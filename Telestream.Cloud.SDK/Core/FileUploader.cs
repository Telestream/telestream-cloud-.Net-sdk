using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Exceptions;
using Telestream.Cloud.SDK.Model;
using Newtonsoft.Json;

namespace Telestream.Cloud.SDK.Core
{
    public class FileUploader
    {
        private UploadSession session;
        private Stream main_file;

        private class FileToUpload
        {
            private String name;
            private Stream data;

            private int parts;
            private int part_size;
            private int [] missing_parts;

            FileToUpload(String n, Stream d)
            {
                if (null == n || null == d)
                    throw new ArgumentException("Given file name or stream is null");

                name = n;
                data = d;
            }
        }

        public FileUploader()
        {
        }

        public FileUploader(UploadSession usi, Stream s)
        {
            session = usi;
            main_file = s;
        }

        public static async Task<FileUploader> Init(RestClient rc, RequestFactory rf, string factoryId, Stream dataStream, string fileName, CancellationToken cancelToken = default(CancellationToken))
        {
            const string FILE_SIZE = "file_size";
            const string FILE_NAME = "file_name";

            var request = rf.Post(
                "videos/upload.json",
                new QueryParamList()
                    .Add(FILE_SIZE, dataStream.Length.ToString())
                    .Add(FILE_NAME, fileName)
                    .Add("multi_chunk", "true"),
                factoryId);

            var s = await rc.Invoke<UploadSession>(request, cancelToken);

            return new FileUploader(s, dataStream);
        }

        public Task<Video> UploadFile(UploadSession sess, Stream dataStream)
        {
            session = sess;
            main_file = dataStream;

            return this.UploadFile(null, new CancellationToken());
        }

        public Task<Video> UploadFile()
        {
            return UploadFile(null);
        }

        public Task<Video> UploadFile(CancellationToken cancelToken)
        {
            return UploadFile(null, cancelToken);
        }

        public async Task<Video> UploadFile(IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            System.Diagnostics.Debug.WriteLine("Parts: {0}", session.Parts);
            System.Diagnostics.Debug.WriteLine("Part Size: {0}", session.Part_Size);
            System.Diagnostics.Debug.WriteLine("Max Connections: {0}", session.Max_Connections);
            if (main_file == null)
            {
                throw new ArgumentNullException("dataStream");
            }

            byte[] buffer = new byte[session.Part_Size];

            var httpClient = new HttpClient();
                        Video video = null;
            for (int i=0; i<session.Parts; ++i)
            {
                int bytesRead;
                if ((bytesRead = main_file.Read(buffer, 0, buffer.Length)) > 0)
                {
                    var message = CreateChunkMessage(i, buffer, bytesRead, session.Location);
                    var response = await SendMessage(httpClient, message, cancelToken);

                    if (progress != null)
                    {
                        progress.Report((main_file.Position / (double)main_file.Length) * 100);
                    }

                    if (cancelToken.IsCancellationRequested)
                    {
                        break;
                    }

                    if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        string body = await response.Content.ReadAsStringAsync();

                        video = ParseJson(body);
                    }
                }
            }
            return video;
        }

        public async Task ResumeUpload(Stream dataStream)
        {
//            var position = await GetBrokenUpload(dataStream, session.Location);
//            await ResumeUpload(session, position, dataStream, null);
        }

        public async Task ResumeUpload(Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            if (session == null) { throw new ArgumentNullException("session"); }

//            var position = await GetBrokenUpload(dataStream, session.Location);
//            await ResumeUpload(session, position, dataStream, progress, cancelToken);
        }

        public async Task AbortUpload(CancellationToken cancelToken = default(CancellationToken))
        {
            var message = new HttpRequestMessage(HttpMethod.Delete, session.Location);
            await SendMessage(message, cancelToken);
        }

//        public async Task<long> GetBrokenUpload(int part_id, string location)
//        {
//            var message = new HttpRequestMessage(HttpMethod.Put, location);
//            message.Content = CreateMessageContent(part_id, new byte[0]);
//
//            var response = await SendMessage(message);
//
//            var result = GetPosition(response);
//            return result;
//        }

        private HttpRequestMessage CreateChunkMessage(int part_id, byte[] bytes, int bytesToSend, string location)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, location);
            message.Headers.Add("Cache-Control", "no-cache");

            message.Content = new ByteArrayContent(bytes, 0, bytesToSend);
            message.Content.Headers.Add("Content-Type", "application/octet-stream");
            message.Content.Headers.Add("X-Part", part_id.ToString());

            return message;
        }

        private Task<HttpResponseMessage> SendMessage(HttpRequestMessage message, CancellationToken cancelToken = default(CancellationToken))
        {
            var client = new HttpClient();
            return SendMessage(client, message, cancelToken);
        }

        private Task<HttpResponseMessage> SendMessage(HttpClient client, HttpRequestMessage message, CancellationToken cancelToken = default(CancellationToken))
        {
            try
            {
                return client.SendAsync(message, cancelToken);
            }
            catch (Exception ex)
            {
                throw new TelestreamCloudException("Unable to complete request", ex);
            }
        }

        private string ExtractFromHeader(HttpResponseMessage response)
        {
            const string RANGE_KEY = "Range";
            if (!response.Headers.Contains(RANGE_KEY))
            {
                throw new TelestreamCloudException(string.Format("'{0}' header not found", RANGE_KEY));
            }

            return response.Headers.GetValues(RANGE_KEY).First();
        }

        private Video ParseJson(string body)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(body));

            JsonSerializer serializer = new JsonSerializer();
            Video video = serializer.Deserialize<Video>(reader);
            return video;
        }
    }
}
