# RevealAPI.V1.Api.Resources.DocumentTextSetApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTextSetCreateTextSet**](DocumentTextSetApi.md#documenttextsetcreatetextset) | **POST** /api/DocumentTextSets | Create a new Document Text Set
[**DocumentTextSetDeleteTextSet**](DocumentTextSetApi.md#documenttextsetdeletetextset) | **DELETE** /api/DocumentTextSets/{id} | Delete a Document Text Set
[**DocumentTextSetGetAllTextSets**](DocumentTextSetApi.md#documenttextsetgetalltextsets) | **GET** /api/DocumentTextSets | Get all Document Text Sets in a case
[**DocumentTextSetGetSingleTextSet**](DocumentTextSetApi.md#documenttextsetgetsingletextset) | **GET** /api/DocumentTextSets/{id} | Get a single Document Text Set in a case
[**DocumentTextSetUpdateTextSet**](DocumentTextSetApi.md#documenttextsetupdatetextset) | **PUT** /api/DocumentTextSets | Update an existing Document Text Set


<a name="documenttextsetcreatetextset"></a>
# **DocumentTextSetCreateTextSet**
> void DocumentTextSetCreateTextSet (int? caseId = null, DocumentTextSet body = null)

Create a new Document Text Set

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentTextSetCreateTextSetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentTextSetApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new DocumentTextSet(); // DocumentTextSet |  (optional) 

            try
            {
                // Create a new Document Text Set
                apiInstance.DocumentTextSetCreateTextSet(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTextSetApi.DocumentTextSetCreateTextSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**DocumentTextSet**](DocumentTextSet.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttextsetdeletetextset"></a>
# **DocumentTextSetDeleteTextSet**
> void DocumentTextSetDeleteTextSet (int? id, int? caseId = null)

Delete a Document Text Set

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentTextSetDeleteTextSetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentTextSetApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Delete a Document Text Set
                apiInstance.DocumentTextSetDeleteTextSet(id, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTextSetApi.DocumentTextSetDeleteTextSet: " + e.Message );
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

<a name="documenttextsetgetalltextsets"></a>
# **DocumentTextSetGetAllTextSets**
> List<DocumentTextSet> DocumentTextSetGetAllTextSets (int? caseId = null)

Get all Document Text Sets in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentTextSetGetAllTextSetsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentTextSetApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get all Document Text Sets in a case
                List&lt;DocumentTextSet&gt; result = apiInstance.DocumentTextSetGetAllTextSets(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTextSetApi.DocumentTextSetGetAllTextSets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 

### Return type

[**List<DocumentTextSet>**](DocumentTextSet.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttextsetgetsingletextset"></a>
# **DocumentTextSetGetSingleTextSet**
> void DocumentTextSetGetSingleTextSet (int? id, int? caseId = null)

Get a single Document Text Set in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentTextSetGetSingleTextSetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentTextSetApi();
            var id = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get a single Document Text Set in a case
                apiInstance.DocumentTextSetGetSingleTextSet(id, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTextSetApi.DocumentTextSetGetSingleTextSet: " + e.Message );
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

<a name="documenttextsetupdatetextset"></a>
# **DocumentTextSetUpdateTextSet**
> void DocumentTextSetUpdateTextSet (int? caseId = null, DocumentTextSet body = null)

Update an existing Document Text Set

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class DocumentTextSetUpdateTextSetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new DocumentTextSetApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new DocumentTextSet(); // DocumentTextSet |  (optional) 

            try
            {
                // Update an existing Document Text Set
                apiInstance.DocumentTextSetUpdateTextSet(caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTextSetApi.DocumentTextSetUpdateTextSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**DocumentTextSet**](DocumentTextSet.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

