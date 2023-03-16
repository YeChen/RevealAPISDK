# IO.Swagger.Api.JobshitReportApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HitReportCreate**](JobshitReportApi.md#hitreportcreate) | **POST** /api/v2/{caseId}/jobs/hitreport | Create a hit report job
[**HitReportDelete**](JobshitReportApi.md#hitreportdelete) | **DELETE** /api/v2/{caseId}/jobs/hitreport/{id} | Delete a hit report job
[**HitReportGet**](JobshitReportApi.md#hitreportget) | **GET** /api/v2/{caseId}/jobs/hitreport/{id} | Get a hit report job given job id
[**HitReportGetAll**](JobshitReportApi.md#hitreportgetall) | **GET** /api/v2/{caseId}/jobs/hitreport | Get all hit report job


<a name="hitreportcreate"></a>
# **HitReportCreate**
> HitReportJob HitReportCreate (int? caseId, HitReportJob body = null)

Create a hit report job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HitReportCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobshitReportApi();
            var caseId = 56;  // int? | 
            var body = new HitReportJob(); // HitReportJob |  (optional) 

            try
            {
                // Create a hit report job
                HitReportJob result = apiInstance.HitReportCreate(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobshitReportApi.HitReportCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**HitReportJob**](HitReportJob.md)|  | [optional] 

### Return type

[**HitReportJob**](HitReportJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hitreportdelete"></a>
# **HitReportDelete**
> void HitReportDelete (int? caseId, int? id)

Delete a hit report job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HitReportDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobshitReportApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Delete a hit report job
                apiInstance.HitReportDelete(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobshitReportApi.HitReportDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hitreportget"></a>
# **HitReportGet**
> HitReportJob HitReportGet (int? caseId, int? id)

Get a hit report job given job id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HitReportGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobshitReportApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a hit report job given job id
                HitReportJob result = apiInstance.HitReportGet(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobshitReportApi.HitReportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**HitReportJob**](HitReportJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hitreportgetall"></a>
# **HitReportGetAll**
> PaginatedOfIEnumerableOfHitReportJob HitReportGetAll (int? caseId, int? start = null, int? count = null)

Get all hit report job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HitReportGetAllExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new JobshitReportApi();
            var caseId = 56;  // int? | 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get all hit report job
                PaginatedOfIEnumerableOfHitReportJob result = apiInstance.HitReportGetAll(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobshitReportApi.HitReportGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfHitReportJob**](PaginatedOfIEnumerableOfHitReportJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

