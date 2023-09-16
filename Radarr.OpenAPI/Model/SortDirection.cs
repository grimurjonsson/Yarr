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
    /// Defines SortDirection
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirection
    {
        /// <summary>
        /// Enum Default for value: default
        /// </summary>
        [EnumMember(Value = "default")]
        Default = 1,

        /// <summary>
        /// Enum Ascending for value: ascending
        /// </summary>
        [EnumMember(Value = "ascending")]
        Ascending = 2,

        /// <summary>
        /// Enum Descending for value: descending
        /// </summary>
        [EnumMember(Value = "descending")]
        Descending = 3

    }

}
