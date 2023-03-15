# RevealAPI.Sdk.Api.Resources.TagsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagV2GetAIModelTagsByUser**](TagsApi.md#tagv2getaimodeltagsbyuser) | **GET** /api/v2/{caseId}/tags/userId/{userId} | get Tags (Name, AI Model id) by UserId
[**TagV2GetRevealAITags**](TagsApi.md#tagv2getrevealaitags) | **GET** /api/v2/{caseId}/tags/aiModelId/{aiModelId} | get all tags for an AI Model (Cosmic Model)
[**TagV2GetTagDocCount**](TagsApi.md#tagv2gettagdoccount) | **POST** /api/v2/{caseId}/tags/count | get doc count for list of tags


<a name="tagv2getaimodeltagsbyuser"></a>
# **TagV2GetAIModelTagsByUser**
> List<AIModelTag> TagV2GetAIModelTagsByUser (int? caseId, int? userId)

get Tags (Name, AI Model id) by UserId

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class TagV2GetAIModelTagsByUserExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 

            try
            {
                // get Tags (Name, AI Model id) by UserId
                List&lt;AIModelTag&gt; result = apiInstance.TagV2GetAIModelTagsByUser(caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagV2GetAIModelTagsByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | 

### Return type

[**List<AIModelTag>**](AIModelTag.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagv2getrevealaitags"></a>
# **TagV2GetRevealAITags**
> List<AIModelTagSet> TagV2GetRevealAITags (int? caseId, int? aiModelId)

get all tags for an AI Model (Cosmic Model)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class TagV2GetRevealAITagsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? | 
            var aiModelId = 56;  // int? | 

            try
            {
                // get all tags for an AI Model (Cosmic Model)
                List&lt;AIModelTagSet&gt; result = apiInstance.TagV2GetRevealAITags(caseId, aiModelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagV2GetRevealAITags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **aiModelId** | **int?**|  | 

### Return type

[**List<AIModelTagSet>**](AIModelTagSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagv2gettagdoccount"></a>
# **TagV2GetTagDocCount**
> AggregationSearchResults TagV2GetTagDocCount (int? caseId, TagCountQuery body = null)

get doc count for list of tags

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class TagV2GetTagDocCountExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? | 
            var body = new TagCountQuery(); // TagCountQuery |  (optional) 

            try
            {
                // get doc count for list of tags
                AggregationSearchResults result = apiInstance.TagV2GetTagDocCount(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagV2GetTagDocCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**TagCountQuery**](TagCountQuery.md)|  | [optional] 

### Return type

[**AggregationSearchResults**](AggregationSearchResults.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

