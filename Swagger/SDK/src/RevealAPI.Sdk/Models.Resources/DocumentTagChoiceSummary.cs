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
    /// DocumentTagChoiceSummary
    /// </summary>
    [DataContract]
    public partial class DocumentTagChoiceSummary :  IEquatable<DocumentTagChoiceSummary>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TagStatus
        /// </summary>
        [DataMember(Name="tagStatus", EmitDefaultValue=false)]
        public TagStatus? TagStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTagChoiceSummary" /> class.
        /// </summary>
        /// <param name="tagId">tagId.</param>
        /// <param name="tagName">tagName.</param>
        /// <param name="tagStatus">tagStatus.</param>
        /// <param name="remoteName">remoteName.</param>
        /// <param name="tagType">tagType.</param>
        /// <param name="tagPredictionScore">tagPredictionScore.</param>
        /// <param name="choiceValues">choiceValues.</param>
        public DocumentTagChoiceSummary(int? tagId = default(int?), string tagName = default(string), TagStatus? tagStatus = default(TagStatus?), string remoteName = default(string), int? tagType = default(int?), int? tagPredictionScore = default(int?), List<TagSummaryTagChoice> choiceValues = default(List<TagSummaryTagChoice>))
        {
            this.TagId = tagId;
            this.TagName = tagName;
            this.TagStatus = tagStatus;
            this.RemoteName = remoteName;
            this.TagType = tagType;
            this.TagPredictionScore = tagPredictionScore;
            this.ChoiceValues = choiceValues;
        }
        
        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId", EmitDefaultValue=false)]
        public int? TagId { get; set; }

        /// <summary>
        /// Gets or Sets TagName
        /// </summary>
        [DataMember(Name="tagName", EmitDefaultValue=false)]
        public string TagName { get; set; }


        /// <summary>
        /// Gets or Sets RemoteName
        /// </summary>
        [DataMember(Name="remoteName", EmitDefaultValue=false)]
        public string RemoteName { get; set; }

        /// <summary>
        /// Gets or Sets TagType
        /// </summary>
        [DataMember(Name="tagType", EmitDefaultValue=false)]
        public int? TagType { get; set; }

        /// <summary>
        /// Gets or Sets TagPredictionScore
        /// </summary>
        [DataMember(Name="tagPredictionScore", EmitDefaultValue=false)]
        public int? TagPredictionScore { get; set; }

        /// <summary>
        /// Gets or Sets ChoiceValues
        /// </summary>
        [DataMember(Name="choiceValues", EmitDefaultValue=false)]
        public List<TagSummaryTagChoice> ChoiceValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTagChoiceSummary {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  TagName: ").Append(TagName).Append("\n");
            sb.Append("  TagStatus: ").Append(TagStatus).Append("\n");
            sb.Append("  RemoteName: ").Append(RemoteName).Append("\n");
            sb.Append("  TagType: ").Append(TagType).Append("\n");
            sb.Append("  TagPredictionScore: ").Append(TagPredictionScore).Append("\n");
            sb.Append("  ChoiceValues: ").Append(ChoiceValues).Append("\n");
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
            return this.Equals(input as DocumentTagChoiceSummary);
        }

        /// <summary>
        /// Returns true if DocumentTagChoiceSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTagChoiceSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTagChoiceSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.TagName == input.TagName ||
                    (this.TagName != null &&
                    this.TagName.Equals(input.TagName))
                ) && 
                (
                    this.TagStatus == input.TagStatus ||
                    (this.TagStatus != null &&
                    this.TagStatus.Equals(input.TagStatus))
                ) && 
                (
                    this.RemoteName == input.RemoteName ||
                    (this.RemoteName != null &&
                    this.RemoteName.Equals(input.RemoteName))
                ) && 
                (
                    this.TagType == input.TagType ||
                    (this.TagType != null &&
                    this.TagType.Equals(input.TagType))
                ) && 
                (
                    this.TagPredictionScore == input.TagPredictionScore ||
                    (this.TagPredictionScore != null &&
                    this.TagPredictionScore.Equals(input.TagPredictionScore))
                ) && 
                (
                    this.ChoiceValues == input.ChoiceValues ||
                    this.ChoiceValues != null &&
                    this.ChoiceValues.SequenceEqual(input.ChoiceValues)
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
                if (this.TagId != null)
                    hashCode = hashCode * 59 + this.TagId.GetHashCode();
                if (this.TagName != null)
                    hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.TagStatus != null)
                    hashCode = hashCode * 59 + this.TagStatus.GetHashCode();
                if (this.RemoteName != null)
                    hashCode = hashCode * 59 + this.RemoteName.GetHashCode();
                if (this.TagType != null)
                    hashCode = hashCode * 59 + this.TagType.GetHashCode();
                if (this.TagPredictionScore != null)
                    hashCode = hashCode * 59 + this.TagPredictionScore.GetHashCode();
                if (this.ChoiceValues != null)
                    hashCode = hashCode * 59 + this.ChoiceValues.GetHashCode();
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
