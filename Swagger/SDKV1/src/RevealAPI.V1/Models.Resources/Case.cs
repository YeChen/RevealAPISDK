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
    /// Case
    /// </summary>
    [DataContract]
    public partial class Case :  IEquatable<Case>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Case" /> class.
        /// </summary>
        /// <param name="caseId">caseId.</param>
        /// <param name="caseName">caseName.</param>
        /// <param name="clientNumber">clientNumber.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="databaseTemplateId">databaseTemplateId.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientName">clientName.</param>
        /// <param name="companyId">companyId.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="caseTypeId">caseTypeId.</param>
        /// <param name="partyTypeId">partyTypeId.</param>
        /// <param name="createdUserId">createdUserId.</param>
        /// <param name="modifiedUserId">modifiedUserId.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="modifiedDateTime">modifiedDateTime.</param>
        /// <param name="searchEngineType">searchEngineType.</param>
        /// <param name="twoFactorAuth">twoFactorAuth.</param>
        /// <param name="documentLevelSecurity">documentLevelSecurity.</param>
        /// <param name="artificialIntelligence">artificialIntelligence.</param>
        /// <param name="artificialIntelligenceId">artificialIntelligenceId.</param>
        /// <param name="timezone">timezone.</param>
        public Case(int? caseId = default(int?), string caseName = default(string), string clientNumber = default(string), string projectId = default(string), int? databaseTemplateId = default(int?), long? clientId = default(long?), string clientName = default(string), int? companyId = default(int?), string companyName = default(string), int? caseTypeId = default(int?), int? partyTypeId = default(int?), long? createdUserId = default(long?), long? modifiedUserId = default(long?), DateTime? createdDateTime = default(DateTime?), DateTime? modifiedDateTime = default(DateTime?), int? searchEngineType = default(int?), bool? twoFactorAuth = default(bool?), bool? documentLevelSecurity = default(bool?), bool? artificialIntelligence = default(bool?), long? artificialIntelligenceId = default(long?), string timezone = default(string))
        {
            this.CaseId = caseId;
            this.CaseName = caseName;
            this.ClientNumber = clientNumber;
            this.ProjectId = projectId;
            this.DatabaseTemplateId = databaseTemplateId;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.CompanyId = companyId;
            this.CompanyName = companyName;
            this.CaseTypeId = caseTypeId;
            this.PartyTypeId = partyTypeId;
            this.CreatedUserId = createdUserId;
            this.ModifiedUserId = modifiedUserId;
            this.CreatedDateTime = createdDateTime;
            this.ModifiedDateTime = modifiedDateTime;
            this.SearchEngineType = searchEngineType;
            this.TwoFactorAuth = twoFactorAuth;
            this.DocumentLevelSecurity = documentLevelSecurity;
            this.ArtificialIntelligence = artificialIntelligence;
            this.ArtificialIntelligenceId = artificialIntelligenceId;
            this.Timezone = timezone;
        }
        
        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>
        [DataMember(Name="caseId", EmitDefaultValue=false)]
        public int? CaseId { get; set; }

        /// <summary>
        /// Gets or Sets CaseName
        /// </summary>
        [DataMember(Name="caseName", EmitDefaultValue=false)]
        public string CaseName { get; set; }

        /// <summary>
        /// Gets or Sets ClientNumber
        /// </summary>
        [DataMember(Name="clientNumber", EmitDefaultValue=false)]
        public string ClientNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseTemplateId
        /// </summary>
        [DataMember(Name="databaseTemplateId", EmitDefaultValue=false)]
        public int? DatabaseTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientName
        /// </summary>
        [DataMember(Name="clientName", EmitDefaultValue=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets CaseTypeId
        /// </summary>
        [DataMember(Name="caseTypeId", EmitDefaultValue=false)]
        public int? CaseTypeId { get; set; }

        /// <summary>
        /// Gets or Sets PartyTypeId
        /// </summary>
        [DataMember(Name="partyTypeId", EmitDefaultValue=false)]
        public int? PartyTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedUserId
        /// </summary>
        [DataMember(Name="createdUserId", EmitDefaultValue=false)]
        public long? CreatedUserId { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedUserId
        /// </summary>
        [DataMember(Name="modifiedUserId", EmitDefaultValue=false)]
        public long? ModifiedUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTime
        /// </summary>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets SearchEngineType
        /// </summary>
        [DataMember(Name="searchEngineType", EmitDefaultValue=false)]
        public int? SearchEngineType { get; set; }

        /// <summary>
        /// Gets or Sets TwoFactorAuth
        /// </summary>
        [DataMember(Name="twoFactorAuth", EmitDefaultValue=false)]
        public bool? TwoFactorAuth { get; set; }

        /// <summary>
        /// Gets or Sets DocumentLevelSecurity
        /// </summary>
        [DataMember(Name="documentLevelSecurity", EmitDefaultValue=false)]
        public bool? DocumentLevelSecurity { get; set; }

        /// <summary>
        /// Gets or Sets ArtificialIntelligence
        /// </summary>
        [DataMember(Name="artificialIntelligence", EmitDefaultValue=false)]
        public bool? ArtificialIntelligence { get; set; }

        /// <summary>
        /// Gets or Sets ArtificialIntelligenceId
        /// </summary>
        [DataMember(Name="artificialIntelligenceId", EmitDefaultValue=false)]
        public long? ArtificialIntelligenceId { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Case {\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  CaseName: ").Append(CaseName).Append("\n");
            sb.Append("  ClientNumber: ").Append(ClientNumber).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  DatabaseTemplateId: ").Append(DatabaseTemplateId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientName: ").Append(ClientName).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CaseTypeId: ").Append(CaseTypeId).Append("\n");
            sb.Append("  PartyTypeId: ").Append(PartyTypeId).Append("\n");
            sb.Append("  CreatedUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  ModifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  SearchEngineType: ").Append(SearchEngineType).Append("\n");
            sb.Append("  TwoFactorAuth: ").Append(TwoFactorAuth).Append("\n");
            sb.Append("  DocumentLevelSecurity: ").Append(DocumentLevelSecurity).Append("\n");
            sb.Append("  ArtificialIntelligence: ").Append(ArtificialIntelligence).Append("\n");
            sb.Append("  ArtificialIntelligenceId: ").Append(ArtificialIntelligenceId).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as Case);
        }

        /// <summary>
        /// Returns true if Case instances are equal
        /// </summary>
        /// <param name="input">Instance of Case to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Case input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaseId == input.CaseId ||
                    (this.CaseId != null &&
                    this.CaseId.Equals(input.CaseId))
                ) && 
                (
                    this.CaseName == input.CaseName ||
                    (this.CaseName != null &&
                    this.CaseName.Equals(input.CaseName))
                ) && 
                (
                    this.ClientNumber == input.ClientNumber ||
                    (this.ClientNumber != null &&
                    this.ClientNumber.Equals(input.ClientNumber))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.DatabaseTemplateId == input.DatabaseTemplateId ||
                    (this.DatabaseTemplateId != null &&
                    this.DatabaseTemplateId.Equals(input.DatabaseTemplateId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientName == input.ClientName ||
                    (this.ClientName != null &&
                    this.ClientName.Equals(input.ClientName))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CaseTypeId == input.CaseTypeId ||
                    (this.CaseTypeId != null &&
                    this.CaseTypeId.Equals(input.CaseTypeId))
                ) && 
                (
                    this.PartyTypeId == input.PartyTypeId ||
                    (this.PartyTypeId != null &&
                    this.PartyTypeId.Equals(input.PartyTypeId))
                ) && 
                (
                    this.CreatedUserId == input.CreatedUserId ||
                    (this.CreatedUserId != null &&
                    this.CreatedUserId.Equals(input.CreatedUserId))
                ) && 
                (
                    this.ModifiedUserId == input.ModifiedUserId ||
                    (this.ModifiedUserId != null &&
                    this.ModifiedUserId.Equals(input.ModifiedUserId))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.ModifiedDateTime == input.ModifiedDateTime ||
                    (this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(input.ModifiedDateTime))
                ) && 
                (
                    this.SearchEngineType == input.SearchEngineType ||
                    (this.SearchEngineType != null &&
                    this.SearchEngineType.Equals(input.SearchEngineType))
                ) && 
                (
                    this.TwoFactorAuth == input.TwoFactorAuth ||
                    (this.TwoFactorAuth != null &&
                    this.TwoFactorAuth.Equals(input.TwoFactorAuth))
                ) && 
                (
                    this.DocumentLevelSecurity == input.DocumentLevelSecurity ||
                    (this.DocumentLevelSecurity != null &&
                    this.DocumentLevelSecurity.Equals(input.DocumentLevelSecurity))
                ) && 
                (
                    this.ArtificialIntelligence == input.ArtificialIntelligence ||
                    (this.ArtificialIntelligence != null &&
                    this.ArtificialIntelligence.Equals(input.ArtificialIntelligence))
                ) && 
                (
                    this.ArtificialIntelligenceId == input.ArtificialIntelligenceId ||
                    (this.ArtificialIntelligenceId != null &&
                    this.ArtificialIntelligenceId.Equals(input.ArtificialIntelligenceId))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.CaseId != null)
                    hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.CaseName != null)
                    hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.ClientNumber != null)
                    hashCode = hashCode * 59 + this.ClientNumber.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DatabaseTemplateId != null)
                    hashCode = hashCode * 59 + this.DatabaseTemplateId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientName != null)
                    hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CaseTypeId != null)
                    hashCode = hashCode * 59 + this.CaseTypeId.GetHashCode();
                if (this.PartyTypeId != null)
                    hashCode = hashCode * 59 + this.PartyTypeId.GetHashCode();
                if (this.CreatedUserId != null)
                    hashCode = hashCode * 59 + this.CreatedUserId.GetHashCode();
                if (this.ModifiedUserId != null)
                    hashCode = hashCode * 59 + this.ModifiedUserId.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.ModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.ModifiedDateTime.GetHashCode();
                if (this.SearchEngineType != null)
                    hashCode = hashCode * 59 + this.SearchEngineType.GetHashCode();
                if (this.TwoFactorAuth != null)
                    hashCode = hashCode * 59 + this.TwoFactorAuth.GetHashCode();
                if (this.DocumentLevelSecurity != null)
                    hashCode = hashCode * 59 + this.DocumentLevelSecurity.GetHashCode();
                if (this.ArtificialIntelligence != null)
                    hashCode = hashCode * 59 + this.ArtificialIntelligence.GetHashCode();
                if (this.ArtificialIntelligenceId != null)
                    hashCode = hashCode * 59 + this.ArtificialIntelligenceId.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
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