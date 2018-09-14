# Telestream.Cloud.Qc.Api.QcApi

All URIs are relative to *https://api.cloud.telestream.net/qc/v1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelJob**](QcApi.md#canceljob) | **PUT** /projects/{project_id}/jobs/{job_id}/cancel.json | 
[**CreateJob**](QcApi.md#createjob) | **POST** /projects/{project_id}/jobs.json | Create a new job
[**CreateProject**](QcApi.md#createproject) | **POST** /projects.json | Create a new project
[**GetJob**](QcApi.md#getjob) | **GET** /projects/{project_id}/jobs/{job_id}.json | Get QC job
[**GetProject**](QcApi.md#getproject) | **GET** /projects/{project_id}.json | Get project by Id
[**ImportTemplate**](QcApi.md#importtemplate) | **POST** /projects/import.json | Import Vidchecker template
[**ListJobs**](QcApi.md#listjobs) | **GET** /projects/{project_id}/jobs.json | Get jobs form projects
[**ListProjects**](QcApi.md#listprojects) | **GET** /projects.json | List all projects for an account
[**ModifyProject**](QcApi.md#modifyproject) | **PUT** /projects/{project_id}.json | Modify project
[**Proxy**](QcApi.md#proxy) | **GET** /projects/{project_id}/jobs/{job_id}/proxy.json | 
[**RemoveJob**](QcApi.md#removejob) | **DELETE** /projects/{project_id}/jobs/{job_id}.json | 
[**RemoveProject**](QcApi.md#removeproject) | **DELETE** /projects/{project_id}.json | 
[**SignedUrls**](QcApi.md#signedurls) | **GET** /projects/{project_id}/jobs/{job_id}/signed-urls.json | 
[**Templates**](QcApi.md#templates) | **GET** /templates.json | List all templates
[**UploadVideo**](QcApi.md#uploadvideo) | **POST** /projects/{project_id}/upload.json | Creates an upload session


<a name="canceljob"></a>
# **CancelJob**
> void CancelJob (string projectId, string jobId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class CancelJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var jobId = jobId_example;  // string | A unique identifier of a Job.

            try
            {
                apiInstance.CancelJob(projectId, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.CancelJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **jobId** | **string**| A unique identifier of a Job. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createjob"></a>
# **CreateJob**
> Job CreateJob (string projectId, JobData data)

Create a new job

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

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

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var data = new JobData(); // JobData | 

            try
            {
                // Create a new job
                Job result = apiInstance.CreateJob(projectId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.CreateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **data** | [**JobData**](JobData.md)|  | 

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
> Project CreateProject (Data data = null)

Create a new project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

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

            var apiInstance = new QcApi();
            var data = new Data(); // Data |  (optional) 

            try
            {
                // Create a new project
                Project result = apiInstance.CreateProject(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.CreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Data**](Data.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjob"></a>
# **GetJob**
> Job GetJob (string projectId, string jobId)

Get QC job

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var jobId = jobId_example;  // string | A unique identifier of a Job.

            try
            {
                // Get QC job
                Job result = apiInstance.GetJob(projectId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **jobId** | **string**| A unique identifier of a Job. | 

### Return type

[**Job**](Job.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproject"></a>
# **GetProject**
> Project GetProject (string projectId)

Get project by Id

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class GetProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.

            try
            {
                // Get project by Id
                Project result = apiInstance.GetProject(projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.GetProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importtemplate"></a>
# **ImportTemplate**
> List<InlineResponse200> ImportTemplate (string name = null,  file = null)

Import Vidchecker template

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class ImportTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var name = name_example;  // string |  (optional) 
            var file = new (); //  |  (optional) 

            try
            {
                // Import Vidchecker template
                List&lt;InlineResponse200&gt; result = apiInstance.ImportTemplate(name, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.ImportTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | [optional] 
 **file** | [****](.md)|  | [optional] 

### Return type

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: text/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listjobs"></a>
# **ListJobs**
> JobsCollection ListJobs (string projectId, bool? expand = null, string status = null, int? perPage = null, int? page = null)

Get jobs form projects

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class ListJobsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var expand = true;  // bool? | Expand details of job (optional) 
            var status = status_example;  // string | Filter jobs by status (optional) 
            var perPage = 56;  // int? | Limit number of listed jobs (optional)  (default to 30)
            var page = 56;  // int? | Index of jobs page to be listed (optional) 

            try
            {
                // Get jobs form projects
                JobsCollection result = apiInstance.ListJobs(projectId, expand, status, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.ListJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **expand** | **bool?**| Expand details of job | [optional] 
 **status** | **string**| Filter jobs by status | [optional] 
 **perPage** | **int?**| Limit number of listed jobs | [optional] [default to 30]
 **page** | **int?**| Index of jobs page to be listed | [optional] 

### Return type

[**JobsCollection**](JobsCollection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listprojects"></a>
# **ListProjects**
> List<Project> ListProjects ()

List all projects for an account

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class ListProjectsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();

            try
            {
                // List all projects for an account
                List&lt;Project&gt; result = apiInstance.ListProjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.ListProjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Project>**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyproject"></a>
# **ModifyProject**
> Project ModifyProject (string projectId, Data1 data = null)

Modify project

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class ModifyProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | 
            var data = new Data1(); // Data1 |  (optional) 

            try
            {
                // Modify project
                Project result = apiInstance.ModifyProject(projectId, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.ModifyProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **data** | [**Data1**](Data1.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="proxy"></a>
# **Proxy**
> Proxy Proxy (string projectId, string jobId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class ProxyExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var jobId = jobId_example;  // string | A unique identifier of a Job.

            try
            {
                Proxy result = apiInstance.Proxy(projectId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.Proxy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **jobId** | **string**| A unique identifier of a Job. | 

### Return type

[**Proxy**](Proxy.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removejob"></a>
# **RemoveJob**
> void RemoveJob (string projectId, string jobId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class RemoveJobExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var jobId = jobId_example;  // string | A unique identifier of a Job.

            try
            {
                apiInstance.RemoveJob(projectId, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.RemoveJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **jobId** | **string**| A unique identifier of a Job. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeproject"></a>
# **RemoveProject**
> void RemoveProject (string projectId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class RemoveProjectExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | 

            try
            {
                apiInstance.RemoveProject(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.RemoveProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signedurls"></a>
# **SignedUrls**
> Dictionary<string, string> SignedUrls (string projectId, string jobId)



### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class SignedUrlsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var jobId = jobId_example;  // string | A unique identifier of a Job.

            try
            {
                Dictionary&lt;string, string&gt; result = apiInstance.SignedUrls(projectId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.SignedUrls: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **jobId** | **string**| A unique identifier of a Job. | 

### Return type

**Dictionary<string, string>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templates"></a>
# **Templates**
> List<Template> Templates ()

List all templates

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Example
{
    public class TemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new QcApi();

            try
            {
                // List all templates
                List&lt;Template&gt; result = apiInstance.Templates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.Templates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Template>**](Template.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvideo"></a>
# **UploadVideo**
> UploadSession UploadVideo (string projectId, VideoUploadBody videoUploadBody)

Creates an upload session

### Example
```csharp
using System;
using System.Diagnostics;
using Telestream.Cloud.Qc.Api;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

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

            var apiInstance = new QcApi();
            var projectId = projectId_example;  // string | A unique identifier of a Project.
            var videoUploadBody = new VideoUploadBody(); // VideoUploadBody | 

            try
            {
                // Creates an upload session
                UploadSession result = apiInstance.UploadVideo(projectId, videoUploadBody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QcApi.UploadVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**| A unique identifier of a Project. | 
 **videoUploadBody** | [**VideoUploadBody**](VideoUploadBody.md)|  | 

### Return type

[**UploadSession**](UploadSession.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

