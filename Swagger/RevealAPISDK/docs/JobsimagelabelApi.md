# IO.Swagger.Api.JobsimagelabelApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImageLabelJobProcessImageLabel**](JobsimagelabelApi.md#imagelabeljobprocessimagelabel) | **POST** /api/v2/{caseId}/jobs/imagelabel | 


<a name="imagelabeljobprocessimagelabel"></a>
# **ImageLabelJobProcessImageLabel**
> CreateJobResponse ImageLabelJobProcessImageLabel (int? caseId, ImageLabelJobCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImageLabelJobProcessImageLabelExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsimagelabelApi();
            var caseId = 56;  // int? | 
            var body = new ImageLabelJobCreate(); // ImageLabelJobCreate |  (optional) 

            try
            {
                CreateJobResponse result = apiInstance.ImageLabelJobProcessImageLabel(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsimagelabelApi.ImageLabelJobProcessImageLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**ImageLabelJobCreate**](ImageLabelJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

