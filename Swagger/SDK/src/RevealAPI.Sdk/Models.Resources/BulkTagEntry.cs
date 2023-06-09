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
    /// BulkTagEntry
    /// </summary>
    [DataContract]
    public partial class BulkTagEntry :  IEquatable<BulkTagEntry>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UpdateOption
        /// </summary>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public BulkTagUpdateOption? UpdateOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTagEntry" /> class.
        /// </summary>
        /// <param name="tagProfileId">tagProfileId.</param>
        /// <param name="tagChoiceIds">tagChoiceIds.</param>
        /// <param name="updateOption">updateOption.</param>
        public BulkTagEntry(int? tagProfileId = default(int?), List<int?> tagChoiceIds = default(List<int?>), BulkTagUpdateOption? updateOption = default(BulkTagUpdateOption?))
        {
            this.TagProfileId = tagProfileId;
            this.TagChoiceIds = tagChoiceIds;
            this.UpdateOption = updateOption;
        }
        
        /// <summary>
        /// Gets or Sets TagProfileId
        /// </summary>
        [DataMember(Name="tagProfileId", EmitDefaultValue=false)]
        public int? TagProfileId { get; set; }

        /// <summary>
        /// Gets or Sets TagChoiceIds
        /// </summary>
        [DataMember(Name="tagChoiceIds", EmitDefaultValue=false)]
        public List<int?> TagChoiceIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkTagEntry {\n");
            sb.Append("  TagProfileId: ").Append(TagProfileId).Append("\n");
            sb.Append("  TagChoiceIds: ").Append(TagChoiceIds).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
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
            return this.Equals(input as BulkTagEntry);
        }

        /// <summary>
        /// Returns true if BulkTagEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkTagEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkTagEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagProfileId == input.TagProfileId ||
                    (this.TagProfileId != null &&
                    this.TagProfileId.Equals(input.TagProfileId))
                ) && 
                (
                    this.TagChoiceIds == input.TagChoiceIds ||
                    this.TagChoiceIds != null &&
                    this.TagChoiceIds.SequenceEqual(input.TagChoiceIds)
                ) && 
                (
                    this.UpdateOption == input.UpdateOption ||
                    (this.UpdateOption != null &&
                    this.UpdateOption.Equals(input.UpdateOption))
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
                if (this.TagProfileId != null)
                    hashCode = hashCode * 59 + this.TagProfileId.GetHashCode();
                if (this.TagChoiceIds != null)
                    hashCode = hashCode * 59 + this.TagChoiceIds.GetHashCode();
                if (this.UpdateOption != null)
                    hashCode = hashCode * 59 + this.UpdateOption.GetHashCode();
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
