/* 
 * Flip API
 *
 * Description
 *
 * OpenAPI spec version: 3.1.0
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
    /// SignedVideoUrl
    /// </summary>
    [DataContract]
    public partial class SignedVideoUrl :  IEquatable<SignedVideoUrl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignedVideoUrl" /> class.
        /// </summary>
        /// <param name="SignedUrl">An URL pointing to the Video file. It contains a valid authentication token..</param>
        public SignedVideoUrl(string SignedUrl = default(string))
        {
            this.SignedUrl = SignedUrl;
        }
        
        /// <summary>
        /// An URL pointing to the Video file. It contains a valid authentication token.
        /// </summary>
        /// <value>An URL pointing to the Video file. It contains a valid authentication token.</value>
        [DataMember(Name="signed_url", EmitDefaultValue=false)]
        public string SignedUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignedVideoUrl {\n");
            sb.Append("  SignedUrl: ").Append(SignedUrl).Append("\n");
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
            return this.Equals(input as SignedVideoUrl);
        }

        /// <summary>
        /// Returns true if SignedVideoUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of SignedVideoUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignedVideoUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignedUrl == input.SignedUrl ||
                    (this.SignedUrl != null &&
                    this.SignedUrl.Equals(input.SignedUrl))
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
                if (this.SignedUrl != null)
                    hashCode = hashCode * 59 + this.SignedUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
