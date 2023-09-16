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
    /// QueueResource
    /// </summary>
    [DataContract(Name = "QueueResource")]
    public partial class QueueResource : IEquatable<QueueResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TrackedDownloadStatus
        /// </summary>
        [DataMember(Name = "trackedDownloadStatus", EmitDefaultValue = false)]
        public TrackedDownloadStatus? TrackedDownloadStatus { get; set; }

        /// <summary>
        /// Gets or Sets TrackedDownloadState
        /// </summary>
        [DataMember(Name = "trackedDownloadState", EmitDefaultValue = false)]
        public TrackedDownloadState? TrackedDownloadState { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public DownloadProtocol? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="movieId">movieId.</param>
        /// <param name="movie">movie.</param>
        /// <param name="languages">languages.</param>
        /// <param name="quality">quality.</param>
        /// <param name="customFormats">customFormats.</param>
        /// <param name="customFormatScore">customFormatScore.</param>
        /// <param name="size">size.</param>
        /// <param name="title">title.</param>
        /// <param name="sizeleft">sizeleft.</param>
        /// <param name="timeleft">timeleft.</param>
        /// <param name="estimatedCompletionTime">estimatedCompletionTime.</param>
        /// <param name="status">status.</param>
        /// <param name="trackedDownloadStatus">trackedDownloadStatus.</param>
        /// <param name="trackedDownloadState">trackedDownloadState.</param>
        /// <param name="statusMessages">statusMessages.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="downloadId">downloadId.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="downloadClient">downloadClient.</param>
        /// <param name="indexer">indexer.</param>
        /// <param name="outputPath">outputPath.</param>
        public QueueResource(int id = default(int), int? movieId = default(int?), MovieResource movie = default(MovieResource), List<Language> languages = default(List<Language>), QualityModel quality = default(QualityModel), List<CustomFormatResource> customFormats = default(List<CustomFormatResource>), int customFormatScore = default(int), double size = default(double), string title = default(string), double sizeleft = default(double), TimeSpan timeleft = default(TimeSpan), DateTime? estimatedCompletionTime = default(DateTime?), string status = default(string), TrackedDownloadStatus? trackedDownloadStatus = default(TrackedDownloadStatus?), TrackedDownloadState? trackedDownloadState = default(TrackedDownloadState?), List<TrackedDownloadStatusMessage> statusMessages = default(List<TrackedDownloadStatusMessage>), string errorMessage = default(string), string downloadId = default(string), DownloadProtocol? protocol = default(DownloadProtocol?), string downloadClient = default(string), string indexer = default(string), string outputPath = default(string))
        {
            this.Id = id;
            this.MovieId = movieId;
            this.Movie = movie;
            this.Languages = languages;
            this.Quality = quality;
            this.CustomFormats = customFormats;
            this.CustomFormatScore = customFormatScore;
            this.Size = size;
            this.Title = title;
            this.Sizeleft = sizeleft;
            this.Timeleft = timeleft;
            this.EstimatedCompletionTime = estimatedCompletionTime;
            this.Status = status;
            this.TrackedDownloadStatus = trackedDownloadStatus;
            this.TrackedDownloadState = trackedDownloadState;
            this.StatusMessages = statusMessages;
            this.ErrorMessage = errorMessage;
            this.DownloadId = downloadId;
            this.Protocol = protocol;
            this.DownloadClient = downloadClient;
            this.Indexer = indexer;
            this.OutputPath = outputPath;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets MovieId
        /// </summary>
        [DataMember(Name = "movieId", EmitDefaultValue = true)]
        public int? MovieId { get; set; }

        /// <summary>
        /// Gets or Sets Movie
        /// </summary>
        [DataMember(Name = "movie", EmitDefaultValue = false)]
        public MovieResource Movie { get; set; }

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
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public double Size { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Sizeleft
        /// </summary>
        [DataMember(Name = "sizeleft", EmitDefaultValue = false)]
        public double Sizeleft { get; set; }

        /// <summary>
        /// Gets or Sets Timeleft
        /// </summary>
        [DataMember(Name = "timeleft", EmitDefaultValue = false)]
        public TimeSpan Timeleft { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCompletionTime
        /// </summary>
        [DataMember(Name = "estimatedCompletionTime", EmitDefaultValue = true)]
        public DateTime? EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusMessages
        /// </summary>
        [DataMember(Name = "statusMessages", EmitDefaultValue = true)]
        public List<TrackedDownloadStatusMessage> StatusMessages { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets DownloadId
        /// </summary>
        [DataMember(Name = "downloadId", EmitDefaultValue = true)]
        public string DownloadId { get; set; }

        /// <summary>
        /// Gets or Sets DownloadClient
        /// </summary>
        [DataMember(Name = "downloadClient", EmitDefaultValue = true)]
        public string DownloadClient { get; set; }

        /// <summary>
        /// Gets or Sets Indexer
        /// </summary>
        [DataMember(Name = "indexer", EmitDefaultValue = true)]
        public string Indexer { get; set; }

        /// <summary>
        /// Gets or Sets OutputPath
        /// </summary>
        [DataMember(Name = "outputPath", EmitDefaultValue = true)]
        public string OutputPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MovieId: ").Append(MovieId).Append("\n");
            sb.Append("  Movie: ").Append(Movie).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  CustomFormats: ").Append(CustomFormats).Append("\n");
            sb.Append("  CustomFormatScore: ").Append(CustomFormatScore).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Sizeleft: ").Append(Sizeleft).Append("\n");
            sb.Append("  Timeleft: ").Append(Timeleft).Append("\n");
            sb.Append("  EstimatedCompletionTime: ").Append(EstimatedCompletionTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackedDownloadStatus: ").Append(TrackedDownloadStatus).Append("\n");
            sb.Append("  TrackedDownloadState: ").Append(TrackedDownloadState).Append("\n");
            sb.Append("  StatusMessages: ").Append(StatusMessages).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  DownloadClient: ").Append(DownloadClient).Append("\n");
            sb.Append("  Indexer: ").Append(Indexer).Append("\n");
            sb.Append("  OutputPath: ").Append(OutputPath).Append("\n");
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
            return this.Equals(input as QueueResource);
        }

        /// <summary>
        /// Returns true if QueueResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueResource input)
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
                    (this.MovieId != null &&
                    this.MovieId.Equals(input.MovieId))
                ) && 
                (
                    this.Movie == input.Movie ||
                    (this.Movie != null &&
                    this.Movie.Equals(input.Movie))
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
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Sizeleft == input.Sizeleft ||
                    this.Sizeleft.Equals(input.Sizeleft)
                ) && 
                (
                    this.Timeleft == input.Timeleft ||
                    (this.Timeleft != null &&
                    this.Timeleft.Equals(input.Timeleft))
                ) && 
                (
                    this.EstimatedCompletionTime == input.EstimatedCompletionTime ||
                    (this.EstimatedCompletionTime != null &&
                    this.EstimatedCompletionTime.Equals(input.EstimatedCompletionTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TrackedDownloadStatus == input.TrackedDownloadStatus ||
                    this.TrackedDownloadStatus.Equals(input.TrackedDownloadStatus)
                ) && 
                (
                    this.TrackedDownloadState == input.TrackedDownloadState ||
                    this.TrackedDownloadState.Equals(input.TrackedDownloadState)
                ) && 
                (
                    this.StatusMessages == input.StatusMessages ||
                    this.StatusMessages != null &&
                    input.StatusMessages != null &&
                    this.StatusMessages.SequenceEqual(input.StatusMessages)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.DownloadId == input.DownloadId ||
                    (this.DownloadId != null &&
                    this.DownloadId.Equals(input.DownloadId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
                ) && 
                (
                    this.DownloadClient == input.DownloadClient ||
                    (this.DownloadClient != null &&
                    this.DownloadClient.Equals(input.DownloadClient))
                ) && 
                (
                    this.Indexer == input.Indexer ||
                    (this.Indexer != null &&
                    this.Indexer.Equals(input.Indexer))
                ) && 
                (
                    this.OutputPath == input.OutputPath ||
                    (this.OutputPath != null &&
                    this.OutputPath.Equals(input.OutputPath))
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
                if (this.MovieId != null)
                    hashCode = hashCode * 59 + this.MovieId.GetHashCode();
                if (this.Movie != null)
                    hashCode = hashCode * 59 + this.Movie.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.CustomFormats != null)
                    hashCode = hashCode * 59 + this.CustomFormats.GetHashCode();
                hashCode = hashCode * 59 + this.CustomFormatScore.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Sizeleft.GetHashCode();
                if (this.Timeleft != null)
                    hashCode = hashCode * 59 + this.Timeleft.GetHashCode();
                if (this.EstimatedCompletionTime != null)
                    hashCode = hashCode * 59 + this.EstimatedCompletionTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.TrackedDownloadStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TrackedDownloadState.GetHashCode();
                if (this.StatusMessages != null)
                    hashCode = hashCode * 59 + this.StatusMessages.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.DownloadId != null)
                    hashCode = hashCode * 59 + this.DownloadId.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.DownloadClient != null)
                    hashCode = hashCode * 59 + this.DownloadClient.GetHashCode();
                if (this.Indexer != null)
                    hashCode = hashCode * 59 + this.Indexer.GetHashCode();
                if (this.OutputPath != null)
                    hashCode = hashCode * 59 + this.OutputPath.GetHashCode();
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
