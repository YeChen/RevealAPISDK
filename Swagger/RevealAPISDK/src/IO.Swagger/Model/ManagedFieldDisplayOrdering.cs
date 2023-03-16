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
    /// ManagedFieldDisplayOrdering
    /// </summary>
    [DataContract]
    public partial class ManagedFieldDisplayOrdering :  IEquatable<ManagedFieldDisplayOrdering>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedFieldDisplayOrdering" /> class.
        /// </summary>
        /// <param name="IsVisible">IsVisible.</param>
        /// <param name="ManagedFieldId">ManagedFieldId.</param>
        /// <param name="Order">Order.</param>
        public ManagedFieldDisplayOrdering(bool? IsVisible = default(bool?), long? ManagedFieldId = default(long?), int? Order = default(int?))
        {
            this.IsVisible = IsVisible;
            this.ManagedFieldId = ManagedFieldId;
            this.Order = Order;
        }
        
        /// <summary>
        /// Gets or Sets IsVisible
        /// </summary>
        [DataMember(Name="isVisible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or Sets ManagedFieldId
        /// </summary>
        [DataMember(Name="managedFieldId", EmitDefaultValue=false)]
        public long? ManagedFieldId { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedFieldDisplayOrdering {\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  ManagedFieldId: ").Append(ManagedFieldId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as ManagedFieldDisplayOrdering);
        }

        /// <summary>
        /// Returns true if ManagedFieldDisplayOrdering instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagedFieldDisplayOrdering to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagedFieldDisplayOrdering input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.ManagedFieldId == input.ManagedFieldId ||
                    (this.ManagedFieldId != null &&
                    this.ManagedFieldId.Equals(input.ManagedFieldId))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.ManagedFieldId != null)
                    hashCode = hashCode * 59 + this.ManagedFieldId.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
