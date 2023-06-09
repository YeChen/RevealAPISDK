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
    /// TagPaneGet
    /// </summary>
    [DataContract]
    public partial class TagPaneGet :  IEquatable<TagPaneGet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagPaneGet" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="profileId">profileId.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="modifiedByUserId">modifiedByUserId.</param>
        /// <param name="modifiedDateTime">modifiedDateTime.</param>
        /// <param name="tagPaneItems">tagPaneItems.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="displayOrder">displayOrder.</param>
        public TagPaneGet(int? id = default(int?), int? profileId = default(int?), int? createdByUserId = default(int?), DateTime? createdDateTime = default(DateTime?), int? modifiedByUserId = default(int?), DateTime? modifiedDateTime = default(DateTime?), List<TagPanelItemGet> tagPaneItems = default(List<TagPanelItemGet>), string name = default(string), string description = default(string), int? displayOrder = default(int?))
        {
            this.Id = id;
            this.ProfileId = profileId;
            this.CreatedByUserId = createdByUserId;
            this.CreatedDateTime = createdDateTime;
            this.ModifiedByUserId = modifiedByUserId;
            this.ModifiedDateTime = modifiedDateTime;
            this.TagPaneItems = tagPaneItems;
            this.Name = name;
            this.Description = description;
            this.DisplayOrder = displayOrder;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public int? ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByUserId
        /// </summary>
        [DataMember(Name="modifiedByUserId", EmitDefaultValue=false)]
        public int? ModifiedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTime
        /// </summary>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets TagPaneItems
        /// </summary>
        [DataMember(Name="tagPaneItems", EmitDefaultValue=false)]
        public List<TagPanelItemGet> TagPaneItems { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class TagPaneGet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  ModifiedByUserId: ").Append(ModifiedByUserId).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  TagPaneItems: ").Append(TagPaneItems).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TagPaneGet);
        }

        /// <summary>
        /// Returns true if TagPaneGet instances are equal
        /// </summary>
        /// <param name="input">Instance of TagPaneGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagPaneGet input)
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
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.ModifiedByUserId == input.ModifiedByUserId ||
                    (this.ModifiedByUserId != null &&
                    this.ModifiedByUserId.Equals(input.ModifiedByUserId))
                ) && 
                (
                    this.ModifiedDateTime == input.ModifiedDateTime ||
                    (this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(input.ModifiedDateTime))
                ) && 
                (
                    this.TagPaneItems == input.TagPaneItems ||
                    this.TagPaneItems != null &&
                    this.TagPaneItems.SequenceEqual(input.TagPaneItems)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.ModifiedByUserId != null)
                    hashCode = hashCode * 59 + this.ModifiedByUserId.GetHashCode();
                if (this.ModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.ModifiedDateTime.GetHashCode();
                if (this.TagPaneItems != null)
                    hashCode = hashCode * 59 + this.TagPaneItems.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
