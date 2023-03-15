# RevealAPI.Sdk.Api.Resources.FoldersApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FoldersDeleteFolderByType**](FoldersApi.md#foldersdeletefolderbytype) | **DELETE** /api/v2/{caseId}/folders/{folderType}/{folderId} | Delete folder
[**FoldersGetFolderCounts**](FoldersApi.md#foldersgetfoldercounts) | **POST** /api/v2/{caseId}/folders/counts | Grabs the counts for folderItems and their children
[**FoldersGetFolders**](FoldersApi.md#foldersgetfolders) | **GET** /api/v2/{caseId}/folders | Get top level folders that can be accessed
[**FoldersGetFoldersByType**](FoldersApi.md#foldersgetfoldersbytype) | **GET** /api/v2/{caseId}/folders/{folderType}/{folderId} | Get immediate child folders for a user


<a name="foldersdeletefolderbytype"></a>
# **FoldersDeleteFolderByType**
> List<FolderItem> FoldersDeleteFolderByType (int? caseId, Object folderType, long? folderId)

Delete folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FoldersDeleteFolderByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersApi();
            var caseId = 56;  // int? | 
            var folderType = new Object(); // Object | 
            var folderId = 789;  // long? | 

            try
            {
                // Delete folder
                List&lt;FolderItem&gt; result = apiInstance.FoldersDeleteFolderByType(caseId, folderType, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersDeleteFolderByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderType** | [**Object**](Object.md)|  | 
 **folderId** | **long?**|  | 

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersgetfoldercounts"></a>
# **FoldersGetFolderCounts**
> FolderDocumentCountsResultsList FoldersGetFolderCounts (int? caseId, bool? allSubFolders = null, FolderCountsQuery body = null)

Grabs the counts for folderItems and their children

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FoldersGetFolderCountsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersApi();
            var caseId = 56;  // int? | 
            var allSubFolders = true;  // bool? | (grab subfolders of subfolders?) (optional) 
            var body = new FolderCountsQuery(); // FolderCountsQuery |  (optional) 

            try
            {
                // Grabs the counts for folderItems and their children
                FolderDocumentCountsResultsList result = apiInstance.FoldersGetFolderCounts(caseId, allSubFolders, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetFolderCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **allSubFolders** | **bool?**| (grab subfolders of subfolders?) | [optional] 
 **body** | [**FolderCountsQuery**](FolderCountsQuery.md)|  | [optional] 

### Return type

[**FolderDocumentCountsResultsList**](FolderDocumentCountsResultsList.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersgetfolders"></a>
# **FoldersGetFolders**
> List<FolderItem> FoldersGetFolders (int? caseId, int? userId = null)

Get top level folders that can be accessed

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FoldersGetFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 

            try
            {
                // Get top level folders that can be accessed
                List&lt;FolderItem&gt; result = apiInstance.FoldersGetFolders(caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersgetfoldersbytype"></a>
# **FoldersGetFoldersByType**
> List<FolderItem> FoldersGetFoldersByType (int? caseId, Object folderType, long? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null, bool? userIdRequested = null)

Get immediate child folders for a user

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class FoldersGetFoldersByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersApi();
            var caseId = 56;  // int? | 
            var folderType = new Object(); // Object | 
            var folderId = 789;  // long? | 
            var userId = 56;  // int? |  (optional) 
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)
            var userIdRequested = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get immediate child folders for a user
                List&lt;FolderItem&gt; result = apiInstance.FoldersGetFoldersByType(caseId, folderType, folderId, userId, uniqueId, isAdminView, userIdRequested);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetFoldersByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderType** | [**Object**](Object.md)|  | 
 **folderId** | **long?**|  | 
 **userId** | **int?**|  | [optional] 
 **uniqueId** | **string**|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]
 **userIdRequested** | **bool?**|  | [optional] [default to false]

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

