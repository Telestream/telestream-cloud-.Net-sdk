# Telestream.Cloud.Flip.Model.Video
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier of the Video. | [optional] 
**AudioBitrate** | **int?** | audio bitrate (in bits/s) | [optional] 
**AudioChannels** | **int?** | A number of audio channels. | [optional] 
**AudioCodec** | **string** | A codec that has been used to encode audio streams. | [optional] 
**AudioSampleRate** | **int?** | A number of samples of audio carried per second. | [optional] 
**CreatedAt** | **string** | A date and time when the Video has been created. | [optional] 
**Duration** | **int?** | A duration of the video in seconds. | [optional] 
**EncodingsCount** | **int?** | A number of related Encoding objects. | [optional] 
**ErrorClass** | **string** | A class of an error that has occurred during the encoding process. It is present only if the encoding status is equal to &#x60;fail&#x60;. | [optional] 
**ErrorMessage** | **string** | A message that explains why the encoding process has resulted in an error. It is present only if the encoding status is equal to &#x60;fail&#x60;. | [optional] 
**Extname** | **string** | Extension of the source file. | [optional] 
**FileSize** | **int?** | A size of the source file. | [optional] 
**Fps** | **decimal?** | Number of frames per second. | [optional] 
**Height** | **int?** | Height of the output video. | [optional] 
**Width** | **int?** | Width of the output video. | [optional] 
**MimeType** | **string** | A mime type of the source file. | [optional] 
**OriginalFilename** | **string** | A name of the source file. | [optional] 
**Path** | **string** |  | [optional] 
**Payload** | **string** | Payload is an arbitrary text of length 256 or shorter that you can store along the Video. It is typically used to retain an association with one of your own DB record ID. | [optional] 
**SourceUrl** | **string** | An URL pointing to the source file. | [optional] 
**Status** | **string** | Determines at what stage of importing process the Video is at the moment. | [optional] 
**UpdatedAt** | **string** | A date and time when a Video has been updated last time. | [optional] 
**VideoBitrate** | **string** | video bitrate (in bits/s) | [optional] 
**VideoCodec** | **string** | A codec that has been used to encode the input file&#39;s video streams. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

