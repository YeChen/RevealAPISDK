# RevealAPI.Sdk.Api.Resources.JobsexportApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportJobsDelete**](JobsexportApi.md#exportjobsdelete) | **DELETE** /api/v2/{caseId}/jobs/export/{id} | Delete a export job
[**ExportJobsGetById**](JobsexportApi.md#exportjobsgetbyid) | **GET** /api/v2/{caseId}/jobs/export/{id} | Get a export job
[**ExportJobsGetList**](JobsexportApi.md#exportjobsgetlist) | **GET** /api/v2/{caseId}/jobs/export | Get available export jobs
[**ExportJobsPost**](JobsexportApi.md#exportjobspost) | **POST** /api/v2/{caseId}/jobs/export | Create and run an export job


<a name="exportjobsdelete"></a>
# **ExportJobsDelete**
> JobSubmitStatus ExportJobsDelete (int? caseId, int? id)

Delete a export job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ExportJobsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsexportApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a export job
                JobSubmitStatus result = apiInstance.ExportJobsDelete(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsexportApi.ExportJobsDelete: " + e.Message );
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

[**JobSubmitStatus**](JobSubmitStatus.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportjobsgetbyid"></a>
# **ExportJobsGetById**
> ExportJob ExportJobsGetById (int? caseId, int? id)

Get a export job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ExportJobsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsexportApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a export job
                ExportJob result = apiInstance.ExportJobsGetById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsexportApi.ExportJobsGetById: " + e.Message );
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

[**ExportJob**](ExportJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportjobsgetlist"></a>
# **ExportJobsGetList**
> PaginatedOfIEnumerableOfExportJob ExportJobsGetList (int? caseId, int? userId = null, int? start = null, int? count = null)

Get available export jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ExportJobsGetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsexportApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get available export jobs
                PaginatedOfIEnumerableOfExportJob result = apiInstance.ExportJobsGetList(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsexportApi.ExportJobsGetList: " + e.Message );
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

[**PaginatedOfIEnumerableOfExportJob**](PaginatedOfIEnumerableOfExportJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportjobspost"></a>
# **ExportJobsPost**
> CreateJobResponse ExportJobsPost (int? caseId, ExportJobCreate body = null)

Create and run an export job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ExportJobsPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsexportApi();
            var caseId = 56;  // int? | 
            var body = new ExportJobCreate(); // ExportJobCreate |  (optional) 

            try
            {
                // Create and run an export job
                CreateJobResponse result = apiInstance.ExportJobsPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsexportApi.ExportJobsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**ExportJobCreate**](ExportJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

