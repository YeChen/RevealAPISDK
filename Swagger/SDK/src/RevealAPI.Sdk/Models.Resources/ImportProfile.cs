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
    /// ImportProfile
    /// </summary>
    [DataContract]
    public partial class ImportProfile :  IEquatable<ImportProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProfile" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="textQuote">textQuote.</param>
        /// <param name="textDelimeter">textDelimeter.</param>
        /// <param name="multiFieldDelimiter">multiFieldDelimiter.</param>
        /// <param name="hierarchyDelimiter">hierarchyDelimiter.</param>
        /// <param name="blankDateStrings">blankDateStrings.</param>
        /// <param name="allowEmptyTextQuote">allowEmptyTextQuote (required).</param>
        public ImportProfile(int? id = default(int?), string name = default(string), string textQuote = default(string), string textDelimeter = default(string), string multiFieldDelimiter = default(string), string hierarchyDelimiter = default(string), string blankDateStrings = default(string), string allowEmptyTextQuote = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ImportProfile and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "allowEmptyTextQuote" is required (not null)
            if (allowEmptyTextQuote == null)
            {
                throw new InvalidDataException("allowEmptyTextQuote is a required property for ImportProfile and cannot be null");
            }
            else
            {
                this.AllowEmptyTextQuote = allowEmptyTextQuote;
            }
            this.Id = id;
            this.TextQuote = textQuote;
            this.TextDelimeter = textDelimeter;
            this.MultiFieldDelimiter = multiFieldDelimiter;
            this.HierarchyDelimiter = hierarchyDelimiter;
            this.BlankDateStrings = blankDateStrings;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TextQuote
        /// </summary>
        [DataMember(Name="textQuote", EmitDefaultValue=false)]
        public string TextQuote { get; set; }

        /// <summary>
        /// Gets or Sets TextDelimeter
        /// </summary>
        [DataMember(Name="textDelimeter", EmitDefaultValue=false)]
        public string TextDelimeter { get; set; }

        /// <summary>
        /// Gets or Sets MultiFieldDelimiter
        /// </summary>
        [DataMember(Name="multiFieldDelimiter", EmitDefaultValue=false)]
        public string MultiFieldDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets HierarchyDelimiter
        /// </summary>
        [DataMember(Name="hierarchyDelimiter", EmitDefaultValue=false)]
        public string HierarchyDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets BlankDateStrings
        /// </summary>
        [DataMember(Name="blankDateStrings", EmitDefaultValue=false)]
        public string BlankDateStrings { get; set; }

        /// <summary>
        /// Gets or Sets AllowEmptyTextQuote
        /// </summary>
        [DataMember(Name="allowEmptyTextQuote", EmitDefaultValue=false)]
        public string AllowEmptyTextQuote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TextQuote: ").Append(TextQuote).Append("\n");
            sb.Append("  TextDelimeter: ").Append(TextDelimeter).Append("\n");
            sb.Append("  MultiFieldDelimiter: ").Append(MultiFieldDelimiter).Append("\n");
            sb.Append("  HierarchyDelimiter: ").Append(HierarchyDelimiter).Append("\n");
            sb.Append("  BlankDateStrings: ").Append(BlankDateStrings).Append("\n");
            sb.Append("  AllowEmptyTextQuote: ").Append(AllowEmptyTextQuote).Append("\n");
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
            return this.Equals(input as ImportProfile);
        }

        /// <summary>
        /// Returns true if ImportProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TextQuote == input.TextQuote ||
                    (this.TextQuote != null &&
                    this.TextQuote.Equals(input.TextQuote))
                ) && 
                (
                    this.TextDelimeter == input.TextDelimeter ||
                    (this.TextDelimeter != null &&
                    this.TextDelimeter.Equals(input.TextDelimeter))
                ) && 
                (
                    this.MultiFieldDelimiter == input.MultiFieldDelimiter ||
                    (this.MultiFieldDelimiter != null &&
                    this.MultiFieldDelimiter.Equals(input.MultiFieldDelimiter))
                ) && 
                (
                    this.HierarchyDelimiter == input.HierarchyDelimiter ||
                    (this.HierarchyDelimiter != null &&
                    this.HierarchyDelimiter.Equals(input.HierarchyDelimiter))
                ) && 
                (
                    this.BlankDateStrings == input.BlankDateStrings ||
                    (this.BlankDateStrings != null &&
                    this.BlankDateStrings.Equals(input.BlankDateStrings))
                ) && 
                (
                    this.AllowEmptyTextQuote == input.AllowEmptyTextQuote ||
                    (this.AllowEmptyTextQuote != null &&
                    this.AllowEmptyTextQuote.Equals(input.AllowEmptyTextQuote))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TextQuote != null)
                    hashCode = hashCode * 59 + this.TextQuote.GetHashCode();
                if (this.TextDelimeter != null)
                    hashCode = hashCode * 59 + this.TextDelimeter.GetHashCode();
                if (this.MultiFieldDelimiter != null)
                    hashCode = hashCode * 59 + this.MultiFieldDelimiter.GetHashCode();
                if (this.HierarchyDelimiter != null)
                    hashCode = hashCode * 59 + this.HierarchyDelimiter.GetHashCode();
                if (this.BlankDateStrings != null)
                    hashCode = hashCode * 59 + this.BlankDateStrings.GetHashCode();
                if (this.AllowEmptyTextQuote != null)
                    hashCode = hashCode * 59 + this.AllowEmptyTextQuote.GetHashCode();
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