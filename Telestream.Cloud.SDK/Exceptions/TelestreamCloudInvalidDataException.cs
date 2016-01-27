using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Exceptions
{
	public class TelestreamCloudInvalidDataException : TelestreamCloudException
	{
		public TelestreamCloudInvalidDataException(string message, Exception innerException)
			: base(message, innerException)
		{

		}
	}
}
