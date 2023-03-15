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
    /// Defines BulkTagUpdateOption
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BulkTagUpdateOption
    {
        
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,
        
        /// <summary>
        /// Enum Tag for value: Tag
        /// </summary>
        [EnumMember(Value = "Tag")]
        Tag = 2,
        
        /// <summary>
        /// Enum UnTag for value: UnTag
        /// </summary>
        [EnumMember(Value = "UnTag")]
        UnTag = 3
    }

}
