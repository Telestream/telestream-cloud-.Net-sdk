# Telestream.Cloud.Stores.Api.StoresApi

All URIs are relative to *https://api.cloud.telestream.net/stores/v1.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStore**](StoresApi.md#createstore) | **POST** /stores | 
[**CreateStoreClientLink**](StoresApi.md#createstoreclientlink) | **POST** /stores/{store_id}/service/{service_name}/id/{service_id} | 
[**CreateWatchRule**](StoresApi.md#createwatchrule) | **POST** /watch_rules | 
[**DeleteStore**](StoresApi.md#deletestore) | **DELETE** /stores/{id} | 
[**DeleteStoreClientLink**](StoresApi.md#deletestoreclientlink) | **DELETE** /stores/{store_id}/service/{service_name}/id/{service_id} | 
[**DeleteWatchRule**](StoresApi.md#deletewatchrule) | **DELETE** /watch_rules/{id} | 
[**GetObjectUrl**](StoresApi.md#getobjecturl) | **GET** /stores/{id}/object_url | 
[**GetStore**](StoresApi.md#getstore) | **GET** /stores/{id} | 
[**GetStoreIdsForClient**](StoresApi.md#getstoreidsforclient) | **GET** /stores/service/{service_name}/id/{service_id} | 
[**GetStores**](StoresApi.md#getstores) | **GET** /stores | 
[**GetWatchRule**](StoresApi.md#getwatchrule) | **GET** /watch_rules/{id} | 
[**GetWatchRules**](StoresApi.md#getwatchrules) | **GET** /watch_rules | 
[**SyncWatchRule**](StoresApi.md#syncwatchrule) | **POST** /watch_rules/{id}/sync | 
[**UpdateStore**](StoresApi.md#updatestore) | **PATCH** /stores/{id} | 
[**UpdateWatchRule**](StoresApi.md#updatewatchrule) | **PATCH** /watch_rules/{id} | 
[**ValidateBucket**](StoresApi.md#validatebucket) | **POST** /validate_bucket | 


<a name="createstore"></a>
# **CreateStore**
> Store CreateStore (StoreBody storeBody)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class CreateStoreExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var storeBody = new StoreBody(); // StoreBody | 

            try
            {
                Store result = apiInstance.CreateStore(storeBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeBody** | [**StoreBody**](StoreBody.md)|  | 

### Return type

[**Store**](Store.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstoreclientlink"></a>
# **CreateStoreClientLink**
> void CreateStoreClientLink (string storeId, string serviceName, string serviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class CreateStoreClientLinkExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var storeId = storeId_example;  // string | an id of a store
            var serviceName = serviceName_example;  // string | a name of a client service
            var serviceId = serviceId_example;  // string | a service id of a resource that queries for its stores

            try
            {
                apiInstance.CreateStoreClientLink(storeId, serviceName, serviceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateStoreClientLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| an id of a store | 
 **serviceName** | **string**| a name of a client service | 
 **serviceId** | **string**| a service id of a resource that queries for its stores | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwatchrule"></a>
# **CreateWatchRule**
> WatchRule CreateWatchRule (WatchRule watchRuleBody)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class CreateWatchRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var watchRuleBody = new WatchRule(); // WatchRule | 

            try
            {
                WatchRule result = apiInstance.CreateWatchRule(watchRuleBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.CreateWatchRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watchRuleBody** | [**WatchRule**](WatchRule.md)|  | 

### Return type

[**WatchRule**](WatchRule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestore"></a>
# **DeleteStore**
> Store DeleteStore (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class DeleteStoreExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a store

            try
            {
                Store result = apiInstance.DeleteStore(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.DeleteStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a store | 

### Return type

[**Store**](Store.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestoreclientlink"></a>
# **DeleteStoreClientLink**
> void DeleteStoreClientLink (string storeId, string serviceName, string serviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class DeleteStoreClientLinkExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var storeId = storeId_example;  // string | an id of a store
            var serviceName = serviceName_example;  // string | a name of a client service
            var serviceId = serviceId_example;  // string | a service id of a resource that queries for its stores

            try
            {
                apiInstance.DeleteStoreClientLink(storeId, serviceName, serviceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.DeleteStoreClientLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| an id of a store | 
 **serviceName** | **string**| a name of a client service | 
 **serviceId** | **string**| a service id of a resource that queries for its stores | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewatchrule"></a>
# **DeleteWatchRule**
> WatchRule DeleteWatchRule (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class DeleteWatchRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a resource

            try
            {
                WatchRule result = apiInstance.DeleteWatchRule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.DeleteWatchRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a resource | 

### Return type

[**WatchRule**](WatchRule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getobjecturl"></a>
# **GetObjectUrl**
> ObjectURL GetObjectUrl (string id, string path, string expiresIn)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetObjectUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a store
            var path = path_example;  // string | an path to a file
            var expiresIn = expiresIn_example;  // string | expiration time in seconds

            try
            {
                ObjectURL result = apiInstance.GetObjectUrl(id, path, expiresIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetObjectUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a store | 
 **path** | **string**| an path to a file | 
 **expiresIn** | **string**| expiration time in seconds | 

### Return type

[**ObjectURL**](ObjectURL.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstore"></a>
# **GetStore**
> Store GetStore (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetStoreExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a store

            try
            {
                Store result = apiInstance.GetStore(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a store | 

### Return type

[**Store**](Store.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoreidsforclient"></a>
# **GetStoreIdsForClient**
> List<string> GetStoreIdsForClient (string serviceName, string serviceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetStoreIdsForClientExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var serviceName = serviceName_example;  // string | a name of a client service
            var serviceId = serviceId_example;  // string | a service id of a resource that queries for its stores

            try
            {
                List&lt;string&gt; result = apiInstance.GetStoreIdsForClient(serviceName, serviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStoreIdsForClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**| a name of a client service | 
 **serviceId** | **string**| a service id of a resource that queries for its stores | 

### Return type

**List<string>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> List<Store> GetStores (string bucketName = null, string provider = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetStoresExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var bucketName = bucketName_example;  // string | filter stores by bucket_name (optional) 
            var provider = provider_example;  // string | filter stores by storage provider (optional) 

            try
            {
                List&lt;Store&gt; result = apiInstance.GetStores(bucketName, provider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetStores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bucketName** | **string**| filter stores by bucket_name | [optional] 
 **provider** | **string**| filter stores by storage provider | [optional] 

### Return type

[**List<Store>**](Store.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatchrule"></a>
# **GetWatchRule**
> WatchRule GetWatchRule (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetWatchRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a watch rule

            try
            {
                WatchRule result = apiInstance.GetWatchRule(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetWatchRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a watch rule | 

### Return type

[**WatchRule**](WatchRule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatchrules"></a>
# **GetWatchRules**
> List<WatchRule> GetWatchRules (string serviceId = null, string storeId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class GetWatchRulesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var serviceId = serviceId_example;  // string | filter watch rules by service_id (optional) 
            var storeId = storeId_example;  // string | filter watch rules by store_id (optional) 

            try
            {
                List&lt;WatchRule&gt; result = apiInstance.GetWatchRules(serviceId, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.GetWatchRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceId** | **string**| filter watch rules by service_id | [optional] 
 **storeId** | **string**| filter watch rules by store_id | [optional] 

### Return type

[**List<WatchRule>**](WatchRule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncwatchrule"></a>
# **SyncWatchRule**
> void SyncWatchRule (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class SyncWatchRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a watch rule

            try
            {
                apiInstance.SyncWatchRule(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.SyncWatchRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a watch rule | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestore"></a>
# **UpdateStore**
> Store UpdateStore (string id, StoreBody storeBody)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class UpdateStoreExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a store
            var storeBody = new StoreBody(); // StoreBody | 

            try
            {
                Store result = apiInstance.UpdateStore(id, storeBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a store | 
 **storeBody** | [**StoreBody**](StoreBody.md)|  | 

### Return type

[**Store**](Store.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewatchrule"></a>
# **UpdateWatchRule**
> WatchRule UpdateWatchRule (string id, WatchRule watchRuleBody)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class UpdateWatchRuleExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var id = id_example;  // string | an id of a watch rule
            var watchRuleBody = new WatchRule(); // WatchRule | 

            try
            {
                WatchRule result = apiInstance.UpdateWatchRule(id, watchRuleBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.UpdateWatchRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| an id of a watch rule | 
 **watchRuleBody** | [**WatchRule**](WatchRule.md)|  | 

### Return type

[**WatchRule**](WatchRule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatebucket"></a>
# **ValidateBucket**
> ValidateBucketResponse ValidateBucket (ValidateBucketBody validateBucketBody)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Model;

namespace Example
{
    public class ValidateBucketExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new StoresApi();
            var validateBucketBody = new ValidateBucketBody(); // ValidateBucketBody | 

            try
            {
                ValidateBucketResponse result = apiInstance.ValidateBucket(validateBucketBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoresApi.ValidateBucket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **validateBucketBody** | [**ValidateBucketBody**](ValidateBucketBody.md)|  | 

### Return type

[**ValidateBucketResponse**](ValidateBucketResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

