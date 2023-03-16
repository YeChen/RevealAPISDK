# IO.Swagger.Api.JobstranslateApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranslateJobGetById**](JobstranslateApi.md#translatejobgetbyid) | **GET** /api/v2/{caseId}/jobs/translate/{id} | Get a Translate job
[**TranslateJobGetList**](JobstranslateApi.md#translatejobgetlist) | **GET** /api/v2/{caseId}/jobs/translate | Get available Translate jobs
[**TranslateJobPost**](JobstranslateApi.md#translatejobpost) | **POST** /api/v2/{caseId}/jobs/translate | Bulk Translate job


<a name="translatejobgetbyid"></a>
# **TranslateJobGetById**
> TranslateJob TranslateJobGetById (int? caseId, int? id)

Get a Translate job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranslateJobGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobstranslateApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a Translate job
                TranslateJob result = apiInstance.TranslateJobGetById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobstranslateApi.TranslateJobGetById: " + e.Message );
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

[**TranslateJob**](TranslateJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translatejobgetlist"></a>
# **TranslateJobGetList**
> PaginatedOfIEnumerableOfTranslateJob TranslateJobGetList (int? caseId, int? start = null, int? count = null, int? userId = null)

Get available Translate jobs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranslateJobGetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobstranslateApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var userId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Get available Translate jobs
                PaginatedOfIEnumerableOfTranslateJob result = apiInstance.TranslateJobGetList(caseId, start, count, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobstranslateApi.TranslateJobGetList: " + e.Message );
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
 **userId** | **int?**|  | [optional] [default to 0]

### Return type

[**PaginatedOfIEnumerableOfTranslateJob**](PaginatedOfIEnumerableOfTranslateJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translatejobpost"></a>
# **TranslateJobPost**
> CreateJobResponse TranslateJobPost (int? caseId, TranslateJobCreate body = null)

Bulk Translate job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranslateJobPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobstranslateApi();
            var caseId = 56;  // int? | 
            var body = new TranslateJobCreate(); // TranslateJobCreate |  (optional) 

            try
            {
                // Bulk Translate job
                CreateJobResponse result = apiInstance.TranslateJobPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobstranslateApi.TranslateJobPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**TranslateJobCreate**](TranslateJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

