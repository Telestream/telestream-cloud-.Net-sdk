/* 
 * IAM API
 *
 * IAM API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: cloudsupport@telestream.net
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
using SwaggerDateConverter = Telestream.Cloud.Iam.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Iam.Model
{
    /// <summary>
    /// Credential
    /// </summary>
    [DataContract]
    public partial class Credential :  IEquatable<Credential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ApiKey">ApiKey.</param>
        /// <param name="Tag">Tag.</param>
        /// <param name="Policy">Policy.</param>
        /// <param name="ParentCredentialId">ParentCredentialId.</param>
        public Credential(string Id = default(string), string ApiKey = default(string), string Tag = default(string), Object Policy = default(Object), int? ParentCredentialId = default(int?))
        {
            this.Id = Id;
            this.ApiKey = ApiKey;
            this.Tag = Tag;
            this.Policy = Policy;
            this.ParentCredentialId = ParentCredentialId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Object Policy { get; set; }

        /// <summary>
        /// Gets or Sets ParentCredentialId
        /// </summary>
        [DataMember(Name="parent_credential_id", EmitDefaultValue=false)]
        public int? ParentCredentialId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Credential {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  ParentCredentialId: ").Append(ParentCredentialId).Append("\n");
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
            return this.Equals(input as Credential);
        }

        /// <summary>
        /// Returns true if Credential instances are equal
        /// </summary>
        /// <param name="input">Instance of Credential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Credential input)
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
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.ParentCredentialId == input.ParentCredentialId ||
                    (this.ParentCredentialId != null &&
                    this.ParentCredentialId.Equals(input.ParentCredentialId))
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
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.ParentCredentialId != null)
                    hashCode = hashCode * 59 + this.ParentCredentialId.GetHashCode();
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
