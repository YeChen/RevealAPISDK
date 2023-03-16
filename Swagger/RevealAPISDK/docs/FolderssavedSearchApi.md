# IO.Swagger.Api.FolderssavedSearchApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SavedSearchFoldersCreateSavedSearchFolder**](FolderssavedSearchApi.md#savedsearchfolderscreatesavedsearchfolder) | **POST** /api/v2/{caseId}/folders/savedSearch | Create a new saved search folder
[**SavedSearchFoldersDeleteFolder**](FolderssavedSearchApi.md#savedsearchfoldersdeletefolder) | **DELETE** /api/v2/{caseId}/folders/savedSearch/{id} | Delete a saved search folder
[**SavedSearchFoldersGetFolderAccessControl**](FolderssavedSearchApi.md#savedsearchfoldersgetfolderaccesscontrol) | **GET** /api/v2/{caseId}/folders/savedSearch/{id}/accessControl | Get ACL permission data for a saved search folder
[**SavedSearchFoldersGetSavedSearchFolders**](FolderssavedSearchApi.md#savedsearchfoldersgetsavedsearchfolders) | **GET** /api/v2/{caseId}/folders/savedSearch/{folderId} | Get Saved Search folders
[**SavedSearchFoldersGetSavedSearchFoldersAll**](FolderssavedSearchApi.md#savedsearchfoldersgetsavedsearchfoldersall) | **GET** /api/v2/{caseId}/folders/savedSearch/all/{folderId} | 
[**SavedSearchFoldersUpdateFolder**](FolderssavedSearchApi.md#savedsearchfoldersupdatefolder) | **PATCH** /api/v2/{caseId}/folders/savedSearch/{id} | Update an existing saved search folder


<a name="savedsearchfolderscreatesavedsearchfolder"></a>
# **SavedSearchFoldersCreateSavedSearchFolder**
> SavedSearchFolder SavedSearchFoldersCreateSavedSearchFolder (int? caseId, int? parentId = null, SavedSearchFolderCreate body = null)

Create a new saved search folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersCreateSavedSearchFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var parentId = 56;  // int? |  (optional) 
            var body = new SavedSearchFolderCreate(); // SavedSearchFolderCreate |  (optional) 

            try
            {
                // Create a new saved search folder
                SavedSearchFolder result = apiInstance.SavedSearchFoldersCreateSavedSearchFolder(caseId, parentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersCreateSavedSearchFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **parentId** | **int?**|  | [optional] 
 **body** | [**SavedSearchFolderCreate**](SavedSearchFolderCreate.md)|  | [optional] 

### Return type

[**SavedSearchFolder**](SavedSearchFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savedsearchfoldersdeletefolder"></a>
# **SavedSearchFoldersDeleteFolder**
> void SavedSearchFoldersDeleteFolder (int? caseId, int? id)

Delete a saved search folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersDeleteFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a saved search folder
                apiInstance.SavedSearchFoldersDeleteFolder(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersDeleteFolder: " + e.Message );
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

<a name="savedsearchfoldersgetfolderaccesscontrol"></a>
# **SavedSearchFoldersGetFolderAccessControl**
> List<FolderAccessControl> SavedSearchFoldersGetFolderAccessControl (int? caseId, int? id)

Get ACL permission data for a saved search folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersGetFolderAccessControlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get ACL permission data for a saved search folder
                List&lt;FolderAccessControl&gt; result = apiInstance.SavedSearchFoldersGetFolderAccessControl(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersGetFolderAccessControl: " + e.Message );
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

<a name="savedsearchfoldersgetsavedsearchfolders"></a>
# **SavedSearchFoldersGetSavedSearchFolders**
> List<FolderItem> SavedSearchFoldersGetSavedSearchFolders (int? caseId, int? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null, bool? userIdRequested = null)

Get Saved Search folders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersGetSavedSearchFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | Requested Folders ID
            var userId = 56;  // int? |  (optional) 
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)
            var userIdRequested = true;  // bool? |  (optional)  (default to false)

            try
            {
                // Get Saved Search folders
                List&lt;FolderItem&gt; result = apiInstance.SavedSearchFoldersGetSavedSearchFolders(caseId, folderId, userId, uniqueId, isAdminView, userIdRequested);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersGetSavedSearchFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **folderId** | **int?**| Requested Folders ID | 
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

<a name="savedsearchfoldersgetsavedsearchfoldersall"></a>
# **SavedSearchFoldersGetSavedSearchFoldersAll**
> List<FolderItem> SavedSearchFoldersGetSavedSearchFoldersAll (int? caseId, int? folderId, int? userId = null, string uniqueId = null, bool? isAdminView = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersGetSavedSearchFoldersAllExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var uniqueId = uniqueId_example;  // string |  (optional) 
            var isAdminView = true;  // bool? |  (optional)  (default to false)

            try
            {
                List&lt;FolderItem&gt; result = apiInstance.SavedSearchFoldersGetSavedSearchFoldersAll(caseId, folderId, userId, uniqueId, isAdminView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersGetSavedSearchFoldersAll: " + e.Message );
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

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savedsearchfoldersupdatefolder"></a>
# **SavedSearchFoldersUpdateFolder**
> void SavedSearchFoldersUpdateFolder (int? caseId, int? id, SavedSearchFolderUpdate body = null)

Update an existing saved search folder

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavedSearchFoldersUpdateFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FolderssavedSearchApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = new SavedSearchFolderUpdate(); // SavedSearchFolderUpdate |  (optional) 

            try
            {
                // Update an existing saved search folder
                apiInstance.SavedSearchFoldersUpdateFolder(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderssavedSearchApi.SavedSearchFoldersUpdateFolder: " + e.Message );
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
 **body** | [**SavedSearchFolderUpdate**](SavedSearchFolderUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

