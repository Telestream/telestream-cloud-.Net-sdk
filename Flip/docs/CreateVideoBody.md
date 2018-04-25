# Telestream.Cloud.Flip.Model.CreateVideoBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceUrl** | **string** | An URL pointing to a source file. | [optional] 
**Profiles** | **string** | Comma-separated list of profile names or IDs to be used during encoding. Alternatively, specify none so no encodings are created yet. | [optional] 
**Payload** | **string** | Arbitrary string stored along the Video object. | [optional] 
**Pipeline** | **string** | String-encoded JSON describing profiles pipeline. | [optional] 
**SubtitleFiles** | **List&lt;string&gt;** | A list of urls pointing to remote subtitle files. | [optional] 
**ExtraFiles** | **Dictionary&lt;string, List&lt;string&gt;&gt;** |  | [optional] 
**ExtraVariables** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**PathFormat** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
