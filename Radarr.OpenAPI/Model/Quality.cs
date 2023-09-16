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
    /// Quality
    /// </summary>
    [DataContract(Name = "Quality")]
    public partial class Quality : IEquatable<Quality>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public QualitySource? Source { get; set; }

        /// <summary>
        /// Gets or Sets Modifier
        /// </summary>
        [DataMember(Name = "modifier", EmitDefaultValue = false)]
        public Modifier? Modifier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quality" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="source">source.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="modifier">modifier.</param>
        public Quality(int id = default(int), string name = default(string), QualitySource? source = default(QualitySource?), int resolution = default(int), Modifier? modifier = default(Modifier?))
        {
            this.Id = id;
            this.Name = name;
            this.Source = source;
            this.Resolution = resolution;
            this.Modifier = modifier;
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
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name = "resolution", EmitDefaultValue = false)]
        public int Resolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quality {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
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
            return this.Equals(input as Quality);
        }

        /// <summary>
        /// Returns true if Quality instances are equal
        /// </summary>
        /// <param name="input">Instance of Quality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quality input)
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
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    this.Resolution.Equals(input.Resolution)
                ) && 
                (
                    this.Modifier == input.Modifier ||
                    this.Modifier.Equals(input.Modifier)
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
                hashCode = hashCode * 59 + this.Source.GetHashCode();
                hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                hashCode = hashCode * 59 + this.Modifier.GetHashCode();
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
