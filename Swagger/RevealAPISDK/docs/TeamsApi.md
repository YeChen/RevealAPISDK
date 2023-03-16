# IO.Swagger.Api.TeamsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamV2DeleteById**](TeamsApi.md#teamv2deletebyid) | **DELETE** /api/v2/{caseId}/teams/{id} | delete a team using team id
[**TeamV2DeleteByName**](TeamsApi.md#teamv2deletebyname) | **DELETE** /api/v2/{caseId}/teams/deleteByName/{name} | delete a team using team name
[**TeamV2GetMembers**](TeamsApi.md#teamv2getmembers) | **GET** /api/v2/{caseId}/teams/{id}/members | Get team members
[**TeamV2GetTeamById**](TeamsApi.md#teamv2getteambyid) | **GET** /api/v2/{caseId}/teams/{id} | get a single team using team id without restricting to a user
[**TeamV2GetTeamByName**](TeamsApi.md#teamv2getteambyname) | **GET** /api/v2/{caseId}/teams/getByName/{name} | get a single team using team name without restricting to a user
[**TeamV2GetTeams**](TeamsApi.md#teamv2getteams) | **GET** /api/v2/{caseId}/teams | get all teams, filter by user
[**TeamV2Post**](TeamsApi.md#teamv2post) | **POST** /api/v2/{caseId}/teams | creates a team
[**TeamV2SetMembers**](TeamsApi.md#teamv2setmembers) | **PATCH** /api/v2/{caseId}/teams/{id}/members | Sets and removes members of a team


<a name="teamv2deletebyid"></a>
# **TeamV2DeleteById**
> void TeamV2DeleteById (int? caseId, int? id)

delete a team using team id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2DeleteByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // delete a team using team id
                apiInstance.TeamV2DeleteById(caseId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2DeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2deletebyname"></a>
# **TeamV2DeleteByName**
> void TeamV2DeleteByName (int? caseId, string name)

delete a team using team name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2DeleteByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 

            try
            {
                // delete a team using team name
                apiInstance.TeamV2DeleteByName(caseId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2DeleteByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2getmembers"></a>
# **TeamV2GetMembers**
> Team TeamV2GetMembers (int? caseId, int? id)

Get team members

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2GetMembersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // Get team members
                Team result = apiInstance.TeamV2GetMembers(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2GetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**Team**](Team.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2getteambyid"></a>
# **TeamV2GetTeamById**
> Team TeamV2GetTeamById (int? caseId, int? id)

get a single team using team id without restricting to a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2GetTeamByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var id = 56;  // int? | 

            try
            {
                // get a single team using team id without restricting to a user
                Team result = apiInstance.TeamV2GetTeamById(caseId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2GetTeamById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **int?**|  | 

### Return type

[**Team**](Team.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2getteambyname"></a>
# **TeamV2GetTeamByName**
> Team TeamV2GetTeamByName (int? caseId, string name, int? userId = null)

get a single team using team name without restricting to a user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2GetTeamByNameExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var name = name_example;  // string | 
            var userId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // get a single team using team name without restricting to a user
                Team result = apiInstance.TeamV2GetTeamByName(caseId, name, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2GetTeamByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **name** | **string**|  | 
 **userId** | **int?**|  | [optional] [default to 0]

### Return type

[**Team**](Team.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2getteams"></a>
# **TeamV2GetTeams**
> PaginatedOfListOfTeam TeamV2GetTeams (int? caseId, int? userId = null, int? start = null, int? count = null)

get all teams, filter by user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2GetTeamsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional)  (default to 0)
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // get all teams, filter by user
                PaginatedOfListOfTeam result = apiInstance.TeamV2GetTeams(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2GetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] [default to 0]
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfTeam**](PaginatedOfListOfTeam.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2post"></a>
# **TeamV2Post**
> Team TeamV2Post (int? caseId, TeamCreate body = null)

creates a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var body = new TeamCreate(); // TeamCreate |  (optional) 

            try
            {
                // creates a team
                Team result = apiInstance.TeamV2Post(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**TeamCreate**](TeamCreate.md)|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamv2setmembers"></a>
# **TeamV2SetMembers**
> void TeamV2SetMembers (int? caseId, string id, List<MemberStatus> body = null)

Sets and removes members of a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TeamV2SetMembersExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new TeamsApi();
            var caseId = 56;  // int? | 
            var id = id_example;  // string | 
            var body = new List<MemberStatus>(); // List<MemberStatus> | false: remove user, true: add user (optional) 

            try
            {
                // Sets and removes members of a team
                apiInstance.TeamV2SetMembers(caseId, id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamV2SetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **id** | **string**|  | 
 **body** | [**List&lt;MemberStatus&gt;**](MemberStatus.md)| false: remove user, true: add user | [optional] 

### Return type

void (empty response body)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

