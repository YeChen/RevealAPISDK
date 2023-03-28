# RevealAPI.V1.Api.Resources.DataLoadingApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataLoadingDelete**](DataLoadingApi.md#dataloadingdelete) | **DELETE** /api/dataLoading/{id} | Cancel a loading job
[**DataLoadingGet**](DataLoadingApi.md#dataloadingget) | **GET** /api/dataLoading | Gets a list of loading jobs
[**DataLoadingGetDocumentErrorFile**](DataLoadingApi.md#dataloadinggetdocumenterrorfile) | **GET** /api/dataLoading/{id}/errorfile | Get loading document error file
[**DataLoadingGetLogFile**](DataLoadingApi.md#dataloadinggetlogfile) | **GET** /api/dataLoading/logfile | Get loading log file.
[**DataLoadingGet_0**](DataLoadingApi.md#dataloadingget_0) | **GET** /api/dataLoading/{id} | Gets the status of a single loading job with errors
[**DataLoadingLoadData**](DataLoadingApi.md#dataloadingloaddata) | **POST** /api/dataLoading | Load documents into case from import file


<a name="dataloadingdelete"></a>
# **DataLoadingDelete**
> void DataLoadingDelete (int? id, int? caseId = null)

Cancel a loading job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var id = 56;  // int? | Loading job Id
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Cancel a loading job
                apiInstance.DataLoadingDelete(id, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Loading job Id | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataloadingget"></a>
# **DataLoadingGet**
> List<DataLoaderJob> DataLoadingGet (int? caseId = null, int? start = null, int? count = null)

Gets a list of loading jobs

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var start = 56;  // int? | Optional. Jobs to skip. Specify 0 to get first record (optional)  (default to 0)
            var count = 56;  // int? | Optional. Number of jobs to return (optional)  (default to 2147483647)

            try
            {
                // Gets a list of loading jobs
                List&lt;DataLoaderJob&gt; result = apiInstance.DataLoadingGet(caseId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **start** | **int?**| Optional. Jobs to skip. Specify 0 to get first record | [optional] [default to 0]
 **count** | **int?**| Optional. Number of jobs to return | [optional] [default to 2147483647]

### Return type

[**List<DataLoaderJob>**](DataLoaderJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataloadinggetdocumenterrorfile"></a>
# **DataLoadingGetDocumentErrorFile**
> string DataLoadingGetDocumentErrorFile (int? id, int? caseId = null)

Get loading document error file

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingGetDocumentErrorFileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var id = 56;  // int? | Loader job id. If 0, then error file for last loading job is returned
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get loading document error file
                string result = apiInstance.DataLoadingGetDocumentErrorFile(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingGetDocumentErrorFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Loader job id. If 0, then error file for last loading job is returned | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataloadinggetlogfile"></a>
# **DataLoadingGetLogFile**
> string DataLoadingGetLogFile (int? caseId = null, int? id = null)

Get loading log file.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingGetLogFileExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var id = 56;  // int? | if not specified, then log for last job is retrieved (optional)  (default to 0)

            try
            {
                // Get loading log file.
                string result = apiInstance.DataLoadingGetLogFile(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingGetLogFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **id** | **int?**| if not specified, then log for last job is retrieved | [optional] [default to 0]

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataloadingget_0"></a>
# **DataLoadingGet_0**
> DataLoaderJob DataLoadingGet_0 (int? id, int? caseId = null)

Gets the status of a single loading job with errors

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingGet_0Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var id = 56;  // int? | Loading job Id
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Gets the status of a single loading job with errors
                DataLoaderJob result = apiInstance.DataLoadingGet_0(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Loading job Id | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

[**DataLoaderJob**](DataLoaderJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataloadingloaddata"></a>
# **DataLoadingLoadData**
> DataLoaderJob DataLoadingLoadData (int? caseId = null, string loadfile = null, int? fieldMappingId = null)

Load documents into case from import file

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DataLoadingLoadDataExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DataLoadingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var loadfile = loadfile_example;  // string | Load file name (fully qualified path) (optional) 
            var fieldMappingId = 56;  // int? | Optional. Field mapping Id or 0 to use first mapping found in case (optional)  (default to 0)

            try
            {
                // Load documents into case from import file
                DataLoaderJob result = apiInstance.DataLoadingLoadData(caseId, loadfile, fieldMappingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataLoadingApi.DataLoadingLoadData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **loadfile** | **string**| Load file name (fully qualified path) | [optional] 
 **fieldMappingId** | **int?**| Optional. Field mapping Id or 0 to use first mapping found in case | [optional] [default to 0]

### Return type

[**DataLoaderJob**](DataLoaderJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

