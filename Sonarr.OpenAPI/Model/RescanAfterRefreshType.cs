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
    /// Defines RescanAfterRefreshType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RescanAfterRefreshType
    {
        /// <summary>
        /// Enum Always for value: always
        /// </summary>
        [EnumMember(Value = "always")]
        Always = 1,

        /// <summary>
        /// Enum AfterManual for value: afterManual
        /// </summary>
        [EnumMember(Value = "afterManual")]
        AfterManual = 2,

        /// <summary>
        /// Enum Never for value: never
        /// </summary>
        [EnumMember(Value = "never")]
        Never = 3

    }

}