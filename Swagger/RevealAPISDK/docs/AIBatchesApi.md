# IO.Swagger.Api.AIBatchesApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AIBatchesAssignQueue**](AIBatchesApi.md#aibatchesassignqueue) | **POST** /api/v2/{caseId}/aIBatches/queues/assign | Start a background job to create batch for a set of docs in one of the AI queues and assign to the provided user
[**AIBatchesGetModelStatistics**](AIBatchesApi.md#aibatchesgetmodelstatistics) | **GET** /api/v2/{caseId}/aIBatches/statistics | Get model statistics
[**AIBatchesGetModels**](AIBatchesApi.md#aibatchesgetmodels) | **GET** /api/v2/{caseId}/aIBatches/models | Get AI models
[**AIBatchesGetQueues**](AIBatchesApi.md#aibatchesgetqueues) | **GET** /api/v2/{caseId}/aIBatches/queues | Get Cosmic queues
[**AIBatchesGetTagProfiles**](AIBatchesApi.md#aibatchesgettagprofiles) | **GET** /api/v2/{caseId}/aIBatches/tagProfiles | Get tag profiles that contain the specified model


<a name="aibatchesassignqueue"></a>
# **AIBatchesAssignQueue**
> CreateJobResponse AIBatchesAssignQueue (int? caseId, AssignQueueRequest body = null)

Start a background job to create batch for a set of docs in one of the AI queues and assign to the provided user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AIBatchesAssignQueueExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AIBatchesApi();
            var caseId = 56;  // int? | 
            var body = new AssignQueueRequest(); // AssignQueueRequest |  (optional) 

            try
            {
                // Start a background job to create batch for a set of docs in one of the AI queues and assign to the provided user
                CreateJobResponse result = apiInstance.AIBatchesAssignQueue(caseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIBatchesApi.AIBatchesAssignQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **body** | [**AssignQueueRequest**](AssignQueueRequest.md)|  | [optional] 

### Return type

[**CreateJobResponse**](CreateJobResponse.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aibatchesgetmodelstatistics"></a>
# **AIBatchesGetModelStatistics**
> ModelStatistics AIBatchesGetModelStatistics (int? caseId, int? userId = null, int? modelId = null)

Get model statistics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AIBatchesGetModelStatisticsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AIBatchesApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var modelId = 56;  // int? |  (optional) 

            try
            {
                // Get model statistics
                ModelStatistics result = apiInstance.AIBatchesGetModelStatistics(caseId, userId, modelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIBatchesApi.AIBatchesGetModelStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 
 **modelId** | **int?**|  | [optional] 

### Return type

[**ModelStatistics**](ModelStatistics.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aibatchesgetmodels"></a>
# **AIBatchesGetModels**
> PaginatedOfListOfAIModel AIBatchesGetModels (int? caseId, int? userId = null, int? start = null, int? count = null)

Get AI models

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AIBatchesGetModelsExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AIBatchesApi();
            var caseId = 56;  // int? | 
            var userId = 56;  // int? |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get AI models
                PaginatedOfListOfAIModel result = apiInstance.AIBatchesGetModels(caseId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIBatchesApi.AIBatchesGetModels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **userId** | **int?**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfAIModel**](PaginatedOfListOfAIModel.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aibatchesgetqueues"></a>
# **AIBatchesGetQueues**
> List<CosmicQueue> AIBatchesGetQueues (int? caseId, int? modelId = null, int? userId = null)

Get Cosmic queues

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AIBatchesGetQueuesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AIBatchesApi();
            var caseId = 56;  // int? | 
            var modelId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 

            try
            {
                // Get Cosmic queues
                List&lt;CosmicQueue&gt; result = apiInstance.AIBatchesGetQueues(caseId, modelId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIBatchesApi.AIBatchesGetQueues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **modelId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 

### Return type

[**List<CosmicQueue>**](CosmicQueue.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aibatchesgettagprofiles"></a>
# **AIBatchesGetTagProfiles**
> PaginatedOfListOfTagProfile AIBatchesGetTagProfiles (int? caseId, int? modelId = null, int? userId = null, int? start = null, int? count = null)

Get tag profiles that contain the specified model

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AIBatchesGetTagProfilesExample
    {
        public void main()
        {
            // Configure API key authorization: api-token
            Configuration.Default.AddApiKey("InControlAuthToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("InControlAuthToken", "Bearer");

            var apiInstance = new AIBatchesApi();
            var caseId = 56;  // int? | 
            var modelId = 56;  // int? |  (optional) 
            var userId = 56;  // int? |  (optional) 
            var start = 56;  // int? |  (optional)  (default to 0)
            var count = 56;  // int? |  (optional)  (default to 2147483647)

            try
            {
                // Get tag profiles that contain the specified model
                PaginatedOfListOfTagProfile result = apiInstance.AIBatchesGetTagProfiles(caseId, modelId, userId, start, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AIBatchesApi.AIBatchesGetTagProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **caseId** | **int?**|  | 
 **modelId** | **int?**|  | [optional] 
 **userId** | **int?**|  | [optional] 
 **start** | **int?**|  | [optional] [default to 0]
 **count** | **int?**|  | [optional] [default to 2147483647]

### Return type

[**PaginatedOfListOfTagProfile**](PaginatedOfListOfTagProfile.md)

### Authorization

[api-token](../README.md#api-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

