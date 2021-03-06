/* 
 * Notifications API
 *
 * Notifications API V2
 *
 * OpenAPI spec version: 2.1.0
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
using SwaggerDateConverter = Telestream.Cloud.Notifications.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Notifications.Model
{
    /// <summary>
    /// Topic
    /// </summary>
    [DataContract]
    public partial class Topic :  IEquatable<Topic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Topic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        /// <param name="Service">Name of service (qc, flip, tts)  (required).</param>
        /// <param name="_Event">Name of the event;  Quality Control (media-passed, media-error, media-warning, media-rejected, media-canceled, job-created, job-progress), Flip (video-created, video-encoded, encoding-complete, encoding-progress), Transcription (job-created, job-completed, job-error, job-progress)  (required).</param>
        /// <param name="Project">(for tts, qc service); Project ID .</param>
        /// <param name="Factory">(for flip service); Factory ID .</param>
        public Topic(string Service = default(string), string _Event = default(string), string Project = default(string), string Factory = default(string))
        {
            // to ensure "Service" is required (not null)
            if (Service == null)
            {
                throw new InvalidDataException("Service is a required property for Topic and cannot be null");
            }
            else
            {
                this.Service = Service;
            }
            // to ensure "_Event" is required (not null)
            if (_Event == null)
            {
                throw new InvalidDataException("_Event is a required property for Topic and cannot be null");
            }
            else
            {
                this._Event = _Event;
            }
            this.Project = Project;
            this.Factory = Factory;
        }
        
        /// <summary>
        /// [read-only] Account identifier connected to subscription notification 
        /// </summary>
        /// <value>[read-only] Account identifier connected to subscription notification </value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; private set; }

        /// <summary>
        /// Name of service (qc, flip, tts) 
        /// </summary>
        /// <value>Name of service (qc, flip, tts) </value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Name of the event;  Quality Control (media-passed, media-error, media-warning, media-rejected, media-canceled, job-created, job-progress), Flip (video-created, video-encoded, encoding-complete, encoding-progress), Transcription (job-created, job-completed, job-error, job-progress) 
        /// </summary>
        /// <value>Name of the event;  Quality Control (media-passed, media-error, media-warning, media-rejected, media-canceled, job-created, job-progress), Flip (video-created, video-encoded, encoding-complete, encoding-progress), Transcription (job-created, job-completed, job-error, job-progress) </value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string _Event { get; set; }

        /// <summary>
        /// (for tts, qc service); Project ID 
        /// </summary>
        /// <value>(for tts, qc service); Project ID </value>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }

        /// <summary>
        /// (for flip service); Factory ID 
        /// </summary>
        /// <value>(for flip service); Factory ID </value>
        [DataMember(Name="factory", EmitDefaultValue=false)]
        public string Factory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Topic {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Factory: ").Append(Factory).Append("\n");
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
            return this.Equals(input as Topic);
        }

        /// <summary>
        /// Returns true if Topic instances are equal
        /// </summary>
        /// <param name="input">Instance of Topic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Topic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this._Event == input._Event ||
                    (this._Event != null &&
                    this._Event.Equals(input._Event))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Factory == input.Factory ||
                    (this.Factory != null &&
                    this.Factory.Equals(input.Factory))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this._Event != null)
                    hashCode = hashCode * 59 + this._Event.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Factory != null)
                    hashCode = hashCode * 59 + this.Factory.GetHashCode();
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
