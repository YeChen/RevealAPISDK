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
    /// Defines TranscriptJobType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TranscriptJobType
    {
        
        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All = 1,
        
        /// <summary>
        /// Enum NewOnly for value: NewOnly
        /// </summary>
        [EnumMember(Value = "NewOnly")]
        NewOnly = 2,
        
        /// <summary>
        /// Enum NewAndErrors for value: NewAndErrors
        /// </summary>
        [EnumMember(Value = "NewAndErrors")]
        NewAndErrors = 3
    }

}