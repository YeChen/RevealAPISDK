# IO.Swagger.Api.FolderstranscriptApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranscriptFoldersCreateFolder**](FolderstranscriptApi.md#transcriptfolderscreatefolder) | **POST** /api/v2/{caseId}/folders/transcript | Creates a transcript folder
[**TranscriptFoldersDelete**](FolderstranscriptApi.md#transcriptfoldersdelete) | **DELETE** /api/v2/{caseId}/folders/transcript/{id} | Deletes a transcript folder
[**TranscriptFoldersGet**](FolderstranscriptApi.md#transcriptfoldersget) | **GET** /api/v2/{caseId}/folders/transcript/{folderId} | Get transcript folders
[**TranscriptFoldersGetFolderAccessControl**](FolderstranscriptApi.md#transcriptfoldersgetfolderaccesscontrol) | **GET** /api/v2/{caseId}/folders/transcript/{id}/accessControl | Get ACL permission data for a transcript folder
[**TranscriptFoldersLockDownFolder**](FolderstranscriptApi.md#transcriptfolderslockdownfolder) | **PUT** /api/v2/{caseId}/folders/transcript/{id}/lock | Locks or unlocks the contents in a folder
[**TranscriptFoldersModifyFolder**](FolderstranscriptApi.md#transcriptfoldersmodifyfolder) | **PATCH** /api/v2/{caseId}/folders/transcript/{id} | Updates a folder
[**TranscriptFoldersMoveFolder**](FolderstranscriptApi.md#transcriptfoldersmovefolder) | **PATCH** /api/v2/{caseId}/folders/transcript/{id}/move | Move a folder.


<a name="transcriptfolderscreatefolder"></a>
# **TranscriptFoldersCreateFolder**
> WorkFolder TranscriptFoldersCreateFolder (int? caseId, string organization = null, int? parentId = null, int? displayOrder = null, WorkFolderCreate body = null)

Creates a transcript folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersCreateFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var organization = organization_example;  // string | Where we are creating the folder (leave blank if Review) (optional) 
            var parentId = 56;  // int? | Which folder should be the folder's parent (2 is root) (optional)  (default to 0)
            var displayOrder = 56;  // int? | 1 based index to order under parent or 0-alphabetically, -1-place at end (optional)  (default to 0)
            var body = new WorkFolderCreate(); // WorkFolderCreate |  (optional) 

            try
            {
                // Creates a transcript folder
                WorkFolder result = apiInstance.TranscriptFoldersCreateFolder(caseId, organization, parentId, displayOrder, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersCreateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **organization** | **string**| Where we are creating the folder (leave blank if Review) | [optional] 
 **parentId** | **int?**| Which folder should be the folder&#39;s parent (2 is root) | [optional] [default to 0]
 **displayOrder** | **int?**| 1 based index to order under parent or 0-alphabetically, -1-place at end | [optional] [default to 0]
 **body** | [**WorkFolderCreate**](WorkFolderCreate.md)|  | [optional] 

### Return type

[**WorkFolder**](WorkFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptfoldersdelete"></a>
# **TranscriptFoldersDelete**
> void TranscriptFoldersDelete (int? caseId, int? id)

Deletes a transcript folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Deletes a transcript folder
                apiInstance.TranscriptFoldersDelete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersDelete: " + e.Message );
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

<a name="transcriptfoldersget"></a>
# **TranscriptFoldersGet**
> List<WorkFolder> TranscriptFoldersGet (int? caseId, long? folderId, int? userId = null, bool? immediateOnly = null, bool? getDocumentCounts = null, string uniqueId = null, bool? isAdminView = null, string filterQuery = null, string filterOperator = null, bool? userIdRequested = null)

Get transcript folders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var folderId = 789;  // long? | 
            var userId = 56;  // int? |  (optional) 
            var immediateOnly = true;  // bool? |  (optional)  (default to true)
            var getDocumentCounts = true;  // bool? |  (optional)  (default to true)
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)
            var filterQuery = filterQuery_example;  // string | Partial folder name match (optional) 
            var filterOperator = filterOperator_example;  // string |  (optional) 
            var userIdRequested = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get transcript folders
                List&lt;WorkFolder&gt; result = apiInstance.TranscriptFoldersGet(caseId, folderId, userId, immediateOnly, getDocumentCounts, uniqueId, isAdminView, filterQuery, filterOperator, userIdRequested);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **long?**|  | 
 **userId** | **int?**|  | [optional] 
 **immediateOnly** | **bool?**|  | [optional] [default to true]
 **getDocumentCounts** | **bool?**|  | [optional] [default to true]
 **uniqueId** | **string**|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]
 **filterQuery** | **string**| Partial folder name match | [optional] 
 **filterOperator** | **string**|  | [optional] 
 **userIdRequested** | **bool?**|  | [optional] [default to false]

### Return type

[**List<WorkFolder>**](WorkFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptfoldersgetfolderaccesscontrol"></a>
# **TranscriptFoldersGetFolderAccessControl**
> List<FolderAccessControl> TranscriptFoldersGetFolderAccessControl (int? caseId, int? id)

Get ACL permission data for a transcript folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersGetFolderAccessControlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get ACL permission data for a transcript folder
                List&lt;FolderAccessControl&gt; result = apiInstance.TranscriptFoldersGetFolderAccessControl(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersGetFolderAccessControl: " + e.Message );
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

[**List<FolderAccessControl>**](FolderAccessControl.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptfolderslockdownfolder"></a>
# **TranscriptFoldersLockDownFolder**
> void TranscriptFoldersLockDownFolder (int? caseId, int? id, bool? lockFolder = null, LockWorkFolder body = null)

Locks or unlocks the contents in a folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersLockDownFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Folder we are updating
            var lockFolder = true;  // bool? | True to lock, false to unlock (optional) 
            var body = new LockWorkFolder(); // LockWorkFolder | What aspects of the folder to lock/unlock (optional) 

            try
            {
                // Locks or unlocks the contents in a folder
                apiInstance.TranscriptFoldersLockDownFolder(caseId, id, lockFolder, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersLockDownFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| Folder we are updating | 
 **lockFolder** | **bool?**| True to lock, false to unlock | [optional] 
 **body** | [**LockWorkFolder**](LockWorkFolder.md)| What aspects of the folder to lock/unlock | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptfoldersmodifyfolder"></a>
# **TranscriptFoldersModifyFolder**
> void TranscriptFoldersModifyFolder (int? caseId, int? id, FolderUpdate body = null)

Updates a folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersModifyFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var body = new FolderUpdate(); // FolderUpdate |  (optional) 

            try
            {
                // Updates a folder
                apiInstance.TranscriptFoldersModifyFolder(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersModifyFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| Id for folder whose name we are changing | 
 **body** | [**FolderUpdate**](FolderUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptfoldersmovefolder"></a>
# **TranscriptFoldersMoveFolder**
> void TranscriptFoldersMoveFolder (int? caseId, int? id, long? parentId = null, int? displayOrder = null)

Move a folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TranscriptFoldersMoveFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderstranscriptApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var parentId = 789;  // long? | Parent folder to move under. Must be a transcript folder. Specify 0 keeps same parent (optional)  (default to 0)
            var displayOrder = 56;  // int? | Order under parent. Starting value is 1. 0-order alphabetically (optional)  (default to 0)

            try
            {
                // Move a folder.
                apiInstance.TranscriptFoldersMoveFolder(caseId, id, parentId, displayOrder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderstranscriptApi.TranscriptFoldersMoveFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| Id for folder whose name we are changing | 
 **parentId** | **long?**| Parent folder to move under. Must be a transcript folder. Specify 0 keeps same parent | [optional] [default to 0]
 **displayOrder** | **int?**| Order under parent. Starting value is 1. 0-order alphabetically | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

