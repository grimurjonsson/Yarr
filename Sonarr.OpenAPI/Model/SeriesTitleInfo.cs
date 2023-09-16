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
    /// SeriesTitleInfo
    /// </summary>
    [DataContract(Name = "SeriesTitleInfo")]
    public partial class SeriesTitleInfo : IEquatable<SeriesTitleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesTitleInfo" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="titleWithoutYear">titleWithoutYear.</param>
        /// <param name="year">year.</param>
        /// <param name="allTitles">allTitles.</param>
        public SeriesTitleInfo(string title = default(string), string titleWithoutYear = default(string), int year = default(int), List<string> allTitles = default(List<string>))
        {
            this.Title = title;
            this.TitleWithoutYear = titleWithoutYear;
            this.Year = year;
            this.AllTitles = allTitles;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleWithoutYear
        /// </summary>
        [DataMember(Name = "titleWithoutYear", EmitDefaultValue = true)]
        public string TitleWithoutYear { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets AllTitles
        /// </summary>
        [DataMember(Name = "allTitles", EmitDefaultValue = true)]
        public List<string> AllTitles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeriesTitleInfo {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleWithoutYear: ").Append(TitleWithoutYear).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  AllTitles: ").Append(AllTitles).Append("\n");
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
            return this.Equals(input as SeriesTitleInfo);
        }

        /// <summary>
        /// Returns true if SeriesTitleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesTitleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesTitleInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleWithoutYear == input.TitleWithoutYear ||
                    (this.TitleWithoutYear != null &&
                    this.TitleWithoutYear.Equals(input.TitleWithoutYear))
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.AllTitles == input.AllTitles ||
                    this.AllTitles != null &&
                    input.AllTitles != null &&
                    this.AllTitles.SequenceEqual(input.AllTitles)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleWithoutYear != null)
                    hashCode = hashCode * 59 + this.TitleWithoutYear.GetHashCode();
                hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.AllTitles != null)
                    hashCode = hashCode * 59 + this.AllTitles.GetHashCode();
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