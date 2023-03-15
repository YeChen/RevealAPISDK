# RevealAPI.Sdk.Api.Resources.JobsdeletionApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDeleteGet**](JobsdeletionApi.md#bulkdeleteget) | **GET** /api/v2/{caseId}/jobs/deletion | Get Deletion jobs
[**BulkDeleteGetJob**](JobsdeletionApi.md#bulkdeletegetjob) | **GET** /api/v2/{caseId}/jobs/deletion/{id} | Get a Deletion job
[**BulkDeletePost**](JobsdeletionApi.md#bulkdeletepost) | **POST** /api/v2/{caseId}/jobs/deletion | Create a document Deletion job


<a name="bulkdeleteget"></a>
# **BulkDeleteGet**
> PaginatedOfIEnumerableOfDeletionJob BulkDeleteGet (int? caseId, int? userId = null, int? start = null, int? count = null)

Get Deletion jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkDeleteGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsdeletionApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | User to get jobs for (optional)  (default to 0)
            var start = 56;  // int? | 0 based (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get Deletion jobs
                PaginatedOfIEnumerableOfDeletionJob result = apiInstance.BulkDeleteGet(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsdeletionApi.BulkDeleteGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**| User to get jobs for | [optional] [default to 0]
 **start** | **int?**| 0 based | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfDeletionJob**](PaginatedOfIEnumerableOfDeletionJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeletegetjob"></a>
# **BulkDeleteGetJob**
> DeletionJob BulkDeleteGetJob (int? caseId, int? id)

Get a Deletion job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkDeleteGetJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsdeletionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | job id

            try
            {
                // Get a Deletion job
                DeletionJob result = apiInstance.BulkDeleteGetJob(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsdeletionApi.BulkDeleteGetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| job id | 

### Return type

[**DeletionJob**](DeletionJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeletepost"></a>
# **BulkDeletePost**
> CreateJobResponse BulkDeletePost (int? caseId, DeletionJobCreate body = null)

Create a document Deletion job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class BulkDeletePostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsdeletionApi();
            var caseId = 56;  // int? | 
            var body = new DeletionJobCreate(); // DeletionJobCreate |  (optional) 

            try
            {
                // Create a document Deletion job
                CreateJobResponse result = apiInstance.BulkDeletePost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsdeletionApi.BulkDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**DeletionJobCreate**](DeletionJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

