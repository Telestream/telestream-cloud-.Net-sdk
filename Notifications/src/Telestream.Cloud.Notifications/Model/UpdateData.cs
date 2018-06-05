/* 
 * Notifications API
 *
 * Notifications API
 *
 * OpenAPI spec version: 2.0.0
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
    /// UpdateData
    /// </summary>
    [DataContract]
    public partial class UpdateData :  IEquatable<UpdateData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateData" /> class.
        /// </summary>
        /// <param name="Topic">Topic.</param>
        /// <param name="_Params">_Params.</param>
        public UpdateData(UpdateTopic Topic = default(UpdateTopic), ModelParams _Params = default(ModelParams))
        {
            this.Topic = Topic;
            this._Params = _Params;
        }
        
        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public UpdateTopic Topic { get; set; }

        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public ModelParams _Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateData {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
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
            return this.Equals(input as UpdateData);
        }

        /// <summary>
        /// Returns true if UpdateData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this._Params == input._Params ||
                    (this._Params != null &&
                    this._Params.Equals(input._Params))
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
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
                return hashCode;
            }
        }
    }

}
