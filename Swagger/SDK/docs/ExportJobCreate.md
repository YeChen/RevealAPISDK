# RevealAPI.Sdk.Models.Resources.ExportJobCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentSelectionType** | **DocumentSelection** |  | [optional] 
**SelectedDocumentItemIds** | **List&lt;long?&gt;** |  | [optional] 
**SearchJobId** | **long?** | Required when DocumentSelectionType &#x3D; AllFromSearchContext | [optional] 
**SearchCriteria** | [**BulkActionSearchCriteria**](BulkActionSearchCriteria.md) |  | [optional] 
**DisplayOrderedFields** | [**List&lt;ExportJobOrderedFieldItem&gt;**](ExportJobOrderedFieldItem.md) |  | [optional] 
**SortOrderedFields** | [**List&lt;ExportJobSortedFieldItem&gt;**](ExportJobSortedFieldItem.md) |  | [optional] 
**TagProfileId** | **int?** | Used in conjunction with InControl.RestAPI.V2.Models.Jobs.Export.ExportJobCreate.SortOrderedFields to order by document tags | [optional] 
**Name** | **string** |  | [optional] 
**ImportProfileId** | **int?** |  | [optional] 
**ImageSetId** | **int?** |  | [optional] 
**ExportAs** | **ExportJobFileType** |  | [optional] 
**IncludeNativeFiles** | **bool?** |  | [optional] 
**FileNamingType** | **ExportJobFileNamingConvention** |  | [optional] 
**VolumePrefix** | **string** |  | [optional] 
**VolumeStartNumber** | **int?** |  | [optional] 
**VolumeNumberDigits** | **int?** |  | [optional] 
**VolumeMaxSize** | **int?** |  | [optional] 
**FileNameOrder** | **FileOrderSetting** |  | [optional] 
**NativeFileFields** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

