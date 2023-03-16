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
    /// DateHistogramCriteria
    /// </summary>
    [DataContract]
    public partial class DateHistogramCriteria :  IEquatable<DateHistogramCriteria>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TimeInterval
        /// </summary>
        [DataMember(Name="timeInterval", EmitDefaultValue=false)]
        public DateHistogramTimeInterval? TimeInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DateHistogramCriteria" /> class.
        /// </summary>
        /// <param name="FieldName">Fields to get back.</param>
        /// <param name="TimeInterval">TimeInterval.</param>
        /// <param name="Start">The amount of results to skip.</param>
        /// <param name="Count">The amount of results to retrieve.</param>
        public DateHistogramCriteria(string FieldName = default(string), DateHistogramTimeInterval? TimeInterval = default(DateHistogramTimeInterval?), int? Start = default(int?), int? Count = default(int?))
        {
            this.FieldName = FieldName;
            this.TimeInterval = TimeInterval;
            this.Start = Start;
            this.Count = Count;
        }
        
        /// <summary>
        /// Fields to get back
        /// </summary>
        /// <value>Fields to get back</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }


        /// <summary>
        /// The amount of results to skip
        /// </summary>
        /// <value>The amount of results to skip</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int? Start { get; set; }

        /// <summary>
        /// The amount of results to retrieve
        /// </summary>
        /// <value>The amount of results to retrieve</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateHistogramCriteria {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as DateHistogramCriteria);
        }

        /// <summary>
        /// Returns true if DateHistogramCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of DateHistogramCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateHistogramCriteria input)
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
                    this.TimeInterval == input.TimeInterval ||
                    (this.TimeInterval != null &&
                    this.TimeInterval.Equals(input.TimeInterval))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.TimeInterval != null)
                    hashCode = hashCode * 59 + this.TimeInterval.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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
