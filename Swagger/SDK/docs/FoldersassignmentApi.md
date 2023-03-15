# RevealAPI.Sdk.Api.Resources.FoldersassignmentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignmentFoldersV2Delete**](FoldersassignmentApi.md#assignmentfoldersv2delete) | **DELETE** /api/v2/{caseId}/folders/assignment | 
[**AssignmentFoldersV2DeleteSingle**](FoldersassignmentApi.md#assignmentfoldersv2deletesingle) | **DELETE** /api/v2/{caseId}/folders/assignment/{id} | 
[**AssignmentFoldersV2Get**](FoldersassignmentApi.md#assignmentfoldersv2get) | **POST** /api/v2/{caseId}/folders/assignment/batches | Get assignment batch folders  filters available:  1) Title - IS_LIKE / IS_NOT_LIKE  2) Date - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO  3) Reviews - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO
[**AssignmentFoldersV2GetAssignmentFolders**](FoldersassignmentApi.md#assignmentfoldersv2getassignmentfolders) | **GET** /api/v2/{caseId}/folders/assignment/{folderId} | Get assignment folders
[**AssignmentFoldersV2GetTopLevelAssignmentFolders**](FoldersassignmentApi.md#assignmentfoldersv2gettoplevelassignmentfolders) | **GET** /api/v2/{caseId}/folders/assignment/toplevel | Get top level assignment folders
[**AssignmentFoldersV2UpadateUserAssignment**](FoldersassignmentApi.md#assignmentfoldersv2upadateuserassignment) | **PUT** /api/v2/{caseId}/folders/assignment/batches/assign | Assign, unassign, or complete assignment batches in bulk


<a name="assignmentfoldersv2delete"></a>
# **AssignmentFoldersV2Delete**
> void AssignmentFoldersV2Delete (int? caseId, List<int?> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var body = ;  // List<int?> |  (optional) 

            try
            {
                apiInstance.AssignmentFoldersV2Delete(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentfoldersv2deletesingle"></a>
# **AssignmentFoldersV2DeleteSingle**
> void AssignmentFoldersV2DeleteSingle (int? caseId, int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2DeleteSingleExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                apiInstance.AssignmentFoldersV2DeleteSingle(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2DeleteSingle: " + e.Message );
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

<a name="assignmentfoldersv2get"></a>
# **AssignmentFoldersV2Get**
> PaginatedOfIEnumerableOfAssignmentBatchFolder AssignmentFoldersV2Get (int? caseId, Object filterOption = null, int? start = null, int? count = null, AssignmentBatchQuery body = null)

Get assignment batch folders  filters available:  1) Title - IS_LIKE / IS_NOT_LIKE  2) Date - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO  3) Reviews - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var filterOption = new Object(); // Object |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var body = new AssignmentBatchQuery(); // AssignmentBatchQuery | Run with one filter with filterType error to run original batch call (optional) 

            try
            {
                // Get assignment batch folders  filters available:  1) Title - IS_LIKE / IS_NOT_LIKE  2) Date - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO  3) Reviews - GREATER_THAN_OR_EQAUL_TO / LESS_THAN_OR_EQUAL_TO
                PaginatedOfIEnumerableOfAssignmentBatchFolder result = apiInstance.AssignmentFoldersV2Get(caseId, filterOption, start, count, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **filterOption** | [**Object**](Object.md)|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]
 **body** | [**AssignmentBatchQuery**](AssignmentBatchQuery.md)| Run with one filter with filterType error to run original batch call | [optional] 

### Return type

[**PaginatedOfIEnumerableOfAssignmentBatchFolder**](PaginatedOfIEnumerableOfAssignmentBatchFolder.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentfoldersv2getassignmentfolders"></a>
# **AssignmentFoldersV2GetAssignmentFolders**
> List<FolderItem> AssignmentFoldersV2GetAssignmentFolders (int? caseId, int? folderId, int? userId = null, bool? getWithDetails = null, string uniqueId = null)

Get assignment folders

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2GetAssignmentFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var folderId = 56;  // int? | 
            var userId = 56;  // int? | User to get assignment folders for (optional) 
            var getWithDetails = true;  // bool? | Return reviewed count information (optional)  (default to false)
            var uniqueId = uniqueId_example;  // string |  (optional) 

            try
            {
                // Get assignment folders
                List&lt;FolderItem&gt; result = apiInstance.AssignmentFoldersV2GetAssignmentFolders(caseId, folderId, userId, getWithDetails, uniqueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2GetAssignmentFolders: " + e.Message );
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
 **userId** | **int?**| User to get assignment folders for | [optional] 
 **getWithDetails** | **bool?**| Return reviewed count information | [optional] [default to false]
 **uniqueId** | **string**|  | [optional] 

### Return type

[**List<FolderItem>**](FolderItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentfoldersv2gettoplevelassignmentfolders"></a>
# **AssignmentFoldersV2GetTopLevelAssignmentFolders**
> List<string> AssignmentFoldersV2GetTopLevelAssignmentFolders (int? caseId, int? start = null, int? count = null, string filter = null)

Get top level assignment folders

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2GetTopLevelAssignmentFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? | 0 based first record to return (optional) 
            var count = 56;  // int? | number of records to return (optional) 
            var filter = filter_example;  // string | part of folder name (optional) 

            try
            {
                // Get top level assignment folders
                List&lt;string&gt; result = apiInstance.AssignmentFoldersV2GetTopLevelAssignmentFolders(caseId, start, count, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2GetTopLevelAssignmentFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **start** | **int?**| 0 based first record to return | [optional] 
 **count** | **int?**| number of records to return | [optional] 
 **filter** | **string**| part of folder name | [optional] 

### Return type

**List<string>**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignmentfoldersv2upadateuserassignment"></a>
# **AssignmentFoldersV2UpadateUserAssignment**
> void AssignmentFoldersV2UpadateUserAssignment (int? caseId, AssignmentBatchFoldersAssignment body = null)

Assign, unassign, or complete assignment batches in bulk

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AssignmentFoldersV2UpadateUserAssignmentExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FoldersassignmentApi();
            var caseId = 56;  // int? | 
            var body = new AssignmentBatchFoldersAssignment(); // AssignmentBatchFoldersAssignment |  (optional) 

            try
            {
                // Assign, unassign, or complete assignment batches in bulk
                apiInstance.AssignmentFoldersV2UpadateUserAssignment(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersassignmentApi.AssignmentFoldersV2UpadateUserAssignment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**AssignmentBatchFoldersAssignment**](AssignmentBatchFoldersAssignment.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

