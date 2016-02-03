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

If you don't know your factory id you can get all factory information using TelestreamCloudService class:

```csharp
  var service = new TelestreamCloudService();
  var myFactories = await service.GetFactories();
```
