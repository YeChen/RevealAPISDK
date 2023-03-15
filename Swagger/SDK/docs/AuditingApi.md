# RevealAPI.Sdk.Api.Resources.AuditingApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuditingPost**](AuditingApi.md#auditingpost) | **POST** /api/v2/{caseId}/auditing | Insert a new log


<a name="auditingpost"></a>
# **AuditingPost**
> void AuditingPost (int? caseId, Audit body = null)

Insert a new log

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class AuditingPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AuditingApi();
            var caseId = 56;  // int? | 
            var body = new Audit(); // Audit |  (optional) 

            try
            {
                // Insert a new log
                apiInstance.AuditingPost(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditingApi.AuditingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**Audit**](Audit.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

