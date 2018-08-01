/* 
 * Notifications API
 *
 * Notifications API V2
 *
 * OpenAPI spec version: 2.1.0
 * Contact: cloudsupport@telestream.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Telestream.Cloud.Notifications.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Notifications.Model
{
    /// <summary>
    /// ModelParams
    /// </summary>
    [DataContract]
    public partial class ModelParams :  IEquatable<ModelParams>
    {
        /// <summary>
        /// (for webhook subscription type);  HTTP method; default: POST (GET, POST) 
        /// </summary>
        /// <value>(for webhook subscription type);  HTTP method; default: POST (GET, POST) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 1,
            
            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 2
        }

        /// <summary>
        /// (for webhook subscription type);  HTTP method; default: POST (GET, POST) 
        /// </summary>
        /// <value>(for webhook subscription type);  HTTP method; default: POST (GET, POST) </value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// (for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded) 
        /// </summary>
        /// <value>(for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {
            
            /// <summary>
            /// Enum Json for value: application/json
            /// </summary>
            [EnumMember(Value = "application/json")]
            Json = 1,
            
            /// <summary>
            /// Enum XWwwFormUrlencoded for value: application/x-www-form-urlencoded
            /// </summary>
            [EnumMember(Value = "application/x-www-form-urlencoded")]
            XWwwFormUrlencoded = 2
        }

        /// <summary>
        /// (for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded) 
        /// </summary>
        /// <value>(for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded) </value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParams" /> class.
        /// </summary>
        /// <param name="Addresses">(for email subscription type);  E-mail addresses .</param>
        /// <param name="Url">(for webhook subscription type);  Webhook URL .</param>
        /// <param name="Method">(for webhook subscription type);  HTTP method; default: POST (GET, POST) .</param>
        /// <param name="Retries">(for webhook subscription type);  Number of retries before forgetting the notification; default: 0 .</param>
        /// <param name="ContentType">(for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded) .</param>
        /// <param name="TopicArn">(for sns subscription type) identifier of an AWS SNS Topic that events will be posted to. .</param>
        /// <param name="RoleArn">(for sns subscription type) identifier of an AWS IAM Role that will be used for authorization. .</param>
        /// <param name="TopicEndpoint">(for aeg subscription type) address of an Azure Event Grid Topic that events will be posted to. .</param>
        /// <param name="AccessKey">(for aeg subscription type) secret access key that authorizes Telestream Cloud to write to an Azure Event Grid Topic. .</param>
        public ModelParams(List<string> Addresses = default(List<string>), string Url = default(string), MethodEnum? Method = default(MethodEnum?), int? Retries = default(int?), ContentTypeEnum? ContentType = default(ContentTypeEnum?), string TopicArn = default(string), string RoleArn = default(string), string TopicEndpoint = default(string), string AccessKey = default(string))
        {
            this.Addresses = Addresses;
            this.Url = Url;
            this.Method = Method;
            this.Retries = Retries;
            this.ContentType = ContentType;
            this.TopicArn = TopicArn;
            this.RoleArn = RoleArn;
            this.TopicEndpoint = TopicEndpoint;
            this.AccessKey = AccessKey;
        }
        
        /// <summary>
        /// (for email subscription type);  E-mail addresses 
        /// </summary>
        /// <value>(for email subscription type);  E-mail addresses </value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// (for webhook subscription type);  Webhook URL 
        /// </summary>
        /// <value>(for webhook subscription type);  Webhook URL </value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// (for webhook subscription type);  Number of retries before forgetting the notification; default: 0 
        /// </summary>
        /// <value>(for webhook subscription type);  Number of retries before forgetting the notification; default: 0 </value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }


        /// <summary>
        /// (for sns subscription type) identifier of an AWS SNS Topic that events will be posted to. 
        /// </summary>
        /// <value>(for sns subscription type) identifier of an AWS SNS Topic that events will be posted to. </value>
        [DataMember(Name="topic_arn", EmitDefaultValue=false)]
        public string TopicArn { get; set; }

        /// <summary>
        /// (for sns subscription type) identifier of an AWS IAM Role that will be used for authorization. 
        /// </summary>
        /// <value>(for sns subscription type) identifier of an AWS IAM Role that will be used for authorization. </value>
        [DataMember(Name="role_arn", EmitDefaultValue=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// (for aeg subscription type) address of an Azure Event Grid Topic that events will be posted to. 
        /// </summary>
        /// <value>(for aeg subscription type) address of an Azure Event Grid Topic that events will be posted to. </value>
        [DataMember(Name="topic_endpoint", EmitDefaultValue=false)]
        public string TopicEndpoint { get; set; }

        /// <summary>
        /// (for aeg subscription type) secret access key that authorizes Telestream Cloud to write to an Azure Event Grid Topic. 
        /// </summary>
        /// <value>(for aeg subscription type) secret access key that authorizes Telestream Cloud to write to an Azure Event Grid Topic. </value>
        [DataMember(Name="access_key", EmitDefaultValue=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelParams {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  TopicArn: ").Append(TopicArn).Append("\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
            sb.Append("  TopicEndpoint: ").Append(TopicEndpoint).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelParams);
        }

        /// <summary>
        /// Returns true if ModelParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.TopicArn == input.TopicArn ||
                    (this.TopicArn != null &&
                    this.TopicArn.Equals(input.TopicArn))
                ) && 
                (
                    this.RoleArn == input.RoleArn ||
                    (this.RoleArn != null &&
                    this.RoleArn.Equals(input.RoleArn))
                ) && 
                (
                    this.TopicEndpoint == input.TopicEndpoint ||
                    (this.TopicEndpoint != null &&
                    this.TopicEndpoint.Equals(input.TopicEndpoint))
                ) && 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.TopicArn != null)
                    hashCode = hashCode * 59 + this.TopicArn.GetHashCode();
                if (this.RoleArn != null)
                    hashCode = hashCode * 59 + this.RoleArn.GetHashCode();
                if (this.TopicEndpoint != null)
                    hashCode = hashCode * 59 + this.TopicEndpoint.GetHashCode();
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                return hashCode;
            }
        }
    }

}
