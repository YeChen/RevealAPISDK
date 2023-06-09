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
    /// ModelStatistics
    /// </summary>
    [DataContract]
    public partial class ModelStatistics :  IEquatable<ModelStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatistics" /> class.
        /// </summary>
        /// <param name="reviewedCount">reviewedCount.</param>
        /// <param name="score">score.</param>
        /// <param name="rounds">rounds.</param>
        /// <param name="status">status.</param>
        /// <param name="precision">precision.</param>
        /// <param name="recall">recall.</param>
        /// <param name="f1">f1.</param>
        /// <param name="stabilityIsClickable">stabilityIsClickable.</param>
        public ModelStatistics(int? reviewedCount = default(int?), double? score = default(double?), int? rounds = default(int?), string status = default(string), double? precision = default(double?), double? recall = default(double?), double? f1 = default(double?), bool? stabilityIsClickable = default(bool?))
        {
            this.ReviewedCount = reviewedCount;
            this.Score = score;
            this.Rounds = rounds;
            this.Status = status;
            this.Precision = precision;
            this.Recall = recall;
            this.F1 = f1;
            this.StabilityIsClickable = stabilityIsClickable;
        }
        
        /// <summary>
        /// Gets or Sets ReviewedCount
        /// </summary>
        [DataMember(Name="reviewedCount", EmitDefaultValue=false)]
        public int? ReviewedCount { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or Sets Rounds
        /// </summary>
        [DataMember(Name="rounds", EmitDefaultValue=false)]
        public int? Rounds { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Precision
        /// </summary>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public double? Precision { get; set; }

        /// <summary>
        /// Gets or Sets Recall
        /// </summary>
        [DataMember(Name="recall", EmitDefaultValue=false)]
        public double? Recall { get; set; }

        /// <summary>
        /// Gets or Sets F1
        /// </summary>
        [DataMember(Name="f1", EmitDefaultValue=false)]
        public double? F1 { get; set; }

        /// <summary>
        /// Gets or Sets StabilityIsClickable
        /// </summary>
        [DataMember(Name="stabilityIsClickable", EmitDefaultValue=false)]
        public bool? StabilityIsClickable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelStatistics {\n");
            sb.Append("  ReviewedCount: ").Append(ReviewedCount).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Rounds: ").Append(Rounds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  Recall: ").Append(Recall).Append("\n");
            sb.Append("  F1: ").Append(F1).Append("\n");
            sb.Append("  StabilityIsClickable: ").Append(StabilityIsClickable).Append("\n");
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
            return this.Equals(input as ModelStatistics);
        }

        /// <summary>
        /// Returns true if ModelStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReviewedCount == input.ReviewedCount ||
                    (this.ReviewedCount != null &&
                    this.ReviewedCount.Equals(input.ReviewedCount))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Rounds == input.Rounds ||
                    (this.Rounds != null &&
                    this.Rounds.Equals(input.Rounds))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
                ) && 
                (
                    this.Recall == input.Recall ||
                    (this.Recall != null &&
                    this.Recall.Equals(input.Recall))
                ) && 
                (
                    this.F1 == input.F1 ||
                    (this.F1 != null &&
                    this.F1.Equals(input.F1))
                ) && 
                (
                    this.StabilityIsClickable == input.StabilityIsClickable ||
                    (this.StabilityIsClickable != null &&
                    this.StabilityIsClickable.Equals(input.StabilityIsClickable))
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
                if (this.ReviewedCount != null)
                    hashCode = hashCode * 59 + this.ReviewedCount.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Rounds != null)
                    hashCode = hashCode * 59 + this.Rounds.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.Recall != null)
                    hashCode = hashCode * 59 + this.Recall.GetHashCode();
                if (this.F1 != null)
                    hashCode = hashCode * 59 + this.F1.GetHashCode();
                if (this.StabilityIsClickable != null)
                    hashCode = hashCode * 59 + this.StabilityIsClickable.GetHashCode();
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
