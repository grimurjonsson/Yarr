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
    /// Defines RuntimeMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuntimeMode
    {
        /// <summary>
        /// Enum Console for value: console
        /// </summary>
        [EnumMember(Value = "console")]
        Console = 1,

        /// <summary>
        /// Enum Service for value: service
        /// </summary>
        [EnumMember(Value = "service")]
        Service = 2,

        /// <summary>
        /// Enum Tray for value: tray
        /// </summary>
        [EnumMember(Value = "tray")]
        Tray = 3

    }

}
