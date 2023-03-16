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
    public interface IImportProfilesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ImportProfile</returns>
        ImportProfile ImportProfileGet (int? caseId, int? id);

        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ImportProfile</returns>
        ApiResponse<ImportProfile> ImportProfileGetWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get a list of image sets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfListOfImportProfile</returns>
        PaginatedOfListOfImportProfile ImportProfileGetList (int? caseId, int? start = null, int? count = null);

        /// <summary>
        /// Get a list of image sets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfListOfImportProfile</returns>
        ApiResponse<PaginatedOfListOfImportProfile> ImportProfileGetListWithHttpInfo (int? caseId, int? start = null, int? count = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ImportProfile</returns>
        System.Threading.Tasks.Task<ImportProfile> ImportProfileGetAsync (int? caseId, int? id);

        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ImportProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportProfile>> ImportProfileGetAsyncWithHttpInfo (int? caseId, int? id);
        /// <summary>
        /// Get a list of image sets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfListOfImportProfile</returns>
        System.Threading.Tasks.Task<PaginatedOfListOfImportProfile> ImportProfileGetListAsync (int? caseId, int? start = null, int? count = null);

        /// <summary>
        /// Get a list of image sets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfListOfImportProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfImportProfile>> ImportProfileGetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImportProfilesApi : IImportProfilesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProfilesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImportProfilesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProfilesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImportProfilesApi(Configuration configuration = null)
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
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ImportProfile</returns>
        public ImportProfile ImportProfileGet (int? caseId, int? id)
        {
             ApiResponse<ImportProfile> localVarResponse = ImportProfileGetWithHttpInfo(caseId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ImportProfile</returns>
        public ApiResponse< ImportProfile > ImportProfileGetWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImportProfilesApi->ImportProfileGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ImportProfilesApi->ImportProfileGet");

            var localVarPath = "/api/v2/{caseId}/importProfiles/{id}";
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
                Exception exception = ExceptionFactory("ImportProfileGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImportProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportProfile)));
        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ImportProfile</returns>
        public async System.Threading.Tasks.Task<ImportProfile> ImportProfileGetAsync (int? caseId, int? id)
        {
             ApiResponse<ImportProfile> localVarResponse = await ImportProfileGetAsyncWithHttpInfo(caseId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ImportProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportProfile>> ImportProfileGetAsyncWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImportProfilesApi->ImportProfileGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ImportProfilesApi->ImportProfileGet");

            var localVarPath = "/api/v2/{caseId}/importProfiles/{id}";
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
                Exception exception = ExceptionFactory("ImportProfileGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImportProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportProfile)));
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfListOfImportProfile</returns>
        public PaginatedOfListOfImportProfile ImportProfileGetList (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfImportProfile> localVarResponse = ImportProfileGetListWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfListOfImportProfile</returns>
        public ApiResponse< PaginatedOfListOfImportProfile > ImportProfileGetListWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImportProfilesApi->ImportProfileGetList");

            var localVarPath = "/api/v2/{caseId}/importProfiles";
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
                Exception exception = ExceptionFactory("ImportProfileGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfImportProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfImportProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfImportProfile)));
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfListOfImportProfile</returns>
        public async System.Threading.Tasks.Task<PaginatedOfListOfImportProfile> ImportProfileGetListAsync (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfImportProfile> localVarResponse = await ImportProfileGetListAsyncWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfListOfImportProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfImportProfile>> ImportProfileGetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImportProfilesApi->ImportProfileGetList");

            var localVarPath = "/api/v2/{caseId}/importProfiles";
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
                Exception exception = ExceptionFactory("ImportProfileGetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfImportProfile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfImportProfile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfImportProfile)));
        }

    }
}
