/* 
 * Reveal API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = RevealAPI.V1.Client.SwaggerDateConverter;

namespace RevealAPI.V1.Models.Resources
{
    /// <summary>
    /// IndexJob
    /// </summary>
    [DataContract]
    public partial class IndexJob :  IEquatable<IndexJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexJob" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="jobName">jobName.</param>
        /// <param name="jobStatus">jobStatus.</param>
        /// <param name="jobStatusName">jobStatusName.</param>
        /// <param name="totalNumberOfDocuments">totalNumberOfDocuments.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="createdByUser">createdByUser.</param>
        /// <param name="modifiedDateTime">modifiedDateTime.</param>
        /// <param name="modifiedByUser">modifiedByUser.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="percentComplete">percentComplete.</param>
        /// <param name="serviceURL">serviceURL.</param>
        /// <param name="jobInfoMessage">jobInfoMessage.</param>
        /// <param name="priority">priority.</param>
        public IndexJob(int? jobId = default(int?), string jobName = default(string), int? jobStatus = default(int?), string jobStatusName = default(string), long? totalNumberOfDocuments = default(long?), DateTime? createdDateTime = default(DateTime?), long? createdByUser = default(long?), DateTime? modifiedDateTime = default(DateTime?), long? modifiedByUser = default(long?), DateTime? startDateTime = default(DateTime?), DateTime? endDateTime = default(DateTime?), int? percentComplete = default(int?), string serviceURL = default(string), string jobInfoMessage = default(string), int? priority = default(int?))
        {
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobStatus = jobStatus;
            this.JobStatusName = jobStatusName;
            this.TotalNumberOfDocuments = totalNumberOfDocuments;
            this.CreatedDateTime = createdDateTime;
            this.CreatedByUser = createdByUser;
            this.ModifiedDateTime = modifiedDateTime;
            this.ModifiedByUser = modifiedByUser;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.PercentComplete = percentComplete;
            this.ServiceURL = serviceURL;
            this.JobInfoMessage = jobInfoMessage;
            this.Priority = priority;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobName
        /// </summary>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="jobStatus", EmitDefaultValue=false)]
        public int? JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets JobStatusName
        /// </summary>
        [DataMember(Name="jobStatusName", EmitDefaultValue=false)]
        public string JobStatusName { get; set; }

        /// <summary>
        /// Gets or Sets TotalNumberOfDocuments
        /// </summary>
        [DataMember(Name="totalNumberOfDocuments", EmitDefaultValue=false)]
        public long? TotalNumberOfDocuments { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUser
        /// </summary>
        [DataMember(Name="createdByUser", EmitDefaultValue=false)]
        public long? CreatedByUser { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTime
        /// </summary>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByUser
        /// </summary>
        [DataMember(Name="modifiedByUser", EmitDefaultValue=false)]
        public long? ModifiedByUser { get; set; }

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
        /// Gets or Sets PercentComplete
        /// </summary>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Gets or Sets ServiceURL
        /// </summary>
        [DataMember(Name="serviceURL", EmitDefaultValue=false)]
        public string ServiceURL { get; set; }

        /// <summary>
        /// Gets or Sets JobInfoMessage
        /// </summary>
        [DataMember(Name="jobInfoMessage", EmitDefaultValue=false)]
        public string JobInfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexJob {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  JobStatusName: ").Append(JobStatusName).Append("\n");
            sb.Append("  TotalNumberOfDocuments: ").Append(TotalNumberOfDocuments).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  ModifiedByUser: ").Append(ModifiedByUser).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  ServiceURL: ").Append(ServiceURL).Append("\n");
            sb.Append("  JobInfoMessage: ").Append(JobInfoMessage).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as IndexJob);
        }

        /// <summary>
        /// Returns true if IndexJob instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.JobStatusName == input.JobStatusName ||
                    (this.JobStatusName != null &&
                    this.JobStatusName.Equals(input.JobStatusName))
                ) && 
                (
                    this.TotalNumberOfDocuments == input.TotalNumberOfDocuments ||
                    (this.TotalNumberOfDocuments != null &&
                    this.TotalNumberOfDocuments.Equals(input.TotalNumberOfDocuments))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
                ) && 
                (
                    this.ModifiedDateTime == input.ModifiedDateTime ||
                    (this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(input.ModifiedDateTime))
                ) && 
                (
                    this.ModifiedByUser == input.ModifiedByUser ||
                    (this.ModifiedByUser != null &&
                    this.ModifiedByUser.Equals(input.ModifiedByUser))
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
                    this.PercentComplete == input.PercentComplete ||
                    (this.PercentComplete != null &&
                    this.PercentComplete.Equals(input.PercentComplete))
                ) && 
                (
                    this.ServiceURL == input.ServiceURL ||
                    (this.ServiceURL != null &&
                    this.ServiceURL.Equals(input.ServiceURL))
                ) && 
                (
                    this.JobInfoMessage == input.JobInfoMessage ||
                    (this.JobInfoMessage != null &&
                    this.JobInfoMessage.Equals(input.JobInfoMessage))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.JobStatusName != null)
                    hashCode = hashCode * 59 + this.JobStatusName.GetHashCode();
                if (this.TotalNumberOfDocuments != null)
                    hashCode = hashCode * 59 + this.TotalNumberOfDocuments.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CreatedByUser != null)
                    hashCode = hashCode * 59 + this.CreatedByUser.GetHashCode();
                if (this.ModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.ModifiedDateTime.GetHashCode();
                if (this.ModifiedByUser != null)
                    hashCode = hashCode * 59 + this.ModifiedByUser.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.PercentComplete != null)
                    hashCode = hashCode * 59 + this.PercentComplete.GetHashCode();
                if (this.ServiceURL != null)
                    hashCode = hashCode * 59 + this.ServiceURL.GetHashCode();
                if (this.JobInfoMessage != null)
                    hashCode = hashCode * 59 + this.JobInfoMessage.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
