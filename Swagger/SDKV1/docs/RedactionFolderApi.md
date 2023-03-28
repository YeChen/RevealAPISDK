# RevealAPI.V1.Api.Resources.RedactionFolderApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RedactionFolderAddDocumentIds**](RedactionFolderApi.md#redactionfolderadddocumentids) | **POST** /api/redactionFolder/documentIds/AddByName | Adds document to given folder name.
[**RedactionFolderAddDocumentIds_0**](RedactionFolderApi.md#redactionfolderadddocumentids_0) | **POST** /api/redactionFolder/documentIds/AddById | Adds document to given folder id.
[**RedactionFolderClearDocumentIds**](RedactionFolderApi.md#redactionfoldercleardocumentids) | **POST** /api/redactionFolder/documentIds/ClearByName | Clears all documents from given folder name.
[**RedactionFolderClearDocumentIds_0**](RedactionFolderApi.md#redactionfoldercleardocumentids_0) | **POST** /api/redactionFolder/documentIds/ClearById | Clears all documents from given folder id.
[**RedactionFolderCreate**](RedactionFolderApi.md#redactionfoldercreate) | **POST** /api/redactionFolder/CreateFolder | Clears all documents from given folder name.
[**RedactionFolderDelete**](RedactionFolderApi.md#redactionfolderdelete) | **DELETE** /api/redactionFolder/DeleteFolderByName | Clears all documents from given folder name.
[**RedactionFolderDeleteDocumentIds**](RedactionFolderApi.md#redactionfolderdeletedocumentids) | **POST** /api/redactionFolder/documentIds/DeleteByName | Deletes document from given folder name.
[**RedactionFolderDeleteDocumentIds_0**](RedactionFolderApi.md#redactionfolderdeletedocumentids_0) | **POST** /api/redactionFolder/documentIds/DeleteById | Deletes document from given folder id.
[**RedactionFolderDelete_0**](RedactionFolderApi.md#redactionfolderdelete_0) | **DELETE** /api/redactionFolder/DeleteFolderById | Clears all documents from given folder name.
[**RedactionFolderEdit**](RedactionFolderApi.md#redactionfolderedit) | **POST** /api/redactionFolder/EditFolder | Clears all documents from given folder name.
[**RedactionFolderGetDocumentIds**](RedactionFolderApi.md#redactionfoldergetdocumentids) | **GET** /api/redactionFolder/GetDocumentsIdsByName | Gets documents ids from given folder name.
[**RedactionFolderGetDocumentIds_0**](RedactionFolderApi.md#redactionfoldergetdocumentids_0) | **GET** /api/redactionFolder/GetDocumentsIdsById | Gets documents ids from given folder name.
[**RedactionFolderGetRootFolder**](RedactionFolderApi.md#redactionfoldergetrootfolder) | **GET** /api/redactionFolder/GetRoot | Gets the Root Folder
[**RedactionFolderGetSingleFolder**](RedactionFolderApi.md#redactionfoldergetsinglefolder) | **GET** /api/redactionFolder/GetFolderByName | Search folder info by name.
[**RedactionFolderGetSingleFolder_0**](RedactionFolderApi.md#redactionfoldergetsinglefolder_0) | **GET** /api/redactionFolder/GetFolderById | Search folder info by id.
[**RedactionFolderGetSubFolders**](RedactionFolderApi.md#redactionfoldergetsubfolders) | **GET** /api/redactionFolder/GetSubfolders | Gets Subfolders for specified parent folder.


<a name="redactionfolderadddocumentids"></a>
# **RedactionFolderAddDocumentIds**
> void RedactionFolderAddDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? parentId = null, string name = null, bool? ignoreReadOnly = null, List<string> body = null)

Adds document to given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderAddDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Container Folder Name (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 
            var body = ;  // List<string> | List of IDs to Add (optional) 

            try
            {
                // Adds document to given folder name.
                apiInstance.RedactionFolderAddDocumentIds(caseId, userId, keyField, parentId, name, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderAddDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Container Folder Name | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 
 **body** | **List&lt;string&gt;**| List of IDs to Add | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderadddocumentids_0"></a>
# **RedactionFolderAddDocumentIds_0**
> void RedactionFolderAddDocumentIds_0 (int? caseId = null, long? userId = null, string keyField = null, int? folderId = null, bool? ignoreReadOnly = null, List<string> body = null)

Adds document to given folder id.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderAddDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var folderId = 56;  // int? | Container Folder ID (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 
            var body = ;  // List<string> | List of IDs to Add (optional) 

            try
            {
                // Adds document to given folder id.
                apiInstance.RedactionFolderAddDocumentIds_0(caseId, userId, keyField, folderId, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderAddDocumentIds_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **folderId** | **int?**| Container Folder ID | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 
 **body** | **List&lt;string&gt;**| List of IDs to Add | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldercleardocumentids"></a>
# **RedactionFolderClearDocumentIds**
> void RedactionFolderClearDocumentIds (int? caseId = null, long? userId = null, int? parentId = null, string name = null, bool? ignoreReadOnly = null)

Clears all documents from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderClearDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Container Folder Name (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 

            try
            {
                // Clears all documents from given folder name.
                apiInstance.RedactionFolderClearDocumentIds(caseId, userId, parentId, name, ignoreReadOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderClearDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Container Folder Name | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldercleardocumentids_0"></a>
# **RedactionFolderClearDocumentIds_0**
> void RedactionFolderClearDocumentIds_0 (int? caseId = null, long? userId = null, int? folderId = null, bool? ignoreReadOnly = null)

Clears all documents from given folder id.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderClearDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var folderId = 56;  // int? | Container Folder Name (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 

            try
            {
                // Clears all documents from given folder id.
                apiInstance.RedactionFolderClearDocumentIds_0(caseId, userId, folderId, ignoreReadOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderClearDocumentIds_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **folderId** | **int?**| Container Folder Name | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldercreate"></a>
# **RedactionFolderCreate**
> void RedactionFolderCreate (int? caseId = null, long? userId = null, int? parentId = null, RedactionFolderCreate body = null)

Clears all documents from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var body = new RedactionFolderCreate(); // RedactionFolderCreate | Folder Structure to Create (optional) 

            try
            {
                // Clears all documents from given folder name.
                apiInstance.RedactionFolderCreate(caseId, userId, parentId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **body** | [**RedactionFolderCreate**](RedactionFolderCreate.md)| Folder Structure to Create | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderdelete"></a>
# **RedactionFolderDelete**
> void RedactionFolderDelete (int? caseId = null, long? userId = null, int? parentId = null, string name = null)

Clears all documents from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Folder Name to Delete (optional) 

            try
            {
                // Clears all documents from given folder name.
                apiInstance.RedactionFolderDelete(caseId, userId, parentId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Folder Name to Delete | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderdeletedocumentids"></a>
# **RedactionFolderDeleteDocumentIds**
> void RedactionFolderDeleteDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? parentId = null, string name = null, bool? ignoreReadOnly = null, List<string> body = null)

Deletes document from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderDeleteDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Container Folder Name (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 
            var body = ;  // List<string> | List of IDs to Add (optional) 

            try
            {
                // Deletes document from given folder name.
                apiInstance.RedactionFolderDeleteDocumentIds(caseId, userId, keyField, parentId, name, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderDeleteDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Container Folder Name | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 
 **body** | **List&lt;string&gt;**| List of IDs to Add | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderdeletedocumentids_0"></a>
# **RedactionFolderDeleteDocumentIds_0**
> void RedactionFolderDeleteDocumentIds_0 (int? caseId = null, long? userId = null, string keyField = null, int? folderId = null, bool? ignoreReadOnly = null, List<string> body = null)

Deletes document from given folder id.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderDeleteDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var folderId = 56;  // int? | Container Folder ID (optional) 
            var ignoreReadOnly = true;  // bool? | Ignore Readonly Attribute (optional) 
            var body = ;  // List<string> | List of IDs to Add (optional) 

            try
            {
                // Deletes document from given folder id.
                apiInstance.RedactionFolderDeleteDocumentIds_0(caseId, userId, keyField, folderId, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderDeleteDocumentIds_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **folderId** | **int?**| Container Folder ID | [optional] 
 **ignoreReadOnly** | **bool?**| Ignore Readonly Attribute | [optional] 
 **body** | **List&lt;string&gt;**| List of IDs to Add | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderdelete_0"></a>
# **RedactionFolderDelete_0**
> void RedactionFolderDelete_0 (int? caseId = null, long? userId = null, int? id = null)

Clears all documents from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderDelete_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var id = 56;  // int? | Folder ID to Delete (optional) 

            try
            {
                // Clears all documents from given folder name.
                apiInstance.RedactionFolderDelete_0(caseId, userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderDelete_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **id** | **int?**| Folder ID to Delete | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfolderedit"></a>
# **RedactionFolderEdit**
> void RedactionFolderEdit (int? caseId = null, long? userId = null, int? id = null, bool? updateACL = null, RedactionFolderCreate body = null)

Clears all documents from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderEditExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var id = 56;  // int? | Folder Id to Edit (optional) 
            var updateACL = true;  // bool? | Access Control Update (optional) 
            var body = new RedactionFolderCreate(); // RedactionFolderCreate | Folder Structure to Create (optional) 

            try
            {
                // Clears all documents from given folder name.
                apiInstance.RedactionFolderEdit(caseId, userId, id, updateACL, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **id** | **int?**| Folder Id to Edit | [optional] 
 **updateACL** | **bool?**| Access Control Update | [optional] 
 **body** | [**RedactionFolderCreate**](RedactionFolderCreate.md)| Folder Structure to Create | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetdocumentids"></a>
# **RedactionFolderGetDocumentIds**
> void RedactionFolderGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, int? parentId = null, string name = null)

Gets documents ids from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var startRow = 56;  // int? | Starting Row Number (optional) 
            var batchSize = 56;  // int? | Batch Size (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Container Folder Name (optional) 

            try
            {
                // Gets documents ids from given folder name.
                apiInstance.RedactionFolderGetDocumentIds(caseId, userId, keyField, startRow, batchSize, parentId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **startRow** | **int?**| Starting Row Number | [optional] 
 **batchSize** | **int?**| Batch Size | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Container Folder Name | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetdocumentids_0"></a>
# **RedactionFolderGetDocumentIds_0**
> void RedactionFolderGetDocumentIds_0 (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, int? folderId = null)

Gets documents ids from given folder name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var keyField = keyField_example;  // string | Field to Retrieve: 1.- \"ITEMID\" 2.- \"BEGDOC\" (optional) 
            var startRow = 56;  // int? | Starting Row Number (optional) 
            var batchSize = 56;  // int? | Batch Size (optional) 
            var folderId = 56;  // int? | Container Folder ID (optional) 

            try
            {
                // Gets documents ids from given folder name.
                apiInstance.RedactionFolderGetDocumentIds_0(caseId, userId, keyField, startRow, batchSize, folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetDocumentIds_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **keyField** | **string**| Field to Retrieve: 1.- \&quot;ITEMID\&quot; 2.- \&quot;BEGDOC\&quot; | [optional] 
 **startRow** | **int?**| Starting Row Number | [optional] 
 **batchSize** | **int?**| Batch Size | [optional] 
 **folderId** | **int?**| Container Folder ID | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetrootfolder"></a>
# **RedactionFolderGetRootFolder**
> void RedactionFolderGetRootFolder (int? caseId = null, long? userId = null)

Gets the Root Folder

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetRootFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 

            try
            {
                // Gets the Root Folder
                apiInstance.RedactionFolderGetRootFolder(caseId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetRootFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetsinglefolder"></a>
# **RedactionFolderGetSingleFolder**
> void RedactionFolderGetSingleFolder (int? caseId = null, long? userId = null, int? parentId = null, string name = null)

Search folder info by name.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetSingleFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 
            var name = name_example;  // string | Folder Name to Search (optional) 

            try
            {
                // Search folder info by name.
                apiInstance.RedactionFolderGetSingleFolder(caseId, userId, parentId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetSingleFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 
 **name** | **string**| Folder Name to Search | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetsinglefolder_0"></a>
# **RedactionFolderGetSingleFolder_0**
> void RedactionFolderGetSingleFolder_0 (int? caseId = null, long? userId = null, int? folderId = null)

Search folder info by id.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetSingleFolder_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var folderId = 56;  // int? | Folder ID to Search (optional) 

            try
            {
                // Search folder info by id.
                apiInstance.RedactionFolderGetSingleFolder_0(caseId, userId, folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetSingleFolder_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **folderId** | **int?**| Folder ID to Search | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redactionfoldergetsubfolders"></a>
# **RedactionFolderGetSubFolders**
> void RedactionFolderGetSubFolders (int? caseId = null, long? userId = null, int? parentId = null)

Gets Subfolders for specified parent folder.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class RedactionFolderGetSubFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RedactionFolderApi();
            var caseId = 56;  // int? | Reveal Case Id (optional) 
            var userId = 789;  // long? | Reveal User Id (optional) 
            var parentId = 56;  // int? | Parent Folder Id (optional) 

            try
            {
                // Gets Subfolders for specified parent folder.
                apiInstance.RedactionFolderGetSubFolders(caseId, userId, parentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RedactionFolderApi.RedactionFolderGetSubFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal Case Id | [optional] 
 **userId** | **long?**| Reveal User Id | [optional] 
 **parentId** | **int?**| Parent Folder Id | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

