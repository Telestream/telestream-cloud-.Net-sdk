# Telestream.Cloud.Notifications.Api.NotificationsApi

All URIs are relative to *https://api.cloud.telestream.net/notifications/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](NotificationsApi.md#createsubscription) | **POST** /subscriptions | Create a new subscription
[**DeleteSubscription**](NotificationsApi.md#deletesubscription) | **DELETE** /subscriptions/{id} | 
[**GetSubscription**](NotificationsApi.md#getsubscription) | **GET** /subscriptions/{id} | 
[**ListSubscriptions**](NotificationsApi.md#listsubscriptions) | **GET** /subscriptions | 
[**ModifySubscription**](NotificationsApi.md#modifysubscription) | **PUT** /subscriptions/{id} | Modify subscription


<a name="createsubscription"></a>
# **CreateSubscription**
> Subscription CreateSubscription (Subscription subscription = null)

Create a new subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Notifications.Api;
using Telestream.Cloud.Notifications.Client;
using Telestream.Cloud.Notifications.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var subscription = new Subscription(); // Subscription |  (optional) 

            try
            {
                // Create a new subscription
                Subscription result = apiInstance.CreateSubscription(subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscription** | [**Subscription**](Subscription.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Notifications.Api;
using Telestream.Cloud.Notifications.Client;
using Telestream.Cloud.Notifications.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Notifications.Api;
using Telestream.Cloud.Notifications.Client;
using Telestream.Cloud.Notifications.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | 

            try
            {
                Subscription result = apiInstance.GetSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubscriptions"></a>
# **ListSubscriptions**
> List<Subscription> ListSubscriptions (string serviceType = null, string type = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Notifications.Api;
using Telestream.Cloud.Notifications.Client;
using Telestream.Cloud.Notifications.Model;

namespace Example
{
    public class ListSubscriptionsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var serviceType = serviceType_example;  // string | Service type (qc, tts, flip) (optional) 
            var type = type_example;  // string | Subscription type (email, webhook, sns, aeg, pubsub) (optional) 

            try
            {
                List&lt;Subscription&gt; result = apiInstance.ListSubscriptions(serviceType, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceType** | **string**| Service type (qc, tts, flip) | [optional] 
 **type** | **string**| Subscription type (email, webhook, sns, aeg, pubsub) | [optional] 

### Return type

[**List<Subscription>**](Subscription.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifysubscription"></a>
# **ModifySubscription**
> Subscription ModifySubscription (string id, UpdateData updateData = null)

Modify subscription

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Notifications.Api;
using Telestream.Cloud.Notifications.Client;
using Telestream.Cloud.Notifications.Model;

namespace Example
{
    public class ModifySubscriptionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var id = id_example;  // string | 
            var updateData = new UpdateData(); // UpdateData |  (optional) 

            try
            {
                // Modify subscription
                Subscription result = apiInstance.ModifySubscription(id, updateData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.ModifySubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **updateData** | [**UpdateData**](UpdateData.md)|  | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

