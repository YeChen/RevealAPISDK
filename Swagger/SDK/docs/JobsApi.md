# RevealAPI.Sdk.Api.Resources.JobsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JobExecuteJobAction**](JobsApi.md#jobexecutejobaction) | **PUT** /api/v2/{caseId}/jobs/{typeId}/run/{jobId} | Execute an action on a job
[**JobGetJobFormDatadata**](JobsApi.md#jobgetjobformdatadata) | **GET** /api/v2/{caseId}/jobs/{typeId}/GetJobFormData | Get job configuration parameters for creating a job


<a name="jobexecutejobaction"></a>
# **JobExecuteJobAction**
> void JobExecuteJobAction (int? caseId, Object typeId, int? jobId, Object jobAction = null)

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
    public class JobExecuteJobActionExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsApi();
            var caseId = 56;  // int? | 
            var typeId = new Object(); // Object | 
            var jobId = 56;  // int? | 
            var jobAction = new Object(); // Object |  (optional) 

            try
            {
                // Execute an action on a job
                apiInstance.JobExecuteJobAction(caseId, typeId, jobId, jobAction);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.JobExecuteJobAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **typeId** | [**Object**](Object.md)|  | 
 **jobId** | **int?**|  | 
 **jobAction** | [**Object**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobgetjobformdatadata"></a>
# **JobGetJobFormDatadata**
> BulkActionForm JobGetJobFormDatadata (int? caseId, Object typeId)

Get job configuration parameters for creating a job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class JobGetJobFormDatadataExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsApi();
            var caseId = 56;  // int? | 
            var typeId = new Object(); // Object | 

            try
            {
                // Get job configuration parameters for creating a job
                BulkActionForm result = apiInstance.JobGetJobFormDatadata(caseId, typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsApi.JobGetJobFormDatadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **typeId** | [**Object**](Object.md)|  | 

### Return type

[**BulkActionForm**](BulkActionForm.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

