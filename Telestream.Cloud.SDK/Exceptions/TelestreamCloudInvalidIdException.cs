using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Exceptions
{
	public class TelestreamCloudInvalidIdException : TelestreamCloudException
	{
		public TelestreamCloudInvalidIdException(string entityName)
			: base(string.Format("{0} is not valid", entityName))
		{

		}
	}
}
