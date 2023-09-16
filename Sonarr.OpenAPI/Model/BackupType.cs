/*
 * Sonarr
 *
 * Sonarr API docs - The v3 API docs apply to both v3 and v4 versions of Sonarr. Some functionality may only be available in v4 of the Sonarr application.
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Sonarr.OpenAPI.Client.OpenAPIDateConverter;

namespace Sonarr.OpenAPI.Model
{
    /// <summary>
    /// Defines BackupType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackupType
    {
        /// <summary>
        /// Enum Scheduled for value: scheduled
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled = 1,

        /// <summary>
        /// Enum Manual for value: manual
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual = 2,

        /// <summary>
        /// Enum Update for value: update
        /// </summary>
        [EnumMember(Value = "update")]
        Update = 3

    }

}
