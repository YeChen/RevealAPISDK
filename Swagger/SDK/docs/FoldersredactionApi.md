# RevealAPI.Sdk.Api.Resources.FoldersredactionApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RedactionFoldersCreateFolder**](FoldersredactionApi.md#redactionfolderscreatefolder) | **POST** /api/v2/{caseId}/folders/redaction | Creates a redaction folder
[**RedactionFoldersDelete**](FoldersredactionApi.md#redactionfoldersdelete) | **DELETE** /api/v2/{caseId}/folders/redaction/{id} | Deletes a redaction folder
[**RedactionFoldersGet**](FoldersredactionApi.md#redactionfoldersget) | **GET** /api/v2/{caseId}/folders/redaction/{folderId} | Get redaction folders
[**RedactionFoldersGetFolderAccessControl**](FoldersredactionApi.md#redactionfoldersgetfolderaccesscontrol) | **GET** /api/v2/{caseId}/folders/redaction/{id}/accessControl | Get ACL permission data for a redaction folder
[**RedactionFoldersLockDownFolder**](FoldersredactionApi.md#redactionfolderslockdownfolder) | **PUT** /api/v2/{caseId}/folders/redaction/{id}/lock | Locks or unlocks the contents in a folder
[**RedactionFoldersModifyFolder**](FoldersredactionApi.md#redactionfoldersmodifyfolder) | **PATCH** /api/v2/{caseId}/folders/redaction/{id} | Updates a folder
[**RedactionFoldersMoveFolder**](FoldersredactionApi.md#redactionfoldersmovefolder) | **PATCH** /api/v2/{caseId}/folders/redaction/{id}/move | Move a folder.


<a name="redactionfolderscreatefolder"></a>
# **RedactionFoldersCreateFolder**
> WorkFolder RedactionFoldersCreateFolder (int? caseId, string organization = null, int? parentId = null, int? displayOrder = null, WorkFolderCreate body = null)

Creates a redaction folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RedactionFoldersCreateFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var organization = organization_example;  // string | Where we are creating the folder (leave blank if Review) (optional) 
            var parentId = 56;  // int? | Which folder should be the folder's parent (2 is root) (optional)  (default to 0)
            var displayOrder = 56;  // int? | 1 based index to order under parent or 0-alphabetically, -1-place at end (optional)  (default to 0)
            var body = new WorkFolderCreate(); // WorkFolderCreate |  (optional) 

            try
            {
                // Creates a redaction folder
                WorkFolder result = apiInstance.RedactionFoldersCreateFolder(caseId, organization, parentId, displayOrder, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersCreateFolder: " + e.Message );
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

<a name="redactionfoldersdelete"></a>
# **RedactionFoldersDelete**
> void RedactionFoldersDelete (int? caseId, int? id)

Deletes a redaction folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RedactionFoldersDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Deletes a redaction folder
                apiInstance.RedactionFoldersDelete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersDelete: " + e.Message );
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

<a name="redactionfoldersget"></a>
# **RedactionFoldersGet**
> List<WorkFolder> RedactionFoldersGet (int? caseId, long? folderId, int? userId = null, bool? immediateOnly = null, bool? getDocumentCounts = null, string uniqueId = null, string filterQuery = null, Object filterOperator = null, bool? isAdminView = null, bool? userIdRequested = null)

Get redaction folders

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RedactionFoldersGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var folderId = 789;  // long? | 
            var userId = 56;  // int? |  (optional) 
            var immediateOnly = true;  // bool? |  (optional)  (default to true)
            var getDocumentCounts = true;  // bool? |  (optional)  (default to true)
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var filterQuery = filterQuery_example;  // string | Partial folder name match (optional) 
            var filterOperator = new Object(); // Object |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)
            var userIdRequested = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get redaction folders
                List&lt;WorkFolder&gt; result = apiInstance.RedactionFoldersGet(caseId, folderId, userId, immediateOnly, getDocumentCounts, uniqueId, filterQuery, filterOperator, isAdminView, userIdRequested);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersGet: " + e.Message );
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

<a name="redactionfoldersgetfolderaccesscontrol"></a>
# **RedactionFoldersGetFolderAccessControl**
> List<FolderAccessControl> RedactionFoldersGetFolderAccessControl (int? caseId, int? id)

Get ACL permission data for a redaction folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RedactionFoldersGetFolderAccessControlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get ACL permission data for a redaction folder
                List&lt;FolderAccessControl&gt; result = apiInstance.RedactionFoldersGetFolderAccessControl(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersGetFolderAccessControl: " + e.Message );
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

<a name="redactionfolderslockdownfolder"></a>
# **RedactionFoldersLockDownFolder**
> void RedactionFoldersLockDownFolder (int? caseId, int? id, bool? lockFolder = null, LockWorkFolder body = null)

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
    public class RedactionFoldersLockDownFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Folder we are updating
            var lockFolder = true;  // bool? | True to lock, false to unlock (optional) 
            var body = new LockWorkFolder(); // LockWorkFolder | What aspects of the folder to lock/unlock (optional) 

            try
            {
                // Locks or unlocks the contents in a folder
                apiInstance.RedactionFoldersLockDownFolder(caseId, id, lockFolder, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersLockDownFolder: " + e.Message );
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

<a name="redactionfoldersmodifyfolder"></a>
# **RedactionFoldersModifyFolder**
> void RedactionFoldersModifyFolder (int? caseId, int? id, FolderUpdate body = null)

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
    public class RedactionFoldersModifyFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var body = new FolderUpdate(); // FolderUpdate |  (optional) 

            try
            {
                // Updates a folder
                apiInstance.RedactionFoldersModifyFolder(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersModifyFolder: " + e.Message );
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

<a name="redactionfoldersmovefolder"></a>
# **RedactionFoldersMoveFolder**
> void RedactionFoldersMoveFolder (int? caseId, int? id, long? parentId = null, int? displayOrder = null)

Move a folder.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RedactionFoldersMoveFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersredactionApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | Id for folder whose name we are changing
            var parentId = 789;  // long? | Parent folder to move under. Must be a redaction folder. Specify 0 keeps same parent (optional)  (default to 0)
            var displayOrder = 56;  // int? | Order under parent. Starting value is 1. 0-order alphabetically (optional)  (default to 0)

            try
            {
                // Move a folder.
                apiInstance.RedactionFoldersMoveFolder(caseId, id, parentId, displayOrder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersredactionApi.RedactionFoldersMoveFolder: " + e.Message );
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
 **parentId** | **long?**| Parent folder to move under. Must be a redaction folder. Specify 0 keeps same parent | [optional] [default to 0]
 **displayOrder** | **int?**| Order under parent. Starting value is 1. 0-order alphabetically | [optional] [default to 0]

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

