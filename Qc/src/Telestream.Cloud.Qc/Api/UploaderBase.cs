using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;
using Telestream.Cloud.Qc.Model;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Api;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;

namespace Telestream.Cloud.Qc.Client
{
        public class FileUploaderBase
        {
                protected QcApi _apiClient;
            public string MediaId;

                public FileUploaderBase(QcApi apiClient)
                {
                        if (apiClient == null) { throw new ArgumentNullException(nameof(apiClient)); }
                        _apiClient = apiClient;
                }

                public async Task UploadFile(string filePath, UploadSession videoSession, ExtraFileItemCollection extraFilesData, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
                {
                    var connections = 8;

                    this.MediaId = await GetMediaId(videoSession.Location);

                        if (extraFilesData != null)
                        {
                                extraFilesData.Apply(videoSession);
                        }

                        if (videoSession.MaxConnections.HasValue)
                        {
                                connections = videoSession.MaxConnections.Value;
                        }

                        await PerformUpload(filePath, videoSession.Location, videoSession.PartSize.Value, videoSession.Parts.Value, connections, null, progress, cancelToken);

                        if (extraFilesData != null)
                        {
                                foreach (var extraFile in extraFilesData)
                                {
                                        await PerformUpload(extraFile.FilePath, videoSession.Location, extraFile.PartSize.Value, extraFile.Parts.Value, connections, extraFile.Tag, progress, cancelToken);
                                }
                        }
                }

                protected ExtraFileItemCollection PrepareExtraFiles(List<ExtraFileMetadata> extraFiles)
                {
                        if (extraFiles == null) { return null; }
                        return new ExtraFileItemCollection(extraFiles);
                }

                private async Task PerformUpload(string filePath, string location, int partSize, int parts, int connections = 8, string tag = null, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken))
                {
                        using (var fileStream = File.Open(filePath, FileMode.Open))
                        {
                                var retries = 3;

                                do
                                {
                                        if (retries == 0)
                                                break;

                                        --retries;
                                } while (!(await upload(fileStream, location, tag, partSize, parts, connections, progress, cancelToken))) ;
                        }
                }
            private async Task<bool> upload(FileStream fileStream, string location, string tag, int partSize, int parts, int connections, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken))
            {
                    var tasks = new List<Task>();
                    var uploaded = 0;

                    var missingParts = await GetMissingParts(location, tag);

                    foreach (var chunkIndex in missingParts)
                    {
                        byte[] buffer = new byte[partSize];
                        fileStream.Seek(chunkIndex * partSize, SeekOrigin.Begin);
                        var bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                        var message = CreateChunkMessage(chunkIndex, buffer, bytesRead, location, tag);

                        if (tasks.Count == connections)
                        {
                            try
                            {
                                var id = Task.WaitAny(tasks.ToArray(), cancelToken);
                                tasks.Remove(tasks[id]);
                                uploaded++;

                                if (progress != null)
                                {
                                    progress.Report((uploaded) * 100.0f / parts);
                                }
                            }
                            catch (OperationCanceledException)
                            {
                                return true;
                            }
                        }

                        var task = SendMessage(message);

                        tasks.Add(task);
                    }

                    while (tasks.Count() > 0)
                    {
                        try
                        {
                            var id = Task.WaitAny(tasks.ToArray(), cancelToken);
                            tasks.Remove(tasks[id]);
                            uploaded++;

                            if (progress != null)
                            {
                                progress.Report((uploaded) * 100.0f / parts);
                            }
                        }
                        catch (OperationCanceledException)
                        {
                            return true;
                        }
                    }

                    missingParts = await GetMissingParts(location, tag);
                    if (missingParts.Length == 0)
                        return true;

                    return false;
            }
                public async Task UploadChunk(byte[] buffer, string location, int partSize, Stream dataStream, string tag, int chunkIndex)
                {
                        int bytesRead;
                        var httpClient = new HttpClient();

                        dataStream.Seek(chunkIndex * partSize, SeekOrigin.Begin);

                        if ((bytesRead = dataStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                                var message = CreateChunkMessage(chunkIndex, buffer, bytesRead, location, tag);
                                var response = await SendMessage(httpClient, message);
                        }
                }

                public async Task AbortUpload(UploadSession session)
                {
                        if (session == null) { throw new ArgumentNullException(nameof(session)); }
                        var message = new HttpRequestMessage(HttpMethod.Delete, session.Location);
                        await SendMessage(message);
                }


                private HttpRequestMessage CreateChunkMessage(int part_id, byte[] bytes, int bytesToSend, string location, string tag)
                {
                        var message = new HttpRequestMessage(HttpMethod.Put, location);
                        message.Headers.Add("Cache-Control", "no-cache");

                        message.Content = new ByteArrayContent(bytes, 0, bytesToSend);
                        message.Content.Headers.Add("Content-Type", "application/octet-stream");
                        message.Content.Headers.Add("X-Part", part_id.ToString());

                        if (!string.IsNullOrEmpty(tag))
                        {
                                message.Content.Headers.Add("X-Extra-File-Tag", tag);
                        }

                        return message;
                }

                private Task<HttpResponseMessage> SendMessage(HttpRequestMessage message)
                {
                        var client = new HttpClient();
                        return SendMessage(client, message);
                }

                private Task<HttpResponseMessage> SendMessage(HttpClient client, HttpRequestMessage message)
                {
                        return client.SendAsync(message);
                }

                private async Task<int[]> GetMissingParts(string location, string tag)
                {
                        var request = new RestRequest(location, Method.GET);
                        request.Serializer = null;
                        var restClient = new RestClient(location);
                        if (!string.IsNullOrEmpty(tag))
                        {
                                request.AddHeader("X-Extra-File-Tag", tag);
                        }
                        var response = await restClient.Execute(request);
                        var parsed = (MissingPartsResponse)_apiClient.Configuration.ApiClient.Deserialize(response, typeof(MissingPartsResponse));
                        return parsed.MissingParts;
                }

            private async Task<string> GetMediaId(string location)
            {
                var request = new RestRequest(location, Method.GET);
                request.Serializer = null;
                var restClient = new RestClient(location);
                var response = await restClient.Execute(request);
                var parsed = (MissingPartsResponse)_apiClient.Configuration.ApiClient.Deserialize(response, typeof(MissingPartsResponse));
                return parsed.MediaId;
            }
                [DataContract]
                protected class MissingPartsResponse
                {
                        [DataMember(Name = "missing_parts")]
                        public int[] MissingParts { get; set; }
                        [DataMember(Name = "media_id")]
                        public string MediaId { get; set; }
                }

        }
}
