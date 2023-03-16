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
    /// Defines MetadataFieldFilterOperator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MetadataFieldFilterOperator
    {
        
        /// <summary>
        /// Enum EQUALTO for value: EQUAL_TO
        /// </summary>
        [EnumMember(Value = "EQUAL_TO")]
        EQUALTO = 1,
        
        /// <summary>
        /// Enum NOTEQUALTO for value: NOT_EQUAL_TO
        /// </summary>
        [EnumMember(Value = "NOT_EQUAL_TO")]
        NOTEQUALTO = 2,
        
        /// <summary>
        /// Enum GREATERTHAN for value: GREATER_THAN
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GREATERTHAN = 3,
        
        /// <summary>
        /// Enum GREATERTHANOREQUALTO for value: GREATER_THAN_OR_EQUAL_TO
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_OR_EQUAL_TO")]
        GREATERTHANOREQUALTO = 4,
        
        /// <summary>
        /// Enum LESSTHAN for value: LESS_THAN
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LESSTHAN = 5,
        
        /// <summary>
        /// Enum LESSTHANOREQUALTO for value: LESS_THAN_OR_EQUAL_TO
        /// </summary>
        [EnumMember(Value = "LESS_THAN_OR_EQUAL_TO")]
        LESSTHANOREQUALTO = 6,
        
        /// <summary>
        /// Enum CONTAINS for value: CONTAINS
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS = 7,
        
        /// <summary>
        /// Enum DOESNOTCONTAIN for value: DOES_NOT_CONTAIN
        /// </summary>
        [EnumMember(Value = "DOES_NOT_CONTAIN")]
        DOESNOTCONTAIN = 8,
        
        /// <summary>
        /// Enum RANGE for value: RANGE
        /// </summary>
        [EnumMember(Value = "RANGE")]
        RANGE = 9,
        
        /// <summary>
        /// Enum ISEMPTY for value: IS_EMPTY
        /// </summary>
        [EnumMember(Value = "IS_EMPTY")]
        ISEMPTY = 10,
        
        /// <summary>
        /// Enum ISNOTEMPTY for value: IS_NOT_EMPTY
        /// </summary>
        [EnumMember(Value = "IS_NOT_EMPTY")]
        ISNOTEMPTY = 11,
        
        /// <summary>
        /// Enum ISLIKE for value: IS_LIKE
        /// </summary>
        [EnumMember(Value = "IS_LIKE")]
        ISLIKE = 12,
        
        /// <summary>
        /// Enum ISNOTLIKE for value: IS_NOT_LIKE
        /// </summary>
        [EnumMember(Value = "IS_NOT_LIKE")]
        ISNOTLIKE = 13,
        
        /// <summary>
        /// Enum HASANY for value: HAS_ANY
        /// </summary>
        [EnumMember(Value = "HAS_ANY")]
        HASANY = 14,
        
        /// <summary>
        /// Enum HASALL for value: HAS_ALL
        /// </summary>
        [EnumMember(Value = "HAS_ALL")]
        HASALL = 15,
        
        /// <summary>
        /// Enum HASNONE for value: HAS_NONE
        /// </summary>
        [EnumMember(Value = "HAS_NONE")]
        HASNONE = 16,
        
        /// <summary>
        /// Enum NOTALL for value: NOT_ALL
        /// </summary>
        [EnumMember(Value = "NOT_ALL")]
        NOTALL = 17,
        
        /// <summary>
        /// Enum HASONLY for value: HAS_ONLY
        /// </summary>
        [EnumMember(Value = "HAS_ONLY")]
        HASONLY = 18,
        
        /// <summary>
        /// Enum STARTSWITH for value: STARTS_WITH
        /// </summary>
        [EnumMember(Value = "STARTS_WITH")]
        STARTSWITH = 19,
        
        /// <summary>
        /// Enum DOESNOTSTARTWITH for value: DOES_NOT_START_WITH
        /// </summary>
        [EnumMember(Value = "DOES_NOT_START_WITH")]
        DOESNOTSTARTWITH = 20,
        
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 21
    }

}
