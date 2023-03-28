# RevealAPI.V1.Api.Resources.WorkFolderApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorkFolderAddDocumentIds**](WorkFolderApi.md#workfolderadddocumentids) | **POST** /api/workFolder/documentIds/add | 
[**WorkFolderClearDocumentIds**](WorkFolderApi.md#workfoldercleardocumentids) | **POST** /api/workFolder/documentIds/clear | 
[**WorkFolderCreate**](WorkFolderApi.md#workfoldercreate) | **POST** /api/workFolder/create | 
[**WorkFolderDelete**](WorkFolderApi.md#workfolderdelete) | **DELETE** /api/workFolder/delete | 
[**WorkFolderDeleteDocumentIds**](WorkFolderApi.md#workfolderdeletedocumentids) | **POST** /api/workFolder/documentIds/delete | 
[**WorkFolderEdit**](WorkFolderApi.md#workfolderedit) | **POST** /api/workFolder/edit | 
[**WorkFolderGetDocumentIds**](WorkFolderApi.md#workfoldergetdocumentids) | **GET** /api/workFolder/documentIds | 
[**WorkFolderGetRootFolder**](WorkFolderApi.md#workfoldergetrootfolder) | **GET** /api/workFolder/rootId | 
[**WorkFolderGetSubFolders**](WorkFolderApi.md#workfoldergetsubfolders) | **GET** /api/workFolder | 


<a name="workfolderadddocumentids"></a>
# **WorkFolderAddDocumentIds**
> void WorkFolderAddDocumentIds (int? caseId = null, int? userId = null, string keyField = null, string name = null, bool? ignoreReadOnly = null, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderAddDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreReadOnly = true;  // bool? |  (optional) 
            var body = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.WorkFolderAddDocumentIds(caseId, userId, keyField, name, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderAddDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **keyField** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **ignoreReadOnly** | **bool?**|  | [optional] 
 **body** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldercleardocumentids"></a>
# **WorkFolderClearDocumentIds**
> void WorkFolderClearDocumentIds (int? caseId = null, long? userId = null, string name = null, bool? ignoreReadOnly = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderClearDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreReadOnly = true;  // bool? |  (optional) 

            try
            {
                apiInstance.WorkFolderClearDocumentIds(caseId, userId, name, ignoreReadOnly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderClearDocumentIds: " + e.Message );
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
 **name** | **string**|  | [optional] 
 **ignoreReadOnly** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldercreate"></a>
# **WorkFolderCreate**
> void WorkFolderCreate (int? caseId = null, int? userId = null, WorkFolderCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var body = new WorkFolderCreate(); // WorkFolderCreate |  (optional) 

            try
            {
                apiInstance.WorkFolderCreate(caseId, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **body** | [**WorkFolderCreate**](WorkFolderCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfolderdelete"></a>
# **WorkFolderDelete**
> void WorkFolderDelete (int? caseId = null, long? userId = null, int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var id = 56;  // int? |  (optional) 

            try
            {
                apiInstance.WorkFolderDelete(caseId, userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderDelete: " + e.Message );
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
 **id** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfolderdeletedocumentids"></a>
# **WorkFolderDeleteDocumentIds**
> void WorkFolderDeleteDocumentIds (int? caseId = null, long? userId = null, string keyField = null, string name = null, bool? ignoreReadOnly = null, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderDeleteDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreReadOnly = true;  // bool? |  (optional) 
            var body = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.WorkFolderDeleteDocumentIds(caseId, userId, keyField, name, ignoreReadOnly, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderDeleteDocumentIds: " + e.Message );
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
 **name** | **string**|  | [optional] 
 **ignoreReadOnly** | **bool?**|  | [optional] 
 **body** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfolderedit"></a>
# **WorkFolderEdit**
> void WorkFolderEdit (int? caseId = null, int? userId = null, int? id = null, bool? updateACL = null, WorkFolderCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderEditExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var id = 56;  // int? |  (optional) 
            var updateACL = true;  // bool? |  (optional) 
            var body = new WorkFolderCreate(); // WorkFolderCreate |  (optional) 

            try
            {
                apiInstance.WorkFolderEdit(caseId, userId, id, updateACL, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **id** | **int?**|  | [optional] 
 **updateACL** | **bool?**|  | [optional] 
 **body** | [**WorkFolderCreate**](WorkFolderCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldergetdocumentids"></a>
# **WorkFolderGetDocumentIds**
> void WorkFolderGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderGetDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.WorkFolderGetDocumentIds(caseId, userId, keyField, startRow, batchSize, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderGetDocumentIds: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldergetrootfolder"></a>
# **WorkFolderGetRootFolder**
> void WorkFolderGetRootFolder (int? caseId = null, long? userId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderGetRootFolderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 

            try
            {
                apiInstance.WorkFolderGetRootFolder(caseId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderGetRootFolder: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workfoldergetsubfolders"></a>
# **WorkFolderGetSubFolders**
> void WorkFolderGetSubFolders (int? caseId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class WorkFolderGetSubFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new WorkFolderApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.WorkFolderGetSubFolders(caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkFolderApi.WorkFolderGetSubFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

