# Telestream.Cloud.Tts.Model.Job
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the job. | [optional] 
**Name** | **string** | The name of the job. | [optional] 
**OriginalFilename** | **string** | The name of the input file | [optional] 
**ProjectId** | **string** | The ID of the project. | [optional] 
**SourceUrl** | **string** | The URL of source file. | [optional] 
**Status** | **string** | Determines the state of transcription job. | [optional] 
**Error** | **string** | If the status of the job is &#39;error&#39;, returns the state of job. | [optional] 
**Progress** | **int?** | A percentage that indicates the progress of the job. | [optional] 
**Confidence** | **int?** | The confidence score of the job in the range of 0 to 100. | [optional] 
**Duration** | **int?** | The duration of the input audio in milliseconds. | [optional] 
**Bitrate** | **int?** | The bitrate of the input audio. | [optional] 
**SampleRate** | **int?** | The sample rate of the input audio. | [optional] 
**Format** | **string** | The format of the input audio. | [optional] 
**FileSize** | **int?** | The file size of the input file. | [optional] 
**CustomWords** | **string** | Words used for model training, separated by space. | [optional] 
**CreatedAt** | **string** | A date and time when the job was created | [optional] 
**UpdatedAt** | **string** | A date and time when the job was updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

