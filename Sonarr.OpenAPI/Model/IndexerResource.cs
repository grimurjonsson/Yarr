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
    /// IndexerResource
    /// </summary>
    [DataContract(Name = "IndexerResource")]
    public partial class IndexerResource : IEquatable<IndexerResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public DownloadProtocol? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerResource" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="fields">fields.</param>
        /// <param name="implementationName">implementationName.</param>
        /// <param name="implementation">implementation.</param>
        /// <param name="configContract">configContract.</param>
        /// <param name="infoLink">infoLink.</param>
        /// <param name="message">message.</param>
        /// <param name="tags">tags.</param>
        /// <param name="presets">presets.</param>
        /// <param name="enableRss">enableRss.</param>
        /// <param name="enableAutomaticSearch">enableAutomaticSearch.</param>
        /// <param name="enableInteractiveSearch">enableInteractiveSearch.</param>
        /// <param name="supportsRss">supportsRss.</param>
        /// <param name="supportsSearch">supportsSearch.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="priority">priority.</param>
        /// <param name="seasonSearchMaximumSingleEpisodeAge">seasonSearchMaximumSingleEpisodeAge.</param>
        /// <param name="downloadClientId">downloadClientId.</param>
        public IndexerResource(int id = default(int), string name = default(string), List<Field> fields = default(List<Field>), string implementationName = default(string), string implementation = default(string), string configContract = default(string), string infoLink = default(string), ProviderMessage message = default(ProviderMessage), List<int> tags = default(List<int>), List<IndexerResource> presets = default(List<IndexerResource>), bool enableRss = default(bool), bool enableAutomaticSearch = default(bool), bool enableInteractiveSearch = default(bool), bool supportsRss = default(bool), bool supportsSearch = default(bool), DownloadProtocol? protocol = default(DownloadProtocol?), int priority = default(int), int seasonSearchMaximumSingleEpisodeAge = default(int), int downloadClientId = default(int))
        {
            this.Id = id;
            this.Name = name;
            this.Fields = fields;
            this.ImplementationName = implementationName;
            this.Implementation = implementation;
            this.ConfigContract = configContract;
            this.InfoLink = infoLink;
            this.Message = message;
            this.Tags = tags;
            this.Presets = presets;
            this.EnableRss = enableRss;
            this.EnableAutomaticSearch = enableAutomaticSearch;
            this.EnableInteractiveSearch = enableInteractiveSearch;
            this.SupportsRss = supportsRss;
            this.SupportsSearch = supportsSearch;
            this.Protocol = protocol;
            this.Priority = priority;
            this.SeasonSearchMaximumSingleEpisodeAge = seasonSearchMaximumSingleEpisodeAge;
            this.DownloadClientId = downloadClientId;
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
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or Sets ImplementationName
        /// </summary>
        [DataMember(Name = "implementationName", EmitDefaultValue = true)]
        public string ImplementationName { get; set; }

        /// <summary>
        /// Gets or Sets Implementation
        /// </summary>
        [DataMember(Name = "implementation", EmitDefaultValue = true)]
        public string Implementation { get; set; }

        /// <summary>
        /// Gets or Sets ConfigContract
        /// </summary>
        [DataMember(Name = "configContract", EmitDefaultValue = true)]
        public string ConfigContract { get; set; }

        /// <summary>
        /// Gets or Sets InfoLink
        /// </summary>
        [DataMember(Name = "infoLink", EmitDefaultValue = true)]
        public string InfoLink { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public ProviderMessage Message { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Presets
        /// </summary>
        [DataMember(Name = "presets", EmitDefaultValue = true)]
        public List<IndexerResource> Presets { get; set; }

        /// <summary>
        /// Gets or Sets EnableRss
        /// </summary>
        [DataMember(Name = "enableRss", EmitDefaultValue = true)]
        public bool EnableRss { get; set; }

        /// <summary>
        /// Gets or Sets EnableAutomaticSearch
        /// </summary>
        [DataMember(Name = "enableAutomaticSearch", EmitDefaultValue = true)]
        public bool EnableAutomaticSearch { get; set; }

        /// <summary>
        /// Gets or Sets EnableInteractiveSearch
        /// </summary>
        [DataMember(Name = "enableInteractiveSearch", EmitDefaultValue = true)]
        public bool EnableInteractiveSearch { get; set; }

        /// <summary>
        /// Gets or Sets SupportsRss
        /// </summary>
        [DataMember(Name = "supportsRss", EmitDefaultValue = true)]
        public bool SupportsRss { get; set; }

        /// <summary>
        /// Gets or Sets SupportsSearch
        /// </summary>
        [DataMember(Name = "supportsSearch", EmitDefaultValue = true)]
        public bool SupportsSearch { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets SeasonSearchMaximumSingleEpisodeAge
        /// </summary>
        [DataMember(Name = "seasonSearchMaximumSingleEpisodeAge", EmitDefaultValue = false)]
        public int SeasonSearchMaximumSingleEpisodeAge { get; set; }

        /// <summary>
        /// Gets or Sets DownloadClientId
        /// </summary>
        [DataMember(Name = "downloadClientId", EmitDefaultValue = false)]
        public int DownloadClientId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexerResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  ImplementationName: ").Append(ImplementationName).Append("\n");
            sb.Append("  Implementation: ").Append(Implementation).Append("\n");
            sb.Append("  ConfigContract: ").Append(ConfigContract).Append("\n");
            sb.Append("  InfoLink: ").Append(InfoLink).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Presets: ").Append(Presets).Append("\n");
            sb.Append("  EnableRss: ").Append(EnableRss).Append("\n");
            sb.Append("  EnableAutomaticSearch: ").Append(EnableAutomaticSearch).Append("\n");
            sb.Append("  EnableInteractiveSearch: ").Append(EnableInteractiveSearch).Append("\n");
            sb.Append("  SupportsRss: ").Append(SupportsRss).Append("\n");
            sb.Append("  SupportsSearch: ").Append(SupportsSearch).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SeasonSearchMaximumSingleEpisodeAge: ").Append(SeasonSearchMaximumSingleEpisodeAge).Append("\n");
            sb.Append("  DownloadClientId: ").Append(DownloadClientId).Append("\n");
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
            return this.Equals(input as IndexerResource);
        }

        /// <summary>
        /// Returns true if IndexerResource instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexerResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexerResource input)
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
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.ImplementationName == input.ImplementationName ||
                    (this.ImplementationName != null &&
                    this.ImplementationName.Equals(input.ImplementationName))
                ) && 
                (
                    this.Implementation == input.Implementation ||
                    (this.Implementation != null &&
                    this.Implementation.Equals(input.Implementation))
                ) && 
                (
                    this.ConfigContract == input.ConfigContract ||
                    (this.ConfigContract != null &&
                    this.ConfigContract.Equals(input.ConfigContract))
                ) && 
                (
                    this.InfoLink == input.InfoLink ||
                    (this.InfoLink != null &&
                    this.InfoLink.Equals(input.InfoLink))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Presets == input.Presets ||
                    this.Presets != null &&
                    input.Presets != null &&
                    this.Presets.SequenceEqual(input.Presets)
                ) && 
                (
                    this.EnableRss == input.EnableRss ||
                    this.EnableRss.Equals(input.EnableRss)
                ) && 
                (
                    this.EnableAutomaticSearch == input.EnableAutomaticSearch ||
                    this.EnableAutomaticSearch.Equals(input.EnableAutomaticSearch)
                ) && 
                (
                    this.EnableInteractiveSearch == input.EnableInteractiveSearch ||
                    this.EnableInteractiveSearch.Equals(input.EnableInteractiveSearch)
                ) && 
                (
                    this.SupportsRss == input.SupportsRss ||
                    this.SupportsRss.Equals(input.SupportsRss)
                ) && 
                (
                    this.SupportsSearch == input.SupportsSearch ||
                    this.SupportsSearch.Equals(input.SupportsSearch)
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.SeasonSearchMaximumSingleEpisodeAge == input.SeasonSearchMaximumSingleEpisodeAge ||
                    this.SeasonSearchMaximumSingleEpisodeAge.Equals(input.SeasonSearchMaximumSingleEpisodeAge)
                ) && 
                (
                    this.DownloadClientId == input.DownloadClientId ||
                    this.DownloadClientId.Equals(input.DownloadClientId)
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.ImplementationName != null)
                    hashCode = hashCode * 59 + this.ImplementationName.GetHashCode();
                if (this.Implementation != null)
                    hashCode = hashCode * 59 + this.Implementation.GetHashCode();
                if (this.ConfigContract != null)
                    hashCode = hashCode * 59 + this.ConfigContract.GetHashCode();
                if (this.InfoLink != null)
                    hashCode = hashCode * 59 + this.InfoLink.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Presets != null)
                    hashCode = hashCode * 59 + this.Presets.GetHashCode();
                hashCode = hashCode * 59 + this.EnableRss.GetHashCode();
                hashCode = hashCode * 59 + this.EnableAutomaticSearch.GetHashCode();
                hashCode = hashCode * 59 + this.EnableInteractiveSearch.GetHashCode();
                hashCode = hashCode * 59 + this.SupportsRss.GetHashCode();
                hashCode = hashCode * 59 + this.SupportsSearch.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                hashCode = hashCode * 59 + this.SeasonSearchMaximumSingleEpisodeAge.GetHashCode();
                hashCode = hashCode * 59 + this.DownloadClientId.GetHashCode();
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
