# Telestream.Cloud.Notifications.Model.ModelParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | **List&lt;string&gt;** | (for email subscription type);  E-mail addresses  | [optional] 
**Url** | **string** | (for webhook subscription type);  Webhook URL  | [optional] 
**Method** | **string** | (for webhook subscription type);  HTTP method; default: POST (GET, POST)  | [optional] 
**Retries** | **int?** | (for webhook subscription type);  Number of retries before forgetting the notification; default: 0  | [optional] 
**ContentType** | **string** | (for webhook subscription type); default: application/json (application/json, application/x-www-form-urlencoded)  | [optional] 
**TopicArn** | **string** | (for sns subscription type) identifier of an AWS SNS Topic that events will be posted to.  | [optional] 
**RoleArn** | **string** | (for sns subscription type) identifier of an AWS IAM Role that will be used for authorization.  | [optional] 
**TopicEndpoint** | **string** | (for aeg subscription type) address of an Azure Event Grid Topic that events will be posted to.  | [optional] 
**AccessKey** | **string** | (for aeg subscription type) secret access key that authorizes Telestream Cloud to write to an Azure Event Grid Topic.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

