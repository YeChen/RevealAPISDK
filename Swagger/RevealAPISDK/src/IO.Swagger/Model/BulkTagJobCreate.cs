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
    /// BulkTagJobCreate
    /// </summary>
    [DataContract]
    public partial class BulkTagJobCreate :  IEquatable<BulkTagJobCreate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DocumentSelectionType
        /// </summary>
        [DataMember(Name="documentSelectionType", EmitDefaultValue=false)]
        public DocumentSelection? DocumentSelectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTagJobCreate" /> class.
        /// </summary>
        /// <param name="DocumentSelectionType">DocumentSelectionType.</param>
        /// <param name="SelectedDocumentItemIds">SelectedDocumentItemIds.</param>
        /// <param name="SearchJobId">SearchJobId.</param>
        /// <param name="SearchCriteria">SearchCriteria.</param>
        /// <param name="Name">Name.</param>
        /// <param name="FolderDocsEntry">FolderDocsEntry.</param>
        /// <param name="BulkTagEntry">BulkTagEntry.</param>
        /// <param name="UpdateFieldsEntry">UpdateFieldsEntry.</param>
        /// <param name="UpdateNotesEntry">UpdateNotesEntry.</param>
        /// <param name="SecureDocumentsEntry">SecureDocumentsEntry.</param>
        public BulkTagJobCreate(DocumentSelection? DocumentSelectionType = default(DocumentSelection?), List<long?> SelectedDocumentItemIds = default(List<long?>), long? SearchJobId = default(long?), BulkActionSearchCriteria SearchCriteria = default(BulkActionSearchCriteria), string Name = default(string), FolderDocsEntry FolderDocsEntry = default(FolderDocsEntry), BulkTagEntry BulkTagEntry = default(BulkTagEntry), UpdateFieldEntry UpdateFieldsEntry = default(UpdateFieldEntry), UpdateNotesEntry UpdateNotesEntry = default(UpdateNotesEntry), SecureDocumentsEntry SecureDocumentsEntry = default(SecureDocumentsEntry))
        {
            this.DocumentSelectionType = DocumentSelectionType;
            this.SelectedDocumentItemIds = SelectedDocumentItemIds;
            this.SearchJobId = SearchJobId;
            this.SearchCriteria = SearchCriteria;
            this.Name = Name;
            this.FolderDocsEntry = FolderDocsEntry;
            this.BulkTagEntry = BulkTagEntry;
            this.UpdateFieldsEntry = UpdateFieldsEntry;
            this.UpdateNotesEntry = UpdateNotesEntry;
            this.SecureDocumentsEntry = SecureDocumentsEntry;
        }
        

        /// <summary>
        /// Gets or Sets SelectedDocumentItemIds
        /// </summary>
        [DataMember(Name="selectedDocumentItemIds", EmitDefaultValue=false)]
        public List<long?> SelectedDocumentItemIds { get; set; }

        /// <summary>
        /// Gets or Sets SearchJobId
        /// </summary>
        [DataMember(Name="searchJobId", EmitDefaultValue=false)]
        public long? SearchJobId { get; set; }

        /// <summary>
        /// Gets or Sets SearchCriteria
        /// </summary>
        [DataMember(Name="searchCriteria", EmitDefaultValue=false)]
        public BulkActionSearchCriteria SearchCriteria { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FolderDocsEntry
        /// </summary>
        [DataMember(Name="folderDocsEntry", EmitDefaultValue=false)]
        public FolderDocsEntry FolderDocsEntry { get; set; }

        /// <summary>
        /// Gets or Sets BulkTagEntry
        /// </summary>
        [DataMember(Name="bulkTagEntry", EmitDefaultValue=false)]
        public BulkTagEntry BulkTagEntry { get; set; }

        /// <summary>
        /// Gets or Sets UpdateFieldsEntry
        /// </summary>
        [DataMember(Name="updateFieldsEntry", EmitDefaultValue=false)]
        public UpdateFieldEntry UpdateFieldsEntry { get; set; }

        /// <summary>
        /// Gets or Sets UpdateNotesEntry
        /// </summary>
        [DataMember(Name="updateNotesEntry", EmitDefaultValue=false)]
        public UpdateNotesEntry UpdateNotesEntry { get; set; }

        /// <summary>
        /// Gets or Sets SecureDocumentsEntry
        /// </summary>
        [DataMember(Name="secureDocumentsEntry", EmitDefaultValue=false)]
        public SecureDocumentsEntry SecureDocumentsEntry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkTagJobCreate {\n");
            sb.Append("  DocumentSelectionType: ").Append(DocumentSelectionType).Append("\n");
            sb.Append("  SelectedDocumentItemIds: ").Append(SelectedDocumentItemIds).Append("\n");
            sb.Append("  SearchJobId: ").Append(SearchJobId).Append("\n");
            sb.Append("  SearchCriteria: ").Append(SearchCriteria).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FolderDocsEntry: ").Append(FolderDocsEntry).Append("\n");
            sb.Append("  BulkTagEntry: ").Append(BulkTagEntry).Append("\n");
            sb.Append("  UpdateFieldsEntry: ").Append(UpdateFieldsEntry).Append("\n");
            sb.Append("  UpdateNotesEntry: ").Append(UpdateNotesEntry).Append("\n");
            sb.Append("  SecureDocumentsEntry: ").Append(SecureDocumentsEntry).Append("\n");
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
            return this.Equals(input as BulkTagJobCreate);
        }

        /// <summary>
        /// Returns true if BulkTagJobCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkTagJobCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkTagJobCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentSelectionType == input.DocumentSelectionType ||
                    (this.DocumentSelectionType != null &&
                    this.DocumentSelectionType.Equals(input.DocumentSelectionType))
                ) && 
                (
                    this.SelectedDocumentItemIds == input.SelectedDocumentItemIds ||
                    this.SelectedDocumentItemIds != null &&
                    this.SelectedDocumentItemIds.SequenceEqual(input.SelectedDocumentItemIds)
                ) && 
                (
                    this.SearchJobId == input.SearchJobId ||
                    (this.SearchJobId != null &&
                    this.SearchJobId.Equals(input.SearchJobId))
                ) && 
                (
                    this.SearchCriteria == input.SearchCriteria ||
                    (this.SearchCriteria != null &&
                    this.SearchCriteria.Equals(input.SearchCriteria))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FolderDocsEntry == input.FolderDocsEntry ||
                    (this.FolderDocsEntry != null &&
                    this.FolderDocsEntry.Equals(input.FolderDocsEntry))
                ) && 
                (
                    this.BulkTagEntry == input.BulkTagEntry ||
                    (this.BulkTagEntry != null &&
                    this.BulkTagEntry.Equals(input.BulkTagEntry))
                ) && 
                (
                    this.UpdateFieldsEntry == input.UpdateFieldsEntry ||
                    (this.UpdateFieldsEntry != null &&
                    this.UpdateFieldsEntry.Equals(input.UpdateFieldsEntry))
                ) && 
                (
                    this.UpdateNotesEntry == input.UpdateNotesEntry ||
                    (this.UpdateNotesEntry != null &&
                    this.UpdateNotesEntry.Equals(input.UpdateNotesEntry))
                ) && 
                (
                    this.SecureDocumentsEntry == input.SecureDocumentsEntry ||
                    (this.SecureDocumentsEntry != null &&
                    this.SecureDocumentsEntry.Equals(input.SecureDocumentsEntry))
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
                if (this.DocumentSelectionType != null)
                    hashCode = hashCode * 59 + this.DocumentSelectionType.GetHashCode();
                if (this.SelectedDocumentItemIds != null)
                    hashCode = hashCode * 59 + this.SelectedDocumentItemIds.GetHashCode();
                if (this.SearchJobId != null)
                    hashCode = hashCode * 59 + this.SearchJobId.GetHashCode();
                if (this.SearchCriteria != null)
                    hashCode = hashCode * 59 + this.SearchCriteria.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FolderDocsEntry != null)
                    hashCode = hashCode * 59 + this.FolderDocsEntry.GetHashCode();
                if (this.BulkTagEntry != null)
                    hashCode = hashCode * 59 + this.BulkTagEntry.GetHashCode();
                if (this.UpdateFieldsEntry != null)
                    hashCode = hashCode * 59 + this.UpdateFieldsEntry.GetHashCode();
                if (this.UpdateNotesEntry != null)
                    hashCode = hashCode * 59 + this.UpdateNotesEntry.GetHashCode();
                if (this.SecureDocumentsEntry != null)
                    hashCode = hashCode * 59 + this.SecureDocumentsEntry.GetHashCode();
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
