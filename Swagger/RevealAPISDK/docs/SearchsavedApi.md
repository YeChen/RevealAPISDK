# IO.Swagger.Api.SearchsavedApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SavedSearchDeleteSearchFromSearchFolder**](SearchsavedApi.md#savedsearchdeletesearchfromsearchfolder) | **DELETE** /api/v2/{caseId}/search/saved/{folderId} | Delete A search from a specific folder
[**SavedSearchGetSavedSearches**](SearchsavedApi.md#savedsearchgetsavedsearches) | **GET** /api/v2/{caseId}/search/saved | Get Saved Searches
[**SavedSearchSaveSearch**](SearchsavedApi.md#savedsearchsavesearch) | **POST** /api/v2/{caseId}/search/saved | Create a Saved Search and optionally run it.
[**SavedSearchUpdateSavedSearch**](SearchsavedApi.md#savedsearchupdatesavedsearch) | **PUT** /api/v2/{caseId}/search/saved/{id} | Update a Saved Search and optionally run it.


<a name="savedsearchdeletesearchfromsearchfolder"></a>
# **SavedSearchDeleteSearchFromSearchFolder**
> void SavedSearchDeleteSearchFromSearchFolder (int? caseId, int? folderId, long? search = null)

Delete A search from a specific folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchDeleteSearchFromSearchFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchsavedApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | 
            var search = 789;  // long? |  (optional) 

            try
            {
                // Delete A search from a specific folder
                apiInstance.SavedSearchDeleteSearchFromSearchFolder(caseId, folderId, search);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchsavedApi.SavedSearchDeleteSearchFromSearchFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**|  | 
 **search** | **long?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savedsearchgetsavedsearches"></a>
# **SavedSearchGetSavedSearches**
> PaginatedOfListOfSavedSearch SavedSearchGetSavedSearches (int? caseId, string query = null, int? folderId = null, string type = null, bool? sortByAsc = null, int? start = null, int? count = null)

Get Saved Searches

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchGetSavedSearchesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchsavedApi();
            var caseId = 56;  // int? | 
            var query = query_example;  // string |  (optional) 
            var folderId = 56;  // int? |  (optional)  (default to 0)
            var type = type_example;  // string |  (optional) 
            var sortByAsc = true;  // bool? |  (optional)  (default to true)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 10)

            try
            {
                // Get Saved Searches
                PaginatedOfListOfSavedSearch result = apiInstance.SavedSearchGetSavedSearches(caseId, query, folderId, type, sortByAsc, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchsavedApi.SavedSearchGetSavedSearches: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **query** | **string**|  | [optional] 
 **folderId** | **int?**|  | [optional] [default to 0]
 **type** | **string**|  | [optional] 
 **sortByAsc** | **bool?**|  | [optional] [default to true]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 10]

### Return type

[**PaginatedOfListOfSavedSearch**](PaginatedOfListOfSavedSearch.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savedsearchsavesearch"></a>
# **SavedSearchSaveSearch**
> SearchJobResponse SavedSearchSaveSearch (int? caseId, SavedSearchCreate body = null)

Create a Saved Search and optionally run it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchSaveSearchExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchsavedApi();
            var caseId = 56;  // int? | 
            var body = new SavedSearchCreate(); // SavedSearchCreate |  (optional) 

            try
            {
                // Create a Saved Search and optionally run it.
                SearchJobResponse result = apiInstance.SavedSearchSaveSearch(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchsavedApi.SavedSearchSaveSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**SavedSearchCreate**](SavedSearchCreate.md)|  | [optional] 

### Return type

[**SearchJobResponse**](SearchJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savedsearchupdatesavedsearch"></a>
# **SavedSearchUpdateSavedSearch**
> SearchJobResponse SavedSearchUpdateSavedSearch (int? caseId, long? id, SavedSearchCreate body = null)

Update a Saved Search and optionally run it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchUpdateSavedSearchExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchsavedApi();
            var caseId = 56;  // int? | 
            var id = 789;  // long? | 
            var body = new SavedSearchCreate(); // SavedSearchCreate |  (optional) 

            try
            {
                // Update a Saved Search and optionally run it.
                SearchJobResponse result = apiInstance.SavedSearchUpdateSavedSearch(caseId, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchsavedApi.SavedSearchUpdateSavedSearch: " + e.Message );
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
 **body** | [**SavedSearchCreate**](SavedSearchCreate.md)|  | [optional] 

### Return type

[**SearchJobResponse**](SearchJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

