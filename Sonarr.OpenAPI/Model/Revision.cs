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
    /// Revision
    /// </summary>
    [DataContract(Name = "Revision")]
    public partial class Revision : IEquatable<Revision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="real">real.</param>
        /// <param name="isRepack">isRepack.</param>
        public Revision(int version = default(int), int real = default(int), bool isRepack = default(bool))
        {
            this._Version = version;
            this.Real = real;
            this.IsRepack = isRepack;
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets Real
        /// </summary>
        [DataMember(Name = "real", EmitDefaultValue = false)]
        public int Real { get; set; }

        /// <summary>
        /// Gets or Sets IsRepack
        /// </summary>
        [DataMember(Name = "isRepack", EmitDefaultValue = true)]
        public bool IsRepack { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Revision {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Real: ").Append(Real).Append("\n");
            sb.Append("  IsRepack: ").Append(IsRepack).Append("\n");
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
            return this.Equals(input as Revision);
        }

        /// <summary>
        /// Returns true if Revision instances are equal
        /// </summary>
        /// <param name="input">Instance of Revision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Revision input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Real == input.Real ||
                    this.Real.Equals(input.Real)
                ) && 
                (
                    this.IsRepack == input.IsRepack ||
                    this.IsRepack.Equals(input.IsRepack)
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
                hashCode = hashCode * 59 + this._Version.GetHashCode();
                hashCode = hashCode * 59 + this.Real.GetHashCode();
                hashCode = hashCode * 59 + this.IsRepack.GetHashCode();
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
