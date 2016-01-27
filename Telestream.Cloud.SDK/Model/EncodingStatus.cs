using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class EncodingStatus
	{
		private string _status;

		public EncodingStatus(string status)
		{
			_status = status;
		}

		public static readonly EncodingStatus Success = new EncodingStatus("success");
		public static readonly EncodingStatus Fail = new EncodingStatus("fail");
		public static readonly EncodingStatus Processing = new EncodingStatus("processing");

		public static implicit operator string(EncodingStatus obj)
		{
			return obj == null ? null : obj._status;
		}

		public static explicit operator EncodingStatus(string obj)
		{
			return new EncodingStatus(obj);
		}

		public override string ToString()
		{
			return _status;
		}
	}
}

