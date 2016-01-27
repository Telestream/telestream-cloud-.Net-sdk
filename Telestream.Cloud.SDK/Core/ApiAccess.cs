using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Core
{
	public class ApiAccess
	{
		public ApiAccess()
		{
			Host = "api.cloud.telestream.net";
			Version = "3.0";
			Port = 443;
		}

		public ApiAccess(string accessKey, string secretKey)
			: this()
		{
			AccessKey = accessKey;
			SecretKey = secretKey;
		}

		public ApiAccess(string accessKey, string secretKey, string host, string version, int port)
			: this(accessKey, secretKey)
		{
			Host = host;
			Version = version;
			Port = port;
		}

		public string AccessKey { get; set; }
		public string SecretKey { get; set; }
		public string Version { get; set; }
		public string Host { get; set; }
		public int Port { get; set; }
	}
}
