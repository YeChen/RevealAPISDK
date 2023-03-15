# RevealAPI.Sdk.Api.Resources.JobsbulkTagApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkTagGet**](JobsbulkTagApi.md#bulktagget) | **GET** /api/v2/{caseId}/jobs/bulkTag/{id} | Get a Bulk Tag job
[**BulkTagGetList**](JobsbulkTagApi.md#bulktaggetlist) | **GET** /api/v2/{caseId}/jobs/bulkTag | Get available bulk tag jobs
[**BulkTagPost**](JobsbulkTagApi.md#bulktagpost) | **POST** /api/v2/{caseId}/jobs/bulkTag | Create a bulk tag job
[**BulkTagRun**](JobsbulkTagApi.md#bulktagrun) | **PUT** /api/v2/{caseId}/jobs/bulkTag/{id}/run | Execute an action on a job


<a name="bulktagget"></a>
# **BulkTagGet**
> BulkTagJob BulkTagGet (int? caseId, int? id)

Get a Bulk Tag job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkTagGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsbulkTagApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a Bulk Tag job
                BulkTagJob result = apiInstance.BulkTagGet(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsbulkTagApi.BulkTagGet: " + e.Message );
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

[**BulkTagJob**](BulkTagJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulktaggetlist"></a>
# **BulkTagGetList**
> PaginatedOfIEnumerableOfBulkTagJob BulkTagGetList (int? caseId, int? userId = null, int? start = null, int? count = null)

Get available bulk tag jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkTagGetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsbulkTagApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get available bulk tag jobs
                PaginatedOfIEnumerableOfBulkTagJob result = apiInstance.BulkTagGetList(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsbulkTagApi.BulkTagGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] [default to 0]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfBulkTagJob**](PaginatedOfIEnumerableOfBulkTagJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulktagpost"></a>
# **BulkTagPost**
> CreateJobResponse BulkTagPost (int? caseId, BulkTagJobCreate body = null)

Create a bulk tag job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkTagPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsbulkTagApi();
            var caseId = 56;  // int? | 
            var body = new BulkTagJobCreate(); // BulkTagJobCreate |  (optional) 

            try
            {
                // Create a bulk tag job
                CreateJobResponse result = apiInstance.BulkTagPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsbulkTagApi.BulkTagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**BulkTagJobCreate**](BulkTagJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulktagrun"></a>
# **BulkTagRun**
> void BulkTagRun (int? caseId, int? id, Object jobAction = null)

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
    public class BulkTagRunExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsbulkTagApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var jobAction = new Object(); // Object |  (optional) 

            try
            {
                // Execute an action on a job
                apiInstance.BulkTagRun(caseId, id, jobAction);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsbulkTagApi.BulkTagRun: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

