using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Exceptions;

namespace Telestream.Cloud.SDK.Core
{
        public class DataSerializer : IDataSerializer
        {
                public TResult Deserialize<TResult>(string value)
                {
                        try
                        {
                            var settings = new JsonSerializerSettings();
                            settings.NullValueHandling = NullValueHandling.Ignore;

                            return JsonConvert.DeserializeObject<TResult>(value, settings);
                        }
                        catch (JsonException ex)
                        {
                                throw new TelestreamCloudInvalidDataException(ex.Message, ex);
                        }
                }


                public string Serialize(object data)
                {
                        try
                        {
                                return JsonConvert.SerializeObject(data);
                        }
                        catch (JsonException ex)
                        {
                                throw new TelestreamCloudInvalidDataException(ex.Message, ex);
                        }
                }
        }
}
