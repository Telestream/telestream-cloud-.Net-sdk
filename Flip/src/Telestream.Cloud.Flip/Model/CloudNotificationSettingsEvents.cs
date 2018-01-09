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
    /// CloudNotificationSettingsEvents
    /// </summary>
    [DataContract]
    public partial class CloudNotificationSettingsEvents :  IEquatable<CloudNotificationSettingsEvents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNotificationSettingsEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloudNotificationSettingsEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNotificationSettingsEvents" /> class.
        /// </summary>
        /// <param name="EncodingCompleted">If set to &#x60;true&#x60;, a notification will be sent after an encoding becomes complete. (required).</param>
        /// <param name="EncodingProgress">If set to &#x60;true&#x60;, a notification will be sent after an encoding&#39;s progess changes. (required).</param>
        /// <param name="VideoCreated">If set to &#x60;true&#x60;, a notification will be sent after a video is created. (required).</param>
        /// <param name="VideoEncoded">If set to &#x60;true&#x60;, a notification will be sent after a video is encoded. (required).</param>
        public CloudNotificationSettingsEvents(bool? EncodingCompleted = default(bool?), bool? EncodingProgress = default(bool?), bool? VideoCreated = default(bool?), bool? VideoEncoded = default(bool?))
        {
            // to ensure "EncodingCompleted" is required (not null)
            if (EncodingCompleted == null)
            {
                throw new InvalidDataException("EncodingCompleted is a required property for CloudNotificationSettingsEvents and cannot be null");
            }
            else
            {
                this.EncodingCompleted = EncodingCompleted;
            }
            // to ensure "EncodingProgress" is required (not null)
            if (EncodingProgress == null)
            {
                throw new InvalidDataException("EncodingProgress is a required property for CloudNotificationSettingsEvents and cannot be null");
            }
            else
            {
                this.EncodingProgress = EncodingProgress;
            }
            // to ensure "VideoCreated" is required (not null)
            if (VideoCreated == null)
            {
                throw new InvalidDataException("VideoCreated is a required property for CloudNotificationSettingsEvents and cannot be null");
            }
            else
            {
                this.VideoCreated = VideoCreated;
            }
            // to ensure "VideoEncoded" is required (not null)
            if (VideoEncoded == null)
            {
                throw new InvalidDataException("VideoEncoded is a required property for CloudNotificationSettingsEvents and cannot be null");
            }
            else
            {
                this.VideoEncoded = VideoEncoded;
            }
        }
        
        /// <summary>
        /// If set to &#x60;true&#x60;, a notification will be sent after an encoding becomes complete.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, a notification will be sent after an encoding becomes complete.</value>
        [DataMember(Name="encoding_completed", EmitDefaultValue=false)]
        public bool? EncodingCompleted { get; set; }

        /// <summary>
        /// If set to &#x60;true&#x60;, a notification will be sent after an encoding&#39;s progess changes.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, a notification will be sent after an encoding&#39;s progess changes.</value>
        [DataMember(Name="encoding_progress", EmitDefaultValue=false)]
        public bool? EncodingProgress { get; set; }

        /// <summary>
        /// If set to &#x60;true&#x60;, a notification will be sent after a video is created.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, a notification will be sent after a video is created.</value>
        [DataMember(Name="video_created", EmitDefaultValue=false)]
        public bool? VideoCreated { get; set; }

        /// <summary>
        /// If set to &#x60;true&#x60;, a notification will be sent after a video is encoded.
        /// </summary>
        /// <value>If set to &#x60;true&#x60;, a notification will be sent after a video is encoded.</value>
        [DataMember(Name="video_encoded", EmitDefaultValue=false)]
        public bool? VideoEncoded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudNotificationSettingsEvents {\n");
            sb.Append("  EncodingCompleted: ").Append(EncodingCompleted).Append("\n");
            sb.Append("  EncodingProgress: ").Append(EncodingProgress).Append("\n");
            sb.Append("  VideoCreated: ").Append(VideoCreated).Append("\n");
            sb.Append("  VideoEncoded: ").Append(VideoEncoded).Append("\n");
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
            return this.Equals(input as CloudNotificationSettingsEvents);
        }

        /// <summary>
        /// Returns true if CloudNotificationSettingsEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudNotificationSettingsEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudNotificationSettingsEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncodingCompleted == input.EncodingCompleted ||
                    (this.EncodingCompleted != null &&
                    this.EncodingCompleted.Equals(input.EncodingCompleted))
                ) && 
                (
                    this.EncodingProgress == input.EncodingProgress ||
                    (this.EncodingProgress != null &&
                    this.EncodingProgress.Equals(input.EncodingProgress))
                ) && 
                (
                    this.VideoCreated == input.VideoCreated ||
                    (this.VideoCreated != null &&
                    this.VideoCreated.Equals(input.VideoCreated))
                ) && 
                (
                    this.VideoEncoded == input.VideoEncoded ||
                    (this.VideoEncoded != null &&
                    this.VideoEncoded.Equals(input.VideoEncoded))
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
                if (this.EncodingCompleted != null)
                    hashCode = hashCode * 59 + this.EncodingCompleted.GetHashCode();
                if (this.EncodingProgress != null)
                    hashCode = hashCode * 59 + this.EncodingProgress.GetHashCode();
                if (this.VideoCreated != null)
                    hashCode = hashCode * 59 + this.VideoCreated.GetHashCode();
                if (this.VideoEncoded != null)
                    hashCode = hashCode * 59 + this.VideoEncoded.GetHashCode();
                return hashCode;
            }
        }
    }

}
