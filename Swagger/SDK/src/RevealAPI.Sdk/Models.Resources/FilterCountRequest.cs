/* 
 * Reveal API v2.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
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
using SwaggerDateConverter = RevealAPI.Sdk.Client.SwaggerDateConverter;

namespace RevealAPI.Sdk.Models.Resources
{
    /// <summary>
    /// FilterCountRequest
    /// </summary>
    [DataContract]
    public partial class FilterCountRequest :  IEquatable<FilterCountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCountRequest" /> class.
        /// </summary>
        /// <param name="filterClauses">filterClauses.</param>
        /// <param name="searchContext">searchContext.</param>
        public FilterCountRequest(List<FilterClauseRequest> filterClauses = default(List<FilterClauseRequest>), CountQueryCriteria searchContext = default(CountQueryCriteria))
        {
            this.FilterClauses = filterClauses;
            this.SearchContext = searchContext;
        }
        
        /// <summary>
        /// Gets or Sets FilterClauses
        /// </summary>
        [DataMember(Name="filterClauses", EmitDefaultValue=false)]
        public List<FilterClauseRequest> FilterClauses { get; set; }

        /// <summary>
        /// Gets or Sets SearchContext
        /// </summary>
        [DataMember(Name="searchContext", EmitDefaultValue=false)]
        public CountQueryCriteria SearchContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterCountRequest {\n");
            sb.Append("  FilterClauses: ").Append(FilterClauses).Append("\n");
            sb.Append("  SearchContext: ").Append(SearchContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as FilterCountRequest);
        }

        /// <summary>
        /// Returns true if FilterCountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterCountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterCountRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterClauses == input.FilterClauses ||
                    this.FilterClauses != null &&
                    this.FilterClauses.SequenceEqual(input.FilterClauses)
                ) && 
                (
                    this.SearchContext == input.SearchContext ||
                    (this.SearchContext != null &&
                    this.SearchContext.Equals(input.SearchContext))
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
                if (this.FilterClauses != null)
                    hashCode = hashCode * 59 + this.FilterClauses.GetHashCode();
                if (this.SearchContext != null)
                    hashCode = hashCode * 59 + this.SearchContext.GetHashCode();
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
