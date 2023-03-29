/* 
 * Reveal API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = RevealAPI.V1.Client.SwaggerDateConverter;

namespace RevealAPI.V1.Models.Resources
{
    /// <summary>
    /// WordList
    /// </summary>
    [DataContract]
    public partial class WordList :  IEquatable<WordList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordList" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="words">words.</param>
        /// <param name="backgroundColor">backgroundColor.</param>
        /// <param name="textColor">textColor.</param>
        /// <param name="highlightName">highlightName.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDate">createdDate.</param>
        public WordList(string name = default(string), List<string> words = default(List<string>), string backgroundColor = default(string), string textColor = default(string), string highlightName = default(string), int? isActive = default(int?), int? createdBy = default(int?), DateTime? createdDate = default(DateTime?))
        {
            this.Name = name;
            this.Words = words;
            this.BackgroundColor = backgroundColor;
            this.TextColor = textColor;
            this.HighlightName = highlightName;
            this.IsActive = isActive;
            this.CreatedBy = createdBy;
            this.CreatedDate = createdDate;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Words
        /// </summary>
        [DataMember(Name="words", EmitDefaultValue=false)]
        public List<string> Words { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets TextColor
        /// </summary>
        [DataMember(Name="textColor", EmitDefaultValue=false)]
        public string TextColor { get; set; }

        /// <summary>
        /// Gets or Sets HighlightName
        /// </summary>
        [DataMember(Name="highlightName", EmitDefaultValue=false)]
        public string HighlightName { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public int? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordList {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  TextColor: ").Append(TextColor).Append("\n");
            sb.Append("  HighlightName: ").Append(HighlightName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(input as WordList);
        }

        /// <summary>
        /// Returns true if WordList instances are equal
        /// </summary>
        /// <param name="input">Instance of WordList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WordList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Words == input.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(input.Words)
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.TextColor == input.TextColor ||
                    (this.TextColor != null &&
                    this.TextColor.Equals(input.TextColor))
                ) && 
                (
                    this.HighlightName == input.HighlightName ||
                    (this.HighlightName != null &&
                    this.HighlightName.Equals(input.HighlightName))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
                if (this.BackgroundColor != null)
                    hashCode = hashCode * 59 + this.BackgroundColor.GetHashCode();
                if (this.TextColor != null)
                    hashCode = hashCode * 59 + this.TextColor.GetHashCode();
                if (this.HighlightName != null)
                    hashCode = hashCode * 59 + this.HighlightName.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
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