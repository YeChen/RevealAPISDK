# RevealAPI.Sdk.Models.Resources.PrintJob
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**CreatedByUserId** | **int?** |  | [optional] 
**NumberOfDocuments** | **int?** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 
**CreatedDateTime** | **DateTime?** |  | [optional] 
**Status** | **JobStatus** |  | [optional] 
**IsDeleted** | **bool?** |  | [optional] 
**TagProfileId** | **int?** |  | [optional] 
**NumberOfErrors** | **int?** |  | [optional] 
**NumberOfDocumentsProcessed** | **int?** |  | [optional] 
**LastUpdatedDateTime** | **DateTime?** |  | [optional] 
**StartDateTime** | **DateTime?** |  | [optional] 
**EndDateTime** | **DateTime?** |  | [optional] 
**JobInfoMessage** | **string** |  | [optional] 
**PagesToPrint** | **int?** |  | [optional] 
**DownloadFileName** | **string** |  | [optional] 
**DownloadFileSize** | **long?** |  | [optional] 
**Name** | **string** |  | [optional] 
**IncludeSlipsheet** | **bool?** |  | [optional] 
**IncludeTranscriptWordList** | **bool?** |  | [optional] 
**Orientation** | **PrintJobOrientation** |  | [optional] 
**PrintFormat** | **PrintPDFFormat** |  | [optional] 
**FileNameOrder** | **FileOrderSetting** |  | [optional] 
**ImageSetId** | **int?** |  | [optional] 
**UseOriginalImageIfMissing** | **bool?** |  | [optional] 
**ColorDetectionSettings** | [**ColorDetectionSettings**](ColorDetectionSettings.md) |  | [optional] 
**ImagingTemplateId** | **int?** |  | [optional] 
**SearchablePDFs** | **bool?** |  | [optional] 
**StampingChoice** | **StampingChoice** |  | [optional] 
**Stamping** | [**StampingSpec**](StampingSpec.md) |  | [optional] 
**IncludeRedactions** | **PrintIncludeRedactions** |  | [optional] 
**AnnotationsToInclude** | [**List&lt;AnnotationType&gt;**](AnnotationType.md) |  | [optional] 
**RedactionsProfiles** | **List&lt;int?&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

