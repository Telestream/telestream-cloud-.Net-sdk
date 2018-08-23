/* 
 * Tts API
 *
 * Description
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
using SwaggerDateConverter = Telestream.Cloud.Tts.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Tts.Model
{
    /// <summary>
    /// JobOutput
    /// </summary>
    [DataContract]
    public partial class JobOutput :  IEquatable<JobOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobOutput" /> class.
        /// </summary>
        /// <param name="Format">Output file format.</param>
        /// <param name="Url">URL to output (must be accessed with X-Api-Key).</param>
        public JobOutput(string Format = default(string), string Url = default(string))
        {
            this.Format = Format;
            this.Url = Url;
        }
        
        /// <summary>
        /// Output file format
        /// </summary>
        /// <value>Output file format</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// URL to output (must be accessed with X-Api-Key)
        /// </summary>
        /// <value>URL to output (must be accessed with X-Api-Key)</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobOutput {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as JobOutput);
        }

        /// <summary>
        /// Returns true if JobOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of JobOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}