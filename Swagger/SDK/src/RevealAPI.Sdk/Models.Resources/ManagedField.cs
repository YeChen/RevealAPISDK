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
    /// ManagedField
    /// </summary>
    [DataContract]
    public partial class ManagedField :  IEquatable<ManagedField>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public FieldDataType? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedField" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="displayOrder">displayOrder.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="isVisible">isVisible.</param>
        /// <param name="isUpdatable">isUpdatable.</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="isSortable">isSortable.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="isProductionUpdatable">isProductionUpdatable.</param>
        /// <param name="displayLines">displayLines.</param>
        /// <param name="fieldLength">fieldLength.</param>
        /// <param name="isLinked">isLinked.</param>
        /// <param name="linkedListId">linkedListId.</param>
        /// <param name="linkedDataType">linkedDataType.</param>
        /// <param name="isLinkedListUpdatable">isLinkedListUpdatable.</param>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="isMultiValue">isMultiValue.</param>
        /// <param name="isImportable">isImportable.</param>
        /// <param name="isSpecial">isSpecial.</param>
        /// <param name="isSortDescending">isSortDescending.</param>
        /// <param name="faceted">faceted.</param>
        /// <param name="hasExactText">hasExactText.</param>
        /// <param name="indexed">indexed.</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="stored">stored.</param>
        /// <param name="type">type.</param>
        public ManagedField(long? id = default(long?), string name = default(string), string description = default(string), int? displayOrder = default(int?), FieldDataType? dataType = default(FieldDataType?), string displayName = default(string), bool? isVisible = default(bool?), bool? isUpdatable = default(bool?), bool? isRequired = default(bool?), bool? isSortable = default(bool?), int? sortOrder = default(int?), bool? isProductionUpdatable = default(bool?), int? displayLines = default(int?), int? fieldLength = default(int?), bool? isLinked = default(bool?), int? linkedListId = default(int?), string linkedDataType = default(string), bool? isLinkedListUpdatable = default(bool?), int? fieldId = default(int?), bool? isMultiValue = default(bool?), bool? isImportable = default(bool?), bool? isSpecial = default(bool?), bool? isSortDescending = default(bool?), bool? faceted = default(bool?), string hasExactText = default(string), bool? indexed = default(bool?), bool? pinned = default(bool?), bool? stored = default(bool?), string type = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DisplayOrder = displayOrder;
            this.DataType = dataType;
            this.DisplayName = displayName;
            this.IsVisible = isVisible;
            this.IsUpdatable = isUpdatable;
            this.IsRequired = isRequired;
            this.IsSortable = isSortable;
            this.SortOrder = sortOrder;
            this.IsProductionUpdatable = isProductionUpdatable;
            this.DisplayLines = displayLines;
            this.FieldLength = fieldLength;
            this.IsLinked = isLinked;
            this.LinkedListId = linkedListId;
            this.LinkedDataType = linkedDataType;
            this.IsLinkedListUpdatable = isLinkedListUpdatable;
            this.FieldId = fieldId;
            this.IsMultiValue = isMultiValue;
            this.IsImportable = isImportable;
            this.IsSpecial = isSpecial;
            this.IsSortDescending = isSortDescending;
            this.Faceted = faceted;
            this.HasExactText = hasExactText;
            this.Indexed = indexed;
            this.Pinned = pinned;
            this.Stored = stored;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

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
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsVisible
        /// </summary>
        [DataMember(Name="isVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or Sets IsUpdatable
        /// </summary>
        [DataMember(Name="isUpdatable", EmitDefaultValue=false)]
        public bool? IsUpdatable { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets IsSortable
        /// </summary>
        [DataMember(Name="isSortable", EmitDefaultValue=false)]
        public bool? IsSortable { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets IsProductionUpdatable
        /// </summary>
        [DataMember(Name="isProductionUpdatable", EmitDefaultValue=false)]
        public bool? IsProductionUpdatable { get; set; }

        /// <summary>
        /// Gets or Sets DisplayLines
        /// </summary>
        [DataMember(Name="displayLines", EmitDefaultValue=false)]
        public int? DisplayLines { get; set; }

        /// <summary>
        /// Gets or Sets FieldLength
        /// </summary>
        [DataMember(Name="fieldLength", EmitDefaultValue=false)]
        public int? FieldLength { get; set; }

        /// <summary>
        /// Gets or Sets IsLinked
        /// </summary>
        [DataMember(Name="isLinked", EmitDefaultValue=false)]
        public bool? IsLinked { get; set; }

        /// <summary>
        /// Gets or Sets LinkedListId
        /// </summary>
        [DataMember(Name="linkedListId", EmitDefaultValue=false)]
        public int? LinkedListId { get; set; }

        /// <summary>
        /// Gets or Sets LinkedDataType
        /// </summary>
        [DataMember(Name="linkedDataType", EmitDefaultValue=false)]
        public string LinkedDataType { get; set; }

        /// <summary>
        /// Gets or Sets IsLinkedListUpdatable
        /// </summary>
        [DataMember(Name="isLinkedListUpdatable", EmitDefaultValue=false)]
        public bool? IsLinkedListUpdatable { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public int? FieldId { get; set; }

        /// <summary>
        /// Gets or Sets IsMultiValue
        /// </summary>
        [DataMember(Name="isMultiValue", EmitDefaultValue=false)]
        public bool? IsMultiValue { get; set; }

        /// <summary>
        /// Gets or Sets IsImportable
        /// </summary>
        [DataMember(Name="isImportable", EmitDefaultValue=false)]
        public bool? IsImportable { get; set; }

        /// <summary>
        /// Gets or Sets IsSpecial
        /// </summary>
        [DataMember(Name="isSpecial", EmitDefaultValue=false)]
        public bool? IsSpecial { get; set; }

        /// <summary>
        /// Gets or Sets IsSortDescending
        /// </summary>
        [DataMember(Name="isSortDescending", EmitDefaultValue=false)]
        public bool? IsSortDescending { get; set; }

        /// <summary>
        /// Gets or Sets Faceted
        /// </summary>
        [DataMember(Name="faceted", EmitDefaultValue=false)]
        public bool? Faceted { get; set; }

        /// <summary>
        /// Gets or Sets HasExactText
        /// </summary>
        [DataMember(Name="hasExactText", EmitDefaultValue=false)]
        public string HasExactText { get; set; }

        /// <summary>
        /// Gets or Sets Indexed
        /// </summary>
        [DataMember(Name="indexed", EmitDefaultValue=false)]
        public bool? Indexed { get; set; }

        /// <summary>
        /// Gets or Sets MultiValued
        /// </summary>
        [DataMember(Name="multiValued", EmitDefaultValue=false)]
        public bool? MultiValued { get; private set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Gets or Sets Stored
        /// </summary>
        [DataMember(Name="stored", EmitDefaultValue=false)]
        public bool? Stored { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  IsUpdatable: ").Append(IsUpdatable).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsSortable: ").Append(IsSortable).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  IsProductionUpdatable: ").Append(IsProductionUpdatable).Append("\n");
            sb.Append("  DisplayLines: ").Append(DisplayLines).Append("\n");
            sb.Append("  FieldLength: ").Append(FieldLength).Append("\n");
            sb.Append("  IsLinked: ").Append(IsLinked).Append("\n");
            sb.Append("  LinkedListId: ").Append(LinkedListId).Append("\n");
            sb.Append("  LinkedDataType: ").Append(LinkedDataType).Append("\n");
            sb.Append("  IsLinkedListUpdatable: ").Append(IsLinkedListUpdatable).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  IsMultiValue: ").Append(IsMultiValue).Append("\n");
            sb.Append("  IsImportable: ").Append(IsImportable).Append("\n");
            sb.Append("  IsSpecial: ").Append(IsSpecial).Append("\n");
            sb.Append("  IsSortDescending: ").Append(IsSortDescending).Append("\n");
            sb.Append("  Faceted: ").Append(Faceted).Append("\n");
            sb.Append("  HasExactText: ").Append(HasExactText).Append("\n");
            sb.Append("  Indexed: ").Append(Indexed).Append("\n");
            sb.Append("  MultiValued: ").Append(MultiValued).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  Stored: ").Append(Stored).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ManagedField);
        }

        /// <summary>
        /// Returns true if ManagedField instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagedField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagedField input)
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
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.IsUpdatable == input.IsUpdatable ||
                    (this.IsUpdatable != null &&
                    this.IsUpdatable.Equals(input.IsUpdatable))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.IsSortable == input.IsSortable ||
                    (this.IsSortable != null &&
                    this.IsSortable.Equals(input.IsSortable))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.IsProductionUpdatable == input.IsProductionUpdatable ||
                    (this.IsProductionUpdatable != null &&
                    this.IsProductionUpdatable.Equals(input.IsProductionUpdatable))
                ) && 
                (
                    this.DisplayLines == input.DisplayLines ||
                    (this.DisplayLines != null &&
                    this.DisplayLines.Equals(input.DisplayLines))
                ) && 
                (
                    this.FieldLength == input.FieldLength ||
                    (this.FieldLength != null &&
                    this.FieldLength.Equals(input.FieldLength))
                ) && 
                (
                    this.IsLinked == input.IsLinked ||
                    (this.IsLinked != null &&
                    this.IsLinked.Equals(input.IsLinked))
                ) && 
                (
                    this.LinkedListId == input.LinkedListId ||
                    (this.LinkedListId != null &&
                    this.LinkedListId.Equals(input.LinkedListId))
                ) && 
                (
                    this.LinkedDataType == input.LinkedDataType ||
                    (this.LinkedDataType != null &&
                    this.LinkedDataType.Equals(input.LinkedDataType))
                ) && 
                (
                    this.IsLinkedListUpdatable == input.IsLinkedListUpdatable ||
                    (this.IsLinkedListUpdatable != null &&
                    this.IsLinkedListUpdatable.Equals(input.IsLinkedListUpdatable))
                ) && 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.IsMultiValue == input.IsMultiValue ||
                    (this.IsMultiValue != null &&
                    this.IsMultiValue.Equals(input.IsMultiValue))
                ) && 
                (
                    this.IsImportable == input.IsImportable ||
                    (this.IsImportable != null &&
                    this.IsImportable.Equals(input.IsImportable))
                ) && 
                (
                    this.IsSpecial == input.IsSpecial ||
                    (this.IsSpecial != null &&
                    this.IsSpecial.Equals(input.IsSpecial))
                ) && 
                (
                    this.IsSortDescending == input.IsSortDescending ||
                    (this.IsSortDescending != null &&
                    this.IsSortDescending.Equals(input.IsSortDescending))
                ) && 
                (
                    this.Faceted == input.Faceted ||
                    (this.Faceted != null &&
                    this.Faceted.Equals(input.Faceted))
                ) && 
                (
                    this.HasExactText == input.HasExactText ||
                    (this.HasExactText != null &&
                    this.HasExactText.Equals(input.HasExactText))
                ) && 
                (
                    this.Indexed == input.Indexed ||
                    (this.Indexed != null &&
                    this.Indexed.Equals(input.Indexed))
                ) && 
                (
                    this.MultiValued == input.MultiValued ||
                    (this.MultiValued != null &&
                    this.MultiValued.Equals(input.MultiValued))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
                ) && 
                (
                    this.Stored == input.Stored ||
                    (this.Stored != null &&
                    this.Stored.Equals(input.Stored))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.IsUpdatable != null)
                    hashCode = hashCode * 59 + this.IsUpdatable.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.IsSortable != null)
                    hashCode = hashCode * 59 + this.IsSortable.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.IsProductionUpdatable != null)
                    hashCode = hashCode * 59 + this.IsProductionUpdatable.GetHashCode();
                if (this.DisplayLines != null)
                    hashCode = hashCode * 59 + this.DisplayLines.GetHashCode();
                if (this.FieldLength != null)
                    hashCode = hashCode * 59 + this.FieldLength.GetHashCode();
                if (this.IsLinked != null)
                    hashCode = hashCode * 59 + this.IsLinked.GetHashCode();
                if (this.LinkedListId != null)
                    hashCode = hashCode * 59 + this.LinkedListId.GetHashCode();
                if (this.LinkedDataType != null)
                    hashCode = hashCode * 59 + this.LinkedDataType.GetHashCode();
                if (this.IsLinkedListUpdatable != null)
                    hashCode = hashCode * 59 + this.IsLinkedListUpdatable.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.IsMultiValue != null)
                    hashCode = hashCode * 59 + this.IsMultiValue.GetHashCode();
                if (this.IsImportable != null)
                    hashCode = hashCode * 59 + this.IsImportable.GetHashCode();
                if (this.IsSpecial != null)
                    hashCode = hashCode * 59 + this.IsSpecial.GetHashCode();
                if (this.IsSortDescending != null)
                    hashCode = hashCode * 59 + this.IsSortDescending.GetHashCode();
                if (this.Faceted != null)
                    hashCode = hashCode * 59 + this.Faceted.GetHashCode();
                if (this.HasExactText != null)
                    hashCode = hashCode * 59 + this.HasExactText.GetHashCode();
                if (this.Indexed != null)
                    hashCode = hashCode * 59 + this.Indexed.GetHashCode();
                if (this.MultiValued != null)
                    hashCode = hashCode * 59 + this.MultiValued.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
                if (this.Stored != null)
                    hashCode = hashCode * 59 + this.Stored.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
