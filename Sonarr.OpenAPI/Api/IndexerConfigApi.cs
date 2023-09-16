/*
 * Sonarr
 *
 * Sonarr API docs - The v3 API docs apply to both v3 and v4 versions of Sonarr. Some functionality may only be available in v4 of the Sonarr application.
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
using Sonarr.OpenAPI.Client;
using Sonarr.OpenAPI.Model;

namespace Sonarr.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIndexerConfigApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IndexerConfigResource</returns>
        IndexerConfigResource ApiV3ConfigIndexerGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>IndexerConfigResource</returns>
        IndexerConfigResource ApiV3ConfigIndexerIdGet(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerIdGetWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <returns>IndexerConfigResource</returns>
        IndexerConfigResource ApiV3ConfigIndexerIdPut(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerIdPutWithHttpInfo(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIndexerConfigApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerIdPutAsync(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerIdPutWithHttpInfoAsync(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIndexerConfigApi : IIndexerConfigApiSync, IIndexerConfigApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IndexerConfigApi : IIndexerConfigApi
    {
        private Sonarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IndexerConfigApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IndexerConfigApi(string basePath)
        {
            this.Configuration = Sonarr.OpenAPI.Client.Configuration.MergeConfigurations(
                Sonarr.OpenAPI.Client.GlobalConfiguration.Instance,
                new Sonarr.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Sonarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Sonarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Sonarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IndexerConfigApi(Sonarr.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Sonarr.OpenAPI.Client.Configuration.MergeConfigurations(
                Sonarr.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Sonarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Sonarr.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Sonarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerConfigApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IndexerConfigApi(Sonarr.OpenAPI.Client.ISynchronousClient client, Sonarr.OpenAPI.Client.IAsynchronousClient asyncClient, Sonarr.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Sonarr.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Sonarr.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Sonarr.OpenAPI.Client.ISynchronousClient Client { get; set; }

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
        public Sonarr.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sonarr.OpenAPI.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IndexerConfigResource</returns>
        public IndexerConfigResource ApiV3ConfigIndexerGet()
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = ApiV3ConfigIndexerGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        public Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerGetWithHttpInfo()
        {
            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<IndexerConfigResource>("/api/v3/config/indexer", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        public async System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = await ApiV3ConfigIndexerGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        public async System.Threading.Tasks.Task<Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<IndexerConfigResource>("/api/v3/config/indexer", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>IndexerConfigResource</returns>
        public IndexerConfigResource ApiV3ConfigIndexerIdGet(int id)
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = ApiV3ConfigIndexerIdGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        public Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerIdGetWithHttpInfo(int id)
        {
            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Sonarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<IndexerConfigResource>("/api/v3/config/indexer/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        public async System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = await ApiV3ConfigIndexerIdGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        public async System.Threading.Tasks.Task<Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Sonarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<IndexerConfigResource>("/api/v3/config/indexer/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <returns>IndexerConfigResource</returns>
        public IndexerConfigResource ApiV3ConfigIndexerIdPut(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource))
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = ApiV3ConfigIndexerIdPutWithHttpInfo(id, indexerConfigResource);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <returns>ApiResponse of IndexerConfigResource</returns>
        public Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> ApiV3ConfigIndexerIdPutWithHttpInfo(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Sonarr.OpenAPI.Client.ApiException(400, "Missing required parameter 'id' when calling IndexerConfigApi->ApiV3ConfigIndexerIdPut");

            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Sonarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = indexerConfigResource;

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<IndexerConfigResource>("/api/v3/config/indexer/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IndexerConfigResource</returns>
        public async System.Threading.Tasks.Task<IndexerConfigResource> ApiV3ConfigIndexerIdPutAsync(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource> localVarResponse = await ApiV3ConfigIndexerIdPutWithHttpInfoAsync(id, indexerConfigResource, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="indexerConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IndexerConfigResource)</returns>
        public async System.Threading.Tasks.Task<Sonarr.OpenAPI.Client.ApiResponse<IndexerConfigResource>> ApiV3ConfigIndexerIdPutWithHttpInfoAsync(string id, IndexerConfigResource indexerConfigResource = default(IndexerConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Sonarr.OpenAPI.Client.ApiException(400, "Missing required parameter 'id' when calling IndexerConfigApi->ApiV3ConfigIndexerIdPut");


            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Sonarr.OpenAPI.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = indexerConfigResource;

            // authentication (X-Api-Key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }
            // authentication (apikey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<IndexerConfigResource>("/api/v3/config/indexer/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigIndexerIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
