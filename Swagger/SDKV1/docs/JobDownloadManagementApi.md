# RevealAPI.V1.Api.Resources.JobDownloadManagementApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JobDownloadManagementGet**](JobDownloadManagementApi.md#jobdownloadmanagementget) | **GET** /api/jobDownload/{caseId}/{downloadGuid} | 


<a name="jobdownloadmanagementget"></a>
# **JobDownloadManagementGet**
> JobDownload JobDownloadManagementGet (int? caseId, string downloadGuid, string downloadManagerVersion = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class JobDownloadManagementGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobDownloadManagementApi();
            var caseId = 56;  // int? | 
            var downloadGuid = downloadGuid_example;  // string | 
            var downloadManagerVersion = downloadManagerVersion_example;  // string |  (optional) 

            try
            {
                JobDownload result = apiInstance.JobDownloadManagementGet(caseId, downloadGuid, downloadManagerVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobDownloadManagementApi.JobDownloadManagementGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **downloadGuid** | **string**|  | 
 **downloadManagerVersion** | **string**|  | [optional] 

### Return type

[**JobDownload**](JobDownload.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

