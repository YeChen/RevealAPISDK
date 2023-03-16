# IO.Swagger.Api.MetadataSearchProfilesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MetadataSearchProfilesCreateSearchProfile**](MetadataSearchProfilesApi.md#metadatasearchprofilescreatesearchprofile) | **POST** /api/v2/{caseId}/metadataSearchProfiles | Create a Metadata Search Profile
[**MetadataSearchProfilesDeleteSearchProfile**](MetadataSearchProfilesApi.md#metadatasearchprofilesdeletesearchprofile) | **DELETE** /api/v2/{caseId}/metadataSearchProfiles/{id} | Delete a Metadata Search Profile
[**MetadataSearchProfilesGetSearchProfile**](MetadataSearchProfilesApi.md#metadatasearchprofilesgetsearchprofile) | **GET** /api/v2/{caseId}/metadataSearchProfiles/{id} | Get a Metadata Search Profile
[**MetadataSearchProfilesGetSearchProfileFields**](MetadataSearchProfilesApi.md#metadatasearchprofilesgetsearchprofilefields) | **GET** /api/v2/{caseId}/metadataSearchProfiles/{id}/fields | Get metadata fields and whether they have been selected
[**MetadataSearchProfilesGetSearchProfiles**](MetadataSearchProfilesApi.md#metadatasearchprofilesgetsearchprofiles) | **GET** /api/v2/{caseId}/metadataSearchProfiles | Get Metadata Search Profiles
[**MetadataSearchProfilesSetSearchProfileFields**](MetadataSearchProfilesApi.md#metadatasearchprofilessetsearchprofilefields) | **PUT** /api/v2/{caseId}/metadataSearchProfiles/{id}/fields | Update a Metadata Search Profile&#39;s selected fields
[**MetadataSearchProfilesUpdateSearchProfile**](MetadataSearchProfilesApi.md#metadatasearchprofilesupdatesearchprofile) | **PATCH** /api/v2/{caseId}/metadataSearchProfiles/{id} | Update a Metadata Search Profile


<a name="metadatasearchprofilescreatesearchprofile"></a>
# **MetadataSearchProfilesCreateSearchProfile**
> int? MetadataSearchProfilesCreateSearchProfile (int? caseId, MetadataSearchProfileCreate body = null)

Create a Metadata Search Profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesCreateSearchProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var body = new MetadataSearchProfileCreate(); // MetadataSearchProfileCreate |  (optional) 

            try
            {
                // Create a Metadata Search Profile
                int? result = apiInstance.MetadataSearchProfilesCreateSearchProfile(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesCreateSearchProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**MetadataSearchProfileCreate**](MetadataSearchProfileCreate.md)|  | [optional] 

### Return type

**int?**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metadatasearchprofilesdeletesearchprofile"></a>
# **MetadataSearchProfilesDeleteSearchProfile**
> void MetadataSearchProfilesDeleteSearchProfile (int? caseId, int? id)

Delete a Metadata Search Profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesDeleteSearchProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a Metadata Search Profile
                apiInstance.MetadataSearchProfilesDeleteSearchProfile(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesDeleteSearchProfile: " + e.Message );
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

<a name="metadatasearchprofilesgetsearchprofile"></a>
# **MetadataSearchProfilesGetSearchProfile**
> MetadataSearchProfile MetadataSearchProfilesGetSearchProfile (int? caseId, int? id)

Get a Metadata Search Profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesGetSearchProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a Metadata Search Profile
                MetadataSearchProfile result = apiInstance.MetadataSearchProfilesGetSearchProfile(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesGetSearchProfile: " + e.Message );
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

[**MetadataSearchProfile**](MetadataSearchProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metadatasearchprofilesgetsearchprofilefields"></a>
# **MetadataSearchProfilesGetSearchProfileFields**
> PaginatedOfIEnumerableOfProfileFieldInclusionItem MetadataSearchProfilesGetSearchProfileFields (int? caseId, int? id, int? start = null, int? count = null)

Get metadata fields and whether they have been selected

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesGetSearchProfileFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get metadata fields and whether they have been selected
                PaginatedOfIEnumerableOfProfileFieldInclusionItem result = apiInstance.MetadataSearchProfilesGetSearchProfileFields(caseId, id, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesGetSearchProfileFields: " + e.Message );
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

[**PaginatedOfIEnumerableOfProfileFieldInclusionItem**](PaginatedOfIEnumerableOfProfileFieldInclusionItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metadatasearchprofilesgetsearchprofiles"></a>
# **MetadataSearchProfilesGetSearchProfiles**
> PaginatedOfIEnumerableOfMetadataSearchProfile MetadataSearchProfilesGetSearchProfiles (int? caseId, int? userId = null, int? start = null, int? count = null)

Get Metadata Search Profiles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesGetSearchProfilesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | Get profiles that a specific user has access to (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get Metadata Search Profiles
                PaginatedOfIEnumerableOfMetadataSearchProfile result = apiInstance.MetadataSearchProfilesGetSearchProfiles(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesGetSearchProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**| Get profiles that a specific user has access to | [optional] [default to 0]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfMetadataSearchProfile**](PaginatedOfIEnumerableOfMetadataSearchProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metadatasearchprofilessetsearchprofilefields"></a>
# **MetadataSearchProfilesSetSearchProfileFields**
> void MetadataSearchProfilesSetSearchProfileFields (int? caseId, int? id, List<int?> body = null)

Update a Metadata Search Profile's selected fields

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesSetSearchProfileFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = ;  // List<int?> |  (optional) 

            try
            {
                // Update a Metadata Search Profile's selected fields
                apiInstance.MetadataSearchProfilesSetSearchProfileFields(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesSetSearchProfileFields: " + e.Message );
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

<a name="metadatasearchprofilesupdatesearchprofile"></a>
# **MetadataSearchProfilesUpdateSearchProfile**
> void MetadataSearchProfilesUpdateSearchProfile (int? caseId, int? id, MetadataSearchProfileUpdate body = null)

Update a Metadata Search Profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MetadataSearchProfilesUpdateSearchProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new MetadataSearchProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = new MetadataSearchProfileUpdate(); // MetadataSearchProfileUpdate |  (optional) 

            try
            {
                // Update a Metadata Search Profile
                apiInstance.MetadataSearchProfilesUpdateSearchProfile(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataSearchProfilesApi.MetadataSearchProfilesUpdateSearchProfile: " + e.Message );
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
 **body** | [**MetadataSearchProfileUpdate**](MetadataSearchProfileUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

