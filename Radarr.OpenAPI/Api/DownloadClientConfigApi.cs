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
    public interface IDownloadClientConfigApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DownloadClientConfigResource</returns>
        DownloadClientConfigResource ApiV3ConfigDownloadclientGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>DownloadClientConfigResource</returns>
        DownloadClientConfigResource ApiV3ConfigDownloadclientIdGet(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdGetWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <returns>DownloadClientConfigResource</returns>
        DownloadClientConfigResource ApiV3ConfigDownloadclientIdPut(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdPutWithHttpInfo(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDownloadClientConfigApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadClientConfigResource</returns>
        System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadClientConfigResource</returns>
        System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadClientConfigResource</returns>
        System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdPutAsync(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientIdPutWithHttpInfoAsync(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDownloadClientConfigApi : IDownloadClientConfigApiSync, IDownloadClientConfigApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DownloadClientConfigApi : IDownloadClientConfigApi
    {
        private Radarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadClientConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DownloadClientConfigApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadClientConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DownloadClientConfigApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DownloadClientConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DownloadClientConfigApi(Radarr.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DownloadClientConfigApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DownloadClientConfigApi(Radarr.OpenAPI.Client.ISynchronousClient client, Radarr.OpenAPI.Client.IAsynchronousClient asyncClient, Radarr.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// <returns>DownloadClientConfigResource</returns>
        public DownloadClientConfigResource ApiV3ConfigDownloadclientGet()
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = ApiV3ConfigDownloadclientGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        public Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientGetWithHttpInfo()
        {
            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = this.Client.Get<DownloadClientConfigResource>("/api/v3/config/downloadclient", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadClientConfigResource</returns>
        public async System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = await ApiV3ConfigDownloadclientGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DownloadClientConfigResource>("/api/v3/config/downloadclient", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>DownloadClientConfigResource</returns>
        public DownloadClientConfigResource ApiV3ConfigDownloadclientIdGet(int id)
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = ApiV3ConfigDownloadclientIdGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        public Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdGetWithHttpInfo(int id)
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
            var localVarResponse = this.Client.Get<DownloadClientConfigResource>("/api/v3/config/downloadclient/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientIdGet", localVarResponse);
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
        /// <returns>Task of DownloadClientConfigResource</returns>
        public async System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdGetAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = await ApiV3ConfigDownloadclientIdGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientIdGetWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DownloadClientConfigResource>("/api/v3/config/downloadclient/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <returns>DownloadClientConfigResource</returns>
        public DownloadClientConfigResource ApiV3ConfigDownloadclientIdPut(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource))
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = ApiV3ConfigDownloadclientIdPutWithHttpInfo(id, downloadClientConfigResource);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <returns>ApiResponse of DownloadClientConfigResource</returns>
        public Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdPutWithHttpInfo(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Radarr.OpenAPI.Client.ApiException(400, "Missing required parameter 'id' when calling DownloadClientConfigApi->ApiV3ConfigDownloadclientIdPut");

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = downloadClientConfigResource;

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
            var localVarResponse = this.Client.Put<DownloadClientConfigResource>("/api/v3/config/downloadclient/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadClientConfigResource</returns>
        public async System.Threading.Tasks.Task<DownloadClientConfigResource> ApiV3ConfigDownloadclientIdPutAsync(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource> localVarResponse = await ApiV3ConfigDownloadclientIdPutWithHttpInfoAsync(id, downloadClientConfigResource, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="downloadClientConfigResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadClientConfigResource)</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<DownloadClientConfigResource>> ApiV3ConfigDownloadclientIdPutWithHttpInfoAsync(string id, DownloadClientConfigResource downloadClientConfigResource = default(DownloadClientConfigResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Radarr.OpenAPI.Client.ApiException(400, "Missing required parameter 'id' when calling DownloadClientConfigApi->ApiV3ConfigDownloadclientIdPut");


            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = downloadClientConfigResource;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<DownloadClientConfigResource>("/api/v3/config/downloadclient/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ConfigDownloadclientIdPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
