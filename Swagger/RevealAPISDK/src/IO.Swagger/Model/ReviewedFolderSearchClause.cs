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
    /// ReviewedFolderSearchClause
    /// </summary>
    [DataContract]
    public partial class ReviewedFolderSearchClause :  IEquatable<ReviewedFolderSearchClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewedFolderSearchClause" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="FolderType">FolderType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IncludeSubFolders">IncludeSubFolders.</param>
        /// <param name="FolderName">FolderName.</param>
        public ReviewedFolderSearchClause(SearchClauseType Type = default(SearchClauseType), FolderSearchType FolderType = default(FolderSearchType), string Id = default(string), bool? IncludeSubFolders = default(bool?), string FolderName = default(string))
        {
            this.Type = Type;
            this.FolderType = FolderType;
            this.Id = Id;
            this.IncludeSubFolders = IncludeSubFolders;
            this.FolderName = FolderName;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SearchClauseType Type { get; set; }

        /// <summary>
        /// Gets or Sets FolderType
        /// </summary>
        [DataMember(Name="folderType", EmitDefaultValue=false)]
        public FolderSearchType FolderType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSubFolders
        /// </summary>
        [DataMember(Name="includeSubFolders", EmitDefaultValue=false)]
        public bool? IncludeSubFolders { get; set; }

        /// <summary>
        /// Gets or Sets FolderName
        /// </summary>
        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewedFolderSearchClause {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncludeSubFolders: ").Append(IncludeSubFolders).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
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
            return this.Equals(input as ReviewedFolderSearchClause);
        }

        /// <summary>
        /// Returns true if ReviewedFolderSearchClause instances are equal
        /// </summary>
        /// <param name="input">Instance of ReviewedFolderSearchClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReviewedFolderSearchClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FolderType == input.FolderType ||
                    (this.FolderType != null &&
                    this.FolderType.Equals(input.FolderType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncludeSubFolders == input.IncludeSubFolders ||
                    (this.IncludeSubFolders != null &&
                    this.IncludeSubFolders.Equals(input.IncludeSubFolders))
                ) && 
                (
                    this.FolderName == input.FolderName ||
                    (this.FolderName != null &&
                    this.FolderName.Equals(input.FolderName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FolderType != null)
                    hashCode = hashCode * 59 + this.FolderType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncludeSubFolders != null)
                    hashCode = hashCode * 59 + this.IncludeSubFolders.GetHashCode();
                if (this.FolderName != null)
                    hashCode = hashCode * 59 + this.FolderName.GetHashCode();
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