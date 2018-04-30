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
    /// CreateVideoBody
    /// </summary>
    [DataContract]
    public partial class CreateVideoBody :  IEquatable<CreateVideoBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoBody" /> class.
        /// </summary>
        /// <param name="SourceUrl">An URL pointing to a source file..</param>
        /// <param name="Profiles">Comma-separated list of profile names or IDs to be used during encoding. Alternatively, specify none so no encodings are created yet..</param>
        /// <param name="Payload">Arbitrary string stored along the Video object..</param>
        /// <param name="Pipeline">String-encoded JSON describing profiles pipeline..</param>
        /// <param name="SubtitleFiles">A list of urls pointing to remote subtitle files..</param>
        /// <param name="ExtraFiles">ExtraFiles.</param>
        /// <param name="ExtraVariables">ExtraVariables.</param>
        /// <param name="PathFormat">PathFormat.</param>
        /// <param name="ClipEnd">Clip ends at a specific time..</param>
        /// <param name="ClipLength">A clip’s duration..</param>
        /// <param name="ClipOffset">Clip starts at a specific offset..</param>
        public CreateVideoBody(string SourceUrl = default(string), string Profiles = default(string), string Payload = default(string), string Pipeline = default(string), List<string> SubtitleFiles = default(List<string>), Dictionary<string, List<string>> ExtraFiles = default(Dictionary<string, List<string>>), Dictionary<string, string> ExtraVariables = default(Dictionary<string, string>), string PathFormat = default(string), string ClipEnd = default(string), string ClipLength = default(string), string ClipOffset = default(string))
        {
            this.SourceUrl = SourceUrl;
            this.Profiles = Profiles;
            this.Payload = Payload;
            this.Pipeline = Pipeline;
            this.SubtitleFiles = SubtitleFiles;
            this.ExtraFiles = ExtraFiles;
            this.ExtraVariables = ExtraVariables;
            this.PathFormat = PathFormat;
            this.ClipEnd = ClipEnd;
            this.ClipLength = ClipLength;
            this.ClipOffset = ClipOffset;
        }
        
        /// <summary>
        /// An URL pointing to a source file.
        /// </summary>
        /// <value>An URL pointing to a source file.</value>
        [DataMember(Name="source_url", EmitDefaultValue=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Comma-separated list of profile names or IDs to be used during encoding. Alternatively, specify none so no encodings are created yet.
        /// </summary>
        /// <value>Comma-separated list of profile names or IDs to be used during encoding. Alternatively, specify none so no encodings are created yet.</value>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public string Profiles { get; set; }

        /// <summary>
        /// Arbitrary string stored along the Video object.
        /// </summary>
        /// <value>Arbitrary string stored along the Video object.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// String-encoded JSON describing profiles pipeline.
        /// </summary>
        /// <value>String-encoded JSON describing profiles pipeline.</value>
        [DataMember(Name="pipeline", EmitDefaultValue=false)]
        public string Pipeline { get; set; }

        /// <summary>
        /// A list of urls pointing to remote subtitle files.
        /// </summary>
        /// <value>A list of urls pointing to remote subtitle files.</value>
        [DataMember(Name="subtitle_files", EmitDefaultValue=false)]
        public List<string> SubtitleFiles { get; set; }

        /// <summary>
        /// Gets or Sets ExtraFiles
        /// </summary>
        [DataMember(Name="extra_files", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ExtraFiles { get; set; }

        /// <summary>
        /// Gets or Sets ExtraVariables
        /// </summary>
        [DataMember(Name="extra_variables", EmitDefaultValue=false)]
        public Dictionary<string, string> ExtraVariables { get; set; }

        /// <summary>
        /// Gets or Sets PathFormat
        /// </summary>
        [DataMember(Name="path_format", EmitDefaultValue=false)]
        public string PathFormat { get; set; }

        /// <summary>
        /// Clip ends at a specific time.
        /// </summary>
        /// <value>Clip ends at a specific time.</value>
        [DataMember(Name="clip_end", EmitDefaultValue=false)]
        public string ClipEnd { get; set; }

        /// <summary>
        /// A clip’s duration.
        /// </summary>
        /// <value>A clip’s duration.</value>
        [DataMember(Name="clip_length", EmitDefaultValue=false)]
        public string ClipLength { get; set; }

        /// <summary>
        /// Clip starts at a specific offset.
        /// </summary>
        /// <value>Clip starts at a specific offset.</value>
        [DataMember(Name="clip_offset", EmitDefaultValue=false)]
        public string ClipOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVideoBody {\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  SubtitleFiles: ").Append(SubtitleFiles).Append("\n");
            sb.Append("  ExtraFiles: ").Append(ExtraFiles).Append("\n");
            sb.Append("  ExtraVariables: ").Append(ExtraVariables).Append("\n");
            sb.Append("  PathFormat: ").Append(PathFormat).Append("\n");
            sb.Append("  ClipEnd: ").Append(ClipEnd).Append("\n");
            sb.Append("  ClipLength: ").Append(ClipLength).Append("\n");
            sb.Append("  ClipOffset: ").Append(ClipOffset).Append("\n");
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
            return this.Equals(input as CreateVideoBody);
        }

        /// <summary>
        /// Returns true if CreateVideoBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateVideoBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVideoBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    (this.Profiles != null &&
                    this.Profiles.Equals(input.Profiles))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Pipeline == input.Pipeline ||
                    (this.Pipeline != null &&
                    this.Pipeline.Equals(input.Pipeline))
                ) && 
                (
                    this.SubtitleFiles == input.SubtitleFiles ||
                    this.SubtitleFiles != null &&
                    this.SubtitleFiles.SequenceEqual(input.SubtitleFiles)
                ) && 
                (
                    this.ExtraFiles == input.ExtraFiles ||
                    this.ExtraFiles != null &&
                    this.ExtraFiles.SequenceEqual(input.ExtraFiles)
                ) && 
                (
                    this.ExtraVariables == input.ExtraVariables ||
                    this.ExtraVariables != null &&
                    this.ExtraVariables.SequenceEqual(input.ExtraVariables)
                ) && 
                (
                    this.PathFormat == input.PathFormat ||
                    (this.PathFormat != null &&
                    this.PathFormat.Equals(input.PathFormat))
                ) && 
                (
                    this.ClipEnd == input.ClipEnd ||
                    (this.ClipEnd != null &&
                    this.ClipEnd.Equals(input.ClipEnd))
                ) && 
                (
                    this.ClipLength == input.ClipLength ||
                    (this.ClipLength != null &&
                    this.ClipLength.Equals(input.ClipLength))
                ) && 
                (
                    this.ClipOffset == input.ClipOffset ||
                    (this.ClipOffset != null &&
                    this.ClipOffset.Equals(input.ClipOffset))
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
                if (this.SourceUrl != null)
                    hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Pipeline != null)
                    hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.SubtitleFiles != null)
                    hashCode = hashCode * 59 + this.SubtitleFiles.GetHashCode();
                if (this.ExtraFiles != null)
                    hashCode = hashCode * 59 + this.ExtraFiles.GetHashCode();
                if (this.ExtraVariables != null)
                    hashCode = hashCode * 59 + this.ExtraVariables.GetHashCode();
                if (this.PathFormat != null)
                    hashCode = hashCode * 59 + this.PathFormat.GetHashCode();
                if (this.ClipEnd != null)
                    hashCode = hashCode * 59 + this.ClipEnd.GetHashCode();
                if (this.ClipLength != null)
                    hashCode = hashCode * 59 + this.ClipLength.GetHashCode();
                if (this.ClipOffset != null)
                    hashCode = hashCode * 59 + this.ClipOffset.GetHashCode();
                return hashCode;
            }
        }
    }

}
