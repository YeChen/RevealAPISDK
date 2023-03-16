# IO.Swagger.Api.FieldsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldV2CreateField**](FieldsApi.md#fieldv2createfield) | **POST** /api/v2/{caseId}/fields | Create a new field
[**FieldV2DeleteField**](FieldsApi.md#fieldv2deletefield) | **DELETE** /api/v2/{caseId}/fields/{id} | Delete a field by FIELD ID
[**FieldV2DeleteFieldByName**](FieldsApi.md#fieldv2deletefieldbyname) | **DELETE** /api/v2/{caseId}/fields/deleteByName/{name} | Delete a field by FIELD NAME
[**FieldV2GetAllFields**](FieldsApi.md#fieldv2getallfields) | **GET** /api/v2/{caseId}/fields | Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS
[**FieldV2GetFieldById**](FieldsApi.md#fieldv2getfieldbyid) | **GET** /api/v2/{caseId}/fields/{id} | Get information about a single field by FIELD ID
[**FieldV2GetFieldByName**](FieldsApi.md#fieldv2getfieldbyname) | **GET** /api/v2/{caseId}/fields/getByName/{name} | Get information about a single field by name (name as part of the path)
[**FieldV2GetSpecialFields**](FieldsApi.md#fieldv2getspecialfields) | **GET** /api/v2/{caseId}/fields/special | Get the special review grid fields.
[**FieldV2UpdateField**](FieldsApi.md#fieldv2updatefield) | **PUT** /api/v2/{caseId}/fields | Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.


<a name="fieldv2createfield"></a>
# **FieldV2CreateField**
> Field FieldV2CreateField (int? caseId, Field body = null)

Create a new field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2CreateFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var body = new Field(); // Field |  (optional) 

            try
            {
                // Create a new field
                Field result = apiInstance.FieldV2CreateField(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2CreateField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**Field**](Field.md)|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2deletefield"></a>
# **FieldV2DeleteField**
> void FieldV2DeleteField (int? caseId, int? id)

Delete a field by FIELD ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2DeleteFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a field by FIELD ID
                apiInstance.FieldV2DeleteField(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2DeleteField: " + e.Message );
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

<a name="fieldv2deletefieldbyname"></a>
# **FieldV2DeleteFieldByName**
> void FieldV2DeleteFieldByName (int? caseId, string name)

Delete a field by FIELD NAME

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2DeleteFieldByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 

            try
            {
                // Delete a field by FIELD NAME
                apiInstance.FieldV2DeleteFieldByName(caseId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2DeleteFieldByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2getallfields"></a>
# **FieldV2GetAllFields**
> PaginatedOfListOfField FieldV2GetAllFields (int? caseId, bool? includeNotImportable = null, bool? includeSpecial = null, int? start = null, int? count = null)

Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2GetAllFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var includeNotImportable = true;  // bool? | Specify true to retrieve special grid fields (optional)  (default to true)
            var includeSpecial = true;  // bool? | Specify true to retrieve special grid fields (optional)  (default to true)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS
                PaginatedOfListOfField result = apiInstance.FieldV2GetAllFields(caseId, includeNotImportable, includeSpecial, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2GetAllFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **includeNotImportable** | **bool?**| Specify true to retrieve special grid fields | [optional] [default to true]
 **includeSpecial** | **bool?**| Specify true to retrieve special grid fields | [optional] [default to true]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfField**](PaginatedOfListOfField.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2getfieldbyid"></a>
# **FieldV2GetFieldById**
> Field FieldV2GetFieldById (int? caseId, int? id)

Get information about a single field by FIELD ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2GetFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get information about a single field by FIELD ID
                Field result = apiInstance.FieldV2GetFieldById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2GetFieldById: " + e.Message );
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

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2getfieldbyname"></a>
# **FieldV2GetFieldByName**
> Field FieldV2GetFieldByName (int? caseId, string name)

Get information about a single field by name (name as part of the path)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2GetFieldByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 

            try
            {
                // Get information about a single field by name (name as part of the path)
                Field result = apiInstance.FieldV2GetFieldByName(caseId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2GetFieldByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **name** | **string**|  | 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2getspecialfields"></a>
# **FieldV2GetSpecialFields**
> PaginatedOfListOfField FieldV2GetSpecialFields (int? caseId, int? userId = null, int? start = null, int? count = null)

Get the special review grid fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2GetSpecialFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | Specify to only get special fields that the user has chosen to be visible using the user's User Settings. (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get the special review grid fields.
                PaginatedOfListOfField result = apiInstance.FieldV2GetSpecialFields(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2GetSpecialFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**| Specify to only get special fields that the user has chosen to be visible using the user&#39;s User Settings. | [optional] [default to 0]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfField**](PaginatedOfListOfField.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldv2updatefield"></a>
# **FieldV2UpdateField**
> Field FieldV2UpdateField (int? caseId, Field body = null)

Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldV2UpdateFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldsApi();
            var caseId = 56;  // int? | 
            var body = new Field(); // Field |  (optional) 

            try
            {
                // Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.
                Field result = apiInstance.FieldV2UpdateField(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldV2UpdateField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**Field**](Field.md)|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

