# RevealAPI.V1.Api.Resources.TagSetsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagSetsCreate**](TagSetsApi.md#tagsetscreate) | **POST** /api/tagSets/create | 
[**TagSetsDelete**](TagSetsApi.md#tagsetsdelete) | **DELETE** /api/tagSets/delete | 
[**TagSetsEdit**](TagSetsApi.md#tagsetsedit) | **POST** /api/tagSets/edit | 
[**TagSetsGetTagSets**](TagSetsApi.md#tagsetsgettagsets) | **GET** /api/tagSets | 


<a name="tagsetscreate"></a>
# **TagSetsCreate**
> TagSet TagSetsCreate (int? caseId = null, long? userId = null, TagSetCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagSetsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagSetsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var body = new TagSetCreate(); // TagSetCreate |  (optional) 

            try
            {
                TagSet result = apiInstance.TagSetsCreate(caseId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagSetsApi.TagSetsCreate: " + e.Message );
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
 **body** | [**TagSetCreate**](TagSetCreate.md)|  | [optional] 

### Return type

[**TagSet**](TagSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsetsdelete"></a>
# **TagSetsDelete**
> void TagSetsDelete (int? caseId = null, long? userId = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagSetsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagSetsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.TagSetsDelete(caseId, userId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagSetsApi.TagSetsDelete: " + e.Message );
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
 **name** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsetsedit"></a>
# **TagSetsEdit**
> TagSet TagSetsEdit (int? caseId = null, long? userId = null, TagSet body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagSetsEditExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagSetsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var body = new TagSet(); // TagSet |  (optional) 

            try
            {
                TagSet result = apiInstance.TagSetsEdit(caseId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagSetsApi.TagSetsEdit: " + e.Message );
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
 **body** | [**TagSet**](TagSet.md)|  | [optional] 

### Return type

[**TagSet**](TagSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsetsgettagsets"></a>
# **TagSetsGetTagSets**
> List<TagSet> TagSetsGetTagSets (int? caseId = null, long? userId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagSetsGetTagSetsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagSetsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 

            try
            {
                List&lt;TagSet&gt; result = apiInstance.TagSetsGetTagSets(caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagSetsApi.TagSetsGetTagSets: " + e.Message );
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

### Return type

[**List<TagSet>**](TagSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

