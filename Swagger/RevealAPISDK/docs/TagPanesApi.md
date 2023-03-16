# IO.Swagger.Api.TagPanesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagPanesUserProfilesGetAllTagPanes**](TagPanesApi.md#tagpanesuserprofilesgetalltagpanes) | **GET** /api/v2/{caseId}/tagPanes | 
[**TagProfilePanesGetTagPane**](TagPanesApi.md#tagprofilepanesgettagpane) | **GET** /api/v2/{caseId}/tagProfiles/{profileId}/panes/{id} | 
[**TagProfilePanesGetTagPanes**](TagPanesApi.md#tagprofilepanesgettagpanes) | **GET** /api/v2/{caseId}/tagProfiles/{profileId}/panes | 


<a name="tagpanesuserprofilesgetalltagpanes"></a>
# **TagPanesUserProfilesGetAllTagPanes**
> List<TagPaneGet> TagPanesUserProfilesGetAllTagPanes (int? caseId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagPanesUserProfilesGetAllTagPanesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPanesApi();
            var caseId = 56;  // int? | 

            try
            {
                List&lt;TagPaneGet&gt; result = apiInstance.TagPanesUserProfilesGetAllTagPanes(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPanesApi.TagPanesUserProfilesGetAllTagPanes: " + e.Message );
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

[**List<TagPaneGet>**](TagPaneGet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilepanesgettagpane"></a>
# **TagProfilePanesGetTagPane**
> TagPaneGet TagProfilePanesGetTagPane (int? caseId, int? profileId, int? id, int? userId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfilePanesGetTagPaneExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPanesApi();
            var caseId = 56;  // int? | 
            var profileId = 56;  // int? | 
            var id = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 

            try
            {
                TagPaneGet result = apiInstance.TagProfilePanesGetTagPane(caseId, profileId, id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPanesApi.TagProfilePanesGetTagPane: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **profileId** | **int?**|  | 
 **id** | **int?**|  | 
 **userId** | **int?**|  | [optional] 

### Return type

[**TagPaneGet**](TagPaneGet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilepanesgettagpanes"></a>
# **TagProfilePanesGetTagPanes**
> PaginatedOfIEnumerableOfTagPaneGet TagProfilePanesGetTagPanes (int? caseId, int? profileId, int? userId = null, int? start = null, int? count = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfilePanesGetTagPanesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPanesApi();
            var caseId = 56;  // int? | 
            var profileId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                PaginatedOfIEnumerableOfTagPaneGet result = apiInstance.TagProfilePanesGetTagPanes(caseId, profileId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPanesApi.TagProfilePanesGetTagPanes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **profileId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfTagPaneGet**](PaginatedOfIEnumerableOfTagPaneGet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

