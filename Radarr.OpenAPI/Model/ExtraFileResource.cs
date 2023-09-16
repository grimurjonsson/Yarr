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
    /// ExtraFileResource
    /// </summary>
    [DataContract(Name = "ExtraFileResource")]
    public partial class ExtraFileResource : IEquatable<ExtraFileResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ExtraFileType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraFileResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="movieId">movieId.</param>
        /// <param name="movieFileId">movieFileId.</param>
        /// <param name="relativePath">relativePath.</param>
        /// <param name="extension">extension.</param>
        /// <param name="type">type.</param>
        public ExtraFileResource(int id = default(int), int movieId = default(int), int? movieFileId = default(int?), string relativePath = default(string), string extension = default(string), ExtraFileType? type = default(ExtraFileType?))
        {
            this.Id = id;
            this.MovieId = movieId;
            this.MovieFileId = movieFileId;
            this.RelativePath = relativePath;
            this.Extension = extension;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets MovieId
        /// </summary>
        [DataMember(Name = "movieId", EmitDefaultValue = false)]
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or Sets MovieFileId
        /// </summary>
        [DataMember(Name = "movieFileId", EmitDefaultValue = true)]
        public int? MovieFileId { get; set; }

        /// <summary>
        /// Gets or Sets RelativePath
        /// </summary>
        [DataMember(Name = "relativePath", EmitDefaultValue = true)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraFileResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MovieId: ").Append(MovieId).Append("\n");
            sb.Append("  MovieFileId: ").Append(MovieFileId).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ExtraFileResource);
        }

        /// <summary>
        /// Returns true if ExtraFileResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtraFileResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtraFileResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.MovieId == input.MovieId ||
                    this.MovieId.Equals(input.MovieId)
                ) && 
                (
                    this.MovieFileId == input.MovieFileId ||
                    (this.MovieFileId != null &&
                    this.MovieFileId.Equals(input.MovieFileId))
                ) && 
                (
                    this.RelativePath == input.RelativePath ||
                    (this.RelativePath != null &&
                    this.RelativePath.Equals(input.RelativePath))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.MovieId.GetHashCode();
                if (this.MovieFileId != null)
                    hashCode = hashCode * 59 + this.MovieFileId.GetHashCode();
                if (this.RelativePath != null)
                    hashCode = hashCode * 59 + this.RelativePath.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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