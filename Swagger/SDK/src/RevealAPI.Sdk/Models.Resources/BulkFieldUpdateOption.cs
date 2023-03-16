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
    /// Defines BulkFieldUpdateOption
    /// </summary>
    
    public enum BulkFieldUpdateOption
    {
        
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        
        None ,
        
        /// <summary>
        /// Enum Replace for value: Replace
        /// </summary>
        
        Replace,
        
        /// <summary>
        /// Enum Append for value: Append
        /// </summary>
        
        Append ,
        
        /// <summary>
        /// Enum Prepend for value: Prepend
        /// </summary>
        
        Prepend ,
        
        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        
        Delete ,
        
        /// <summary>
        /// Enum KeepExisting for value: KeepExisting
        /// </summary>
        
        KeepExisting 
    }

}
