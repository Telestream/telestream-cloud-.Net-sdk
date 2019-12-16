# Telestream.Cloud.Tts.Api.TtsApi

All URIs are relative to *https://api.cloud.telestream.net/tts/v1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Corpora**](TtsApi.md#corpora) | **GET** /projects/{projectID}/corpora | Returns a collection of Corpora
[**Corpus**](TtsApi.md#corpus) | **GET** /projects/{projectID}/corpora/{name} | Returns the Corpus
[**CreateCorpus**](TtsApi.md#createcorpus) | **POST** /projects/{projectID}/corpora/{name} | Creates a new Corpus
[**CreateJob**](TtsApi.md#createjob) | **POST** /projects/{projectID}/jobs | Creates a new Job
[**CreateProject**](TtsApi.md#createproject) | **POST** /projects | Creates a new Project
[**DeleteCorpus**](TtsApi.md#deletecorpus) | **DELETE** /projects/{projectID}/corpora/{name} | Creates a new Corpus
[**DeleteJob**](TtsApi.md#deletejob) | **DELETE** /projects/{projectID}/jobs/{jobID} | Deletes the Job
[**DeleteProject**](TtsApi.md#deleteproject) | **DELETE** /projects/{projectID} | Deletes the Project
[**Job**](TtsApi.md#job) | **GET** /projects/{projectID}/jobs/{jobID} | Returns the Job
[**JobOutputs**](TtsApi.md#joboutputs) | **GET** /projects/{projectID}/jobs/{jobID}/outputs | Returns the Job Outputs
[**JobResult**](TtsApi.md#jobresult) | **GET** /projects/{projectID}/jobs/{jobID}/result | Returns the Job Result
[**Jobs**](TtsApi.md#jobs) | **GET** /projects/{projectID}/jobs | Returns a collection of Jobs
[**Project**](TtsApi.md#project) | **GET** /projects/{projectID} | Returns the Project
[**Projects**](TtsApi.md#projects) | **GET** /projects | Returns a collection of Projects
[**TrainProject**](TtsApi.md#trainproject) | **POST** /projects/{projectID}/train | Queues training
[**UpdateProject**](TtsApi.md#updateproject) | **PUT** /projects/{projectID} | Updates an existing Project
[**UploadVideo**](TtsApi.md#uploadvideo) | **POST** /projects/{projectID}/jobs/upload | Creates an upload session


<a name="corpora"></a>
# **Corpora**
> CorporaCollection Corpora (string projectID)

Returns a collection of Corpora

Returns a collection of Corpora

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class CorporaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project

            try
            {
                // Returns a collection of Corpora
                CorporaCollection result = apiInstance.Corpora(projectID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Corpora: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 

### Return type

[**CorporaCollection**](CorporaCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corpus"></a>
# **Corpus**
> Corpus Corpus (string projectID, string name)

Returns the Corpus

Returns the Corpus

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class CorpusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var name = name_example;  // string | Corpus name

            try
            {
                // Returns the Corpus
                Corpus result = apiInstance.Corpus(projectID, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Corpus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **name** | **string**| Corpus name | 

### Return type

[**Corpus**](Corpus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcorpus"></a>
# **CreateCorpus**
> void CreateCorpus (string projectID, string name, string body)

Creates a new Corpus

Creates a new Corpus

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class CreateCorpusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var name = name_example;  // string | Corpus name
            var body = body_example;  // string | 

            try
            {
                // Creates a new Corpus
                apiInstance.CreateCorpus(projectID, name, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.CreateCorpus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **name** | **string**| Corpus name | 
 **body** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createjob"></a>
# **CreateJob**
> Job CreateJob (string projectID, Job job)

Creates a new Job

Creates a new Job

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class CreateJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var job = new Job(); // Job | 

            try
            {
                // Creates a new Job
                Job result = apiInstance.CreateJob(projectID, job);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.CreateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **job** | [**Job**](Job.md)|  | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproject"></a>
# **CreateProject**
> Project CreateProject (Project project)

Creates a new Project

Creates a new Project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var project = new Project(); // Project | 

            try
            {
                // Creates a new Project
                Project result = apiInstance.CreateProject(project);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.CreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **project** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecorpus"></a>
# **DeleteCorpus**
> void DeleteCorpus (string projectID, string name)

Creates a new Corpus

Creates a new Corpus

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class DeleteCorpusExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var name = name_example;  // string | Corpus name

            try
            {
                // Creates a new Corpus
                apiInstance.DeleteCorpus(projectID, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.DeleteCorpus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **name** | **string**| Corpus name | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejob"></a>
# **DeleteJob**
> void DeleteJob (string projectID, string jobID)

Deletes the Job

Deletes the Job

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var jobID = jobID_example;  // string | 

            try
            {
                // Deletes the Job
                apiInstance.DeleteJob(projectID, jobID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.DeleteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **jobID** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (string projectID)

Deletes the Project

Deletes the Project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project

            try
            {
                // Deletes the Project
                apiInstance.DeleteProject(projectID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.DeleteProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="job"></a>
# **Job**
> Job Job (string projectID, string jobID)

Returns the Job

Returns the Job

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class JobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var jobID = jobID_example;  // string | 

            try
            {
                // Returns the Job
                Job result = apiInstance.Job(projectID, jobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Job: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **jobID** | **string**|  | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="joboutputs"></a>
# **JobOutputs**
> List<JobOutput> JobOutputs (string projectID, string jobID)

Returns the Job Outputs

Returns the Job Outputs

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class JobOutputsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var jobID = jobID_example;  // string | 

            try
            {
                // Returns the Job Outputs
                List&lt;JobOutput&gt; result = apiInstance.JobOutputs(projectID, jobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.JobOutputs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **jobID** | **string**|  | 

### Return type

[**List<JobOutput>**](JobOutput.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobresult"></a>
# **JobResult**
> JobResult JobResult (string projectID, string jobID)

Returns the Job Result

Returns the Job Result

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class JobResultExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var jobID = jobID_example;  // string | 

            try
            {
                // Returns the Job Result
                JobResult result = apiInstance.JobResult(projectID, jobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.JobResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **jobID** | **string**|  | 

### Return type

[**JobResult**](JobResult.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobs"></a>
# **Jobs**
> JobsCollection Jobs (string projectID, int? page = null, int? perPage = null)

Returns a collection of Jobs

Returns a collection of Jobs

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class JobsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var page = 56;  // int? | page number (optional) 
            var perPage = 56;  // int? | number of records per page (optional) 

            try
            {
                // Returns a collection of Jobs
                JobsCollection result = apiInstance.Jobs(projectID, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Jobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **page** | **int?**| page number | [optional] 
 **perPage** | **int?**| number of records per page | [optional] 

### Return type

[**JobsCollection**](JobsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="project"></a>
# **Project**
> Project Project (string projectID)

Returns the Project

Returns the Project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class ProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project

            try
            {
                // Returns the Project
                Project result = apiInstance.Project(projectID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Project: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projects"></a>
# **Projects**
> ProjectsCollection Projects ()

Returns a collection of Projects

Returns a collection of Projects

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class ProjectsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();

            try
            {
                // Returns a collection of Projects
                ProjectsCollection result = apiInstance.Projects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.Projects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProjectsCollection**](ProjectsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trainproject"></a>
# **TrainProject**
> void TrainProject (string projectID)

Queues training

Queues training

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class TrainProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project

            try
            {
                // Queues training
                apiInstance.TrainProject(projectID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.TrainProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproject"></a>
# **UpdateProject**
> Project UpdateProject (string projectID, Project project)

Updates an existing Project

Updates an existing Project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Example
{
    public class UpdateProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var project = new Project(); // Project | 

            try
            {
                // Updates an existing Project
                Project result = apiInstance.UpdateProject(projectID, project);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.UpdateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **project** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvideo"></a>
# **UploadVideo**
> UploadSession UploadVideo (string projectID, VideoUploadBody videoUploadBody)

Creates an upload session

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Tts.Api;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

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

            var apiInstance = new TtsApi();
            var projectID = projectID_example;  // string | ID of the Project
            var videoUploadBody = new VideoUploadBody(); // VideoUploadBody | 

            try
            {
                // Creates an upload session
                UploadSession result = apiInstance.UploadVideo(projectID, videoUploadBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TtsApi.UploadVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectID** | **string**| ID of the Project | 
 **videoUploadBody** | [**VideoUploadBody**](VideoUploadBody.md)|  | 

### Return type

[**UploadSession**](UploadSession.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

