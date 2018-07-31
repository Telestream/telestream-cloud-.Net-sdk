# Telestream.Cloud.Iam.Api.IamApi

All URIs are relative to *https://api.cloud.telestream.net/iam/v1.0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCredential**](IamApi.md#deletecredential) | **DELETE** /credentials/{id} | 
[**GetCredential**](IamApi.md#getcredential) | **GET** /credentials/{id} | 
[**GetCredentials**](IamApi.md#getcredentials) | **GET** /credentials | 
[**GetPolicy**](IamApi.md#getpolicy) | **POST** /credentials/policy | 
[**PostCredentials**](IamApi.md#postcredentials) | **POST** /credentials | 
[**UpdateCredential**](IamApi.md#updatecredential) | **PATCH** /credentials/{id} | 


<a name="deletecredential"></a>
# **DeleteCredential**
> void DeleteCredential (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class DeleteCredentialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();
            var id = id_example;  // string | 

            try
            {
                apiInstance.DeleteCredential(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.DeleteCredential: " + e.Message );
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

<a name="getcredential"></a>
# **GetCredential**
> Credential GetCredential (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class GetCredentialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();
            var id = id_example;  // string | 

            try
            {
                Credential result = apiInstance.GetCredential(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.GetCredential: " + e.Message );
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

[**Credential**](Credential.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentials"></a>
# **GetCredentials**
> CredentialsResponse GetCredentials ()



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class GetCredentialsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();

            try
            {
                CredentialsResponse result = apiInstance.GetCredentials();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.GetCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CredentialsResponse**](CredentialsResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolicy"></a>
# **GetPolicy**
> Dictionary<string, bool?> GetPolicy (StatementsList policy)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class GetPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();
            var policy = new StatementsList(); // StatementsList | 

            try
            {
                Dictionary&lt;string, bool?&gt; result = apiInstance.GetPolicy(policy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.GetPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policy** | [**StatementsList**](StatementsList.md)|  | 

### Return type

**Dictionary<string, bool?>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcredentials"></a>
# **PostCredentials**
> Credential PostCredentials (Credential createCredential)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class PostCredentialsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();
            var createCredential = new Credential(); // Credential | 

            try
            {
                Credential result = apiInstance.PostCredentials(createCredential);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.PostCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCredential** | [**Credential**](Credential.md)|  | 

### Return type

[**Credential**](Credential.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecredential"></a>
# **UpdateCredential**
> Credential UpdateCredential (string id, Credential updateCredential)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Iam.Api;
using Telestream.Cloud.Iam.Client;
using Telestream.Cloud.Iam.Model;

namespace Example
{
    public class UpdateCredentialExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new IamApi();
            var id = id_example;  // string | 
            var updateCredential = new Credential(); // Credential | 

            try
            {
                Credential result = apiInstance.UpdateCredential(id, updateCredential);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IamApi.UpdateCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **updateCredential** | [**Credential**](Credential.md)|  | 

### Return type

[**Credential**](Credential.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

