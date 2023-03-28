# RevealAPI.V1.Api.Resources.TagPaneApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagPaneCreate**](TagPaneApi.md#tagpanecreate) | **POST** /api/tagPane/create | 
[**TagPaneCreate_0**](TagPaneApi.md#tagpanecreate_0) | **POST** /api/tagPane/item/create | 
[**TagPaneDelete**](TagPaneApi.md#tagpanedelete) | **DELETE** /api/tagPane/delete | 
[**TagPaneGetTagPanes**](TagPaneApi.md#tagpanegettagpanes) | **GET** /api/tagPane | 


<a name="tagpanecreate"></a>
# **TagPaneCreate**
> TagPane TagPaneCreate (int? caseId = null, int? userId = null, TagPaneCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagPaneCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPaneApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var body = new TagPaneCreate(); // TagPaneCreate |  (optional) 

            try
            {
                TagPane result = apiInstance.TagPaneCreate(caseId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPaneApi.TagPaneCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **body** | [**TagPaneCreate**](TagPaneCreate.md)|  | [optional] 

### Return type

[**TagPane**](TagPane.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagpanecreate_0"></a>
# **TagPaneCreate_0**
> TagPaneItem TagPaneCreate_0 (int? caseId = null, int? userId = null, TagPaneItemCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagPaneCreate_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPaneApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var body = new TagPaneItemCreate(); // TagPaneItemCreate |  (optional) 

            try
            {
                TagPaneItem result = apiInstance.TagPaneCreate_0(caseId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPaneApi.TagPaneCreate_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **body** | [**TagPaneItemCreate**](TagPaneItemCreate.md)|  | [optional] 

### Return type

[**TagPaneItem**](TagPaneItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagpanedelete"></a>
# **TagPaneDelete**
> void TagPaneDelete (int? caseId = null, long? userId = null, string profileName = null, string paneName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagPaneDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPaneApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var profileName = profileName_example;  // string |  (optional) 
            var paneName = paneName_example;  // string |  (optional) 

            try
            {
                apiInstance.TagPaneDelete(caseId, userId, profileName, paneName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPaneApi.TagPaneDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **long?**|  | [optional] 
 **profileName** | **string**|  | [optional] 
 **paneName** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagpanegettagpanes"></a>
# **TagPaneGetTagPanes**
> List<TagPane> TagPaneGetTagPanes (string profileName = null, int? caseId = null, int? userId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagPaneGetTagPanesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagPaneApi();
            var profileName = profileName_example;  // string |  (optional) 
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 

            try
            {
                List&lt;TagPane&gt; result = apiInstance.TagPaneGetTagPanes(profileName, caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagPaneApi.TagPaneGetTagPanes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileName** | **string**|  | [optional] 
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 

### Return type

[**List<TagPane>**](TagPane.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

