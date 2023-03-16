# IO.Swagger.Model.PrintJobCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentSelectionType** | **DocumentSelection** |  | [optional] 
**SelectedDocumentItemIds** | **List&lt;long?&gt;** | Required when DocumentSelectionType &#x3D; Subset | [optional] 
**SearchJobId** | **long?** | Required when DocumentSelectionType &#x3D; AllFromSearchContext | [optional] 
**SearchCriteria** | [**BulkActionSearchCriteria**](BulkActionSearchCriteria.md) |  | [optional] 
**DisplayOrderedFields** | [**List&lt;ExportJobOrderedFieldItem&gt;**](ExportJobOrderedFieldItem.md) |  | [optional] 
**SortOrderedFields** | [**List&lt;ExportJobSortedFieldItem&gt;**](ExportJobSortedFieldItem.md) |  | [optional] 
**TagProfileId** | **int?** |  | [optional] 
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

