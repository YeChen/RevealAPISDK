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
    /// FolderItem
    /// </summary>
    [DataContract]
    public partial class FolderItem :  IEquatable<FolderItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FolderType
        /// </summary>
        [DataMember(Name="folderType", EmitDefaultValue=false)]
        public FolderItemType? FolderType { get; set; }
        /// <summary>
        /// Gets or Sets SearchType
        /// </summary>
        [DataMember(Name="searchType", EmitDefaultValue=false)]
        public FolderSearchType? SearchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderItem" /> class.
        /// </summary>
        /// <param name="FolderType">FolderType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CanSelectFolder">CanSelectFolder.</param>
        /// <param name="UniqueId">UniqueId.</param>
        /// <param name="UniqueParentId">UniqueParentId.</param>
        /// <param name="_ReadOnly">_ReadOnly.</param>
        /// <param name="CreatedByUserId">CreatedByUserId.</param>
        /// <param name="HasChildren">HasChildren.</param>
        /// <param name="HasItemChildren">HasItemChildren.</param>
        /// <param name="DocumentCount">DocumentCount.</param>
        /// <param name="FolderActionPermissions">FolderActionPermissions.</param>
        /// <param name="Children">Children.</param>
        /// <param name="FolderQuery">FolderQuery.</param>
        /// <param name="IsSearchable">IsSearchable.</param>
        /// <param name="IsUserFolder">IsUserFolder.</param>
        /// <param name="SearchType">SearchType.</param>
        public FolderItem(FolderItemType? FolderType = default(FolderItemType?), string Id = default(string), string Name = default(string), string Description = default(string), bool? CanSelectFolder = default(bool?), string UniqueId = default(string), string UniqueParentId = default(string), bool? _ReadOnly = default(bool?), int? CreatedByUserId = default(int?), bool? HasChildren = default(bool?), bool? HasItemChildren = default(bool?), long? DocumentCount = default(long?), ActionPermissions FolderActionPermissions = default(ActionPermissions), List<FolderItem> Children = default(List<FolderItem>), FolderItemQuery FolderQuery = default(FolderItemQuery), bool? IsSearchable = default(bool?), bool? IsUserFolder = default(bool?), FolderSearchType? SearchType = default(FolderSearchType?))
        {
            this.FolderType = FolderType;
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.CanSelectFolder = CanSelectFolder;
            this.UniqueId = UniqueId;
            this.UniqueParentId = UniqueParentId;
            this._ReadOnly = _ReadOnly;
            this.CreatedByUserId = CreatedByUserId;
            this.HasChildren = HasChildren;
            this.HasItemChildren = HasItemChildren;
            this.DocumentCount = DocumentCount;
            this.FolderActionPermissions = FolderActionPermissions;
            this.Children = Children;
            this.FolderQuery = FolderQuery;
            this.IsSearchable = IsSearchable;
            this.IsUserFolder = IsUserFolder;
            this.SearchType = SearchType;
        }
        

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

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
        /// Gets or Sets CanSelectFolder
        /// </summary>
        [DataMember(Name="canSelectFolder", EmitDefaultValue=false)]
        public bool? CanSelectFolder { get; set; }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or Sets UniqueParentId
        /// </summary>
        [DataMember(Name="uniqueParentId", EmitDefaultValue=false)]
        public string UniqueParentId { get; set; }

        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets HasChildren
        /// </summary>
        [DataMember(Name="hasChildren", EmitDefaultValue=false)]
        public bool? HasChildren { get; set; }

        /// <summary>
        /// Gets or Sets HasItemChildren
        /// </summary>
        [DataMember(Name="hasItemChildren", EmitDefaultValue=false)]
        public bool? HasItemChildren { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [DataMember(Name="documentCount", EmitDefaultValue=false)]
        public long? DocumentCount { get; set; }

        /// <summary>
        /// Gets or Sets FolderActionPermissions
        /// </summary>
        [DataMember(Name="folderActionPermissions", EmitDefaultValue=false)]
        public ActionPermissions FolderActionPermissions { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<FolderItem> Children { get; set; }

        /// <summary>
        /// Gets or Sets FolderQuery
        /// </summary>
        [DataMember(Name="folderQuery", EmitDefaultValue=false)]
        public FolderItemQuery FolderQuery { get; set; }

        /// <summary>
        /// Gets or Sets IsSearchable
        /// </summary>
        [DataMember(Name="isSearchable", EmitDefaultValue=false)]
        public bool? IsSearchable { get; set; }

        /// <summary>
        /// Gets or Sets IsUserFolder
        /// </summary>
        [DataMember(Name="isUserFolder", EmitDefaultValue=false)]
        public bool? IsUserFolder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderItem {\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CanSelectFolder: ").Append(CanSelectFolder).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  UniqueParentId: ").Append(UniqueParentId).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  HasChildren: ").Append(HasChildren).Append("\n");
            sb.Append("  HasItemChildren: ").Append(HasItemChildren).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  FolderActionPermissions: ").Append(FolderActionPermissions).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  FolderQuery: ").Append(FolderQuery).Append("\n");
            sb.Append("  IsSearchable: ").Append(IsSearchable).Append("\n");
            sb.Append("  IsUserFolder: ").Append(IsUserFolder).Append("\n");
            sb.Append("  SearchType: ").Append(SearchType).Append("\n");
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
            return this.Equals(input as FolderItem);
        }

        /// <summary>
        /// Returns true if FolderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FolderType == input.FolderType ||
                    (this.FolderType != null &&
                    this.FolderType.Equals(input.FolderType))
                ) && 
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
                    this.CanSelectFolder == input.CanSelectFolder ||
                    (this.CanSelectFolder != null &&
                    this.CanSelectFolder.Equals(input.CanSelectFolder))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.UniqueParentId == input.UniqueParentId ||
                    (this.UniqueParentId != null &&
                    this.UniqueParentId.Equals(input.UniqueParentId))
                ) && 
                (
                    this._ReadOnly == input._ReadOnly ||
                    (this._ReadOnly != null &&
                    this._ReadOnly.Equals(input._ReadOnly))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.HasChildren == input.HasChildren ||
                    (this.HasChildren != null &&
                    this.HasChildren.Equals(input.HasChildren))
                ) && 
                (
                    this.HasItemChildren == input.HasItemChildren ||
                    (this.HasItemChildren != null &&
                    this.HasItemChildren.Equals(input.HasItemChildren))
                ) && 
                (
                    this.DocumentCount == input.DocumentCount ||
                    (this.DocumentCount != null &&
                    this.DocumentCount.Equals(input.DocumentCount))
                ) && 
                (
                    this.FolderActionPermissions == input.FolderActionPermissions ||
                    (this.FolderActionPermissions != null &&
                    this.FolderActionPermissions.Equals(input.FolderActionPermissions))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.FolderQuery == input.FolderQuery ||
                    (this.FolderQuery != null &&
                    this.FolderQuery.Equals(input.FolderQuery))
                ) && 
                (
                    this.IsSearchable == input.IsSearchable ||
                    (this.IsSearchable != null &&
                    this.IsSearchable.Equals(input.IsSearchable))
                ) && 
                (
                    this.IsUserFolder == input.IsUserFolder ||
                    (this.IsUserFolder != null &&
                    this.IsUserFolder.Equals(input.IsUserFolder))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
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
                if (this.FolderType != null)
                    hashCode = hashCode * 59 + this.FolderType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CanSelectFolder != null)
                    hashCode = hashCode * 59 + this.CanSelectFolder.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.UniqueParentId != null)
                    hashCode = hashCode * 59 + this.UniqueParentId.GetHashCode();
                if (this._ReadOnly != null)
                    hashCode = hashCode * 59 + this._ReadOnly.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.HasChildren != null)
                    hashCode = hashCode * 59 + this.HasChildren.GetHashCode();
                if (this.HasItemChildren != null)
                    hashCode = hashCode * 59 + this.HasItemChildren.GetHashCode();
                if (this.DocumentCount != null)
                    hashCode = hashCode * 59 + this.DocumentCount.GetHashCode();
                if (this.FolderActionPermissions != null)
                    hashCode = hashCode * 59 + this.FolderActionPermissions.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.FolderQuery != null)
                    hashCode = hashCode * 59 + this.FolderQuery.GetHashCode();
                if (this.IsSearchable != null)
                    hashCode = hashCode * 59 + this.IsSearchable.GetHashCode();
                if (this.IsUserFolder != null)
                    hashCode = hashCode * 59 + this.IsUserFolder.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
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
