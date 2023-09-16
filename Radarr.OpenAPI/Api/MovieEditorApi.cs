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
    public interface IMovieEditorApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns></returns>
        void ApiV3MovieEditorDelete(MovieEditorResource movieEditorResource = default(MovieEditorResource));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV3MovieEditorDeleteWithHttpInfo(MovieEditorResource movieEditorResource = default(MovieEditorResource));
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns></returns>
        void ApiV3MovieEditorPut(MovieEditorResource movieEditorResource = default(MovieEditorResource));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiV3MovieEditorPutWithHttpInfo(MovieEditorResource movieEditorResource = default(MovieEditorResource));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMovieEditorApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV3MovieEditorDeleteAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3MovieEditorDeleteWithHttpInfoAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiV3MovieEditorPutAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiV3MovieEditorPutWithHttpInfoAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMovieEditorApi : IMovieEditorApiSync, IMovieEditorApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MovieEditorApi : IMovieEditorApi
    {
        private Radarr.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieEditorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MovieEditorApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieEditorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MovieEditorApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MovieEditorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MovieEditorApi(Radarr.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MovieEditorApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MovieEditorApi(Radarr.OpenAPI.Client.ISynchronousClient client, Radarr.OpenAPI.Client.IAsynchronousClient asyncClient, Radarr.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns></returns>
        public void ApiV3MovieEditorDelete(MovieEditorResource movieEditorResource = default(MovieEditorResource))
        {
            ApiV3MovieEditorDeleteWithHttpInfo(movieEditorResource);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Radarr.OpenAPI.Client.ApiResponse<Object> ApiV3MovieEditorDeleteWithHttpInfo(MovieEditorResource movieEditorResource = default(MovieEditorResource))
        {
            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = movieEditorResource;

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
            var localVarResponse = this.Client.Delete<Object>("/api/v3/movie/editor", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3MovieEditorDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV3MovieEditorDeleteAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiV3MovieEditorDeleteWithHttpInfoAsync(movieEditorResource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<Object>> ApiV3MovieEditorDeleteWithHttpInfoAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = movieEditorResource;

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/v3/movie/editor", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3MovieEditorDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns></returns>
        public void ApiV3MovieEditorPut(MovieEditorResource movieEditorResource = default(MovieEditorResource))
        {
            ApiV3MovieEditorPutWithHttpInfo(movieEditorResource);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Radarr.OpenAPI.Client.ApiResponse<Object> ApiV3MovieEditorPutWithHttpInfo(MovieEditorResource movieEditorResource = default(MovieEditorResource))
        {
            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = movieEditorResource;

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
            var localVarResponse = this.Client.Put<Object>("/api/v3/movie/editor", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3MovieEditorPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiV3MovieEditorPutAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiV3MovieEditorPutWithHttpInfoAsync(movieEditorResource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Radarr.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movieEditorResource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Radarr.OpenAPI.Client.ApiResponse<Object>> ApiV3MovieEditorPutWithHttpInfoAsync(MovieEditorResource movieEditorResource = default(MovieEditorResource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Radarr.OpenAPI.Client.RequestOptions localVarRequestOptions = new Radarr.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Radarr.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = movieEditorResource;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/v3/movie/editor", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV3MovieEditorPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
