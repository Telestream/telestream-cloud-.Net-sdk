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
    /// StatementsList
    /// </summary>
    [DataContract]
    public partial class StatementsList :  IEquatable<StatementsList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsList" /> class.
        /// </summary>
        /// <param name="Statements">Statements.</param>
        public StatementsList(List<string> Statements = default(List<string>))
        {
            this.Statements = Statements;
        }
        
        /// <summary>
        /// Gets or Sets Statements
        /// </summary>
        [DataMember(Name="statements", EmitDefaultValue=false)]
        public List<string> Statements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementsList {\n");
            sb.Append("  Statements: ").Append(Statements).Append("\n");
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
            return this.Equals(input as StatementsList);
        }

        /// <summary>
        /// Returns true if StatementsList instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statements == input.Statements ||
                    this.Statements != null &&
                    this.Statements.SequenceEqual(input.Statements)
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
                return hashCode;
            }
        }
    }

}
