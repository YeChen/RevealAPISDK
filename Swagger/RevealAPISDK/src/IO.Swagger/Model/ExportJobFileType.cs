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
    /// Defines ExportJobFileType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ExportJobFileType
    {
        
        /// <summary>
        /// Enum CSV for value: CSV
        /// </summary>
        [EnumMember(Value = "CSV")]
        CSV = 1,
        
        /// <summary>
        /// Enum TXT for value: TXT
        /// </summary>
        [EnumMember(Value = "TXT")]
        TXT = 2
    }

}
