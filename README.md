# Telestream Cloud API client

## Getting Started
### Obtain address for TCS api
In order to use TCS api client first you need to get `ApiKey`. Login to [website](https://cloud.telestream.net/console), go to *Flip* service and open *API Access* tab.
You account will be identified by unique *Api Key*, if it is unavailable click *Reset* button.

### Usage
This example show uploading media file to flip service. If you want to use other service refer to [services](#services).

    using Telestream.Cloud.Tts.Api;
    using Telestream.Cloud.Tts.Client;
    using Telestream.Cloud.Tts.Model;

    Configuration.Default.ApiKey.Add("X-Api-Key", "YOUR_API_KEY");

    var apiInstance = new FlipApi();

    var factoryId = "tg0...";

    var uploader = new FileUploader(apiInstance);

    await uploader.UploadFile("/video/mp4", factoryId, "h264");

## Services
Api client is divided into parts corresponding to services provided. Currently supported services include:
- [Flip](flip/README.md) - high-volume media transcoding to multiple formats
- [Timed Text Speech](tts/README.md) - automated captions and subtitles creation
- [Quality Control](qc/README.md) - automated quality control for file base media
