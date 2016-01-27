using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Exceptions
{
	public class TelestreamCloudException : Exception
	{
		public TelestreamCloudException()
		{

		}

		public TelestreamCloudException(string message)
			: base(message)
		{

		}

		public TelestreamCloudException(string message, Exception innerException)
			: base(message, innerException)
		{

		}
	}
}
