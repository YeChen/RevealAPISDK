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
    /// FolderItemQueryParams
    /// </summary>
    [DataContract]
    public partial class FolderItemQueryParams :  IEquatable<FolderItemQueryParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderItemQueryParams" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="isAdminView">isAdminView.</param>
        public FolderItemQueryParams(int? userId = default(int?), bool? isAdminView = default(bool?))
        {
            this.UserId = userId;
            this.IsAdminView = isAdminView;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets IsAdminView
        /// </summary>
        [DataMember(Name="isAdminView", EmitDefaultValue=false)]
        public bool? IsAdminView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderItemQueryParams {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IsAdminView: ").Append(IsAdminView).Append("\n");
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
            return this.Equals(input as FolderItemQueryParams);
        }

        /// <summary>
        /// Returns true if FolderItemQueryParams instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderItemQueryParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderItemQueryParams input)
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
                    this.IsAdminView == input.IsAdminView ||
                    (this.IsAdminView != null &&
                    this.IsAdminView.Equals(input.IsAdminView))
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
                if (this.IsAdminView != null)
                    hashCode = hashCode * 59 + this.IsAdminView.GetHashCode();
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
