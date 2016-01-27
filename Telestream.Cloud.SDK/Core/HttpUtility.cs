using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Core
{
	public static class HttpUtility
	{
		public static List<QueryParam> ParseQueryString(Uri uri)
		{
			var query = uri.Query.Substring(uri.Query.IndexOf('?') + 1); // +1 for skipping '?'
			var pairs = query.Split('&');
			return pairs
				.Select(o => o.Split('='))
				.Where(items => items.Count() == 2)
				.Select(x => new QueryParam
				{
					Key = Uri.UnescapeDataString(x[0]),
					Value = Uri.UnescapeDataString(x[1])
				}).ToList();
		}

	}

	public class QueryParam
	{
		public QueryParam()
		{

		}

		public QueryParam(string key, string value)
		{
			Key = key;
			Value = value;
		}
		
		public string Key { get; set; }
		public string Value { get; set; }

		public string EncodedValue
		{
			get
			{
				return Uri.EscapeDataString(Value);
			}
		}
	}

}
