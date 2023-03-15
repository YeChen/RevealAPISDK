# RevealAPI.Sdk.Api.Resources.JobsunassignmentApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UnassignmentJobPost**](JobsunassignmentApi.md#unassignmentjobpost) | **POST** /api/v2/{caseId}/jobs/unassignment | Create an unassignment job


<a name="unassignmentjobpost"></a>
# **UnassignmentJobPost**
> CreateJobResponse UnassignmentJobPost (int? caseId, UnassignmentJobCreate body = null)

Create an unassignment job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class UnassignmentJobPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobsunassignmentApi();
            var caseId = 56;  // int? | 
            var body = new UnassignmentJobCreate(); // UnassignmentJobCreate |  (optional) 

            try
            {
                // Create an unassignment job
                CreateJobResponse result = apiInstance.UnassignmentJobPost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobsunassignmentApi.UnassignmentJobPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**UnassignmentJobCreate**](UnassignmentJobCreate.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

