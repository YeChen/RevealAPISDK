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
    /// ActionPermissions
    /// </summary>
    [DataContract]
    public partial class ActionPermissions :  IEquatable<ActionPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionPermissions" /> class.
        /// </summary>
        /// <param name="add">add.</param>
        /// <param name="reName">reName.</param>
        /// <param name="modifyWithACL">modifyWithACL.</param>
        /// <param name="delete">delete.</param>
        /// <param name="viewContents">viewContents.</param>
        /// <param name="lockDownContents">lockDownContents.</param>
        /// <param name="manageBatches">manageBatches.</param>
        /// <param name="manageBatchesAdmin">manageBatchesAdmin.</param>
        /// <param name="processTranscripts">processTranscripts.</param>
        public ActionPermissions(bool? add = default(bool?), bool? reName = default(bool?), bool? modifyWithACL = default(bool?), bool? delete = default(bool?), bool? viewContents = default(bool?), bool? lockDownContents = default(bool?), bool? manageBatches = default(bool?), bool? manageBatchesAdmin = default(bool?), bool? processTranscripts = default(bool?))
        {
            this.Add = add;
            this.ReName = reName;
            this.ModifyWithACL = modifyWithACL;
            this.Delete = delete;
            this.ViewContents = viewContents;
            this.LockDownContents = lockDownContents;
            this.ManageBatches = manageBatches;
            this.ManageBatchesAdmin = manageBatchesAdmin;
            this.ProcessTranscripts = processTranscripts;
        }
        
        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool? Add { get; set; }

        /// <summary>
        /// Gets or Sets ReName
        /// </summary>
        [DataMember(Name="reName", EmitDefaultValue=false)]
        public bool? ReName { get; set; }

        /// <summary>
        /// Gets or Sets ModifyWithACL
        /// </summary>
        [DataMember(Name="modifyWithACL", EmitDefaultValue=false)]
        public bool? ModifyWithACL { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Gets or Sets ViewContents
        /// </summary>
        [DataMember(Name="viewContents", EmitDefaultValue=false)]
        public bool? ViewContents { get; set; }

        /// <summary>
        /// Gets or Sets LockDownContents
        /// </summary>
        [DataMember(Name="lockDownContents", EmitDefaultValue=false)]
        public bool? LockDownContents { get; set; }

        /// <summary>
        /// Gets or Sets ManageBatches
        /// </summary>
        [DataMember(Name="manageBatches", EmitDefaultValue=false)]
        public bool? ManageBatches { get; set; }

        /// <summary>
        /// Gets or Sets ManageBatchesAdmin
        /// </summary>
        [DataMember(Name="manageBatchesAdmin", EmitDefaultValue=false)]
        public bool? ManageBatchesAdmin { get; set; }

        /// <summary>
        /// Gets or Sets ProcessTranscripts
        /// </summary>
        [DataMember(Name="processTranscripts", EmitDefaultValue=false)]
        public bool? ProcessTranscripts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionPermissions {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  ReName: ").Append(ReName).Append("\n");
            sb.Append("  ModifyWithACL: ").Append(ModifyWithACL).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  ViewContents: ").Append(ViewContents).Append("\n");
            sb.Append("  LockDownContents: ").Append(LockDownContents).Append("\n");
            sb.Append("  ManageBatches: ").Append(ManageBatches).Append("\n");
            sb.Append("  ManageBatchesAdmin: ").Append(ManageBatchesAdmin).Append("\n");
            sb.Append("  ProcessTranscripts: ").Append(ProcessTranscripts).Append("\n");
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
            return this.Equals(input as ActionPermissions);
        }

        /// <summary>
        /// Returns true if ActionPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Add == input.Add ||
                    (this.Add != null &&
                    this.Add.Equals(input.Add))
                ) && 
                (
                    this.ReName == input.ReName ||
                    (this.ReName != null &&
                    this.ReName.Equals(input.ReName))
                ) && 
                (
                    this.ModifyWithACL == input.ModifyWithACL ||
                    (this.ModifyWithACL != null &&
                    this.ModifyWithACL.Equals(input.ModifyWithACL))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
                ) && 
                (
                    this.ViewContents == input.ViewContents ||
                    (this.ViewContents != null &&
                    this.ViewContents.Equals(input.ViewContents))
                ) && 
                (
                    this.LockDownContents == input.LockDownContents ||
                    (this.LockDownContents != null &&
                    this.LockDownContents.Equals(input.LockDownContents))
                ) && 
                (
                    this.ManageBatches == input.ManageBatches ||
                    (this.ManageBatches != null &&
                    this.ManageBatches.Equals(input.ManageBatches))
                ) && 
                (
                    this.ManageBatchesAdmin == input.ManageBatchesAdmin ||
                    (this.ManageBatchesAdmin != null &&
                    this.ManageBatchesAdmin.Equals(input.ManageBatchesAdmin))
                ) && 
                (
                    this.ProcessTranscripts == input.ProcessTranscripts ||
                    (this.ProcessTranscripts != null &&
                    this.ProcessTranscripts.Equals(input.ProcessTranscripts))
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
                if (this.Add != null)
                    hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.ReName != null)
                    hashCode = hashCode * 59 + this.ReName.GetHashCode();
                if (this.ModifyWithACL != null)
                    hashCode = hashCode * 59 + this.ModifyWithACL.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.ViewContents != null)
                    hashCode = hashCode * 59 + this.ViewContents.GetHashCode();
                if (this.LockDownContents != null)
                    hashCode = hashCode * 59 + this.LockDownContents.GetHashCode();
                if (this.ManageBatches != null)
                    hashCode = hashCode * 59 + this.ManageBatches.GetHashCode();
                if (this.ManageBatchesAdmin != null)
                    hashCode = hashCode * 59 + this.ManageBatchesAdmin.GetHashCode();
                if (this.ProcessTranscripts != null)
                    hashCode = hashCode * 59 + this.ProcessTranscripts.GetHashCode();
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