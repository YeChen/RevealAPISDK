# RevealAPI.V1.Api.Resources.ArchiveApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ArchiveGet**](ArchiveApi.md#archiveget) | **GET** /api/archive/{caseId}/{archiveId} | Get a presigned url downloading an archive


<a name="archiveget"></a>
# **ArchiveGet**
> ArchiveDownload ArchiveGet (int? caseId, string archiveId, string downloadManagerVersion = null)

Get a presigned url downloading an archive

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ArchiveGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ArchiveApi();
            var caseId = 56;  // int? | Reveal case Id
            var archiveId = archiveId_example;  // string | Archive Id
            var downloadManagerVersion = downloadManagerVersion_example;  // string | Reveal Download Manager Version (optional) 

            try
            {
                // Get a presigned url downloading an archive
                ArchiveDownload result = apiInstance.ArchiveGet(caseId, archiveId, downloadManagerVersion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | 
 **archiveId** | **string**| Archive Id | 
 **downloadManagerVersion** | **string**| Reveal Download Manager Version | [optional] 

### Return type

[**ArchiveDownload**](ArchiveDownload.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

