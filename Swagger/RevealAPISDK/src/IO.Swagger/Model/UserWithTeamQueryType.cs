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
    /// Defines UserWithTeamQueryType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserWithTeamQueryType
    {
        
        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 1,
        
        /// <summary>
        /// Enum Team for value: Team
        /// </summary>
        [EnumMember(Value = "Team")]
        Team = 2
    }

}
