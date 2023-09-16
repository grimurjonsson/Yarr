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
    /// Defines ProperDownloadTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProperDownloadTypes
    {
        /// <summary>
        /// Enum PreferAndUpgrade for value: preferAndUpgrade
        /// </summary>
        [EnumMember(Value = "preferAndUpgrade")]
        PreferAndUpgrade = 1,

        /// <summary>
        /// Enum DoNotUpgrade for value: doNotUpgrade
        /// </summary>
        [EnumMember(Value = "doNotUpgrade")]
        DoNotUpgrade = 2,

        /// <summary>
        /// Enum DoNotPrefer for value: doNotPrefer
        /// </summary>
        [EnumMember(Value = "doNotPrefer")]
        DoNotPrefer = 3

    }

}