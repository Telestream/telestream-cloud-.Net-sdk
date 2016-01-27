using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Telestream.Cloud.SDK.Core
{
	public class SecurityUtility
	{
		public string GenerateSignature(RestRequest request, QueryParamList parameters)
		{
			if (request == null) { throw new ArgumentNullException("request"); }
			var sb = new StringBuilder();
			sb.Append(Enum.GetName(typeof(RestMethod), request.Method).ToUpperInvariant());
			sb.Append("\n");
			sb.Append(request.ApiHost);
			sb.Append("\n");
			sb.Append("/" + request.EndpointName);
			sb.Append("\n");
			sb.Append(parameters.Concat());
			var toSign = sb.ToString();

			return GetHmacSha256(toSign, request.SecretKey);
		}

		public QueryParamList GenerateAuthParameters(RestRequest request)
		{
			var parameters = new QueryParamList();
			parameters.Add("access_key", request.AccessKey);
			if (!string.IsNullOrEmpty(request.FactoryId))
			{
				parameters.Add("cloud_id", request.FactoryId);
			}
			parameters.Add("timestamp", Uri.EscapeDataString(GetTimestamp(request.TimeStamp)));

			return parameters;
		}

		public string GetTimestamp(DateTime time)
		{
			return time.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss+00:00");
		}

		private string GetHmacSha256(string stringToSign, string secretKey)
		{
			var key = Encoding.UTF8.GetBytes(secretKey);
			var data = Encoding.UTF8.GetBytes(stringToSign);
			var hash = new Sha256Digest();

			HMac hmac = new HMac(hash);

			hmac.Init(new KeyParameter(key, 0, key.Length));

			hmac.BlockUpdate(data, 0, data.Length);

			byte[] abyDigest = new byte[hmac.GetMacSize()];

			int nRet = hmac.DoFinal(abyDigest, 0);

			return System.Convert.ToBase64String(abyDigest); ;
		}

	}
}
