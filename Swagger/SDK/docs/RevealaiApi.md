# RevealAPI.Sdk.Api.Resources.RevealaiApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RevealAiPassThroughDelete**](RevealaiApi.md#revealaipassthroughdelete) | **DELETE** /api/v2/revealai/{path} | 
[**RevealAiPassThroughGet**](RevealaiApi.md#revealaipassthroughget) | **GET** /api/v2/revealai/{path} | 
[**RevealAiPassThroughHead**](RevealaiApi.md#revealaipassthroughhead) | **HEAD** /api/v2/revealai/{path} | 
[**RevealAiPassThroughPatch**](RevealaiApi.md#revealaipassthroughpatch) | **PATCH** /api/v2/revealai/{path} | 
[**RevealAiPassThroughPost**](RevealaiApi.md#revealaipassthroughpost) | **POST** /api/v2/revealai/{path} | 
[**RevealAiPassThroughPostForm**](RevealaiApi.md#revealaipassthroughpostform) | **POST** /api/v2/revealai/form/{path} | 
[**RevealAiPassThroughPut**](RevealaiApi.md#revealaipassthroughput) | **PUT** /api/v2/revealai/{path} | 


<a name="revealaipassthroughdelete"></a>
# **RevealAiPassThroughDelete**
> void RevealAiPassThroughDelete (string path, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.RevealAiPassThroughDelete(path, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughget"></a>
# **RevealAiPassThroughGet**
> void RevealAiPassThroughGet (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.RevealAiPassThroughGet(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughhead"></a>
# **RevealAiPassThroughHead**
> void RevealAiPassThroughHead (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughHeadExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.RevealAiPassThroughHead(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughpatch"></a>
# **RevealAiPassThroughPatch**
> void RevealAiPassThroughPatch (string path, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughPatchExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.RevealAiPassThroughPatch(path, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughpost"></a>
# **RevealAiPassThroughPost**
> void RevealAiPassThroughPost (string path, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.RevealAiPassThroughPost(path, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughpostform"></a>
# **RevealAiPassThroughPostForm**
> void RevealAiPassThroughPostForm (string path, List<KeyValuePairOfStringAndStringValues> formData = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughPostFormExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 
            var formData = new List<KeyValuePairOfStringAndStringValues>(); // List<KeyValuePairOfStringAndStringValues> |  (optional) 

            try
            {
                apiInstance.RevealAiPassThroughPostForm(path, formData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughPostForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **formData** | [**List&lt;KeyValuePairOfStringAndStringValues&gt;**](KeyValuePairOfStringAndStringValues.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revealaipassthroughput"></a>
# **RevealAiPassThroughPut**
> void RevealAiPassThroughPut (string path, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class RevealAiPassThroughPutExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new RevealaiApi();
            var path = path_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.RevealAiPassThroughPut(path, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevealaiApi.RevealAiPassThroughPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

