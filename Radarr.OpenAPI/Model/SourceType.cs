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
    /// Defines SourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceType
    {
        /// <summary>
        /// Enum Tmdb for value: tmdb
        /// </summary>
        [EnumMember(Value = "tmdb")]
        Tmdb = 1,

        /// <summary>
        /// Enum Mappings for value: mappings
        /// </summary>
        [EnumMember(Value = "mappings")]
        Mappings = 2,

        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 3,

        /// <summary>
        /// Enum Indexer for value: indexer
        /// </summary>
        [EnumMember(Value = "indexer")]
        Indexer = 4

    }

}
