using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Exceptions;
using Telestream.Cloud.SDK.Model;
using Newtonsoft.Json;

namespace Telestream.Cloud.SDK.Core
{
    public class FileUploader
    {
        public FileUploader()
        {
            _rangeHeaderRegex = new Regex(@"^\d-(?<position>\d*)$");
        }

        private const int CHUNK_SIZE = 5 * 1024 * 1024;
        private readonly Regex _rangeHeaderRegex;

        public Task<Video> UploadFile(UploadSession session, long position, Stream dataStream)
        {
            return UploadFile(session, position, dataStream, null);
        }

        public Task<Video> UploadFile(UploadSession session, Stream dataStream)
        {
            return UploadFile(session, dataStream, null);
        }

        public Task<Video> UploadFile(UploadSession session, Stream dataStream, IProgress<double> progress)
        {
            return UploadFile(session, 0, dataStream, progress);
        }


        public Task<Video> UploadFile(UploadSession session, Stream dataStream, CancellationToken cancelToken)
        {
            return UploadFile(session, 0, dataStream, null, cancelToken);
        }

        public async Task<Video> UploadFile(UploadSession session, long position, Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            if (dataStream == null)
            {
                throw new ArgumentNullException("dataStream");
            }

            byte[] buffer = new byte[CHUNK_SIZE];

            var httpClient = new HttpClient();

            dataStream.Seek(position, SeekOrigin.Begin);
            int readed = 0;

            while ((readed = dataStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                System.Diagnostics.Debug.WriteLine("Content-Lenght:{0}", CHUNK_SIZE.ToString());
                System.Diagnostics.Debug.WriteLine("Content-Range: {0}", string.Format("bytes {0}-{1}/{2}", position, dataStream.Position - 1, dataStream.Length));

                var message = CreateChunkMessage(position, dataStream.Position - 1, dataStream.Length, buffer, session.Location);

                var response = await SendMessage(httpClient, message, cancelToken);

                position = dataStream.Position;

                if (progress != null)
                {
                    progress.Report((position / (double)dataStream.Length) * 100);
                }

                if (cancelToken.IsCancellationRequested)
                {
                    break;
                }

                if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    string body = await response.Content.ReadAsStringAsync();

                    return ParseJson(body);
                }
            }

            return null;
        }

        public Task ResumeUpload(UploadSession session, long position, Stream dataStream)
        {
            return ResumeUpload(session, position, dataStream, null);
        }

        public async Task ResumeUpload(UploadSession session, Stream dataStream)
        {
            var position = await GetBrokenUpload(dataStream, session.Location);
            await ResumeUpload(session, position, dataStream, null);
        }

        public async Task ResumeUpload(UploadSession session, Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            if (session == null) { throw new ArgumentNullException("session"); }

            var position = await GetBrokenUpload(dataStream, session.Location);
            await ResumeUpload(session, position, dataStream, progress, cancelToken);
        }

        public Task ResumeUpload(UploadSession session, long position, Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            return UploadFile(session, position, dataStream, progress, cancelToken);
        }

        public async Task AbortUpload(UploadSession session, CancellationToken cancelToken = default(CancellationToken))
        {
            var message = new HttpRequestMessage(HttpMethod.Delete, session.Location);
            await SendMessage(message, cancelToken);
        }

        public async Task<long> GetBrokenUpload(Stream dataStream, string location)
        {
            if (dataStream == null) { throw new ArgumentNullException("dataStream"); }

            var message = new HttpRequestMessage(HttpMethod.Put, location);
            message.Content = CreateMessageContent(string.Format("bytes */{0}", dataStream.Length), new byte[0]);

            var response = await SendMessage(message);

            var result = GetPosition(response);
            return result;
        }

        private HttpRequestMessage CreateChunkMessage(long from, long to, long totalLength, byte[] bytes, string location)
        {
            var message = new HttpRequestMessage(HttpMethod.Put, location);
            message.Headers.Add("Cache-Control", "no-cache");

            var content = CreateMessageContent(string.Format("bytes {0}-{1}/{2}", from, to, totalLength), bytes);
            message.Content = content;

            return message;
        }

        private HttpContent CreateMessageContent(string contentRange, byte[] bytes)
        {
            var content = new ByteArrayContent(bytes);
            content.Headers.Add("Content-Range", contentRange);
            content.Headers.Add("Content-Type", "application/octet-stream");
            return content;
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

        private long GetPosition(HttpResponseMessage response)
        {
            var headerValue = ExtractFromHeader(response);
            return GetPosition(headerValue);
        }

        private long GetPosition(string headerValue)
        {
            var match = _rangeHeaderRegex.Match(headerValue);

            if (!match.Success)
            {
                throw new TelestreamCloudException("Invalid range");
            }

            return long.Parse(match.Groups["position"].Value);
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
