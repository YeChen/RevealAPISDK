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
    /// LookupTokenResponse
    /// </summary>
    [DataContract]
    public partial class LookupTokenResponse :  IEquatable<LookupTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupTokenResponse" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="caseId">caseId.</param>
        /// <param name="caseName">caseName.</param>
        /// <param name="databaseId">databaseId.</param>
        /// <param name="databaseName">databaseName.</param>
        public LookupTokenResponse(long? userId = default(long?), string userName = default(string), int? caseId = default(int?), string caseName = default(string), int? databaseId = default(int?), string databaseName = default(string))
        {
            this.UserId = userId;
            this.UserName = userName;
            this.CaseId = caseId;
            this.CaseName = caseName;
            this.DatabaseId = databaseId;
            this.DatabaseName = databaseName;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

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
        /// Gets or Sets DatabaseId
        /// </summary>
        [DataMember(Name="databaseId", EmitDefaultValue=false)]
        public int? DatabaseId { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseName
        /// </summary>
        [DataMember(Name="databaseName", EmitDefaultValue=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupTokenResponse {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  CaseName: ").Append(CaseName).Append("\n");
            sb.Append("  DatabaseId: ").Append(DatabaseId).Append("\n");
            sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
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
            return this.Equals(input as LookupTokenResponse);
        }

        /// <summary>
        /// Returns true if LookupTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
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
                    this.DatabaseId == input.DatabaseId ||
                    (this.DatabaseId != null &&
                    this.DatabaseId.Equals(input.DatabaseId))
                ) && 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CaseId != null)
                    hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.CaseName != null)
                    hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.DatabaseId != null)
                    hashCode = hashCode * 59 + this.DatabaseId.GetHashCode();
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
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
