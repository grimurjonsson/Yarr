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
    /// QualityProfileResource
    /// </summary>
    [DataContract(Name = "QualityProfileResource")]
    public partial class QualityProfileResource : IEquatable<QualityProfileResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityProfileResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="upgradeAllowed">upgradeAllowed.</param>
        /// <param name="cutoff">cutoff.</param>
        /// <param name="items">items.</param>
        /// <param name="minFormatScore">minFormatScore.</param>
        /// <param name="cutoffFormatScore">cutoffFormatScore.</param>
        /// <param name="formatItems">formatItems.</param>
        /// <param name="language">language.</param>
        public QualityProfileResource(int id = default(int), string name = default(string), bool upgradeAllowed = default(bool), int cutoff = default(int), List<QualityProfileQualityItemResource> items = default(List<QualityProfileQualityItemResource>), int minFormatScore = default(int), int cutoffFormatScore = default(int), List<ProfileFormatItemResource> formatItems = default(List<ProfileFormatItemResource>), Language language = default(Language))
        {
            this.Id = id;
            this.Name = name;
            this.UpgradeAllowed = upgradeAllowed;
            this.Cutoff = cutoff;
            this.Items = items;
            this.MinFormatScore = minFormatScore;
            this.CutoffFormatScore = cutoffFormatScore;
            this.FormatItems = formatItems;
            this.Language = language;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UpgradeAllowed
        /// </summary>
        [DataMember(Name = "upgradeAllowed", EmitDefaultValue = true)]
        public bool UpgradeAllowed { get; set; }

        /// <summary>
        /// Gets or Sets Cutoff
        /// </summary>
        [DataMember(Name = "cutoff", EmitDefaultValue = false)]
        public int Cutoff { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<QualityProfileQualityItemResource> Items { get; set; }

        /// <summary>
        /// Gets or Sets MinFormatScore
        /// </summary>
        [DataMember(Name = "minFormatScore", EmitDefaultValue = false)]
        public int MinFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets CutoffFormatScore
        /// </summary>
        [DataMember(Name = "cutoffFormatScore", EmitDefaultValue = false)]
        public int CutoffFormatScore { get; set; }

        /// <summary>
        /// Gets or Sets FormatItems
        /// </summary>
        [DataMember(Name = "formatItems", EmitDefaultValue = true)]
        public List<ProfileFormatItemResource> FormatItems { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public Language Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityProfileResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpgradeAllowed: ").Append(UpgradeAllowed).Append("\n");
            sb.Append("  Cutoff: ").Append(Cutoff).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MinFormatScore: ").Append(MinFormatScore).Append("\n");
            sb.Append("  CutoffFormatScore: ").Append(CutoffFormatScore).Append("\n");
            sb.Append("  FormatItems: ").Append(FormatItems).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as QualityProfileResource);
        }

        /// <summary>
        /// Returns true if QualityProfileResource instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityProfileResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityProfileResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UpgradeAllowed == input.UpgradeAllowed ||
                    this.UpgradeAllowed.Equals(input.UpgradeAllowed)
                ) && 
                (
                    this.Cutoff == input.Cutoff ||
                    this.Cutoff.Equals(input.Cutoff)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.MinFormatScore == input.MinFormatScore ||
                    this.MinFormatScore.Equals(input.MinFormatScore)
                ) && 
                (
                    this.CutoffFormatScore == input.CutoffFormatScore ||
                    this.CutoffFormatScore.Equals(input.CutoffFormatScore)
                ) && 
                (
                    this.FormatItems == input.FormatItems ||
                    this.FormatItems != null &&
                    input.FormatItems != null &&
                    this.FormatItems.SequenceEqual(input.FormatItems)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.UpgradeAllowed.GetHashCode();
                hashCode = hashCode * 59 + this.Cutoff.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                hashCode = hashCode * 59 + this.MinFormatScore.GetHashCode();
                hashCode = hashCode * 59 + this.CutoffFormatScore.GetHashCode();
                if (this.FormatItems != null)
                    hashCode = hashCode * 59 + this.FormatItems.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
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
