# RevealAPI.V1.Api.Resources.ProcessingApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessingDeleteUploadJobReports**](ProcessingApi.md#processingdeleteuploadjobreports) | **DELETE** /api/processing/reports | Delete all upload job processing reports for a job
[**ProcessingGetUploadJobReport**](ProcessingApi.md#processinggetuploadjobreport) | **GET** /api/processing/reports/{reportId} | Get a single upload job processing report
[**ProcessingGetUploadJobReports**](ProcessingApi.md#processinggetuploadjobreports) | **GET** /api/processing/reports | Get upload job processing reports
[**ProcessingInsertUploadJobReport**](ProcessingApi.md#processinginsertuploadjobreport) | **POST** /api/processing/reports | Creates or replaces an upload job processing report
[**ProcessingUpdateUploadJob**](ProcessingApi.md#processingupdateuploadjob) | **POST** /api/processing/updateuploadjob | Update an upload job


<a name="processingdeleteuploadjobreports"></a>
# **ProcessingDeleteUploadJobReports**
> void ProcessingDeleteUploadJobReports (int? caseId = null, Guid? jobId = null)

Delete all upload job processing reports for a job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ProcessingDeleteUploadJobReportsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProcessingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var jobId = new Guid?(); // Guid? | Job Id GUID (optional) 

            try
            {
                // Delete all upload job processing reports for a job
                apiInstance.ProcessingDeleteUploadJobReports(caseId, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingApi.ProcessingDeleteUploadJobReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **jobId** | [**Guid?**](Guid?.md)| Job Id GUID | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinggetuploadjobreport"></a>
# **ProcessingGetUploadJobReport**
> UploadJobReportDetails ProcessingGetUploadJobReport (int? reportId, int? caseId = null)

Get a single upload job processing report

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ProcessingGetUploadJobReportExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProcessingApi();
            var reportId = 56;  // int? | Report ID
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get a single upload job processing report
                UploadJobReportDetails result = apiInstance.ProcessingGetUploadJobReport(reportId, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingApi.ProcessingGetUploadJobReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportId** | **int?**| Report ID | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

[**UploadJobReportDetails**](UploadJobReportDetails.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinggetuploadjobreports"></a>
# **ProcessingGetUploadJobReports**
> List<UploadJobReport> ProcessingGetUploadJobReports (int? caseId = null, Guid? jobId = null)

Get upload job processing reports

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ProcessingGetUploadJobReportsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProcessingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var jobId = new Guid?(); // Guid? | Job Id GUID (optional) 

            try
            {
                // Get upload job processing reports
                List&lt;UploadJobReport&gt; result = apiInstance.ProcessingGetUploadJobReports(caseId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingApi.ProcessingGetUploadJobReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **jobId** | [**Guid?**](Guid?.md)| Job Id GUID | [optional] 

### Return type

[**List<UploadJobReport>**](UploadJobReport.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinginsertuploadjobreport"></a>
# **ProcessingInsertUploadJobReport**
> UploadJobReportCreateUpdateResponse ProcessingInsertUploadJobReport (int? caseId = null, UploadJobReportDetails body = null)

Creates or replaces an upload job processing report

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ProcessingInsertUploadJobReportExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProcessingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var body = new UploadJobReportDetails(); // UploadJobReportDetails | UploadJobReport object (optional) 

            try
            {
                // Creates or replaces an upload job processing report
                UploadJobReportCreateUpdateResponse result = apiInstance.ProcessingInsertUploadJobReport(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingApi.ProcessingInsertUploadJobReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **body** | [**UploadJobReportDetails**](UploadJobReportDetails.md)| UploadJobReport object | [optional] 

### Return type

[**UploadJobReportCreateUpdateResponse**](UploadJobReportCreateUpdateResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processingupdateuploadjob"></a>
# **ProcessingUpdateUploadJob**
> void ProcessingUpdateUploadJob (int? caseId = null, UploadJobUpdate body = null)

Update an upload job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class ProcessingUpdateUploadJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProcessingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var body = new UploadJobUpdate(); // UploadJobUpdate | UploadJobUpdate (optional) 

            try
            {
                // Update an upload job
                apiInstance.ProcessingUpdateUploadJob(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessingApi.ProcessingUpdateUploadJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **body** | [**UploadJobUpdate**](UploadJobUpdate.md)| UploadJobUpdate | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

