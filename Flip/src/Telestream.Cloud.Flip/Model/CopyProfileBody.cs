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
    /// CopyProfileBody
    /// </summary>
    [DataContract]
    public partial class CopyProfileBody :  IEquatable<CopyProfileBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyProfileBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyProfileBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyProfileBody" /> class.
        /// </summary>
        /// <param name="DestFactoryId">an id of a target Factory that will own a copy of the Profile (required).</param>
        /// <param name="ProfileName">a name for a copy of the Profile (required).</param>
        public CopyProfileBody(string DestFactoryId = default(string), string ProfileName = default(string))
        {
            // to ensure "DestFactoryId" is required (not null)
            if (DestFactoryId == null)
            {
                throw new InvalidDataException("DestFactoryId is a required property for CopyProfileBody and cannot be null");
            }
            else
            {
                this.DestFactoryId = DestFactoryId;
            }
            // to ensure "ProfileName" is required (not null)
            if (ProfileName == null)
            {
                throw new InvalidDataException("ProfileName is a required property for CopyProfileBody and cannot be null");
            }
            else
            {
                this.ProfileName = ProfileName;
            }
        }
        
        /// <summary>
        /// an id of a target Factory that will own a copy of the Profile
        /// </summary>
        /// <value>an id of a target Factory that will own a copy of the Profile</value>
        [DataMember(Name="dest_factory_id", EmitDefaultValue=false)]
        public string DestFactoryId { get; set; }

        /// <summary>
        /// a name for a copy of the Profile
        /// </summary>
        /// <value>a name for a copy of the Profile</value>
        [DataMember(Name="profile_name", EmitDefaultValue=false)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyProfileBody {\n");
            sb.Append("  DestFactoryId: ").Append(DestFactoryId).Append("\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
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
            return this.Equals(input as CopyProfileBody);
        }

        /// <summary>
        /// Returns true if CopyProfileBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyProfileBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyProfileBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestFactoryId == input.DestFactoryId ||
                    (this.DestFactoryId != null &&
                    this.DestFactoryId.Equals(input.DestFactoryId))
                ) && 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
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
                if (this.DestFactoryId != null)
                    hashCode = hashCode * 59 + this.DestFactoryId.GetHashCode();
                if (this.ProfileName != null)
                    hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                return hashCode;
            }
        }
    }

}
