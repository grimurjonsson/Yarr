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
    /// HistoryResource
    /// </summary>
    [DataContract(Name = "HistoryResource")]
    public partial class HistoryResource : IEquatable<HistoryResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public EpisodeHistoryEventType? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="episodeId">episodeId.</param>
        /// <param name="seriesId">seriesId.</param>
        /// <param name="sourceTitle">sourceTitle.</param>
        /// <param name="languages">languages.</param>
        /// <param name="quality">quality.</param>
        /// <param name="customFormats">customFormats.</param>
        /// <param name="customFormatScore">customFormatScore.</param>
        /// <param name="qualityCutoffNotMet">qualityCutoffNotMet.</param>
        /// <param name="date">date.</param>
        /// <param name="downloadId">downloadId.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="data">data.</param>
        /// <param name="episode">episode.</param>
        /// <param name="series">series.</param>
        public HistoryResource(int id = default(int), int episodeId = default(int), int seriesId = default(int), string sourceTitle = default(string), List<Language> languages = default(List<Language>), QualityModel quality = default(QualityModel), List<CustomFormatResource> customFormats = default(List<CustomFormatResource>), int customFormatScore = default(int), bool qualityCutoffNotMet = default(bool), DateTime date = default(DateTime), string downloadId = default(string), EpisodeHistoryEventType? eventType = default(EpisodeHistoryEventType?), Dictionary<string, string> data = default(Dictionary<string, string>), EpisodeResource episode = default(EpisodeResource), SeriesResource series = default(SeriesResource))
        {
            this.Id = id;
            this.EpisodeId = episodeId;
            this.SeriesId = seriesId;
            this.SourceTitle = sourceTitle;
            this.Languages = languages;
            this.Quality = quality;
            this.CustomFormats = customFormats;
            this.CustomFormatScore = customFormatScore;
            this.QualityCutoffNotMet = qualityCutoffNotMet;
            this.Date = date;
            this.DownloadId = downloadId;
            this.EventType = eventType;
            this.Data = data;
            this.Episode = episode;
            this.Series = series;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets EpisodeId
        /// </summary>
        [DataMember(Name = "episodeId", EmitDefaultValue = false)]
        public int EpisodeId { get; set; }

        /// <summary>
        /// Gets or Sets SeriesId
        /// </summary>
        [DataMember(Name = "seriesId", EmitDefaultValue = false)]
        public int SeriesId { get; set; }

        /// <summary>
        /// Gets or Sets SourceTitle
        /// </summary>
        [DataMember(Name = "sourceTitle", EmitDefaultValue = true)]
        public string SourceTitle { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = true)]
        public List<Language> Languages { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public QualityModel Quality { get; set; }

        /// <summary>
        /// Gets or Sets CustomFormats
        /// </summary>
        [DataMember(Name = "customFormats", EmitDefaultValue = true)]
        public List<CustomFormatResource> CustomFormats { get; set; }

        /// <summary>
        /// Gets or Sets CustomFormatScore
        /// </summary>
        [DataMember(Name = "customFormatScore", EmitDefaultValue = false)]
        public int CustomFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets QualityCutoffNotMet
        /// </summary>
        [DataMember(Name = "qualityCutoffNotMet", EmitDefaultValue = true)]
        public bool QualityCutoffNotMet { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets DownloadId
        /// </summary>
        [DataMember(Name = "downloadId", EmitDefaultValue = true)]
        public string DownloadId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Gets or Sets Episode
        /// </summary>
        [DataMember(Name = "episode", EmitDefaultValue = false)]
        public EpisodeResource Episode { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public SeriesResource Series { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EpisodeId: ").Append(EpisodeId).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  SourceTitle: ").Append(SourceTitle).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  CustomFormats: ").Append(CustomFormats).Append("\n");
            sb.Append("  CustomFormatScore: ").Append(CustomFormatScore).Append("\n");
            sb.Append("  QualityCutoffNotMet: ").Append(QualityCutoffNotMet).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Episode: ").Append(Episode).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
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
            return this.Equals(input as HistoryResource);
        }

        /// <summary>
        /// Returns true if HistoryResource instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.EpisodeId == input.EpisodeId ||
                    this.EpisodeId.Equals(input.EpisodeId)
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    this.SeriesId.Equals(input.SeriesId)
                ) && 
                (
                    this.SourceTitle == input.SourceTitle ||
                    (this.SourceTitle != null &&
                    this.SourceTitle.Equals(input.SourceTitle))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.CustomFormats == input.CustomFormats ||
                    this.CustomFormats != null &&
                    input.CustomFormats != null &&
                    this.CustomFormats.SequenceEqual(input.CustomFormats)
                ) && 
                (
                    this.CustomFormatScore == input.CustomFormatScore ||
                    this.CustomFormatScore.Equals(input.CustomFormatScore)
                ) && 
                (
                    this.QualityCutoffNotMet == input.QualityCutoffNotMet ||
                    this.QualityCutoffNotMet.Equals(input.QualityCutoffNotMet)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DownloadId == input.DownloadId ||
                    (this.DownloadId != null &&
                    this.DownloadId.Equals(input.DownloadId))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Episode == input.Episode ||
                    (this.Episode != null &&
                    this.Episode.Equals(input.Episode))
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
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
                hashCode = hashCode * 59 + this.EpisodeId.GetHashCode();
                hashCode = hashCode * 59 + this.SeriesId.GetHashCode();
                if (this.SourceTitle != null)
                    hashCode = hashCode * 59 + this.SourceTitle.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.CustomFormats != null)
                    hashCode = hashCode * 59 + this.CustomFormats.GetHashCode();
                hashCode = hashCode * 59 + this.CustomFormatScore.GetHashCode();
                hashCode = hashCode * 59 + this.QualityCutoffNotMet.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DownloadId != null)
                    hashCode = hashCode * 59 + this.DownloadId.GetHashCode();
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Episode != null)
                    hashCode = hashCode * 59 + this.Episode.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
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
