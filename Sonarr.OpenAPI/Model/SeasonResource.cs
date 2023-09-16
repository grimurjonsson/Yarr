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
    /// SeasonResource
    /// </summary>
    [DataContract(Name = "SeasonResource")]
    public partial class SeasonResource : IEquatable<SeasonResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonResource" /> class.
        /// </summary>
        /// <param name="seasonNumber">seasonNumber.</param>
        /// <param name="monitored">monitored.</param>
        /// <param name="statistics">statistics.</param>
        /// <param name="images">images.</param>
        public SeasonResource(int seasonNumber = default(int), bool monitored = default(bool), SeasonStatisticsResource statistics = default(SeasonStatisticsResource), List<MediaCover> images = default(List<MediaCover>))
        {
            this.SeasonNumber = seasonNumber;
            this.Monitored = monitored;
            this.Statistics = statistics;
            this.Images = images;
        }

        /// <summary>
        /// Gets or Sets SeasonNumber
        /// </summary>
        [DataMember(Name = "seasonNumber", EmitDefaultValue = false)]
        public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or Sets Monitored
        /// </summary>
        [DataMember(Name = "monitored", EmitDefaultValue = true)]
        public bool Monitored { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name = "statistics", EmitDefaultValue = false)]
        public SeasonStatisticsResource Statistics { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = true)]
        public List<MediaCover> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeasonResource {\n");
            sb.Append("  SeasonNumber: ").Append(SeasonNumber).Append("\n");
            sb.Append("  Monitored: ").Append(Monitored).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as SeasonResource);
        }

        /// <summary>
        /// Returns true if SeasonResource instances are equal
        /// </summary>
        /// <param name="input">Instance of SeasonResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeasonResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SeasonNumber == input.SeasonNumber ||
                    this.SeasonNumber.Equals(input.SeasonNumber)
                ) && 
                (
                    this.Monitored == input.Monitored ||
                    this.Monitored.Equals(input.Monitored)
                ) && 
                (
                    this.Statistics == input.Statistics ||
                    (this.Statistics != null &&
                    this.Statistics.Equals(input.Statistics))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                hashCode = hashCode * 59 + this.SeasonNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Monitored.GetHashCode();
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
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
