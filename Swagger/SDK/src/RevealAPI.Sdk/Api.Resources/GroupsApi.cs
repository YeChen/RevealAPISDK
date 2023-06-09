/* 
 * Reveal API v2.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace RevealAPI.Sdk.Api.Resources
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfListOfGroup</returns>
        PaginatedOfListOfGroup GroupsV2Get (int? caseId, int? start = null, int? count = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfListOfGroup</returns>
        ApiResponse<PaginatedOfListOfGroup> GroupsV2GetWithHttpInfo (int? caseId, int? start = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfListOfGroup</returns>
        System.Threading.Tasks.Task<PaginatedOfListOfGroup> GroupsV2GetAsync (int? caseId, int? start = null, int? count = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfListOfGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfGroup>> GroupsV2GetAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GroupsApi : IGroupsApi
    {
        private RevealAPI.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsApi(String basePath)
        {
            this.Configuration = new RevealAPI.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RevealAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GroupsApi(RevealAPI.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = RevealAPI.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = RevealAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
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
        public RevealAPI.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public RevealAPI.Sdk.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfListOfGroup</returns>
        public PaginatedOfListOfGroup GroupsV2Get (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfGroup> localVarResponse = GroupsV2GetWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfListOfGroup</returns>
        public ApiResponse< PaginatedOfListOfGroup > GroupsV2GetWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling GroupsApi->GroupsV2Get");

            var localVarPath = "/api/v2/{caseId}/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GroupsV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfGroup)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfListOfGroup</returns>
        public async System.Threading.Tasks.Task<PaginatedOfListOfGroup> GroupsV2GetAsync (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfGroup> localVarResponse = await GroupsV2GetAsyncWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfListOfGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfGroup>> GroupsV2GetAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling GroupsApi->GroupsV2Get");

            var localVarPath = "/api/v2/{caseId}/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (count != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GroupsV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfGroup) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfGroup)));
        }

    }
}
