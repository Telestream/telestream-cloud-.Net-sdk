# Telestream.Cloud.Flip.Model.VideoUploadBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileSize** | **long?** | Size of the file that will be uploaded in &#x60;bytes&#x60;. | 
**FileName** | **string** | Name of the file that will be uploaded. | 
**ExtraFiles** | [**List&lt;ExtraFile&gt;**](ExtraFile.md) | A list of names of additional files that will be uploaded. | [optional] 
**Profiles** | **string** | A comma-separated list of profile names or IDs to be used during encoding. Alternatively, specify none so no encodings will created right away. | [optional] 
**PathFormat** | **string** |  | [optional] 
**Payload** | **string** | Payload is an arbitrary text of length 256 or shorter that you can store along the Video. It is typically used to retain an association with one of your own DB record ID. | [optional] 
**ExtraVariables** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**WatermarkUrl** | **string** | URL pointing to an image that will be used asa watermark. | [optional] 
**WatermarkLeft** | **string** | Determines distance between the left edge of a video and the left edge of a watermark image. Can be specified in pixels or percents. This parameter can be set only if watermark_right is not. | [optional] 
**WatermarkTop** | **string** | Determines distance between the top edge of a video and the top edge of a watermark image. Can be specified in pixels or percents. This parameter can be set only if watermark_bottom is not. | [optional] 
**WatermarkRight** | **string** | Determines distance between the right edge of a video and the right edge of a watermark image. Can be specified in pixels or percents. This parameter can be set only if watermark_left is not. | [optional] 
**WatermarkBottom** | **string** | Determines distance between the bottom edge of a video and the bottom edge of a watermark image. Can be specified in pixels or percents. This parameter can be set only if watermark_top is not. | [optional] 
**WatermarkWidth** | **string** | Determines width of the watermark image. Should be specified in pixels. | [optional] 
**WatermarkHeight** | **string** | Determines width of the watermark image. Should be specified in pixels. | [optional] 
**ClipLength** | **string** | Length of the uploaded video. Should be formatted as follows: HH:MM:SS | [optional] 
**ClipOffset** | **string** | Clip starts at a specific offset. | [optional] 
**MultiChunk** | **bool?** |  | [optional] [default to true]
**StoreId** | **string** | An individual store_id for this video processing. If provided will replace store_id from cloud factory but must match underlying cloud provider and region. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

