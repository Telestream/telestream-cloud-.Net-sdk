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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Telestream.Cloud.Tts.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Tts.Model
{
    /// <summary>
    /// Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>, IValidatableObject
    {
        /// <summary>
        /// Determines the state of transcription job.
        /// </summary>
        /// <value>Determines the state of transcription job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Preparing for value: preparing
            /// </summary>
            [EnumMember(Value = "preparing")]
            Preparing = 2,
            
            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 3,
            
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 4,
            
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 5
        }

        /// <summary>
        /// Determines the state of transcription job.
        /// </summary>
        /// <value>Determines the state of transcription job.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="Id">The ID of the job..</param>
        /// <param name="Name">The name of the job..</param>
        /// <param name="OriginalFilename">The name of the input file.</param>
        /// <param name="ProjectId">The ID of the project..</param>
        /// <param name="SourceUrl">The URL of source file..</param>
        /// <param name="Status">Determines the state of transcription job..</param>
        /// <param name="Error">If the status of the job is &#39;error&#39;, returns the state of job..</param>
        /// <param name="Progress">A percentage that indicates the progress of the job..</param>
        /// <param name="Confidence">The confidence score of the job in the range of 0 to 100..</param>
        /// <param name="Duration">The duration of the input audio in milliseconds..</param>
        /// <param name="Bitrate">The bitrate of the input audio..</param>
        /// <param name="SampleRate">The sample rate of the input audio..</param>
        /// <param name="Format">The format of the input audio..</param>
        /// <param name="FileSize">The file size of the input file..</param>
        /// <param name="CustomWords">Words used for model training, separated by space..</param>
        /// <param name="CreatedAt">A date and time when the job was created.</param>
        /// <param name="UpdatedAt">A date and time when the job was updated.</param>
        public Job(string Id = default(string), string Name = default(string), string OriginalFilename = default(string), string ProjectId = default(string), string SourceUrl = default(string), StatusEnum? Status = default(StatusEnum?), string Error = default(string), int? Progress = default(int?), int? Confidence = default(int?), int? Duration = default(int?), int? Bitrate = default(int?), int? SampleRate = default(int?), string Format = default(string), long? FileSize = default(long?), string CustomWords = default(string), string CreatedAt = default(string), string UpdatedAt = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.OriginalFilename = OriginalFilename;
            this.ProjectId = ProjectId;
            this.SourceUrl = SourceUrl;
            this.Status = Status;
            this.Error = Error;
            this.Progress = Progress;
            this.Confidence = Confidence;
            this.Duration = Duration;
            this.Bitrate = Bitrate;
            this.SampleRate = SampleRate;
            this.Format = Format;
            this.FileSize = FileSize;
            this.CustomWords = CustomWords;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// The ID of the job.
        /// </summary>
        /// <value>The ID of the job.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the job.
        /// </summary>
        /// <value>The name of the job.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the input file
        /// </summary>
        /// <value>The name of the input file</value>
        [DataMember(Name="original_filename", EmitDefaultValue=false)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// The ID of the project.
        /// </summary>
        /// <value>The ID of the project.</value>
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The URL of source file.
        /// </summary>
        /// <value>The URL of source file.</value>
        [DataMember(Name="source_url", EmitDefaultValue=false)]
        public string SourceUrl { get; set; }


        /// <summary>
        /// If the status of the job is &#39;error&#39;, returns the state of job.
        /// </summary>
        /// <value>If the status of the job is &#39;error&#39;, returns the state of job.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// A percentage that indicates the progress of the job.
        /// </summary>
        /// <value>A percentage that indicates the progress of the job.</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// The confidence score of the job in the range of 0 to 100.
        /// </summary>
        /// <value>The confidence score of the job in the range of 0 to 100.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }

        /// <summary>
        /// The duration of the input audio in milliseconds.
        /// </summary>
        /// <value>The duration of the input audio in milliseconds.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The bitrate of the input audio.
        /// </summary>
        /// <value>The bitrate of the input audio.</value>
        [DataMember(Name="bitrate", EmitDefaultValue=false)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// The sample rate of the input audio.
        /// </summary>
        /// <value>The sample rate of the input audio.</value>
        [DataMember(Name="sample_rate", EmitDefaultValue=false)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The format of the input audio.
        /// </summary>
        /// <value>The format of the input audio.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// The file size of the input file.
        /// </summary>
        /// <value>The file size of the input file.</value>
        [DataMember(Name="file_size", EmitDefaultValue=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// Words used for model training, separated by space.
        /// </summary>
        /// <value>Words used for model training, separated by space.</value>
        [DataMember(Name="custom_words", EmitDefaultValue=false)]
        public string CustomWords { get; set; }

        /// <summary>
        /// A date and time when the job was created
        /// </summary>
        /// <value>A date and time when the job was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// A date and time when the job was updated
        /// </summary>
        /// <value>A date and time when the job was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  SampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  CustomWords: ").Append(CustomWords).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OriginalFilename == input.OriginalFilename ||
                    (this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(input.OriginalFilename))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Bitrate == input.Bitrate ||
                    (this.Bitrate != null &&
                    this.Bitrate.Equals(input.Bitrate))
                ) && 
                (
                    this.SampleRate == input.SampleRate ||
                    (this.SampleRate != null &&
                    this.SampleRate.Equals(input.SampleRate))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.CustomWords == input.CustomWords ||
                    (this.CustomWords != null &&
                    this.CustomWords.Equals(input.CustomWords))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OriginalFilename != null)
                    hashCode = hashCode * 59 + this.OriginalFilename.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.SourceUrl != null)
                    hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Bitrate != null)
                    hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.SampleRate != null)
                    hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.CustomWords != null)
                    hashCode = hashCode * 59 + this.CustomWords.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
