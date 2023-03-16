# IO.Swagger.Api.JobsuploadApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploadJobCreateUploadJob**](JobsuploadApi.md#uploadjobcreateuploadjob) | **POST** /api/v2/{caseId}/jobs/upload | 
[**UploadJobGetClientConfiguration**](JobsuploadApi.md#uploadjobgetclientconfiguration) | **GET** /api/v2/{caseId}/jobs/upload/client-configuration | 
[**UploadJobGetS3Signature**](JobsuploadApi.md#uploadjobgets3signature) | **GET** /api/v2/upload-signature | 
[**UploadJobUpdateUploadJob**](JobsuploadApi.md#uploadjobupdateuploadjob) | **PUT** /api/v2/{caseId}/jobs/upload/{id} | 


<a name="uploadjobcreateuploadjob"></a>
# **UploadJobCreateUploadJob**
> Guid? UploadJobCreateUploadJob (int? caseId, UploadJobCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadJobCreateUploadJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsuploadApi();
            var caseId = 56;  // int? | 
            var body = new UploadJobCreate(); // UploadJobCreate |  (optional) 

            try
            {
                Guid? result = apiInstance.UploadJobCreateUploadJob(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsuploadApi.UploadJobCreateUploadJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**UploadJobCreate**](UploadJobCreate.md)|  | [optional] 

### Return type

**Guid?**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadjobgetclientconfiguration"></a>
# **UploadJobGetClientConfiguration**
> UploadJobClientConfiguration UploadJobGetClientConfiguration (int? caseId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadJobGetClientConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsuploadApi();
            var caseId = 56;  // int? | 

            try
            {
                UploadJobClientConfiguration result = apiInstance.UploadJobGetClientConfiguration(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsuploadApi.UploadJobGetClientConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

[**UploadJobClientConfiguration**](UploadJobClientConfiguration.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadjobgets3signature"></a>
# **UploadJobGetS3Signature**
> string UploadJobGetS3Signature (string toSign = null, string datetime = null, string canonicalRequest = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadJobGetS3SignatureExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsuploadApi();
            var toSign = toSign_example;  // string |  (optional) 
            var datetime = datetime_example;  // string |  (optional) 
            var canonicalRequest = canonicalRequest_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.UploadJobGetS3Signature(toSign, datetime, canonicalRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsuploadApi.UploadJobGetS3Signature: " + e.Message );
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

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadjobupdateuploadjob"></a>
# **UploadJobUpdateUploadJob**
> void UploadJobUpdateUploadJob (int? caseId, Guid? id, UploadJobUpdate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadJobUpdateUploadJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsuploadApi();
            var caseId = 56;  // int? | 
            var id = new Guid?(); // Guid? | 
            var body = new UploadJobUpdate(); // UploadJobUpdate |  (optional) 

            try
            {
                apiInstance.UploadJobUpdateUploadJob(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsuploadApi.UploadJobUpdateUploadJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | [**Guid?**](Guid?.md)|  | 
 **body** | [**UploadJobUpdate**](UploadJobUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

