# Telestream.Cloud.Notifications.Model.Topic
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | [read-only] Account identifier connected to subscription notification  | [optional] 
**Service** | **string** | Name of service (qc, flip, tts)  | 
**_Event** | **string** | Name of the event;  Quality Control (media-passed, media-error, media-warning, media-rejected, media-canceled, job-created, job-progress), Flip (video-created, video-encoded, encoding-complete, encoding-progress), Transcription (job-created, job-completed, job-error, job-progress)  | 
**Project** | **string** | (for tts, qc service); Project ID  | [optional] 
**Factory** | **string** | (for flip service); Factory ID  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

