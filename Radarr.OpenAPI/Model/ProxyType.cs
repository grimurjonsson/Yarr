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
    /// Defines ProxyType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProxyType
    {
        /// <summary>
        /// Enum Http for value: http
        /// </summary>
        [EnumMember(Value = "http")]
        Http = 1,

        /// <summary>
        /// Enum Socks4 for value: socks4
        /// </summary>
        [EnumMember(Value = "socks4")]
        Socks4 = 2,

        /// <summary>
        /// Enum Socks5 for value: socks5
        /// </summary>
        [EnumMember(Value = "socks5")]
        Socks5 = 3

    }

}