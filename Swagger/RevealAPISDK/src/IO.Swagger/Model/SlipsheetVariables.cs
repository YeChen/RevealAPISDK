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
    /// SlipsheetVariables
    /// </summary>
    [DataContract]
    public partial class SlipsheetVariables :  IEquatable<SlipsheetVariables>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public SlipsheetProfileVariableCategory? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlipsheetVariables" /> class.
        /// </summary>
        /// <param name="DisplayOrder">DisplayOrder.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Value">Value.</param>
        public SlipsheetVariables(int? DisplayOrder = default(int?), SlipsheetProfileVariableCategory? Category = default(SlipsheetProfileVariableCategory?), string Value = default(string))
        {
            this.DisplayOrder = DisplayOrder;
            this.Category = Category;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlipsheetVariables {\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SlipsheetVariables);
        }

        /// <summary>
        /// Returns true if SlipsheetVariables instances are equal
        /// </summary>
        /// <param name="input">Instance of SlipsheetVariables to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlipsheetVariables input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayOrder == input.DisplayOrder ||
                    (this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(input.DisplayOrder))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.DisplayOrder != null)
                    hashCode = hashCode * 59 + this.DisplayOrder.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
