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
    /// DocumentFieldCountResponse
    /// </summary>
    [DataContract]
    public partial class DocumentFieldCountResponse :  IEquatable<DocumentFieldCountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentFieldCountResponse" /> class.
        /// </summary>
        /// <param name="tracingId">tracingId.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="fieldDisplayName">fieldDisplayName.</param>
        /// <param name="totalResults">totalResults.</param>
        /// <param name="start">start.</param>
        /// <param name="values">values.</param>
        public DocumentFieldCountResponse(string tracingId = default(string), string fieldName = default(string), string fieldDisplayName = default(string), long? totalResults = default(long?), int? start = default(int?), List<DocumentFieldCountValues> values = default(List<DocumentFieldCountValues>))
        {
            this.TracingId = tracingId;
            this.FieldName = fieldName;
            this.FieldDisplayName = fieldDisplayName;
            this.TotalResults = totalResults;
            this.Start = start;
            this.Values = values;
        }
        
        /// <summary>
        /// Gets or Sets TracingId
        /// </summary>
        [DataMember(Name="tracingId", EmitDefaultValue=false)]
        public string TracingId { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets FieldDisplayName
        /// </summary>
        [DataMember(Name="fieldDisplayName", EmitDefaultValue=false)]
        public string FieldDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets TotalResults
        /// </summary>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public long? TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int? Start { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<DocumentFieldCountValues> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentFieldCountResponse {\n");
            sb.Append("  TracingId: ").Append(TracingId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FieldDisplayName: ").Append(FieldDisplayName).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as DocumentFieldCountResponse);
        }

        /// <summary>
        /// Returns true if DocumentFieldCountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentFieldCountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFieldCountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TracingId == input.TracingId ||
                    (this.TracingId != null &&
                    this.TracingId.Equals(input.TracingId))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FieldDisplayName == input.FieldDisplayName ||
                    (this.FieldDisplayName != null &&
                    this.FieldDisplayName.Equals(input.FieldDisplayName))
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    (this.TotalResults != null &&
                    this.TotalResults.Equals(input.TotalResults))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.TracingId != null)
                    hashCode = hashCode * 59 + this.TracingId.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FieldDisplayName != null)
                    hashCode = hashCode * 59 + this.FieldDisplayName.GetHashCode();
                if (this.TotalResults != null)
                    hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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