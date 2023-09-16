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
    /// CreditResource
    /// </summary>
    [DataContract(Name = "CreditResource")]
    public partial class CreditResource : IEquatable<CreditResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CreditType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="personName">personName.</param>
        /// <param name="creditTmdbId">creditTmdbId.</param>
        /// <param name="personTmdbId">personTmdbId.</param>
        /// <param name="movieMetadataId">movieMetadataId.</param>
        /// <param name="images">images.</param>
        /// <param name="department">department.</param>
        /// <param name="job">job.</param>
        /// <param name="character">character.</param>
        /// <param name="order">order.</param>
        /// <param name="type">type.</param>
        public CreditResource(int id = default(int), string personName = default(string), string creditTmdbId = default(string), int personTmdbId = default(int), int movieMetadataId = default(int), List<MediaCover> images = default(List<MediaCover>), string department = default(string), string job = default(string), string character = default(string), int order = default(int), CreditType? type = default(CreditType?))
        {
            this.Id = id;
            this.PersonName = personName;
            this.CreditTmdbId = creditTmdbId;
            this.PersonTmdbId = personTmdbId;
            this.MovieMetadataId = movieMetadataId;
            this.Images = images;
            this.Department = department;
            this.Job = job;
            this.Character = character;
            this.Order = order;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets PersonName
        /// </summary>
        [DataMember(Name = "personName", EmitDefaultValue = true)]
        public string PersonName { get; set; }

        /// <summary>
        /// Gets or Sets CreditTmdbId
        /// </summary>
        [DataMember(Name = "creditTmdbId", EmitDefaultValue = true)]
        public string CreditTmdbId { get; set; }

        /// <summary>
        /// Gets or Sets PersonTmdbId
        /// </summary>
        [DataMember(Name = "personTmdbId", EmitDefaultValue = false)]
        public int PersonTmdbId { get; set; }

        /// <summary>
        /// Gets or Sets MovieMetadataId
        /// </summary>
        [DataMember(Name = "movieMetadataId", EmitDefaultValue = false)]
        public int MovieMetadataId { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = true)]
        public List<MediaCover> Images { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name = "job", EmitDefaultValue = true)]
        public string Job { get; set; }

        /// <summary>
        /// Gets or Sets Character
        /// </summary>
        [DataMember(Name = "character", EmitDefaultValue = true)]
        public string Character { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PersonName: ").Append(PersonName).Append("\n");
            sb.Append("  CreditTmdbId: ").Append(CreditTmdbId).Append("\n");
            sb.Append("  PersonTmdbId: ").Append(PersonTmdbId).Append("\n");
            sb.Append("  MovieMetadataId: ").Append(MovieMetadataId).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Character: ").Append(Character).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreditResource);
        }

        /// <summary>
        /// Returns true if CreditResource instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.PersonName == input.PersonName ||
                    (this.PersonName != null &&
                    this.PersonName.Equals(input.PersonName))
                ) && 
                (
                    this.CreditTmdbId == input.CreditTmdbId ||
                    (this.CreditTmdbId != null &&
                    this.CreditTmdbId.Equals(input.CreditTmdbId))
                ) && 
                (
                    this.PersonTmdbId == input.PersonTmdbId ||
                    this.PersonTmdbId.Equals(input.PersonTmdbId)
                ) && 
                (
                    this.MovieMetadataId == input.MovieMetadataId ||
                    this.MovieMetadataId.Equals(input.MovieMetadataId)
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.Character == input.Character ||
                    (this.Character != null &&
                    this.Character.Equals(input.Character))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.PersonName != null)
                    hashCode = hashCode * 59 + this.PersonName.GetHashCode();
                if (this.CreditTmdbId != null)
                    hashCode = hashCode * 59 + this.CreditTmdbId.GetHashCode();
                hashCode = hashCode * 59 + this.PersonTmdbId.GetHashCode();
                hashCode = hashCode * 59 + this.MovieMetadataId.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Character != null)
                    hashCode = hashCode * 59 + this.Character.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
