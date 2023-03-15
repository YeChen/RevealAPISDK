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
    /// AvTranscribeJob
    /// </summary>
    [DataContract]
    public partial class AvTranscribeJob :  IEquatable<AvTranscribeJob>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public JobStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvTranscribeJob" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="batchGuid">batchGuid.</param>
        /// <param name="totalDocuments">totalDocuments.</param>
        /// <param name="documentsProcessed">documentsProcessed.</param>
        /// <param name="processingErrors">processingErrors.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="createdByUserName">createdByUserName.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="textSetSourceName">textSetSourceName.</param>
        /// <param name="textSetDestName">textSetDestName.</param>
        /// <param name="name">name.</param>
        /// <param name="textSetSourceId">textSetSourceId.</param>
        /// <param name="textSetDestId">textSetDestId.</param>
        /// <param name="languageSource">languageSource.</param>
        public AvTranscribeJob(int? id = default(int?), JobStatus? status = default(JobStatus?), string batchGuid = default(string), int? totalDocuments = default(int?), int? documentsProcessed = default(int?), int? processingErrors = default(int?), long? createdByUserId = default(long?), string createdByUserName = default(string), DateTime? createdDateTime = default(DateTime?), DateTime? startDateTime = default(DateTime?), DateTime? endDateTime = default(DateTime?), bool? isDeleted = default(bool?), string textSetSourceName = default(string), string textSetDestName = default(string), string name = default(string), int? textSetSourceId = default(int?), int? textSetDestId = default(int?), string languageSource = default(string))
        {
            this.Id = id;
            this.Status = status;
            this.BatchGuid = batchGuid;
            this.TotalDocuments = totalDocuments;
            this.DocumentsProcessed = documentsProcessed;
            this.ProcessingErrors = processingErrors;
            this.CreatedByUserId = createdByUserId;
            this.CreatedByUserName = createdByUserName;
            this.CreatedDateTime = createdDateTime;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.IsDeleted = isDeleted;
            this.TextSetSourceName = textSetSourceName;
            this.TextSetDestName = textSetDestName;
            this.Name = name;
            this.TextSetSourceId = textSetSourceId;
            this.TextSetDestId = textSetDestId;
            this.LanguageSource = languageSource;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }


        /// <summary>
        /// Gets or Sets BatchGuid
        /// </summary>
        [DataMember(Name="batchGuid", EmitDefaultValue=false)]
        public string BatchGuid { get; set; }

        /// <summary>
        /// Gets or Sets TotalDocuments
        /// </summary>
        [DataMember(Name="totalDocuments", EmitDefaultValue=false)]
        public int? TotalDocuments { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsProcessed
        /// </summary>
        [DataMember(Name="documentsProcessed", EmitDefaultValue=false)]
        public int? DocumentsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingErrors
        /// </summary>
        [DataMember(Name="processingErrors", EmitDefaultValue=false)]
        public int? ProcessingErrors { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserName
        /// </summary>
        [DataMember(Name="createdByUserName", EmitDefaultValue=false)]
        public string CreatedByUserName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets TextSetSourceName
        /// </summary>
        [DataMember(Name="textSetSourceName", EmitDefaultValue=false)]
        public string TextSetSourceName { get; set; }

        /// <summary>
        /// Gets or Sets TextSetDestName
        /// </summary>
        [DataMember(Name="textSetDestName", EmitDefaultValue=false)]
        public string TextSetDestName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TextSetSourceId
        /// </summary>
        [DataMember(Name="textSetSourceId", EmitDefaultValue=false)]
        public int? TextSetSourceId { get; set; }

        /// <summary>
        /// Gets or Sets TextSetDestId
        /// </summary>
        [DataMember(Name="textSetDestId", EmitDefaultValue=false)]
        public int? TextSetDestId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageSource
        /// </summary>
        [DataMember(Name="languageSource", EmitDefaultValue=false)]
        public string LanguageSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvTranscribeJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BatchGuid: ").Append(BatchGuid).Append("\n");
            sb.Append("  TotalDocuments: ").Append(TotalDocuments).Append("\n");
            sb.Append("  DocumentsProcessed: ").Append(DocumentsProcessed).Append("\n");
            sb.Append("  ProcessingErrors: ").Append(ProcessingErrors).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  TextSetSourceName: ").Append(TextSetSourceName).Append("\n");
            sb.Append("  TextSetDestName: ").Append(TextSetDestName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TextSetSourceId: ").Append(TextSetSourceId).Append("\n");
            sb.Append("  TextSetDestId: ").Append(TextSetDestId).Append("\n");
            sb.Append("  LanguageSource: ").Append(LanguageSource).Append("\n");
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
            return this.Equals(input as AvTranscribeJob);
        }

        /// <summary>
        /// Returns true if AvTranscribeJob instances are equal
        /// </summary>
        /// <param name="input">Instance of AvTranscribeJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvTranscribeJob input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BatchGuid == input.BatchGuid ||
                    (this.BatchGuid != null &&
                    this.BatchGuid.Equals(input.BatchGuid))
                ) && 
                (
                    this.TotalDocuments == input.TotalDocuments ||
                    (this.TotalDocuments != null &&
                    this.TotalDocuments.Equals(input.TotalDocuments))
                ) && 
                (
                    this.DocumentsProcessed == input.DocumentsProcessed ||
                    (this.DocumentsProcessed != null &&
                    this.DocumentsProcessed.Equals(input.DocumentsProcessed))
                ) && 
                (
                    this.ProcessingErrors == input.ProcessingErrors ||
                    (this.ProcessingErrors != null &&
                    this.ProcessingErrors.Equals(input.ProcessingErrors))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.CreatedByUserName == input.CreatedByUserName ||
                    (this.CreatedByUserName != null &&
                    this.CreatedByUserName.Equals(input.CreatedByUserName))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.TextSetSourceName == input.TextSetSourceName ||
                    (this.TextSetSourceName != null &&
                    this.TextSetSourceName.Equals(input.TextSetSourceName))
                ) && 
                (
                    this.TextSetDestName == input.TextSetDestName ||
                    (this.TextSetDestName != null &&
                    this.TextSetDestName.Equals(input.TextSetDestName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TextSetSourceId == input.TextSetSourceId ||
                    (this.TextSetSourceId != null &&
                    this.TextSetSourceId.Equals(input.TextSetSourceId))
                ) && 
                (
                    this.TextSetDestId == input.TextSetDestId ||
                    (this.TextSetDestId != null &&
                    this.TextSetDestId.Equals(input.TextSetDestId))
                ) && 
                (
                    this.LanguageSource == input.LanguageSource ||
                    (this.LanguageSource != null &&
                    this.LanguageSource.Equals(input.LanguageSource))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BatchGuid != null)
                    hashCode = hashCode * 59 + this.BatchGuid.GetHashCode();
                if (this.TotalDocuments != null)
                    hashCode = hashCode * 59 + this.TotalDocuments.GetHashCode();
                if (this.DocumentsProcessed != null)
                    hashCode = hashCode * 59 + this.DocumentsProcessed.GetHashCode();
                if (this.ProcessingErrors != null)
                    hashCode = hashCode * 59 + this.ProcessingErrors.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.CreatedByUserName != null)
                    hashCode = hashCode * 59 + this.CreatedByUserName.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.TextSetSourceName != null)
                    hashCode = hashCode * 59 + this.TextSetSourceName.GetHashCode();
                if (this.TextSetDestName != null)
                    hashCode = hashCode * 59 + this.TextSetDestName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TextSetSourceId != null)
                    hashCode = hashCode * 59 + this.TextSetSourceId.GetHashCode();
                if (this.TextSetDestId != null)
                    hashCode = hashCode * 59 + this.TextSetDestId.GetHashCode();
                if (this.LanguageSource != null)
                    hashCode = hashCode * 59 + this.LanguageSource.GetHashCode();
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
