# RevealAPI.Sdk.Api.Resources.JobsavTranscribeApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvTranscribeGetById**](JobsavTranscribeApi.md#avtranscribegetbyid) | **GET** /api/v2/{caseId}/jobs/av-transcribe/{id} | Get single AV transcribe job
[**AvTranscribeGetLanguages**](JobsavTranscribeApi.md#avtranscribegetlanguages) | **GET** /api/v2/{caseId}/jobs/av-transcribe/languages | Get language Sources for transcribe job
[**AvTranscribeGetList**](JobsavTranscribeApi.md#avtranscribegetlist) | **GET** /api/v2/{caseId}/jobs/av-transcribe | Get AV transcribe jobs
[**AvTranscribePost**](JobsavTranscribeApi.md#avtranscribepost) | **POST** /api/v2/{caseId}/jobs/av-transcribe | Transcribe request sent to index batch server for processing


<a name="avtranscribegetbyid"></a>
# **AvTranscribeGetById**
> AvTranscribeJob AvTranscribeGetById (int? caseId, int? id)

Get single AV transcribe job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AvTranscribeGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsavTranscribeApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Job Id

            try
            {
                // Get single AV transcribe job
                AvTranscribeJob result = apiInstance.AvTranscribeGetById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsavTranscribeApi.AvTranscribeGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| Job Id | 

### Return type

[**AvTranscribeJob**](AvTranscribeJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="avtranscribegetlanguages"></a>
# **AvTranscribeGetLanguages**
> SearchJobResponse AvTranscribeGetLanguages (int? caseId)

Get language Sources for transcribe job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AvTranscribeGetLanguagesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsavTranscribeApi();
            var caseId = 56;  // int? | 

            try
            {
                // Get language Sources for transcribe job
                SearchJobResponse result = apiInstance.AvTranscribeGetLanguages(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsavTranscribeApi.AvTranscribeGetLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

[**SearchJobResponse**](SearchJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="avtranscribegetlist"></a>
# **AvTranscribeGetList**
> PaginatedOfIEnumerableOfAvTranscribeJob AvTranscribeGetList (int? caseId, bool? currentUserOnly = null, int? start = null, int? count = null, bool? deletedFlag = null)

Get AV transcribe jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AvTranscribeGetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsavTranscribeApi();
            var caseId = 56;  // int? | 
            var currentUserOnly = true;  // bool? | Get only jobs for current user or all jobs (optional)  (default to false)
            var start = 56;  // int? | 0 based (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var deletedFlag = true;  // bool? | null to return all jobs. otherwise return jobs with specified deleted status (optional) 

            try
            {
                // Get AV transcribe jobs
                PaginatedOfIEnumerableOfAvTranscribeJob result = apiInstance.AvTranscribeGetList(caseId, currentUserOnly, start, count, deletedFlag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsavTranscribeApi.AvTranscribeGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **currentUserOnly** | **bool?**| Get only jobs for current user or all jobs | [optional] [default to false]
 **start** | **int?**| 0 based | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]
 **deletedFlag** | **bool?**| null to return all jobs. otherwise return jobs with specified deleted status | [optional] 

### Return type

[**PaginatedOfIEnumerableOfAvTranscribeJob**](PaginatedOfIEnumerableOfAvTranscribeJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="avtranscribepost"></a>
# **AvTranscribePost**
> CreateJobResponse AvTranscribePost (int? caseId, AvTranscribeCreate body = null)

Transcribe request sent to index batch server for processing

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AvTranscribePostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsavTranscribeApi();
            var caseId = 56;  // int? | 
            var body = new AvTranscribeCreate(); // AvTranscribeCreate |  (optional) 

            try
            {
                // Transcribe request sent to index batch server for processing
                CreateJobResponse result = apiInstance.AvTranscribePost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsavTranscribeApi.AvTranscribePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**AvTranscribeCreate**](AvTranscribeCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

