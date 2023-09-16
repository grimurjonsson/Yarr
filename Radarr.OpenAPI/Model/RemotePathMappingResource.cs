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
    /// RemotePathMappingResource
    /// </summary>
    [DataContract(Name = "RemotePathMappingResource")]
    public partial class RemotePathMappingResource : IEquatable<RemotePathMappingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemotePathMappingResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="host">host.</param>
        /// <param name="remotePath">remotePath.</param>
        /// <param name="localPath">localPath.</param>
        public RemotePathMappingResource(int id = default(int), string host = default(string), string remotePath = default(string), string localPath = default(string))
        {
            this.Id = id;
            this.Host = host;
            this.RemotePath = remotePath;
            this.LocalPath = localPath;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets RemotePath
        /// </summary>
        [DataMember(Name = "remotePath", EmitDefaultValue = true)]
        public string RemotePath { get; set; }

        /// <summary>
        /// Gets or Sets LocalPath
        /// </summary>
        [DataMember(Name = "localPath", EmitDefaultValue = true)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemotePathMappingResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  RemotePath: ").Append(RemotePath).Append("\n");
            sb.Append("  LocalPath: ").Append(LocalPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemotePathMappingResource);
        }

        /// <summary>
        /// Returns true if RemotePathMappingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RemotePathMappingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemotePathMappingResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.RemotePath == input.RemotePath ||
                    (this.RemotePath != null &&
                    this.RemotePath.Equals(input.RemotePath))
                ) && 
                (
                    this.LocalPath == input.LocalPath ||
                    (this.LocalPath != null &&
                    this.LocalPath.Equals(input.LocalPath))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.RemotePath != null)
                    hashCode = hashCode * 59 + this.RemotePath.GetHashCode();
                if (this.LocalPath != null)
                    hashCode = hashCode * 59 + this.LocalPath.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}