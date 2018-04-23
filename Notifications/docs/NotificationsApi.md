# Telestream.Cloud.Notifications.Api.NotificationsApi

All URIs are relative to *https://api.cloud.telestream.net/notifications/v1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](NotificationsApi.md#createsubscription) | **POST** /subscriptions | Create a new subscription
[**DeleteSubscription**](NotificationsApi.md#deletesubscription) | **DELETE** /subscriptions/{id} | 
[**ListSubscriptions**](NotificationsApi.md#listsubscriptions) | **GET** /subscriptions | 


<a name="createsubscription"></a>
# **CreateSubscription**
> void CreateSubscription (Subscription subscription = null)

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
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var subscription = new Subscription(); // Subscription |  (optional) 

            try
            {
                // Create a new subscription
                apiInstance.CreateSubscription(subscription);
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

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

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
            // Configure API key authorization: apiKey
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

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubscriptions"></a>
# **ListSubscriptions**
> List<Subscription> ListSubscriptions ()



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
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new NotificationsApi();

            try
            {
                List&lt;Subscription&gt; result = apiInstance.ListSubscriptions();
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
This endpoint does not need any parameter.

### Return type

[**List<Subscription>**](Subscription.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

