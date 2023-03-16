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
    /// SearchCriteria
    /// </summary>
    [DataContract]
    public partial class SearchCriteria :  IEquatable<SearchCriteria>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets QueryType
        /// </summary>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public SearchQueryType? QueryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteria" /> class.
        /// </summary>
        /// <param name="GetDocumentBodyTerms">Retrieve document body terms.</param>
        /// <param name="DocumentCriteria">DocumentCriteria.</param>
        /// <param name="AggregationCriteria">AggregationCriteria.</param>
        /// <param name="DocumentFieldFillRateCriteria">DocumentFieldFillRateCriteria.</param>
        /// <param name="DateHistogramCriteria">DateHistogramCriteria.</param>
        /// <param name="NumberHistogramCriteria">NumberHistogramCriteria.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="CaseId">CaseId.</param>
        /// <param name="QueryString">QueryString.</param>
        /// <param name="QueryType">QueryType.</param>
        /// <param name="SortByString">SortByString.</param>
        /// <param name="IgnoreDocumentSecurity">IgnoreDocumentSecurity.</param>
        /// <param name="SearchProfileIds">SearchProfileIds.</param>
        public SearchCriteria(bool? GetDocumentBodyTerms = default(bool?), DocumentCriteria DocumentCriteria = default(DocumentCriteria), List<AggregationCriteria> AggregationCriteria = default(List<AggregationCriteria>), List<DocumentFieldsFillRateCriteria> DocumentFieldFillRateCriteria = default(List<DocumentFieldsFillRateCriteria>), List<DateHistogramCriteria> DateHistogramCriteria = default(List<DateHistogramCriteria>), List<NumberHistogramCriteria> NumberHistogramCriteria = default(List<NumberHistogramCriteria>), int? UserId = default(int?), int? CaseId = default(int?), string QueryString = default(string), SearchQueryType? QueryType = default(SearchQueryType?), string SortByString = default(string), bool? IgnoreDocumentSecurity = default(bool?), List<int?> SearchProfileIds = default(List<int?>))
        {
            this.GetDocumentBodyTerms = GetDocumentBodyTerms;
            this.DocumentCriteria = DocumentCriteria;
            this.AggregationCriteria = AggregationCriteria;
            this.DocumentFieldFillRateCriteria = DocumentFieldFillRateCriteria;
            this.DateHistogramCriteria = DateHistogramCriteria;
            this.NumberHistogramCriteria = NumberHistogramCriteria;
            this.UserId = UserId;
            this.CaseId = CaseId;
            this.QueryString = QueryString;
            this.QueryType = QueryType;
            this.SortByString = SortByString;
            this.IgnoreDocumentSecurity = IgnoreDocumentSecurity;
            this.SearchProfileIds = SearchProfileIds;
        }
        
        /// <summary>
        /// Retrieve document body terms
        /// </summary>
        /// <value>Retrieve document body terms</value>
        [DataMember(Name="getDocumentBodyTerms", EmitDefaultValue=false)]
        public bool? GetDocumentBodyTerms { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCriteria
        /// </summary>
        [DataMember(Name="documentCriteria", EmitDefaultValue=false)]
        public DocumentCriteria DocumentCriteria { get; set; }

        /// <summary>
        /// Gets or Sets AggregationCriteria
        /// </summary>
        [DataMember(Name="aggregationCriteria", EmitDefaultValue=false)]
        public List<AggregationCriteria> AggregationCriteria { get; set; }

        /// <summary>
        /// Gets or Sets DocumentFieldFillRateCriteria
        /// </summary>
        [DataMember(Name="documentFieldFillRateCriteria", EmitDefaultValue=false)]
        public List<DocumentFieldsFillRateCriteria> DocumentFieldFillRateCriteria { get; set; }

        /// <summary>
        /// Gets or Sets DateHistogramCriteria
        /// </summary>
        [DataMember(Name="dateHistogramCriteria", EmitDefaultValue=false)]
        public List<DateHistogramCriteria> DateHistogramCriteria { get; set; }

        /// <summary>
        /// Gets or Sets NumberHistogramCriteria
        /// </summary>
        [DataMember(Name="numberHistogramCriteria", EmitDefaultValue=false)]
        public List<NumberHistogramCriteria> NumberHistogramCriteria { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets CaseId
        /// </summary>
        [DataMember(Name="caseId", EmitDefaultValue=false)]
        public int? CaseId { get; set; }

        /// <summary>
        /// Gets or Sets QueryString
        /// </summary>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }


        /// <summary>
        /// Gets or Sets SortByString
        /// </summary>
        [DataMember(Name="sortByString", EmitDefaultValue=false)]
        public string SortByString { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreDocumentSecurity
        /// </summary>
        [DataMember(Name="ignoreDocumentSecurity", EmitDefaultValue=false)]
        public bool? IgnoreDocumentSecurity { get; set; }

        /// <summary>
        /// Gets or Sets SearchProfileIds
        /// </summary>
        [DataMember(Name="searchProfileIds", EmitDefaultValue=false)]
        public List<int?> SearchProfileIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchCriteria {\n");
            sb.Append("  GetDocumentBodyTerms: ").Append(GetDocumentBodyTerms).Append("\n");
            sb.Append("  DocumentCriteria: ").Append(DocumentCriteria).Append("\n");
            sb.Append("  AggregationCriteria: ").Append(AggregationCriteria).Append("\n");
            sb.Append("  DocumentFieldFillRateCriteria: ").Append(DocumentFieldFillRateCriteria).Append("\n");
            sb.Append("  DateHistogramCriteria: ").Append(DateHistogramCriteria).Append("\n");
            sb.Append("  NumberHistogramCriteria: ").Append(NumberHistogramCriteria).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  SortByString: ").Append(SortByString).Append("\n");
            sb.Append("  IgnoreDocumentSecurity: ").Append(IgnoreDocumentSecurity).Append("\n");
            sb.Append("  SearchProfileIds: ").Append(SearchProfileIds).Append("\n");
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
            return this.Equals(input as SearchCriteria);
        }

        /// <summary>
        /// Returns true if SearchCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchCriteria input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GetDocumentBodyTerms == input.GetDocumentBodyTerms ||
                    (this.GetDocumentBodyTerms != null &&
                    this.GetDocumentBodyTerms.Equals(input.GetDocumentBodyTerms))
                ) && 
                (
                    this.DocumentCriteria == input.DocumentCriteria ||
                    (this.DocumentCriteria != null &&
                    this.DocumentCriteria.Equals(input.DocumentCriteria))
                ) && 
                (
                    this.AggregationCriteria == input.AggregationCriteria ||
                    this.AggregationCriteria != null &&
                    this.AggregationCriteria.SequenceEqual(input.AggregationCriteria)
                ) && 
                (
                    this.DocumentFieldFillRateCriteria == input.DocumentFieldFillRateCriteria ||
                    this.DocumentFieldFillRateCriteria != null &&
                    this.DocumentFieldFillRateCriteria.SequenceEqual(input.DocumentFieldFillRateCriteria)
                ) && 
                (
                    this.DateHistogramCriteria == input.DateHistogramCriteria ||
                    this.DateHistogramCriteria != null &&
                    this.DateHistogramCriteria.SequenceEqual(input.DateHistogramCriteria)
                ) && 
                (
                    this.NumberHistogramCriteria == input.NumberHistogramCriteria ||
                    this.NumberHistogramCriteria != null &&
                    this.NumberHistogramCriteria.SequenceEqual(input.NumberHistogramCriteria)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.CaseId == input.CaseId ||
                    (this.CaseId != null &&
                    this.CaseId.Equals(input.CaseId))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
                ) && 
                (
                    this.SortByString == input.SortByString ||
                    (this.SortByString != null &&
                    this.SortByString.Equals(input.SortByString))
                ) && 
                (
                    this.IgnoreDocumentSecurity == input.IgnoreDocumentSecurity ||
                    (this.IgnoreDocumentSecurity != null &&
                    this.IgnoreDocumentSecurity.Equals(input.IgnoreDocumentSecurity))
                ) && 
                (
                    this.SearchProfileIds == input.SearchProfileIds ||
                    this.SearchProfileIds != null &&
                    this.SearchProfileIds.SequenceEqual(input.SearchProfileIds)
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
                if (this.GetDocumentBodyTerms != null)
                    hashCode = hashCode * 59 + this.GetDocumentBodyTerms.GetHashCode();
                if (this.DocumentCriteria != null)
                    hashCode = hashCode * 59 + this.DocumentCriteria.GetHashCode();
                if (this.AggregationCriteria != null)
                    hashCode = hashCode * 59 + this.AggregationCriteria.GetHashCode();
                if (this.DocumentFieldFillRateCriteria != null)
                    hashCode = hashCode * 59 + this.DocumentFieldFillRateCriteria.GetHashCode();
                if (this.DateHistogramCriteria != null)
                    hashCode = hashCode * 59 + this.DateHistogramCriteria.GetHashCode();
                if (this.NumberHistogramCriteria != null)
                    hashCode = hashCode * 59 + this.NumberHistogramCriteria.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CaseId != null)
                    hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.QueryType != null)
                    hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.SortByString != null)
                    hashCode = hashCode * 59 + this.SortByString.GetHashCode();
                if (this.IgnoreDocumentSecurity != null)
                    hashCode = hashCode * 59 + this.IgnoreDocumentSecurity.GetHashCode();
                if (this.SearchProfileIds != null)
                    hashCode = hashCode * 59 + this.SearchProfileIds.GetHashCode();
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