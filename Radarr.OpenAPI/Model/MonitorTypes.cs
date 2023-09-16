/*
 * Radarr
 *
 * Radarr API docs
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
using OpenAPIDateConverter = Radarr.OpenAPI.Client.OpenAPIDateConverter;

namespace Radarr.OpenAPI.Model
{
    /// <summary>
    /// Defines MonitorTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonitorTypes
    {
        /// <summary>
        /// Enum MovieOnly for value: movieOnly
        /// </summary>
        [EnumMember(Value = "movieOnly")]
        MovieOnly = 1,

        /// <summary>
        /// Enum MovieAndCollection for value: movieAndCollection
        /// </summary>
        [EnumMember(Value = "movieAndCollection")]
        MovieAndCollection = 2,

        /// <summary>
        /// Enum None for value: none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 3

    }

}
