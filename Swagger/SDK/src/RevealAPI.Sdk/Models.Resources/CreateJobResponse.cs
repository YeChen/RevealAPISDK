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
    /// CreateJobResponse
    /// </summary>
    [DataContract]
    public partial class CreateJobResponse :  IEquatable<CreateJobResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets JobSubmitStatus
        /// </summary>
        [DataMember(Name="jobSubmitStatus", EmitDefaultValue=false)]
        public JobSubmitStatus? JobSubmitStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="jobSubmitStatus">jobSubmitStatus.</param>
        public CreateJobResponse(long? jobId = default(long?), JobSubmitStatus? jobSubmitStatus = default(JobSubmitStatus?))
        {
            this.JobId = jobId;
            this.JobSubmitStatus = jobSubmitStatus;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public long? JobId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJobResponse {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobSubmitStatus: ").Append(JobSubmitStatus).Append("\n");
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
            return this.Equals(input as CreateJobResponse);
        }

        /// <summary>
        /// Returns true if CreateJobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateJobResponse input)
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
                    this.JobSubmitStatus == input.JobSubmitStatus ||
                    (this.JobSubmitStatus != null &&
                    this.JobSubmitStatus.Equals(input.JobSubmitStatus))
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
                if (this.JobSubmitStatus != null)
                    hashCode = hashCode * 59 + this.JobSubmitStatus.GetHashCode();
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
