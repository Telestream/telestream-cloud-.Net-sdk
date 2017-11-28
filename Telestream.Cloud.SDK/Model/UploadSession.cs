using Newtonsoft.Json;
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

		[JsonProperty("location")]
		public string Location { get; set; }
		[JsonProperty("parts")]
		public long Parts { get; set; }
		[JsonProperty("part_size")]
		public long PartSize { get; set; }
		[JsonProperty("max_connections")]
		public long MaxConnections { get; set; }

		public int LastUploadedPart { get; set; } = -1;
	}
}
