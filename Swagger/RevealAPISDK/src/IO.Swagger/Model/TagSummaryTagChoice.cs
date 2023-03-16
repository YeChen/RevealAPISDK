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
    /// TagSummaryTagChoice
    /// </summary>
    [DataContract]
    public partial class TagSummaryTagChoice :  IEquatable<TagSummaryTagChoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagSummaryTagChoice" /> class.
        /// </summary>
        /// <param name="PredictionScore">PredictionScore.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        public TagSummaryTagChoice(int? PredictionScore = default(int?), int? Id = default(int?), string Name = default(string))
        {
            this.PredictionScore = PredictionScore;
            this.Id = Id;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets PredictionScore
        /// </summary>
        [DataMember(Name="predictionScore", EmitDefaultValue=false)]
        public int? PredictionScore { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagSummaryTagChoice {\n");
            sb.Append("  PredictionScore: ").Append(PredictionScore).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TagSummaryTagChoice);
        }

        /// <summary>
        /// Returns true if TagSummaryTagChoice instances are equal
        /// </summary>
        /// <param name="input">Instance of TagSummaryTagChoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagSummaryTagChoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PredictionScore == input.PredictionScore ||
                    (this.PredictionScore != null &&
                    this.PredictionScore.Equals(input.PredictionScore))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.PredictionScore != null)
                    hashCode = hashCode * 59 + this.PredictionScore.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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