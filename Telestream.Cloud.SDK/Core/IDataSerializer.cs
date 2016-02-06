using System;
namespace Telestream.Cloud.SDK.Core
{
	public interface IDataSerializer
	{
		TResult Deserialize<TResult>(string value);
		string Serialize(object data);
	}
}
