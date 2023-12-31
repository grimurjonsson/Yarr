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
    /// ReleaseProfileResource
    /// </summary>
    [DataContract(Name = "ReleaseProfileResource")]
    public partial class ReleaseProfileResource : IEquatable<ReleaseProfileResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseProfileResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="required">required.</param>
        /// <param name="ignored">ignored.</param>
        /// <param name="indexerId">indexerId.</param>
        /// <param name="tags">tags.</param>
        public ReleaseProfileResource(int id = default(int), string name = default(string), bool enabled = default(bool), Object required = default(Object), Object ignored = default(Object), int indexerId = default(int), List<int> tags = default(List<int>))
        {
            this.Id = id;
            this.Name = name;
            this.Enabled = enabled;
            this.Required = required;
            this.Ignored = ignored;
            this.IndexerId = indexerId;
            this.Tags = tags;
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
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public Object Required { get; set; }

        /// <summary>
        /// Gets or Sets Ignored
        /// </summary>
        [DataMember(Name = "ignored", EmitDefaultValue = true)]
        public Object Ignored { get; set; }

        /// <summary>
        /// Gets or Sets IndexerId
        /// </summary>
        [DataMember(Name = "indexerId", EmitDefaultValue = false)]
        public int IndexerId { get; set; }

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
            sb.Append("class ReleaseProfileResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  IndexerId: ").Append(IndexerId).Append("\n");
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
            return this.Equals(input as ReleaseProfileResource);
        }

        /// <summary>
        /// Returns true if ReleaseProfileResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseProfileResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseProfileResource input)
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
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Ignored == input.Ignored ||
                    (this.Ignored != null &&
                    this.Ignored.Equals(input.Ignored))
                ) && 
                (
                    this.IndexerId == input.IndexerId ||
                    this.IndexerId.Equals(input.IndexerId)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Ignored != null)
                    hashCode = hashCode * 59 + this.Ignored.GetHashCode();
                hashCode = hashCode * 59 + this.IndexerId.GetHashCode();
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
