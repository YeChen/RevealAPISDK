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
    /// FolderItemQuery
    /// </summary>
    [DataContract]
    public partial class FolderItemQuery :  IEquatable<FolderItemQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderItemQuery" /> class.
        /// </summary>
        /// <param name="queryParams">queryParams.</param>
        public FolderItemQuery(FolderItemQueryParams queryParams = default(FolderItemQueryParams))
        {
            this.QueryParams = queryParams;
        }
        
        /// <summary>
        /// Gets or Sets QueryParams
        /// </summary>
        [DataMember(Name="queryParams", EmitDefaultValue=false)]
        public FolderItemQueryParams QueryParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderItemQuery {\n");
            sb.Append("  QueryParams: ").Append(QueryParams).Append("\n");
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
            return this.Equals(input as FolderItemQuery);
        }

        /// <summary>
        /// Returns true if FolderItemQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderItemQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderItemQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueryParams == input.QueryParams ||
                    (this.QueryParams != null &&
                    this.QueryParams.Equals(input.QueryParams))
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
                if (this.QueryParams != null)
                    hashCode = hashCode * 59 + this.QueryParams.GetHashCode();
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
