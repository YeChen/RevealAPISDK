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
    /// PaginatedOfIEnumerableOfTranslateJob
    /// </summary>
    [DataContract]
    public partial class PaginatedOfIEnumerableOfTranslateJob :  IEquatable<PaginatedOfIEnumerableOfTranslateJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedOfIEnumerableOfTranslateJob" /> class.
        /// </summary>
        /// <param name="Start">Start.</param>
        /// <param name="Count">Count.</param>
        /// <param name="TotalResults">TotalResults.</param>
        /// <param name="Results">Results.</param>
        public PaginatedOfIEnumerableOfTranslateJob(long? Start = default(long?), long? Count = default(long?), long? TotalResults = default(long?), List<TranslateJob> Results = default(List<TranslateJob>))
        {
            this.Start = Start;
            this.Count = Count;
            this.TotalResults = TotalResults;
            this.Results = Results;
        }
        
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public long? Start { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or Sets TotalResults
        /// </summary>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public long? TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TranslateJob> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginatedOfIEnumerableOfTranslateJob {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as PaginatedOfIEnumerableOfTranslateJob);
        }

        /// <summary>
        /// Returns true if PaginatedOfIEnumerableOfTranslateJob instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedOfIEnumerableOfTranslateJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedOfIEnumerableOfTranslateJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    (this.TotalResults != null &&
                    this.TotalResults.Equals(input.TotalResults))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalResults != null)
                    hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
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
