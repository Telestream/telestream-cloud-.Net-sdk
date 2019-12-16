using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;
using Telestream.Cloud.Flip.Model;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Api;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RestSharp;

namespace Telestream.Cloud.Flip.Client
{
    public class PartStream : Stream
    {
        private Stream stream;
        private long len;
        public override bool CanSeek
        {
            get { return this.stream.CanSeek; }
        }

        public override bool CanRead
        {
            get { return this.stream.CanRead; }
        }

        public override bool CanWrite
        {
            get { return this.stream.CanWrite; }
        }

        public override long Position
        {
            get { return this.stream.Position; }
            set { this.stream.Position = value; }
        }

        public override long Length
        {
            get { return this.len; }
        }

        public PartStream(Stream stream, long position, long length)
        {
            this.stream = stream;
            if (this.stream.Length < length)
            {
                this.len = this.stream.Length;
            }
            else
            {
                this.len = length;
            }
            this.stream.Position = position;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return this.stream.Seek(offset, origin);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            this.stream.Write(buffer, offset, count);
        }

        public override void Flush()
        {
            this.stream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {


            var _count = count;
            if ((count + this.Position) > this.len)
            {
                _count = (int)(this.len - this.Position);
            }
            return this.stream.Read(buffer, offset, _count);
        }

        public override void SetLength(long value)
        {
            this.stream.SetLength(value);
        }
    }

    public class FileUploaderBase
    {
        protected FlipApi _apiClient;
        public string MediaId;

        public FileUploaderBase(FlipApi apiClient)
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
            var retries = 3;

            do
            {
                if (retries == 0)
                    break;

                --retries;
            } while (!(await upload(filePath, location, tag, partSize, parts, connections, progress, cancelToken))) ;
        }
        private async Task<bool> upload(string filePath, string location, string tag, int partSize, int parts, int connections, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken))
        {
            var tasks = new List<Task<HttpResponseMessage> >();
            var missingParts = await GetMissingParts(location, tag);
            var uploaded = parts - missingParts.Length;

            foreach (var chunkIndex in missingParts)
            {

                if (tasks.Count == connections)
                {
                    try
                    {
                        var id = Task.WaitAny(tasks.ToArray(), cancelToken);
                        try
                        {
                            if (tasks[id].IsCompleted && tasks[id].Result.IsSuccessStatusCode)
                            {
                                uploaded++;
                            }

                        } catch (System.AggregateException e)
                        {
                        } catch (System.Net.Http.HttpRequestException e)
                        {
                        }

                        tasks.Remove(tasks[id]);

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

                 tasks.Add(SendMessage(CreateMessage(filePath, location, tag, chunkIndex, partSize)));
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

        private HttpRequestMessage CreateChunkMessage(int partId, byte[] bytes, int bytesToSend, string location, string tag)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, location);

            message.Headers.Add("Cache-Control", "no-cache");
            message.Content = new ByteArrayContent(bytes, 0, bytesToSend);
            message.Content.Headers.Add("Content-Type", "application/octet-stream");
            message.Content.Headers.Add("X-Part", partId.ToString());

            if (!string.IsNullOrEmpty(tag))
            {
                message.Content.Headers.Add("X-Extra-File-Tag", tag);
            }

            return message;
        }

        private HttpRequestMessage CreateMessage(string filePath, string location, string tag, long partId, long partSize)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, location);
            var fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            message.Headers.Add("Cache-Control", "no-cache");

            message.Content = new StreamContent(new PartStream(fileStream, partId * partSize, (partId + 1) * partSize),
                                                32 * 1024);
            message.Content.Headers.Add("Content-Type", "application/octet-stream");
            message.Content.Headers.Add("X-Part", partId.ToString());

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
            request.JsonSerializer = null;
            var restClient = new RestClient(location);
            if (!string.IsNullOrEmpty(tag))
            {
                request.AddHeader("X-Extra-File-Tag", tag);
            }
            var response = await restClient.ExecuteTaskAsync(request);
            var parsed = (MissingPartsResponse)_apiClient.Configuration.ApiClient.Deserialize(response, typeof(MissingPartsResponse));
            return parsed.MissingParts;
        }

        private async Task<string> GetMediaId(string location)
        {
            var request = new RestRequest(location, Method.GET);
            request.JsonSerializer = null;
            var restClient = new RestClient(location);
            var response = await restClient.ExecuteTaskAsync(request);
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
