# IO.Swagger.Api.FieldProfilesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldProfileV2AssociateWithFields**](FieldProfilesApi.md#fieldprofilev2associatewithfields) | **PUT** /api/v2/{caseId}/fieldProfiles/{id}/fields/add | Adds fields to a field profile
[**FieldProfileV2Delete**](FieldProfilesApi.md#fieldprofilev2delete) | **DELETE** /api/v2/{caseId}/fieldProfiles/{id} | Delete an existing field profile
[**FieldProfileV2Get**](FieldProfilesApi.md#fieldprofilev2get) | **GET** /api/v2/{caseId}/fieldProfiles | Get a list of field profiles
[**FieldProfileV2GetByName**](FieldProfilesApi.md#fieldprofilev2getbyname) | **GET** /api/v2/{caseId}/fieldProfiles/getByName/{name} | Get a single field profile by name for a user
[**FieldProfileV2GetDefaultFields**](FieldProfilesApi.md#fieldprofilev2getdefaultfields) | **GET** /api/v2/{caseId}/fieldProfiles/{id}/fields/default | Get the default fields for selection for a field profile
[**FieldProfileV2GetFields**](FieldProfilesApi.md#fieldprofilev2getfields) | **GET** /api/v2/{caseId}/fieldProfiles/{id}/fields | Get the fields of a specified field profile for a user.
[**FieldProfileV2Post**](FieldProfilesApi.md#fieldprofilev2post) | **POST** /api/v2/{caseId}/fieldProfiles | Create a new field profile
[**FieldProfileV2Put**](FieldProfilesApi.md#fieldprofilev2put) | **PUT** /api/v2/{caseId}/fieldProfiles | Update an existing field profile
[**FieldProfileV2SetDefaultFieldsDisplayOrder**](FieldProfilesApi.md#fieldprofilev2setdefaultfieldsdisplayorder) | **PUT** /api/v2/{caseId}/fieldProfiles/{id}/fields/defaultDisplayOrder | Set the default field profile field display order.
[**FieldProfileV2SetDefaultFieldsSortOrder**](FieldProfilesApi.md#fieldprofilev2setdefaultfieldssortorder) | **PUT** /api/v2/{caseId}/fieldProfiles/{id}/fields/defaultSortOrder | Set the default field profile field sort order.
[**FieldProfileV2SetFieldsDisplayOrder**](FieldProfilesApi.md#fieldprofilev2setfieldsdisplayorder) | **PUT** /api/v2/{caseId}/fieldProfiles/{id}/fields/displayOrder | Set a user&#39;s display order and visibility of fields for a specified field profile.
[**FieldProfileV2SetFieldsSortOrder**](FieldProfilesApi.md#fieldprofilev2setfieldssortorder) | **PUT** /api/v2/{caseId}/fieldProfiles/{id}/fields/sortOrder | Set a user&#39;s sort order of fields for a specified field profile.
[**FieldProfileV2UnAssociateWithFields**](FieldProfilesApi.md#fieldprofilev2unassociatewithfields) | **DELETE** /api/v2/{caseId}/fieldProfiles/{id}/fields/remove | Removes fields from a field profile


<a name="fieldprofilev2associatewithfields"></a>
# **FieldProfileV2AssociateWithFields**
> void FieldProfileV2AssociateWithFields (int? caseId, int? id, List<FieldIdVisibleAssociation> body = null)

Adds fields to a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2AssociateWithFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = new List<FieldIdVisibleAssociation>(); // List<FieldIdVisibleAssociation> |  (optional) 

            try
            {
                // Adds fields to a field profile
                apiInstance.FieldProfileV2AssociateWithFields(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2AssociateWithFields: " + e.Message );
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
 **body** | [**List&lt;FieldIdVisibleAssociation&gt;**](FieldIdVisibleAssociation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2delete"></a>
# **FieldProfileV2Delete**
> void FieldProfileV2Delete (int? caseId, int? id)

Delete an existing field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete an existing field profile
                apiInstance.FieldProfileV2Delete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2Delete: " + e.Message );
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

<a name="fieldprofilev2get"></a>
# **FieldProfileV2Get**
> PaginatedOfListOfFieldProfile FieldProfileV2Get (int? caseId, int? userId = null, int? start = null, int? count = null)

Get a list of field profiles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get a list of field profiles
                PaginatedOfListOfFieldProfile result = apiInstance.FieldProfileV2Get(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] [default to 0]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfFieldProfile**](PaginatedOfListOfFieldProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2getbyname"></a>
# **FieldProfileV2GetByName**
> PaginatedOfListOfFieldProfile FieldProfileV2GetByName (int? caseId, string name, int? userId = null, int? start = null, int? count = null)

Get a single field profile by name for a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2GetByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 
            var userId = 56;  // int? |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get a single field profile by name for a user
                PaginatedOfListOfFieldProfile result = apiInstance.FieldProfileV2GetByName(caseId, name, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2GetByName: " + e.Message );
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
 **userId** | **int?**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfFieldProfile**](PaginatedOfListOfFieldProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2getdefaultfields"></a>
# **FieldProfileV2GetDefaultFields**
> PaginatedOfListOfProfileFieldInclusionItem FieldProfileV2GetDefaultFields (int? caseId, int? id, int? start = null, int? count = null)

Get the default fields for selection for a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2GetDefaultFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get the default fields for selection for a field profile
                PaginatedOfListOfProfileFieldInclusionItem result = apiInstance.FieldProfileV2GetDefaultFields(caseId, id, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2GetDefaultFields: " + e.Message );
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
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfProfileFieldInclusionItem**](PaginatedOfListOfProfileFieldInclusionItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2getfields"></a>
# **FieldProfileV2GetFields**
> PaginatedOfListOfManagedField FieldProfileV2GetFields (int? caseId, int? id, int? userId = null, bool? combineDateTimeFields = null, bool? includeSpecial = null, int? start = null, int? count = null)

Get the fields of a specified field profile for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2GetFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var combineDateTimeFields = true;  // bool? | combine date/time fields into one field (optional)  (default to false)
            var includeSpecial = true;  // bool? | Specify true to retrieve special grid fields (optional)  (default to true)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get the fields of a specified field profile for a user.
                PaginatedOfListOfManagedField result = apiInstance.FieldProfileV2GetFields(caseId, id, userId, combineDateTimeFields, includeSpecial, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2GetFields: " + e.Message );
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
 **userId** | **int?**|  | [optional] 
 **combineDateTimeFields** | **bool?**| combine date/time fields into one field | [optional] [default to false]
 **includeSpecial** | **bool?**| Specify true to retrieve special grid fields | [optional] [default to true]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfManagedField**](PaginatedOfListOfManagedField.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2post"></a>
# **FieldProfileV2Post**
> FieldProfileCreate FieldProfileV2Post (int? caseId, FieldProfileCreate body = null)

Create a new field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var body = new FieldProfileCreate(); // FieldProfileCreate |  (optional) 

            try
            {
                // Create a new field profile
                FieldProfileCreate result = apiInstance.FieldProfileV2Post(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**FieldProfileCreate**](FieldProfileCreate.md)|  | [optional] 

### Return type

[**FieldProfileCreate**](FieldProfileCreate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2put"></a>
# **FieldProfileV2Put**
> FieldProfileUpdate FieldProfileV2Put (int? caseId, FieldProfileUpdate body = null)

Update an existing field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2PutExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var body = new FieldProfileUpdate(); // FieldProfileUpdate |  (optional) 

            try
            {
                // Update an existing field profile
                FieldProfileUpdate result = apiInstance.FieldProfileV2Put(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2Put: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**FieldProfileUpdate**](FieldProfileUpdate.md)|  | [optional] 

### Return type

[**FieldProfileUpdate**](FieldProfileUpdate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2setdefaultfieldsdisplayorder"></a>
# **FieldProfileV2SetDefaultFieldsDisplayOrder**
> void FieldProfileV2SetDefaultFieldsDisplayOrder (int? caseId, int? id, bool? overwriteUserProfiles = null, List<ManagedFieldDisplayOrdering> body = null)

Set the default field profile field display order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2SetDefaultFieldsDisplayOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var overwriteUserProfiles = true;  // bool? |  (optional)  (default to false)
            var body = new List<ManagedFieldDisplayOrdering>(); // List<ManagedFieldDisplayOrdering> |  (optional) 

            try
            {
                // Set the default field profile field display order.
                apiInstance.FieldProfileV2SetDefaultFieldsDisplayOrder(caseId, id, overwriteUserProfiles, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2SetDefaultFieldsDisplayOrder: " + e.Message );
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
 **overwriteUserProfiles** | **bool?**|  | [optional] [default to false]
 **body** | [**List&lt;ManagedFieldDisplayOrdering&gt;**](ManagedFieldDisplayOrdering.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2setdefaultfieldssortorder"></a>
# **FieldProfileV2SetDefaultFieldsSortOrder**
> void FieldProfileV2SetDefaultFieldsSortOrder (int? caseId, int? id, bool? overwriteUserProfiles = null, List<ManagedFieldSortOrdering> body = null)

Set the default field profile field sort order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2SetDefaultFieldsSortOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var overwriteUserProfiles = true;  // bool? |  (optional)  (default to false)
            var body = new List<ManagedFieldSortOrdering>(); // List<ManagedFieldSortOrdering> |  (optional) 

            try
            {
                // Set the default field profile field sort order.
                apiInstance.FieldProfileV2SetDefaultFieldsSortOrder(caseId, id, overwriteUserProfiles, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2SetDefaultFieldsSortOrder: " + e.Message );
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
 **overwriteUserProfiles** | **bool?**|  | [optional] [default to false]
 **body** | [**List&lt;ManagedFieldSortOrdering&gt;**](ManagedFieldSortOrdering.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2setfieldsdisplayorder"></a>
# **FieldProfileV2SetFieldsDisplayOrder**
> void FieldProfileV2SetFieldsDisplayOrder (int? caseId, int? id, int? userId = null, List<ManagedFieldDisplayOrdering> body = null)

Set a user's display order and visibility of fields for a specified field profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2SetFieldsDisplayOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var body = new List<ManagedFieldDisplayOrdering>(); // List<ManagedFieldDisplayOrdering> | DisplayOrder starts at 1 (optional) 

            try
            {
                // Set a user's display order and visibility of fields for a specified field profile.
                apiInstance.FieldProfileV2SetFieldsDisplayOrder(caseId, id, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2SetFieldsDisplayOrder: " + e.Message );
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
 **userId** | **int?**|  | [optional] 
 **body** | [**List&lt;ManagedFieldDisplayOrdering&gt;**](ManagedFieldDisplayOrdering.md)| DisplayOrder starts at 1 | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2setfieldssortorder"></a>
# **FieldProfileV2SetFieldsSortOrder**
> void FieldProfileV2SetFieldsSortOrder (int? caseId, int? id, int? userId = null, List<ManagedFieldSortOrdering> body = null)

Set a user's sort order of fields for a specified field profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2SetFieldsSortOrderExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var body = new List<ManagedFieldSortOrdering>(); // List<ManagedFieldSortOrdering> |  (optional) 

            try
            {
                // Set a user's sort order of fields for a specified field profile.
                apiInstance.FieldProfileV2SetFieldsSortOrder(caseId, id, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2SetFieldsSortOrder: " + e.Message );
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
 **userId** | **int?**|  | [optional] 
 **body** | [**List&lt;ManagedFieldSortOrdering&gt;**](ManagedFieldSortOrdering.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilev2unassociatewithfields"></a>
# **FieldProfileV2UnAssociateWithFields**
> void FieldProfileV2UnAssociateWithFields (int? caseId, int? id, List<int?> body = null)

Removes fields from a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldProfileV2UnAssociateWithFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = ;  // List<int?> |  (optional) 

            try
            {
                // Removes fields from a field profile
                apiInstance.FieldProfileV2UnAssociateWithFields(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfilesApi.FieldProfileV2UnAssociateWithFields: " + e.Message );
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
 **body** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

