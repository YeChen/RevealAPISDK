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
    /// AssignmentBatchFolder
    /// </summary>
    [DataContract]
    public partial class AssignmentBatchFolder :  IEquatable<AssignmentBatchFolder>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public AssignmentBatchControlStatusType? Status { get; set; }
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
        /// Initializes a new instance of the <see cref="AssignmentBatchFolder" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="tag">tag.</param>
        /// <param name="status">status.</param>
        /// <param name="checkedOutByUserId">checkedOutByUserId.</param>
        /// <param name="checkedOutByUserName">checkedOutByUserName.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastActionDatetime">lastActionDatetime.</param>
        /// <param name="reviewedCount">reviewedCount.</param>
        /// <param name="markedBatchCompleteByUserName">markedBatchCompleteByUserName.</param>
        /// <param name="isBatchComplete">isBatchComplete.</param>
        /// <param name="folderType">folderType.</param>
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
        public AssignmentBatchFolder(long? id = default(long?), string type = default(string), string tag = default(string), AssignmentBatchControlStatusType? status = default(AssignmentBatchControlStatusType?), int? checkedOutByUserId = default(int?), string checkedOutByUserName = default(string), DateTime? createdDateTime = default(DateTime?), DateTime? lastActionDatetime = default(DateTime?), int? reviewedCount = default(int?), string markedBatchCompleteByUserName = default(string), bool? isBatchComplete = default(bool?), FolderItemType? folderType = default(FolderItemType?), string name = default(string), string description = default(string), bool? canSelectFolder = default(bool?), string uniqueId = default(string), string uniqueParentId = default(string), bool? readOnly = default(bool?), int? createdByUserId = default(int?), bool? hasChildren = default(bool?), bool? hasItemChildren = default(bool?), long? documentCount = default(long?), ActionPermissions folderActionPermissions = default(ActionPermissions), List<FolderItem> children = default(List<FolderItem>), FolderItemQuery folderQuery = default(FolderItemQuery), bool? isSearchable = default(bool?), bool? isUserFolder = default(bool?), FolderSearchType? searchType = default(FolderSearchType?))
        {
            this.Id = id;
            this.Type = type;
            this.Tag = tag;
            this.Status = status;
            this.CheckedOutByUserId = checkedOutByUserId;
            this.CheckedOutByUserName = checkedOutByUserName;
            this.CreatedDateTime = createdDateTime;
            this.LastActionDatetime = lastActionDatetime;
            this.ReviewedCount = reviewedCount;
            this.MarkedBatchCompleteByUserName = markedBatchCompleteByUserName;
            this.IsBatchComplete = isBatchComplete;
            this.FolderType = folderType;
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
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }


        /// <summary>
        /// Gets or Sets CheckedOutByUserId
        /// </summary>
        [DataMember(Name="checkedOutByUserId", EmitDefaultValue=false)]
        public int? CheckedOutByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CheckedOutByUserName
        /// </summary>
        [DataMember(Name="checkedOutByUserName", EmitDefaultValue=false)]
        public string CheckedOutByUserName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastActionDatetime
        /// </summary>
        [DataMember(Name="lastActionDatetime", EmitDefaultValue=false)]
        public DateTime? LastActionDatetime { get; set; }

        /// <summary>
        /// Gets or Sets ReviewedCount
        /// </summary>
        [DataMember(Name="reviewedCount", EmitDefaultValue=false)]
        public int? ReviewedCount { get; set; }

        /// <summary>
        /// Gets or Sets MarkedBatchCompleteByUserName
        /// </summary>
        [DataMember(Name="markedBatchCompleteByUserName", EmitDefaultValue=false)]
        public string MarkedBatchCompleteByUserName { get; set; }

        /// <summary>
        /// Gets or Sets IsBatchComplete
        /// </summary>
        [DataMember(Name="isBatchComplete", EmitDefaultValue=false)]
        public bool? IsBatchComplete { get; set; }


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
            sb.Append("class AssignmentBatchFolder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CheckedOutByUserId: ").Append(CheckedOutByUserId).Append("\n");
            sb.Append("  CheckedOutByUserName: ").Append(CheckedOutByUserName).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastActionDatetime: ").Append(LastActionDatetime).Append("\n");
            sb.Append("  ReviewedCount: ").Append(ReviewedCount).Append("\n");
            sb.Append("  MarkedBatchCompleteByUserName: ").Append(MarkedBatchCompleteByUserName).Append("\n");
            sb.Append("  IsBatchComplete: ").Append(IsBatchComplete).Append("\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
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
            return this.Equals(input as AssignmentBatchFolder);
        }

        /// <summary>
        /// Returns true if AssignmentBatchFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of AssignmentBatchFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignmentBatchFolder input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CheckedOutByUserId == input.CheckedOutByUserId ||
                    (this.CheckedOutByUserId != null &&
                    this.CheckedOutByUserId.Equals(input.CheckedOutByUserId))
                ) && 
                (
                    this.CheckedOutByUserName == input.CheckedOutByUserName ||
                    (this.CheckedOutByUserName != null &&
                    this.CheckedOutByUserName.Equals(input.CheckedOutByUserName))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.LastActionDatetime == input.LastActionDatetime ||
                    (this.LastActionDatetime != null &&
                    this.LastActionDatetime.Equals(input.LastActionDatetime))
                ) && 
                (
                    this.ReviewedCount == input.ReviewedCount ||
                    (this.ReviewedCount != null &&
                    this.ReviewedCount.Equals(input.ReviewedCount))
                ) && 
                (
                    this.MarkedBatchCompleteByUserName == input.MarkedBatchCompleteByUserName ||
                    (this.MarkedBatchCompleteByUserName != null &&
                    this.MarkedBatchCompleteByUserName.Equals(input.MarkedBatchCompleteByUserName))
                ) && 
                (
                    this.IsBatchComplete == input.IsBatchComplete ||
                    (this.IsBatchComplete != null &&
                    this.IsBatchComplete.Equals(input.IsBatchComplete))
                ) && 
                (
                    this.FolderType == input.FolderType ||
                    (this.FolderType != null &&
                    this.FolderType.Equals(input.FolderType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CheckedOutByUserId != null)
                    hashCode = hashCode * 59 + this.CheckedOutByUserId.GetHashCode();
                if (this.CheckedOutByUserName != null)
                    hashCode = hashCode * 59 + this.CheckedOutByUserName.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.LastActionDatetime != null)
                    hashCode = hashCode * 59 + this.LastActionDatetime.GetHashCode();
                if (this.ReviewedCount != null)
                    hashCode = hashCode * 59 + this.ReviewedCount.GetHashCode();
                if (this.MarkedBatchCompleteByUserName != null)
                    hashCode = hashCode * 59 + this.MarkedBatchCompleteByUserName.GetHashCode();
                if (this.IsBatchComplete != null)
                    hashCode = hashCode * 59 + this.IsBatchComplete.GetHashCode();
                if (this.FolderType != null)
                    hashCode = hashCode * 59 + this.FolderType.GetHashCode();
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
