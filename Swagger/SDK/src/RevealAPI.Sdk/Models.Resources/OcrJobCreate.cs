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
    /// OcrJobCreate
    /// </summary>
    [DataContract]
    public partial class OcrJobCreate :  IEquatable<OcrJobCreate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DocumentSelectionType
        /// </summary>
        [DataMember(Name="documentSelectionType", EmitDefaultValue=false)]
        public DocumentSelection? DocumentSelectionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrJobCreate" /> class.
        /// </summary>
        /// <param name="documentSelectionType">documentSelectionType.</param>
        /// <param name="selectedDocumentItemIds">selectedDocumentItemIds.</param>
        /// <param name="searchJobId">searchJobId.</param>
        /// <param name="searchCriteria">searchCriteria.</param>
        /// <param name="generateMissingImages">generateMissingImages.</param>
        /// <param name="overwriteExistingText">overwriteExistingText.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="createdDatetime">createdDatetime.</param>
        /// <param name="startDatetime">startDatetime.</param>
        /// <param name="endDatetime">endDatetime.</param>
        /// <param name="jobInfoMessage">jobInfoMessage.</param>
        /// <param name="pageCount">pageCount.</param>
        /// <param name="id">id.</param>
        /// <param name="documentImageSetId">documentImageSetId.</param>
        /// <param name="documentTextSetId">documentTextSetId.</param>
        /// <param name="totalDocuments">totalDocuments.</param>
        /// <param name="status">status.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="name">name.</param>
        /// <param name="imagingTemplateId">imagingTemplateId.</param>
        public OcrJobCreate(DocumentSelection? documentSelectionType = default(DocumentSelection?), List<long?> selectedDocumentItemIds = default(List<long?>), long? searchJobId = default(long?), BulkActionSearchCriteria searchCriteria = default(BulkActionSearchCriteria), bool? generateMissingImages = default(bool?), bool? overwriteExistingText = default(bool?), long? createdByUserId = default(long?), DateTime? createdDatetime = default(DateTime?), DateTime? startDatetime = default(DateTime?), DateTime? endDatetime = default(DateTime?), string jobInfoMessage = default(string), int? pageCount = default(int?), int? id = default(int?), int? documentImageSetId = default(int?), int? documentTextSetId = default(int?), int? totalDocuments = default(int?), int? status = default(int?), bool? isDeleted = default(bool?), string name = default(string), int? imagingTemplateId = default(int?))
        {
            this.DocumentSelectionType = documentSelectionType;
            this.SelectedDocumentItemIds = selectedDocumentItemIds;
            this.SearchJobId = searchJobId;
            this.SearchCriteria = searchCriteria;
            this.GenerateMissingImages = generateMissingImages;
            this.OverwriteExistingText = overwriteExistingText;
            this.CreatedByUserId = createdByUserId;
            this.CreatedDatetime = createdDatetime;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.JobInfoMessage = jobInfoMessage;
            this.PageCount = pageCount;
            this.Id = id;
            this.DocumentImageSetId = documentImageSetId;
            this.DocumentTextSetId = documentTextSetId;
            this.TotalDocuments = totalDocuments;
            this.Status = status;
            this.IsDeleted = isDeleted;
            this.Name = name;
            this.ImagingTemplateId = imagingTemplateId;
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
        /// Gets or Sets GenerateMissingImages
        /// </summary>
        [DataMember(Name="generateMissingImages", EmitDefaultValue=false)]
        public bool? GenerateMissingImages { get; set; }

        /// <summary>
        /// Gets or Sets OverwriteExistingText
        /// </summary>
        [DataMember(Name="overwriteExistingText", EmitDefaultValue=false)]
        public bool? OverwriteExistingText { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDatetime
        /// </summary>
        [DataMember(Name="createdDatetime", EmitDefaultValue=false)]
        public DateTime? CreatedDatetime { get; set; }

        /// <summary>
        /// Gets or Sets StartDatetime
        /// </summary>
        [DataMember(Name="startDatetime", EmitDefaultValue=false)]
        public DateTime? StartDatetime { get; set; }

        /// <summary>
        /// Gets or Sets EndDatetime
        /// </summary>
        [DataMember(Name="endDatetime", EmitDefaultValue=false)]
        public DateTime? EndDatetime { get; set; }

        /// <summary>
        /// Gets or Sets JobInfoMessage
        /// </summary>
        [DataMember(Name="jobInfoMessage", EmitDefaultValue=false)]
        public string JobInfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets DocumentImageSetId
        /// </summary>
        [DataMember(Name="documentImageSetId", EmitDefaultValue=false)]
        public int? DocumentImageSetId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTextSetId
        /// </summary>
        [DataMember(Name="documentTextSetId", EmitDefaultValue=false)]
        public int? DocumentTextSetId { get; set; }

        /// <summary>
        /// Gets or Sets TotalDocuments
        /// </summary>
        [DataMember(Name="totalDocuments", EmitDefaultValue=false)]
        public int? TotalDocuments { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ImagingTemplateId
        /// </summary>
        [DataMember(Name="imagingTemplateId", EmitDefaultValue=false)]
        public int? ImagingTemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcrJobCreate {\n");
            sb.Append("  DocumentSelectionType: ").Append(DocumentSelectionType).Append("\n");
            sb.Append("  SelectedDocumentItemIds: ").Append(SelectedDocumentItemIds).Append("\n");
            sb.Append("  SearchJobId: ").Append(SearchJobId).Append("\n");
            sb.Append("  SearchCriteria: ").Append(SearchCriteria).Append("\n");
            sb.Append("  GenerateMissingImages: ").Append(GenerateMissingImages).Append("\n");
            sb.Append("  OverwriteExistingText: ").Append(OverwriteExistingText).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedDatetime: ").Append(CreatedDatetime).Append("\n");
            sb.Append("  StartDatetime: ").Append(StartDatetime).Append("\n");
            sb.Append("  EndDatetime: ").Append(EndDatetime).Append("\n");
            sb.Append("  JobInfoMessage: ").Append(JobInfoMessage).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentImageSetId: ").Append(DocumentImageSetId).Append("\n");
            sb.Append("  DocumentTextSetId: ").Append(DocumentTextSetId).Append("\n");
            sb.Append("  TotalDocuments: ").Append(TotalDocuments).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImagingTemplateId: ").Append(ImagingTemplateId).Append("\n");
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
            return this.Equals(input as OcrJobCreate);
        }

        /// <summary>
        /// Returns true if OcrJobCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrJobCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrJobCreate input)
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
                    this.GenerateMissingImages == input.GenerateMissingImages ||
                    (this.GenerateMissingImages != null &&
                    this.GenerateMissingImages.Equals(input.GenerateMissingImages))
                ) && 
                (
                    this.OverwriteExistingText == input.OverwriteExistingText ||
                    (this.OverwriteExistingText != null &&
                    this.OverwriteExistingText.Equals(input.OverwriteExistingText))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.CreatedDatetime == input.CreatedDatetime ||
                    (this.CreatedDatetime != null &&
                    this.CreatedDatetime.Equals(input.CreatedDatetime))
                ) && 
                (
                    this.StartDatetime == input.StartDatetime ||
                    (this.StartDatetime != null &&
                    this.StartDatetime.Equals(input.StartDatetime))
                ) && 
                (
                    this.EndDatetime == input.EndDatetime ||
                    (this.EndDatetime != null &&
                    this.EndDatetime.Equals(input.EndDatetime))
                ) && 
                (
                    this.JobInfoMessage == input.JobInfoMessage ||
                    (this.JobInfoMessage != null &&
                    this.JobInfoMessage.Equals(input.JobInfoMessage))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DocumentImageSetId == input.DocumentImageSetId ||
                    (this.DocumentImageSetId != null &&
                    this.DocumentImageSetId.Equals(input.DocumentImageSetId))
                ) && 
                (
                    this.DocumentTextSetId == input.DocumentTextSetId ||
                    (this.DocumentTextSetId != null &&
                    this.DocumentTextSetId.Equals(input.DocumentTextSetId))
                ) && 
                (
                    this.TotalDocuments == input.TotalDocuments ||
                    (this.TotalDocuments != null &&
                    this.TotalDocuments.Equals(input.TotalDocuments))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ImagingTemplateId == input.ImagingTemplateId ||
                    (this.ImagingTemplateId != null &&
                    this.ImagingTemplateId.Equals(input.ImagingTemplateId))
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
                if (this.GenerateMissingImages != null)
                    hashCode = hashCode * 59 + this.GenerateMissingImages.GetHashCode();
                if (this.OverwriteExistingText != null)
                    hashCode = hashCode * 59 + this.OverwriteExistingText.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.CreatedDatetime != null)
                    hashCode = hashCode * 59 + this.CreatedDatetime.GetHashCode();
                if (this.StartDatetime != null)
                    hashCode = hashCode * 59 + this.StartDatetime.GetHashCode();
                if (this.EndDatetime != null)
                    hashCode = hashCode * 59 + this.EndDatetime.GetHashCode();
                if (this.JobInfoMessage != null)
                    hashCode = hashCode * 59 + this.JobInfoMessage.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DocumentImageSetId != null)
                    hashCode = hashCode * 59 + this.DocumentImageSetId.GetHashCode();
                if (this.DocumentTextSetId != null)
                    hashCode = hashCode * 59 + this.DocumentTextSetId.GetHashCode();
                if (this.TotalDocuments != null)
                    hashCode = hashCode * 59 + this.TotalDocuments.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ImagingTemplateId != null)
                    hashCode = hashCode * 59 + this.ImagingTemplateId.GetHashCode();
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
