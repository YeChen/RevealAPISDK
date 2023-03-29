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
    /// FieldIdVisibleAssociation
    /// </summary>
    [DataContract]
    public partial class FieldIdVisibleAssociation :  IEquatable<FieldIdVisibleAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldIdVisibleAssociation" /> class.
        /// </summary>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="isVisible">isVisible.</param>
        public FieldIdVisibleAssociation(long? fieldId = default(long?), bool? isVisible = default(bool?))
        {
            this.FieldId = fieldId;
            this.IsVisible = isVisible;
        }
        
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public long? FieldId { get; set; }

        /// <summary>
        /// Gets or Sets IsVisible
        /// </summary>
        [DataMember(Name="isVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldIdVisibleAssociation {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
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
            return this.Equals(input as FieldIdVisibleAssociation);
        }

        /// <summary>
        /// Returns true if FieldIdVisibleAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldIdVisibleAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldIdVisibleAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
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