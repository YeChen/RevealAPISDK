# RevealAPI.V1.Api.Resources.WordListApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WordListGet**](WordListApi.md#wordlistget) | **GET** /api/wordlist | 
[**WordListPost**](WordListApi.md#wordlistpost) | **POST** /api/wordlist | 


<a name="wordlistget"></a>
# **WordListGet**
> List<WordList> WordListGet (int? caseId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WordListGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WordListApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                List&lt;WordList&gt; result = apiInstance.WordListGet(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordListApi.WordListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 

### Return type

[**List<WordList>**](WordList.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wordlistpost"></a>
# **WordListPost**
> WordListCreate WordListPost (int? caseId = null, WordListCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WordListPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WordListApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new WordListCreate(); // WordListCreate |  (optional) 

            try
            {
                WordListCreate result = apiInstance.WordListPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordListApi.WordListPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**WordListCreate**](WordListCreate.md)|  | [optional] 

### Return type

[**WordListCreate**](WordListCreate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

