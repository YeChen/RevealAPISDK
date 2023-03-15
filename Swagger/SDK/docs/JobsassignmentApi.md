# RevealAPI.Sdk.Api.Resources.JobsassignmentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignmentJobsGet**](JobsassignmentApi.md#assignmentjobsget) | **GET** /api/v2/{caseId}/jobs/assignment | Get available assignment jobs
[**AssignmentJobsGetById**](JobsassignmentApi.md#assignmentjobsgetbyid) | **GET** /api/v2/{caseId}/jobs/assignment/{id} | Get an assignment job
[**AssignmentJobsPatch**](JobsassignmentApi.md#assignmentjobspatch) | **PATCH** /api/v2/{caseId}/jobs/assignment | Update an assignment job
[**AssignmentJobsPost**](JobsassignmentApi.md#assignmentjobspost) | **POST** /api/v2/{caseId}/jobs/assignment | Create an assignment job
[**AssignmentJobsRun**](JobsassignmentApi.md#assignmentjobsrun) | **PUT** /api/v2/{caseId}/jobs/assignment/{id}/run | Execute an action on a job


<a name="assignmentjobsget"></a>
# **AssignmentJobsGet**
> PaginatedOfListOfAssignmentJob AssignmentJobsGet (int? caseId, int? start = null, int? count = null)

Get available assignment jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentJobsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsassignmentApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get available assignment jobs
                PaginatedOfListOfAssignmentJob result = apiInstance.AssignmentJobsGet(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsassignmentApi.AssignmentJobsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfAssignmentJob**](PaginatedOfListOfAssignmentJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentjobsgetbyid"></a>
# **AssignmentJobsGetById**
> AssignmentJob AssignmentJobsGetById (int? caseId, int? id)

Get an assignment job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentJobsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsassignmentApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get an assignment job
                AssignmentJob result = apiInstance.AssignmentJobsGetById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsassignmentApi.AssignmentJobsGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**AssignmentJob**](AssignmentJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentjobspatch"></a>
# **AssignmentJobsPatch**
> void AssignmentJobsPatch (int? caseId, AssignmentJobUpdate body = null)

Update an assignment job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentJobsPatchExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsassignmentApi();
            var caseId = 56;  // int? | 
            var body = new AssignmentJobUpdate(); // AssignmentJobUpdate |  (optional) 

            try
            {
                // Update an assignment job
                apiInstance.AssignmentJobsPatch(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsassignmentApi.AssignmentJobsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**AssignmentJobUpdate**](AssignmentJobUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentjobspost"></a>
# **AssignmentJobsPost**
> CreateJobResponse AssignmentJobsPost (int? caseId, AssignmentJobCreate body = null)

Create an assignment job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentJobsPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsassignmentApi();
            var caseId = 56;  // int? | 
            var body = new AssignmentJobCreate(); // AssignmentJobCreate |  (optional) 

            try
            {
                // Create an assignment job
                CreateJobResponse result = apiInstance.AssignmentJobsPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsassignmentApi.AssignmentJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**AssignmentJobCreate**](AssignmentJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentjobsrun"></a>
# **AssignmentJobsRun**
> void AssignmentJobsRun (int? caseId, int? id, Object jobAction = null)

Execute an action on a job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentJobsRunExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsassignmentApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var jobAction = new Object(); // Object |  (optional) 

            try
            {
                // Execute an action on a job
                apiInstance.AssignmentJobsRun(caseId, id, jobAction);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsassignmentApi.AssignmentJobsRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 
 **jobAction** | [**Object**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

