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
    /// UpdateFieldEntry
    /// </summary>
    [DataContract]
    public partial class UpdateFieldEntry :  IEquatable<UpdateFieldEntry>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets UpdateOption
        /// </summary>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public BulkFieldUpdateOption? UpdateOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldEntry" /> class.
        /// </summary>
        /// <param name="variableSets">variableSets.</param>
        /// <param name="updateOption">updateOption.</param>
        public UpdateFieldEntry(List<FieldUpdateVariableSet> variableSets = default(List<FieldUpdateVariableSet>), BulkFieldUpdateOption? updateOption = default(BulkFieldUpdateOption?))
        {
            this.VariableSets = variableSets;
            this.UpdateOption = updateOption;
        }
        
        /// <summary>
        /// Gets or Sets VariableSets
        /// </summary>
        [DataMember(Name="variableSets", EmitDefaultValue=false)]
        public List<FieldUpdateVariableSet> VariableSets { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFieldEntry {\n");
            sb.Append("  VariableSets: ").Append(VariableSets).Append("\n");
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
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
            return this.Equals(input as UpdateFieldEntry);
        }

        /// <summary>
        /// Returns true if UpdateFieldEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFieldEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFieldEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableSets == input.VariableSets ||
                    this.VariableSets != null &&
                    this.VariableSets.SequenceEqual(input.VariableSets)
                ) && 
                (
                    this.UpdateOption == input.UpdateOption ||
                    (this.UpdateOption != null &&
                    this.UpdateOption.Equals(input.UpdateOption))
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
                if (this.VariableSets != null)
                    hashCode = hashCode * 59 + this.VariableSets.GetHashCode();
                if (this.UpdateOption != null)
                    hashCode = hashCode * 59 + this.UpdateOption.GetHashCode();
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