using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class UploadSession : ModelBase
	{
		public string Id { get; set; }
		public string Location { get; set; }
		public long Parts { get; set; }
		public long Part_Size { get; set; }
		public long Max_Connections { get; set; }
	}
}
