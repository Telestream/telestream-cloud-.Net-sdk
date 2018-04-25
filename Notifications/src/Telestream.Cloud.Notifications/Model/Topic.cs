/* 
 * Notifications API
 *
 * Notifications API
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
using SwaggerDateConverter = Telestream.Cloud.Notifications.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Notifications.Model
{
    /// <summary>
    /// Topic
    /// </summary>
    [DataContract]
    public partial class Topic :  IEquatable<Topic>
    {
        /// <summary>
        /// Defines Service
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceEnum
        {
            
            /// <summary>
            /// Enum Qc for value: qc
            /// </summary>
            [EnumMember(Value = "qc")]
            Qc = 1
        }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Defines Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
        {
            
            /// <summary>
            /// Enum Passed for value: video-passed
            /// </summary>
            [EnumMember(Value = "video-passed")]
            Passed = 1,
            
            /// <summary>
            /// Enum Error for value: video-error
            /// </summary>
            [EnumMember(Value = "video-error")]
            Error = 2,
            
            /// <summary>
            /// Enum Warning for value: video-warning
            /// </summary>
            [EnumMember(Value = "video-warning")]
            Warning = 3,
            
            /// <summary>
            /// Enum Rejected for value: video-rejected
            /// </summary>
            [EnumMember(Value = "video-rejected")]
            Rejected = 4,
            
            /// <summary>
            /// Enum Canceled for value: video-canceled
            /// </summary>
            [EnumMember(Value = "video-canceled")]
            Canceled = 5
        }


        /// <summary>
        /// Name of the event  Quality Control - video-passed - video-error - video-warning - video-rejected - video-canceled 
        /// </summary>
        /// <value>Name of the event  Quality Control - video-passed - video-error - video-warning - video-rejected - video-canceled </value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<EventsEnum> Events { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        /// <param name="Account">[read-only] Account identifier connected to subscription notification .</param>
        /// <param name="Service">Service.</param>
        /// <param name="Events">Name of the event  Quality Control - video-passed - video-error - video-warning - video-rejected - video-canceled .</param>
        /// <param name="Project">Project ID.</param>
        public Topic(string Account = default(string), ServiceEnum? Service = default(ServiceEnum?), List<EventsEnum> Events = default(List<EventsEnum>), string Project = default(string))
        {
            this.Account = Account;
            this.Service = Service;
            this.Events = Events;
            this.Project = Project;
        }
        
        /// <summary>
        /// [read-only] Account identifier connected to subscription notification 
        /// </summary>
        /// <value>[read-only] Account identifier connected to subscription notification </value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }



        /// <summary>
        /// Project ID
        /// </summary>
        /// <value>Project ID</value>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }

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
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                return hashCode;
            }
        }
    }

}