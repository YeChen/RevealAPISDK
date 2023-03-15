# RevealAPI.Sdk.Api.Resources.TextSetsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTextSetsCreateTextSet**](TextSetsApi.md#documenttextsetscreatetextset) | **POST** /api/v2/{caseId}/textSets | Create a new Document Text Set (original version, requires full info)
[**DocumentTextSetsGet**](TextSetsApi.md#documenttextsetsget) | **GET** /api/v2/{caseId}/textSets | Get all text sets in the case
[**DocumentTextSetsGetCreateTextSetFormData**](TextSetsApi.md#documenttextsetsgetcreatetextsetformdata) | **GET** /api/v2/{caseId}/textSets/createformdata | Get form data to create a text set for ocr, transcribe, and translate jobs


<a name="documenttextsetscreatetextset"></a>
# **DocumentTextSetsCreateTextSet**
> DocumentTextSet DocumentTextSetsCreateTextSet (int? caseId, DocumentTextSetCreate body = null)

Create a new Document Text Set (original version, requires full info)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class DocumentTextSetsCreateTextSetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TextSetsApi();
            var caseId = 56;  // int? | 
            var body = new DocumentTextSetCreate(); // DocumentTextSetCreate |  (optional) 

            try
            {
                // Create a new Document Text Set (original version, requires full info)
                DocumentTextSet result = apiInstance.DocumentTextSetsCreateTextSet(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextSetsApi.DocumentTextSetsCreateTextSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**DocumentTextSetCreate**](DocumentTextSetCreate.md)|  | [optional] 

### Return type

[**DocumentTextSet**](DocumentTextSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttextsetsget"></a>
# **DocumentTextSetsGet**
> PaginatedOfListOfDocumentTextSet2 DocumentTextSetsGet (int? caseId, int? start = null, int? count = null)

Get all text sets in the case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class DocumentTextSetsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TextSetsApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get all text sets in the case
                PaginatedOfListOfDocumentTextSet2 result = apiInstance.DocumentTextSetsGet(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextSetsApi.DocumentTextSetsGet: " + e.Message );
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
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfDocumentTextSet2**](PaginatedOfListOfDocumentTextSet2.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttextsetsgetcreatetextsetformdata"></a>
# **DocumentTextSetsGetCreateTextSetFormData**
> BulkActionForm DocumentTextSetsGetCreateTextSetFormData (int? caseId)

Get form data to create a text set for ocr, transcribe, and translate jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class DocumentTextSetsGetCreateTextSetFormDataExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TextSetsApi();
            var caseId = 56;  // int? | 

            try
            {
                // Get form data to create a text set for ocr, transcribe, and translate jobs
                BulkActionForm result = apiInstance.DocumentTextSetsGetCreateTextSetFormData(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextSetsApi.DocumentTextSetsGetCreateTextSetFormData: " + e.Message );
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

[**BulkActionForm**](BulkActionForm.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

