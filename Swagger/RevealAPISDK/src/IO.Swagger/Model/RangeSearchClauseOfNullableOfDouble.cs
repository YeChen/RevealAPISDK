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
    /// RangeSearchClauseOfNullableOfDouble
    /// </summary>
    [DataContract]
    public partial class RangeSearchClauseOfNullableOfDouble :  IEquatable<RangeSearchClauseOfNullableOfDouble>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeSearchClauseOfNullableOfDouble" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="Gte">Gte.</param>
        /// <param name="Gt">Gt.</param>
        /// <param name="Eq">Eq.</param>
        /// <param name="Lte">Lte.</param>
        /// <param name="Lt">Lt.</param>
        /// <param name="Item">Item.</param>
        public RangeSearchClauseOfNullableOfDouble(SearchClauseType Type = default(SearchClauseType), string FieldName = default(string), double? Gte = default(double?), double? Gt = default(double?), double? Eq = default(double?), double? Lte = default(double?), double? Lt = default(double?), double? Item = default(double?))
        {
            this.Type = Type;
            this.FieldName = FieldName;
            this.Gte = Gte;
            this.Gt = Gt;
            this.Eq = Eq;
            this.Lte = Lte;
            this.Lt = Lt;
            this.Item = Item;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SearchClauseType Type { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets Gte
        /// </summary>
        [DataMember(Name="gte", EmitDefaultValue=false)]
        public double? Gte { get; set; }

        /// <summary>
        /// Gets or Sets Gt
        /// </summary>
        [DataMember(Name="gt", EmitDefaultValue=false)]
        public double? Gt { get; set; }

        /// <summary>
        /// Gets or Sets Eq
        /// </summary>
        [DataMember(Name="eq", EmitDefaultValue=false)]
        public double? Eq { get; set; }

        /// <summary>
        /// Gets or Sets Lte
        /// </summary>
        [DataMember(Name="lte", EmitDefaultValue=false)]
        public double? Lte { get; set; }

        /// <summary>
        /// Gets or Sets Lt
        /// </summary>
        [DataMember(Name="lt", EmitDefaultValue=false)]
        public double? Lt { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public double? Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeSearchClauseOfNullableOfDouble {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            sb.Append("  Eq: ").Append(Eq).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as RangeSearchClauseOfNullableOfDouble);
        }

        /// <summary>
        /// Returns true if RangeSearchClauseOfNullableOfDouble instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeSearchClauseOfNullableOfDouble to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeSearchClauseOfNullableOfDouble input)
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
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Gte == input.Gte ||
                    (this.Gte != null &&
                    this.Gte.Equals(input.Gte))
                ) && 
                (
                    this.Gt == input.Gt ||
                    (this.Gt != null &&
                    this.Gt.Equals(input.Gt))
                ) && 
                (
                    this.Eq == input.Eq ||
                    (this.Eq != null &&
                    this.Eq.Equals(input.Eq))
                ) && 
                (
                    this.Lte == input.Lte ||
                    (this.Lte != null &&
                    this.Lte.Equals(input.Lte))
                ) && 
                (
                    this.Lt == input.Lt ||
                    (this.Lt != null &&
                    this.Lt.Equals(input.Lt))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Gte != null)
                    hashCode = hashCode * 59 + this.Gte.GetHashCode();
                if (this.Gt != null)
                    hashCode = hashCode * 59 + this.Gt.GetHashCode();
                if (this.Eq != null)
                    hashCode = hashCode * 59 + this.Eq.GetHashCode();
                if (this.Lte != null)
                    hashCode = hashCode * 59 + this.Lte.GetHashCode();
                if (this.Lt != null)
                    hashCode = hashCode * 59 + this.Lt.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
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
