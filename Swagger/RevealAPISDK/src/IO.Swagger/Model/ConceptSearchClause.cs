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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ConceptSearchClause
    /// </summary>
    [DataContract]
    public partial class ConceptSearchClause :  IEquatable<ConceptSearchClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptSearchClause" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Concept">Concept.</param>
        /// <param name="Terms">Terms.</param>
        public ConceptSearchClause(SearchClauseType Type = default(SearchClauseType), string Concept = default(string), List<ConceptTerm> Terms = default(List<ConceptTerm>))
        {
            this.Type = Type;
            this.Concept = Concept;
            this.Terms = Terms;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SearchClauseType Type { get; set; }

        /// <summary>
        /// Gets or Sets Concept
        /// </summary>
        [DataMember(Name="concept", EmitDefaultValue=false)]
        public string Concept { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<ConceptTerm> Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConceptSearchClause {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Concept: ").Append(Concept).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as ConceptSearchClause);
        }

        /// <summary>
        /// Returns true if ConceptSearchClause instances are equal
        /// </summary>
        /// <param name="input">Instance of ConceptSearchClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConceptSearchClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Concept == input.Concept ||
                    (this.Concept != null &&
                    this.Concept.Equals(input.Concept))
                ) && 
                (
                    this.Terms == input.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(input.Terms)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Concept != null)
                    hashCode = hashCode * 59 + this.Concept.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
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
