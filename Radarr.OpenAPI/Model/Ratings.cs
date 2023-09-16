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
    /// Ratings
    /// </summary>
    [DataContract(Name = "Ratings")]
    public partial class Ratings : IEquatable<Ratings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ratings" /> class.
        /// </summary>
        /// <param name="imdb">imdb.</param>
        /// <param name="tmdb">tmdb.</param>
        /// <param name="metacritic">metacritic.</param>
        /// <param name="rottenTomatoes">rottenTomatoes.</param>
        public Ratings(RatingChild imdb = default(RatingChild), RatingChild tmdb = default(RatingChild), RatingChild metacritic = default(RatingChild), RatingChild rottenTomatoes = default(RatingChild))
        {
            this.Imdb = imdb;
            this.Tmdb = tmdb;
            this.Metacritic = metacritic;
            this.RottenTomatoes = rottenTomatoes;
        }

        /// <summary>
        /// Gets or Sets Imdb
        /// </summary>
        [DataMember(Name = "imdb", EmitDefaultValue = false)]
        public RatingChild Imdb { get; set; }

        /// <summary>
        /// Gets or Sets Tmdb
        /// </summary>
        [DataMember(Name = "tmdb", EmitDefaultValue = false)]
        public RatingChild Tmdb { get; set; }

        /// <summary>
        /// Gets or Sets Metacritic
        /// </summary>
        [DataMember(Name = "metacritic", EmitDefaultValue = false)]
        public RatingChild Metacritic { get; set; }

        /// <summary>
        /// Gets or Sets RottenTomatoes
        /// </summary>
        [DataMember(Name = "rottenTomatoes", EmitDefaultValue = false)]
        public RatingChild RottenTomatoes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ratings {\n");
            sb.Append("  Imdb: ").Append(Imdb).Append("\n");
            sb.Append("  Tmdb: ").Append(Tmdb).Append("\n");
            sb.Append("  Metacritic: ").Append(Metacritic).Append("\n");
            sb.Append("  RottenTomatoes: ").Append(RottenTomatoes).Append("\n");
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
            return this.Equals(input as Ratings);
        }

        /// <summary>
        /// Returns true if Ratings instances are equal
        /// </summary>
        /// <param name="input">Instance of Ratings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ratings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Imdb == input.Imdb ||
                    (this.Imdb != null &&
                    this.Imdb.Equals(input.Imdb))
                ) && 
                (
                    this.Tmdb == input.Tmdb ||
                    (this.Tmdb != null &&
                    this.Tmdb.Equals(input.Tmdb))
                ) && 
                (
                    this.Metacritic == input.Metacritic ||
                    (this.Metacritic != null &&
                    this.Metacritic.Equals(input.Metacritic))
                ) && 
                (
                    this.RottenTomatoes == input.RottenTomatoes ||
                    (this.RottenTomatoes != null &&
                    this.RottenTomatoes.Equals(input.RottenTomatoes))
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
                if (this.Imdb != null)
                    hashCode = hashCode * 59 + this.Imdb.GetHashCode();
                if (this.Tmdb != null)
                    hashCode = hashCode * 59 + this.Tmdb.GetHashCode();
                if (this.Metacritic != null)
                    hashCode = hashCode * 59 + this.Metacritic.GetHashCode();
                if (this.RottenTomatoes != null)
                    hashCode = hashCode * 59 + this.RottenTomatoes.GetHashCode();
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