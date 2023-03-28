# RevealAPI.V1.Api.Resources.TeamApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamCreate**](TeamApi.md#teamcreate) | **POST** /api/team/create | 
[**TeamDelete**](TeamApi.md#teamdelete) | **DELETE** /api/team/delete | 
[**TeamGet**](TeamApi.md#teamget) | **GET** /api/team | 


<a name="teamcreate"></a>
# **TeamCreate**
> void TeamCreate (int? caseId = null, int? userId = null, TeamCreate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TeamCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var body = new TeamCreate(); // TeamCreate |  (optional) 

            try
            {
                apiInstance.TeamCreate(caseId, userId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **body** | [**TeamCreate**](TeamCreate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamdelete"></a>
# **TeamDelete**
> void TeamDelete (int? caseId = null, int? userId = null, int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TeamDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamApi();
            var caseId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var id = 56;  // int? |  (optional) 

            try
            {
                apiInstance.TeamDelete(caseId, userId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **id** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamget"></a>
# **TeamGet**
> void TeamGet (int? caseId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.V1.Api.Resources;
using RevealAPI.V1.Client;
using RevealAPI.V1.Models.Resources;

namespace Example
{
    public class TeamGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamApi();
            var caseId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.TeamGet(caseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.TeamGet: " + e.Message );
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

