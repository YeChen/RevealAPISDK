# RevealAPI.Sdk.Api.Resources.ProjectsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsV2Get**](ProjectsApi.md#projectsv2get) | **GET** /api/v2/projects | Get a list of projects, with optional filtering.
[**ProjectsV2GetById**](ProjectsApi.md#projectsv2getbyid) | **GET** /api/v2/projects/{id} | Get info for a single project
[**ProjectsV2GetStats**](ProjectsApi.md#projectsv2getstats) | **GET** /api/v2/projects/{id}/statistics | Get statistics for a project


<a name="projectsv2get"></a>
# **ProjectsV2Get**
> PaginatedOfIEnumerableOfProject ProjectsV2Get (int? userId = null, bool? filterByExact = null, string projectName = null, int? start = null, int? count = null)

Get a list of projects, with optional filtering.

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ProjectsV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProjectsApi();
            var userId = 56;  // int? | User to get cases for (optional)  (default to 0)
            var filterByExact = true;  // bool? | Whether a filter value must be equal to or contained. (optional)  (default to true)
            var projectName = projectName_example;  // string |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get a list of projects, with optional filtering.
                PaginatedOfIEnumerableOfProject result = apiInstance.ProjectsV2Get(userId, filterByExact, projectName, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsV2Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User to get cases for | [optional] [default to 0]
 **filterByExact** | **bool?**| Whether a filter value must be equal to or contained. | [optional] [default to true]
 **projectName** | **string**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfIEnumerableOfProject**](PaginatedOfIEnumerableOfProject.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsv2getbyid"></a>
# **ProjectsV2GetById**
> Project ProjectsV2GetById (int? id, int? userId = null)

Get info for a single project

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ProjectsV2GetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProjectsApi();
            var id = 56;  // int? | Project Id
            var userId = 56;  // int? | User to get project for (optional)  (default to 0)

            try
            {
                // Get info for a single project
                Project result = apiInstance.ProjectsV2GetById(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsV2GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Project Id | 
 **userId** | **int?**| User to get project for | [optional] [default to 0]

### Return type

[**Project**](Project.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsv2getstats"></a>
# **ProjectsV2GetStats**
> AdminStats ProjectsV2GetStats (int? id)

Get statistics for a project

### Example
```csharp
using System;
using System.Diagnostics;
using RevealAPI.Sdk.Api.Resources;
using RevealAPI.Sdk.Client;
using RevealAPI.Sdk.Models.Resources;

namespace Example
{
    public class ProjectsV2GetStatsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new ProjectsApi();
            var id = 56;  // int? | Project Id

            try
            {
                // Get statistics for a project
                AdminStats result = apiInstance.ProjectsV2GetStats(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsV2GetStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Project Id | 

### Return type

[**AdminStats**](AdminStats.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

