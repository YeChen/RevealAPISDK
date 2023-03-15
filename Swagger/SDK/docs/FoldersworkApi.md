# RevealAPI.Sdk.Api.Resources.FoldersworkApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorkFoldersV2AddDocuments**](FoldersworkApi.md#workfoldersv2adddocuments) | **PATCH** /api/v2/{caseId}/folders/work/{id}/docs | Add or remove documents in a folder
[**WorkFoldersV2CreateFolder**](FoldersworkApi.md#workfoldersv2createfolder) | **POST** /api/v2/{caseId}/folders/work | Creates a work folder
[**WorkFoldersV2Delete**](FoldersworkApi.md#workfoldersv2delete) | **DELETE** /api/v2/{caseId}/folders/work/{id} | Deletes a work folder
[**WorkFoldersV2GetFolderAccessControl**](FoldersworkApi.md#workfoldersv2getfolderaccesscontrol) | **GET** /api/v2/{caseId}/folders/work/{id}/accessControl | Get ACL permission data for a work folder
[**WorkFoldersV2GetFolders**](FoldersworkApi.md#workfoldersv2getfolders) | **GET** /api/v2/{caseId}/folders/work/{folderId} | Get a list of work folders for a user in a case
[**WorkFoldersV2LockDownFolder**](FoldersworkApi.md#workfoldersv2lockdownfolder) | **PUT** /api/v2/{caseId}/folders/work/{id}/lock | Locks or unlocks the contents in a folder
[**WorkFoldersV2ModifyFolder**](FoldersworkApi.md#workfoldersv2modifyfolder) | **PATCH** /api/v2/{caseId}/folders/work/{id} | Updates a folder
[**WorkFoldersV2MoveFolder**](FoldersworkApi.md#workfoldersv2movefolder) | **PATCH** /api/v2/{caseId}/folders/work/{id}/move | Move a folder


<a name="workfoldersv2adddocuments"></a>
# **WorkFoldersV2AddDocuments**
> CreateJobResponse WorkFoldersV2AddDocuments (int? caseId, int? id, Object updateOption = null, List<long?> body = null)

Add or remove documents in a folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2AddDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Folder Id
            var updateOption = new Object(); // Object |  (optional) 
            var body = ;  // List<long?> | List of documents by ITEMID (optional) 

            try
            {
                // Add or remove documents in a folder
                CreateJobResponse result = apiInstance.WorkFoldersV2AddDocuments(caseId, id, updateOption, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2AddDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**| Folder Id | 
 **updateOption** | [**Object**](Object.md)|  | [optional] 
 **body** | **List&lt;long?&gt;**| List of documents by ITEMID | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldersv2createfolder"></a>
# **WorkFoldersV2CreateFolder**
> WorkFolder WorkFoldersV2CreateFolder (int? caseId, string organization = null, int? parentId = null, int? displayOrder = null, WorkFolderCreate body = null)

Creates a work folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2CreateFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var organization = organization_example;  // string | Where we are creating the folder (leave blank if Review) (optional) 
            var parentId = 56;  // int? | Which folder should be the folder's parent (optional)  (default to 0)
            var displayOrder = 56;  // int? | 1 based index to order under parent or 0-alphabetically, -1-place at end (optional)  (default to 0)
            var body = new WorkFolderCreate(); // WorkFolderCreate |  (optional) 

            try
            {
                // Creates a work folder
                WorkFolder result = apiInstance.WorkFoldersV2CreateFolder(caseId, organization, parentId, displayOrder, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2CreateFolder: " + e.Message );
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
 **parentId** | **int?**| Which folder should be the folder&#39;s parent | [optional] [default to 0]
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

<a name="workfoldersv2delete"></a>
# **WorkFoldersV2Delete**
> void WorkFoldersV2Delete (int? caseId, int? id)

Deletes a work folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Deletes a work folder
                apiInstance.WorkFoldersV2Delete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2Delete: " + e.Message );
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

<a name="workfoldersv2getfolderaccesscontrol"></a>
# **WorkFoldersV2GetFolderAccessControl**
> List<FolderAccessControl> WorkFoldersV2GetFolderAccessControl (int? caseId, int? id)

Get ACL permission data for a work folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2GetFolderAccessControlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get ACL permission data for a work folder
                List&lt;FolderAccessControl&gt; result = apiInstance.WorkFoldersV2GetFolderAccessControl(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2GetFolderAccessControl: " + e.Message );
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

<a name="workfoldersv2getfolders"></a>
# **WorkFoldersV2GetFolders**
> List<WorkFolder> WorkFoldersV2GetFolders (int? caseId, int? folderId, int? userId = null, bool? immediateOnly = null, bool? getDocumentCounts = null, string uniqueId = null, string filterQuery = null, Object filterOperator = null, bool? isAdminView = null, bool? userIdRequested = null)

Get a list of work folders for a user in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2GetFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | 1-Root ID for public folders
            var userId = 56;  // int? | Specify 0 to ignore folder security (optional) 
            var immediateOnly = true;  // bool? | Only get folders immediate below the parent folder specified (optional)  (default to true)
            var getDocumentCounts = true;  // bool? | Return the number of documents in each folder (requires more computation) (optional)  (default to true)
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var filterQuery = filterQuery_example;  // string | Partial folder name match (optional) 
            var filterOperator = new Object(); // Object |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)
            var userIdRequested = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get a list of work folders for a user in a case
                List&lt;WorkFolder&gt; result = apiInstance.WorkFoldersV2GetFolders(caseId, folderId, userId, immediateOnly, getDocumentCounts, uniqueId, filterQuery, filterOperator, isAdminView, userIdRequested);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2GetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**| 1-Root ID for public folders | 
 **userId** | **int?**| Specify 0 to ignore folder security | [optional] 
 **immediateOnly** | **bool?**| Only get folders immediate below the parent folder specified | [optional] [default to true]
 **getDocumentCounts** | **bool?**| Return the number of documents in each folder (requires more computation) | [optional] [default to true]
 **uniqueId** | **string**|  | [optional] 
 **filterQuery** | **string**| Partial folder name match | [optional] 
 **filterOperator** | [**Object**](Object.md)|  | [optional] 
 **isAdminView** | **bool?**|  | [optional] [default to false]
 **userIdRequested** | **bool?**|  | [optional] [default to false]

### Return type

[**List<WorkFolder>**](WorkFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldersv2lockdownfolder"></a>
# **WorkFoldersV2LockDownFolder**
> void WorkFoldersV2LockDownFolder (int? caseId, int? id, bool? lockFolder = null, LockWorkFolder body = null)

Locks or unlocks the contents in a folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2LockDownFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Folder we are updating
            var lockFolder = true;  // bool? | True to lock, false to unlock (optional) 
            var body = new LockWorkFolder(); // LockWorkFolder | What aspects of the folder to lock/unlock (optional) 

            try
            {
                // Locks or unlocks the contents in a folder
                apiInstance.WorkFoldersV2LockDownFolder(caseId, id, lockFolder, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2LockDownFolder: " + e.Message );
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

<a name="workfoldersv2modifyfolder"></a>
# **WorkFoldersV2ModifyFolder**
> void WorkFoldersV2ModifyFolder (int? caseId, int? id, FolderUpdate body = null)

Updates a folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2ModifyFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var body = new FolderUpdate(); // FolderUpdate |  (optional) 

            try
            {
                // Updates a folder
                apiInstance.WorkFoldersV2ModifyFolder(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2ModifyFolder: " + e.Message );
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

<a name="workfoldersv2movefolder"></a>
# **WorkFoldersV2MoveFolder**
> void WorkFoldersV2MoveFolder (int? caseId, int? id, long? parentId = null, int? displayOrder = null)

Move a folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class WorkFoldersV2MoveFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersworkApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var parentId = 789;  // long? | Parent folder to move under. Specify 0 keeps same parent (optional)  (default to 0)
            var displayOrder = 56;  // int? | Order under parent. Starting value is 1. 0-order alphabetically (optional)  (default to 0)

            try
            {
                // Move a folder
                apiInstance.WorkFoldersV2MoveFolder(caseId, id, parentId, displayOrder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersworkApi.WorkFoldersV2MoveFolder: " + e.Message );
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
 **parentId** | **long?**| Parent folder to move under. Specify 0 keeps same parent | [optional] [default to 0]
 **displayOrder** | **int?**| Order under parent. Starting value is 1. 0-order alphabetically | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

