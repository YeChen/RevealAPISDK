# RevealAPI.Sdk.Api.Resources.JobssearchApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchJobCreateSearchAndWait**](JobssearchApi.md#searchjobcreatesearchandwait) | **POST** /api/v2/{caseId}/jobs/search | Create, run, and wait for a Search Job to complete
[**SearchJobGetSearchJob**](JobssearchApi.md#searchjobgetsearchjob) | **GET** /api/v2/{caseId}/jobs/search/{id} | Get a Search Job


<a name="searchjobcreatesearchandwait"></a>
# **SearchJobCreateSearchAndWait**
> SearchJobResponse SearchJobCreateSearchAndWait (int? caseId, ISearchClause body = null)

Create, run, and wait for a Search Job to complete

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchJobCreateSearchAndWaitExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssearchApi();
            var caseId = 56;  // int? | 
            var body = new ISearchClause(); // ISearchClause |  (optional) 

            try
            {
                // Create, run, and wait for a Search Job to complete
                SearchJobResponse result = apiInstance.SearchJobCreateSearchAndWait(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssearchApi.SearchJobCreateSearchAndWait: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**ISearchClause**](ISearchClause.md)|  | [optional] 

### Return type

[**SearchJobResponse**](SearchJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchjobgetsearchjob"></a>
# **SearchJobGetSearchJob**
> SearchJob SearchJobGetSearchJob (int? caseId, long? id)

Get a Search Job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchJobGetSearchJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobssearchApi();
            var caseId = 56;  // int? | 
            var id = 789;  // long? | 

            try
            {
                // Get a Search Job
                SearchJob result = apiInstance.SearchJobGetSearchJob(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobssearchApi.SearchJobGetSearchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **long?**|  | 

### Return type

[**SearchJob**](SearchJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

