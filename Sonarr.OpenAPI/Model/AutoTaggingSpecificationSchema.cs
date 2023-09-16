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
    /// AutoTaggingSpecificationSchema
    /// </summary>
    [DataContract(Name = "AutoTaggingSpecificationSchema")]
    public partial class AutoTaggingSpecificationSchema : IEquatable<AutoTaggingSpecificationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTaggingSpecificationSchema" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="implementation">implementation.</param>
        /// <param name="implementationName">implementationName.</param>
        /// <param name="negate">negate.</param>
        /// <param name="required">required.</param>
        /// <param name="fields">fields.</param>
        public AutoTaggingSpecificationSchema(int id = default(int), string name = default(string), string implementation = default(string), string implementationName = default(string), bool negate = default(bool), bool required = default(bool), List<Field> fields = default(List<Field>))
        {
            this.Id = id;
            this.Name = name;
            this.Implementation = implementation;
            this.ImplementationName = implementationName;
            this.Negate = negate;
            this.Required = required;
            this.Fields = fields;
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
        /// Gets or Sets Implementation
        /// </summary>
        [DataMember(Name = "implementation", EmitDefaultValue = true)]
        public string Implementation { get; set; }

        /// <summary>
        /// Gets or Sets ImplementationName
        /// </summary>
        [DataMember(Name = "implementationName", EmitDefaultValue = true)]
        public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or Sets Negate
        /// </summary>
        [DataMember(Name = "negate", EmitDefaultValue = true)]
        public bool Negate { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoTaggingSpecificationSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Implementation: ").Append(Implementation).Append("\n");
            sb.Append("  ImplementationName: ").Append(ImplementationName).Append("\n");
            sb.Append("  Negate: ").Append(Negate).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as AutoTaggingSpecificationSchema);
        }

        /// <summary>
        /// Returns true if AutoTaggingSpecificationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTaggingSpecificationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTaggingSpecificationSchema input)
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
                    this.Implementation == input.Implementation ||
                    (this.Implementation != null &&
                    this.Implementation.Equals(input.Implementation))
                ) && 
                (
                    this.ImplementationName == input.ImplementationName ||
                    (this.ImplementationName != null &&
                    this.ImplementationName.Equals(input.ImplementationName))
                ) && 
                (
                    this.Negate == input.Negate ||
                    this.Negate.Equals(input.Negate)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Implementation != null)
                    hashCode = hashCode * 59 + this.Implementation.GetHashCode();
                if (this.ImplementationName != null)
                    hashCode = hashCode * 59 + this.ImplementationName.GetHashCode();
                hashCode = hashCode * 59 + this.Negate.GetHashCode();
                hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
