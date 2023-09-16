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
    /// IndexerConfigResource
    /// </summary>
    [DataContract(Name = "IndexerConfigResource")]
    public partial class IndexerConfigResource : IEquatable<IndexerConfigResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerConfigResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="minimumAge">minimumAge.</param>
        /// <param name="retention">retention.</param>
        /// <param name="maximumSize">maximumSize.</param>
        /// <param name="rssSyncInterval">rssSyncInterval.</param>
        public IndexerConfigResource(int id = default(int), int minimumAge = default(int), int retention = default(int), int maximumSize = default(int), int rssSyncInterval = default(int))
        {
            this.Id = id;
            this.MinimumAge = minimumAge;
            this.Retention = retention;
            this.MaximumSize = maximumSize;
            this.RssSyncInterval = rssSyncInterval;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets MinimumAge
        /// </summary>
        [DataMember(Name = "minimumAge", EmitDefaultValue = false)]
        public int MinimumAge { get; set; }

        /// <summary>
        /// Gets or Sets Retention
        /// </summary>
        [DataMember(Name = "retention", EmitDefaultValue = false)]
        public int Retention { get; set; }

        /// <summary>
        /// Gets or Sets MaximumSize
        /// </summary>
        [DataMember(Name = "maximumSize", EmitDefaultValue = false)]
        public int MaximumSize { get; set; }

        /// <summary>
        /// Gets or Sets RssSyncInterval
        /// </summary>
        [DataMember(Name = "rssSyncInterval", EmitDefaultValue = false)]
        public int RssSyncInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexerConfigResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MinimumAge: ").Append(MinimumAge).Append("\n");
            sb.Append("  Retention: ").Append(Retention).Append("\n");
            sb.Append("  MaximumSize: ").Append(MaximumSize).Append("\n");
            sb.Append("  RssSyncInterval: ").Append(RssSyncInterval).Append("\n");
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
            return this.Equals(input as IndexerConfigResource);
        }

        /// <summary>
        /// Returns true if IndexerConfigResource instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexerConfigResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexerConfigResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.MinimumAge == input.MinimumAge ||
                    this.MinimumAge.Equals(input.MinimumAge)
                ) && 
                (
                    this.Retention == input.Retention ||
                    this.Retention.Equals(input.Retention)
                ) && 
                (
                    this.MaximumSize == input.MaximumSize ||
                    this.MaximumSize.Equals(input.MaximumSize)
                ) && 
                (
                    this.RssSyncInterval == input.RssSyncInterval ||
                    this.RssSyncInterval.Equals(input.RssSyncInterval)
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
                hashCode = hashCode * 59 + this.MinimumAge.GetHashCode();
                hashCode = hashCode * 59 + this.Retention.GetHashCode();
                hashCode = hashCode * 59 + this.MaximumSize.GetHashCode();
                hashCode = hashCode * 59 + this.RssSyncInterval.GetHashCode();
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
