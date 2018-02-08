using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
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

		public FileUploaderBase(QcApi apiClient)
		{
			if (apiClient == null) { throw new ArgumentNullException(nameof(apiClient)); }
			_apiClient = apiClient;
		}

		public async Task UploadFile(string filePath, UploadSession videoSession, ExtraFileItemCollection extraFilesData)
		{

			if (extraFilesData != null)
			{
				extraFilesData.Apply(videoSession);
			}

			await PerformUpload(filePath, videoSession.Location, videoSession.PartSize.Value, null);

			if (extraFilesData != null)
			{
				foreach (var extraFile in extraFilesData)
				{
					await PerformUpload(extraFile.FilePath, videoSession.Location, extraFile.PartSize.Value, extraFile.Tag);
				}
			}
		}

		protected ExtraFileItemCollection PrepareExtraFiles(List<ExtraFileMetadata> extraFiles)
		{
			if (extraFiles == null) { return null; }
			return new ExtraFileItemCollection(extraFiles);
		}

		private async Task PerformUpload(string filePath, string location, int partSize, string tag = null)
		{
			var missingParts = await GetMissingParts(location, tag);

			using (var fileStream = File.Open(filePath, FileMode.Open))
			{
				byte[] buffer = new byte[partSize];
				foreach (var chunkIndex in missingParts)
				{
					await UploadChunk(buffer, location, partSize, fileStream, tag, chunkIndex);
				}
			}
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

		[DataContract]
		protected class MissingPartsResponse
		{
			[DataMember(Name = "missing_parts")]
			public int[] MissingParts { get; set; }
		}

	}
}
