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
    /// ProfileFieldInclusionItem
    /// </summary>
    [DataContract]
    public partial class ProfileFieldInclusionItem :  IEquatable<ProfileFieldInclusionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileFieldInclusionItem" /> class.
        /// </summary>
        /// <param name="isIncluded">isIncluded.</param>
        /// <param name="field">field.</param>
        public ProfileFieldInclusionItem(bool? isIncluded = default(bool?), FieldBasic field = default(FieldBasic))
        {
            this.IsIncluded = isIncluded;
            this.Field = field;
        }
        
        /// <summary>
        /// Gets or Sets IsIncluded
        /// </summary>
        [DataMember(Name="isIncluded", EmitDefaultValue=false)]
        public bool? IsIncluded { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldBasic Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileFieldInclusionItem {\n");
            sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as ProfileFieldInclusionItem);
        }

        /// <summary>
        /// Returns true if ProfileFieldInclusionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileFieldInclusionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileFieldInclusionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsIncluded == input.IsIncluded ||
                    (this.IsIncluded != null &&
                    this.IsIncluded.Equals(input.IsIncluded))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.IsIncluded != null)
                    hashCode = hashCode * 59 + this.IsIncluded.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
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
