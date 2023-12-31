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
    /// Field
    /// </summary>
    [DataContract(Name = "Field")]
    public partial class Field : IEquatable<Field>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public PrivacyLevel? Privacy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="order">order.</param>
        /// <param name="name">name.</param>
        /// <param name="label">label.</param>
        /// <param name="unit">unit.</param>
        /// <param name="helpText">helpText.</param>
        /// <param name="helpTextWarning">helpTextWarning.</param>
        /// <param name="helpLink">helpLink.</param>
        /// <param name="value">value.</param>
        /// <param name="type">type.</param>
        /// <param name="advanced">advanced.</param>
        /// <param name="selectOptions">selectOptions.</param>
        /// <param name="selectOptionsProviderAction">selectOptionsProviderAction.</param>
        /// <param name="section">section.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="isFloat">isFloat.</param>
        public Field(int order = default(int), string name = default(string), string label = default(string), string unit = default(string), string helpText = default(string), string helpTextWarning = default(string), string helpLink = default(string), Object value = default(Object), string type = default(string), bool advanced = default(bool), List<SelectOption> selectOptions = default(List<SelectOption>), string selectOptionsProviderAction = default(string), string section = default(string), string hidden = default(string), PrivacyLevel? privacy = default(PrivacyLevel?), string placeholder = default(string), bool isFloat = default(bool))
        {
            this.Order = order;
            this.Name = name;
            this.Label = label;
            this.Unit = unit;
            this.HelpText = helpText;
            this.HelpTextWarning = helpTextWarning;
            this.HelpLink = helpLink;
            this.Value = value;
            this.Type = type;
            this.Advanced = advanced;
            this.SelectOptions = selectOptions;
            this.SelectOptionsProviderAction = selectOptionsProviderAction;
            this.Section = section;
            this.Hidden = hidden;
            this.Privacy = privacy;
            this.Placeholder = placeholder;
            this.IsFloat = isFloat;
        }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "helpText", EmitDefaultValue = true)]
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or Sets HelpTextWarning
        /// </summary>
        [DataMember(Name = "helpTextWarning", EmitDefaultValue = true)]
        public string HelpTextWarning { get; set; }

        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name = "helpLink", EmitDefaultValue = true)]
        public string HelpLink { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = true)]
        public bool Advanced { get; set; }

        /// <summary>
        /// Gets or Sets SelectOptions
        /// </summary>
        [DataMember(Name = "selectOptions", EmitDefaultValue = true)]
        public List<SelectOption> SelectOptions { get; set; }

        /// <summary>
        /// Gets or Sets SelectOptionsProviderAction
        /// </summary>
        [DataMember(Name = "selectOptionsProviderAction", EmitDefaultValue = true)]
        public string SelectOptionsProviderAction { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name = "section", EmitDefaultValue = true)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public string Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = true)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets IsFloat
        /// </summary>
        [DataMember(Name = "isFloat", EmitDefaultValue = true)]
        public bool IsFloat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Field {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            sb.Append("  HelpTextWarning: ").Append(HelpTextWarning).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  SelectOptions: ").Append(SelectOptions).Append("\n");
            sb.Append("  SelectOptionsProviderAction: ").Append(SelectOptionsProviderAction).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  IsFloat: ").Append(IsFloat).Append("\n");
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
            return this.Equals(input as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="input">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.HelpText == input.HelpText ||
                    (this.HelpText != null &&
                    this.HelpText.Equals(input.HelpText))
                ) && 
                (
                    this.HelpTextWarning == input.HelpTextWarning ||
                    (this.HelpTextWarning != null &&
                    this.HelpTextWarning.Equals(input.HelpTextWarning))
                ) && 
                (
                    this.HelpLink == input.HelpLink ||
                    (this.HelpLink != null &&
                    this.HelpLink.Equals(input.HelpLink))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Advanced == input.Advanced ||
                    this.Advanced.Equals(input.Advanced)
                ) && 
                (
                    this.SelectOptions == input.SelectOptions ||
                    this.SelectOptions != null &&
                    input.SelectOptions != null &&
                    this.SelectOptions.SequenceEqual(input.SelectOptions)
                ) && 
                (
                    this.SelectOptionsProviderAction == input.SelectOptionsProviderAction ||
                    (this.SelectOptionsProviderAction != null &&
                    this.SelectOptionsProviderAction.Equals(input.SelectOptionsProviderAction))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.Placeholder == input.Placeholder ||
                    (this.Placeholder != null &&
                    this.Placeholder.Equals(input.Placeholder))
                ) && 
                (
                    this.IsFloat == input.IsFloat ||
                    this.IsFloat.Equals(input.IsFloat)
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
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.HelpText != null)
                    hashCode = hashCode * 59 + this.HelpText.GetHashCode();
                if (this.HelpTextWarning != null)
                    hashCode = hashCode * 59 + this.HelpTextWarning.GetHashCode();
                if (this.HelpLink != null)
                    hashCode = hashCode * 59 + this.HelpLink.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Advanced.GetHashCode();
                if (this.SelectOptions != null)
                    hashCode = hashCode * 59 + this.SelectOptions.GetHashCode();
                if (this.SelectOptionsProviderAction != null)
                    hashCode = hashCode * 59 + this.SelectOptionsProviderAction.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.Placeholder != null)
                    hashCode = hashCode * 59 + this.Placeholder.GetHashCode();
                hashCode = hashCode * 59 + this.IsFloat.GetHashCode();
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
