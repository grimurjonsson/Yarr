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
    /// AddSeriesOptions
    /// </summary>
    [DataContract(Name = "AddSeriesOptions")]
    public partial class AddSeriesOptions : IEquatable<AddSeriesOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Monitor
        /// </summary>
        [DataMember(Name = "monitor", EmitDefaultValue = false)]
        public MonitorTypes? Monitor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSeriesOptions" /> class.
        /// </summary>
        /// <param name="ignoreEpisodesWithFiles">ignoreEpisodesWithFiles.</param>
        /// <param name="ignoreEpisodesWithoutFiles">ignoreEpisodesWithoutFiles.</param>
        /// <param name="monitor">monitor.</param>
        /// <param name="searchForMissingEpisodes">searchForMissingEpisodes.</param>
        /// <param name="searchForCutoffUnmetEpisodes">searchForCutoffUnmetEpisodes.</param>
        public AddSeriesOptions(bool ignoreEpisodesWithFiles = default(bool), bool ignoreEpisodesWithoutFiles = default(bool), MonitorTypes? monitor = default(MonitorTypes?), bool searchForMissingEpisodes = default(bool), bool searchForCutoffUnmetEpisodes = default(bool))
        {
            this.IgnoreEpisodesWithFiles = ignoreEpisodesWithFiles;
            this.IgnoreEpisodesWithoutFiles = ignoreEpisodesWithoutFiles;
            this.Monitor = monitor;
            this.SearchForMissingEpisodes = searchForMissingEpisodes;
            this.SearchForCutoffUnmetEpisodes = searchForCutoffUnmetEpisodes;
        }

        /// <summary>
        /// Gets or Sets IgnoreEpisodesWithFiles
        /// </summary>
        [DataMember(Name = "ignoreEpisodesWithFiles", EmitDefaultValue = true)]
        public bool IgnoreEpisodesWithFiles { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreEpisodesWithoutFiles
        /// </summary>
        [DataMember(Name = "ignoreEpisodesWithoutFiles", EmitDefaultValue = true)]
        public bool IgnoreEpisodesWithoutFiles { get; set; }

        /// <summary>
        /// Gets or Sets SearchForMissingEpisodes
        /// </summary>
        [DataMember(Name = "searchForMissingEpisodes", EmitDefaultValue = true)]
        public bool SearchForMissingEpisodes { get; set; }

        /// <summary>
        /// Gets or Sets SearchForCutoffUnmetEpisodes
        /// </summary>
        [DataMember(Name = "searchForCutoffUnmetEpisodes", EmitDefaultValue = true)]
        public bool SearchForCutoffUnmetEpisodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSeriesOptions {\n");
            sb.Append("  IgnoreEpisodesWithFiles: ").Append(IgnoreEpisodesWithFiles).Append("\n");
            sb.Append("  IgnoreEpisodesWithoutFiles: ").Append(IgnoreEpisodesWithoutFiles).Append("\n");
            sb.Append("  Monitor: ").Append(Monitor).Append("\n");
            sb.Append("  SearchForMissingEpisodes: ").Append(SearchForMissingEpisodes).Append("\n");
            sb.Append("  SearchForCutoffUnmetEpisodes: ").Append(SearchForCutoffUnmetEpisodes).Append("\n");
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
            return this.Equals(input as AddSeriesOptions);
        }

        /// <summary>
        /// Returns true if AddSeriesOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of AddSeriesOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddSeriesOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IgnoreEpisodesWithFiles == input.IgnoreEpisodesWithFiles ||
                    this.IgnoreEpisodesWithFiles.Equals(input.IgnoreEpisodesWithFiles)
                ) && 
                (
                    this.IgnoreEpisodesWithoutFiles == input.IgnoreEpisodesWithoutFiles ||
                    this.IgnoreEpisodesWithoutFiles.Equals(input.IgnoreEpisodesWithoutFiles)
                ) && 
                (
                    this.Monitor == input.Monitor ||
                    this.Monitor.Equals(input.Monitor)
                ) && 
                (
                    this.SearchForMissingEpisodes == input.SearchForMissingEpisodes ||
                    this.SearchForMissingEpisodes.Equals(input.SearchForMissingEpisodes)
                ) && 
                (
                    this.SearchForCutoffUnmetEpisodes == input.SearchForCutoffUnmetEpisodes ||
                    this.SearchForCutoffUnmetEpisodes.Equals(input.SearchForCutoffUnmetEpisodes)
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
                hashCode = hashCode * 59 + this.IgnoreEpisodesWithFiles.GetHashCode();
                hashCode = hashCode * 59 + this.IgnoreEpisodesWithoutFiles.GetHashCode();
                hashCode = hashCode * 59 + this.Monitor.GetHashCode();
                hashCode = hashCode * 59 + this.SearchForMissingEpisodes.GetHashCode();
                hashCode = hashCode * 59 + this.SearchForCutoffUnmetEpisodes.GetHashCode();
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
