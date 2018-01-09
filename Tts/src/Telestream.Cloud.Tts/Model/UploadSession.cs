/* 
 * Tts API
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
using SwaggerDateConverter = Telestream.Cloud.Tts.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Tts.Model
{
    /// <summary>
    /// UploadSession
    /// </summary>
    [DataContract]
    public partial class UploadSession :  IEquatable<UploadSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSession" /> class.
        /// </summary>
        /// <param name="Id">An unique identifier of the UploadSession. (required).</param>
        /// <param name="Location">An URL to which chunks of the uploaded file should be sent (required).</param>
        /// <param name="Parts">A number of chunks that are expected by the upstream..</param>
        /// <param name="PartSize">An expected size of uploaded chunks..</param>
        /// <param name="MaxConnections">A maximum number of concurrent connections..</param>
        /// <param name="ExtraFiles">An object containing additional files uploaded using the session..</param>
        public UploadSession(string Id = default(string), string Location = default(string), int? Parts = default(int?), int? PartSize = default(int?), int? MaxConnections = default(int?), Object ExtraFiles = default(Object))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UploadSession and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for UploadSession and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            this.Parts = Parts;
            this.PartSize = PartSize;
            this.MaxConnections = MaxConnections;
            this.ExtraFiles = ExtraFiles;
        }
        
        /// <summary>
        /// An unique identifier of the UploadSession.
        /// </summary>
        /// <value>An unique identifier of the UploadSession.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An URL to which chunks of the uploaded file should be sent
        /// </summary>
        /// <value>An URL to which chunks of the uploaded file should be sent</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// A number of chunks that are expected by the upstream.
        /// </summary>
        /// <value>A number of chunks that are expected by the upstream.</value>
        [DataMember(Name="parts", EmitDefaultValue=false)]
        public int? Parts { get; set; }

        /// <summary>
        /// An expected size of uploaded chunks.
        /// </summary>
        /// <value>An expected size of uploaded chunks.</value>
        [DataMember(Name="part_size", EmitDefaultValue=false)]
        public int? PartSize { get; set; }

        /// <summary>
        /// A maximum number of concurrent connections.
        /// </summary>
        /// <value>A maximum number of concurrent connections.</value>
        [DataMember(Name="max_connections", EmitDefaultValue=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// An object containing additional files uploaded using the session.
        /// </summary>
        /// <value>An object containing additional files uploaded using the session.</value>
        [DataMember(Name="extra_files", EmitDefaultValue=false)]
        public Object ExtraFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  PartSize: ").Append(PartSize).Append("\n");
            sb.Append("  MaxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  ExtraFiles: ").Append(ExtraFiles).Append("\n");
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
            return this.Equals(input as UploadSession);
        }

        /// <summary>
        /// Returns true if UploadSession instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadSession input)
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
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Parts == input.Parts ||
                    (this.Parts != null &&
                    this.Parts.Equals(input.Parts))
                ) && 
                (
                    this.PartSize == input.PartSize ||
                    (this.PartSize != null &&
                    this.PartSize.Equals(input.PartSize))
                ) && 
                (
                    this.MaxConnections == input.MaxConnections ||
                    (this.MaxConnections != null &&
                    this.MaxConnections.Equals(input.MaxConnections))
                ) && 
                (
                    this.ExtraFiles == input.ExtraFiles ||
                    (this.ExtraFiles != null &&
                    this.ExtraFiles.Equals(input.ExtraFiles))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Parts != null)
                    hashCode = hashCode * 59 + this.Parts.GetHashCode();
                if (this.PartSize != null)
                    hashCode = hashCode * 59 + this.PartSize.GetHashCode();
                if (this.MaxConnections != null)
                    hashCode = hashCode * 59 + this.MaxConnections.GetHashCode();
                if (this.ExtraFiles != null)
                    hashCode = hashCode * 59 + this.ExtraFiles.GetHashCode();
                return hashCode;
            }
        }
    }

}
