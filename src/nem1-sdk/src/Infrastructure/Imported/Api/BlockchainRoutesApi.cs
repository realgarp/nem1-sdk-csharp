/* 
 * NIS1 API
 *
 * This document defines all the nis1 api routes and behaviour
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kodtycoon@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using io.nem1.sdk.Infrastructure.Imported.Client;
using io.nem1.sdk.Infrastructure.Mapping;
using io.nem1.sdk.Model.Blockchain;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace io.nem1.sdk.Infrastructure.Imported.Api
{
    /// <exclude />
    internal interface IBlockchainRoutesApi : IApiAccessor
    {
        
        #region Asynchronous Operations
        /// <summary>
        /// Getting a block with a given height
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Height at which to retrieve a block</param>
        /// <returns>Task of BlockDTO</returns>
        System.Threading.Tasks.Task<BlockInfo> BlockAtHeightAsync (ulong body);

        /// <summary>
        /// Getting a block with a given height
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Height at which to retrieve a block</param>
        /// <returns>Task of ApiResponse (BlockDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BlockAtHeightAsyncWithHttpInfo (JObject body);
        /// <summary>
        /// Get current chain height
        /// </summary>
        /// <remarks>
        /// Returns the current chain height
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainHeightDTO</returns>
        System.Threading.Tasks.Task<ulong> CurrentChainHeightAsync ();

        /// <summary>
        /// Get current chain height
        /// </summary>
        /// <remarks>
        /// Returns the current chain height
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainHeightDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CurrentChainHeightAsyncWithHttpInfo ();
        /// <summary>
        /// Getting current chain score
        /// </summary>
        /// <remarks>
        /// Returns the current chain score
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainScoreDTO</returns>
        System.Threading.Tasks.Task<string> CurrentChainScoreAsync ();

        /// <summary>
        /// Getting current chain score
        /// </summary>
        /// <remarks>
        /// Returns the current chain score
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainScoreDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CurrentChainScoreAsyncWithHttpInfo ();
        /// <summary>
        /// Get current chain height
        /// </summary>
        /// <remarks>
        /// Returns the current chain height
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BlockDTO</returns>
        System.Threading.Tasks.Task<BlockInfo> LastBlockAsync ();

        /// <summary>
        /// Get current chain height
        /// </summary>
        /// <remarks>
        /// Returns the current chain height
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BlockDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> LastBlockAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <exclude />
    internal class BlockchainRoutesApi : IBlockchainRoutesApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockchainRoutesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlockchainRoutesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockchainRoutesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        internal BlockchainRoutesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

       
        /// <summary>
        /// Getting a block with a given height 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Height at which to retrieve a block</param>
        /// <returns>Task of BlockDTO</returns>
        public async System.Threading.Tasks.Task<BlockInfo> BlockAtHeightAsync (ulong body)
        {
             ApiResponse<string> localVarResponse = await BlockAtHeightAsyncWithHttpInfo(JObject.Parse("{\"height\":" + body + "}"));
             return new BlockMapping().Apply(localVarResponse.Data);

        }

        /// <summary>
        /// Getting a block with a given height 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Height at which to retrieve a block</param>
        /// <returns>Task of ApiResponse (BlockDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BlockAtHeightAsyncWithHttpInfo (JObject body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BlockchainRoutesApi->BlockAtHeight");

            var localVarPath = "/block/at/public";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BlockAtHeight", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

       
        /// <summary>
        /// Get current chain height Returns the current chain height
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainHeightDTO</returns>
        public async System.Threading.Tasks.Task<ulong> CurrentChainHeightAsync ()
        {
             ApiResponse<string> localVarResponse = await CurrentChainHeightAsyncWithHttpInfo();
             return ulong.Parse(JObject.Parse(localVarResponse.Data)["height"].ToString());

        }

        /// <summary>
        /// Get current chain height Returns the current chain height
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainHeightDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CurrentChainHeightAsyncWithHttpInfo ()
        {

            var localVarPath = "/chain/height";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CurrentChainHeight", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

       

        /// <summary>
        /// Getting current chain score Returns the current chain score
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainScoreDTO</returns>
        public async System.Threading.Tasks.Task<string> CurrentChainScoreAsync ()
        {
             ApiResponse<string> localVarResponse = await CurrentChainScoreAsyncWithHttpInfo();
             return JObject.Parse(localVarResponse.Data)["score"].ToString();

        }

        /// <summary>
        /// Getting current chain score Returns the current chain score
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainScoreDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CurrentChainScoreAsyncWithHttpInfo ()
        {

            var localVarPath = "/chain/score";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CurrentChainScore", localVarResponse);
                if (exception != null) throw exception;
            }
           
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

       
        /// <summary>
        /// Get current chain height Returns the current chain height
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of BlockDTO</returns>
        public async System.Threading.Tasks.Task<BlockInfo> LastBlockAsync ()
        {
             ApiResponse<string> localVarResponse = await LastBlockAsyncWithHttpInfo();
             return new BlockMapping().Apply(localVarResponse.Data);

        }

        /// <summary>
        /// Get current chain height Returns the current chain height
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (BlockDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> LastBlockAsyncWithHttpInfo ()
        {

            var localVarPath = "/chain/last-block";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LastBlock", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
