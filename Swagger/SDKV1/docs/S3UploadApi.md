# RevealAPI.V1.Api.Resources.S3UploadApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**S3UploadGetS3Signature**](S3UploadApi.md#s3uploadgets3signature) | **GET** /api/s3upload/auth | 
[**S3UploadPostManifest**](S3UploadApi.md#s3uploadpostmanifest) | **POST** /api/s3upload/manifest | 


<a name="s3uploadgets3signature"></a>
# **S3UploadGetS3Signature**
> void S3UploadGetS3Signature (string toSign = null, string datetime = null, string canonicalRequest = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class S3UploadGetS3SignatureExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new S3UploadApi();
            var toSign = toSign_example;  // string |  (optional) 
            var datetime = datetime_example;  // string |  (optional) 
            var canonicalRequest = canonicalRequest_example;  // string |  (optional) 

            try
            {
                apiInstance.S3UploadGetS3Signature(toSign, datetime, canonicalRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling S3UploadApi.S3UploadGetS3Signature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toSign** | **string**|  | [optional] 
 **datetime** | **string**|  | [optional] 
 **canonicalRequest** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="s3uploadpostmanifest"></a>
# **S3UploadPostManifest**
> int? S3UploadPostManifest (S3Manifest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class S3UploadPostManifestExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new S3UploadApi();
            var body = new S3Manifest(); // S3Manifest |  (optional) 

            try
            {
                int? result = apiInstance.S3UploadPostManifest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling S3UploadApi.S3UploadPostManifest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**S3Manifest**](S3Manifest.md)|  | [optional] 

### Return type

**int?**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

