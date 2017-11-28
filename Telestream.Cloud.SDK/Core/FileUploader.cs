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
		public FileUploader()
		{
		}

		public async Task<Video> UploadFile(UploadSession session, Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
		{
			if (dataStream == null)
			{
				throw new ArgumentNullException("dataStream");
			}

			byte[] buffer = new byte[session.PartSize];

			var httpClient = new HttpClient();
			Video video = null;

			for (var i = session.LastUploadedPart + 1; i < session.Parts; i++)
			{
				int bytesRead;
				if ((bytesRead = dataStream.Read(buffer, 0, buffer.Length)) > 0)
				{
					var message = CreateChunkMessage(i, buffer, bytesRead, session.Location);
					var response = await SendMessage(httpClient, message, cancelToken);

					if (progress != null)
					{
						progress.Report((dataStream.Position / (double)dataStream.Length) * 100);
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
					session.LastUploadedPart = i;
				}
			}
			return video;
		}

		public Task ResumeUpload(UploadSession session, Stream dataStream, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken))
		{
			return UploadFile(session, dataStream, progress, cancelToken);
		}

		public async Task AbortUpload(UploadSession session, CancellationToken cancelToken = default(CancellationToken))
		{
			if (session == null) { throw new ArgumentNullException("session"); }
			var message = new HttpRequestMessage(HttpMethod.Delete, session.Location);
			await SendMessage(message, cancelToken);
		}

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
