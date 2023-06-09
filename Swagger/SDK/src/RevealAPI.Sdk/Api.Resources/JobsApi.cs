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
    public interface IJobsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Execute an action on a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns></returns>
        void JobExecuteJobAction (int? caseId, Object typeId, int? jobId, Object jobAction = null);

        /// <summary>
        /// Execute an action on a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> JobExecuteJobActionWithHttpInfo (int? caseId, Object typeId, int? jobId, Object jobAction = null);
        /// <summary>
        /// Get job configuration parameters for creating a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>BulkActionForm</returns>
        BulkActionForm JobGetJobFormDatadata (int? caseId, Object typeId);

        /// <summary>
        /// Get job configuration parameters for creating a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>ApiResponse of BulkActionForm</returns>
        ApiResponse<BulkActionForm> JobGetJobFormDatadataWithHttpInfo (int? caseId, Object typeId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Execute an action on a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task JobExecuteJobActionAsync (int? caseId, Object typeId, int? jobId, Object jobAction = null);

        /// <summary>
        /// Execute an action on a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> JobExecuteJobActionAsyncWithHttpInfo (int? caseId, Object typeId, int? jobId, Object jobAction = null);
        /// <summary>
        /// Get job configuration parameters for creating a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>Task of BulkActionForm</returns>
        System.Threading.Tasks.Task<BulkActionForm> JobGetJobFormDatadataAsync (int? caseId, Object typeId);

        /// <summary>
        /// Get job configuration parameters for creating a job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>Task of ApiResponse (BulkActionForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkActionForm>> JobGetJobFormDatadataAsyncWithHttpInfo (int? caseId, Object typeId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JobsApi : IJobsApi
    {
        private RevealAPI.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobsApi(String basePath)
        {
            this.Configuration = new RevealAPI.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = RevealAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobsApi(RevealAPI.Sdk.Client.Configuration configuration = null)
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
        /// Execute an action on a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns></returns>
        public void JobExecuteJobAction (int? caseId, Object typeId, int? jobId, Object jobAction = null)
        {
             JobExecuteJobActionWithHttpInfo(caseId, typeId, jobId, jobAction);
        }

        /// <summary>
        /// Execute an action on a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> JobExecuteJobActionWithHttpInfo (int? caseId, Object typeId, int? jobId, Object jobAction = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsApi->JobExecuteJobAction");
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling JobsApi->JobExecuteJobAction");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JobsApi->JobExecuteJobAction");

            var localVarPath = "/api/v2/{caseId}/jobs/{typeId}/run/{jobId}";
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            if (jobAction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "jobAction", jobAction)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("JobExecuteJobAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Execute an action on a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task JobExecuteJobActionAsync (int? caseId, Object typeId, int? jobId, Object jobAction = null)
        {
             await JobExecuteJobActionAsyncWithHttpInfo(caseId, typeId, jobId, jobAction);

        }

        /// <summary>
        /// Execute an action on a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <param name="jobId"></param>
        /// <param name="jobAction"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> JobExecuteJobActionAsyncWithHttpInfo (int? caseId, Object typeId, int? jobId, Object jobAction = null)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsApi->JobExecuteJobAction");
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling JobsApi->JobExecuteJobAction");
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling JobsApi->JobExecuteJobAction");

            var localVarPath = "/api/v2/{caseId}/jobs/{typeId}/run/{jobId}";
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            if (jobAction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "jobAction", jobAction)); // query parameter

            // authentication (api-token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("InControlAuthToken")))
            {
                localVarHeaderParams["InControlAuthToken"] = this.Configuration.GetApiKeyWithPrefix("InControlAuthToken");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("JobExecuteJobAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get job configuration parameters for creating a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>BulkActionForm</returns>
        public BulkActionForm JobGetJobFormDatadata (int? caseId, Object typeId)
        {
             ApiResponse<BulkActionForm> localVarResponse = JobGetJobFormDatadataWithHttpInfo(caseId, typeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get job configuration parameters for creating a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>ApiResponse of BulkActionForm</returns>
        public ApiResponse< BulkActionForm > JobGetJobFormDatadataWithHttpInfo (int? caseId, Object typeId)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsApi->JobGetJobFormDatadata");
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling JobsApi->JobGetJobFormDatadata");

            var localVarPath = "/api/v2/{caseId}/jobs/{typeId}/GetJobFormData";
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId)); // path parameter

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
                Exception exception = ExceptionFactory("JobGetJobFormDatadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BulkActionForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionForm)));
        }

        /// <summary>
        /// Get job configuration parameters for creating a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>Task of BulkActionForm</returns>
        public async System.Threading.Tasks.Task<BulkActionForm> JobGetJobFormDatadataAsync (int? caseId, Object typeId)
        {
             ApiResponse<BulkActionForm> localVarResponse = await JobGetJobFormDatadataAsyncWithHttpInfo(caseId, typeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get job configuration parameters for creating a job 
        /// </summary>
        /// <exception cref="RevealAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="caseId"></param>
        /// <param name="typeId"></param>
        /// <returns>Task of ApiResponse (BulkActionForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BulkActionForm>> JobGetJobFormDatadataAsyncWithHttpInfo (int? caseId, Object typeId)
        {
            // verify the required parameter 'caseId' is set
            if (caseId == null)
                throw new ApiException(400, "Missing required parameter 'caseId' when calling JobsApi->JobGetJobFormDatadata");
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling JobsApi->JobGetJobFormDatadata");

            var localVarPath = "/api/v2/{caseId}/jobs/{typeId}/GetJobFormData";
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
            if (typeId != null) localVarPathParams.Add("typeId", this.Configuration.ApiClient.ParameterToString(typeId)); // path parameter

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
                Exception exception = ExceptionFactory("JobGetJobFormDatadata", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BulkActionForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BulkActionForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BulkActionForm)));
        }

    }
}
