/* 
 * Qc API
 *
 * QC API
 *
 * OpenAPI spec version: 2.0.3
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
    /// Data
    /// </summary>
    [DataContract]
    public partial class Data :  IEquatable<Data>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="Name">Human-readable identifier of a Project..</param>
        /// <param name="Template">Name of QC template..</param>
        /// <param name="Options">Options.</param>
        public Data(string Name = default(string), string Template = default(string), Options Options = default(Options))
        {
            this.Name = Name;
            this.Template = Template;
            this.Options = Options;
        }
        
        /// <summary>
        /// Human-readable identifier of a Project.
        /// </summary>
        /// <value>Human-readable identifier of a Project.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of QC template.
        /// </summary>
        /// <value>Name of QC template.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as Data);
        }

        /// <summary>
        /// Returns true if Data instances are equal
        /// </summary>
        /// <param name="input">Instance of Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }

}
