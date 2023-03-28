# RevealAPI.V1.Api.Resources.TagsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagsAddDocumentIds**](TagsApi.md#tagsadddocumentids) | **POST** /api/tags/documentIds/add | 
[**TagsClearDocumentIds**](TagsApi.md#tagscleardocumentids) | **POST** /api/tags/documentIds/clear | 
[**TagsCreate**](TagsApi.md#tagscreate) | **POST** /api/tags/create | 
[**TagsDelete**](TagsApi.md#tagsdelete) | **DELETE** /api/tags/delete | 
[**TagsDeleteDocumentIds**](TagsApi.md#tagsdeletedocumentids) | **POST** /api/tags/documentIds/delete | 
[**TagsEdit**](TagsApi.md#tagsedit) | **POST** /api/tags/edit2 | Edit a tag (cannot modify its tag set)  The only things that can be changes are the name, description, and the IsPrivilege flag
[**TagsEdit_0**](TagsApi.md#tagsedit_0) | **POST** /api/tags/edit | Edit a tag with the ability to change its position in a tag set. The tag name, description, and the IsPrivilege flag can be changed.  The tags parent and display order can be changed in the tag set. It cannot be moved to a different tag set. Specify 0 to not change any tag set info.
[**TagsGet**](TagsApi.md#tagsget) | **GET** /api/tags | 
[**TagsGetDocumentIds**](TagsApi.md#tagsgetdocumentids) | **GET** /api/tags/documentIds | 
[**TagsGetDocumentIds_0**](TagsApi.md#tagsgetdocumentids_0) | **POST** /api/tags/documentIds | 
[**TagsGetReviewedDocuments**](TagsApi.md#tagsgetrevieweddocuments) | **GET** /api/tags/documentIds/reviewed | 


<a name="tagsadddocumentids"></a>
# **TagsAddDocumentIds**
> void TagsAddDocumentIds (int? caseId = null, long? userId = null, string keyField = null, string name = null, bool? ignoreAccessRights = null, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsAddDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 
            var body = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.TagsAddDocumentIds(caseId, userId, keyField, name, ignoreAccessRights, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsAddDocumentIds: " + e.Message );
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
 **ignoreAccessRights** | **bool?**|  | [optional] 
 **body** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagscleardocumentids"></a>
# **TagsClearDocumentIds**
> void TagsClearDocumentIds (int? caseId = null, long? userId = null, string name = null, bool? ignoreAccessRights = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsClearDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 

            try
            {
                apiInstance.TagsClearDocumentIds(caseId, userId, name, ignoreAccessRights);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsClearDocumentIds: " + e.Message );
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
 **ignoreAccessRights** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagscreate"></a>
# **TagsCreate**
> void TagsCreate (int? caseId = null, long? userId = null, string tagSetName = null, TagCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var tagSetName = tagSetName_example;  // string |  (optional) 
            var body = new TagCreate(); // TagCreate |  (optional) 

            try
            {
                apiInstance.TagsCreate(caseId, userId, tagSetName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsCreate: " + e.Message );
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
 **tagSetName** | **string**|  | [optional] 
 **body** | [**TagCreate**](TagCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsdelete"></a>
# **TagsDelete**
> void TagsDelete (int? caseId = null, long? userId = null, string tagSetName = null, string tagName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var tagSetName = tagSetName_example;  // string |  (optional) 
            var tagName = tagName_example;  // string |  (optional) 

            try
            {
                apiInstance.TagsDelete(caseId, userId, tagSetName, tagName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsDelete: " + e.Message );
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
 **tagSetName** | **string**|  | [optional] 
 **tagName** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsdeletedocumentids"></a>
# **TagsDeleteDocumentIds**
> void TagsDeleteDocumentIds (int? caseId = null, long? userId = null, string keyField = null, string name = null, bool? ignoreAccessRights = null, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsDeleteDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 
            var body = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.TagsDeleteDocumentIds(caseId, userId, keyField, name, ignoreAccessRights, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsDeleteDocumentIds: " + e.Message );
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
 **ignoreAccessRights** | **bool?**|  | [optional] 
 **body** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsedit"></a>
# **TagsEdit**
> void TagsEdit (int? caseId = null, long? userId = null, int? id = null, TagCreate body = null)

Edit a tag (cannot modify its tag set)  The only things that can be changes are the name, description, and the IsPrivilege flag

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsEditExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var id = 56;  // int? |  (optional) 
            var body = new TagCreate(); // TagCreate |  (optional) 

            try
            {
                // Edit a tag (cannot modify its tag set)  The only things that can be changes are the name, description, and the IsPrivilege flag
                apiInstance.TagsEdit(caseId, userId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsEdit: " + e.Message );
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
 **body** | [**TagCreate**](TagCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsedit_0"></a>
# **TagsEdit_0**
> void TagsEdit_0 (int? caseId = null, long? userId = null, int? id = null, int? tagSetId = null, TagCreate body = null)

Edit a tag with the ability to change its position in a tag set. The tag name, description, and the IsPrivilege flag can be changed.  The tags parent and display order can be changed in the tag set. It cannot be moved to a different tag set. Specify 0 to not change any tag set info.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsEdit_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var id = 56;  // int? |  (optional) 
            var tagSetId = 56;  // int? |  (optional) 
            var body = new TagCreate(); // TagCreate |  (optional) 

            try
            {
                // Edit a tag with the ability to change its position in a tag set. The tag name, description, and the IsPrivilege flag can be changed.  The tags parent and display order can be changed in the tag set. It cannot be moved to a different tag set. Specify 0 to not change any tag set info.
                apiInstance.TagsEdit_0(caseId, userId, id, tagSetId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsEdit_0: " + e.Message );
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
 **tagSetId** | **int?**|  | [optional] 
 **body** | [**TagCreate**](TagCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsget"></a>
# **TagsGet**
> void TagsGet (int? caseId = null, long? userId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 

            try
            {
                apiInstance.TagsGet(caseId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsGet: " + e.Message );
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

<a name="tagsgetdocumentids"></a>
# **TagsGetDocumentIds**
> void TagsGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, string name = null, bool? ignoreAccessRights = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsGetDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 

            try
            {
                apiInstance.TagsGetDocumentIds(caseId, userId, keyField, startRow, batchSize, name, ignoreAccessRights);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsGetDocumentIds: " + e.Message );
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
 **ignoreAccessRights** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsgetdocumentids_0"></a>
# **TagsGetDocumentIds_0**
> void TagsGetDocumentIds_0 (int? caseId = null, long? userId = null, string keyField = null, int? id = null, bool? ignoreAccessRights = null, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsGetDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var id = 56;  // int? |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 
            var body = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.TagsGetDocumentIds_0(caseId, userId, keyField, id, ignoreAccessRights, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsGetDocumentIds_0: " + e.Message );
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
 **id** | **int?**|  | [optional] 
 **ignoreAccessRights** | **bool?**|  | [optional] 
 **body** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsgetrevieweddocuments"></a>
# **TagsGetReviewedDocuments**
> void TagsGetReviewedDocuments (int? caseId = null, string reviewedSince = null, int? tagProfileId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, bool? ignoreAccessRights = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagsGetReviewedDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagsApi();
            var caseId = 56;  // int? |  (optional) 
            var reviewedSince = reviewedSince_example;  // string |  (optional) 
            var tagProfileId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var ignoreAccessRights = true;  // bool? |  (optional) 

            try
            {
                apiInstance.TagsGetReviewedDocuments(caseId, reviewedSince, tagProfileId, userId, keyField, startRow, batchSize, ignoreAccessRights);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsGetReviewedDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **reviewedSince** | **string**|  | [optional] 
 **tagProfileId** | **int?**|  | [optional] 
 **userId** | **long?**|  | [optional] 
 **keyField** | **string**|  | [optional] 
 **startRow** | **int?**|  | [optional] 
 **batchSize** | **int?**|  | [optional] 
 **ignoreAccessRights** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

