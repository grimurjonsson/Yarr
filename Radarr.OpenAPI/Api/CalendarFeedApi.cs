/*
 * Radarr
 *
 * Radarr API docs
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Radarr.OpenAPI.Client;

namespace Radarr.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICalendarFeedApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <returns></returns>
        void FeedV3CalendarRadarrIcsGet(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FeedV3CalendarRadarrIcsGetWithHttpInfo(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICalendarFeedApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FeedV3CalendarRadarrIcsGetAsync(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FeedV3CalendarRadarrIcsGetWithHttpInfoAsync(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICalendarFeedApi : ICalendarFeedApiSync, ICalendarFeedApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CalendarFeedApi : ICalendarFeedApi
    {
        private Radarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarFeedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CalendarFeedApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarFeedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CalendarFeedApi(string basePath)
        {
            this.Configuration = Radarr.OpenAPI.Client.Configuration.MergeConfigurations(
                Radarr.OpenAPI.Client.GlobalConfiguration.Instance,
                new Radarr.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Radarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Radarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Radarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarFeedApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CalendarFeedApi(Radarr.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Radarr.OpenAPI.Client.Configuration.MergeConfigurations(
                Radarr.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Radarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Radarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Radarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarFeedApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CalendarFeedApi(Radarr.OpenAPI.Client.ISynchronousClient client, Radarr.OpenAPI.Client.IAsynchronousClient asyncClient, Radarr.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Radarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Radarr.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Radarr.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Radarr.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Radarr.OpenAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <returns></returns>
        public void FeedV3CalendarRadarrIcsGet(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?))
        {
            FeedV3CalendarRadarrIcsGetWithHttpInfo(pastDays, futureDays, tags, unmonitored);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Radarr.OpenAPI.Client.ApiResponse<Object> FeedV3CalendarRadarrIcsGetWithHttpInfo(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?))
        {
            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (pastDays != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "pastDays", pastDays));
            }
            if (futureDays != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "futureDays", futureDays));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (unmonitored != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "unmonitored", unmonitored));
            }

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/feed/v3/calendar/radarr.ics", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FeedV3CalendarRadarrIcsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FeedV3CalendarRadarrIcsGetAsync(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await FeedV3CalendarRadarrIcsGetWithHttpInfoAsync(pastDays, futureDays, tags, unmonitored, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pastDays"> (optional, default to 7)</param>
        /// <param name="futureDays"> (optional, default to 28)</param>
        /// <param name="tags"> (optional, default to &quot;&quot;)</param>
        /// <param name="unmonitored"> (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<Object>> FeedV3CalendarRadarrIcsGetWithHttpInfoAsync(int? pastDays = default(int?), int? futureDays = default(int?), string tags = default(string), bool? unmonitored = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (pastDays != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "pastDays", pastDays));
            }
            if (futureDays != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "futureDays", futureDays));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (unmonitored != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "unmonitored", unmonitored));
            }

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/feed/v3/calendar/radarr.ics", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FeedV3CalendarRadarrIcsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}