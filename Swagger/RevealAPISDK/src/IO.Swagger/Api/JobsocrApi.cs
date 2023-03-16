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
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJobsocrApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a OCR job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>BulkOCRJob</returns>
        BulkOCRJob OcrJobGetById (int? caseId, int? id);

        /// <summary>
        /// Get a OCR job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of BulkOCRJob</returns>
        ApiResponse<BulkOCRJob> OcrJobGetByIdWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get available OCR jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfIEnumerableOfBulkOCRJob</returns>
        PaginatedOfIEnumerableOfBulkOCRJob OcrJobGetList (int? caseId, int? userId = null, int? start = null, int? count = null);

        /// <summary>
        /// Get available OCR jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfIEnumerableOfBulkOCRJob</returns>
        ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob> OcrJobGetListWithHttpInfo (int? caseId, int? userId = null, int? start = null, int? count = null);
        /// <summary>
        /// Create a ocr request job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>CreateJobResponse</returns>
        CreateJobResponse OcrJobPost (int? caseId, OcrJobCreate body = null);

        /// <summary>
        /// Create a ocr request job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CreateJobResponse</returns>
        ApiResponse<CreateJobResponse> OcrJobPostWithHttpInfo (int? caseId, OcrJobCreate body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a OCR job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of BulkOCRJob</returns>
        System.Threading.Tasks.Task<BulkOCRJob> OcrJobGetByIdAsync (int? caseId, int? id);

        /// <summary>
        /// Get a OCR job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (BulkOCRJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkOCRJob>> OcrJobGetByIdAsyncWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get available OCR jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfIEnumerableOfBulkOCRJob</returns>
        System.Threading.Tasks.Task<PaginatedOfIEnumerableOfBulkOCRJob> OcrJobGetListAsync (int? caseId, int? userId = null, int? start = null, int? count = null);

        /// <summary>
        /// Get available OCR jobs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfIEnumerableOfBulkOCRJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob>> OcrJobGetListAsyncWithHttpInfo (int? caseId, int? userId = null, int? start = null, int? count = null);
        /// <summary>
        /// Create a ocr request job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CreateJobResponse</returns>
        System.Threading.Tasks.Task<CreateJobResponse> OcrJobPostAsync (int? caseId, OcrJobCreate body = null);

        /// <summary>
        /// Create a ocr request job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateJobResponse>> OcrJobPostAsyncWithHttpInfo (int? caseId, OcrJobCreate body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JobsocrApi : IJobsocrApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsocrApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobsocrApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsocrApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobsocrApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Get a OCR job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>BulkOCRJob</returns>
        public BulkOCRJob OcrJobGetById (int? caseId, int? id)
        {
             ApiResponse<BulkOCRJob> localVarResponse = OcrJobGetByIdWithHttpInfo(caseId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a OCR job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of BulkOCRJob</returns>
        public ApiResponse< BulkOCRJob > OcrJobGetByIdWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobGetById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobsocrApi->OcrJobGetById");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr/{id}";
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

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BulkOCRJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkOCRJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOCRJob)));
        }

        /// <summary>
        /// Get a OCR job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of BulkOCRJob</returns>
        public async System.Threading.Tasks.Task<BulkOCRJob> OcrJobGetByIdAsync (int? caseId, int? id)
        {
             ApiResponse<BulkOCRJob> localVarResponse = await OcrJobGetByIdAsyncWithHttpInfo(caseId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a OCR job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (BulkOCRJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BulkOCRJob>> OcrJobGetByIdAsyncWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobGetById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling JobsocrApi->OcrJobGetById");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr/{id}";
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

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BulkOCRJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkOCRJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkOCRJob)));
        }

        /// <summary>
        /// Get available OCR jobs 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfIEnumerableOfBulkOCRJob</returns>
        public PaginatedOfIEnumerableOfBulkOCRJob OcrJobGetList (int? caseId, int? userId = null, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob> localVarResponse = OcrJobGetListWithHttpInfo(caseId, userId, start, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get available OCR jobs 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfIEnumerableOfBulkOCRJob</returns>
        public ApiResponse< PaginatedOfIEnumerableOfBulkOCRJob > OcrJobGetListWithHttpInfo (int? caseId, int? userId = null, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobGetList");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr";
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

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (userId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (start != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfIEnumerableOfBulkOCRJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfIEnumerableOfBulkOCRJob)));
        }

        /// <summary>
        /// Get available OCR jobs 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfIEnumerableOfBulkOCRJob</returns>
        public async System.Threading.Tasks.Task<PaginatedOfIEnumerableOfBulkOCRJob> OcrJobGetListAsync (int? caseId, int? userId = null, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob> localVarResponse = await OcrJobGetListAsyncWithHttpInfo(caseId, userId, start, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get available OCR jobs 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="userId"> (optional, default to 0)</param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfIEnumerableOfBulkOCRJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob>> OcrJobGetListAsyncWithHttpInfo (int? caseId, int? userId = null, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobGetList");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr";
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

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (userId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (start != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (count != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "count", count)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfIEnumerableOfBulkOCRJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfIEnumerableOfBulkOCRJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfIEnumerableOfBulkOCRJob)));
        }

        /// <summary>
        /// Create a ocr request job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>CreateJobResponse</returns>
        public CreateJobResponse OcrJobPost (int? caseId, OcrJobCreate body = null)
        {
             ApiResponse<CreateJobResponse> localVarResponse = OcrJobPostWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a ocr request job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CreateJobResponse</returns>
        public ApiResponse< CreateJobResponse > OcrJobPostWithHttpInfo (int? caseId, OcrJobCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobPost");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateJobResponse)));
        }

        /// <summary>
        /// Create a ocr request job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CreateJobResponse</returns>
        public async System.Threading.Tasks.Task<CreateJobResponse> OcrJobPostAsync (int? caseId, OcrJobCreate body = null)
        {
             ApiResponse<CreateJobResponse> localVarResponse = await OcrJobPostAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a ocr request job 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateJobResponse>> OcrJobPostAsyncWithHttpInfo (int? caseId, OcrJobCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsocrApi->OcrJobPost");

            var localVarPath = "/api/v2/{caseId}/jobs/ocr";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
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
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (caseId != null) localVarPathParams.Add("caseId", Configuration.ApiClient.ParameterToString(caseId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OcrJobPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateJobResponse)));
        }

    }
}
