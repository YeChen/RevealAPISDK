# RevealAPI.V1.Api.Resources.FieldMappingApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldMappingCreateNewFieldMapping**](FieldMappingApi.md#fieldmappingcreatenewfieldmapping) | **POST** /api/FieldMapping | Create a new field mapping
[**FieldMappingDeleteFieldMapping**](FieldMappingApi.md#fieldmappingdeletefieldmapping) | **DELETE** /api/FieldMapping/{id} | Delete a field mapping
[**FieldMappingGet**](FieldMappingApi.md#fieldmappingget) | **GET** /api/FieldMapping | Get a list of field mappings in a case
[**FieldMappingGetSingle**](FieldMappingApi.md#fieldmappinggetsingle) | **GET** /api/FieldMapping/{id} | Get a single field mapping in a case
[**FieldMappingModifyFieldMapping**](FieldMappingApi.md#fieldmappingmodifyfieldmapping) | **PUT** /api/FieldMapping | Update a field mapping


<a name="fieldmappingcreatenewfieldmapping"></a>
# **FieldMappingCreateNewFieldMapping**
> FieldMappingInfo FieldMappingCreateNewFieldMapping (int? caseId = null, FieldMappingInfo body = null)

Create a new field mapping

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldMappingCreateNewFieldMappingExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldMappingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var body = new FieldMappingInfo(); // FieldMappingInfo | FieldMappingInfo (optional) 

            try
            {
                // Create a new field mapping
                FieldMappingInfo result = apiInstance.FieldMappingCreateNewFieldMapping(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldMappingApi.FieldMappingCreateNewFieldMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **body** | [**FieldMappingInfo**](FieldMappingInfo.md)| FieldMappingInfo | [optional] 

### Return type

[**FieldMappingInfo**](FieldMappingInfo.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldmappingdeletefieldmapping"></a>
# **FieldMappingDeleteFieldMapping**
> void FieldMappingDeleteFieldMapping (int? id, int? caseId = null)

Delete a field mapping

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldMappingDeleteFieldMappingExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldMappingApi();
            var id = 56;  // int? | Field mapping Id to retrieve
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Delete a field mapping
                apiInstance.FieldMappingDeleteFieldMapping(id, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldMappingApi.FieldMappingDeleteFieldMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Field mapping Id to retrieve | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldmappingget"></a>
# **FieldMappingGet**
> List<FieldMapping> FieldMappingGet (int? caseId = null)

Get a list of field mappings in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldMappingGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldMappingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get a list of field mappings in a case
                List&lt;FieldMapping&gt; result = apiInstance.FieldMappingGet(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldMappingApi.FieldMappingGet: " + e.Message );
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

[**List<FieldMapping>**](FieldMapping.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldmappinggetsingle"></a>
# **FieldMappingGetSingle**
> FieldMappingInfo FieldMappingGetSingle (int? id, int? caseId = null)

Get a single field mapping in a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldMappingGetSingleExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldMappingApi();
            var id = 56;  // int? | Field mapping Id to retrieve
            var caseId = 56;  // int? | Reveal case Id (optional) 

            try
            {
                // Get a single field mapping in a case
                FieldMappingInfo result = apiInstance.FieldMappingGetSingle(id, caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldMappingApi.FieldMappingGetSingle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Field mapping Id to retrieve | 
 **caseId** | **int?**| Reveal case Id | [optional] 

### Return type

[**FieldMappingInfo**](FieldMappingInfo.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldmappingmodifyfieldmapping"></a>
# **FieldMappingModifyFieldMapping**
> FieldMappingInfo FieldMappingModifyFieldMapping (int? caseId = null, FieldMappingInfo body = null)

Update a field mapping

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldMappingModifyFieldMappingExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldMappingApi();
            var caseId = 56;  // int? | Reveal case Id (optional) 
            var body = new FieldMappingInfo(); // FieldMappingInfo | FieldMappingInfo (optional) 

            try
            {
                // Update a field mapping
                FieldMappingInfo result = apiInstance.FieldMappingModifyFieldMapping(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldMappingApi.FieldMappingModifyFieldMapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Reveal case Id | [optional] 
 **body** | [**FieldMappingInfo**](FieldMappingInfo.md)| FieldMappingInfo | [optional] 

### Return type

[**FieldMappingInfo**](FieldMappingInfo.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

