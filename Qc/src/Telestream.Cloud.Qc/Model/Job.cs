/* 
 * Qc API
 *
 * QC API
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
using SwaggerDateConverter = Telestream.Cloud.Qc.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Qc.Model
{
    /// <summary>
    /// Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Transfering for value: transfering
            /// </summary>
            [EnumMember(Value = "transfering")]
            Transfering = 2,
            
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 3,
            
            /// <summary>
            /// Enum Downloading for value: downloading
            /// </summary>
            [EnumMember(Value = "downloading")]
            Downloading = 4,
            
            /// <summary>
            /// Enum Uploading for value: uploading
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading = 5,
            
            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 6,
            
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 7,
            
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 8
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Vidchecker for value: vidchecker
            /// </summary>
            [EnumMember(Value = "vidchecker")]
            Vidchecker = 1,
            
            /// <summary>
            /// Enum Lipsync for value: lipsync
            /// </summary>
            [EnumMember(Value = "lipsync")]
            Lipsync = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="State">State.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Progress">Progress.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="SourceUrl">SourceUrl.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="ErrorClass">ErrorClass.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="Payload">Payload.</param>
        /// <param name="Details">Details.</param>
        public Job(string Id = default(string), string ProjectId = default(string), StatusEnum? Status = default(StatusEnum?), string State = default(string), int? Duration = default(int?), TypeEnum? Type = default(TypeEnum?), int? Progress = default(int?), string Filename = default(string), string SourceUrl = default(string), string CreatedAt = default(string), string UpdatedAt = default(string), string ErrorClass = default(string), string ErrorMessage = default(string), string Payload = default(string), JobDetails Details = default(JobDetails))
        {
            this.Id = Id;
            this.ProjectId = ProjectId;
            this.Status = Status;
            this.State = State;
            this.Duration = Duration;
            this.Type = Type;
            this.Progress = Progress;
            this.Filename = Filename;
            this.SourceUrl = SourceUrl;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.ErrorClass = ErrorClass;
            this.ErrorMessage = ErrorMessage;
            this.Payload = Payload;
            this.Details = Details;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }


        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets SourceUrl
        /// </summary>
        [DataMember(Name="source_url", EmitDefaultValue=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ErrorClass
        /// </summary>
        [DataMember(Name="error_class", EmitDefaultValue=false)]
        public string ErrorClass { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public JobDetails Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ErrorClass: ").Append(ErrorClass).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="input">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job input)
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ErrorClass == input.ErrorClass ||
                    (this.ErrorClass != null &&
                    this.ErrorClass.Equals(input.ErrorClass))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.SourceUrl != null)
                    hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ErrorClass != null)
                    hashCode = hashCode * 59 + this.ErrorClass.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                return hashCode;
            }
        }
    }

}
