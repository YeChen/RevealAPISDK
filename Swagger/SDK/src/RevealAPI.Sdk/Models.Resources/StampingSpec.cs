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
    /// StampingSpec
    /// </summary>
    [DataContract]
    public partial class StampingSpec :  IEquatable<StampingSpec>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets FontStyle
        /// </summary>
        [DataMember(Name="fontStyle", EmitDefaultValue=false)]
        public FontStyle? FontStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StampingSpec" /> class.
        /// </summary>
        /// <param name="fontName">fontName.</param>
        /// <param name="fontStyle">fontStyle.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="color">color.</param>
        /// <param name="removeExtraLineBreaks">removeExtraLineBreaks.</param>
        /// <param name="lineBreakValue">lineBreakValue.</param>
        /// <param name="ulStamp">ulStamp.</param>
        /// <param name="umStamp">umStamp.</param>
        /// <param name="urStamp">urStamp.</param>
        /// <param name="llStamp">llStamp.</param>
        /// <param name="lmStamp">lmStamp.</param>
        /// <param name="lrStamp">lrStamp.</param>
        public StampingSpec(string fontName = default(string), FontStyle? fontStyle = default(FontStyle?), int? fontSize = default(int?), string color = default(string), bool? removeExtraLineBreaks = default(bool?), int? lineBreakValue = default(int?), RegionStampSpec ulStamp = default(RegionStampSpec), RegionStampSpec umStamp = default(RegionStampSpec), RegionStampSpec urStamp = default(RegionStampSpec), RegionStampSpec llStamp = default(RegionStampSpec), RegionStampSpec lmStamp = default(RegionStampSpec), RegionStampSpec lrStamp = default(RegionStampSpec))
        {
            this.FontName = fontName;
            this.FontStyle = fontStyle;
            this.FontSize = fontSize;
            this.Color = color;
            this.RemoveExtraLineBreaks = removeExtraLineBreaks;
            this.LineBreakValue = lineBreakValue;
            this.UlStamp = ulStamp;
            this.UmStamp = umStamp;
            this.UrStamp = urStamp;
            this.LlStamp = llStamp;
            this.LmStamp = lmStamp;
            this.LrStamp = lrStamp;
        }
        
        /// <summary>
        /// Gets or Sets FontName
        /// </summary>
        [DataMember(Name="fontName", EmitDefaultValue=false)]
        public string FontName { get; set; }


        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public int? FontSize { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets RemoveExtraLineBreaks
        /// </summary>
        [DataMember(Name="removeExtraLineBreaks", EmitDefaultValue=false)]
        public bool? RemoveExtraLineBreaks { get; set; }

        /// <summary>
        /// Gets or Sets LineBreakValue
        /// </summary>
        [DataMember(Name="lineBreakValue", EmitDefaultValue=false)]
        public int? LineBreakValue { get; set; }

        /// <summary>
        /// Gets or Sets UlStamp
        /// </summary>
        [DataMember(Name="ulStamp", EmitDefaultValue=false)]
        public RegionStampSpec UlStamp { get; set; }

        /// <summary>
        /// Gets or Sets UmStamp
        /// </summary>
        [DataMember(Name="umStamp", EmitDefaultValue=false)]
        public RegionStampSpec UmStamp { get; set; }

        /// <summary>
        /// Gets or Sets UrStamp
        /// </summary>
        [DataMember(Name="urStamp", EmitDefaultValue=false)]
        public RegionStampSpec UrStamp { get; set; }

        /// <summary>
        /// Gets or Sets LlStamp
        /// </summary>
        [DataMember(Name="llStamp", EmitDefaultValue=false)]
        public RegionStampSpec LlStamp { get; set; }

        /// <summary>
        /// Gets or Sets LmStamp
        /// </summary>
        [DataMember(Name="lmStamp", EmitDefaultValue=false)]
        public RegionStampSpec LmStamp { get; set; }

        /// <summary>
        /// Gets or Sets LrStamp
        /// </summary>
        [DataMember(Name="lrStamp", EmitDefaultValue=false)]
        public RegionStampSpec LrStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StampingSpec {\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  RemoveExtraLineBreaks: ").Append(RemoveExtraLineBreaks).Append("\n");
            sb.Append("  LineBreakValue: ").Append(LineBreakValue).Append("\n");
            sb.Append("  UlStamp: ").Append(UlStamp).Append("\n");
            sb.Append("  UmStamp: ").Append(UmStamp).Append("\n");
            sb.Append("  UrStamp: ").Append(UrStamp).Append("\n");
            sb.Append("  LlStamp: ").Append(LlStamp).Append("\n");
            sb.Append("  LmStamp: ").Append(LmStamp).Append("\n");
            sb.Append("  LrStamp: ").Append(LrStamp).Append("\n");
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
            return this.Equals(input as StampingSpec);
        }

        /// <summary>
        /// Returns true if StampingSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of StampingSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StampingSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FontName == input.FontName ||
                    (this.FontName != null &&
                    this.FontName.Equals(input.FontName))
                ) && 
                (
                    this.FontStyle == input.FontStyle ||
                    (this.FontStyle != null &&
                    this.FontStyle.Equals(input.FontStyle))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.RemoveExtraLineBreaks == input.RemoveExtraLineBreaks ||
                    (this.RemoveExtraLineBreaks != null &&
                    this.RemoveExtraLineBreaks.Equals(input.RemoveExtraLineBreaks))
                ) && 
                (
                    this.LineBreakValue == input.LineBreakValue ||
                    (this.LineBreakValue != null &&
                    this.LineBreakValue.Equals(input.LineBreakValue))
                ) && 
                (
                    this.UlStamp == input.UlStamp ||
                    (this.UlStamp != null &&
                    this.UlStamp.Equals(input.UlStamp))
                ) && 
                (
                    this.UmStamp == input.UmStamp ||
                    (this.UmStamp != null &&
                    this.UmStamp.Equals(input.UmStamp))
                ) && 
                (
                    this.UrStamp == input.UrStamp ||
                    (this.UrStamp != null &&
                    this.UrStamp.Equals(input.UrStamp))
                ) && 
                (
                    this.LlStamp == input.LlStamp ||
                    (this.LlStamp != null &&
                    this.LlStamp.Equals(input.LlStamp))
                ) && 
                (
                    this.LmStamp == input.LmStamp ||
                    (this.LmStamp != null &&
                    this.LmStamp.Equals(input.LmStamp))
                ) && 
                (
                    this.LrStamp == input.LrStamp ||
                    (this.LrStamp != null &&
                    this.LrStamp.Equals(input.LrStamp))
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
                if (this.FontName != null)
                    hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.FontStyle != null)
                    hashCode = hashCode * 59 + this.FontStyle.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.RemoveExtraLineBreaks != null)
                    hashCode = hashCode * 59 + this.RemoveExtraLineBreaks.GetHashCode();
                if (this.LineBreakValue != null)
                    hashCode = hashCode * 59 + this.LineBreakValue.GetHashCode();
                if (this.UlStamp != null)
                    hashCode = hashCode * 59 + this.UlStamp.GetHashCode();
                if (this.UmStamp != null)
                    hashCode = hashCode * 59 + this.UmStamp.GetHashCode();
                if (this.UrStamp != null)
                    hashCode = hashCode * 59 + this.UrStamp.GetHashCode();
                if (this.LlStamp != null)
                    hashCode = hashCode * 59 + this.LlStamp.GetHashCode();
                if (this.LmStamp != null)
                    hashCode = hashCode * 59 + this.LmStamp.GetHashCode();
                if (this.LrStamp != null)
                    hashCode = hashCode * 59 + this.LrStamp.GetHashCode();
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