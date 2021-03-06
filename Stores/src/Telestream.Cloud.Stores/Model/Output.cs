/* 
 * API
 *
 * API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Telestream.Cloud.Stores.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Stores.Model
{
    /// <summary>
    /// Output
    /// </summary>
    [DataContract]
    public partial class Output :  IEquatable<Output>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Output" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="PathFormat">PathFormat.</param>
        /// <param name="StoreId">StoreId.</param>
        /// <param name="ServiceId">ServiceId.</param>
        /// <param name="ServiceName">ServiceName.</param>
        public Output(string Id = default(string), string PathFormat = default(string), string StoreId = default(string), string ServiceId = default(string), string ServiceName = default(string))
        {
            this.Id = Id;
            this.PathFormat = PathFormat;
            this.StoreId = StoreId;
            this.ServiceId = ServiceId;
            this.ServiceName = ServiceName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PathFormat
        /// </summary>
        [DataMember(Name="path_format", EmitDefaultValue=false)]
        public string PathFormat { get; set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="store_id", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name="service_id", EmitDefaultValue=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name="service_name", EmitDefaultValue=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Output {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PathFormat: ").Append(PathFormat).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
            return this.Equals(input as Output);
        }

        /// <summary>
        /// Returns true if Output instances are equal
        /// </summary>
        /// <param name="input">Instance of Output to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Output input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PathFormat == input.PathFormat ||
                    (this.PathFormat != null &&
                    this.PathFormat.Equals(input.PathFormat))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PathFormat != null)
                    hashCode = hashCode * 59 + this.PathFormat.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
