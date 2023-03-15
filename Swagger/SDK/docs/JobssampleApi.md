# RevealAPI.Sdk.Api.Resources.JobssampleApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SampleJobDelete**](JobssampleApi.md#samplejobdelete) | **DELETE** /api/v2/{caseId}/jobs/sample/{id} | Delete a sample job
[**SampleJobGet**](JobssampleApi.md#samplejobget) | **GET** /api/v2/{caseId}/jobs/sample/{id} | Get a sample job
[**SampleJobGetList**](JobssampleApi.md#samplejobgetlist) | **GET** /api/v2/{caseId}/jobs/sample | Get available sample jobs
[**SampleJobPost**](JobssampleApi.md#samplejobpost) | **POST** /api/v2/{caseId}/jobs/sample | Create a sample job


<a name="samplejobdelete"></a>
# **SampleJobDelete**
> void SampleJobDelete (int? caseId, int? id)

Delete a sample job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SampleJobDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssampleApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a sample job
                apiInstance.SampleJobDelete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssampleApi.SampleJobDelete: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="samplejobget"></a>
# **SampleJobGet**
> SampleJob SampleJobGet (int? caseId, int? id)

Get a sample job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SampleJobGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssampleApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a sample job
                SampleJob result = apiInstance.SampleJobGet(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssampleApi.SampleJobGet: " + e.Message );
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

[**SampleJob**](SampleJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="samplejobgetlist"></a>
# **SampleJobGetList**
> PaginatedOfIEnumerableOfSampleJob SampleJobGetList (int? caseId, int? userId = null, int? start = null, int? count = null)

Get available sample jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SampleJobGetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssampleApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get available sample jobs
                PaginatedOfIEnumerableOfSampleJob result = apiInstance.SampleJobGetList(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssampleApi.SampleJobGetList: " + e.Message );
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

[**PaginatedOfIEnumerableOfSampleJob**](PaginatedOfIEnumerableOfSampleJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="samplejobpost"></a>
# **SampleJobPost**
> CreateJobResponse SampleJobPost (int? caseId, SampleJobCreate body = null)

Create a sample job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SampleJobPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssampleApi();
            var caseId = 56;  // int? | 
            var body = new SampleJobCreate(); // SampleJobCreate |  (optional) 

            try
            {
                // Create a sample job
                CreateJobResponse result = apiInstance.SampleJobPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssampleApi.SampleJobPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**SampleJobCreate**](SampleJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

