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
    /// DeletionJob
    /// </summary>
    [DataContract]
    public partial class DeletionJob :  IEquatable<DeletionJob>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DeletionJobType? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public JobStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletionJob" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="DeletedJobId">DeletedJobId.</param>
        /// <param name="CreatedByUserId">CreatedByUserId.</param>
        /// <param name="CreatedByUserName">CreatedByUserName.</param>
        /// <param name="NumberOfFiles">NumberOfFiles.</param>
        /// <param name="NumberOfFilesDeleted">NumberOfFilesDeleted.</param>
        /// <param name="Status">Status.</param>
        /// <param name="PerCentComplete">PerCentComplete.</param>
        /// <param name="CreatedDateTime">CreatedDateTime.</param>
        /// <param name="StartDateTime">StartDateTime.</param>
        /// <param name="EndDateTime">EndDateTime.</param>
        /// <param name="NumberOfErrors">NumberOfErrors.</param>
        /// <param name="TotalDocsAffected">TotalDocsAffected.</param>
        public DeletionJob(int? Id = default(int?), string Name = default(string), DeletionJobType? Type = default(DeletionJobType?), int? DeletedJobId = default(int?), long? CreatedByUserId = default(long?), string CreatedByUserName = default(string), long? NumberOfFiles = default(long?), long? NumberOfFilesDeleted = default(long?), JobStatus? Status = default(JobStatus?), int? PerCentComplete = default(int?), DateTime? CreatedDateTime = default(DateTime?), DateTime? StartDateTime = default(DateTime?), DateTime? EndDateTime = default(DateTime?), long? NumberOfErrors = default(long?), long? TotalDocsAffected = default(long?))
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.DeletedJobId = DeletedJobId;
            this.CreatedByUserId = CreatedByUserId;
            this.CreatedByUserName = CreatedByUserName;
            this.NumberOfFiles = NumberOfFiles;
            this.NumberOfFilesDeleted = NumberOfFilesDeleted;
            this.Status = Status;
            this.PerCentComplete = PerCentComplete;
            this.CreatedDateTime = CreatedDateTime;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.NumberOfErrors = NumberOfErrors;
            this.TotalDocsAffected = TotalDocsAffected;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets DeletedJobId
        /// </summary>
        [DataMember(Name="deletedJobId", EmitDefaultValue=false)]
        public int? DeletedJobId { get; set; }

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
        /// Gets or Sets NumberOfFiles
        /// </summary>
        [DataMember(Name="numberOfFiles", EmitDefaultValue=false)]
        public long? NumberOfFiles { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfFilesDeleted
        /// </summary>
        [DataMember(Name="numberOfFilesDeleted", EmitDefaultValue=false)]
        public long? NumberOfFilesDeleted { get; set; }


        /// <summary>
        /// Gets or Sets PerCentComplete
        /// </summary>
        [DataMember(Name="perCentComplete", EmitDefaultValue=false)]
        public int? PerCentComplete { get; set; }

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
        /// Gets or Sets NumberOfErrors
        /// </summary>
        [DataMember(Name="numberOfErrors", EmitDefaultValue=false)]
        public long? NumberOfErrors { get; set; }

        /// <summary>
        /// Gets or Sets TotalDocsAffected
        /// </summary>
        [DataMember(Name="totalDocsAffected", EmitDefaultValue=false)]
        public long? TotalDocsAffected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletionJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeletedJobId: ").Append(DeletedJobId).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
            sb.Append("  NumberOfFiles: ").Append(NumberOfFiles).Append("\n");
            sb.Append("  NumberOfFilesDeleted: ").Append(NumberOfFilesDeleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PerCentComplete: ").Append(PerCentComplete).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  NumberOfErrors: ").Append(NumberOfErrors).Append("\n");
            sb.Append("  TotalDocsAffected: ").Append(TotalDocsAffected).Append("\n");
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
            return this.Equals(input as DeletionJob);
        }

        /// <summary>
        /// Returns true if DeletionJob instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletionJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletionJob input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DeletedJobId == input.DeletedJobId ||
                    (this.DeletedJobId != null &&
                    this.DeletedJobId.Equals(input.DeletedJobId))
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
                    this.NumberOfFiles == input.NumberOfFiles ||
                    (this.NumberOfFiles != null &&
                    this.NumberOfFiles.Equals(input.NumberOfFiles))
                ) && 
                (
                    this.NumberOfFilesDeleted == input.NumberOfFilesDeleted ||
                    (this.NumberOfFilesDeleted != null &&
                    this.NumberOfFilesDeleted.Equals(input.NumberOfFilesDeleted))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PerCentComplete == input.PerCentComplete ||
                    (this.PerCentComplete != null &&
                    this.PerCentComplete.Equals(input.PerCentComplete))
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
                    this.NumberOfErrors == input.NumberOfErrors ||
                    (this.NumberOfErrors != null &&
                    this.NumberOfErrors.Equals(input.NumberOfErrors))
                ) && 
                (
                    this.TotalDocsAffected == input.TotalDocsAffected ||
                    (this.TotalDocsAffected != null &&
                    this.TotalDocsAffected.Equals(input.TotalDocsAffected))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeletedJobId != null)
                    hashCode = hashCode * 59 + this.DeletedJobId.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.CreatedByUserName != null)
                    hashCode = hashCode * 59 + this.CreatedByUserName.GetHashCode();
                if (this.NumberOfFiles != null)
                    hashCode = hashCode * 59 + this.NumberOfFiles.GetHashCode();
                if (this.NumberOfFilesDeleted != null)
                    hashCode = hashCode * 59 + this.NumberOfFilesDeleted.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PerCentComplete != null)
                    hashCode = hashCode * 59 + this.PerCentComplete.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.NumberOfErrors != null)
                    hashCode = hashCode * 59 + this.NumberOfErrors.GetHashCode();
                if (this.TotalDocsAffected != null)
                    hashCode = hashCode * 59 + this.TotalDocsAffected.GetHashCode();
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