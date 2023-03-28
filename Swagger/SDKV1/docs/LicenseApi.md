# RevealAPI.V1.Api.Resources.LicenseApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicenseGet**](LicenseApi.md#licenseget) | **GET** /api/license | Get license information  URL: GET api/license
[**LicensePost**](LicenseApi.md#licensepost) | **POST** /api/license | Update license   URL: PUT api/license


<a name="licenseget"></a>
# **LicenseGet**
> void LicenseGet ()

Get license information  URL: GET api/license

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class LicenseGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new LicenseApi();

            try
            {
                // Get license information  URL: GET api/license
                apiInstance.LicenseGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="licensepost"></a>
# **LicensePost**
> void LicensePost (LicenseUpdate body = null)

Update license   URL: PUT api/license

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class LicensePostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new LicenseApi();
            var body = new LicenseUpdate(); // LicenseUpdate |  (optional) 

            try
            {
                // Update license   URL: PUT api/license
                apiInstance.LicensePost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicensePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LicenseUpdate**](LicenseUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

