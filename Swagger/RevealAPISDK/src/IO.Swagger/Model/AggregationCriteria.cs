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
    /// AggregationCriteria
    /// </summary>
    [DataContract]
    public partial class AggregationCriteria :  IEquatable<AggregationCriteria>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationCriteria" /> class.
        /// </summary>
        /// <param name="FieldName">Fields to get back.</param>
        /// <param name="ComponentKey">Unique identifier for this aggregation.</param>
        /// <param name="ExcludedFieldValues">Field values to exclude.</param>
        /// <param name="IncludedFieldValues">Field values to include.</param>
        /// <param name="IncludePrefixes">filter all aggregations  by values.</param>
        /// <param name="SortByValue">true: sort by the field value,   false: sort by the count.</param>
        /// <param name="SortAscending">true for ascending sort.</param>
        /// <param name="Start">The amount of results to skip.</param>
        /// <param name="Count">The amount of results to retrieve.</param>
        public AggregationCriteria(string FieldName = default(string), string ComponentKey = default(string), List<string> ExcludedFieldValues = default(List<string>), List<string> IncludedFieldValues = default(List<string>), List<string> IncludePrefixes = default(List<string>), bool? SortByValue = default(bool?), bool? SortAscending = default(bool?), int? Start = default(int?), int? Count = default(int?))
        {
            this.FieldName = FieldName;
            this.ComponentKey = ComponentKey;
            this.ExcludedFieldValues = ExcludedFieldValues;
            this.IncludedFieldValues = IncludedFieldValues;
            this.IncludePrefixes = IncludePrefixes;
            this.SortByValue = SortByValue;
            this.SortAscending = SortAscending;
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
        /// Unique identifier for this aggregation
        /// </summary>
        /// <value>Unique identifier for this aggregation</value>
        [DataMember(Name="componentKey", EmitDefaultValue=false)]
        public string ComponentKey { get; set; }

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
        /// filter all aggregations  by values
        /// </summary>
        /// <value>filter all aggregations  by values</value>
        [DataMember(Name="includePrefixes", EmitDefaultValue=false)]
        public List<string> IncludePrefixes { get; set; }

        /// <summary>
        /// true: sort by the field value,   false: sort by the count
        /// </summary>
        /// <value>true: sort by the field value,   false: sort by the count</value>
        [DataMember(Name="sortByValue", EmitDefaultValue=false)]
        public bool? SortByValue { get; set; }

        /// <summary>
        /// true for ascending sort
        /// </summary>
        /// <value>true for ascending sort</value>
        [DataMember(Name="sortAscending", EmitDefaultValue=false)]
        public bool? SortAscending { get; set; }

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
            sb.Append("class AggregationCriteria {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ComponentKey: ").Append(ComponentKey).Append("\n");
            sb.Append("  ExcludedFieldValues: ").Append(ExcludedFieldValues).Append("\n");
            sb.Append("  IncludedFieldValues: ").Append(IncludedFieldValues).Append("\n");
            sb.Append("  IncludePrefixes: ").Append(IncludePrefixes).Append("\n");
            sb.Append("  SortByValue: ").Append(SortByValue).Append("\n");
            sb.Append("  SortAscending: ").Append(SortAscending).Append("\n");
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
            return this.Equals(input as AggregationCriteria);
        }

        /// <summary>
        /// Returns true if AggregationCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationCriteria input)
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
                    this.ComponentKey == input.ComponentKey ||
                    (this.ComponentKey != null &&
                    this.ComponentKey.Equals(input.ComponentKey))
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
                ) && 
                (
                    this.IncludePrefixes == input.IncludePrefixes ||
                    this.IncludePrefixes != null &&
                    this.IncludePrefixes.SequenceEqual(input.IncludePrefixes)
                ) && 
                (
                    this.SortByValue == input.SortByValue ||
                    (this.SortByValue != null &&
                    this.SortByValue.Equals(input.SortByValue))
                ) && 
                (
                    this.SortAscending == input.SortAscending ||
                    (this.SortAscending != null &&
                    this.SortAscending.Equals(input.SortAscending))
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
                if (this.ComponentKey != null)
                    hashCode = hashCode * 59 + this.ComponentKey.GetHashCode();
                if (this.ExcludedFieldValues != null)
                    hashCode = hashCode * 59 + this.ExcludedFieldValues.GetHashCode();
                if (this.IncludedFieldValues != null)
                    hashCode = hashCode * 59 + this.IncludedFieldValues.GetHashCode();
                if (this.IncludePrefixes != null)
                    hashCode = hashCode * 59 + this.IncludePrefixes.GetHashCode();
                if (this.SortByValue != null)
                    hashCode = hashCode * 59 + this.SortByValue.GetHashCode();
                if (this.SortAscending != null)
                    hashCode = hashCode * 59 + this.SortAscending.GetHashCode();
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
