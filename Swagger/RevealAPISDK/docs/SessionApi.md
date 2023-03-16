# IO.Swagger.Api.SessionApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionGetAuthSessionConfig**](SessionApi.md#sessiongetauthsessionconfig) | **GET** /api/v2/session/install/oidc | 
[**SessionGetSessionUser**](SessionApi.md#sessiongetsessionuser) | **GET** /api/v2/session/userInfo | Get user information for the current api user.


<a name="sessiongetauthsessionconfig"></a>
# **SessionGetAuthSessionConfig**
> OIDCKeycloakInstallation SessionGetAuthSessionConfig ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SessionGetAuthSessionConfigExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SessionApi();

            try
            {
                OIDCKeycloakInstallation result = apiInstance.SessionGetAuthSessionConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionGetAuthSessionConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OIDCKeycloakInstallation**](OIDCKeycloakInstallation.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessiongetsessionuser"></a>
# **SessionGetSessionUser**
> User SessionGetSessionUser (int? caseId = null)

Get user information for the current api user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SessionGetSessionUserExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new SessionApi();
            var caseId = 56;  // int? | Specify to get project specific info (optional)  (default to 0)

            try
            {
                // Get user information for the current api user.
                User result = apiInstance.SessionGetSessionUser(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionGetSessionUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Specify to get project specific info | [optional] [default to 0]

### Return type

[**User**](User.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

