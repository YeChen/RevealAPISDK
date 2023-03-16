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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Field
    /// </summary>
    [DataContract]
    public partial class Field :  IEquatable<Field>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="DataType">DataType.</param>
        /// <param name="MaxLength">MaxLength.</param>
        /// <param name="DataTypeDesc">DataTypeDesc.</param>
        /// <param name="IsTranscriptLookup">IsTranscriptLookup.</param>
        /// <param name="IsSearchable">IsSearchable.</param>
        /// <param name="IsUpdatable">IsUpdatable.</param>
        /// <param name="IsProductionUpdatable">IsProductionUpdatable.</param>
        /// <param name="IsMultiValue">IsMultiValue.</param>
        /// <param name="IsCustomField">IsCustomField.</param>
        /// <param name="IsImportable">IsImportable.</param>
        /// <param name="IsNativeFileField">IsNativeFileField.</param>
        /// <param name="IsSortable">IsSortable.</param>
        /// <param name="IsFacetable">IsFacetable.</param>
        /// <param name="HasExactText">HasExactText.</param>
        /// <param name="Indexed">Indexed.</param>
        /// <param name="Pinned">Pinned.</param>
        /// <param name="Stored">Stored.</param>
        /// <param name="Type">Type.</param>
        public Field(int? FieldId = default(int?), string FieldName = default(string), string DisplayName = default(string), string DataType = default(string), int? MaxLength = default(int?), string DataTypeDesc = default(string), bool? IsTranscriptLookup = default(bool?), bool? IsSearchable = default(bool?), bool? IsUpdatable = default(bool?), bool? IsProductionUpdatable = default(bool?), bool? IsMultiValue = default(bool?), bool? IsCustomField = default(bool?), bool? IsImportable = default(bool?), bool? IsNativeFileField = default(bool?), bool? IsSortable = default(bool?), bool? IsFacetable = default(bool?), bool? HasExactText = default(bool?), bool? Indexed = default(bool?), bool? Pinned = default(bool?), bool? Stored = default(bool?), string Type = default(string))
        {
            this.FieldId = FieldId;
            this.FieldName = FieldName;
            this.DisplayName = DisplayName;
            this.DataType = DataType;
            this.MaxLength = MaxLength;
            this.DataTypeDesc = DataTypeDesc;
            this.IsTranscriptLookup = IsTranscriptLookup;
            this.IsSearchable = IsSearchable;
            this.IsUpdatable = IsUpdatable;
            this.IsProductionUpdatable = IsProductionUpdatable;
            this.IsMultiValue = IsMultiValue;
            this.IsCustomField = IsCustomField;
            this.IsImportable = IsImportable;
            this.IsNativeFileField = IsNativeFileField;
            this.IsSortable = IsSortable;
            this.IsFacetable = IsFacetable;
            this.HasExactText = HasExactText;
            this.Indexed = Indexed;
            this.Pinned = Pinned;
            this.Stored = Stored;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public int? FieldId { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeDesc
        /// </summary>
        [DataMember(Name="dataTypeDesc", EmitDefaultValue=false)]
        public string DataTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets IsTranscriptLookup
        /// </summary>
        [DataMember(Name="isTranscriptLookup", EmitDefaultValue=false)]
        public bool? IsTranscriptLookup { get; set; }

        /// <summary>
        /// Gets or Sets IsSearchable
        /// </summary>
        [DataMember(Name="isSearchable", EmitDefaultValue=false)]
        public bool? IsSearchable { get; set; }

        /// <summary>
        /// Gets or Sets IsUpdatable
        /// </summary>
        [DataMember(Name="isUpdatable", EmitDefaultValue=false)]
        public bool? IsUpdatable { get; set; }

        /// <summary>
        /// Gets or Sets IsProductionUpdatable
        /// </summary>
        [DataMember(Name="isProductionUpdatable", EmitDefaultValue=false)]
        public bool? IsProductionUpdatable { get; set; }

        /// <summary>
        /// Gets or Sets IsMultiValue
        /// </summary>
        [DataMember(Name="isMultiValue", EmitDefaultValue=false)]
        public bool? IsMultiValue { get; set; }

        /// <summary>
        /// Gets or Sets IsCustomField
        /// </summary>
        [DataMember(Name="isCustomField", EmitDefaultValue=false)]
        public bool? IsCustomField { get; set; }

        /// <summary>
        /// Gets or Sets IsImportable
        /// </summary>
        [DataMember(Name="isImportable", EmitDefaultValue=false)]
        public bool? IsImportable { get; set; }

        /// <summary>
        /// Gets or Sets IsNativeFileField
        /// </summary>
        [DataMember(Name="isNativeFileField", EmitDefaultValue=false)]
        public bool? IsNativeFileField { get; set; }

        /// <summary>
        /// Gets or Sets IsSortable
        /// </summary>
        [DataMember(Name="isSortable", EmitDefaultValue=false)]
        public bool? IsSortable { get; set; }

        /// <summary>
        /// Gets or Sets IsFacetable
        /// </summary>
        [DataMember(Name="isFacetable", EmitDefaultValue=false)]
        public bool? IsFacetable { get; set; }

        /// <summary>
        /// Gets or Sets HasExactText
        /// </summary>
        [DataMember(Name="hasExactText", EmitDefaultValue=false)]
        public bool? HasExactText { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

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
            sb.Append("class Field {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  DataTypeDesc: ").Append(DataTypeDesc).Append("\n");
            sb.Append("  IsTranscriptLookup: ").Append(IsTranscriptLookup).Append("\n");
            sb.Append("  IsSearchable: ").Append(IsSearchable).Append("\n");
            sb.Append("  IsUpdatable: ").Append(IsUpdatable).Append("\n");
            sb.Append("  IsProductionUpdatable: ").Append(IsProductionUpdatable).Append("\n");
            sb.Append("  IsMultiValue: ").Append(IsMultiValue).Append("\n");
            sb.Append("  IsCustomField: ").Append(IsCustomField).Append("\n");
            sb.Append("  IsImportable: ").Append(IsImportable).Append("\n");
            sb.Append("  IsNativeFileField: ").Append(IsNativeFileField).Append("\n");
            sb.Append("  IsSortable: ").Append(IsSortable).Append("\n");
            sb.Append("  IsFacetable: ").Append(IsFacetable).Append("\n");
            sb.Append("  HasExactText: ").Append(HasExactText).Append("\n");
            sb.Append("  Indexed: ").Append(Indexed).Append("\n");
            sb.Append("  MultiValued: ").Append(MultiValued).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        public string ToJson()
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
            return this.Equals(input as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="input">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field input)
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
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.DataTypeDesc == input.DataTypeDesc ||
                    (this.DataTypeDesc != null &&
                    this.DataTypeDesc.Equals(input.DataTypeDesc))
                ) && 
                (
                    this.IsTranscriptLookup == input.IsTranscriptLookup ||
                    (this.IsTranscriptLookup != null &&
                    this.IsTranscriptLookup.Equals(input.IsTranscriptLookup))
                ) && 
                (
                    this.IsSearchable == input.IsSearchable ||
                    (this.IsSearchable != null &&
                    this.IsSearchable.Equals(input.IsSearchable))
                ) && 
                (
                    this.IsUpdatable == input.IsUpdatable ||
                    (this.IsUpdatable != null &&
                    this.IsUpdatable.Equals(input.IsUpdatable))
                ) && 
                (
                    this.IsProductionUpdatable == input.IsProductionUpdatable ||
                    (this.IsProductionUpdatable != null &&
                    this.IsProductionUpdatable.Equals(input.IsProductionUpdatable))
                ) && 
                (
                    this.IsMultiValue == input.IsMultiValue ||
                    (this.IsMultiValue != null &&
                    this.IsMultiValue.Equals(input.IsMultiValue))
                ) && 
                (
                    this.IsCustomField == input.IsCustomField ||
                    (this.IsCustomField != null &&
                    this.IsCustomField.Equals(input.IsCustomField))
                ) && 
                (
                    this.IsImportable == input.IsImportable ||
                    (this.IsImportable != null &&
                    this.IsImportable.Equals(input.IsImportable))
                ) && 
                (
                    this.IsNativeFileField == input.IsNativeFileField ||
                    (this.IsNativeFileField != null &&
                    this.IsNativeFileField.Equals(input.IsNativeFileField))
                ) && 
                (
                    this.IsSortable == input.IsSortable ||
                    (this.IsSortable != null &&
                    this.IsSortable.Equals(input.IsSortable))
                ) && 
                (
                    this.IsFacetable == input.IsFacetable ||
                    (this.IsFacetable != null &&
                    this.IsFacetable.Equals(input.IsFacetable))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.DataTypeDesc != null)
                    hashCode = hashCode * 59 + this.DataTypeDesc.GetHashCode();
                if (this.IsTranscriptLookup != null)
                    hashCode = hashCode * 59 + this.IsTranscriptLookup.GetHashCode();
                if (this.IsSearchable != null)
                    hashCode = hashCode * 59 + this.IsSearchable.GetHashCode();
                if (this.IsUpdatable != null)
                    hashCode = hashCode * 59 + this.IsUpdatable.GetHashCode();
                if (this.IsProductionUpdatable != null)
                    hashCode = hashCode * 59 + this.IsProductionUpdatable.GetHashCode();
                if (this.IsMultiValue != null)
                    hashCode = hashCode * 59 + this.IsMultiValue.GetHashCode();
                if (this.IsCustomField != null)
                    hashCode = hashCode * 59 + this.IsCustomField.GetHashCode();
                if (this.IsImportable != null)
                    hashCode = hashCode * 59 + this.IsImportable.GetHashCode();
                if (this.IsNativeFileField != null)
                    hashCode = hashCode * 59 + this.IsNativeFileField.GetHashCode();
                if (this.IsSortable != null)
                    hashCode = hashCode * 59 + this.IsSortable.GetHashCode();
                if (this.IsFacetable != null)
                    hashCode = hashCode * 59 + this.IsFacetable.GetHashCode();
                if (this.HasExactText != null)
                    hashCode = hashCode * 59 + this.HasExactText.GetHashCode();
                if (this.Indexed != null)
                    hashCode = hashCode * 59 + this.Indexed.GetHashCode();
                if (this.MultiValued != null)
                    hashCode = hashCode * 59 + this.MultiValued.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
