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
    /// FieldCountFilter
    /// </summary>
    [DataContract]
    public partial class FieldCountFilter :  IEquatable<FieldCountFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCountFilter" /> class.
        /// </summary>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="ExcludedFieldValues">Field values to exclude.</param>
        /// <param name="IncludedFieldValues">Field values to include.</param>
        public FieldCountFilter(string FieldName = default(string), List<string> ExcludedFieldValues = default(List<string>), List<string> IncludedFieldValues = default(List<string>))
        {
            this.FieldName = FieldName;
            this.ExcludedFieldValues = ExcludedFieldValues;
            this.IncludedFieldValues = IncludedFieldValues;
        }
        
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Field values to exclude
        /// </summary>
        /// <value>Field values to exclude</value>
        [DataMember(Name="excludedFieldValues", EmitDefaultValue=false)]
        public List<string> ExcludedFieldValues { get; set; }

        /// <summary>
        /// Field values to include
        /// </summary>
        /// <value>Field values to include</value>
        [DataMember(Name="includedFieldValues", EmitDefaultValue=false)]
        public List<string> IncludedFieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldCountFilter {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ExcludedFieldValues: ").Append(ExcludedFieldValues).Append("\n");
            sb.Append("  IncludedFieldValues: ").Append(IncludedFieldValues).Append("\n");
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
            return this.Equals(input as FieldCountFilter);
        }

        /// <summary>
        /// Returns true if FieldCountFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldCountFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldCountFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.ExcludedFieldValues == input.ExcludedFieldValues ||
                    this.ExcludedFieldValues != null &&
                    this.ExcludedFieldValues.SequenceEqual(input.ExcludedFieldValues)
                ) && 
                (
                    this.IncludedFieldValues == input.IncludedFieldValues ||
                    this.IncludedFieldValues != null &&
                    this.IncludedFieldValues.SequenceEqual(input.IncludedFieldValues)
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.ExcludedFieldValues != null)
                    hashCode = hashCode * 59 + this.ExcludedFieldValues.GetHashCode();
                if (this.IncludedFieldValues != null)
                    hashCode = hashCode * 59 + this.IncludedFieldValues.GetHashCode();
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