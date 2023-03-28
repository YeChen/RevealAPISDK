# RevealAPI.V1.Api.Resources.MyAssignmentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MyAssignmentGetDocumentIdsForFolderId**](MyAssignmentApi.md#myassignmentgetdocumentidsforfolderid) | **GET** /api/MyAssignment/documentIdsForFolderId | 
[**MyAssignmentGetDocumentIdsForFolderName**](MyAssignmentApi.md#myassignmentgetdocumentidsforfoldername) | **GET** /api/MyAssignment/documentIdsForFolderName | 
[**MyAssignmentGetSubFolders**](MyAssignmentApi.md#myassignmentgetsubfolders) | **GET** /api/MyAssignment | 


<a name="myassignmentgetdocumentidsforfolderid"></a>
# **MyAssignmentGetDocumentIdsForFolderId**
> void MyAssignmentGetDocumentIdsForFolderId (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class MyAssignmentGetDocumentIdsForFolderIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MyAssignmentApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var id = 56;  // int? |  (optional) 

            try
            {
                apiInstance.MyAssignmentGetDocumentIdsForFolderId(caseId, userId, keyField, startRow, batchSize, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAssignmentApi.MyAssignmentGetDocumentIdsForFolderId: " + e.Message );
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
 **id** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="myassignmentgetdocumentidsforfoldername"></a>
# **MyAssignmentGetDocumentIdsForFolderName**
> void MyAssignmentGetDocumentIdsForFolderName (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class MyAssignmentGetDocumentIdsForFolderNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MyAssignmentApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.MyAssignmentGetDocumentIdsForFolderName(caseId, userId, keyField, startRow, batchSize, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAssignmentApi.MyAssignmentGetDocumentIdsForFolderName: " + e.Message );
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

<a name="myassignmentgetsubfolders"></a>
# **MyAssignmentGetSubFolders**
> void MyAssignmentGetSubFolders (int? caseId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class MyAssignmentGetSubFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MyAssignmentApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.MyAssignmentGetSubFolders(caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAssignmentApi.MyAssignmentGetSubFolders: " + e.Message );
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

