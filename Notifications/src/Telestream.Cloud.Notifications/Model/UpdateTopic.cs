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
    /// UpdateTopic
    /// </summary>
    [DataContract]
    public partial class UpdateTopic :  IEquatable<UpdateTopic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopic" /> class.
        /// </summary>
        /// <param name="_Event">Name of the event; Quality Control (media-passed,  media-error,  media-warning,  media-rejected,  media-canceled) .</param>
        public UpdateTopic(string _Event = default(string))
        {
            this._Event = _Event;
        }
        
        /// <summary>
        /// Name of the event; Quality Control (media-passed,  media-error,  media-warning,  media-rejected,  media-canceled) 
        /// </summary>
        /// <value>Name of the event; Quality Control (media-passed,  media-error,  media-warning,  media-rejected,  media-canceled) </value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string _Event { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTopic {\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
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
            return this.Equals(input as UpdateTopic);
        }

        /// <summary>
        /// Returns true if UpdateTopic instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTopic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Event == input._Event ||
                    (this._Event != null &&
                    this._Event.Equals(input._Event))
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
                if (this._Event != null)
                    hashCode = hashCode * 59 + this._Event.GetHashCode();
                return hashCode;
            }
        }
    }

}
