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
    public interface IJobstranslateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>TranslateJob</returns>
        TranslateJob TranslateJobGetById (int? caseId, int? id);

        /// <summary>
        /// Get a Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of TranslateJob</returns>
        ApiResponse<TranslateJob> TranslateJobGetByIdWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get available Translate jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>PaginatedOfIEnumerableOfTranslateJob</returns>
        PaginatedOfIEnumerableOfTranslateJob TranslateJobGetList (int? caseId, int? start = null, int? count = null, int? userId = null);

        /// <summary>
        /// Get available Translate jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>ApiResponse of PaginatedOfIEnumerableOfTranslateJob</returns>
        ApiResponse<PaginatedOfIEnumerableOfTranslateJob> TranslateJobGetListWithHttpInfo (int? caseId, int? start = null, int? count = null, int? userId = null);
        /// <summary>
        /// Bulk Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>CreateJobResponse</returns>
        CreateJobResponse TranslateJobPost (int? caseId, TranslateJobCreate body = null);

        /// <summary>
        /// Bulk Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CreateJobResponse</returns>
        ApiResponse<CreateJobResponse> TranslateJobPostWithHttpInfo (int? caseId, TranslateJobCreate body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of TranslateJob</returns>
        System.Threading.Tasks.Task<TranslateJob> TranslateJobGetByIdAsync (int? caseId, int? id);

        /// <summary>
        /// Get a Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (TranslateJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<TranslateJob>> TranslateJobGetByIdAsyncWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get available Translate jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>Task of PaginatedOfIEnumerableOfTranslateJob</returns>
        System.Threading.Tasks.Task<PaginatedOfIEnumerableOfTranslateJob> TranslateJobGetListAsync (int? caseId, int? start = null, int? count = null, int? userId = null);

        /// <summary>
        /// Get available Translate jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (PaginatedOfIEnumerableOfTranslateJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedOfIEnumerableOfTranslateJob>> TranslateJobGetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null, int? userId = null);
        /// <summary>
        /// Bulk Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CreateJobResponse</returns>
        System.Threading.Tasks.Task<CreateJobResponse> TranslateJobPostAsync (int? caseId, TranslateJobCreate body = null);

        /// <summary>
        /// Bulk Translate job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateJobResponse>> TranslateJobPostAsyncWithHttpInfo (int? caseId, TranslateJobCreate body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JobstranslateApi : IJobstranslateApi
    {
        private RevealAPI.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobstranslateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobstranslateApi(String basePath)
        {
            this.Configuration = new RevealAPI.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RevealAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobstranslateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobstranslateApi(RevealAPI.Sdk.Client.Configuration configuration = null)
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
        /// Get a Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>TranslateJob</returns>
        public TranslateJob TranslateJobGetById (int? caseId, int? id)
        {
             ApiResponse<TranslateJob> localVarResponse = TranslateJobGetByIdWithHttpInfo(caseId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of TranslateJob</returns>
        public ApiResponse< TranslateJob > TranslateJobGetByIdWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobGetById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobstranslateApi->TranslateJobGetById");

            var localVarPath = "/api/v2/{caseId}/jobs/translate/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                Exception exception = ExceptionFactory("TranslateJobGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TranslateJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TranslateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateJob)));
        }

        /// <summary>
        /// Get a Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of TranslateJob</returns>
        public async System.Threading.Tasks.Task<TranslateJob> TranslateJobGetByIdAsync (int? caseId, int? id)
        {
             ApiResponse<TranslateJob> localVarResponse = await TranslateJobGetByIdAsyncWithHttpInfo(caseId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (TranslateJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TranslateJob>> TranslateJobGetByIdAsyncWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobGetById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobstranslateApi->TranslateJobGetById");

            var localVarPath = "/api/v2/{caseId}/jobs/translate/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                Exception exception = ExceptionFactory("TranslateJobGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TranslateJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TranslateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateJob)));
        }

        /// <summary>
        /// Get available Translate jobs 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>PaginatedOfIEnumerableOfTranslateJob</returns>
        public PaginatedOfIEnumerableOfTranslateJob TranslateJobGetList (int? caseId, int? start = null, int? count = null, int? userId = null)
        {
             ApiResponse<PaginatedOfIEnumerableOfTranslateJob> localVarResponse = TranslateJobGetListWithHttpInfo(caseId, start, count, userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get available Translate jobs 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>ApiResponse of PaginatedOfIEnumerableOfTranslateJob</returns>
        public ApiResponse< PaginatedOfIEnumerableOfTranslateJob > TranslateJobGetListWithHttpInfo (int? caseId, int? start = null, int? count = null, int? userId = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobGetList");

            var localVarPath = "/api/v2/{caseId}/jobs/translate";
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
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter

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
                Exception exception = ExceptionFactory("TranslateJobGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfIEnumerableOfTranslateJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfIEnumerableOfTranslateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfIEnumerableOfTranslateJob)));
        }

        /// <summary>
        /// Get available Translate jobs 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>Task of PaginatedOfIEnumerableOfTranslateJob</returns>
        public async System.Threading.Tasks.Task<PaginatedOfIEnumerableOfTranslateJob> TranslateJobGetListAsync (int? caseId, int? start = null, int? count = null, int? userId = null)
        {
             ApiResponse<PaginatedOfIEnumerableOfTranslateJob> localVarResponse = await TranslateJobGetListAsyncWithHttpInfo(caseId, start, count, userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get available Translate jobs 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <returns>Task of ApiResponse (PaginatedOfIEnumerableOfTranslateJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedOfIEnumerableOfTranslateJob>> TranslateJobGetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null, int? userId = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobGetList");

            var localVarPath = "/api/v2/{caseId}/jobs/translate";
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
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter

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
                Exception exception = ExceptionFactory("TranslateJobGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfIEnumerableOfTranslateJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfIEnumerableOfTranslateJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfIEnumerableOfTranslateJob)));
        }

        /// <summary>
        /// Bulk Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>CreateJobResponse</returns>
        public CreateJobResponse TranslateJobPost (int? caseId, TranslateJobCreate body = null)
        {
             ApiResponse<CreateJobResponse> localVarResponse = TranslateJobPostWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CreateJobResponse</returns>
        public ApiResponse< CreateJobResponse > TranslateJobPostWithHttpInfo (int? caseId, TranslateJobCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobPost");

            var localVarPath = "/api/v2/{caseId}/jobs/translate";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId)); // path parameter
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
                Exception exception = ExceptionFactory("TranslateJobPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateJobResponse)));
        }

        /// <summary>
        /// Bulk Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CreateJobResponse</returns>
        public async System.Threading.Tasks.Task<CreateJobResponse> TranslateJobPostAsync (int? caseId, TranslateJobCreate body = null)
        {
             ApiResponse<CreateJobResponse> localVarResponse = await TranslateJobPostAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk Translate job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateJobResponse>> TranslateJobPostAsyncWithHttpInfo (int? caseId, TranslateJobCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobstranslateApi->TranslateJobPost");

            var localVarPath = "/api/v2/{caseId}/jobs/translate";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", this.Configuration.ApiClient.ParameterToString(caseId)); // path parameter
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
                Exception exception = ExceptionFactory("TranslateJobPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateJobResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateJobResponse)));
        }

    }
}
