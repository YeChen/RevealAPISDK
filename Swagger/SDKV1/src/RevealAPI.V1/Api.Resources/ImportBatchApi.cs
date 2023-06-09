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
    public interface IImportBatchApi : IApiAccessor
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
        /// <param name="name"> (optional)</param>
        /// <returns>List&lt;ImportBatch&gt;</returns>
        List<ImportBatch> ImportBatchGet (int? caseId = null, string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ImportBatch&gt;</returns>
        ApiResponse<List<ImportBatch>> ImportBatchGetWithHttpInfo (int? caseId = null, string name = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ImportBatchGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> ImportBatchGetDocumentIdsWithHttpInfo (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null);
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
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;ImportBatch&gt;</returns>
        System.Threading.Tasks.Task<List<ImportBatch>> ImportBatchGetAsync (int? caseId = null, string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ImportBatch&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ImportBatch>>> ImportBatchGetAsyncWithHttpInfo (int? caseId = null, string name = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> ImportBatchGetDocumentIdsAsync (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> ImportBatchGetDocumentIdsAsyncWithHttpInfo (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImportBatchApi : IImportBatchApi
    {
        private RevealAPI.V1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBatchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImportBatchApi(String basePath)
        {
            this.Configuration = new RevealAPI.V1.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RevealAPI.V1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBatchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImportBatchApi(RevealAPI.V1.Client.Configuration configuration = null)
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
        /// <param name="name"> (optional)</param>
        /// <returns>List&lt;ImportBatch&gt;</returns>
        public List<ImportBatch> ImportBatchGet (int? caseId = null, string name = null)
        {
             ApiResponse<List<ImportBatch>> localVarResponse = ImportBatchGetWithHttpInfo(caseId, name);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>ApiResponse of List&lt;ImportBatch&gt;</returns>
        public ApiResponse< List<ImportBatch> > ImportBatchGetWithHttpInfo (int? caseId = null, string name = null)
        {

            var localVarPath = "/api/importBatch";
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

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

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
                Exception exception = ExceptionFactory("ImportBatchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ImportBatch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ImportBatch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ImportBatch>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;ImportBatch&gt;</returns>
        public async System.Threading.Tasks.Task<List<ImportBatch>> ImportBatchGetAsync (int? caseId = null, string name = null)
        {
             ApiResponse<List<ImportBatch>> localVarResponse = await ImportBatchGetAsyncWithHttpInfo(caseId, name);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ImportBatch&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ImportBatch>>> ImportBatchGetAsyncWithHttpInfo (int? caseId = null, string name = null)
        {

            var localVarPath = "/api/importBatch";
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

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

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
                Exception exception = ExceptionFactory("ImportBatchGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ImportBatch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ImportBatch>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ImportBatch>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ImportBatchGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)
        {
             ApiResponse<List<string>> localVarResponse = ImportBatchGetDocumentIdsWithHttpInfo(caseId, userId, keyField, startRow, batchSize, name);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > ImportBatchGetDocumentIdsWithHttpInfo (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)
        {

            var localVarPath = "/api/importBatch/documentIds";
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

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (keyField != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyField", keyField)); // query parameter
            if (startRow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "startRow", startRow)); // query parameter
            if (batchSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "batchSize", batchSize)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

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
                Exception exception = ExceptionFactory("ImportBatchGetDocumentIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> ImportBatchGetDocumentIdsAsync (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)
        {
             ApiResponse<List<string>> localVarResponse = await ImportBatchGetDocumentIdsAsyncWithHttpInfo(caseId, userId, keyField, startRow, batchSize, name);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="RevealAPI.V1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"> (optional)</param>
        /// <param name="userId"> (optional)</param>
        /// <param name="keyField"> (optional)</param>
        /// <param name="startRow"> (optional)</param>
        /// <param name="batchSize"> (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> ImportBatchGetDocumentIdsAsyncWithHttpInfo (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)
        {

            var localVarPath = "/api/importBatch/documentIds";
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

            if (caseId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "caseId", caseId)); // query parameter
            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (keyField != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyField", keyField)); // query parameter
            if (startRow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "startRow", startRow)); // query parameter
            if (batchSize != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "batchSize", batchSize)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter

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
                Exception exception = ExceptionFactory("ImportBatchGetDocumentIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
        }

    }
}
