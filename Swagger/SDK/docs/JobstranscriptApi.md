# RevealAPI.Sdk.Api.Resources.JobstranscriptApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranscriptJobProcessTranscripts**](JobstranscriptApi.md#transcriptjobprocesstranscripts) | **POST** /api/v2/{caseId}/jobs/transcript | 


<a name="transcriptjobprocesstranscripts"></a>
# **TranscriptJobProcessTranscripts**
> CreateJobResponse TranscriptJobProcessTranscripts (int? caseId, TranscriptJobCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class TranscriptJobProcessTranscriptsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobstranscriptApi();
            var caseId = 56;  // int? | 
            var body = new TranscriptJobCreate(); // TranscriptJobCreate |  (optional) 

            try
            {
                CreateJobResponse result = apiInstance.TranscriptJobProcessTranscripts(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobstranscriptApi.TranscriptJobProcessTranscripts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**TranscriptJobCreate**](TranscriptJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

