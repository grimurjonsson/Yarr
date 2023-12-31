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
    /// Defines TrackedDownloadState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackedDownloadState
    {
        /// <summary>
        /// Enum Downloading for value: downloading
        /// </summary>
        [EnumMember(Value = "downloading")]
        Downloading = 1,

        /// <summary>
        /// Enum ImportPending for value: importPending
        /// </summary>
        [EnumMember(Value = "importPending")]
        ImportPending = 2,

        /// <summary>
        /// Enum Importing for value: importing
        /// </summary>
        [EnumMember(Value = "importing")]
        Importing = 3,

        /// <summary>
        /// Enum Imported for value: imported
        /// </summary>
        [EnumMember(Value = "imported")]
        Imported = 4,

        /// <summary>
        /// Enum FailedPending for value: failedPending
        /// </summary>
        [EnumMember(Value = "failedPending")]
        FailedPending = 5,

        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 6,

        /// <summary>
        /// Enum Ignored for value: ignored
        /// </summary>
        [EnumMember(Value = "ignored")]
        Ignored = 7

    }

}
