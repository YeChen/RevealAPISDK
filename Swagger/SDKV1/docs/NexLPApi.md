# RevealAPI.V1.Api.Resources.NexLPApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NexLPGetNexLPJobDocumentIds**](NexLPApi.md#nexlpgetnexlpjobdocumentids) | **GET** /api/NexLP/jobs/documentIds/{id} | Get the list of document ids for a NexLP processing job.  On the first call start offset should be 0 or 1, on subsequent calls it should be \&quot;count of results received + 1\&quot;  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
[**NexLPGetNexLPJobs**](NexLPApi.md#nexlpgetnexlpjobs) | **GET** /api/NexLP/jobs | Get a list of NexLP processing jobs in a case
[**NexLPGetSingleNexLPJob**](NexLPApi.md#nexlpgetsinglenexlpjob) | **GET** /api/NexLP/jobs/{id} | Get a single NexLP Job in a case


<a name="nexlpgetnexlpjobdocumentids"></a>
# **NexLPGetNexLPJobDocumentIds**
> List<NexLPJobItem> NexLPGetNexLPJobDocumentIds (int? id, int? caseId = null, string keyField = null, int? startRow = null, int? batchSize = null)

Get the list of document ids for a NexLP processing job.  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class NexLPGetNexLPJobDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new NexLPApi();
            var id = 56;  // int? | Reveal NexLP job Id
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var keyField = keyField_example;  // string | ITEMID or BEGDOC (optional) 
            var startRow = 56;  // int? | Starting row offset. Use 0 for first request (optional) 
            var batchSize = 56;  // int? | Chunksize of records to return (optional) 

            try
            {
                // Get the list of document ids for a NexLP processing job.  On the first call start offset should be 0 or 1, on subsequent calls it should be \"count of results received + 1\"  If you receive less records than the batchsize you sent in (unless you sent in 0) then you are done.
                List&lt;NexLPJobItem&gt; result = apiInstance.NexLPGetNexLPJobDocumentIds(id, caseId, keyField, startRow, batchSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NexLPApi.NexLPGetNexLPJobDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Reveal NexLP job Id | 
 **caseId** | **int?**| Reveal case Id | [optional] 
 **keyField** | **string**| ITEMID or BEGDOC | [optional] 
 **startRow** | **int?**| Starting row offset. Use 0 for first request | [optional] 
 **batchSize** | **int?**| Chunksize of records to return | [optional] 

### Return type

[**List<NexLPJobItem>**](NexLPJobItem.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nexlpgetnexlpjobs"></a>
# **NexLPGetNexLPJobs**
> List<NexLPJob> NexLPGetNexLPJobs (int? caseId = null, int? status = null)

Get a list of NexLP processing jobs in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class NexLPGetNexLPJobsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new NexLPApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var status = 56;  // int? | -1-Any, 0-Created, 1-Submitted, 2-In Process, 3-Complete, 4-Error, 5-Cancelled, 6-Cancel Pending, 7-Deleted, 8-Modified (optional) 

            try
            {
                // Get a list of NexLP processing jobs in a case
                List&lt;NexLPJob&gt; result = apiInstance.NexLPGetNexLPJobs(caseId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NexLPApi.NexLPGetNexLPJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **status** | **int?**| -1-Any, 0-Created, 1-Submitted, 2-In Process, 3-Complete, 4-Error, 5-Cancelled, 6-Cancel Pending, 7-Deleted, 8-Modified | [optional] 

### Return type

[**List<NexLPJob>**](NexLPJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nexlpgetsinglenexlpjob"></a>
# **NexLPGetSingleNexLPJob**
> NexLPJob NexLPGetSingleNexLPJob (int? id, int? caseId = null)

Get a single NexLP Job in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class NexLPGetSingleNexLPJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new NexLPApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get a single NexLP Job in a case
                NexLPJob result = apiInstance.NexLPGetSingleNexLPJob(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NexLPApi.NexLPGetSingleNexLPJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

[**NexLPJob**](NexLPJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

