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
    /// Defines PrintPDFFormat
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PrintPDFFormat
    {
        
        /// <summary>
        /// Enum Single for value: Single
        /// </summary>
        [EnumMember(Value = "Single")]
        Single = 1,
        
        /// <summary>
        /// Enum Multiple for value: Multiple
        /// </summary>
        [EnumMember(Value = "Multiple")]
        Multiple = 2,
        
        /// <summary>
        /// Enum Family for value: Family
        /// </summary>
        [EnumMember(Value = "Family")]
        Family = 3
    }

}