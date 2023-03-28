# RevealAPI.V1.Api.Resources.ImportBatchApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportBatchGet**](ImportBatchApi.md#importbatchget) | **GET** /api/importBatch | 
[**ImportBatchGetDocumentIds**](ImportBatchApi.md#importbatchgetdocumentids) | **GET** /api/importBatch/documentIds | 


<a name="importbatchget"></a>
# **ImportBatchGet**
> List<ImportBatch> ImportBatchGet (int? caseId = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ImportBatchGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImportBatchApi();
            var caseId = 56;  // int? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                List&lt;ImportBatch&gt; result = apiInstance.ImportBatchGet(caseId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportBatchApi.ImportBatchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **name** | **string**|  | [optional] 

### Return type

[**List<ImportBatch>**](ImportBatch.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importbatchgetdocumentids"></a>
# **ImportBatchGetDocumentIds**
> List<string> ImportBatchGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ImportBatchGetDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImportBatchApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.ImportBatchGetDocumentIds(caseId, userId, keyField, startRow, batchSize, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportBatchApi.ImportBatchGetDocumentIds: " + e.Message );
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
 **keyField** | **string**|  | [optional] 
 **startRow** | **int?**|  | [optional] 
 **batchSize** | **int?**|  | [optional] 
 **name** | **string**|  | [optional] 

### Return type

**List<string>**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

