using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Core;

namespace Telestream.Cloud.SDK
{
	public class TelestreamCloudConfig
	{
		public static void Initialize(string accessKey, string secretKey)
		{
			lock (padlock)
			{
				Credentials = new ApiAccess(accessKey, secretKey);
			}
		}
		
		public static void Initialize(string accessKey, string secretKey, string hostname, string version, int port ) 
		{
			lock (padlock)
			{
				Credentials = new ApiAccess(accessKey, secretKey, hostname, version, port);
			}
		}

		private static object padlock = new object();

		public static ApiAccess Credentials { get; private set; }
	}
}
