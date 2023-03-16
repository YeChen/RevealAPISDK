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
    public interface IImageSetsApi : IApiAccessor
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
        /// <returns>ImageSet</returns>
        ImageSet ImageSetV2Get (int? caseId, int? id);

        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ImageSet</returns>
        ApiResponse<ImageSet> ImageSetV2GetWithHttpInfo (int? caseId, int? id);
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
        /// <returns>PaginatedOfListOfImageSet</returns>
        PaginatedOfListOfImageSet ImageSetV2GetList (int? caseId, int? start = null, int? count = null);

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
        /// <returns>ApiResponse of PaginatedOfListOfImageSet</returns>
        ApiResponse<PaginatedOfListOfImageSet> ImageSetV2GetListWithHttpInfo (int? caseId, int? start = null, int? count = null);
        /// <summary>
        /// Create a new image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageSetCreate</returns>
        ImageSetCreate ImageSetV2Post (int? caseId, ImageSetCreate body = null);

        /// <summary>
        /// Create a new image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageSetCreate</returns>
        ApiResponse<ImageSetCreate> ImageSetV2PostWithHttpInfo (int? caseId, ImageSetCreate body = null);
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
        /// <returns>Task of ImageSet</returns>
        System.Threading.Tasks.Task<ImageSet> ImageSetV2GetAsync (int? caseId, int? id);

        /// <summary>
        /// Get an image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ImageSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSet>> ImageSetV2GetAsyncWithHttpInfo (int? caseId, int? id);
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
        /// <returns>Task of PaginatedOfListOfImageSet</returns>
        System.Threading.Tasks.Task<PaginatedOfListOfImageSet> ImageSetV2GetListAsync (int? caseId, int? start = null, int? count = null);

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
        /// <returns>Task of ApiResponse (PaginatedOfListOfImageSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfImageSet>> ImageSetV2GetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null);
        /// <summary>
        /// Create a new image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageSetCreate</returns>
        System.Threading.Tasks.Task<ImageSetCreate> ImageSetV2PostAsync (int? caseId, ImageSetCreate body = null);

        /// <summary>
        /// Create a new image set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageSetCreate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageSetCreate>> ImageSetV2PostAsyncWithHttpInfo (int? caseId, ImageSetCreate body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ImageSetsApi : IImageSetsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImageSetsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImageSetsApi(Configuration configuration = null)
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
        /// <returns>ImageSet</returns>
        public ImageSet ImageSetV2Get (int? caseId, int? id)
        {
             ApiResponse<ImageSet> localVarResponse = ImageSetV2GetWithHttpInfo(caseId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ImageSet</returns>
        public ApiResponse< ImageSet > ImageSetV2GetWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2Get");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ImageSetsApi->ImageSetV2Get");

            var localVarPath = "/api/v2/{caseId}/imageSets/{id}";
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
                Exception exception = ExceptionFactory("ImageSetV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSet)));
        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ImageSet</returns>
        public async System.Threading.Tasks.Task<ImageSet> ImageSetV2GetAsync (int? caseId, int? id)
        {
             ApiResponse<ImageSet> localVarResponse = await ImageSetV2GetAsyncWithHttpInfo(caseId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ImageSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSet>> ImageSetV2GetAsyncWithHttpInfo (int? caseId, int? id)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2Get");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ImageSetsApi->ImageSetV2Get");

            var localVarPath = "/api/v2/{caseId}/imageSets/{id}";
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
                Exception exception = ExceptionFactory("ImageSetV2Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSet)));
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>PaginatedOfListOfImageSet</returns>
        public PaginatedOfListOfImageSet ImageSetV2GetList (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfImageSet> localVarResponse = ImageSetV2GetListWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>ApiResponse of PaginatedOfListOfImageSet</returns>
        public ApiResponse< PaginatedOfListOfImageSet > ImageSetV2GetListWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2GetList");

            var localVarPath = "/api/v2/{caseId}/imageSets";
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
                Exception exception = ExceptionFactory("ImageSetV2GetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfImageSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfImageSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfImageSet)));
        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of PaginatedOfListOfImageSet</returns>
        public async System.Threading.Tasks.Task<PaginatedOfListOfImageSet> ImageSetV2GetListAsync (int? caseId, int? start = null, int? count = null)
        {
             ApiResponse<PaginatedOfListOfImageSet> localVarResponse = await ImageSetV2GetListAsyncWithHttpInfo(caseId, start, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of image sets 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="start"> (optional, default to 0)</param>
        /// <param name="count"> (optional, default to 2147483647)</param>
        /// <returns>Task of ApiResponse (PaginatedOfListOfImageSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaginatedOfListOfImageSet>> ImageSetV2GetListAsyncWithHttpInfo (int? caseId, int? start = null, int? count = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2GetList");

            var localVarPath = "/api/v2/{caseId}/imageSets";
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
                Exception exception = ExceptionFactory("ImageSetV2GetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaginatedOfListOfImageSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PaginatedOfListOfImageSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedOfListOfImageSet)));
        }

        /// <summary>
        /// Create a new image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageSetCreate</returns>
        public ImageSetCreate ImageSetV2Post (int? caseId, ImageSetCreate body = null)
        {
             ApiResponse<ImageSetCreate> localVarResponse = ImageSetV2PostWithHttpInfo(caseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageSetCreate</returns>
        public ApiResponse< ImageSetCreate > ImageSetV2PostWithHttpInfo (int? caseId, ImageSetCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2Post");

            var localVarPath = "/api/v2/{caseId}/imageSets";
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
                Exception exception = ExceptionFactory("ImageSetV2Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSetCreate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageSetCreate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSetCreate)));
        }

        /// <summary>
        /// Create a new image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageSetCreate</returns>
        public async System.Threading.Tasks.Task<ImageSetCreate> ImageSetV2PostAsync (int? caseId, ImageSetCreate body = null)
        {
             ApiResponse<ImageSetCreate> localVarResponse = await ImageSetV2PostAsyncWithHttpInfo(caseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new image set 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageSetCreate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageSetCreate>> ImageSetV2PostAsyncWithHttpInfo (int? caseId, ImageSetCreate body = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling ImageSetsApi->ImageSetV2Post");

            var localVarPath = "/api/v2/{caseId}/imageSets";
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
                Exception exception = ExceptionFactory("ImageSetV2Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageSetCreate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageSetCreate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageSetCreate)));
        }

    }
}
