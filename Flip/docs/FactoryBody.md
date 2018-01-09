# Telestream.Cloud.Flip.Model.FactoryBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AwsAccessKey** | **string** | AWS access key. | [optional] 
**AwsSecretKey** | **string** | AWS secret key. | [optional] 
**FactoryRegion** | **string** | A region where the factory is located. | [optional] 
**InputBucketFilePattern** | **string** | A pattern that will be used to locate files in the input bucket. Valid wildcards might be used. | [optional] 
**InputBucketName** | **string** | A name of an input bucket. | [optional] 
**InputBucketRecursive** | **bool?** |  | [optional] 
**InputBucketSyncEveryNMin** | **int?** | Determines how often the input bucket is synchronised. | [optional] 
**InputBucketWatch** | **bool?** | Determines whether the Factory should be notified about new files added to the input bucket. | [optional] 
**Name** | **string** | Name of the Factory. | 
**OutputsPathFormat** | **string** | Specify the directory where the output files should be stored. By default it is not set. More info [here](https://cloud.telestream.net/docs#path-format- --know-how). | [optional] 
**ProviderSpecificSettings** | **Object** |  | [optional] 
**Acl** | **string** | Specify if your files are public or private (private files need authorization url to access). By default this is not set. | [optional] 
**OutputBucketName** | **string** | A bucket where processed files will be stored. | [optional] 
**ServerSideEncryption** | **bool?** | Specify if you want to use multi-factor server-side 256-bit AES-256 data encryption with Amazon S3-managed encryption keys (SSE-S3). Each object is encrypted using a unique key which as an additional safeguard is encrypted itself with a master key that S3 regularly rotates. By default this is not set. | [optional] 
**StorageCredentialAttributes** | [**FactoryBodyStorageCredentialAttributes**](FactoryBodyStorageCredentialAttributes.md) |  | [optional] 
**StorageProvider** | **int?** | Specifies which storage provider the factory should use. Available options: S3: 0, Google Cloud Storage: 1, FTP storage: 2, Google Cloud Interoperability Storage: 5, Flip storage: 7, FASP storage: 8, Azure Blob Storage: 9 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

