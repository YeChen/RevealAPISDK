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
    /// ListItem
    /// </summary>
    [DataContract]
    public partial class ListItem :  IEquatable<ListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Text">Text.</param>
        /// <param name="VisibilityControlledBy">VisibilityControlledBy.</param>
        public ListItem(string Value = default(string), string Text = default(string), Object VisibilityControlledBy = default(Object))
        {
            this.Value = Value;
            this.Text = Text;
            this.VisibilityControlledBy = VisibilityControlledBy;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets VisibilityControlledBy
        /// </summary>
        [DataMember(Name="visibilityControlledBy", EmitDefaultValue=false)]
        public Object VisibilityControlledBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItem {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  VisibilityControlledBy: ").Append(VisibilityControlledBy).Append("\n");
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
            return this.Equals(input as ListItem);
        }

        /// <summary>
        /// Returns true if ListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.VisibilityControlledBy == input.VisibilityControlledBy ||
                    (this.VisibilityControlledBy != null &&
                    this.VisibilityControlledBy.Equals(input.VisibilityControlledBy))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.VisibilityControlledBy != null)
                    hashCode = hashCode * 59 + this.VisibilityControlledBy.GetHashCode();
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
