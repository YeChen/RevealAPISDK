/* 
 * Reveal API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace RevealAPI.V1.Api.Resources
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void TeamCreate (int? caseId = null, int? userId = null, TeamCreate body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TeamCreateWithHttpInfo (int? caseId = null, int? userId = null, TeamCreate body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns></returns>
        void TeamDelete (int? caseId = null, int? userId = null, int? id = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TeamDeleteWithHttpInfo (int? caseId = null, int? userId = null, int? id = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns></returns>
        void TeamGet (int? caseId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TeamGetWithHttpInfo (int? caseId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamCreateAsync (int? caseId = null, int? userId = null, TeamCreate body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TeamCreateAsyncWithHttpInfo (int? caseId = null, int? userId = null, TeamCreate body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamDeleteAsync (int? caseId = null, int? userId = null, int? id = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TeamDeleteAsyncWithHttpInfo (int? caseId = null, int? userId = null, int? id = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TeamGetAsync (int? caseId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TeamGetAsyncWithHttpInfo (int? caseId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TeamApi : ITeamApi
    {
        private RevealAPI.V1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamApi(String basePath)
        {
            this.Configuration = new RevealAPI.V1.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RevealAPI.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TeamApi(RevealAPI.V1.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = RevealAPI.V1.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = RevealAPI.V1.Client.Configuration.DefaultExceptionFactory;
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
        public RevealAPI.V1.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public RevealAPI.V1.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void TeamCreate (int? caseId = null, int? userId = null, TeamCreate body = null)
        {
             TeamCreateWithHttpInfo(caseId, userId, body);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TeamCreateWithHttpInfo (int? caseId = null, int? userId = null, TeamCreate body = null)
        {

            var localVarPath = "/api/team/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TeamCreateAsync (int? caseId = null, int? userId = null, TeamCreate body = null)
        {
             await TeamCreateAsyncWithHttpInfo(caseId, userId, body);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TeamCreateAsyncWithHttpInfo (int? caseId = null, int? userId = null, TeamCreate body = null)
        {

            var localVarPath = "/api/team/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns></returns>
        public void TeamDelete (int? caseId = null, int? userId = null, int? id = null)
        {
             TeamDeleteWithHttpInfo(caseId, userId, id);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TeamDeleteWithHttpInfo (int? caseId = null, int? userId = null, int? id = null)
        {

            var localVarPath = "/api/team/delete";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TeamDeleteAsync (int? caseId = null, int? userId = null, int? id = null)
        {
             await TeamDeleteAsyncWithHttpInfo(caseId, userId, id);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TeamDeleteAsyncWithHttpInfo (int? caseId = null, int? userId = null, int? id = null)
        {

            var localVarPath = "/api/team/delete";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns></returns>
        public void TeamGet (int? caseId = null)
        {
             TeamGetWithHttpInfo(caseId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TeamGetWithHttpInfo (int? caseId = null)
        {

            var localVarPath = "/api/team";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter

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
                Exception exception = ExceptionFactory("TeamGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TeamGetAsync (int? caseId = null)
        {
             await TeamGetAsyncWithHttpInfo(caseId);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TeamGetAsyncWithHttpInfo (int? caseId = null)
        {

            var localVarPath = "/api/team";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter

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
                Exception exception = ExceptionFactory("TeamGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
