# IO.Swagger.Api.FolderssecuredApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecuredFoldersV2GetFolders**](FolderssecuredApi.md#securedfoldersv2getfolders) | **GET** /api/v2/{caseId}/folders/secured/{folderId} | Get a list of secured folders which are things like \&quot;by user\&quot;, \&quot;by team\&quot; or unsecured


<a name="securedfoldersv2getfolders"></a>
# **SecuredFoldersV2GetFolders**
> List<FolderItem> SecuredFoldersV2GetFolders (int? caseId, int? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null)

Get a list of secured folders which are things like \"by user\", \"by team\" or unsecured

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SecuredFoldersV2GetFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssecuredApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | -2 by team, -3, by user
            var userId = 56;  // int? | Specify 0 to ignore folder security for document counts (optional) 
            var uniqueId = uniqueId_example;  // string | The parent unique id (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to true)

            try
            {
                // Get a list of secured folders which are things like \"by user\", \"by team\" or unsecured
                List&lt;FolderItem&gt; result = apiInstance.SecuredFoldersV2GetFolders(caseId, folderId, userId, uniqueId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssecuredApi.SecuredFoldersV2GetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**| -2 by team, -3, by user | 
 **userId** | **int?**| Specify 0 to ignore folder security for document counts | [optional] 
 **uniqueId** | **string**| The parent unique id | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to true]

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

