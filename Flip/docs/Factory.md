# Telestream.Cloud.Flip.Model.Factory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier of a Factory. | [optional] 
**Name** | **string** | Human-readable identifier of a Factory. | [optional] 
**CreatedAt** | **string** | A date and time when a Factory has been created. | [optional] 
**UpdatedAt** | **string** | A date and time when a Factory has been updated last time. | [optional] 
**Url** | **string** | An URL pointing to the output_bucket_name. | [optional] 
**ServerSideEncryption** | **bool?** | Specify if you want to use multi-factor server-side 256-bit AES-256 data encryption with Amazon S3-managed encryption keys (SSE-S3). Each object is encrypted using a unique key which as an additional safeguard is encrypted itself with a master key that S3 regularly rotates. By default this is not set. | [optional] 
**OutputsPathFormat** | **string** | Specify the directory where the output files should be stored. By default it is not set. More info [here](https://cloud.telestream.net/docs#path-format- --know-how). | [optional] 
**StoreId** | **string** | Unique ID of a store defined in the stores service that will be used as a destination for all of the outputs created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

