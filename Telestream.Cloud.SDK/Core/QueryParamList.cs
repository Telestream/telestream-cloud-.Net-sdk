using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Core
{
	[ComVisible(false)]
	public class QueryParamList : List<QueryParam>
	{
		public QueryParamList() { }
		public QueryParamList(IEnumerable<QueryParam> collection) : base(collection) { }

		public QueryParamList Add(string key, string value)
		{
			Add(new QueryParam(key, value));
			return this;
		}

		public static QueryParamList New()
		{
			return new QueryParamList();
		}

		public string Concat()
		{
			const string SEPARATOR = "&";
			const string FORMAT = "{0}={1}";
			var result = string.Join(SEPARATOR, this.Select(x => string.Format(FORMAT, x.Key, x.Value)));
			return result;
		}

		public void SortByKey()
		{
			Sort((x, y) => string.Compare(x.Key, y.Key));
		}

		public QueryParamList AddNonEmpty<T>(string key, Nullable<T> value) where T : struct
		{
			if (value.HasValue)
			{
				AddNonEmpty(key, value.Value.ToString());
			}
			return this;
		}


		public QueryParamList AddNonEmpty(string key, bool? value)
		{
			return AddNonEmpty<bool>(key, value);
		}

		public QueryParamList AddNonEmpty(string key, int? value)
		{
			return AddNonEmpty<int>(key, value);
		}

		public QueryParamList AddNonEmpty(string key, int value)
		{
			return AddNonEmpty(key, value.ToString());
		}

		public QueryParamList AddNonEmpty(string key, string value)
		{
			if (!string.IsNullOrWhiteSpace(value))
			{
				return Add(key, value);
			}
			return this;
		}
	}
}
