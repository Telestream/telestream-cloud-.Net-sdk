# Telestream.Cloud.Flip.Api.FlipApi

All URIs are relative to *https://api.cloud.telestream.net/flip/3.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelEncoding**](FlipApi.md#cancelencoding) | **POST** /encodings/{id}/cancel.json | Cancels an Encoding.
[**CopyProfile**](FlipApi.md#copyprofile) | **POST** /profiles/{id}/copy.json | Copies a given Profile
[**CreateEncoding**](FlipApi.md#createencoding) | **POST** /encodings.json | Creates an Encoding
[**CreateFactory**](FlipApi.md#createfactory) | **POST** /factories.json | Creates a new factory
[**CreateProfile**](FlipApi.md#createprofile) | **POST** /profiles.json | Creates a Profile
[**CreateVideo**](FlipApi.md#createvideo) | **POST** /videos.json | Creates a Video from a provided source_url.
[**CreateWorkorder**](FlipApi.md#createworkorder) | **POST** /workorders.json | Creates a Workorder.
[**DeleteEncoding**](FlipApi.md#deleteencoding) | **DELETE** /encodings/{id}.json | Deletes an Encoding from both Telestream Cloud and your storage. Returns an information whether the operation was successful.
[**DeleteProfile**](FlipApi.md#deleteprofile) | **DELETE** /profiles/{id}.json | Deletes a given Profile
[**DeleteVideo**](FlipApi.md#deletevideo) | **DELETE** /videos/{id}.json | Deletes a Video object.
[**DeleteVideoSource**](FlipApi.md#deletevideosource) | **DELETE** /videos/{id}/source.json | Delete a video&#39;s source file.
[**Encoding**](FlipApi.md#encoding) | **GET** /encodings/{id}.json | Returns an Encoding object.
[**Encodings**](FlipApi.md#encodings) | **GET** /encodings.json | Returns a list of Encoding objects
[**EncodingsCount**](FlipApi.md#encodingscount) | **GET** /encodings/count.json | Returns a number of Encoding objects created using a given factory.
[**Factories**](FlipApi.md#factories) | **GET** /factories.json | Returns a collection of Factory objects.
[**Factory**](FlipApi.md#factory) | **GET** /factories/{id}.json | Returns a Factory object.
[**Notifications**](FlipApi.md#notifications) | **GET** /notifications.json | Returns a Factory&#39;s notification settings.
[**Profile**](FlipApi.md#profile) | **GET** /profiles/{id_or_name}.json | Returns a Profile object.
[**ProfileEncodings**](FlipApi.md#profileencodings) | **GET** /profiles/{id_or_name}/encodings.json | Returns a list of Encodings that belong to a Profile.
[**Profiles**](FlipApi.md#profiles) | **GET** /profiles.json | Returns a collection of Profile objects.
[**QueuedVideos**](FlipApi.md#queuedvideos) | **GET** /videos/queued.json | Returns a collection of Video objects queued for encoding.
[**ResubmitVideo**](FlipApi.md#resubmitvideo) | **POST** /videos/resubmit.json | Resubmits a video to encode.
[**RetryEncoding**](FlipApi.md#retryencoding) | **POST** /encodings/{id}/retry.json | Retries a failed encoding.
[**SignedEncodingUrl**](FlipApi.md#signedencodingurl) | **GET** /encodings/{id}/signed-url.json | Returns a signed url pointing to an Encoding.
[**SignedEncodingUrls**](FlipApi.md#signedencodingurls) | **GET** /encodings/{id}/signed-urls.json | Returns a list of signed urls pointing to an Encoding&#39;s outputs.
[**SignedVideoUrl**](FlipApi.md#signedvideourl) | **GET** /videos/{id}/signed-url.json | Returns a signed url pointing to a Video.
[**ToggleFactorySync**](FlipApi.md#togglefactorysync) | **POST** /factories/{id}/sync.json | Toggles synchronisation settings.
[**UpdateEncoding**](FlipApi.md#updateencoding) | **PUT** /encodings/{id}.json | Updates an Encoding
[**UpdateFactory**](FlipApi.md#updatefactory) | **PATCH** /factories/{id}.json | Updates a Factory&#39;s settings. Returns a Factory object.
[**UpdateNotifications**](FlipApi.md#updatenotifications) | **PUT** /notifications.json | Updates a Factory&#39;s notification settings.
[**UpdateProfile**](FlipApi.md#updateprofile) | **PUT** /profiles/{id}.json | Updates a given Profile
[**UploadVideo**](FlipApi.md#uploadvideo) | **POST** /videos/upload.json | Creates an upload session.
[**Video**](FlipApi.md#video) | **GET** /videos/{id}.json | Returns a Video object.
[**VideoEncodings**](FlipApi.md#videoencodings) | **GET** /videos/{id}/encodings.json | Returns a list of Encodings that belong to a Video.
[**VideoMetadata**](FlipApi.md#videometadata) | **GET** /videos/{id}/metadata.json | Returns a Video&#39;s metadata
[**Videos**](FlipApi.md#videos) | **GET** /videos.json | Returns a collection of Video objects.
[**Workflows**](FlipApi.md#workflows) | **GET** /workflows.json | Returns a collection of Workflows that belong to a Factory.


<a name="cancelencoding"></a>
# **CancelEncoding**
> CanceledResponse CancelEncoding (string id, string factoryId)

Cancels an Encoding.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CancelEncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Cancels an Encoding.
                CanceledResponse result = apiInstance.CancelEncoding(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CancelEncoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**CanceledResponse**](CanceledResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyprofile"></a>
# **CopyProfile**
> Profile CopyProfile (string id, string factoryId, CopyProfileBody copyProfileBody, bool? expand = null)

Copies a given Profile

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CopyProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Profile.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var copyProfileBody = new CopyProfileBody(); // CopyProfileBody | 
            var expand = true;  // bool? | If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. (optional) 

            try
            {
                // Copies a given Profile
                Profile result = apiInstance.CopyProfile(id, factoryId, copyProfileBody, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CopyProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Profile. | 
 **factoryId** | **string**| Id of a Factory. | 
 **copyProfileBody** | [**CopyProfileBody**](CopyProfileBody.md)|  | 
 **expand** | **bool?**| If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. | [optional] 

### Return type

[**Profile**](Profile.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createencoding"></a>
# **CreateEncoding**
> Encoding CreateEncoding (string factoryId, CreateEncodingBody createEncodingBody, bool? screenshots = null, bool? preciseStatus = null)

Creates an Encoding

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CreateEncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var createEncodingBody = new CreateEncodingBody(); // CreateEncodingBody | 
            var screenshots = true;  // bool? | Determines whether the response will include screenshots. By default this is not set. (optional) 
            var preciseStatus = true;  // bool? | Determines whether the response will include a precise status. By default this is not set. (optional) 

            try
            {
                // Creates an Encoding
                Encoding result = apiInstance.CreateEncoding(factoryId, createEncodingBody, screenshots, preciseStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CreateEncoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **createEncodingBody** | [**CreateEncodingBody**](CreateEncodingBody.md)|  | 
 **screenshots** | **bool?**| Determines whether the response will include screenshots. By default this is not set. | [optional] 
 **preciseStatus** | **bool?**| Determines whether the response will include a precise status. By default this is not set. | [optional] 

### Return type

[**Encoding**](Encoding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfactory"></a>
# **CreateFactory**
> Factory CreateFactory (FactoryBody createFactoryBody, bool? withStorageProvider = null)

Creates a new factory

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CreateFactoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var createFactoryBody = new FactoryBody(); // FactoryBody | 
            var withStorageProvider = true;  // bool? | if set to `true`, results will include a storage provider's id (optional) 

            try
            {
                // Creates a new factory
                Factory result = apiInstance.CreateFactory(createFactoryBody, withStorageProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CreateFactory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFactoryBody** | [**FactoryBody**](FactoryBody.md)|  | 
 **withStorageProvider** | **bool?**| if set to &#x60;true&#x60;, results will include a storage provider&#39;s id | [optional] 

### Return type

[**Factory**](Factory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprofile"></a>
# **CreateProfile**
> Profile CreateProfile (string factoryId, ProfileBody createProfileBody, bool? excludeAdvancedServices = null, bool? expand = null)

Creates a Profile

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CreateProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var createProfileBody = new ProfileBody(); // ProfileBody | 
            var excludeAdvancedServices = true;  // bool? |  (optional) 
            var expand = true;  // bool? | If expand option is set Profile objects will contain all command parameters, even if their value is default. By default it is not set. (optional) 

            try
            {
                // Creates a Profile
                Profile result = apiInstance.CreateProfile(factoryId, createProfileBody, excludeAdvancedServices, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CreateProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **createProfileBody** | [**ProfileBody**](ProfileBody.md)|  | 
 **excludeAdvancedServices** | **bool?**|  | [optional] 
 **expand** | **bool?**| If expand option is set Profile objects will contain all command parameters, even if their value is default. By default it is not set. | [optional] 

### Return type

[**Profile**](Profile.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvideo"></a>
# **CreateVideo**
> Video CreateVideo (string factoryId, CreateVideoBody createVideoBody)

Creates a Video from a provided source_url.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CreateVideoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var createVideoBody = new CreateVideoBody(); // CreateVideoBody | 

            try
            {
                // Creates a Video from a provided source_url.
                Video result = apiInstance.CreateVideo(factoryId, createVideoBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CreateVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **createVideoBody** | [**CreateVideoBody**](CreateVideoBody.md)|  | 

### Return type

[**Video**](Video.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createworkorder"></a>
# **CreateWorkorder**
> void CreateWorkorder (string factoryId, string profileId = null, System.IO.Stream file = null, string sourceUrl = null)

Creates a Workorder.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class CreateWorkorderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var profileId = profileId_example;  // string | Id of a Profile. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | Input file. (optional) 
            var sourceUrl = sourceUrl_example;  // string | URL pointing to an input file. (optional) 

            try
            {
                // Creates a Workorder.
                apiInstance.CreateWorkorder(factoryId, profileId, file, sourceUrl);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.CreateWorkorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **profileId** | **string**| Id of a Profile. | [optional] 
 **file** | **System.IO.Stream**| Input file. | [optional] 
 **sourceUrl** | **string**| URL pointing to an input file. | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteencoding"></a>
# **DeleteEncoding**
> DeletedResponse DeleteEncoding (string id, string factoryId)

Deletes an Encoding from both Telestream Cloud and your storage. Returns an information whether the operation was successful.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class DeleteEncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Deletes an Encoding from both Telestream Cloud and your storage. Returns an information whether the operation was successful.
                DeletedResponse result = apiInstance.DeleteEncoding(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.DeleteEncoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**DeletedResponse**](DeletedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprofile"></a>
# **DeleteProfile**
> DeletedResponse DeleteProfile (string id, string factoryId)

Deletes a given Profile

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class DeleteProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Profile
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Deletes a given Profile
                DeletedResponse result = apiInstance.DeleteProfile(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.DeleteProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Profile | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**DeletedResponse**](DeletedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideo"></a>
# **DeleteVideo**
> DeletedResponse DeleteVideo (string id, string factoryId)

Deletes a Video object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class DeleteVideoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Deletes a Video object.
                DeletedResponse result = apiInstance.DeleteVideo(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.DeleteVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**DeletedResponse**](DeletedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideosource"></a>
# **DeleteVideoSource**
> DeletedResponse DeleteVideoSource (string id, string factoryId)

Delete a video's source file.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class DeleteVideoSourceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Delete a video's source file.
                DeletedResponse result = apiInstance.DeleteVideoSource(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.DeleteVideoSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**DeletedResponse**](DeletedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encoding"></a>
# **Encoding**
> Encoding Encoding (string id, string factoryId, bool? screenshots = null, bool? preciseStatus = null)

Returns an Encoding object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class EncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var screenshots = true;  // bool? | Determines whether the response will include screenshots. By default this is not set. (optional) 
            var preciseStatus = true;  // bool? | Determines whether the response will include a precise status. By default this is not set. (optional) 

            try
            {
                // Returns an Encoding object.
                Encoding result = apiInstance.Encoding(id, factoryId, screenshots, preciseStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Encoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 
 **screenshots** | **bool?**| Determines whether the response will include screenshots. By default this is not set. | [optional] 
 **preciseStatus** | **bool?**| Determines whether the response will include a precise status. By default this is not set. | [optional] 

### Return type

[**Encoding**](Encoding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encodings"></a>
# **Encodings**
> PaginatedEncodingsCollection Encodings (string factoryId, string videoId = null, string status = null, string profileId = null, string profileName = null, int? page = null, int? perPage = null, bool? screenshots = null, bool? preciseStatus = null)

Returns a list of Encoding objects

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class EncodingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var videoId = videoId_example;  // string | Id of a Video. When specified, the resulting list will contain videos that belong to the Video. (optional) 
            var status = status_example;  // string | One of `success`, `fail`, `processing`. When specified, the resulting list will contain ecodings filtered by status. (optional) 
            var profileId = profileId_example;  // string | Filter by profile_id. (optional) 
            var profileName = profileName_example;  // string | Filter by profile_name. (optional) 
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 
            var screenshots = true;  // bool? | Determines whether the response will include screenshots. By default this is not set. (optional) 
            var preciseStatus = true;  // bool? | Determines whether the response will include a precise status. By default this is not set. (optional) 

            try
            {
                // Returns a list of Encoding objects
                PaginatedEncodingsCollection result = apiInstance.Encodings(factoryId, videoId, status, profileId, profileName, page, perPage, screenshots, preciseStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Encodings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **videoId** | **string**| Id of a Video. When specified, the resulting list will contain videos that belong to the Video. | [optional] 
 **status** | **string**| One of &#x60;success&#x60;, &#x60;fail&#x60;, &#x60;processing&#x60;. When specified, the resulting list will contain ecodings filtered by status. | [optional] 
 **profileId** | **string**| Filter by profile_id. | [optional] 
 **profileName** | **string**| Filter by profile_name. | [optional] 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 
 **screenshots** | **bool?**| Determines whether the response will include screenshots. By default this is not set. | [optional] 
 **preciseStatus** | **bool?**| Determines whether the response will include a precise status. By default this is not set. | [optional] 

### Return type

[**PaginatedEncodingsCollection**](PaginatedEncodingsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encodingscount"></a>
# **EncodingsCount**
> CountResponse EncodingsCount (string factoryId)

Returns a number of Encoding objects created using a given factory.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class EncodingsCountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a number of Encoding objects created using a given factory.
                CountResponse result = apiInstance.EncodingsCount(factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.EncodingsCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**CountResponse**](CountResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="factories"></a>
# **Factories**
> PaginatedFactoryCollection Factories (int? page = null, int? perPage = null, bool? withStorageProvider = null)

Returns a collection of Factory objects.

Returns a collection of Factory objects.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class FactoriesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 
            var withStorageProvider = true;  // bool? | if set to `true`, results will include a storage provider's id (optional) 

            try
            {
                // Returns a collection of Factory objects.
                PaginatedFactoryCollection result = apiInstance.Factories(page, perPage, withStorageProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Factories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 
 **withStorageProvider** | **bool?**| if set to &#x60;true&#x60;, results will include a storage provider&#39;s id | [optional] 

### Return type

[**PaginatedFactoryCollection**](PaginatedFactoryCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="factory"></a>
# **Factory**
> Factory Factory (string id, bool? withStorageProvider = null)

Returns a Factory object.

Returns a Factory object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class FactoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | id of a factory
            var withStorageProvider = true;  // bool? | if set to `true`, results will include a storage provider's id (optional) 

            try
            {
                // Returns a Factory object.
                Factory result = apiInstance.Factory(id, withStorageProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Factory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id of a factory | 
 **withStorageProvider** | **bool?**| if set to &#x60;true&#x60;, results will include a storage provider&#39;s id | [optional] 

### Return type

[**Factory**](Factory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notifications"></a>
# **Notifications**
> CloudNotificationSettings Notifications (string factoryId)

Returns a Factory's notification settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class NotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a Factory's notification settings.
                CloudNotificationSettings result = apiInstance.Notifications(factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Notifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**CloudNotificationSettings**](CloudNotificationSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profile"></a>
# **Profile**
> Profile Profile (string idOrName, string factoryId, bool? expand = null)

Returns a Profile object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class ProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var idOrName = idOrName_example;  // string | A name or an id of a Profile.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var expand = true;  // bool? | If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. (optional) 

            try
            {
                // Returns a Profile object.
                Profile result = apiInstance.Profile(idOrName, factoryId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Profile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idOrName** | **string**| A name or an id of a Profile. | 
 **factoryId** | **string**| Id of a Factory. | 
 **expand** | **bool?**| If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. | [optional] 

### Return type

[**Profile**](Profile.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profileencodings"></a>
# **ProfileEncodings**
> PaginatedEncodingsCollection ProfileEncodings (string idOrName, string factoryId)

Returns a list of Encodings that belong to a Profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class ProfileEncodingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var idOrName = idOrName_example;  // string | Id or name of a Profile.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a list of Encodings that belong to a Profile.
                PaginatedEncodingsCollection result = apiInstance.ProfileEncodings(idOrName, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.ProfileEncodings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idOrName** | **string**| Id or name of a Profile. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**PaginatedEncodingsCollection**](PaginatedEncodingsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profiles"></a>
# **Profiles**
> PaginatedProfilesCollection Profiles (string factoryId, bool? excludeAdvancedServices = null, bool? expand = null, int? page = null, int? perPage = null)

Returns a collection of Profile objects.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class ProfilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var excludeAdvancedServices = true;  // bool? | Determine whether exclude Advanced Services profiles from the results. By default this is not set. (optional) 
            var expand = true;  // bool? | If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. (optional) 
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 

            try
            {
                // Returns a collection of Profile objects.
                PaginatedProfilesCollection result = apiInstance.Profiles(factoryId, excludeAdvancedServices, expand, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Profiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **excludeAdvancedServices** | **bool?**| Determine whether exclude Advanced Services profiles from the results. By default this is not set. | [optional] 
 **expand** | **bool?**| If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. | [optional] 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 

### Return type

[**PaginatedProfilesCollection**](PaginatedProfilesCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuedvideos"></a>
# **QueuedVideos**
> PaginatedVideoCollection QueuedVideos (string factoryId, int? page = null, int? perPage = null)

Returns a collection of Video objects queued for encoding.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class QueuedVideosExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 

            try
            {
                // Returns a collection of Video objects queued for encoding.
                PaginatedVideoCollection result = apiInstance.QueuedVideos(factoryId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.QueuedVideos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 

### Return type

[**PaginatedVideoCollection**](PaginatedVideoCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resubmitvideo"></a>
# **ResubmitVideo**
> void ResubmitVideo (string factoryId, ResubmitVideoBody resubmitVideoBody)

Resubmits a video to encode.

Resubmits the video to encode. Please note that this option will work only for videos in `success` status.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class ResubmitVideoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var resubmitVideoBody = new ResubmitVideoBody(); // ResubmitVideoBody | 

            try
            {
                // Resubmits a video to encode.
                apiInstance.ResubmitVideo(factoryId, resubmitVideoBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.ResubmitVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **resubmitVideoBody** | [**ResubmitVideoBody**](ResubmitVideoBody.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retryencoding"></a>
# **RetryEncoding**
> RetriedResponse RetryEncoding (string id, string factoryId)

Retries a failed encoding.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class RetryEncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Retries a failed encoding.
                RetriedResponse result = apiInstance.RetryEncoding(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.RetryEncoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**RetriedResponse**](RetriedResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signedencodingurl"></a>
# **SignedEncodingUrl**
> EncodingSignedUrl SignedEncodingUrl (string id, string factoryId, int? expires = null)

Returns a signed url pointing to an Encoding.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class SignedEncodingUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var expires = 56;  // int? | Duration in seconds for validity period. (optional) 

            try
            {
                // Returns a signed url pointing to an Encoding.
                EncodingSignedUrl result = apiInstance.SignedEncodingUrl(id, factoryId, expires);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.SignedEncodingUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 
 **expires** | **int?**| Duration in seconds for validity period. | [optional] 

### Return type

[**EncodingSignedUrl**](EncodingSignedUrl.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signedencodingurls"></a>
# **SignedEncodingUrls**
> EncodingSignedUrls SignedEncodingUrls (string id, string factoryId)

Returns a list of signed urls pointing to an Encoding's outputs.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class SignedEncodingUrlsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a list of signed urls pointing to an Encoding's outputs.
                EncodingSignedUrls result = apiInstance.SignedEncodingUrls(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.SignedEncodingUrls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**EncodingSignedUrls**](EncodingSignedUrls.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signedvideourl"></a>
# **SignedVideoUrl**
> SignedVideoUrl SignedVideoUrl (string id, string factoryId)

Returns a signed url pointing to a Video.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class SignedVideoUrlExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a signed url pointing to a Video.
                SignedVideoUrl result = apiInstance.SignedVideoUrl(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.SignedVideoUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**SignedVideoUrl**](SignedVideoUrl.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="togglefactorysync"></a>
# **ToggleFactorySync**
> FactorySync ToggleFactorySync (string id, FactorySyncBody factorySyncBody)

Toggles synchronisation settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class ToggleFactorySyncExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | id of the factory
            var factorySyncBody = new FactorySyncBody(); // FactorySyncBody | 

            try
            {
                // Toggles synchronisation settings.
                FactorySync result = apiInstance.ToggleFactorySync(id, factorySyncBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.ToggleFactorySync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id of the factory | 
 **factorySyncBody** | [**FactorySyncBody**](FactorySyncBody.md)|  | 

### Return type

[**FactorySync**](FactorySync.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateencoding"></a>
# **UpdateEncoding**
> Encoding UpdateEncoding (string id, string factoryId, UpdateEncodingBody updateEncodingBody, bool? screenshots = null, bool? preciseStatus = null)

Updates an Encoding

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class UpdateEncodingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of an Encoding.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var updateEncodingBody = new UpdateEncodingBody(); // UpdateEncodingBody | 
            var screenshots = true;  // bool? | Determines whether the response will include screenshots. By default this is not set. (optional) 
            var preciseStatus = true;  // bool? | Determines whether the response will include a precise status. By default this is not set. (optional) 

            try
            {
                // Updates an Encoding
                Encoding result = apiInstance.UpdateEncoding(id, factoryId, updateEncodingBody, screenshots, preciseStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.UpdateEncoding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of an Encoding. | 
 **factoryId** | **string**| Id of a Factory. | 
 **updateEncodingBody** | [**UpdateEncodingBody**](UpdateEncodingBody.md)|  | 
 **screenshots** | **bool?**| Determines whether the response will include screenshots. By default this is not set. | [optional] 
 **preciseStatus** | **bool?**| Determines whether the response will include a precise status. By default this is not set. | [optional] 

### Return type

[**Encoding**](Encoding.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefactory"></a>
# **UpdateFactory**
> Factory UpdateFactory (string id, FactoryBody updateFactoryBody, bool? withStorageProvider = null)

Updates a Factory's settings. Returns a Factory object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class UpdateFactoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | id of the factory
            var updateFactoryBody = new FactoryBody(); // FactoryBody | 
            var withStorageProvider = true;  // bool? | if set to `true`, results will include a storage provider's id (optional) 

            try
            {
                // Updates a Factory's settings. Returns a Factory object.
                Factory result = apiInstance.UpdateFactory(id, updateFactoryBody, withStorageProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.UpdateFactory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id of the factory | 
 **updateFactoryBody** | [**FactoryBody**](FactoryBody.md)|  | 
 **withStorageProvider** | **bool?**| if set to &#x60;true&#x60;, results will include a storage provider&#39;s id | [optional] 

### Return type

[**Factory**](Factory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenotifications"></a>
# **UpdateNotifications**
> CloudNotificationSettings UpdateNotifications (string factoryId, CloudNotificationSettings cloudNotificationSettingsBody)

Updates a Factory's notification settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class UpdateNotificationsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var cloudNotificationSettingsBody = new CloudNotificationSettings(); // CloudNotificationSettings | 

            try
            {
                // Updates a Factory's notification settings.
                CloudNotificationSettings result = apiInstance.UpdateNotifications(factoryId, cloudNotificationSettingsBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.UpdateNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **cloudNotificationSettingsBody** | [**CloudNotificationSettings**](CloudNotificationSettings.md)|  | 

### Return type

[**CloudNotificationSettings**](CloudNotificationSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprofile"></a>
# **UpdateProfile**
> Profile UpdateProfile (string id, string factoryId, ProfileBody updateProfileBody, bool? excludeAdvancedServices = null, bool? expand = null)

Updates a given Profile

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class UpdateProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | 
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var updateProfileBody = new ProfileBody(); // ProfileBody | 
            var excludeAdvancedServices = true;  // bool? |  (optional) 
            var expand = true;  // bool? | If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. (optional) 

            try
            {
                // Updates a given Profile
                Profile result = apiInstance.UpdateProfile(id, factoryId, updateProfileBody, excludeAdvancedServices, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.UpdateProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **factoryId** | **string**| Id of a Factory. | 
 **updateProfileBody** | [**ProfileBody**](ProfileBody.md)|  | 
 **excludeAdvancedServices** | **bool?**|  | [optional] 
 **expand** | **bool?**| If expand option is set Profile objects will contain all command parameters, even if their value is default. By default this is not set. | [optional] 

### Return type

[**Profile**](Profile.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvideo"></a>
# **UploadVideo**
> UploadSession UploadVideo (string factoryId, VideoUploadBody videoUploadBody)

Creates an upload session.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class UploadVideoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var videoUploadBody = new VideoUploadBody(); // VideoUploadBody | 

            try
            {
                // Creates an upload session.
                UploadSession result = apiInstance.UploadVideo(factoryId, videoUploadBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.UploadVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **videoUploadBody** | [**VideoUploadBody**](VideoUploadBody.md)|  | 

### Return type

[**UploadSession**](UploadSession.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="video"></a>
# **Video**
> Video Video (string id, string factoryId)

Returns a Video object.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class VideoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a Video object.
                Video result = apiInstance.Video(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Video: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**Video**](Video.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videoencodings"></a>
# **VideoEncodings**
> PaginatedEncodingsCollection VideoEncodings (string id, string factoryId, int? page = null, int? perPage = null, bool? screenshots = null, bool? preciseStatus = null)

Returns a list of Encodings that belong to a Video.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class VideoEncodingsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 
            var screenshots = true;  // bool? | Determines whether the response will include screenshots. By default this is not set. (optional) 
            var preciseStatus = true;  // bool? | Determines whether the response will include a precise status. By default this is not set. (optional) 

            try
            {
                // Returns a list of Encodings that belong to a Video.
                PaginatedEncodingsCollection result = apiInstance.VideoEncodings(id, factoryId, page, perPage, screenshots, preciseStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.VideoEncodings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 
 **screenshots** | **bool?**| Determines whether the response will include screenshots. By default this is not set. | [optional] 
 **preciseStatus** | **bool?**| Determines whether the response will include a precise status. By default this is not set. | [optional] 

### Return type

[**PaginatedEncodingsCollection**](PaginatedEncodingsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videometadata"></a>
# **VideoMetadata**
> VideoMetadata VideoMetadata (string id, string factoryId)

Returns a Video's metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class VideoMetadataExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var id = id_example;  // string | Id of a Video.
            var factoryId = factoryId_example;  // string | Id of a Factory.

            try
            {
                // Returns a Video's metadata
                VideoMetadata result = apiInstance.VideoMetadata(id, factoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.VideoMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of a Video. | 
 **factoryId** | **string**| Id of a Factory. | 

### Return type

[**VideoMetadata**](VideoMetadata.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="videos"></a>
# **Videos**
> PaginatedVideoCollection Videos (string factoryId, int? page = null, int? perPage = null)

Returns a collection of Video objects.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class VideosExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 

            try
            {
                // Returns a collection of Video objects.
                PaginatedVideoCollection result = apiInstance.Videos(factoryId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Videos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 

### Return type

[**PaginatedVideoCollection**](PaginatedVideoCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflows"></a>
# **Workflows**
> PaginatedWorkflowsCollection Workflows (string factoryId, int? page = null, int? perPage = null)

Returns a collection of Workflows that belong to a Factory.

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Example
{
    public class WorkflowsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new FlipApi();
            var factoryId = factoryId_example;  // string | Id of a Factory.
            var page = 56;  // int? | A page to be fetched. Default is `1`. (optional) 
            var perPage = 56;  // int? | A number of results per page. Default is `100`. (optional) 

            try
            {
                // Returns a collection of Workflows that belong to a Factory.
                PaginatedWorkflowsCollection result = apiInstance.Workflows(factoryId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlipApi.Workflows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **factoryId** | **string**| Id of a Factory. | 
 **page** | **int?**| A page to be fetched. Default is &#x60;1&#x60;. | [optional] 
 **perPage** | **int?**| A number of results per page. Default is &#x60;100&#x60;. | [optional] 

### Return type

[**PaginatedWorkflowsCollection**](PaginatedWorkflowsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

