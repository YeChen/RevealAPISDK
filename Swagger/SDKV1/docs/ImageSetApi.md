# RevealAPI.V1.Api.Resources.ImageSetApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImageSetGet**](ImageSetApi.md#imagesetget) | **GET** /api/imageSet | Get a list of image sets
[**ImageSetGetById**](ImageSetApi.md#imagesetgetbyid) | **GET** /api/imageSet/{imageSetId} | Get an image set
[**ImageSetPost**](ImageSetApi.md#imagesetpost) | **POST** /api/imageSet | Create a new image set


<a name="imagesetget"></a>
# **ImageSetGet**
> List<ImageSet> ImageSetGet (string caseid = null)

Get a list of image sets

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ImageSetGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetApi();
            var caseid = caseid_example;  // string |  (optional) 

            try
            {
                // Get a list of image sets
                List&lt;ImageSet&gt; result = apiInstance.ImageSetGet(caseid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetApi.ImageSetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseid** | **string**|  | [optional] 

### Return type

[**List<ImageSet>**](ImageSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesetgetbyid"></a>
# **ImageSetGetById**
> ImageSet ImageSetGetById (int? imageSetId, int? caseId = null)

Get an image set

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ImageSetGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetApi();
            var imageSetId = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get an image set
                ImageSet result = apiInstance.ImageSetGetById(imageSetId, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetApi.ImageSetGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageSetId** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

[**ImageSet**](ImageSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesetpost"></a>
# **ImageSetPost**
> ImageSetCreate ImageSetPost (int? caseId = null, ImageSetCreate body = null)

Create a new image set

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ImageSetPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ImageSetApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new ImageSetCreate(); // ImageSetCreate |  (optional) 

            try
            {
                // Create a new image set
                ImageSetCreate result = apiInstance.ImageSetPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageSetApi.ImageSetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**ImageSetCreate**](ImageSetCreate.md)|  | [optional] 

### Return type

[**ImageSetCreate**](ImageSetCreate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

