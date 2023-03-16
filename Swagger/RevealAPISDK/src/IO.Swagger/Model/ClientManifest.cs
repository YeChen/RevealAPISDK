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
    /// ClientManifest
    /// </summary>
    [DataContract]
    public partial class ClientManifest :  IEquatable<ClientManifest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientManifest" /> class.
        /// </summary>
        /// <param name="JobName">JobName.</param>
        /// <param name="Custodian">Custodian.</param>
        /// <param name="Workflow">Workflow.</param>
        /// <param name="DuplicateDocuments">DuplicateDocuments.</param>
        /// <param name="ReviewAPIToken">ReviewAPIToken.</param>
        /// <param name="ClientID">ClientID.</param>
        /// <param name="ClientName">ClientName.</param>
        /// <param name="CompanyID">CompanyID.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="ProjectID">ProjectID.</param>
        /// <param name="ProjectName">ProjectName.</param>
        /// <param name="Api">Api.</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="Source">Source.</param>
        /// <param name="JobGUID">JobGUID.</param>
        /// <param name="JobPath">JobPath.</param>
        /// <param name="S3Path">S3Path.</param>
        /// <param name="CaseID">CaseID.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        public ClientManifest(string JobName = default(string), string Custodian = default(string), string Workflow = default(string), bool? DuplicateDocuments = default(bool?), string ReviewAPIToken = default(string), int? ClientID = default(int?), string ClientName = default(string), int? CompanyID = default(int?), string CompanyName = default(string), string ProjectID = default(string), string ProjectName = default(string), string Api = default(string), string Timezone = default(string), string Source = default(string), string JobGUID = default(string), string JobPath = default(string), string S3Path = default(string), int? CaseID = default(int?), int? CreatedBy = default(int?))
        {
            this.JobName = JobName;
            this.Custodian = Custodian;
            this.Workflow = Workflow;
            this.DuplicateDocuments = DuplicateDocuments;
            this.ReviewAPIToken = ReviewAPIToken;
            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.CompanyID = CompanyID;
            this.CompanyName = CompanyName;
            this.ProjectID = ProjectID;
            this.ProjectName = ProjectName;
            this.Api = Api;
            this.Timezone = Timezone;
            this.Source = Source;
            this.JobGUID = JobGUID;
            this.JobPath = JobPath;
            this.S3Path = S3Path;
            this.CaseID = CaseID;
            this.CreatedBy = CreatedBy;
        }
        
        /// <summary>
        /// Gets or Sets JobName
        /// </summary>
        [DataMember(Name="jobName", EmitDefaultValue=false)]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or Sets Custodian
        /// </summary>
        [DataMember(Name="custodian", EmitDefaultValue=false)]
        public string Custodian { get; set; }

        /// <summary>
        /// Gets or Sets Workflow
        /// </summary>
        [DataMember(Name="workflow", EmitDefaultValue=false)]
        public string Workflow { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateDocuments
        /// </summary>
        [DataMember(Name="duplicateDocuments", EmitDefaultValue=false)]
        public bool? DuplicateDocuments { get; set; }

        /// <summary>
        /// Gets or Sets ReviewAPIToken
        /// </summary>
        [DataMember(Name="reviewAPIToken", EmitDefaultValue=false)]
        public string ReviewAPIToken { get; set; }

        /// <summary>
        /// Gets or Sets ClientID
        /// </summary>
        [DataMember(Name="clientID", EmitDefaultValue=false)]
        public int? ClientID { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="clientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets CompanyID
        /// </summary>
        [DataMember(Name="companyID", EmitDefaultValue=false)]
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID", EmitDefaultValue=false)]
        public string ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="projectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name="api", EmitDefaultValue=false)]
        public string Api { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets JobGUID
        /// </summary>
        [DataMember(Name="jobGUID", EmitDefaultValue=false)]
        public string JobGUID { get; set; }

        /// <summary>
        /// Gets or Sets JobPath
        /// </summary>
        [DataMember(Name="jobPath", EmitDefaultValue=false)]
        public string JobPath { get; set; }

        /// <summary>
        /// Gets or Sets S3Path
        /// </summary>
        [DataMember(Name="s3Path", EmitDefaultValue=false)]
        public string S3Path { get; set; }

        /// <summary>
        /// Gets or Sets CaseID
        /// </summary>
        [DataMember(Name="caseID", EmitDefaultValue=false)]
        public int? CaseID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientManifest {\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  Custodian: ").Append(Custodian).Append("\n");
            sb.Append("  Workflow: ").Append(Workflow).Append("\n");
            sb.Append("  DuplicateDocuments: ").Append(DuplicateDocuments).Append("\n");
            sb.Append("  ReviewAPIToken: ").Append(ReviewAPIToken).Append("\n");
            sb.Append("  ClientID: ").Append(ClientID).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  CompanyID: ").Append(CompanyID).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  JobGUID: ").Append(JobGUID).Append("\n");
            sb.Append("  JobPath: ").Append(JobPath).Append("\n");
            sb.Append("  S3Path: ").Append(S3Path).Append("\n");
            sb.Append("  CaseID: ").Append(CaseID).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as ClientManifest);
        }

        /// <summary>
        /// Returns true if ClientManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientManifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.Custodian == input.Custodian ||
                    (this.Custodian != null &&
                    this.Custodian.Equals(input.Custodian))
                ) && 
                (
                    this.Workflow == input.Workflow ||
                    (this.Workflow != null &&
                    this.Workflow.Equals(input.Workflow))
                ) && 
                (
                    this.DuplicateDocuments == input.DuplicateDocuments ||
                    (this.DuplicateDocuments != null &&
                    this.DuplicateDocuments.Equals(input.DuplicateDocuments))
                ) && 
                (
                    this.ReviewAPIToken == input.ReviewAPIToken ||
                    (this.ReviewAPIToken != null &&
                    this.ReviewAPIToken.Equals(input.ReviewAPIToken))
                ) && 
                (
                    this.ClientID == input.ClientID ||
                    (this.ClientID != null &&
                    this.ClientID.Equals(input.ClientID))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.CompanyID == input.CompanyID ||
                    (this.CompanyID != null &&
                    this.CompanyID.Equals(input.CompanyID))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Api == input.Api ||
                    (this.Api != null &&
                    this.Api.Equals(input.Api))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.JobGUID == input.JobGUID ||
                    (this.JobGUID != null &&
                    this.JobGUID.Equals(input.JobGUID))
                ) && 
                (
                    this.JobPath == input.JobPath ||
                    (this.JobPath != null &&
                    this.JobPath.Equals(input.JobPath))
                ) && 
                (
                    this.S3Path == input.S3Path ||
                    (this.S3Path != null &&
                    this.S3Path.Equals(input.S3Path))
                ) && 
                (
                    this.CaseID == input.CaseID ||
                    (this.CaseID != null &&
                    this.CaseID.Equals(input.CaseID))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.Custodian != null)
                    hashCode = hashCode * 59 + this.Custodian.GetHashCode();
                if (this.Workflow != null)
                    hashCode = hashCode * 59 + this.Workflow.GetHashCode();
                if (this.DuplicateDocuments != null)
                    hashCode = hashCode * 59 + this.DuplicateDocuments.GetHashCode();
                if (this.ReviewAPIToken != null)
                    hashCode = hashCode * 59 + this.ReviewAPIToken.GetHashCode();
                if (this.ClientID != null)
                    hashCode = hashCode * 59 + this.ClientID.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.CompanyID != null)
                    hashCode = hashCode * 59 + this.CompanyID.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Api != null)
                    hashCode = hashCode * 59 + this.Api.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.JobGUID != null)
                    hashCode = hashCode * 59 + this.JobGUID.GetHashCode();
                if (this.JobPath != null)
                    hashCode = hashCode * 59 + this.JobPath.GetHashCode();
                if (this.S3Path != null)
                    hashCode = hashCode * 59 + this.S3Path.GetHashCode();
                if (this.CaseID != null)
                    hashCode = hashCode * 59 + this.CaseID.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
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
