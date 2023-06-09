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
    /// DateHistogramSearchCriteria
    /// </summary>
    [DataContract]
    public partial class DateHistogramSearchCriteria :  IEquatable<DateHistogramSearchCriteria>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TimeInterval
        /// </summary>
        [DataMember(Name="timeInterval", EmitDefaultValue=false)]
        public DateHistogramTimeInterval? TimeInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DateHistogramSearchCriteria" /> class.
        /// </summary>
        /// <param name="start">The amount of results to skip.</param>
        /// <param name="count">The amount of results to retrieve.</param>
        /// <param name="fieldNames">Fields to get back.</param>
        /// <param name="timeInterval">timeInterval.</param>
        /// <param name="query">query.</param>
        /// <param name="sortByString">Sort query.</param>
        public DateHistogramSearchCriteria(int? start = default(int?), int? count = default(int?), List<string> fieldNames = default(List<string>), DateHistogramTimeInterval? timeInterval = default(DateHistogramTimeInterval?), ISearchClause query = default(ISearchClause), string sortByString = default(string))
        {
            this.Start = start;
            this.Count = count;
            this.FieldNames = fieldNames;
            this.TimeInterval = timeInterval;
            this.Query = query;
            this.SortByString = sortByString;
        }
        
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
        /// Fields to get back
        /// </summary>
        /// <value>Fields to get back</value>
        [DataMember(Name="fieldNames", EmitDefaultValue=false)]
        public List<string> FieldNames { get; set; }


        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public ISearchClause Query { get; set; }

        /// <summary>
        /// Sort query
        /// </summary>
        /// <value>Sort query</value>
        [DataMember(Name="sortByString", EmitDefaultValue=false)]
        public string SortByString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateHistogramSearchCriteria {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FieldNames: ").Append(FieldNames).Append("\n");
            sb.Append("  TimeInterval: ").Append(TimeInterval).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  SortByString: ").Append(SortByString).Append("\n");
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
            return this.Equals(input as DateHistogramSearchCriteria);
        }

        /// <summary>
        /// Returns true if DateHistogramSearchCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of DateHistogramSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateHistogramSearchCriteria input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.FieldNames == input.FieldNames ||
                    this.FieldNames != null &&
                    this.FieldNames.SequenceEqual(input.FieldNames)
                ) && 
                (
                    this.TimeInterval == input.TimeInterval ||
                    (this.TimeInterval != null &&
                    this.TimeInterval.Equals(input.TimeInterval))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.SortByString == input.SortByString ||
                    (this.SortByString != null &&
                    this.SortByString.Equals(input.SortByString))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.FieldNames != null)
                    hashCode = hashCode * 59 + this.FieldNames.GetHashCode();
                if (this.TimeInterval != null)
                    hashCode = hashCode * 59 + this.TimeInterval.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.SortByString != null)
                    hashCode = hashCode * 59 + this.SortByString.GetHashCode();
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
