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
    /// JSON with specific options
    /// </summary>
    [DataContract]
    public partial class Options : Dictionary<String, Object>,  IEquatable<Options>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Options() : base()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as Options);
        }

        /// <summary>
        /// Returns true if Options instances are equal
        /// </summary>
        /// <param name="input">Instance of Options to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }
    }

}
