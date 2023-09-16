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
    /// MetadataConfigResource
    /// </summary>
    [DataContract(Name = "MetadataConfigResource")]
    public partial class MetadataConfigResource : IEquatable<MetadataConfigResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CertificationCountry
        /// </summary>
        [DataMember(Name = "certificationCountry", EmitDefaultValue = false)]
        public TMDbCountryCode? CertificationCountry { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataConfigResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="certificationCountry">certificationCountry.</param>
        public MetadataConfigResource(int id = default(int), TMDbCountryCode? certificationCountry = default(TMDbCountryCode?))
        {
            this.Id = id;
            this.CertificationCountry = certificationCountry;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataConfigResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CertificationCountry: ").Append(CertificationCountry).Append("\n");
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
            return this.Equals(input as MetadataConfigResource);
        }

        /// <summary>
        /// Returns true if MetadataConfigResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MetadataConfigResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataConfigResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.CertificationCountry == input.CertificationCountry ||
                    this.CertificationCountry.Equals(input.CertificationCountry)
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
                hashCode = hashCode * 59 + this.CertificationCountry.GetHashCode();
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
