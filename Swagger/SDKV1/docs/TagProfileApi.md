# RevealAPI.V1.Api.Resources.TagProfileApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagProfileCreate**](TagProfileApi.md#tagprofilecreate) | **POST** /api/tagProfile/create | 
[**TagProfileDelete**](TagProfileApi.md#tagprofiledelete) | **DELETE** /api/tagProfile/delete | 
[**TagProfileEdit**](TagProfileApi.md#tagprofileedit) | **POST** /api/tagProfile/edit | 
[**TagProfileGetTagProfiles**](TagProfileApi.md#tagprofilegettagprofiles) | **GET** /api/tagProfile | 


<a name="tagprofilecreate"></a>
# **TagProfileCreate**
> void TagProfileCreate (int? caseId = null, long? userId = null, TagProfileCreateEdit body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagProfileCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var body = new TagProfileCreateEdit(); // TagProfileCreateEdit |  (optional) 

            try
            {
                apiInstance.TagProfileCreate(caseId, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfileApi.TagProfileCreate: " + e.Message );
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
 **body** | [**TagProfileCreateEdit**](TagProfileCreateEdit.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofiledelete"></a>
# **TagProfileDelete**
> void TagProfileDelete (int? caseId = null, long? userId = null, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagProfileDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var name = name_example;  // string |  (optional) 

            try
            {
                apiInstance.TagProfileDelete(caseId, userId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfileApi.TagProfileDelete: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofileedit"></a>
# **TagProfileEdit**
> void TagProfileEdit (int? caseId = null, long? userId = null, TagProfileCreateEdit body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagProfileEditExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 789;  // long? |  (optional) 
            var body = new TagProfileCreateEdit(); // TagProfileCreateEdit |  (optional) 

            try
            {
                apiInstance.TagProfileEdit(caseId, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfileApi.TagProfileEdit: " + e.Message );
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
 **body** | [**TagProfileCreateEdit**](TagProfileCreateEdit.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagprofilegettagprofiles"></a>
# **TagProfileGetTagProfiles**
> void TagProfileGetTagProfiles (int? caseId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TagProfileGetTagProfilesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TagProfileApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.TagProfileGetTagProfiles(caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagProfileApi.TagProfileGetTagProfiles: " + e.Message );
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

