# RevealAPI.Sdk.Api.Resources.SearchhistoryApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchHistoryGetSearcHistory**](SearchhistoryApi.md#searchhistorygetsearchistory) | **GET** /api/v2/{caseId}/search/history | Get Searches From History
[**SearchHistoryUpdateSearchHistory**](SearchhistoryApi.md#searchhistoryupdatesearchhistory) | **PATCH** /api/v2/{caseId}/search/history/{id} | Update Search History
[**SearchHistoryUpdateSearchHistoryQuery**](SearchhistoryApi.md#searchhistoryupdatesearchhistoryquery) | **POST** /api/v2/{caseId}/search/history | Update Search History


<a name="searchhistorygetsearchistory"></a>
# **SearchHistoryGetSearcHistory**
> PaginatedListOfHistorySearch SearchHistoryGetSearcHistory (int? caseId, int? start = null, int? count = null)

Get Searches From History

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchHistoryGetSearcHistoryExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchhistoryApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 20)

            try
            {
                // Get Searches From History
                PaginatedListOfHistorySearch result = apiInstance.SearchHistoryGetSearcHistory(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchhistoryApi.SearchHistoryGetSearcHistory: " + e.Message );
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
 **count** | **int?**|  | [optional] [default to 20]

### Return type

[**PaginatedListOfHistorySearch**](PaginatedListOfHistorySearch.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchhistoryupdatesearchhistory"></a>
# **SearchHistoryUpdateSearchHistory**
> void SearchHistoryUpdateSearchHistory (int? caseId, long? id)

Update Search History

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchHistoryUpdateSearchHistoryExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchhistoryApi();
            var caseId = 56;  // int? | 
            var id = 789;  // long? | 

            try
            {
                // Update Search History
                apiInstance.SearchHistoryUpdateSearchHistory(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchhistoryApi.SearchHistoryUpdateSearchHistory: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchhistoryupdatesearchhistoryquery"></a>
# **SearchHistoryUpdateSearchHistoryQuery**
> void SearchHistoryUpdateSearchHistoryQuery (int? caseId, SearchHistoryCreate body = null)

Update Search History

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchHistoryUpdateSearchHistoryQueryExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchhistoryApi();
            var caseId = 56;  // int? | 
            var body = new SearchHistoryCreate(); // SearchHistoryCreate |  (optional) 

            try
            {
                // Update Search History
                apiInstance.SearchHistoryUpdateSearchHistoryQuery(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchhistoryApi.SearchHistoryUpdateSearchHistoryQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**SearchHistoryCreate**](SearchHistoryCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

