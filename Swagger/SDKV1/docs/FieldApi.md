# RevealAPI.V1.Api.Resources.FieldApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldClearField**](FieldApi.md#fieldclearfield) | **PUT** /api/field/clear | Clear values in IMPORT_DOCUMENTS for a field by FIELD NAME
[**FieldClearField_0**](FieldApi.md#fieldclearfield_0) | **PUT** /api/field/clear/{id} | Clear values in IMPORT_DOCUMENTS for a field by FIELD ID
[**FieldCreateField**](FieldApi.md#fieldcreatefield) | **POST** /api/field | Create a new field
[**FieldDeleteFieldById**](FieldApi.md#fielddeletefieldbyid) | **DELETE** /api/field/{id} | Delete a field by FIELD ID
[**FieldDeleteFieldByName**](FieldApi.md#fielddeletefieldbyname) | **DELETE** /api/field | Delete a field by FIELD NAME
[**FieldGetAllFields**](FieldApi.md#fieldgetallfields) | **GET** /api/field | Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS
[**FieldGetDocumentIds**](FieldApi.md#fieldgetdocumentids) | **GET** /api/field/documentIds | Get the list of all document ids in the case (ITEMID or BEGDOC values).  On the first call start offset should be 0 or 1, on subsequent calls it should be \&quot;count of results received + 1\&quot;  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
[**FieldGetDocumentIds_0**](FieldApi.md#fieldgetdocumentids_0) | **POST** /api/field/documentIds | Get a list of document ids (ITEMID or BEGDOC values) for a field that have a certain value.   Specify the desired matching field value or specify null or \&quot;null\&quot; or \&quot;not null\&quot; as special values.  The keyfield can be either \&quot;ITEMID\&quot; or \&quot;BEGDOC\&quot;  On the first call start offset should be 0 or 1, on subsequent calls it should be \&quot;count of results received + 1\&quot;  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
[**FieldGetFieldById**](FieldApi.md#fieldgetfieldbyid) | **GET** /api/field/{id} | Get information about a single field by FIELD ID
[**FieldGetFieldByName**](FieldApi.md#fieldgetfieldbyname) | **GET** /api/field/name/{fieldName} | Get information about a single field by name (name as part of the path)
[**FieldOverLayFields**](FieldApi.md#fieldoverlayfields) | **POST** /api/field/overlay | Overlay field values into IMPORT_DOCUMENTS table. Use either FieldId or FieldName to specify the fields to update
[**FieldUpdateField**](FieldApi.md#fieldupdatefield) | **PUT** /api/field | Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.


<a name="fieldclearfield"></a>
# **FieldClearField**
> string FieldClearField (int? caseId = null, string fieldName = null)

Clear values in IMPORT_DOCUMENTS for a field by FIELD NAME

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldClearFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var fieldName = fieldName_example;  // string |  (optional) 

            try
            {
                // Clear values in IMPORT_DOCUMENTS for a field by FIELD NAME
                string result = apiInstance.FieldClearField(caseId, fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldClearField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **fieldName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldclearfield_0"></a>
# **FieldClearField_0**
> string FieldClearField_0 (int? id, int? caseId = null)

Clear values in IMPORT_DOCUMENTS for a field by FIELD ID

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldClearField_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Clear values in IMPORT_DOCUMENTS for a field by FIELD ID
                string result = apiInstance.FieldClearField_0(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldClearField_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldcreatefield"></a>
# **FieldCreateField**
> Field FieldCreateField (int? caseId = null, Field body = null)

Create a new field

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldCreateFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new Field(); // Field |  (optional) 

            try
            {
                // Create a new field
                Field result = apiInstance.FieldCreateField(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldCreateField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**Field**](Field.md)|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fielddeletefieldbyid"></a>
# **FieldDeleteFieldById**
> string FieldDeleteFieldById (int? id, int? caseId = null)

Delete a field by FIELD ID

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldDeleteFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Delete a field by FIELD ID
                string result = apiInstance.FieldDeleteFieldById(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldDeleteFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fielddeletefieldbyname"></a>
# **FieldDeleteFieldByName**
> string FieldDeleteFieldByName (string fieldName = null, int? caseId = null)

Delete a field by FIELD NAME

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldDeleteFieldByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var fieldName = fieldName_example;  // string |  (optional) 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Delete a field by FIELD NAME
                string result = apiInstance.FieldDeleteFieldByName(fieldName, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldDeleteFieldByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**|  | [optional] 
 **caseId** | **int?**|  | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldgetallfields"></a>
# **FieldGetAllFields**
> List<Field> FieldGetAllFields (int? caseId = null)

Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldGetAllFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get a list of all fields in IMPORT_METADATA / IMPORT_DOCUMENTS
                List&lt;Field&gt; result = apiInstance.FieldGetAllFields(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldGetAllFields: " + e.Message );
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

[**List<Field>**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldgetdocumentids"></a>
# **FieldGetDocumentIds**
> void FieldGetDocumentIds (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null)

Get the list of all document ids in the case (ITEMID or BEGDOC values).  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldGetDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 

            try
            {
                // Get the list of all document ids in the case (ITEMID or BEGDOC values).  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
                apiInstance.FieldGetDocumentIds(caseId, userId, keyField, startRow, batchSize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldGetDocumentIds: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldgetdocumentids_0"></a>
# **FieldGetDocumentIds_0**
> void FieldGetDocumentIds_0 (int? caseId = null, long? userId = null, string keyField = null, int? startRow = null, int? batchSize = null, DocumentField body = null)

Get a list of document ids (ITEMID or BEGDOC values) for a field that have a certain value.   Specify the desired matching field value or specify null or \"null\" or \"not null\" as special values.  The keyfield can be either \"ITEMID\" or \"BEGDOC\"  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldGetDocumentIds_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var keyField = keyField_example;  // string |  (optional) 
            var startRow = 56;  // int? |  (optional) 
            var batchSize = 56;  // int? |  (optional) 
            var body = new DocumentField(); // DocumentField |  (optional) 

            try
            {
                // Get a list of document ids (ITEMID or BEGDOC values) for a field that have a certain value.   Specify the desired matching field value or specify null or \"null\" or \"not null\" as special values.  The keyfield can be either \"ITEMID\" or \"BEGDOC\"  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
                apiInstance.FieldGetDocumentIds_0(caseId, userId, keyField, startRow, batchSize, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldGetDocumentIds_0: " + e.Message );
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
 **body** | [**DocumentField**](DocumentField.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldgetfieldbyid"></a>
# **FieldGetFieldById**
> Field FieldGetFieldById (int? id, int? caseId = null)

Get information about a single field by FIELD ID

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldGetFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get information about a single field by FIELD ID
                Field result = apiInstance.FieldGetFieldById(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldGetFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldgetfieldbyname"></a>
# **FieldGetFieldByName**
> Field FieldGetFieldByName (string fieldName, int? caseId = null)

Get information about a single field by name (name as part of the path)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldGetFieldByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var fieldName = fieldName_example;  // string | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get information about a single field by name (name as part of the path)
                Field result = apiInstance.FieldGetFieldByName(fieldName, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldGetFieldByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldoverlayfields"></a>
# **FieldOverLayFields**
> string FieldOverLayFields (int? caseId = null, List<OverLayRequest> body = null)

Overlay field values into IMPORT_DOCUMENTS table. Use either FieldId or FieldName to specify the fields to update

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldOverLayFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new List<OverLayRequest>(); // List<OverLayRequest> |  (optional) 

            try
            {
                // Overlay field values into IMPORT_DOCUMENTS table. Use either FieldId or FieldName to specify the fields to update
                string result = apiInstance.FieldOverLayFields(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldOverLayFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**List&lt;OverLayRequest&gt;**](OverLayRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldupdatefield"></a>
# **FieldUpdateField**
> Field FieldUpdateField (int? caseId = null, Field body = null)

Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldUpdateFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new Field(); // Field |  (optional) 

            try
            {
                // Update an existing field by field name or Id in the Field object. Id is used first. If its 0, then the field name is used to lookup the field.
                Field result = apiInstance.FieldUpdateField(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldApi.FieldUpdateField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**Field**](Field.md)|  | [optional] 

### Return type

[**Field**](Field.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

