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
    /// LogResourcePagingResource
    /// </summary>
    [DataContract(Name = "LogResourcePagingResource")]
    public partial class LogResourcePagingResource : IEquatable<LogResourcePagingResource>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirection? SortDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogResourcePagingResource" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="sortKey">sortKey.</param>
        /// <param name="sortDirection">sortDirection.</param>
        /// <param name="filters">filters.</param>
        /// <param name="totalRecords">totalRecords.</param>
        /// <param name="records">records.</param>
        public LogResourcePagingResource(int page = default(int), int pageSize = default(int), string sortKey = default(string), SortDirection? sortDirection = default(SortDirection?), List<PagingResourceFilter> filters = default(List<PagingResourceFilter>), int totalRecords = default(int), List<LogResource> records = default(List<LogResource>))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.SortKey = sortKey;
            this.SortDirection = sortDirection;
            this.Filters = filters;
            this.TotalRecords = totalRecords;
            this.Records = records;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets SortKey
        /// </summary>
        [DataMember(Name = "sortKey", EmitDefaultValue = true)]
        public string SortKey { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public List<PagingResourceFilter> Filters { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = true)]
        public List<LogResource> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogResourcePagingResource {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SortKey: ").Append(SortKey).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as LogResourcePagingResource);
        }

        /// <summary>
        /// Returns true if LogResourcePagingResource instances are equal
        /// </summary>
        /// <param name="input">Instance of LogResourcePagingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogResourcePagingResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.SortDirection == input.SortDirection ||
                    this.SortDirection.Equals(input.SortDirection)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.TotalRecords == input.TotalRecords ||
                    this.TotalRecords.Equals(input.TotalRecords)
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                hashCode = hashCode * 59 + this.Page.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDirection.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
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
