# Telestream.Cloud.Flip.Model.Encoding
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier of an Encoding. | [optional] 
**AudioBitrate** | **int?** | Audio bitrate (in bits/s). | [optional] 
**AudioChannels** | **int?** | A number of audio channels. | [optional] 
**AudioCodec** | **string** | A codec that is used to encode audio streams. | [optional] 
**AudioSampleRate** | **string** | A number of samples of audio carried per second. | [optional] 
**CreatedAt** | **string** | A date and time when the Encoding has been created. | [optional] 
**Duration** | **string** |  | [optional] 
**EncodingProgress** | **string** |  | [optional] 
**EncodingTime** | **string** |  | [optional] 
**ErrorClass** | **string** | A class of an error that has occurred during the encoding process. It is present only if the encoding status is equal to &#x60;fail&#x60;. | [optional] 
**ErrorMessage** | **string** | A message that explains why the encoding process has resulted in an error. It is present only if the encoding status is equal to &#x60;fail&#x60;. | [optional] 
**ExternalId** | **string** |  | [optional] 
**Extname** | **string** | Extension of the output file. | [optional] 
**FileSize** | **string** | A size of the output file. | [optional] 
**Files** | **List&lt;string&gt;** | An array of output file names. | [optional] 
**Fps** | **string** | Number of frames per second. | [optional] 
**Height** | **string** | Height of the output video. | [optional] 
**Width** | **string** | Width of the output video. | [optional] 
**LogfileUrl** | **string** | An URL pointing to a logfile. | [optional] 
**MimeType** | **string** | A mime type of the encoded file. | [optional] 
**ParentEncodingId** | **string** |  | [optional] 
**Path** | **string** |  | [optional] 
**ProfileId** | **string** | An id of a related Profile. | [optional] 
**ProfileName** | **string** | A name of the used Profile. | [optional] 
**Screenshots** | **List&lt;string&gt;** |  | [optional] 
**StartedEncodingAt** | **string** | A date and time when the encoding process has been started | [optional] 
**Status** | **string** | Determines at what stage the encoding process is at the moment. | [optional] 
**UpdatedAt** | **string** | A date and time when a Encoding has been updated last time. | [optional] 
**VideoBitrate** | **string** | video bitrate (in bits/s) | [optional] 
**VideoCodec** | **string** | A codec that is used to encode video streams. | [optional] 
**VideoId** | **string** | An id of a related Video object | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

