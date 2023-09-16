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
    /// Defines MovieHistoryEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MovieHistoryEventType
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Grabbed for value: grabbed
        /// </summary>
        [EnumMember(Value = "grabbed")]
        Grabbed = 2,

        /// <summary>
        /// Enum DownloadFolderImported for value: downloadFolderImported
        /// </summary>
        [EnumMember(Value = "downloadFolderImported")]
        DownloadFolderImported = 3,

        /// <summary>
        /// Enum DownloadFailed for value: downloadFailed
        /// </summary>
        [EnumMember(Value = "downloadFailed")]
        DownloadFailed = 4,

        /// <summary>
        /// Enum MovieFileDeleted for value: movieFileDeleted
        /// </summary>
        [EnumMember(Value = "movieFileDeleted")]
        MovieFileDeleted = 5,

        /// <summary>
        /// Enum MovieFolderImported for value: movieFolderImported
        /// </summary>
        [EnumMember(Value = "movieFolderImported")]
        MovieFolderImported = 6,

        /// <summary>
        /// Enum MovieFileRenamed for value: movieFileRenamed
        /// </summary>
        [EnumMember(Value = "movieFileRenamed")]
        MovieFileRenamed = 7,

        /// <summary>
        /// Enum DownloadIgnored for value: downloadIgnored
        /// </summary>
        [EnumMember(Value = "downloadIgnored")]
        DownloadIgnored = 8

    }

}