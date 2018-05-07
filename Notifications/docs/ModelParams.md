# Telestream.Cloud.Notifications.Model.ModelParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | **List&lt;string&gt;** | [required] #email;  E-mail addresses  | [optional] 
**Url** | **string** | [required] #webhook;  Webhook URL  | [optional] 
**Method** | **string** | [optional] #webhook;  HTTP method; default: POST (GET, POST)  | [optional] 
**Retries** | **int?** | [optional] #webhook;  Number of retries before forgetting the notification; default: 0  | [optional] 
**ContentType** | **string** | [optional] #webhook; default: application/json (application/json, application/x-www-form-urlencoded)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

