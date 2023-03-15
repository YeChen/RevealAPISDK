# RevealAPI.Sdk.Api.Resources.FiltersApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterGetCompleted**](FiltersApi.md#filtergetcompleted) | **GET** /api/v2/{caseId}/filters/completedAssignment | Get Completed Assignments
[**FilterGetCounts2**](FiltersApi.md#filtergetcounts2) | **POST** /api/v2/{caseId}/filters/count | Get Counts for given Filters (multiple)
[**FilterGetCounts3**](FiltersApi.md#filtergetcounts3) | **POST** /api/v2/{caseId}/filters/count2 | Get Counts for given Filters (multiple)
[**FilterGetFilters**](FiltersApi.md#filtergetfilters) | **GET** /api/v2/{caseId}/filters | Get filters for sidebar
[**FilterGetHeaderFilters**](FiltersApi.md#filtergetheaderfilters) | **GET** /api/v2/{caseId}/filters/headers | Get filter headers
[**FilterGetSomeFilters**](FiltersApi.md#filtergetsomefilters) | **GET** /api/v2/{caseId}/filters/{id} | Get filters for sidebar sub categories given the unique id of the header filter


<a name="filtergetcompleted"></a>
# **FilterGetCompleted**
> List<FolderItem> FilterGetCompleted (int? caseId, string uniqueId = null, bool? getWithDetails = null)

Get Completed Assignments

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetCompletedExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var getWithDetails = true;  // bool? |  (optional) 

            try
            {
                // Get Completed Assignments
                List&lt;FolderItem&gt; result = apiInstance.FilterGetCompleted(caseId, uniqueId, getWithDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetCompleted: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **uniqueId** | **string**|  | [optional] 
 **getWithDetails** | **bool?**|  | [optional] 

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtergetcounts2"></a>
# **FilterGetCounts2**
> List<FilterCountResults> FilterGetCounts2 (int? caseId, FilterCountRequest body = null)

Get Counts for given Filters (multiple)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetCounts2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var body = new FilterCountRequest(); // FilterCountRequest |  (optional) 

            try
            {
                // Get Counts for given Filters (multiple)
                List&lt;FilterCountResults&gt; result = apiInstance.FilterGetCounts2(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetCounts2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**FilterCountRequest**](FilterCountRequest.md)|  | [optional] 

### Return type

[**List<FilterCountResults>**](FilterCountResults.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtergetcounts3"></a>
# **FilterGetCounts3**
> List<FilterCountResults> FilterGetCounts3 (int? caseId, FilterCountRequestDTO body = null)

Get Counts for given Filters (multiple)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetCounts3Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var body = new FilterCountRequestDTO(); // FilterCountRequestDTO |  (optional) 

            try
            {
                // Get Counts for given Filters (multiple)
                List&lt;FilterCountResults&gt; result = apiInstance.FilterGetCounts3(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetCounts3: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**FilterCountRequestDTO**](FilterCountRequestDTO.md)|  | [optional] 

### Return type

[**List<FilterCountResults>**](FilterCountResults.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtergetfilters"></a>
# **FilterGetFilters**
> List<FolderItem> FilterGetFilters (int? caseId, string uniqueFolderId = null, bool? isAdminView = null)

Get filters for sidebar

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetFiltersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var uniqueFolderId = uniqueFolderId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get filters for sidebar
                List&lt;FolderItem&gt; result = apiInstance.FilterGetFilters(caseId, uniqueFolderId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **uniqueFolderId** | **string**|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtergetheaderfilters"></a>
# **FilterGetHeaderFilters**
> List<FolderItem> FilterGetHeaderFilters (int? caseId, string uniqueFolderId = null, bool? isAdminView = null)

Get filter headers

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetHeaderFiltersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var uniqueFolderId = uniqueFolderId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get filter headers
                List&lt;FolderItem&gt; result = apiInstance.FilterGetHeaderFilters(caseId, uniqueFolderId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetHeaderFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **uniqueFolderId** | **string**|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filtergetsomefilters"></a>
# **FilterGetSomeFilters**
> PaginatedOfIEnumerableOfFolderItem FilterGetSomeFilters (int? caseId, int? id, Object type = null, string uniqueFolderId = null, int? start = null, int? count = null, bool? isAdminView = null)

Get filters for sidebar sub categories given the unique id of the header filter

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FilterGetSomeFiltersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FiltersApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var type = new Object(); // Object |  (optional) 
            var uniqueFolderId = uniqueFolderId_example;  // string |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get filters for sidebar sub categories given the unique id of the header filter
                PaginatedOfIEnumerableOfFolderItem result = apiInstance.FilterGetSomeFilters(caseId, id, type, uniqueFolderId, start, count, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FiltersApi.FilterGetSomeFilters: " + e.Message );
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
 **type** | [**Object**](Object.md)|  | [optional] 
 **uniqueFolderId** | **string**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]
 **isAdminView** | **bool?**|  | [optional] [default to false]

### Return type

[**PaginatedOfIEnumerableOfFolderItem**](PaginatedOfIEnumerableOfFolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

