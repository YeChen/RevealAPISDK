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
    /// Defines JobSubmitStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobSubmitStatus
    {
        
        /// <summary>
        /// Enum Ok for value: Ok
        /// </summary>
        [EnumMember(Value = "Ok")]
        Ok = 1,
        
        /// <summary>
        /// Enum CaseOrJobNotFound for value: CaseOrJobNotFound
        /// </summary>
        [EnumMember(Value = "CaseOrJobNotFound")]
        CaseOrJobNotFound = 2,
        
        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 3,
        
        /// <summary>
        /// Enum AlreadyAtMaxNumJobs for value: AlreadyAtMaxNumJobs
        /// </summary>
        [EnumMember(Value = "AlreadyAtMaxNumJobs")]
        AlreadyAtMaxNumJobs = 4,
        
        /// <summary>
        /// Enum ShutdownInProgress for value: ShutdownInProgress
        /// </summary>
        [EnumMember(Value = "ShutdownInProgress")]
        ShutdownInProgress = 5
    }

}
