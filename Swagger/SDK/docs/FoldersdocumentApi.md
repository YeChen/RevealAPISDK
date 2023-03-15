# RevealAPI.Sdk.Api.Resources.FoldersdocumentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentFoldersDelete**](FoldersdocumentApi.md#documentfoldersdelete) | **DELETE** /api/v2/{caseId}/folders/document/{id} | Deletes a document folder
[**DocumentFoldersGet**](FoldersdocumentApi.md#documentfoldersget) | **GET** /api/v2/{caseId}/folders/document/{folderId} | Get document folders


<a name="documentfoldersdelete"></a>
# **DocumentFoldersDelete**
> void DocumentFoldersDelete (int? caseId, int? id)

Deletes a document folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class DocumentFoldersDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersdocumentApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Deletes a document folder
                apiInstance.DocumentFoldersDelete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersdocumentApi.DocumentFoldersDelete: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentfoldersget"></a>
# **DocumentFoldersGet**
> List<DocumentFolder> DocumentFoldersGet (int? caseId, int? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null)

Get document folders

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class DocumentFoldersGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersdocumentApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get document folders
                List&lt;DocumentFolder&gt; result = apiInstance.DocumentFoldersGet(caseId, folderId, userId, uniqueId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersdocumentApi.DocumentFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 
 **uniqueId** | **string**|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]

### Return type

[**List<DocumentFolder>**](DocumentFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

