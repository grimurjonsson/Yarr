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
using Radarr.OpenAPI.Model;

namespace Radarr.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IParseApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <returns>ParseResource</returns>
        ParseResource ApiV3ParseGet(string title = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <returns>ApiResponse of ParseResource</returns>
        ApiResponse<ParseResource> ApiV3ParseGetWithHttpInfo(string title = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IParseApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ParseResource</returns>
        System.Threading.Tasks.Task<ParseResource> ApiV3ParseGetAsync(string title = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ParseResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParseResource>> ApiV3ParseGetWithHttpInfoAsync(string title = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IParseApi : IParseApiSync, IParseApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ParseApi : IParseApi
    {
        private Radarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParseApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParseApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ParseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ParseApi(Radarr.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ParseApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ParseApi(Radarr.OpenAPI.Client.ISynchronousClient client, Radarr.OpenAPI.Client.IAsynchronousClient asyncClient, Radarr.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// <param name="title"> (optional)</param>
        /// <returns>ParseResource</returns>
        public ParseResource ApiV3ParseGet(string title = default(string))
        {
            Radarr.OpenAPI.Client.ApiResponse<ParseResource> localVarResponse = ApiV3ParseGetWithHttpInfo(title);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <returns>ApiResponse of ParseResource</returns>
        public Radarr.OpenAPI.Client.ApiResponse<ParseResource> ApiV3ParseGetWithHttpInfo(string title = default(string))
        {
            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (title != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "title", title));
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
            var localVarResponse = this.Client.Get<ParseResource>("/api/v3/parse", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ParseGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ParseResource</returns>
        public async System.Threading.Tasks.Task<ParseResource> ApiV3ParseGetAsync(string title = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<ParseResource> localVarResponse = await ApiV3ParseGetWithHttpInfoAsync(title, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ParseResource)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<ParseResource>> ApiV3ParseGetWithHttpInfoAsync(string title = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (title != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "title", title));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ParseResource>("/api/v3/parse", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ParseGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
