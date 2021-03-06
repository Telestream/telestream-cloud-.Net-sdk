# Telestream Cloud IAM Csharp SDK

This library provides a low-level interface to the REST API of Telestream Cloud, the online video encoding service.

# Telestream.Cloud.Iam - the C# library for the IAM API

IAM API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Telestream.Cloud.Iam.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

## Documentation for API Endpoints

All URIs are relative to *https://api.cloud.telestream.net/iam/v1.0/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IamApi* | [**DeleteCredential**](docs/IamApi.md#deletecredential) | **DELETE** /credentials/{id} | 
*IamApi* | [**GetCredential**](docs/IamApi.md#getcredential) | **GET** /credentials/{id} | 
*IamApi* | [**GetCredentials**](docs/IamApi.md#getcredentials) | **GET** /credentials | 
*IamApi* | [**GetPolicy**](docs/IamApi.md#getpolicy) | **POST** /credentials/policy | 
*IamApi* | [**PostCredentials**](docs/IamApi.md#postcredentials) | **POST** /credentials | 
*IamApi* | [**UpdateCredential**](docs/IamApi.md#updatecredential) | **PATCH** /credentials/{id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Credential](docs/Credential.md)
 - [Model.CredentialsResponse](docs/CredentialsResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.Policy](docs/Policy.md)
 - [Model.Statement](docs/Statement.md)
 - [Model.StatementsList](docs/StatementsList.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: X-Api-Key
- **Location**: HTTP header

