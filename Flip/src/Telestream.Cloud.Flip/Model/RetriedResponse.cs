/* 
 * Flip API
 *
 * Description
 *
 * OpenAPI spec version: 2.0.1
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
using SwaggerDateConverter = Telestream.Cloud.Flip.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Flip.Model
{
    /// <summary>
    /// RetriedResponse
    /// </summary>
    [DataContract]
    public partial class RetriedResponse :  IEquatable<RetriedResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetriedResponse" /> class.
        /// </summary>
        /// <param name="Retried">Informs whether an action has been retried successfully..</param>
        public RetriedResponse(bool? Retried = default(bool?))
        {
            this.Retried = Retried;
        }
        
        /// <summary>
        /// Informs whether an action has been retried successfully.
        /// </summary>
        /// <value>Informs whether an action has been retried successfully.</value>
        [DataMember(Name="retried", EmitDefaultValue=false)]
        public bool? Retried { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetriedResponse {\n");
            sb.Append("  Retried: ").Append(Retried).Append("\n");
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
            return this.Equals(input as RetriedResponse);
        }

        /// <summary>
        /// Returns true if RetriedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetriedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetriedResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Retried == input.Retried ||
                    (this.Retried != null &&
                    this.Retried.Equals(input.Retried))
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
                if (this.Retried != null)
                    hashCode = hashCode * 59 + this.Retried.GetHashCode();
                return hashCode;
            }
        }
    }

}