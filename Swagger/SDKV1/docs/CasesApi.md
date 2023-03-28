# RevealAPI.V1.Api.Resources.CasesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CasesDelete**](CasesApi.md#casesdelete) | **DELETE** /api/cases | Delete a case (Not implemented)
[**CasesGet**](CasesApi.md#casesget) | **GET** /api/cases | Get all cases
[**CasesGetById**](CasesApi.md#casesgetbyid) | **GET** /api/cases/{caseId} | Get a single case
[**CasesGetCaseDatabaseTemplates**](CasesApi.md#casesgetcasedatabasetemplates) | **GET** /api/cases/DatabaseTemplates | Get a list of field templates used to create a case
[**CasesGetCaseStatistics**](CasesApi.md#casesgetcasestatistics) | **POST** /api/cases/Statistics | Get statistics for a case
[**CasesLookupLoginToken**](CasesApi.md#caseslookuplogintoken) | **GET** /api/cases/LookupLoginToken | Lookup a login token. This is used to get the current logged in user and case for a login token created in the review web interface
[**CasesPost**](CasesApi.md#casespost) | **POST** /api/cases | Create a new case
[**CasesPut**](CasesApi.md#casesput) | **PUT** /api/cases | Update an existing case
[**CasesSetBrainspaceDatasetId**](CasesApi.md#casessetbrainspacedatasetid) | **PUT** /api/cases/SetBrainspaceDatasetId | Set BrainspaceDatasetId for a case


<a name="casesdelete"></a>
# **CasesDelete**
> void CasesDelete (int? id = null)

Delete a case (Not implemented)

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                // Delete a case (Not implemented)
                apiInstance.CasesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casesget"></a>
# **CasesGet**
> List<Case> CasesGet ()

Get all cases

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();

            try
            {
                // Get all cases
                List&lt;Case&gt; result = apiInstance.CasesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Case>**](Case.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casesgetbyid"></a>
# **CasesGetById**
> Case CasesGetById (int? caseId)

Get a single case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var caseId = 56;  // int? | Reveal case Id

            try
            {
                // Get a single case
                Case result = apiInstance.CasesGetById(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | 

### Return type

[**Case**](Case.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casesgetcasedatabasetemplates"></a>
# **CasesGetCaseDatabaseTemplates**
> List<CaseDatabaseTemplate> CasesGetCaseDatabaseTemplates ()

Get a list of field templates used to create a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesGetCaseDatabaseTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();

            try
            {
                // Get a list of field templates used to create a case
                List&lt;CaseDatabaseTemplate&gt; result = apiInstance.CasesGetCaseDatabaseTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesGetCaseDatabaseTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CaseDatabaseTemplate>**](CaseDatabaseTemplate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casesgetcasestatistics"></a>
# **CasesGetCaseStatistics**
> List<CaseStatisticsResponse> CasesGetCaseStatistics (CaseStatisticsRequest body = null)

Get statistics for a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesGetCaseStatisticsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var body = new CaseStatisticsRequest(); // CaseStatisticsRequest | CaseStatisticsRequest object (optional) 

            try
            {
                // Get statistics for a case
                List&lt;CaseStatisticsResponse&gt; result = apiInstance.CasesGetCaseStatistics(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesGetCaseStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CaseStatisticsRequest**](CaseStatisticsRequest.md)| CaseStatisticsRequest object | [optional] 

### Return type

[**List<CaseStatisticsResponse>**](CaseStatisticsResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="caseslookuplogintoken"></a>
# **CasesLookupLoginToken**
> LookupTokenResponse CasesLookupLoginToken (string token = null)

Lookup a login token. This is used to get the current logged in user and case for a login token created in the review web interface

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesLookupLoginTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var token = token_example;  // string | Login Token (optional) 

            try
            {
                // Lookup a login token. This is used to get the current logged in user and case for a login token created in the review web interface
                LookupTokenResponse result = apiInstance.CasesLookupLoginToken(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesLookupLoginToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| Login Token | [optional] 

### Return type

[**LookupTokenResponse**](LookupTokenResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casespost"></a>
# **CasesPost**
> Case CasesPost (Case body = null)

Create a new case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var body = new Case(); // Case | Case object (optional) 

            try
            {
                // Create a new case
                Case result = apiInstance.CasesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Case**](Case.md)| Case object | [optional] 

### Return type

[**Case**](Case.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casesput"></a>
# **CasesPut**
> Case CasesPut (Case body = null)

Update an existing case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesPutExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var body = new Case(); // Case | Case object (optional) 

            try
            {
                // Update an existing case
                Case result = apiInstance.CasesPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Case**](Case.md)| Case object | [optional] 

### Return type

[**Case**](Case.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="casessetbrainspacedatasetid"></a>
# **CasesSetBrainspaceDatasetId**
> void CasesSetBrainspaceDatasetId (CaseBrainspaceDatasetUpdate body = null)

Set BrainspaceDatasetId for a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class CasesSetBrainspaceDatasetIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new CasesApi();
            var body = new CaseBrainspaceDatasetUpdate(); // CaseBrainspaceDatasetUpdate |  (optional) 

            try
            {
                // Set BrainspaceDatasetId for a case
                apiInstance.CasesSetBrainspaceDatasetId(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.CasesSetBrainspaceDatasetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CaseBrainspaceDatasetUpdate**](CaseBrainspaceDatasetUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

