# RevealAPI.V1.Api.Resources.DocumentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentPost**](DocumentApi.md#documentpost) | **POST** /api/document | 
[**DocumentSetDocumentText**](DocumentApi.md#documentsetdocumenttext) | **POST** /api/document/SetDocumentText | 


<a name="documentpost"></a>
# **DocumentPost**
> List<Document> DocumentPost (int? caseId = null, int? userId = null, DocumentsRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var body = new DocumentsRequest(); // DocumentsRequest |  (optional) 

            try
            {
                List&lt;Document&gt; result = apiInstance.DocumentPost(caseId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentPost: " + e.Message );
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
 **body** | [**DocumentsRequest**](DocumentsRequest.md)|  | [optional] 

### Return type

[**List<Document>**](Document.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsetdocumenttext"></a>
# **DocumentSetDocumentText**
> void DocumentSetDocumentText (int? caseId = null, string keyField = null, List<SetDocumentTextRequest> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentSetDocumentTextExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentApi();
            var caseId = 56;  // int? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var body = new List<SetDocumentTextRequest>(); // List<SetDocumentTextRequest> |  (optional) 

            try
            {
                apiInstance.DocumentSetDocumentText(caseId, keyField, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentApi.DocumentSetDocumentText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **keyField** | **string**|  | [optional] 
 **body** | [**List&lt;SetDocumentTextRequest&gt;**](SetDocumentTextRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

