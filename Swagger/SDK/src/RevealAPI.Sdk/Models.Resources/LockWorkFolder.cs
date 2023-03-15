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
    /// LockWorkFolder
    /// </summary>
    [DataContract]
    public partial class LockWorkFolder :  IEquatable<LockWorkFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockWorkFolder" /> class.
        /// </summary>
        /// <param name="fields">fields.</param>
        /// <param name="notes">notes.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="redactions">redactions.</param>
        /// <param name="tagSetIds">tagSetIds.</param>
        public LockWorkFolder(bool? fields = default(bool?), bool? notes = default(bool?), bool? annotations = default(bool?), bool? redactions = default(bool?), List<int?> tagSetIds = default(List<int?>))
        {
            this.Fields = fields;
            this.Notes = notes;
            this.Annotations = annotations;
            this.Redactions = redactions;
            this.TagSetIds = tagSetIds;
        }
        
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public bool? Fields { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public bool? Notes { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public bool? Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Redactions
        /// </summary>
        [DataMember(Name="redactions", EmitDefaultValue=false)]
        public bool? Redactions { get; set; }

        /// <summary>
        /// Gets or Sets TagSetIds
        /// </summary>
        [DataMember(Name="tagSetIds", EmitDefaultValue=false)]
        public List<int?> TagSetIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockWorkFolder {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Redactions: ").Append(Redactions).Append("\n");
            sb.Append("  TagSetIds: ").Append(TagSetIds).Append("\n");
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
            return this.Equals(input as LockWorkFolder);
        }

        /// <summary>
        /// Returns true if LockWorkFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of LockWorkFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockWorkFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    (this.Fields != null &&
                    this.Fields.Equals(input.Fields))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    (this.Annotations != null &&
                    this.Annotations.Equals(input.Annotations))
                ) && 
                (
                    this.Redactions == input.Redactions ||
                    (this.Redactions != null &&
                    this.Redactions.Equals(input.Redactions))
                ) && 
                (
                    this.TagSetIds == input.TagSetIds ||
                    this.TagSetIds != null &&
                    this.TagSetIds.SequenceEqual(input.TagSetIds)
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.Redactions != null)
                    hashCode = hashCode * 59 + this.Redactions.GetHashCode();
                if (this.TagSetIds != null)
                    hashCode = hashCode * 59 + this.TagSetIds.GetHashCode();
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
