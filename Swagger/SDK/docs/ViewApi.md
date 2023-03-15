# RevealAPI.Sdk.Api.Resources.ViewApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewRouteGetJobsUrl**](ViewApi.md#viewroutegetjobsurl) | **POST** /api/v2/{caseId}/view/jobs | Returns the Team Documents URL
[**ViewRouteGetProjectAdminUrl**](ViewApi.md#viewroutegetprojectadminurl) | **POST** /api/v2/{caseId}/view/projectAdmin | Returns a Url
[**ViewRouteGetReportsUrl**](ViewApi.md#viewroutegetreportsurl) | **POST** /api/v2/{caseId}/view/reports | Returns the Reports Url
[**ViewRouteGetReviewDocumentViewerUrl**](ViewApi.md#viewroutegetreviewdocumentviewerurl) | **POST** /api/v2/{caseId}/view/document | Returns a Url
[**ViewRouteGetReviewDocumentViewerUrl2**](ViewApi.md#viewroutegetreviewdocumentviewerurl2) | **POST** /api/v2/{caseId}/view/document2 | Returns a Url
[**ViewRouteGetTeamDocumentsUrl**](ViewApi.md#viewroutegetteamdocumentsurl) | **POST** /api/v2/{caseId}/view/teamDocuments | Returns the Team Documents Url


<a name="viewroutegetjobsurl"></a>
# **ViewRouteGetJobsUrl**
> string ViewRouteGetJobsUrl (int? caseId)

Returns the Team Documents URL

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetJobsUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 

            try
            {
                // Returns the Team Documents URL
                string result = apiInstance.ViewRouteGetJobsUrl(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetJobsUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewroutegetprojectadminurl"></a>
# **ViewRouteGetProjectAdminUrl**
> string ViewRouteGetProjectAdminUrl (int? caseId)

Returns a Url

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetProjectAdminUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 

            try
            {
                // Returns a Url
                string result = apiInstance.ViewRouteGetProjectAdminUrl(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetProjectAdminUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewroutegetreportsurl"></a>
# **ViewRouteGetReportsUrl**
> string ViewRouteGetReportsUrl (int? caseId)

Returns the Reports Url

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetReportsUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 

            try
            {
                // Returns the Reports Url
                string result = apiInstance.ViewRouteGetReportsUrl(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetReportsUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewroutegetreviewdocumentviewerurl"></a>
# **ViewRouteGetReviewDocumentViewerUrl**
> string ViewRouteGetReviewDocumentViewerUrl (int? caseId, int? docIndex = null, int? gridPageIndex = null, int? assignmentFolderId = null, DocumentQuery body = null)

Returns a Url

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetReviewDocumentViewerUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 
            var docIndex = 56;  // int? | The 0 based index for the selected document from the documents list (optional)  (default to 0)
            var gridPageIndex = 56;  // int? | The 0 based index for the current grid page. Used to determine the current chunk (optional)  (default to 0)
            var assignmentFolderId = 56;  // int? | Required only when the document is retrieved from an assignment folder (optional)  (default to 0)
            var body = new DocumentQuery(); // DocumentQuery | The query used to retrieve the documents list (optional) 

            try
            {
                // Returns a Url
                string result = apiInstance.ViewRouteGetReviewDocumentViewerUrl(caseId, docIndex, gridPageIndex, assignmentFolderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetReviewDocumentViewerUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **docIndex** | **int?**| The 0 based index for the selected document from the documents list | [optional] [default to 0]
 **gridPageIndex** | **int?**| The 0 based index for the current grid page. Used to determine the current chunk | [optional] [default to 0]
 **assignmentFolderId** | **int?**| Required only when the document is retrieved from an assignment folder | [optional] [default to 0]
 **body** | [**DocumentQuery**](DocumentQuery.md)| The query used to retrieve the documents list | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewroutegetreviewdocumentviewerurl2"></a>
# **ViewRouteGetReviewDocumentViewerUrl2**
> string ViewRouteGetReviewDocumentViewerUrl2 (int? caseId, int? assignmentFolderId = null, DocumentViewerSearchCriteria body = null)

Returns a Url

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetReviewDocumentViewerUrl2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 
            var assignmentFolderId = 56;  // int? |  (optional)  (default to 0)
            var body = new DocumentViewerSearchCriteria(); // DocumentViewerSearchCriteria | The query used to retrieve the documents list (optional) 

            try
            {
                // Returns a Url
                string result = apiInstance.ViewRouteGetReviewDocumentViewerUrl2(caseId, assignmentFolderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetReviewDocumentViewerUrl2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **assignmentFolderId** | **int?**|  | [optional] [default to 0]
 **body** | [**DocumentViewerSearchCriteria**](DocumentViewerSearchCriteria.md)| The query used to retrieve the documents list | [optional] 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewroutegetteamdocumentsurl"></a>
# **ViewRouteGetTeamDocumentsUrl**
> string ViewRouteGetTeamDocumentsUrl (int? caseId)

Returns the Team Documents Url

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ViewRouteGetTeamDocumentsUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ViewApi();
            var caseId = 56;  // int? | 

            try
            {
                // Returns the Team Documents Url
                string result = apiInstance.ViewRouteGetTeamDocumentsUrl(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewApi.ViewRouteGetTeamDocumentsUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

**string**

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

