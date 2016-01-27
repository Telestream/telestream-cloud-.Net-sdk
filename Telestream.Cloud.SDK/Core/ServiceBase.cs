using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Exceptions;

namespace Telestream.Cloud.SDK.Core
{
	public abstract class ServiceBase
	{
		protected RestClient _client;
		protected RequestFactory _requestFactory;
		protected ApiAccess _apiAccess;

		public ServiceBase()
			: this(TelestreamCloudConfig.Credentials)
		{

		}

		public ServiceBase(ApiAccess apiAccess)
		{
			Initialize(apiAccess);
		}

		public ServiceBase(IConfigurationService configuration)
		{
			if (configuration == null) { throw new ArgumentNullException("configuration"); }

			var apiAccess = configuration.Get();

			Initialize(apiAccess);
		}

		protected virtual void Initialize(ApiAccess apiAccess)
		{
			if (apiAccess == null) { throw new ArgumentNullException("apiAccess"); }

			_apiAccess = apiAccess;
			_requestFactory = new RequestFactory(apiAccess);
			_client = new RestClient();
		}

		public void ValidateId(string entityName, string id)
		{
			if (string.IsNullOrWhiteSpace(id))
			{
				throw new TelestreamCloudInvalidIdException(entityName);
			}
		}

		protected virtual void ValidateFactoryId(string value)
		{
			ValidateId("factoryId", value);
		}

		protected virtual void ValidateVideoId(string value)
		{
			ValidateId("videoId", value);
		}

		protected virtual Task InvokeDelete(string factoryId, string endpoint)
		{
			ValidateFactoryId(factoryId);

			var request = _requestFactory.Delete(endpoint, factoryId);
			return _client.Invoke(request);
		}

		public Task<T> InvokePut<T>(string factoryId, string endpoint, object data)
		{
			ValidateFactoryId(factoryId);
			var request = _requestFactory.PutJson(endpoint, data, factoryId);
			return _client.Invoke<T>(request);
		}

		public Task<T> InvokePost<T>(string factoryId, string endpoint, object data)
		{
			ValidateFactoryId(factoryId);
			var request = _requestFactory.Post(endpoint, data, factoryId);
			return _client.Invoke<T>(request);
		}

		public Task<T> InvokePost<T>(string factoryId, string endpoint, QueryParamList param)
		{
			ValidateFactoryId(factoryId);
			var request = _requestFactory.Post(endpoint, param, factoryId);
			return _client.Invoke<T>(request);
		}

		public Task<T> InvokeGet<T>(string factoryId, string endpoint, QueryParamList param = null)
		{
			ValidateFactoryId(factoryId);

			var request = _requestFactory.Get(endpoint, param, factoryId);
			return _client.Invoke<T>(request);
		}
	}
}
