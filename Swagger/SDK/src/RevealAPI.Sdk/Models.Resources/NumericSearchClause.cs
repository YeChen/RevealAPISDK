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
    /// NumericSearchClause
    /// </summary>
    [DataContract]
    public partial class NumericSearchClause :  IEquatable<NumericSearchClause>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericSearchClause" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="gte">gte.</param>
        /// <param name="gt">gt.</param>
        /// <param name="eq">eq.</param>
        /// <param name="lte">lte.</param>
        /// <param name="lt">lt.</param>
        /// <param name="item">item.</param>
        public NumericSearchClause(SearchClauseType type = default(SearchClauseType), string fieldName = default(string), double? gte = default(double?), double? gt = default(double?), double? eq = default(double?), double? lte = default(double?), double? lt = default(double?), double? item = default(double?))
        {
            this.Type = type;
            this.FieldName = fieldName;
            this.Gte = gte;
            this.Gt = gt;
            this.Eq = eq;
            this.Lte = lte;
            this.Lt = lt;
            this.Item = item;
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
            sb.Append("class NumericSearchClause {\n");
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
            return this.Equals(input as NumericSearchClause);
        }

        /// <summary>
        /// Returns true if NumericSearchClause instances are equal
        /// </summary>
        /// <param name="input">Instance of NumericSearchClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumericSearchClause input)
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