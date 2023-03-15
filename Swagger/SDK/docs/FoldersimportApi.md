# RevealAPI.Sdk.Api.Resources.FoldersimportApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportFoldersV2GetFolders**](FoldersimportApi.md#importfoldersv2getfolders) | **GET** /api/v2/{caseId}/folders/imports/{folderId} | Get a list of imports in a case


<a name="importfoldersv2getfolders"></a>
# **ImportFoldersV2GetFolders**
> List<ImportFolder> ImportFoldersV2GetFolders (int? caseId, int? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null)

Get a list of imports in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ImportFoldersV2GetFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersimportApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | Always 1
            var userId = 56;  // int? | Specify 0 to ignore folder security for document counts (optional) 
            var uniqueId = uniqueId_example;  // string | The parent unique id (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get a list of imports in a case
                List&lt;ImportFolder&gt; result = apiInstance.ImportFoldersV2GetFolders(caseId, folderId, userId, uniqueId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersimportApi.ImportFoldersV2GetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**| Always 1 | 
 **userId** | **int?**| Specify 0 to ignore folder security for document counts | [optional] 
 **uniqueId** | **string**| The parent unique id | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]

### Return type

[**List<ImportFolder>**](ImportFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

