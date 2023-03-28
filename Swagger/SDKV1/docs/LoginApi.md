# RevealAPI.V1.Api.Resources.LoginApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginGet**](LoginApi.md#loginget) | **GET** /api/login | Login


<a name="loginget"></a>
# **LoginGet**
> Login LoginGet (string username = null, string password = null)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class LoginGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new LoginApi();
            var username = username_example;  // string |  (optional) 
            var password = password_example;  // string |  (optional) 

            try
            {
                // Login
                Login result = apiInstance.LoginGet(username, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.LoginGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**|  | [optional] 
 **password** | **string**|  | [optional] 

### Return type

[**Login**](Login.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

