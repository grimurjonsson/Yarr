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
    /// Defines EpisodeHistoryEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EpisodeHistoryEventType
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
        /// Enum SeriesFolderImported for value: seriesFolderImported
        /// </summary>
        [EnumMember(Value = "seriesFolderImported")]
        SeriesFolderImported = 3,

        /// <summary>
        /// Enum DownloadFolderImported for value: downloadFolderImported
        /// </summary>
        [EnumMember(Value = "downloadFolderImported")]
        DownloadFolderImported = 4,

        /// <summary>
        /// Enum DownloadFailed for value: downloadFailed
        /// </summary>
        [EnumMember(Value = "downloadFailed")]
        DownloadFailed = 5,

        /// <summary>
        /// Enum EpisodeFileDeleted for value: episodeFileDeleted
        /// </summary>
        [EnumMember(Value = "episodeFileDeleted")]
        EpisodeFileDeleted = 6,

        /// <summary>
        /// Enum EpisodeFileRenamed for value: episodeFileRenamed
        /// </summary>
        [EnumMember(Value = "episodeFileRenamed")]
        EpisodeFileRenamed = 7,

        /// <summary>
        /// Enum DownloadIgnored for value: downloadIgnored
        /// </summary>
        [EnumMember(Value = "downloadIgnored")]
        DownloadIgnored = 8

    }

}
