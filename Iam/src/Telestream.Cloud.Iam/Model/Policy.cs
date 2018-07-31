/* 
 * IAM API
 *
 * IAM API
 *
 * OpenAPI spec version: 1.0.0
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
using SwaggerDateConverter = Telestream.Cloud.Iam.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Iam.Model
{
    /// <summary>
    /// Policy
    /// </summary>
    [DataContract]
    public partial class Policy :  IEquatable<Policy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Policy" /> class.
        /// </summary>
        /// <param name="Statements">Statements.</param>
        /// <param name="Version">Version.</param>
        public Policy(List<Statement> Statements = default(List<Statement>), int? Version = default(int?))
        {
            this.Statements = Statements;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Statements
        /// </summary>
        [DataMember(Name="statements", EmitDefaultValue=false)]
        public List<Statement> Statements { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policy {\n");
            sb.Append("  Statements: ").Append(Statements).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Policy);
        }

        /// <summary>
        /// Returns true if Policy instances are equal
        /// </summary>
        /// <param name="input">Instance of Policy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Policy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statements == input.Statements ||
                    this.Statements != null &&
                    this.Statements.SequenceEqual(input.Statements)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Statements != null)
                    hashCode = hashCode * 59 + this.Statements.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
