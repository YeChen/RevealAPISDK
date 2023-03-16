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
    /// Defines AssignmentBatchControlStatusType
    /// </summary>
    
    public enum AssignmentBatchControlStatusType
    {
        
        /// <summary>
        /// Enum Assigned for value: Assigned
        /// </summary>
        
        Assigned,
        
        /// <summary>
        /// Enum Available for value: Available
        /// </summary>
        
        Available,
        
        /// <summary>
        /// Enum CheckedOut for value: CheckedOut
        /// </summary>
        
        CheckedOut,
        
        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        
        Complete
    }

}
