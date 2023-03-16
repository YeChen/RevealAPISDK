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
    /// Defines DeletionStatus
    /// </summary>
    
    public enum DeletionStatus
    {
        
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        
        None = None,
        
        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        
        Pending = Pending,
        
        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        
        InProgress = InProgress,
        
        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        
        Complete = Complete
    }

}
