# RevealAPI.Sdk.Api.Resources.SearchApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchGetSearchOperatorsForField**](SearchApi.md#searchgetsearchoperatorsforfield) | **GET** /api/v2/{caseId}/fields/{id}/searchOperators | Get search operators for a metadata field
[**SearchSearch**](SearchApi.md#searchsearch) | **POST** /api/v2/{caseId}/search | 
[**SearchValidate**](SearchApi.md#searchvalidate) | **POST** /api/v2/{caseId}/search/validaterql | Validate Reveal Query Language syntax


<a name="searchgetsearchoperatorsforfield"></a>
# **SearchGetSearchOperatorsForField**
> List<SearchExpressionOperators> SearchGetSearchOperatorsForField (int? caseId, int? id)

Get search operators for a metadata field

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchGetSearchOperatorsForFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get search operators for a metadata field
                List&lt;SearchExpressionOperators&gt; result = apiInstance.SearchGetSearchOperatorsForField(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchGetSearchOperatorsForField: " + e.Message );
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

[**List<SearchExpressionOperators>**](SearchExpressionOperators.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchsearch"></a>
# **SearchSearch**
> SearchResults SearchSearch (int? caseId, SearchCriteria body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchSearchExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchApi();
            var caseId = 56;  // int? | 
            var body = new SearchCriteria(); // SearchCriteria |  (optional) 

            try
            {
                SearchResults result = apiInstance.SearchSearch(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**SearchCriteria**](SearchCriteria.md)|  | [optional] 

### Return type

[**SearchResults**](SearchResults.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvalidate"></a>
# **SearchValidate**
> List<ValidationResult> SearchValidate (int? caseId, QueryRequest body = null)

Validate Reveal Query Language syntax

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class SearchValidateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SearchApi();
            var caseId = 56;  // int? | 
            var body = new QueryRequest(); // QueryRequest | RQL to validate (optional) 

            try
            {
                // Validate Reveal Query Language syntax
                List&lt;ValidationResult&gt; result = apiInstance.SearchValidate(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**QueryRequest**](QueryRequest.md)| RQL to validate | [optional] 

### Return type

[**List<ValidationResult>**](ValidationResult.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

