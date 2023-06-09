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
    /// TagPaneCreate
    /// </summary>
    [DataContract]
    public partial class TagPaneCreate :  IEquatable<TagPaneCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagPaneCreate" /> class.
        /// </summary>
        /// <param name="profileName">profileName.</param>
        /// <param name="paneName">paneName.</param>
        /// <param name="description">description.</param>
        /// <param name="displayOrder">displayOrder.</param>
        public TagPaneCreate(string profileName = default(string), string paneName = default(string), string description = default(string), int? displayOrder = default(int?))
        {
            this.ProfileName = profileName;
            this.PaneName = paneName;
            this.Description = description;
            this.DisplayOrder = displayOrder;
        }
        
        /// <summary>
        /// Gets or Sets ProfileName
        /// </summary>
        [DataMember(Name="profileName", EmitDefaultValue=false)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Gets or Sets PaneName
        /// </summary>
        [DataMember(Name="paneName", EmitDefaultValue=false)]
        public string PaneName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagPaneCreate {\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  PaneName: ").Append(PaneName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
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
            return this.Equals(input as TagPaneCreate);
        }

        /// <summary>
        /// Returns true if TagPaneCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TagPaneCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagPaneCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
                ) && 
                (
                    this.PaneName == input.PaneName ||
                    (this.PaneName != null &&
                    this.PaneName.Equals(input.PaneName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
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
                if (this.ProfileName != null)
                    hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                if (this.PaneName != null)
                    hashCode = hashCode * 59 + this.PaneName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
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
