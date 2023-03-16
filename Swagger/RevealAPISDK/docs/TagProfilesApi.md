# IO.Swagger.Api.TagProfilesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagProfileV2Delete**](TagProfilesApi.md#tagprofilev2delete) | **DELETE** /api/v2/{caseId}/tagProfiles | deletes a tag profile in a case
[**TagProfileV2GetSingleTagProfileById**](TagProfilesApi.md#tagprofilev2getsingletagprofilebyid) | **GET** /api/v2/{caseId}/tagProfiles/{id} | get a single tag profile by id
[**TagProfileV2GetSingleTagProfileByName**](TagProfilesApi.md#tagprofilev2getsingletagprofilebyname) | **GET** /api/v2/{caseId}/tagProfiles/getByName/{name} | get a single tag profile by name
[**TagProfileV2GetTagProfilesList**](TagProfilesApi.md#tagprofilev2gettagprofileslist) | **GET** /api/v2/{caseId}/tagProfiles | get a list of all tags profiles along with their tag sets and tag in a case
[**TagProfileV2GetTagProfilesList2**](TagProfilesApi.md#tagprofilev2gettagprofileslist2) | **GET** /api/v2/{caseId}/tagProfiles/new | get a list of all tags profiles along with their tag sets and tag in a case
[**TagProfileV2GetTagProfilesWithModel**](TagProfilesApi.md#tagprofilev2gettagprofileswithmodel) | **GET** /api/v2/{caseId}/tagProfiles/AIModelId/{aiModelId} | get tag profiles by user ID and AI Model ID
[**TagProfileV2Post**](TagProfilesApi.md#tagprofilev2post) | **POST** /api/v2/{caseId}/tagProfiles | creates a tag profile in a case
[**TagProfileV2ValidateTagProfileUserPermissionById**](TagProfilesApi.md#tagprofilev2validatetagprofileuserpermissionbyid) | **POST** /api/v2/{caseId}/tagProfiles/{id}/hasPermission | check if the user/team have permission to the tag profile


<a name="tagprofilev2delete"></a>
# **TagProfileV2Delete**
> void TagProfileV2Delete (int? caseId, string name = null)

deletes a tag profile in a case

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string |  (optional) 

            try
            {
                // deletes a tag profile in a case
                apiInstance.TagProfileV2Delete(caseId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **name** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2getsingletagprofilebyid"></a>
# **TagProfileV2GetSingleTagProfileById**
> TagProfile TagProfileV2GetSingleTagProfileById (int? caseId, int? id)

get a single tag profile by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2GetSingleTagProfileByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // get a single tag profile by id
                TagProfile result = apiInstance.TagProfileV2GetSingleTagProfileById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2GetSingleTagProfileById: " + e.Message );
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

[**TagProfile**](TagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2getsingletagprofilebyname"></a>
# **TagProfileV2GetSingleTagProfileByName**
> TagProfile TagProfileV2GetSingleTagProfileByName (int? caseId, string name)

get a single tag profile by name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2GetSingleTagProfileByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 

            try
            {
                // get a single tag profile by name
                TagProfile result = apiInstance.TagProfileV2GetSingleTagProfileByName(caseId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2GetSingleTagProfileByName: " + e.Message );
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

[**TagProfile**](TagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2gettagprofileslist"></a>
# **TagProfileV2GetTagProfilesList**
> PaginatedOfIEnumerableOfTagProfile TagProfileV2GetTagProfilesList (int? caseId, int? start = null, int? count = null)

get a list of all tags profiles along with their tag sets and tag in a case

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2GetTagProfilesListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // get a list of all tags profiles along with their tag sets and tag in a case
                PaginatedOfIEnumerableOfTagProfile result = apiInstance.TagProfileV2GetTagProfilesList(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2GetTagProfilesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfTagProfile**](PaginatedOfIEnumerableOfTagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2gettagprofileslist2"></a>
# **TagProfileV2GetTagProfilesList2**
> PaginatedOfIEnumerableOfTagProfile TagProfileV2GetTagProfilesList2 (int? caseId, int? start = null, int? count = null)

get a list of all tags profiles along with their tag sets and tag in a case

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2GetTagProfilesList2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // get a list of all tags profiles along with their tag sets and tag in a case
                PaginatedOfIEnumerableOfTagProfile result = apiInstance.TagProfileV2GetTagProfilesList2(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2GetTagProfilesList2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfTagProfile**](PaginatedOfIEnumerableOfTagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2gettagprofileswithmodel"></a>
# **TagProfileV2GetTagProfilesWithModel**
> List<TagProfile> TagProfileV2GetTagProfilesWithModel (int? caseId, int? aiModelId, int? userId = null)

get tag profiles by user ID and AI Model ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2GetTagProfilesWithModelExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var aiModelId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 

            try
            {
                // get tag profiles by user ID and AI Model ID
                List&lt;TagProfile&gt; result = apiInstance.TagProfileV2GetTagProfilesWithModel(caseId, aiModelId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2GetTagProfilesWithModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **aiModelId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 

### Return type

[**List<TagProfile>**](TagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2post"></a>
# **TagProfileV2Post**
> TagProfile TagProfileV2Post (int? caseId, TagProfileCreateEdit body = null)

creates a tag profile in a case

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var body = new TagProfileCreateEdit(); // TagProfileCreateEdit |  (optional) 

            try
            {
                // creates a tag profile in a case
                TagProfile result = apiInstance.TagProfileV2Post(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**TagProfileCreateEdit**](TagProfileCreateEdit.md)|  | [optional] 

### Return type

[**TagProfile**](TagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilev2validatetagprofileuserpermissionbyid"></a>
# **TagProfileV2ValidateTagProfileUserPermissionById**
> bool? TagProfileV2ValidateTagProfileUserPermissionById (int? caseId, int? id, TagProfileUserPermissionValitation body = null)

check if the user/team have permission to the tag profile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagProfileV2ValidateTagProfileUserPermissionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfilesApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 
            var body = new TagProfileUserPermissionValitation(); // TagProfileUserPermissionValitation |  (optional) 

            try
            {
                // check if the user/team have permission to the tag profile
                bool? result = apiInstance.TagProfileV2ValidateTagProfileUserPermissionById(caseId, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfilesApi.TagProfileV2ValidateTagProfileUserPermissionById: " + e.Message );
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
 **body** | [**TagProfileUserPermissionValitation**](TagProfileUserPermissionValitation.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

