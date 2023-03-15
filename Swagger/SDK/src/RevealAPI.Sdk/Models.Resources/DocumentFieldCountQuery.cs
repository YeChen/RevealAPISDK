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
    /// DocumentFieldCountQuery
    /// </summary>
    [DataContract]
    public partial class DocumentFieldCountQuery :  IEquatable<DocumentFieldCountQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFieldCountQuery" /> class.
        /// </summary>
        /// <param name="documentQuery">documentQuery.</param>
        /// <param name="fields">fields.</param>
        /// <param name="sortByValue">sortByValue.</param>
        /// <param name="sortAscending">sortAscending.</param>
        public DocumentFieldCountQuery(DocumentQuery documentQuery = default(DocumentQuery), List<FieldCountFilter> fields = default(List<FieldCountFilter>), bool? sortByValue = default(bool?), bool? sortAscending = default(bool?))
        {
            this.DocumentQuery = documentQuery;
            this.Fields = fields;
            this.SortByValue = sortByValue;
            this.SortAscending = sortAscending;
        }
        
        /// <summary>
        /// Gets or Sets DocumentQuery
        /// </summary>
        [DataMember(Name="documentQuery", EmitDefaultValue=false)]
        public DocumentQuery DocumentQuery { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldCountFilter> Fields { get; set; }

        /// <summary>
        /// Gets or Sets SortByValue
        /// </summary>
        [DataMember(Name="sortByValue", EmitDefaultValue=false)]
        public bool? SortByValue { get; set; }

        /// <summary>
        /// Gets or Sets SortAscending
        /// </summary>
        [DataMember(Name="sortAscending", EmitDefaultValue=false)]
        public bool? SortAscending { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentFieldCountQuery {\n");
            sb.Append("  DocumentQuery: ").Append(DocumentQuery).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  SortByValue: ").Append(SortByValue).Append("\n");
            sb.Append("  SortAscending: ").Append(SortAscending).Append("\n");
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
            return this.Equals(input as DocumentFieldCountQuery);
        }

        /// <summary>
        /// Returns true if DocumentFieldCountQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentFieldCountQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFieldCountQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentQuery == input.DocumentQuery ||
                    (this.DocumentQuery != null &&
                    this.DocumentQuery.Equals(input.DocumentQuery))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.SortByValue == input.SortByValue ||
                    (this.SortByValue != null &&
                    this.SortByValue.Equals(input.SortByValue))
                ) && 
                (
                    this.SortAscending == input.SortAscending ||
                    (this.SortAscending != null &&
                    this.SortAscending.Equals(input.SortAscending))
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
                if (this.DocumentQuery != null)
                    hashCode = hashCode * 59 + this.DocumentQuery.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.SortByValue != null)
                    hashCode = hashCode * 59 + this.SortByValue.GetHashCode();
                if (this.SortAscending != null)
                    hashCode = hashCode * 59 + this.SortAscending.GetHashCode();
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