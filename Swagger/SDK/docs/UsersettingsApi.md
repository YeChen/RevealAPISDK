# RevealAPI.Sdk.Api.Resources.UsersettingsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserSettingsFormData**](UsersettingsApi.md#usersettingsformdata) | **GET** /api/v2/{caseId}/user/{userId}/settings/formData | Get a User Settings Form Data
[**UserSettingsGetSetting**](UsersettingsApi.md#usersettingsgetsetting) | **GET** /api/v2/{caseId}/user/{userId}/settings/{id} | Get a user setting by id
[**UserSettingsGetSettings**](UsersettingsApi.md#usersettingsgetsettings) | **GET** /api/v2/{caseId}/user/{userId}/settings | Get all or specified user settings
[**UserSettingsSaveSettings**](UsersettingsApi.md#usersettingssavesettings) | **PUT** /api/v2/{caseId}/user/{userId}/settings | Save or update specified user settings


<a name="usersettingsformdata"></a>
# **UserSettingsFormData**
> UserSettingsForm UserSettingsFormData (int? caseId, int? userId)

Get a User Settings Form Data

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class UserSettingsFormDataExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersettingsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 

            try
            {
                // Get a User Settings Form Data
                UserSettingsForm result = apiInstance.UserSettingsFormData(caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UserSettingsFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | 

### Return type

[**UserSettingsForm**](UserSettingsForm.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetsetting"></a>
# **UserSettingsGetSetting**
> UserSetting UserSettingsGetSetting (int? caseId, int? userId, int? id)

Get a user setting by id

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class UserSettingsGetSettingExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersettingsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get a user setting by id
                UserSetting result = apiInstance.UserSettingsGetSetting(caseId, userId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UserSettingsGetSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**UserSetting**](UserSetting.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetsettings"></a>
# **UserSettingsGetSettings**
> PaginatedOfListOfUserSetting UserSettingsGetSettings (int? caseId, int? userId, List<UserSettings> userSettings = null, int? start = null, int? count = null)

Get all or specified user settings

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class UserSettingsGetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersettingsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 
            var userSettings = new List<UserSettings>(); // List<UserSettings> |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get all or specified user settings
                PaginatedOfListOfUserSetting result = apiInstance.UserSettingsGetSettings(caseId, userId, userSettings, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UserSettingsGetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | 
 **userSettings** | [**List&lt;UserSettings&gt;**](UserSettings.md)|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfUserSetting**](PaginatedOfListOfUserSetting.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssavesettings"></a>
# **UserSettingsSaveSettings**
> void UserSettingsSaveSettings (int? caseId, int? userId, List<UserSetting> body = null)

Save or update specified user settings

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class UserSettingsSaveSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersettingsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 
            var body = new List<UserSetting>(); // List<UserSetting> |  (optional) 

            try
            {
                // Save or update specified user settings
                apiInstance.UserSettingsSaveSettings(caseId, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UserSettingsSaveSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | 
 **body** | [**List&lt;UserSetting&gt;**](UserSetting.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

