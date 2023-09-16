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
    public interface IAlternativeTitleApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <returns>List&lt;AlternativeTitleResource&gt;</returns>
        List<AlternativeTitleResource> ApiV3AlttitleGet(int? movieId = default(int?), int? movieMetadataId = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;AlternativeTitleResource&gt;</returns>
        ApiResponse<List<AlternativeTitleResource>> ApiV3AlttitleGetWithHttpInfo(int? movieId = default(int?), int? movieMetadataId = default(int?));
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>AlternativeTitleResource</returns>
        AlternativeTitleResource ApiV3AlttitleIdGet(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of AlternativeTitleResource</returns>
        ApiResponse<AlternativeTitleResource> ApiV3AlttitleIdGetWithHttpInfo(int id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlternativeTitleApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AlternativeTitleResource&gt;</returns>
        System.Threading.Tasks.Task<List<AlternativeTitleResource>> ApiV3AlttitleGetAsync(int? movieId = default(int?), int? movieMetadataId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AlternativeTitleResource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AlternativeTitleResource>>> ApiV3AlttitleGetWithHttpInfoAsync(int? movieId = default(int?), int? movieMetadataId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AlternativeTitleResource</returns>
        System.Threading.Tasks.Task<AlternativeTitleResource> ApiV3AlttitleIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AlternativeTitleResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlternativeTitleResource>> ApiV3AlttitleIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlternativeTitleApi : IAlternativeTitleApiSync, IAlternativeTitleApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlternativeTitleApi : IAlternativeTitleApi
    {
        private Radarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeTitleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlternativeTitleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeTitleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlternativeTitleApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlternativeTitleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlternativeTitleApi(Radarr.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlternativeTitleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlternativeTitleApi(Radarr.OpenAPI.Client.ISynchronousClient client, Radarr.OpenAPI.Client.IAsynchronousClient asyncClient, Radarr.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <returns>List&lt;AlternativeTitleResource&gt;</returns>
        public List<AlternativeTitleResource> ApiV3AlttitleGet(int? movieId = default(int?), int? movieMetadataId = default(int?))
        {
            Radarr.OpenAPI.Client.ApiResponse<List<AlternativeTitleResource>> localVarResponse = ApiV3AlttitleGetWithHttpInfo(movieId, movieMetadataId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <returns>ApiResponse of List&lt;AlternativeTitleResource&gt;</returns>
        public Radarr.OpenAPI.Client.ApiResponse<List<AlternativeTitleResource>> ApiV3AlttitleGetWithHttpInfo(int? movieId = default(int?), int? movieMetadataId = default(int?))
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

            if (movieId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "movieId", movieId));
            }
            if (movieMetadataId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "movieMetadataId", movieMetadataId));
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
            var localVarResponse = this.Client.Get<List<AlternativeTitleResource>>("/api/v3/alttitle", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3AlttitleGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AlternativeTitleResource&gt;</returns>
        public async System.Threading.Tasks.Task<List<AlternativeTitleResource>> ApiV3AlttitleGetAsync(int? movieId = default(int?), int? movieMetadataId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<List<AlternativeTitleResource>> localVarResponse = await ApiV3AlttitleGetWithHttpInfoAsync(movieId, movieMetadataId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieId"> (optional)</param>
        /// <param name="movieMetadataId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AlternativeTitleResource&gt;)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<List<AlternativeTitleResource>>> ApiV3AlttitleGetWithHttpInfoAsync(int? movieId = default(int?), int? movieMetadataId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (movieId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "movieId", movieId));
            }
            if (movieMetadataId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Radarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "movieMetadataId", movieMetadataId));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AlternativeTitleResource>>("/api/v3/alttitle", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3AlttitleGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>AlternativeTitleResource</returns>
        public AlternativeTitleResource ApiV3AlttitleIdGet(int id)
        {
            Radarr.OpenAPI.Client.ApiResponse<AlternativeTitleResource> localVarResponse = ApiV3AlttitleIdGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of AlternativeTitleResource</returns>
        public Radarr.OpenAPI.Client.ApiResponse<AlternativeTitleResource> ApiV3AlttitleIdGetWithHttpInfo(int id)
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

            localVarRequestOptions.PathParameters.Add("id", Radarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = this.Client.Get<AlternativeTitleResource>("/api/v3/alttitle/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3AlttitleIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AlternativeTitleResource</returns>
        public async System.Threading.Tasks.Task<AlternativeTitleResource> ApiV3AlttitleIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<AlternativeTitleResource> localVarResponse = await ApiV3AlttitleIdGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AlternativeTitleResource)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<AlternativeTitleResource>> ApiV3AlttitleIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("id", Radarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<AlternativeTitleResource>("/api/v3/alttitle/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3AlttitleIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
