# IO.Swagger.Api.DocsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentV2GetDateHistogramResults**](DocsApi.md#documentv2getdatehistogramresults) | **POST** /api/v2/{caseId}/docs/date-histogram | Get a list of date histograms
[**DocumentV2GetDocumentCountsForField**](DocsApi.md#documentv2getdocumentcountsforfield) | **POST** /api/v2/{caseId}/docs/countsbyfield | Get the count of documents for the specified field
[**DocumentV2GetDocumentCountsForField2**](DocsApi.md#documentv2getdocumentcountsforfield2) | **POST** /api/v2/{caseId}/docs/countsbyfield2 | Get the count of documents for the specified fields
[**DocumentV2QueryDocs**](DocsApi.md#documentv2querydocs) | **POST** /api/v2/{caseId}/docs/query2 | Get documents


<a name="documentv2getdatehistogramresults"></a>
# **DocumentV2GetDateHistogramResults**
> List<DateHistogramSearchResult> DocumentV2GetDateHistogramResults (int? caseId, DateHistogramSearchCriteria body = null)

Get a list of date histograms

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentV2GetDateHistogramResultsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocsApi();
            var caseId = 56;  // int? | Project ID
            var body = new DateHistogramSearchCriteria(); // DateHistogramSearchCriteria |  (optional) 

            try
            {
                // Get a list of date histograms
                List&lt;DateHistogramSearchResult&gt; result = apiInstance.DocumentV2GetDateHistogramResults(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocsApi.DocumentV2GetDateHistogramResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Project ID | 
 **body** | [**DateHistogramSearchCriteria**](DateHistogramSearchCriteria.md)|  | [optional] 

### Return type

[**List<DateHistogramSearchResult>**](DateHistogramSearchResult.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentv2getdocumentcountsforfield"></a>
# **DocumentV2GetDocumentCountsForField**
> DocumentFieldCountResponse DocumentV2GetDocumentCountsForField (int? caseId, string fieldName = null, int? returnCountsGreaterThan = null, bool? sortByValue = null, bool? sortAscending = null, DocumentQuery body = null)

Get the count of documents for the specified field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentV2GetDocumentCountsForFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocsApi();
            var caseId = 56;  // int? | Project ID
            var fieldName = fieldName_example;  // string | Database field name, for example FILE_EXTENSION (optional) 
            var returnCountsGreaterThan = 56;  // int? | Optional. Only return counts greater than this value (optional)  (default to 0)
            var sortByValue = true;  // bool? | If true, the returned items will be sorted by the value instead of the count (optional)  (default to false)
            var sortAscending = true;  // bool? | True for ascending sort, false for descending (optional)  (default to false)
            var body = new DocumentQuery(); // DocumentQuery | Start is zero based page index. Count is records per page (optional) 

            try
            {
                // Get the count of documents for the specified field
                DocumentFieldCountResponse result = apiInstance.DocumentV2GetDocumentCountsForField(caseId, fieldName, returnCountsGreaterThan, sortByValue, sortAscending, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocsApi.DocumentV2GetDocumentCountsForField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Project ID | 
 **fieldName** | **string**| Database field name, for example FILE_EXTENSION | [optional] 
 **returnCountsGreaterThan** | **int?**| Optional. Only return counts greater than this value | [optional] [default to 0]
 **sortByValue** | **bool?**| If true, the returned items will be sorted by the value instead of the count | [optional] [default to false]
 **sortAscending** | **bool?**| True for ascending sort, false for descending | [optional] [default to false]
 **body** | [**DocumentQuery**](DocumentQuery.md)| Start is zero based page index. Count is records per page | [optional] 

### Return type

[**DocumentFieldCountResponse**](DocumentFieldCountResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentv2getdocumentcountsforfield2"></a>
# **DocumentV2GetDocumentCountsForField2**
> List<DocumentFieldCountResponse> DocumentV2GetDocumentCountsForField2 (int? caseId, DocumentFieldCountQuery body = null)

Get the count of documents for the specified fields

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentV2GetDocumentCountsForField2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocsApi();
            var caseId = 56;  // int? | Project ID
            var body = new DocumentFieldCountQuery(); // DocumentFieldCountQuery | Start is zero based page index. Count is records per page (optional) 

            try
            {
                // Get the count of documents for the specified fields
                List&lt;DocumentFieldCountResponse&gt; result = apiInstance.DocumentV2GetDocumentCountsForField2(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocsApi.DocumentV2GetDocumentCountsForField2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Project ID | 
 **body** | [**DocumentFieldCountQuery**](DocumentFieldCountQuery.md)| Start is zero based page index. Count is records per page | [optional] 

### Return type

[**List<DocumentFieldCountResponse>**](DocumentFieldCountResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentv2querydocs"></a>
# **DocumentV2QueryDocs**
> DocumentQueryResults2 DocumentV2QueryDocs (int? caseId, DocumentQuery body = null)

Get documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DocumentV2QueryDocsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocsApi();
            var caseId = 56;  // int? | Project ID
            var body = new DocumentQuery(); // DocumentQuery | Start is the zero based first record to return. Count is the number of records (optional) 

            try
            {
                // Get documents
                DocumentQueryResults2 result = apiInstance.DocumentV2QueryDocs(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocsApi.DocumentV2QueryDocs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Project ID | 
 **body** | [**DocumentQuery**](DocumentQuery.md)| Start is the zero based first record to return. Count is the number of records | [optional] 

### Return type

[**DocumentQueryResults2**](DocumentQueryResults2.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

