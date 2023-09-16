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
    /// UpdateChanges
    /// </summary>
    [DataContract(Name = "UpdateChanges")]
    public partial class UpdateChanges : IEquatable<UpdateChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChanges" /> class.
        /// </summary>
        /// <param name="_new">_new.</param>
        /// <param name="_fixed">_fixed.</param>
        public UpdateChanges(List<string> _new = default(List<string>), List<string> _fixed = default(List<string>))
        {
            this.New = _new;
            this.Fixed = _fixed;
        }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", EmitDefaultValue = true)]
        public List<string> New { get; set; }

        /// <summary>
        /// Gets or Sets Fixed
        /// </summary>
        [DataMember(Name = "fixed", EmitDefaultValue = true)]
        public List<string> Fixed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateChanges {\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Fixed: ").Append(Fixed).Append("\n");
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
            return this.Equals(input as UpdateChanges);
        }

        /// <summary>
        /// Returns true if UpdateChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.New == input.New ||
                    this.New != null &&
                    input.New != null &&
                    this.New.SequenceEqual(input.New)
                ) && 
                (
                    this.Fixed == input.Fixed ||
                    this.Fixed != null &&
                    input.Fixed != null &&
                    this.Fixed.SequenceEqual(input.Fixed)
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
                if (this.New != null)
                    hashCode = hashCode * 59 + this.New.GetHashCode();
                if (this.Fixed != null)
                    hashCode = hashCode * 59 + this.Fixed.GetHashCode();
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
