# RevealAPI.V1.Api.Resources.IndexingApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IndexingAddIndexJobDocuments**](IndexingApi.md#indexingaddindexjobdocuments) | **POST** /api/Indexing/{id}/Documents | Bulk adds documents to an index job. This is always additive.
[**IndexingCancelIndexJob**](IndexingApi.md#indexingcancelindexjob) | **DELETE** /api/Indexing/{id} | Cancel an index job. This does not delete the job from the database.
[**IndexingCreateIndexJob**](IndexingApi.md#indexingcreateindexjob) | **POST** /api/Indexing | Create a new index job
[**IndexingGetIndexJobDocumentIds**](IndexingApi.md#indexinggetindexjobdocumentids) | **GET** /api/Indexing/DocumentIds/{id} | Get document ids for an indexing job
[**IndexingGetIndexes**](IndexingApi.md#indexinggetindexes) | **GET** /api/Indexing/Indexes | Get a list of indexes in a case
[**IndexingGetIndexingErrors**](IndexingApi.md#indexinggetindexingerrors) | **GET** /api/Indexing/Errors/{id} | Get indexing errors
[**IndexingGetIndexingJobs**](IndexingApi.md#indexinggetindexingjobs) | **GET** /api/Indexing | Get a list of indexing jobs in a case
[**IndexingGetSingleIndexJob**](IndexingApi.md#indexinggetsingleindexjob) | **GET** /api/Indexing/{id} | Get a single Index Job in a case


<a name="indexingaddindexjobdocuments"></a>
# **IndexingAddIndexJobDocuments**
> void IndexingAddIndexJobDocuments (int? id, int? caseId = null, IndexJobDocuments body = null)

Bulk adds documents to an index job. This is always additive.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingAddIndexJobDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 
            var body = new IndexJobDocuments(); // IndexJobDocuments |  (optional) 

            try
            {
                // Bulk adds documents to an index job. This is always additive.
                apiInstance.IndexingAddIndexJobDocuments(id, caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingAddIndexJobDocuments: " + e.Message );
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
 **body** | [**IndexJobDocuments**](IndexJobDocuments.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexingcancelindexjob"></a>
# **IndexingCancelIndexJob**
> void IndexingCancelIndexJob (int? id, int? caseId = null)

Cancel an index job. This does not delete the job from the database.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingCancelIndexJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Cancel an index job. This does not delete the job from the database.
                apiInstance.IndexingCancelIndexJob(id, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingCancelIndexJob: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexingcreateindexjob"></a>
# **IndexingCreateIndexJob**
> IndexJob IndexingCreateIndexJob (int? caseId = null, IndexJobCreate body = null)

Create a new index job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingCreateIndexJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new IndexJobCreate(); // IndexJobCreate |  (optional) 

            try
            {
                // Create a new index job
                IndexJob result = apiInstance.IndexingCreateIndexJob(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingCreateIndexJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**IndexJobCreate**](IndexJobCreate.md)|  | [optional] 

### Return type

[**IndexJob**](IndexJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexinggetindexjobdocumentids"></a>
# **IndexingGetIndexJobDocumentIds**
> List<string> IndexingGetIndexJobDocumentIds (int? id, int? caseId = null, string keyField = null, int? startRow = null, int? batchSize = null)

Get document ids for an indexing job

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingGetIndexJobDocumentIdsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var id = 56;  // int? | Indexing job Id
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var keyField = keyField_example;  // string | ITEMID or BEGDOC (optional) 
            var startRow = 56;  // int? | Starting row offset. Use 0 for first request (optional) 
            var batchSize = 56;  // int? | Chunksize of records to return (optional) 

            try
            {
                // Get document ids for an indexing job
                List&lt;string&gt; result = apiInstance.IndexingGetIndexJobDocumentIds(id, caseId, keyField, startRow, batchSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingGetIndexJobDocumentIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Indexing job Id | 
 **caseId** | **int?**| Reveal case Id | [optional] 
 **keyField** | **string**| ITEMID or BEGDOC | [optional] 
 **startRow** | **int?**| Starting row offset. Use 0 for first request | [optional] 
 **batchSize** | **int?**| Chunksize of records to return | [optional] 

### Return type

**List<string>**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexinggetindexes"></a>
# **IndexingGetIndexes**
> List<IndexInfo> IndexingGetIndexes (int? caseId = null)

Get a list of indexes in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingGetIndexesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get a list of indexes in a case
                List&lt;IndexInfo&gt; result = apiInstance.IndexingGetIndexes(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingGetIndexes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

[**List<IndexInfo>**](IndexInfo.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexinggetindexingerrors"></a>
# **IndexingGetIndexingErrors**
> List<IndexingError> IndexingGetIndexingErrors (int? id, int? caseId = null)

Get indexing errors

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingGetIndexingErrorsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var id = 56;  // int? | Indexing job Id
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get indexing errors
                List&lt;IndexingError&gt; result = apiInstance.IndexingGetIndexingErrors(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingGetIndexingErrors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Indexing job Id | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

[**List<IndexingError>**](IndexingError.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexinggetindexingjobs"></a>
# **IndexingGetIndexingJobs**
> List<IndexJob> IndexingGetIndexingJobs (int? caseId = null, int? status = null)

Get a list of indexing jobs in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingGetIndexingJobsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var status = 56;  // int? | -1-Any, 0-Created, 1-Submitted, 2-In Process, 3-Complete, 4-Error, 5-Cancelled, 6-Cancel Pending, 7-Deleted, 8-Modified (optional) 

            try
            {
                // Get a list of indexing jobs in a case
                List&lt;IndexJob&gt; result = apiInstance.IndexingGetIndexingJobs(caseId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingGetIndexingJobs: " + e.Message );
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

[**List<IndexJob>**](IndexJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexinggetsingleindexjob"></a>
# **IndexingGetSingleIndexJob**
> IndexJob IndexingGetSingleIndexJob (int? id, int? caseId = null)

Get a single Index Job in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class IndexingGetSingleIndexJobExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new IndexingApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get a single Index Job in a case
                IndexJob result = apiInstance.IndexingGetSingleIndexJob(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexingApi.IndexingGetSingleIndexJob: " + e.Message );
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

[**IndexJob**](IndexJob.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

