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
    /// CountResponse
    /// </summary>
    [DataContract]
    public partial class CountResponse :  IEquatable<CountResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountResponse" /> class.
        /// </summary>
        /// <param name="Total">Informs how many objects are stored in the database..</param>
        public CountResponse(int? Total = default(int?))
        {
            this.Total = Total;
        }
        
        /// <summary>
        /// Informs how many objects are stored in the database.
        /// </summary>
        /// <value>Informs how many objects are stored in the database.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountResponse {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as CountResponse);
        }

        /// <summary>
        /// Returns true if CountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }

}
