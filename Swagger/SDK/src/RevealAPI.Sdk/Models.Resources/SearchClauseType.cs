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
    /// Defines SearchClauseType
    /// </summary>
    
    public enum SearchClauseType
    {
        
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        
        none ,
        
        /// <summary>
        /// Enum Tag for value: tag
        /// </summary>
        
        tag ,
        
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        
        all ,
        
        /// <summary>
        /// Enum Not for value: not
        /// </summary>
        
        not ,
        
        /// <summary>
        /// Enum Folder for value: folder
        /// </summary>
        
        folder ,
        
        /// <summary>
        /// Enum RevealQueryLanguage for value: revealQueryLanguage
        /// </summary>
        
        revealQueryLanguage ,
        
        /// <summary>
        /// Enum Term for value: term
        /// </summary>
        
        term ,
        
        /// <summary>
        /// Enum Numeric for value: numeric
        /// </summary>
        
        numeric ,
        
        /// <summary>
        /// Enum DateTime for value: dateTime
        /// </summary>
        
        dateTime ,
        
        /// <summary>
        /// Enum Metadata for value: metadata
        /// </summary>
        
        metadata ,
        
        /// <summary>
        /// Enum Has for value: has
        /// </summary>
        
        has ,
        
        /// <summary>
        /// Enum DupType for value: dupType
        /// </summary>
        
        dupType ,
        
        /// <summary>
        /// Enum Concept for value: concept
        /// </summary>
        
        concept ,
        
        /// <summary>
        /// Enum AdvancedBoolean for value: advancedBoolean
        /// </summary>
        
        advancedBoolean ,
        
        /// <summary>
        /// Enum RqlList for value: rqlList
        /// </summary>
        
        rqlList ,
        
        /// <summary>
        /// Enum Expansion for value: expansion
        /// </summary>
        
        expansion ,
        
        /// <summary>
        /// Enum Time for value: time
        /// </summary>
        
        time ,
        
        /// <summary>
        /// Enum SearchProfile for value: searchProfile
        /// </summary>
        
        searchProfile,
        
        /// <summary>
        /// Enum TermIn for value: termIn
        /// </summary>
        
         termIn
    }

}
