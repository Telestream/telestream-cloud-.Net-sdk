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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Telestream.Cloud.Flip.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Flip.Model
{
    /// <summary>
    /// PaginatedWorkflowsCollection
    /// </summary>
    [DataContract]
    public partial class PaginatedWorkflowsCollection :  IEquatable<PaginatedWorkflowsCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedWorkflowsCollection" /> class.
        /// </summary>
        /// <param name="Workflows">Workflows.</param>
        /// <param name="Page">A number of the fetched page..</param>
        /// <param name="PerPage">A number of factories per page..</param>
        /// <param name="Total">A number of all factories stored in the db..</param>
        public PaginatedWorkflowsCollection(List<Profile> Workflows = default(List<Profile>), int? Page = default(int?), int? PerPage = default(int?), int? Total = default(int?))
        {
            this.Workflows = Workflows;
            this.Page = Page;
            this.PerPage = PerPage;
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Workflows
        /// </summary>
        [DataMember(Name="workflows", EmitDefaultValue=false)]
        public List<Profile> Workflows { get; set; }

        /// <summary>
        /// A number of the fetched page.
        /// </summary>
        /// <value>A number of the fetched page.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// A number of factories per page.
        /// </summary>
        /// <value>A number of factories per page.</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// A number of all factories stored in the db.
        /// </summary>
        /// <value>A number of all factories stored in the db.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginatedWorkflowsCollection {\n");
            sb.Append("  Workflows: ").Append(Workflows).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as PaginatedWorkflowsCollection);
        }

        /// <summary>
        /// Returns true if PaginatedWorkflowsCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedWorkflowsCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedWorkflowsCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Workflows == input.Workflows ||
                    this.Workflows != null &&
                    this.Workflows.SequenceEqual(input.Workflows)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Workflows != null)
                    hashCode = hashCode * 59 + this.Workflows.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
