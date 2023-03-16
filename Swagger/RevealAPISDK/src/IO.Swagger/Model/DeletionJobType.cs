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
    /// Defines DeletionJobType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DeletionJobType
    {
        
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,
        
        /// <summary>
        /// Enum Print for value: Print
        /// </summary>
        [EnumMember(Value = "Print")]
        Print = 2,
        
        /// <summary>
        /// Enum Production for value: Production
        /// </summary>
        [EnumMember(Value = "Production")]
        Production = 3,
        
        /// <summary>
        /// Enum ProductionExport for value: ProductionExport
        /// </summary>
        [EnumMember(Value = "ProductionExport")]
        ProductionExport = 4,
        
        /// <summary>
        /// Enum Export for value: Export
        /// </summary>
        [EnumMember(Value = "Export")]
        Export = 5,
        
        /// <summary>
        /// Enum DocumentDeletion for value: DocumentDeletion
        /// </summary>
        [EnumMember(Value = "DocumentDeletion")]
        DocumentDeletion = 6,
        
        /// <summary>
        /// Enum CaseArchive for value: CaseArchive
        /// </summary>
        [EnumMember(Value = "CaseArchive")]
        CaseArchive = 7,
        
        /// <summary>
        /// Enum Project for value: Project
        /// </summary>
        [EnumMember(Value = "Project")]
        Project = 8
    }

}