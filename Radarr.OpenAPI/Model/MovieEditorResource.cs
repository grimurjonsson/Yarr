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
    /// MovieEditorResource
    /// </summary>
    [DataContract(Name = "MovieEditorResource")]
    public partial class MovieEditorResource : IEquatable<MovieEditorResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MinimumAvailability
        /// </summary>
        [DataMember(Name = "minimumAvailability", EmitDefaultValue = false)]
        public MovieStatusType? MinimumAvailability { get; set; }

        /// <summary>
        /// Gets or Sets ApplyTags
        /// </summary>
        [DataMember(Name = "applyTags", EmitDefaultValue = false)]
        public ApplyTags? ApplyTags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MovieEditorResource" /> class.
        /// </summary>
        /// <param name="movieIds">movieIds.</param>
        /// <param name="monitored">monitored.</param>
        /// <param name="qualityProfileId">qualityProfileId.</param>
        /// <param name="minimumAvailability">minimumAvailability.</param>
        /// <param name="rootFolderPath">rootFolderPath.</param>
        /// <param name="tags">tags.</param>
        /// <param name="applyTags">applyTags.</param>
        /// <param name="moveFiles">moveFiles.</param>
        /// <param name="deleteFiles">deleteFiles.</param>
        /// <param name="addImportExclusion">addImportExclusion.</param>
        public MovieEditorResource(List<int> movieIds = default(List<int>), bool? monitored = default(bool?), int? qualityProfileId = default(int?), MovieStatusType? minimumAvailability = default(MovieStatusType?), string rootFolderPath = default(string), List<int> tags = default(List<int>), ApplyTags? applyTags = default(ApplyTags?), bool moveFiles = default(bool), bool deleteFiles = default(bool), bool addImportExclusion = default(bool))
        {
            this.MovieIds = movieIds;
            this.Monitored = monitored;
            this.QualityProfileId = qualityProfileId;
            this.MinimumAvailability = minimumAvailability;
            this.RootFolderPath = rootFolderPath;
            this.Tags = tags;
            this.ApplyTags = applyTags;
            this.MoveFiles = moveFiles;
            this.DeleteFiles = deleteFiles;
            this.AddImportExclusion = addImportExclusion;
        }

        /// <summary>
        /// Gets or Sets MovieIds
        /// </summary>
        [DataMember(Name = "movieIds", EmitDefaultValue = true)]
        public List<int> MovieIds { get; set; }

        /// <summary>
        /// Gets or Sets Monitored
        /// </summary>
        [DataMember(Name = "monitored", EmitDefaultValue = true)]
        public bool? Monitored { get; set; }

        /// <summary>
        /// Gets or Sets QualityProfileId
        /// </summary>
        [DataMember(Name = "qualityProfileId", EmitDefaultValue = true)]
        public int? QualityProfileId { get; set; }

        /// <summary>
        /// Gets or Sets RootFolderPath
        /// </summary>
        [DataMember(Name = "rootFolderPath", EmitDefaultValue = true)]
        public string RootFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets MoveFiles
        /// </summary>
        [DataMember(Name = "moveFiles", EmitDefaultValue = true)]
        public bool MoveFiles { get; set; }

        /// <summary>
        /// Gets or Sets DeleteFiles
        /// </summary>
        [DataMember(Name = "deleteFiles", EmitDefaultValue = true)]
        public bool DeleteFiles { get; set; }

        /// <summary>
        /// Gets or Sets AddImportExclusion
        /// </summary>
        [DataMember(Name = "addImportExclusion", EmitDefaultValue = true)]
        public bool AddImportExclusion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieEditorResource {\n");
            sb.Append("  MovieIds: ").Append(MovieIds).Append("\n");
            sb.Append("  Monitored: ").Append(Monitored).Append("\n");
            sb.Append("  QualityProfileId: ").Append(QualityProfileId).Append("\n");
            sb.Append("  MinimumAvailability: ").Append(MinimumAvailability).Append("\n");
            sb.Append("  RootFolderPath: ").Append(RootFolderPath).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ApplyTags: ").Append(ApplyTags).Append("\n");
            sb.Append("  MoveFiles: ").Append(MoveFiles).Append("\n");
            sb.Append("  DeleteFiles: ").Append(DeleteFiles).Append("\n");
            sb.Append("  AddImportExclusion: ").Append(AddImportExclusion).Append("\n");
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
            return this.Equals(input as MovieEditorResource);
        }

        /// <summary>
        /// Returns true if MovieEditorResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MovieEditorResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieEditorResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MovieIds == input.MovieIds ||
                    this.MovieIds != null &&
                    input.MovieIds != null &&
                    this.MovieIds.SequenceEqual(input.MovieIds)
                ) && 
                (
                    this.Monitored == input.Monitored ||
                    (this.Monitored != null &&
                    this.Monitored.Equals(input.Monitored))
                ) && 
                (
                    this.QualityProfileId == input.QualityProfileId ||
                    (this.QualityProfileId != null &&
                    this.QualityProfileId.Equals(input.QualityProfileId))
                ) && 
                (
                    this.MinimumAvailability == input.MinimumAvailability ||
                    this.MinimumAvailability.Equals(input.MinimumAvailability)
                ) && 
                (
                    this.RootFolderPath == input.RootFolderPath ||
                    (this.RootFolderPath != null &&
                    this.RootFolderPath.Equals(input.RootFolderPath))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ApplyTags == input.ApplyTags ||
                    this.ApplyTags.Equals(input.ApplyTags)
                ) && 
                (
                    this.MoveFiles == input.MoveFiles ||
                    this.MoveFiles.Equals(input.MoveFiles)
                ) && 
                (
                    this.DeleteFiles == input.DeleteFiles ||
                    this.DeleteFiles.Equals(input.DeleteFiles)
                ) && 
                (
                    this.AddImportExclusion == input.AddImportExclusion ||
                    this.AddImportExclusion.Equals(input.AddImportExclusion)
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
                if (this.MovieIds != null)
                    hashCode = hashCode * 59 + this.MovieIds.GetHashCode();
                if (this.Monitored != null)
                    hashCode = hashCode * 59 + this.Monitored.GetHashCode();
                if (this.QualityProfileId != null)
                    hashCode = hashCode * 59 + this.QualityProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.MinimumAvailability.GetHashCode();
                if (this.RootFolderPath != null)
                    hashCode = hashCode * 59 + this.RootFolderPath.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ApplyTags.GetHashCode();
                hashCode = hashCode * 59 + this.MoveFiles.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteFiles.GetHashCode();
                hashCode = hashCode * 59 + this.AddImportExclusion.GetHashCode();
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