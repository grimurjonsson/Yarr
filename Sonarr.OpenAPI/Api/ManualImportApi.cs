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
    public interface IManualImportApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <returns>List&lt;ManualImportResource&gt;</returns>
        List<ManualImportResource> ApiV3ManualimportGet(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;ManualImportResource&gt;</returns>
        ApiResponse<List<ManualImportResource>> ApiV3ManualimportGetWithHttpInfo(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?));
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <returns></returns>
        void ApiV3ManualimportPost(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV3ManualimportPostWithHttpInfo(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManualImportApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ManualImportResource&gt;</returns>
        System.Threading.Tasks.Task<List<ManualImportResource>> ApiV3ManualimportGetAsync(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ManualImportResource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ManualImportResource>>> ApiV3ManualimportGetWithHttpInfoAsync(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV3ManualimportPostAsync(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3ManualimportPostWithHttpInfoAsync(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManualImportApi : IManualImportApiSync, IManualImportApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ManualImportApi : IManualImportApi
    {
        private Sonarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualImportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ManualImportApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualImportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ManualImportApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ManualImportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ManualImportApi(Sonarr.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ManualImportApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ManualImportApi(Sonarr.OpenAPI.Client.ISynchronousClient client, Sonarr.OpenAPI.Client.IAsynchronousClient asyncClient, Sonarr.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <returns>List&lt;ManualImportResource&gt;</returns>
        public List<ManualImportResource> ApiV3ManualimportGet(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?))
        {
            Sonarr.OpenAPI.Client.ApiResponse<List<ManualImportResource>> localVarResponse = ApiV3ManualimportGetWithHttpInfo(folder, downloadId, seriesId, seasonNumber, filterExistingFiles);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;ManualImportResource&gt;</returns>
        public Sonarr.OpenAPI.Client.ApiResponse<List<ManualImportResource>> ApiV3ManualimportGetWithHttpInfo(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?))
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

            if (folder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "folder", folder));
            }
            if (downloadId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "downloadId", downloadId));
            }
            if (seriesId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "seriesId", seriesId));
            }
            if (seasonNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "seasonNumber", seasonNumber));
            }
            if (filterExistingFiles != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "filterExistingFiles", filterExistingFiles));
            }

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
            var localVarResponse = this.Client.Get<List<ManualImportResource>>("/api/v3/manualimport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ManualimportGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ManualImportResource&gt;</returns>
        public async System.Threading.Tasks.Task<List<ManualImportResource>> ApiV3ManualimportGetAsync(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Sonarr.OpenAPI.Client.ApiResponse<List<ManualImportResource>> localVarResponse = await ApiV3ManualimportGetWithHttpInfoAsync(folder, downloadId, seriesId, seasonNumber, filterExistingFiles, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folder"> (optional)</param>
        /// <param name="downloadId"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="seasonNumber"> (optional)</param>
        /// <param name="filterExistingFiles"> (optional, default to true)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ManualImportResource&gt;)</returns>
        public async System.Threading.Tasks.Task<Sonarr.OpenAPI.Client.ApiResponse<List<ManualImportResource>>> ApiV3ManualimportGetWithHttpInfoAsync(string folder = default(string), string downloadId = default(string), int? seriesId = default(int?), int? seasonNumber = default(int?), bool? filterExistingFiles = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (folder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "folder", folder));
            }
            if (downloadId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "downloadId", downloadId));
            }
            if (seriesId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "seriesId", seriesId));
            }
            if (seasonNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "seasonNumber", seasonNumber));
            }
            if (filterExistingFiles != null)
            {
                localVarRequestOptions.QueryParameters.Add(Sonarr.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "filterExistingFiles", filterExistingFiles));
            }

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ManualImportResource>>("/api/v3/manualimport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ManualimportGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <returns></returns>
        public void ApiV3ManualimportPost(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>))
        {
            ApiV3ManualimportPostWithHttpInfo(manualImportReprocessResource);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Sonarr.OpenAPI.Client.ApiResponse<Object> ApiV3ManualimportPostWithHttpInfo(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>))
        {
            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = manualImportReprocessResource;

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
            var localVarResponse = this.Client.Post<Object>("/api/v3/manualimport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ManualimportPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV3ManualimportPostAsync(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiV3ManualimportPostWithHttpInfoAsync(manualImportReprocessResource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Sonarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manualImportReprocessResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Sonarr.OpenAPI.Client.ApiResponse<Object>> ApiV3ManualimportPostWithHttpInfoAsync(List<ManualImportReprocessResource> manualImportReprocessResource = default(List<ManualImportReprocessResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Sonarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Sonarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sonarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = manualImportReprocessResource;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/v3/manualimport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3ManualimportPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}