# IO.Swagger.Api.ImageSetsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImageSetV2Get**](ImageSetsApi.md#imagesetv2get) | **GET** /api/v2/{caseId}/imageSets/{id} | Get an image set
[**ImageSetV2GetList**](ImageSetsApi.md#imagesetv2getlist) | **GET** /api/v2/{caseId}/imageSets | Get a list of image sets
[**ImageSetV2Post**](ImageSetsApi.md#imagesetv2post) | **POST** /api/v2/{caseId}/imageSets | Create a new image set


<a name="imagesetv2get"></a>
# **ImageSetV2Get**
> ImageSet ImageSetV2Get (int? caseId, int? id)

Get an image set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImageSetV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get an image set
                ImageSet result = apiInstance.ImageSetV2Get(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetsApi.ImageSetV2Get: " + e.Message );
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

[**ImageSet**](ImageSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesetv2getlist"></a>
# **ImageSetV2GetList**
> PaginatedOfListOfImageSet ImageSetV2GetList (int? caseId, int? start = null, int? count = null)

Get a list of image sets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImageSetV2GetListExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetsApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get a list of image sets
                PaginatedOfListOfImageSet result = apiInstance.ImageSetV2GetList(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetsApi.ImageSetV2GetList: " + e.Message );
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

[**PaginatedOfListOfImageSet**](PaginatedOfListOfImageSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesetv2post"></a>
# **ImageSetV2Post**
> ImageSetCreate ImageSetV2Post (int? caseId, ImageSetCreate body = null)

Create a new image set

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImageSetV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetsApi();
            var caseId = 56;  // int? | 
            var body = new ImageSetCreate(); // ImageSetCreate |  (optional) 

            try
            {
                // Create a new image set
                ImageSetCreate result = apiInstance.ImageSetV2Post(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetsApi.ImageSetV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**ImageSetCreate**](ImageSetCreate.md)|  | [optional] 

### Return type

[**ImageSetCreate**](ImageSetCreate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

