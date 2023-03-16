# IO.Swagger.Api.BrainspaceApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BrainspacePassThrough**](BrainspaceApi.md#brainspacepassthrough) | **GET** /api/v2/rest/{path} | 
[**BrainspacePassThrough_0**](BrainspaceApi.md#brainspacepassthrough_0) | **HEAD** /api/v2/rest/{path} | 
[**BrainspacePassThrough_1**](BrainspaceApi.md#brainspacepassthrough_1) | **PUT** /api/v2/rest/{path} | 
[**BrainspacePassThrough_2**](BrainspaceApi.md#brainspacepassthrough_2) | **POST** /api/v2/rest/{path} | 
[**BrainspacePassThrough_3**](BrainspaceApi.md#brainspacepassthrough_3) | **DELETE** /api/v2/rest/{path} | 
[**BrainspacePassThrough_4**](BrainspaceApi.md#brainspacepassthrough_4) | **PATCH** /api/v2/rest/{path} | 


<a name="brainspacepassthrough"></a>
# **BrainspacePassThrough**
> void BrainspacePassThrough (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThroughExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough: " + e.Message );
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

<a name="brainspacepassthrough_0"></a>
# **BrainspacePassThrough_0**
> void BrainspacePassThrough_0 (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThrough_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough_0(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough_0: " + e.Message );
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

<a name="brainspacepassthrough_1"></a>
# **BrainspacePassThrough_1**
> void BrainspacePassThrough_1 (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThrough_1Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough_1(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough_1: " + e.Message );
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

<a name="brainspacepassthrough_2"></a>
# **BrainspacePassThrough_2**
> void BrainspacePassThrough_2 (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThrough_2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough_2(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough_2: " + e.Message );
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

<a name="brainspacepassthrough_3"></a>
# **BrainspacePassThrough_3**
> void BrainspacePassThrough_3 (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThrough_3Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough_3(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough_3: " + e.Message );
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

<a name="brainspacepassthrough_4"></a>
# **BrainspacePassThrough_4**
> void BrainspacePassThrough_4 (string path)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BrainspacePassThrough_4Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new BrainspaceApi();
            var path = path_example;  // string | 

            try
            {
                apiInstance.BrainspacePassThrough_4(path);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrainspaceApi.BrainspacePassThrough_4: " + e.Message );
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

