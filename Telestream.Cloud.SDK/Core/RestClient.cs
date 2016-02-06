using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Core;
using Telestream.Cloud.SDK.Exceptions;

namespace Telestream.Cloud.SDK.Core
{
	public class RestClient
	{
		private IDataSerializer _serializer;
		private HttpClient _client;
		private SecurityUtility _security;

		public RestClient()
		{
			_serializer = new DataSerializer();
			_security = new SecurityUtility();
		}

		public async Task<string> Invoke(RestRequest request)
		{
			if (request == null) { throw new ArgumentNullException("request"); }

			var client = CreateClient(request);
			var message = CreateMessage(request);

			if (message.Content != null)
			{
				var i = await message.Content.ReadAsStringAsync();
			}

			var response = await client.SendAsync(message);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				return content;
			}
			else
			{
				try
				{
					response.EnsureSuccessStatusCode();
					return null;
				}
				catch (HttpRequestException ex)
				{
					if (response.StatusCode == HttpStatusCode.Unauthorized)
					{
						throw new TelestreamCloudAccessDeniedException();
					}
					throw new TelestreamCloudException(string.Format("Unable to call api endpoint: {0}", request.ApiHostWithEndpoint), ex);
				}
			}
		}

		public async Task<TResult> Invoke<TResult>(RestRequest request)
		{
			if (request == null) { throw new ArgumentNullException("request"); }

			string content = await Invoke(request);
			var deserialized = _serializer.Deserialize<TResult>(content);
			return deserialized;
		}

		private HttpClient CreateClient(RestRequest request)
		{
			if (_client == null)
			{
				_client = new HttpClient();
			}

			if (!string.IsNullOrEmpty(request.UserAgent))
			{
				_client.DefaultRequestHeaders.Add("User-Agent", request.UserAgent);
			}

			return _client;
		}

		private HttpRequestMessage CreateMessage(RestRequest request)
		{
			var authParameters = _security.GenerateAuthParameters(request);
			authParameters.AddRange(HttpUtility.ParseQueryString(request.Query));

			if (request.Params != null)
			{
				var d = request.Params.Select(x => new QueryParam(x.Key, Uri.EscapeDataString(x.Value)));
				authParameters.AddRange(d);
			}

			authParameters.SortByKey();

			var signature = _security.GenerateSignature(request, authParameters);

			authParameters.Add("signature", Uri.EscapeDataString(signature));

			var endpoint = GetUrl(request, authParameters);

			var message = new HttpRequestMessage(GetMethod(request.Method), endpoint);
			message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			message.Headers.ExpectContinue = false;
			if (request.HasData)
			{
				message.Content = CreateContent(request, authParameters);
			}

			return message;
		}

		private HttpContent CreateContent(RestRequest request, QueryParamList authParameters)
		{
			if (request.Data == null)
			{
				var dataToSend = authParameters.Concat();

				var content = new ByteArrayContent(Encoding.UTF8.GetBytes(dataToSend));
				content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
				return content;
			}
			else
			{
				var json = _serializer.Serialize(request.Data);
				var content = new ByteArrayContent(Encoding.UTF8.GetBytes(json));
				content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
				return content;
			}
		}

		private string GetUrl(RestRequest request, QueryParamList authParameters)
		{
			//if (request.HasData)
			//{
			//	return request.ApiHostWithEndpoint.ToString();
			//}

			return string.Concat(request.ApiHostWithEndpoint, "?", authParameters.Concat());
		}

		private HttpMethod GetMethod(RestMethod method)
		{
			switch (method)
			{
				case RestMethod.Get: return HttpMethod.Get;
				case RestMethod.Post: return HttpMethod.Post;
				case RestMethod.Put: return HttpMethod.Put;
				case RestMethod.Delete: return HttpMethod.Delete;
				default: return HttpMethod.Get;
			}
		}
	}
}
