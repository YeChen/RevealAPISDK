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
    /// Defines UploadJobWorkFlow
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UploadJobWorkFlow
    {
        
        /// <summary>
        /// Enum Review for value: Review
        /// </summary>
        [EnumMember(Value = "Review")]
        Review = 1,
        
        /// <summary>
        /// Enum Eca for value: Eca
        /// </summary>
        [EnumMember(Value = "Eca")]
        Eca = 2
    }

}