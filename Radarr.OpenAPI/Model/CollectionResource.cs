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
    /// CollectionResource
    /// </summary>
    [DataContract(Name = "CollectionResource")]
    public partial class CollectionResource : IEquatable<CollectionResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MinimumAvailability
        /// </summary>
        [DataMember(Name = "minimumAvailability", EmitDefaultValue = false)]
        public MovieStatusType? MinimumAvailability { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="sortTitle">sortTitle.</param>
        /// <param name="tmdbId">tmdbId.</param>
        /// <param name="images">images.</param>
        /// <param name="overview">overview.</param>
        /// <param name="monitored">monitored.</param>
        /// <param name="rootFolderPath">rootFolderPath.</param>
        /// <param name="qualityProfileId">qualityProfileId.</param>
        /// <param name="searchOnAdd">searchOnAdd.</param>
        /// <param name="minimumAvailability">minimumAvailability.</param>
        /// <param name="movies">movies.</param>
        /// <param name="missingMovies">missingMovies.</param>
        /// <param name="tags">tags.</param>
        public CollectionResource(int id = default(int), string title = default(string), string sortTitle = default(string), int tmdbId = default(int), List<MediaCover> images = default(List<MediaCover>), string overview = default(string), bool monitored = default(bool), string rootFolderPath = default(string), int qualityProfileId = default(int), bool searchOnAdd = default(bool), MovieStatusType? minimumAvailability = default(MovieStatusType?), List<CollectionMovieResource> movies = default(List<CollectionMovieResource>), int missingMovies = default(int), List<int> tags = default(List<int>))
        {
            this.Id = id;
            this.Title = title;
            this.SortTitle = sortTitle;
            this.TmdbId = tmdbId;
            this.Images = images;
            this.Overview = overview;
            this.Monitored = monitored;
            this.RootFolderPath = rootFolderPath;
            this.QualityProfileId = qualityProfileId;
            this.SearchOnAdd = searchOnAdd;
            this.MinimumAvailability = minimumAvailability;
            this.Movies = movies;
            this.MissingMovies = missingMovies;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SortTitle
        /// </summary>
        [DataMember(Name = "sortTitle", EmitDefaultValue = true)]
        public string SortTitle { get; set; }

        /// <summary>
        /// Gets or Sets TmdbId
        /// </summary>
        [DataMember(Name = "tmdbId", EmitDefaultValue = false)]
        public int TmdbId { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = true)]
        public List<MediaCover> Images { get; set; }

        /// <summary>
        /// Gets or Sets Overview
        /// </summary>
        [DataMember(Name = "overview", EmitDefaultValue = true)]
        public string Overview { get; set; }

        /// <summary>
        /// Gets or Sets Monitored
        /// </summary>
        [DataMember(Name = "monitored", EmitDefaultValue = true)]
        public bool Monitored { get; set; }

        /// <summary>
        /// Gets or Sets RootFolderPath
        /// </summary>
        [DataMember(Name = "rootFolderPath", EmitDefaultValue = true)]
        public string RootFolderPath { get; set; }

        /// <summary>
        /// Gets or Sets QualityProfileId
        /// </summary>
        [DataMember(Name = "qualityProfileId", EmitDefaultValue = false)]
        public int QualityProfileId { get; set; }

        /// <summary>
        /// Gets or Sets SearchOnAdd
        /// </summary>
        [DataMember(Name = "searchOnAdd", EmitDefaultValue = true)]
        public bool SearchOnAdd { get; set; }

        /// <summary>
        /// Gets or Sets Movies
        /// </summary>
        [DataMember(Name = "movies", EmitDefaultValue = true)]
        public List<CollectionMovieResource> Movies { get; set; }

        /// <summary>
        /// Gets or Sets MissingMovies
        /// </summary>
        [DataMember(Name = "missingMovies", EmitDefaultValue = false)]
        public int MissingMovies { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  SortTitle: ").Append(SortTitle).Append("\n");
            sb.Append("  TmdbId: ").Append(TmdbId).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Overview: ").Append(Overview).Append("\n");
            sb.Append("  Monitored: ").Append(Monitored).Append("\n");
            sb.Append("  RootFolderPath: ").Append(RootFolderPath).Append("\n");
            sb.Append("  QualityProfileId: ").Append(QualityProfileId).Append("\n");
            sb.Append("  SearchOnAdd: ").Append(SearchOnAdd).Append("\n");
            sb.Append("  MinimumAvailability: ").Append(MinimumAvailability).Append("\n");
            sb.Append("  Movies: ").Append(Movies).Append("\n");
            sb.Append("  MissingMovies: ").Append(MissingMovies).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as CollectionResource);
        }

        /// <summary>
        /// Returns true if CollectionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.SortTitle == input.SortTitle ||
                    (this.SortTitle != null &&
                    this.SortTitle.Equals(input.SortTitle))
                ) && 
                (
                    this.TmdbId == input.TmdbId ||
                    this.TmdbId.Equals(input.TmdbId)
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Overview == input.Overview ||
                    (this.Overview != null &&
                    this.Overview.Equals(input.Overview))
                ) && 
                (
                    this.Monitored == input.Monitored ||
                    this.Monitored.Equals(input.Monitored)
                ) && 
                (
                    this.RootFolderPath == input.RootFolderPath ||
                    (this.RootFolderPath != null &&
                    this.RootFolderPath.Equals(input.RootFolderPath))
                ) && 
                (
                    this.QualityProfileId == input.QualityProfileId ||
                    this.QualityProfileId.Equals(input.QualityProfileId)
                ) && 
                (
                    this.SearchOnAdd == input.SearchOnAdd ||
                    this.SearchOnAdd.Equals(input.SearchOnAdd)
                ) && 
                (
                    this.MinimumAvailability == input.MinimumAvailability ||
                    this.MinimumAvailability.Equals(input.MinimumAvailability)
                ) && 
                (
                    this.Movies == input.Movies ||
                    this.Movies != null &&
                    input.Movies != null &&
                    this.Movies.SequenceEqual(input.Movies)
                ) && 
                (
                    this.MissingMovies == input.MissingMovies ||
                    this.MissingMovies.Equals(input.MissingMovies)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SortTitle != null)
                    hashCode = hashCode * 59 + this.SortTitle.GetHashCode();
                hashCode = hashCode * 59 + this.TmdbId.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Overview != null)
                    hashCode = hashCode * 59 + this.Overview.GetHashCode();
                hashCode = hashCode * 59 + this.Monitored.GetHashCode();
                if (this.RootFolderPath != null)
                    hashCode = hashCode * 59 + this.RootFolderPath.GetHashCode();
                hashCode = hashCode * 59 + this.QualityProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.SearchOnAdd.GetHashCode();
                hashCode = hashCode * 59 + this.MinimumAvailability.GetHashCode();
                if (this.Movies != null)
                    hashCode = hashCode * 59 + this.Movies.GetHashCode();
                hashCode = hashCode * 59 + this.MissingMovies.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
