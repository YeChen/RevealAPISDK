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
    /// DocumentQueryResults2
    /// </summary>
    [DataContract]
    public partial class DocumentQueryResults2 :  IEquatable<DocumentQueryResults2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentQueryResults2" /> class.
        /// </summary>
        /// <param name="TracingId">TracingId.</param>
        /// <param name="Documents">Documents.</param>
        /// <param name="TotalDocuments">TotalDocuments.</param>
        public DocumentQueryResults2(string TracingId = default(string), List<DocumentMetadataInformation> Documents = default(List<DocumentMetadataInformation>), long? TotalDocuments = default(long?))
        {
            this.TracingId = TracingId;
            this.Documents = Documents;
            this.TotalDocuments = TotalDocuments;
        }
        
        /// <summary>
        /// Gets or Sets TracingId
        /// </summary>
        [DataMember(Name="tracingId", EmitDefaultValue=false)]
        public string TracingId { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<DocumentMetadataInformation> Documents { get; set; }

        /// <summary>
        /// Gets or Sets TotalDocuments
        /// </summary>
        [DataMember(Name="totalDocuments", EmitDefaultValue=false)]
        public long? TotalDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQueryResults2 {\n");
            sb.Append("  TracingId: ").Append(TracingId).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  TotalDocuments: ").Append(TotalDocuments).Append("\n");
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
            return this.Equals(input as DocumentQueryResults2);
        }

        /// <summary>
        /// Returns true if DocumentQueryResults2 instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentQueryResults2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentQueryResults2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TracingId == input.TracingId ||
                    (this.TracingId != null &&
                    this.TracingId.Equals(input.TracingId))
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.TotalDocuments == input.TotalDocuments ||
                    (this.TotalDocuments != null &&
                    this.TotalDocuments.Equals(input.TotalDocuments))
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
                if (this.TracingId != null)
                    hashCode = hashCode * 59 + this.TracingId.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.TotalDocuments != null)
                    hashCode = hashCode * 59 + this.TotalDocuments.GetHashCode();
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
