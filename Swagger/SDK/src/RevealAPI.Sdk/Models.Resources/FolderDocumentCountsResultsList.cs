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
    /// FolderDocumentCountsResultsList
    /// </summary>
    [DataContract]
    public partial class FolderDocumentCountsResultsList :  IEquatable<FolderDocumentCountsResultsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDocumentCountsResultsList" /> class.
        /// </summary>
        /// <param name="aggregations">aggregations.</param>
        public FolderDocumentCountsResultsList(FolderDocumentCountsResultsListAggregations aggregations = default(FolderDocumentCountsResultsListAggregations))
        {
            this.Aggregations = aggregations;
        }
        
        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public FolderDocumentCountsResultsListAggregations Aggregations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDocumentCountsResultsList {\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
            return this.Equals(input as FolderDocumentCountsResultsList);
        }

        /// <summary>
        /// Returns true if FolderDocumentCountsResultsList instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderDocumentCountsResultsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderDocumentCountsResultsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aggregations == input.Aggregations ||
                    (this.Aggregations != null &&
                    this.Aggregations.Equals(input.Aggregations))
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
                if (this.Aggregations != null)
                    hashCode = hashCode * 59 + this.Aggregations.GetHashCode();
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
