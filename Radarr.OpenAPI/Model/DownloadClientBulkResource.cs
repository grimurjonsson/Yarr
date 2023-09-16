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
    /// DownloadClientBulkResource
    /// </summary>
    [DataContract(Name = "DownloadClientBulkResource")]
    public partial class DownloadClientBulkResource : IEquatable<DownloadClientBulkResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApplyTags
        /// </summary>
        [DataMember(Name = "applyTags", EmitDefaultValue = false)]
        public ApplyTags? ApplyTags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadClientBulkResource" /> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="tags">tags.</param>
        /// <param name="applyTags">applyTags.</param>
        /// <param name="enable">enable.</param>
        /// <param name="priority">priority.</param>
        /// <param name="removeCompletedDownloads">removeCompletedDownloads.</param>
        /// <param name="removeFailedDownloads">removeFailedDownloads.</param>
        public DownloadClientBulkResource(List<int> ids = default(List<int>), List<int> tags = default(List<int>), ApplyTags? applyTags = default(ApplyTags?), bool? enable = default(bool?), int? priority = default(int?), bool? removeCompletedDownloads = default(bool?), bool? removeFailedDownloads = default(bool?))
        {
            this.Ids = ids;
            this.Tags = tags;
            this.ApplyTags = applyTags;
            this.Enable = enable;
            this.Priority = priority;
            this.RemoveCompletedDownloads = removeCompletedDownloads;
            this.RemoveFailedDownloads = removeFailedDownloads;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets RemoveCompletedDownloads
        /// </summary>
        [DataMember(Name = "removeCompletedDownloads", EmitDefaultValue = true)]
        public bool? RemoveCompletedDownloads { get; set; }

        /// <summary>
        /// Gets or Sets RemoveFailedDownloads
        /// </summary>
        [DataMember(Name = "removeFailedDownloads", EmitDefaultValue = true)]
        public bool? RemoveFailedDownloads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadClientBulkResource {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ApplyTags: ").Append(ApplyTags).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  RemoveCompletedDownloads: ").Append(RemoveCompletedDownloads).Append("\n");
            sb.Append("  RemoveFailedDownloads: ").Append(RemoveFailedDownloads).Append("\n");
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
            return this.Equals(input as DownloadClientBulkResource);
        }

        /// <summary>
        /// Returns true if DownloadClientBulkResource instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadClientBulkResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadClientBulkResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
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
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.RemoveCompletedDownloads == input.RemoveCompletedDownloads ||
                    (this.RemoveCompletedDownloads != null &&
                    this.RemoveCompletedDownloads.Equals(input.RemoveCompletedDownloads))
                ) && 
                (
                    this.RemoveFailedDownloads == input.RemoveFailedDownloads ||
                    (this.RemoveFailedDownloads != null &&
                    this.RemoveFailedDownloads.Equals(input.RemoveFailedDownloads))
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ApplyTags.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RemoveCompletedDownloads != null)
                    hashCode = hashCode * 59 + this.RemoveCompletedDownloads.GetHashCode();
                if (this.RemoveFailedDownloads != null)
                    hashCode = hashCode * 59 + this.RemoveFailedDownloads.GetHashCode();
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