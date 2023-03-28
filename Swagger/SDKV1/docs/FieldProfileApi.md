# RevealAPI.V1.Api.Resources.FieldProfileApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldProfileAssociateWithFields**](FieldProfileApi.md#fieldprofileassociatewithfields) | **PUT** /api/fieldProfile/{profileId} | Associate fields and corresponding sort orders to a field profile
[**FieldProfileAssociateWithFields2**](FieldProfileApi.md#fieldprofileassociatewithfields2) | **PUT** /api/fieldProfile/fields/add | Adds fields to a field profile
[**FieldProfileDelete**](FieldProfileApi.md#fieldprofiledelete) | **DELETE** /api/fieldProfile/{profileId} | Delete an existing field profile
[**FieldProfileGet**](FieldProfileApi.md#fieldprofileget) | **GET** /api/fieldProfile | Get a list of all field profiles for a case
[**FieldProfilePost**](FieldProfileApi.md#fieldprofilepost) | **POST** /api/fieldProfile | Create a new field profile
[**FieldProfilePut**](FieldProfileApi.md#fieldprofileput) | **PUT** /api/fieldProfile | Update an existing field profile
[**FieldProfileUnAssociateWithFields**](FieldProfileApi.md#fieldprofileunassociatewithfields) | **PUT** /api/fieldProfile/fields/delete | Removes fields from a field profile


<a name="fieldprofileassociatewithfields"></a>
# **FieldProfileAssociateWithFields**
> void FieldProfileAssociateWithFields (int? profileId, int? caseId = null, List<FieldIdVisibleAssociation> body = null)

Associate fields and corresponding sort orders to a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfileAssociateWithFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var profileId = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 
            var body = new List<FieldIdVisibleAssociation>(); // List<FieldIdVisibleAssociation> |  (optional) 

            try
            {
                // Associate fields and corresponding sort orders to a field profile
                apiInstance.FieldProfileAssociateWithFields(profileId, caseId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfileAssociateWithFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 
 **body** | [**List&lt;FieldIdVisibleAssociation&gt;**](FieldIdVisibleAssociation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofileassociatewithfields2"></a>
# **FieldProfileAssociateWithFields2**
> void FieldProfileAssociateWithFields2 (int? caseId = null, int? profileId = null, List<FieldIdVisibleAssociation> body = null)

Adds fields to a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfileAssociateWithFields2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var profileId = 56;  // int? |  (optional) 
            var body = new List<FieldIdVisibleAssociation>(); // List<FieldIdVisibleAssociation> |  (optional) 

            try
            {
                // Adds fields to a field profile
                apiInstance.FieldProfileAssociateWithFields2(caseId, profileId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfileAssociateWithFields2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **profileId** | **int?**|  | [optional] 
 **body** | [**List&lt;FieldIdVisibleAssociation&gt;**](FieldIdVisibleAssociation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofiledelete"></a>
# **FieldProfileDelete**
> void FieldProfileDelete (int? profileId, int? caseId = null)

Delete an existing field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfileDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var profileId = 56;  // int? | 
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Delete an existing field profile
                apiInstance.FieldProfileDelete(profileId, caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfileDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profileId** | **int?**|  | 
 **caseId** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofileget"></a>
# **FieldProfileGet**
> void FieldProfileGet (int? caseId = null)

Get a list of all field profiles for a case

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfileGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                // Get a list of all field profiles for a case
                apiInstance.FieldProfileGet(caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfileGet: " + e.Message );
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

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofilepost"></a>
# **FieldProfilePost**
> FieldProfileCreate FieldProfilePost (int? caseId = null, FieldProfileCreate body = null)

Create a new field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfilePostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new FieldProfileCreate(); // FieldProfileCreate |  (optional) 

            try
            {
                // Create a new field profile
                FieldProfileCreate result = apiInstance.FieldProfilePost(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**FieldProfileCreate**](FieldProfileCreate.md)|  | [optional] 

### Return type

[**FieldProfileCreate**](FieldProfileCreate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofileput"></a>
# **FieldProfilePut**
> FieldProfileUpdate FieldProfilePut (int? caseId = null, FieldProfileUpdate body = null)

Update an existing field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfilePutExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var body = new FieldProfileUpdate(); // FieldProfileUpdate |  (optional) 

            try
            {
                // Update an existing field profile
                FieldProfileUpdate result = apiInstance.FieldProfilePut(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfilePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **body** | [**FieldProfileUpdate**](FieldProfileUpdate.md)|  | [optional] 

### Return type

[**FieldProfileUpdate**](FieldProfileUpdate.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldprofileunassociatewithfields"></a>
# **FieldProfileUnAssociateWithFields**
> void FieldProfileUnAssociateWithFields (int? caseId = null, int? profileId = null, List<int?> body = null)

Removes fields from a field profile

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class FieldProfileUnAssociateWithFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new FieldProfileApi();
            var caseId = 56;  // int? |  (optional) 
            var profileId = 56;  // int? |  (optional) 
            var body = ;  // List<int?> |  (optional) 

            try
            {
                // Removes fields from a field profile
                apiInstance.FieldProfileUnAssociateWithFields(caseId, profileId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldProfileApi.FieldProfileUnAssociateWithFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **profileId** | **int?**|  | [optional] 
 **body** | **List&lt;int?&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

