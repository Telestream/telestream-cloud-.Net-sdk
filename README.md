# .NET Client for Telestream Cloud
## How do I use it?

#### Configuration

To use Telestream Cloud SDK you need to configure client of Cloud API

```csharp
    TelestreamCloudConfig.Initialize("ACCESS KEY", "SECRET KEY");
```

For default Host = "api.cloud.telestream.net", Version = "3.0", Port = 443;

You can change it using:
```csharp
    TelestreamCloudConfig.Initialize("ACCESS KEY", "SECRET KEY", "api-us-east.cloud.telestream.net", "3.0", 443);
```

#### Custom configuration

For example, if you want to store your keys into app.config you can write your own class that implements  IConfigurationService interface

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="Telestream.AccessKey" value="ACCESS KEY"/>
    <add key="Telestream.SecretKey" value="SECRET KEY"/>
  </appSettings>
</configuration>
```

```csharp
  public class AppConfigConfigurationService : IConfigurationService
	{
		public ApiAccess Get()
		{
			var accessKey = ConfigurationManager.AppSettings["Telestream.AccessKey"];
			var secretKey = ConfigurationManager.AppSettings["Telestream.SecretKey"];

			return new ApiAccess(accessKey, secretKey);
		}
	}
```

And pass the instance to service client 
```csharp
var customConfig = new AppConfigConfigurationService();
var service = new FactoryService(customConfig, "FACTORY ID");
```


#### The client:

Each client is working in context of factory.

```csharp
  var service = new FactoryService("FACTORY ID");
```
### Examples

#### Factories

Get all factories
```csharp
  var cloud = new TelestreamCloudService();
  var myFactories = await cloud.GetFactories();
```

Change a factory name
```csharp
  await cloud.ChangeFactoryName("[FACTORY_ID]", "My new factory name");
```

#### Jobs
Get all jobs
```csharp
  var factoryService = new FactoryService("[FACTORY_ID]");
  var myJobs = await factoryService.GetVideos();
```

Sumbit a new job with h264 and webm profile
```csharp
  var cloud = new TelestreamCloudService();
  var newJob = await cloud.CreateVideo("[FACTORY_ID]"), "https://link.to/your_movie.mp4", new string[] { "h264", "webm" });
```

Sumbit a new job with h264 and webm profile and extra files
```csharp
  var newVideo = new Video() { Profiles = "h264,webm", SourceUrl = "https://link.to/your_movie.mp4" };
  newVideo.AddExtraFile("closed_captions", "https://link.to/your_file.ext");
  newVideo.InputPath = "relative/path/to/input_file.ext";
  var newJob = await cloud.CreateVideo(firstFactory.Id, newVideo);
```

Delete a job
```csharp
  await factoryService.DeleteVideo("[JOB_ID]");
```

#### Encodings
Show actual state of encoding jobs 
```csharp
  var encodings = await factoryService.GetEncodings(newJob.Id);
  foreach (var encoding in encodings)
  {
    Console.WriteLine($"[{encoding.EncodingProgress}] - V:{encoding.VideoCodec}/A:{encoding.AudioCodec} (size:{encoding.FileSize})");
 }
```

Cancel an encoding
```csharp
  await factoryService.CancelEncoding("[ENCODING_ID]");
```

Retry an encoding
```csharp
  await factoryService.RetryEncoding("[ENCODING_ID]");
```

Delete an encoding
```csharp
  await factoryService.DeleteEncoding("[ENCODING_ID]");
```

#### Profiles
Get a profile
```csharp
  var cloud = new TelestreamCloudService();
  var encodings = await cloud.GetProfile("[FACTORY_ID]", "h264.1");
```

Create a profile based on existing one
```csharp
  var cloud = new TelestreamCloudService();
  var baseProfile = await cloud.GetProfile("[FACTORY_ID]", "h264.1");
  baseProfile.Title = "h264.new";
  var newProfile = await cloud.CreateProfile("[FACTORY_ID]", baseProfile);
```

