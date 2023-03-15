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
    /// TagSet
    /// </summary>
    [DataContract]
    public partial class TagSet :  IEquatable<TagSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagSet" /> class.
        /// </summary>
        /// <param name="tagSetId">tagSetId.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="isRecursive">isRecursive.</param>
        /// <param name="tags">tags.</param>
        public TagSet(int? tagSetId = default(int?), string name = default(string), int? type = default(int?), bool? isRecursive = default(bool?), List<Tag> tags = default(List<Tag>))
        {
            this.TagSetId = tagSetId;
            this.Name = name;
            this.Type = type;
            this.IsRecursive = isRecursive;
            this.Tags = tags;
        }
        
        /// <summary>
        /// Gets or Sets TagSetId
        /// </summary>
        [DataMember(Name="tagSetId", EmitDefaultValue=false)]
        public int? TagSetId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets IsRecursive
        /// </summary>
        [DataMember(Name="isRecursive", EmitDefaultValue=false)]
        public bool? IsRecursive { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagSet {\n");
            sb.Append("  TagSetId: ").Append(TagSetId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsRecursive: ").Append(IsRecursive).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as TagSet);
        }

        /// <summary>
        /// Returns true if TagSet instances are equal
        /// </summary>
        /// <param name="input">Instance of TagSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagSetId == input.TagSetId ||
                    (this.TagSetId != null &&
                    this.TagSetId.Equals(input.TagSetId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsRecursive == input.IsRecursive ||
                    (this.IsRecursive != null &&
                    this.IsRecursive.Equals(input.IsRecursive))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.TagSetId != null)
                    hashCode = hashCode * 59 + this.TagSetId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsRecursive != null)
                    hashCode = hashCode * 59 + this.IsRecursive.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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