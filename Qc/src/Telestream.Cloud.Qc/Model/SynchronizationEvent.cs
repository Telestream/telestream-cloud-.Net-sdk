/* 
 * Qc API
 *
 * QC API
 *
 * OpenAPI spec version: 2.0.3
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
using SwaggerDateConverter = Telestream.Cloud.Qc.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Qc.Model
{
    /// <summary>
    /// SynchronizationEvent
    /// </summary>
    [DataContract]
    public partial class SynchronizationEvent :  IEquatable<SynchronizationEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizationEvent" /> class.
        /// </summary>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Skew">Skew.</param>
        /// <param name="Result">Result.</param>
        public SynchronizationEvent(string Timestamp = default(string), int? Skew = default(int?), string Result = default(string))
        {
            this.Timestamp = Timestamp;
            this.Skew = Skew;
            this.Result = Result;
        }
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Skew
        /// </summary>
        [DataMember(Name="skew", EmitDefaultValue=false)]
        public int? Skew { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SynchronizationEvent {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Skew: ").Append(Skew).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as SynchronizationEvent);
        }

        /// <summary>
        /// Returns true if SynchronizationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SynchronizationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SynchronizationEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Skew == input.Skew ||
                    (this.Skew != null &&
                    this.Skew.Equals(input.Skew))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Skew != null)
                    hashCode = hashCode * 59 + this.Skew.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }

}
