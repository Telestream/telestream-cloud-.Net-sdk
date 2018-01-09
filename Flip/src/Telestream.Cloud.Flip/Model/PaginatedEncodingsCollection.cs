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
    /// PaginatedEncodingsCollection
    /// </summary>
    [DataContract]
    public partial class PaginatedEncodingsCollection :  IEquatable<PaginatedEncodingsCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedEncodingsCollection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaginatedEncodingsCollection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedEncodingsCollection" /> class.
        /// </summary>
        /// <param name="Encodings">Encodings (required).</param>
        /// <param name="Page">A number of the fetched page. (required).</param>
        /// <param name="PerPage">A number of encodings per page. (required).</param>
        /// <param name="Total">A number of all encodings stored in the db. (required).</param>
        public PaginatedEncodingsCollection(List<Encoding> Encodings = default(List<Encoding>), int? Page = default(int?), int? PerPage = default(int?), int? Total = default(int?))
        {
            // to ensure "Encodings" is required (not null)
            if (Encodings == null)
            {
                throw new InvalidDataException("Encodings is a required property for PaginatedEncodingsCollection and cannot be null");
            }
            else
            {
                this.Encodings = Encodings;
            }
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for PaginatedEncodingsCollection and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "PerPage" is required (not null)
            if (PerPage == null)
            {
                throw new InvalidDataException("PerPage is a required property for PaginatedEncodingsCollection and cannot be null");
            }
            else
            {
                this.PerPage = PerPage;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for PaginatedEncodingsCollection and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
        }
        
        /// <summary>
        /// Gets or Sets Encodings
        /// </summary>
        [DataMember(Name="encodings", EmitDefaultValue=false)]
        public List<Encoding> Encodings { get; set; }

        /// <summary>
        /// A number of the fetched page.
        /// </summary>
        /// <value>A number of the fetched page.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// A number of encodings per page.
        /// </summary>
        /// <value>A number of encodings per page.</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// A number of all encodings stored in the db.
        /// </summary>
        /// <value>A number of all encodings stored in the db.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginatedEncodingsCollection {\n");
            sb.Append("  Encodings: ").Append(Encodings).Append("\n");
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
            return this.Equals(input as PaginatedEncodingsCollection);
        }

        /// <summary>
        /// Returns true if PaginatedEncodingsCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedEncodingsCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedEncodingsCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Encodings == input.Encodings ||
                    this.Encodings != null &&
                    this.Encodings.SequenceEqual(input.Encodings)
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
                if (this.Encodings != null)
                    hashCode = hashCode * 59 + this.Encodings.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }

}
