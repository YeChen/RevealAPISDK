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
    /// Defines FolderSearchType
    /// </summary>
    
    public enum FolderSearchType
    {
        
        /// <summary>
        /// Enum Work for value: Work
        /// </summary>
        
        Work ,
        
        /// <summary>
        /// Enum Document for value: Document
        /// </summary>
        
        Document ,
        
        /// <summary>
        /// Enum AssignmentFolder for value: AssignmentFolder
        /// </summary>
        
        AssignmentFolder ,
        
        /// <summary>
        /// Enum Transcript for value: Transcript
        /// </summary>
        
        Transcript ,
        
        /// <summary>
        /// Enum Imports for value: Imports
        /// </summary>
        
        Imports ,
        
        /// <summary>
        /// Enum SecuredByTeam for value: SecuredByTeam
        /// </summary>
        
        SecuredByTeam ,
        
        /// <summary>
        /// Enum SecuredByUser for value: SecuredByUser
        /// </summary>
        
        SecuredByUser ,
        
        /// <summary>
        /// Enum Unsecured for value: Unsecured
        /// </summary>
        
        Unsecured ,
        
        /// <summary>
        /// Enum RedactionByUser for value: RedactionByUser
        /// </summary>
        
        RedactionByUser ,
        
        /// <summary>
        /// Enum AssignmentByBatch for value: AssignmentByBatch
        /// </summary>
        
        AssignmentByBatch ,
        
        /// <summary>
        /// Enum AssignmentByCustodian for value: AssignmentByCustodian
        /// </summary>
        
        AssignmentByCustodian ,
        
        /// <summary>
        /// Enum AssignmentByJob for value: AssignmentByJob
        /// </summary>
        
        AssignmentByJob ,
        
        /// <summary>
        /// Enum AssignmentByFolderIsReviewed for value: AssignmentByFolderIsReviewed
        /// </summary>
        
        AssignmentByFolderIsReviewed ,
        
        /// <summary>
        /// Enum AssignmentByFolderIsNotReviewed for value: AssignmentByFolderIsNotReviewed
        /// </summary>
        
        AssignmentByFolderIsNotReviewed ,
        
        /// <summary>
        /// Enum AssignmentByJobIsReviewed for value: AssignmentByJobIsReviewed
        /// </summary>
        
        AssignmentByJobIsReviewed ,
        
        /// <summary>
        /// Enum AssignmentByJobIsNotReviewed for value: AssignmentByJobIsNotReviewed
        /// </summary>
        
        AssignmentByJobIsNotReviewed,
        
        /// <summary>
        /// Enum TagProfileIsReviewed for value: TagProfileIsReviewed
        /// </summary>
        
        TagProfileIsReviewed ,
        
        /// <summary>
        /// Enum TagProfileIsNotReviewed for value: TagProfileIsNotReviewed
        /// </summary>
        
        TagProfileIsNotReviewed 
    }

}
