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
    /// DocumentFolder
    /// </summary>
    [DataContract]
    public partial class DocumentFolder :  IEquatable<DocumentFolder>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="DocumentFolder" /> class.
        /// </summary>
        /// <param name="folderType">folderType.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="canSelectFolder">canSelectFolder.</param>
        /// <param name="uniqueId">uniqueId.</param>
        /// <param name="uniqueParentId">uniqueParentId.</param>
        /// <param name="readOnly">readOnly.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="hasChildren">hasChildren.</param>
        /// <param name="hasItemChildren">hasItemChildren.</param>
        /// <param name="documentCount">documentCount.</param>
        /// <param name="folderActionPermissions">folderActionPermissions.</param>
        /// <param name="children">children.</param>
        /// <param name="folderQuery">folderQuery.</param>
        /// <param name="isSearchable">isSearchable.</param>
        /// <param name="isUserFolder">isUserFolder.</param>
        /// <param name="searchType">searchType.</param>
        public DocumentFolder(FolderItemType? folderType = default(FolderItemType?), string id = default(string), string name = default(string), string description = default(string), bool? canSelectFolder = default(bool?), string uniqueId = default(string), string uniqueParentId = default(string), bool? readOnly = default(bool?), int? createdByUserId = default(int?), bool? hasChildren = default(bool?), bool? hasItemChildren = default(bool?), long? documentCount = default(long?), ActionPermissions folderActionPermissions = default(ActionPermissions), List<FolderItem> children = default(List<FolderItem>), FolderItemQuery folderQuery = default(FolderItemQuery), bool? isSearchable = default(bool?), bool? isUserFolder = default(bool?), FolderSearchType? searchType = default(FolderSearchType?))
        {
            this.FolderType = folderType;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CanSelectFolder = canSelectFolder;
            this.UniqueId = uniqueId;
            this.UniqueParentId = uniqueParentId;
            this.ReadOnly = readOnly;
            this.CreatedByUserId = createdByUserId;
            this.HasChildren = hasChildren;
            this.HasItemChildren = hasItemChildren;
            this.DocumentCount = documentCount;
            this.FolderActionPermissions = folderActionPermissions;
            this.Children = children;
            this.FolderQuery = folderQuery;
            this.IsSearchable = isSearchable;
            this.IsUserFolder = isUserFolder;
            this.SearchType = searchType;
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
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

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
            sb.Append("class DocumentFolder {\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CanSelectFolder: ").Append(CanSelectFolder).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  UniqueParentId: ").Append(UniqueParentId).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as DocumentFolder);
        }

        /// <summary>
        /// Returns true if DocumentFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFolder input)
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
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
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
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
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
