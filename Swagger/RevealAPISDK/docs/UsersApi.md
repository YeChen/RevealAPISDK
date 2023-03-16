# IO.Swagger.Api.UsersApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersV2Enable**](UsersApi.md#usersv2enable) | **PUT** /api/v2/users/{id}/enable | Enable or disable a user
[**UsersV2GetAll**](UsersApi.md#usersv2getall) | **GET** /api/v2/users | Get all users
[**UsersV2GetAllPermissions**](UsersApi.md#usersv2getallpermissions) | **GET** /api/v2/{caseId}/permissions | Get all permissions for a project
[**UsersV2GetAllowedJobtypes**](UsersApi.md#usersv2getallowedjobtypes) | **GET** /api/v2/{caseId}/users/getAllowedJobTypes | Get allowed job types
[**UsersV2GetGroups**](UsersApi.md#usersv2getgroups) | **GET** /api/v2/{caseId}/users/{userId}/groups | Get the groups for a user in a case. A user is only allowed to be in one group in a case by design.
[**UsersV2GetPermissions**](UsersApi.md#usersv2getpermissions) | **GET** /api/v2/{caseId}/users/{userId}/permissions | Get the permissions for a user in a project.
[**UsersV2GetPermissionsV2**](UsersApi.md#usersv2getpermissionsv2) | **POST** /api/v2/permissions | Get the permissions for a user in projects.
[**UsersV2GetTeams**](UsersApi.md#usersv2getteams) | **GET** /api/v2/{caseId}/users/{userId}/teams | get teams for a particular user
[**UsersV2GetUser**](UsersApi.md#usersv2getuser) | **GET** /api/v2/users/{id} | Get information about a particular user
[**UsersV2GetUserByProject**](UsersApi.md#usersv2getuserbyproject) | **GET** /api/v2/{caseId}/users/{id} | Get information about a particular user with case specific info like groups
[**UsersV2GetUsersByProject**](UsersApi.md#usersv2getusersbyproject) | **GET** /api/v2/{caseId}/users | Get a list of all users assigned to a case
[**UsersV2GetUsersByProjectWithTeams**](UsersApi.md#usersv2getusersbyprojectwithteams) | **POST** /api/v2/{caseId}/users/teams | Get all users assigned to a case with a list of the teams they are on
[**UsersV2Post**](UsersApi.md#usersv2post) | **POST** /api/v2/users | Create a new user
[**UsersV2Put**](UsersApi.md#usersv2put) | **PUT** /api/v2/users | Update an existing user


<a name="usersv2enable"></a>
# **UsersV2Enable**
> void UsersV2Enable (int? id, bool? enable = null)

Enable or disable a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2EnableExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var id = 56;  // int? | 
            var enable = true;  // bool? |  (optional) 

            try
            {
                // Enable or disable a user
                apiInstance.UsersV2Enable(id, enable);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2Enable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **enable** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getall"></a>
# **UsersV2GetAll**
> PaginatedListOfUser UsersV2GetAll (int? start = null, int? count = null)

Get all users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetAllExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get all users
                PaginatedListOfUser result = apiInstance.UsersV2GetAll(start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedListOfUser**](PaginatedListOfUser.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getallpermissions"></a>
# **UsersV2GetAllPermissions**
> List<Permission> UsersV2GetAllPermissions (int? caseId)

Get all permissions for a project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetAllPermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | 

            try
            {
                // Get all permissions for a project
                List&lt;Permission&gt; result = apiInstance.UsersV2GetAllPermissions(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetAllPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

[**List<Permission>**](Permission.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getallowedjobtypes"></a>
# **UsersV2GetAllowedJobtypes**
> List<JobType> UsersV2GetAllowedJobtypes (int? caseId)

Get allowed job types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetAllowedJobtypesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | 

            try
            {
                // Get allowed job types
                List&lt;JobType&gt; result = apiInstance.UsersV2GetAllowedJobtypes(caseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetAllowedJobtypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 

### Return type

[**List<JobType>**](JobType.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getgroups"></a>
# **UsersV2GetGroups**
> List<Group> UsersV2GetGroups (int? caseId, int? userId, string filter = null)

Get the groups for a user in a case. A user is only allowed to be in one group in a case by design.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Get the groups for a user in a case. A user is only allowed to be in one group in a case by design.
                List&lt;Group&gt; result = apiInstance.UsersV2GetGroups(caseId, userId, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetGroups: " + e.Message );
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
 **filter** | **string**|  | [optional] 

### Return type

[**List<Group>**](Group.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getpermissions"></a>
# **UsersV2GetPermissions**
> List<Permission> UsersV2GetPermissions (int? caseId, int? userId)

Get the permissions for a user in a project.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetPermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 

            try
            {
                // Get the permissions for a user in a project.
                List&lt;Permission&gt; result = apiInstance.UsersV2GetPermissions(caseId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetPermissions: " + e.Message );
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

[**List<Permission>**](Permission.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getpermissionsv2"></a>
# **UsersV2GetPermissionsV2**
> List<ProjectPermissions> UsersV2GetPermissionsV2 (List<int?> body = null)

Get the permissions for a user in projects.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetPermissionsV2Example
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var body = ;  // List<int?> |  (optional) 

            try
            {
                // Get the permissions for a user in projects.
                List&lt;ProjectPermissions&gt; result = apiInstance.UsersV2GetPermissionsV2(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetPermissionsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;int?&gt;**|  | [optional] 

### Return type

[**List<ProjectPermissions>**](ProjectPermissions.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getteams"></a>
# **UsersV2GetTeams**
> List<Team> UsersV2GetTeams (int? caseId, int? userId, string filter = null)

get teams for a particular user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? | 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // get teams for a particular user
                List&lt;Team&gt; result = apiInstance.UsersV2GetTeams(caseId, userId, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetTeams: " + e.Message );
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
 **filter** | **string**|  | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getuser"></a>
# **UsersV2GetUser**
> User UsersV2GetUser (int? id)

Get information about a particular user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetUserExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var id = 56;  // int? | User Id

            try
            {
                // Get information about a particular user
                User result = apiInstance.UsersV2GetUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| User Id | 

### Return type

[**User**](User.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getuserbyproject"></a>
# **UsersV2GetUserByProject**
> User UsersV2GetUserByProject (int? caseId, int? id)

Get information about a particular user with case specific info like groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetUserByProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | Case Id
            var id = 56;  // int? | User Id

            try
            {
                // Get information about a particular user with case specific info like groups
                User result = apiInstance.UsersV2GetUserByProject(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetUserByProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Case Id | 
 **id** | **int?**| User Id | 

### Return type

[**User**](User.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getusersbyproject"></a>
# **UsersV2GetUsersByProject**
> PaginatedListOfUser UsersV2GetUsersByProject (int? caseId, int? start = null, int? count = null, string filter = null)

Get a list of all users assigned to a case

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetUsersByProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | Case Id
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Get a list of all users assigned to a case
                PaginatedListOfUser result = apiInstance.UsersV2GetUsersByProject(caseId, start, count, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetUsersByProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Case Id | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]
 **filter** | **string**|  | [optional] 

### Return type

[**PaginatedListOfUser**](PaginatedListOfUser.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2getusersbyprojectwithteams"></a>
# **UsersV2GetUsersByProjectWithTeams**
> PaginatedListOfUserWithTeams UsersV2GetUsersByProjectWithTeams (int? caseId, int? start = null, int? count = null, List<UserWithTeamQuery> body = null)

Get all users assigned to a case with a list of the teams they are on

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2GetUsersByProjectWithTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var caseId = 56;  // int? | Case Id
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)
            var body = new List<UserWithTeamQuery>(); // List<UserWithTeamQuery> |  (optional) 

            try
            {
                // Get all users assigned to a case with a list of the teams they are on
                PaginatedListOfUserWithTeams result = apiInstance.UsersV2GetUsersByProjectWithTeams(caseId, start, count, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2GetUsersByProjectWithTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**| Case Id | 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]
 **body** | [**List&lt;UserWithTeamQuery&gt;**](UserWithTeamQuery.md)|  | [optional] 

### Return type

[**PaginatedListOfUserWithTeams**](PaginatedListOfUserWithTeams.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2post"></a>
# **UsersV2Post**
> User UsersV2Post (User body = null)

Create a new user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var body = new User(); // User | User object (optional) 

            try
            {
                // Create a new user
                User result = apiInstance.UsersV2Post(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)| User object | [optional] 

### Return type

[**User**](User.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersv2put"></a>
# **UsersV2Put**
> User UsersV2Put (User body = null)

Update an existing user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersV2PutExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new UsersApi();
            var body = new User(); // User |  (optional) 

            try
            {
                // Update an existing user
                User result = apiInstance.UsersV2Put(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersV2Put: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

