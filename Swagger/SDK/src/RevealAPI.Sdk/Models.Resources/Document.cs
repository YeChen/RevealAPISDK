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
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="index">The index of the document with respect to the current search context.</param>
        /// <param name="score">score.</param>
        /// <param name="relativeScore">relativeScore.</param>
        /// <param name="familyCount">familyCount.</param>
        /// <param name="hitInContext">hitInContext.</param>
        /// <param name="tagChoiceSummaries">tagChoiceSummaries.</param>
        /// <param name="fields">fields.</param>
        public Document(long? id = default(long?), int? index = default(int?), double? score = default(double?), long? relativeScore = default(long?), long? familyCount = default(long?), long? hitInContext = default(long?), List<DocumentTagChoiceSummary> tagChoiceSummaries = default(List<DocumentTagChoiceSummary>), Dictionary<string, Object> fields = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.Index = index;
            this.Score = score;
            this.RelativeScore = relativeScore;
            this.FamilyCount = familyCount;
            this.HitInContext = hitInContext;
            this.TagChoiceSummaries = tagChoiceSummaries;
            this.Fields = fields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The index of the document with respect to the current search context
        /// </summary>
        /// <value>The index of the document with respect to the current search context</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or Sets RelativeScore
        /// </summary>
        [DataMember(Name="relativeScore", EmitDefaultValue=false)]
        public long? RelativeScore { get; set; }

        /// <summary>
        /// Gets or Sets FamilyCount
        /// </summary>
        [DataMember(Name="familyCount", EmitDefaultValue=false)]
        public long? FamilyCount { get; set; }

        /// <summary>
        /// Gets or Sets HitInContext
        /// </summary>
        [DataMember(Name="hitInContext", EmitDefaultValue=false)]
        public long? HitInContext { get; set; }

        /// <summary>
        /// Gets or Sets TagChoiceSummaries
        /// </summary>
        [DataMember(Name="tagChoiceSummaries", EmitDefaultValue=false)]
        public List<DocumentTagChoiceSummary> TagChoiceSummaries { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  RelativeScore: ").Append(RelativeScore).Append("\n");
            sb.Append("  FamilyCount: ").Append(FamilyCount).Append("\n");
            sb.Append("  HitInContext: ").Append(HitInContext).Append("\n");
            sb.Append("  TagChoiceSummaries: ").Append(TagChoiceSummaries).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.RelativeScore == input.RelativeScore ||
                    (this.RelativeScore != null &&
                    this.RelativeScore.Equals(input.RelativeScore))
                ) && 
                (
                    this.FamilyCount == input.FamilyCount ||
                    (this.FamilyCount != null &&
                    this.FamilyCount.Equals(input.FamilyCount))
                ) && 
                (
                    this.HitInContext == input.HitInContext ||
                    (this.HitInContext != null &&
                    this.HitInContext.Equals(input.HitInContext))
                ) && 
                (
                    this.TagChoiceSummaries == input.TagChoiceSummaries ||
                    this.TagChoiceSummaries != null &&
                    this.TagChoiceSummaries.SequenceEqual(input.TagChoiceSummaries)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.RelativeScore != null)
                    hashCode = hashCode * 59 + this.RelativeScore.GetHashCode();
                if (this.FamilyCount != null)
                    hashCode = hashCode * 59 + this.FamilyCount.GetHashCode();
                if (this.HitInContext != null)
                    hashCode = hashCode * 59 + this.HitInContext.GetHashCode();
                if (this.TagChoiceSummaries != null)
                    hashCode = hashCode * 59 + this.TagChoiceSummaries.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
