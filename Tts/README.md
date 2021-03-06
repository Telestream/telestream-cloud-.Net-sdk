# Telestream Cloud Timed Text Speech Csharp SDK

This library provides a low-level interface to the REST API of Telestream Cloud, the online video encoding service.

# Telestream.Cloud.Tts - the C# library for the Tts API

Description

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
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
nuget pack -Build -OutputDirectory out Telestream.Cloud.Tts.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

## Documentation for API Endpoints

All URIs are relative to *https://api.cloud.telestream.net/tts/v1.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*TtsApi* | [**Corpora**](docs/TtsApi.md#corpora) | **GET** /projects/{projectID}/corpora | Returns a collection of Corpora
*TtsApi* | [**Corpus**](docs/TtsApi.md#corpus) | **GET** /projects/{projectID}/corpora/{name} | Returns the Corpus
*TtsApi* | [**CreateCorpus**](docs/TtsApi.md#createcorpus) | **POST** /projects/{projectID}/corpora/{name} | Creates a new Corpus
*TtsApi* | [**CreateJob**](docs/TtsApi.md#createjob) | **POST** /projects/{projectID}/jobs | Creates a new Job
*TtsApi* | [**CreateProject**](docs/TtsApi.md#createproject) | **POST** /projects | Creates a new Project
*TtsApi* | [**DeleteCorpus**](docs/TtsApi.md#deletecorpus) | **DELETE** /projects/{projectID}/corpora/{name} | Creates a new Corpus
*TtsApi* | [**DeleteJob**](docs/TtsApi.md#deletejob) | **DELETE** /projects/{projectID}/jobs/{jobID} | Deletes the Job
*TtsApi* | [**DeleteProject**](docs/TtsApi.md#deleteproject) | **DELETE** /projects/{projectID} | Deletes the Project
*TtsApi* | [**Job**](docs/TtsApi.md#job) | **GET** /projects/{projectID}/jobs/{jobID} | Returns the Job
*TtsApi* | [**JobOutputs**](docs/TtsApi.md#joboutputs) | **GET** /projects/{projectID}/jobs/{jobID}/outputs | Returns the Job Outputs
*TtsApi* | [**JobResult**](docs/TtsApi.md#jobresult) | **GET** /projects/{projectID}/jobs/{jobID}/result | Returns the Job Result
*TtsApi* | [**Jobs**](docs/TtsApi.md#jobs) | **GET** /projects/{projectID}/jobs | Returns a collection of Jobs
*TtsApi* | [**Project**](docs/TtsApi.md#project) | **GET** /projects/{projectID} | Returns the Project
*TtsApi* | [**Projects**](docs/TtsApi.md#projects) | **GET** /projects | Returns a collection of Projects
*TtsApi* | [**TrainProject**](docs/TtsApi.md#trainproject) | **POST** /projects/{projectID}/train | Queues training
*TtsApi* | [**UpdateProject**](docs/TtsApi.md#updateproject) | **PUT** /projects/{projectID} | Updates an existing Project
*TtsApi* | [**UploadVideo**](docs/TtsApi.md#uploadvideo) | **POST** /projects/{projectID}/jobs/upload | Creates an upload session


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CorporaCollection](docs/CorporaCollection.md)
 - [Model.Corpus](docs/Corpus.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ExtraFile](docs/ExtraFile.md)
 - [Model.Fragment](docs/Fragment.md)
 - [Model.FragmentVariant](docs/FragmentVariant.md)
 - [Model.Job](docs/Job.md)
 - [Model.JobOutput](docs/JobOutput.md)
 - [Model.JobResult](docs/JobResult.md)
 - [Model.JobsCollection](docs/JobsCollection.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectsCollection](docs/ProjectsCollection.md)
 - [Model.Result](docs/Result.md)
 - [Model.UploadSession](docs/UploadSession.md)
 - [Model.VideoUploadBody](docs/VideoUploadBody.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: X-Api-Key
- **Location**: HTTP header

