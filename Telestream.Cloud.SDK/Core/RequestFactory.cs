using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Core
{
	public class RequestFactory
	{
		private ApiAccess _apiAccess;
		public RequestFactory(ApiAccess apiAccess)
		{
			_apiAccess = apiAccess;
		}

		public RequestFactory(IConfigurationService configurationService)
		{
			_apiAccess = configurationService.Get();
		}

		public RestRequest Post(string endpoint, object data, string factoryId)
		{
			var request = CreateRequest(RestMethod.Post, endpoint, data: data, factoryId: factoryId);
			return request;
		}

		public RestRequest Post(string endpoint, QueryParamList parameters, string factoryId)
		{
			var request = CreateRequest(RestMethod.Post, endpoint, parameters: parameters, factoryId: factoryId);
			return request;
		}

		public RestRequest PostJson(string endpoint, object data)
		{
			var request = CreateRequest(RestMethod.Post, endpoint, data: data);
			return request;
		}

		public RestRequest Put(string endpoint, QueryParamList parameters)
		{
			var request = CreateRequest(RestMethod.Put, endpoint, parameters: parameters);
			return request;
		}

		public RestRequest PutJson(string endpoint, object data, string factoryId)
		{
			var request = CreateRequest(RestMethod.Put, endpoint, data, factoryId: factoryId);
			return request;
		}

		public RestRequest Get(string endpoint)
		{
			var request = Get(endpoint, null);
			return request;
		}

		public RestRequest Get(string endpoint, string factoryId)
		{
			var request = CreateRequest(RestMethod.Get, endpoint, factoryId: factoryId);
			return request;
		}

		public RestRequest Delete(string endpoint, string factoryId)
		{
			var request = CreateRequest(RestMethod.Delete, endpoint, factoryId: factoryId);
			return request;
		}

		public RestRequest Get(string endpoint, QueryParamList parameters = null, string factoryId = null)
		{
			var request = CreateRequest(RestMethod.Get, endpoint, parameters: parameters, factoryId: factoryId);
			return request;
		}

		private RestRequest CreateRequest(RestMethod method, string endpoint, object data = null, QueryParamList parameters = null, string factoryId = null)
		{
			var access = _apiAccess;

			var request = new RestRequest();
			request.Method = method;
			request.Endpoint = endpoint;
			request.TimeStamp = DateTime.Now;
			request.FactoryId = factoryId;
			request.Data = data;
			request.Params = parameters;
			request.ApiHost = access.Host;
			request.ApiVersion = access.Version;
			request.ApiPort = access.Port;
			request.AccessKey = access.AccessKey;
			request.SecretKey = access.SecretKey;

			return request;
		}


	}
}
