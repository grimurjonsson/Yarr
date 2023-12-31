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
    /// Defines MovieStatusType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MovieStatusType
    {
        /// <summary>
        /// Enum Tba for value: tba
        /// </summary>
        [EnumMember(Value = "tba")]
        Tba = 1,

        /// <summary>
        /// Enum Announced for value: announced
        /// </summary>
        [EnumMember(Value = "announced")]
        Announced = 2,

        /// <summary>
        /// Enum InCinemas for value: inCinemas
        /// </summary>
        [EnumMember(Value = "inCinemas")]
        InCinemas = 3,

        /// <summary>
        /// Enum Released for value: released
        /// </summary>
        [EnumMember(Value = "released")]
        Released = 4,

        /// <summary>
        /// Enum Deleted for value: deleted
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted = 5

    }

}
