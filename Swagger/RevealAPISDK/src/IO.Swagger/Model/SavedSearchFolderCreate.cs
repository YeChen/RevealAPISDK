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
    /// SavedSearchFolderCreate
    /// </summary>
    [DataContract]
    public partial class SavedSearchFolderCreate :  IEquatable<SavedSearchFolderCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedSearchFolderCreate" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="AcLs">AcLs.</param>
        public SavedSearchFolderCreate(string Name = default(string), List<FolderAccessControl> AcLs = default(List<FolderAccessControl>))
        {
            this.Name = Name;
            this.AcLs = AcLs;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AcLs
        /// </summary>
        [DataMember(Name="acLs", EmitDefaultValue=false)]
        public List<FolderAccessControl> AcLs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SavedSearchFolderCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AcLs: ").Append(AcLs).Append("\n");
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
            return this.Equals(input as SavedSearchFolderCreate);
        }

        /// <summary>
        /// Returns true if SavedSearchFolderCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SavedSearchFolderCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SavedSearchFolderCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AcLs == input.AcLs ||
                    this.AcLs != null &&
                    this.AcLs.SequenceEqual(input.AcLs)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AcLs != null)
                    hashCode = hashCode * 59 + this.AcLs.GetHashCode();
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
