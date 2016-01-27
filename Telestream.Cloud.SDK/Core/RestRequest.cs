using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Core
{
	public class RestRequest
	{
		public string UserAgent { get; set; }
		public string ApiHost { get; set; }
		public int ApiPort { get; set; }
		public string ApiVersion { get; set; }
		public RestMethod Method { get; set; }
		public string Endpoint { get; set; }
		public string FactoryId { get; set; }
		public string AccessKey { get; set; }
		public string SecretKey { get; set; }
		public DateTime TimeStamp { get; set; }
		public List<QueryParam> Params { get; set; }
		public Uri Query
		{
			get
			{
				return new Uri(ApiHostWithPort, Endpoint);
			}
		}

		public Uri ApiHostWithPort
		{
			get
			{
				var protocol = ApiPort == 443 ? "https://" : "http://";
				var port = ApiPort == 80 || ApiPort <= 0 ? string.Empty : string.Concat(":", ApiPort);

				return new Uri(string.Concat(protocol, ApiHost, port));
			}
		}

		public Uri ApiHostWithVersion
		{
			get
			{
				return new Uri(ApiHostWithPort, string.Concat("/v", ApiVersion, "/"));
			}
		}

		public Uri ApiHostWithEndpoint
		{
			get
			{
				return new Uri(ApiHostWithVersion, EndpointName);
			}
		}

		public string EndpointName
		{
			get
			{
				var separatorIndex = Endpoint.IndexOf('?');
				if (separatorIndex <= 0) { return Endpoint; }
				return Endpoint.Substring(0, separatorIndex);
			}
		}

		public bool HasData
		{
			get { return Method == RestMethod.Post || Method == RestMethod.Put; }
		}

		public object Data { get; set; }

		public override string ToString()
		{
			var desc = new StringBuilder();
			desc.Append(Method);
			desc.Append(" ");
			desc.Append(ApiHostWithEndpoint);
			return desc.ToString();
		}
	}
}
