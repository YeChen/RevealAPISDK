/* 
 * Reveal API v2.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PrintJob
    /// </summary>
    [DataContract]
    public partial class PrintJob :  IEquatable<PrintJob>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public JobStatus? Status { get; set; }
        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public PrintJobOrientation? Orientation { get; set; }
        /// <summary>
        /// Gets or Sets PrintFormat
        /// </summary>
        [DataMember(Name="printFormat", EmitDefaultValue=false)]
        public PrintPDFFormat? PrintFormat { get; set; }
        /// <summary>
        /// Gets or Sets FileNameOrder
        /// </summary>
        [DataMember(Name="fileNameOrder", EmitDefaultValue=false)]
        public FileOrderSetting? FileNameOrder { get; set; }
        /// <summary>
        /// Gets or Sets StampingChoice
        /// </summary>
        [DataMember(Name="stampingChoice", EmitDefaultValue=false)]
        public StampingChoice? StampingChoice { get; set; }
        /// <summary>
        /// Gets or Sets IncludeRedactions
        /// </summary>
        [DataMember(Name="includeRedactions", EmitDefaultValue=false)]
        public PrintIncludeRedactions? IncludeRedactions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJob" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CreatedByUserId">CreatedByUserId.</param>
        /// <param name="NumberOfDocuments">NumberOfDocuments.</param>
        /// <param name="CreatedByUserName">CreatedByUserName.</param>
        /// <param name="CreatedDateTime">CreatedDateTime.</param>
        /// <param name="Status">Status.</param>
        /// <param name="IsDeleted">IsDeleted.</param>
        /// <param name="TagProfileId">TagProfileId.</param>
        /// <param name="NumberOfErrors">NumberOfErrors.</param>
        /// <param name="NumberOfDocumentsProcessed">NumberOfDocumentsProcessed.</param>
        /// <param name="LastUpdatedDateTime">LastUpdatedDateTime.</param>
        /// <param name="StartDateTime">StartDateTime.</param>
        /// <param name="EndDateTime">EndDateTime.</param>
        /// <param name="JobInfoMessage">JobInfoMessage.</param>
        /// <param name="PagesToPrint">PagesToPrint.</param>
        /// <param name="DownloadFileName">DownloadFileName.</param>
        /// <param name="DownloadFileSize">DownloadFileSize.</param>
        /// <param name="Name">Name.</param>
        /// <param name="IncludeSlipsheet">IncludeSlipsheet.</param>
        /// <param name="IncludeTranscriptWordList">IncludeTranscriptWordList.</param>
        /// <param name="Orientation">Orientation.</param>
        /// <param name="PrintFormat">PrintFormat.</param>
        /// <param name="FileNameOrder">FileNameOrder.</param>
        /// <param name="ImageSetId">ImageSetId.</param>
        /// <param name="UseOriginalImageIfMissing">UseOriginalImageIfMissing.</param>
        /// <param name="ColorDetectionSettings">ColorDetectionSettings.</param>
        /// <param name="ImagingTemplateId">ImagingTemplateId.</param>
        /// <param name="SearchablePDFs">SearchablePDFs.</param>
        /// <param name="StampingChoice">StampingChoice.</param>
        /// <param name="Stamping">Stamping.</param>
        /// <param name="IncludeRedactions">IncludeRedactions.</param>
        /// <param name="AnnotationsToInclude">AnnotationsToInclude.</param>
        /// <param name="RedactionsProfiles">RedactionsProfiles.</param>
        public PrintJob(int? Id = default(int?), int? CreatedByUserId = default(int?), int? NumberOfDocuments = default(int?), string CreatedByUserName = default(string), DateTime? CreatedDateTime = default(DateTime?), JobStatus? Status = default(JobStatus?), bool? IsDeleted = default(bool?), int? TagProfileId = default(int?), int? NumberOfErrors = default(int?), int? NumberOfDocumentsProcessed = default(int?), DateTime? LastUpdatedDateTime = default(DateTime?), DateTime? StartDateTime = default(DateTime?), DateTime? EndDateTime = default(DateTime?), string JobInfoMessage = default(string), int? PagesToPrint = default(int?), string DownloadFileName = default(string), long? DownloadFileSize = default(long?), string Name = default(string), bool? IncludeSlipsheet = default(bool?), bool? IncludeTranscriptWordList = default(bool?), PrintJobOrientation? Orientation = default(PrintJobOrientation?), PrintPDFFormat? PrintFormat = default(PrintPDFFormat?), FileOrderSetting? FileNameOrder = default(FileOrderSetting?), int? ImageSetId = default(int?), bool? UseOriginalImageIfMissing = default(bool?), ColorDetectionSettings ColorDetectionSettings = default(ColorDetectionSettings), int? ImagingTemplateId = default(int?), bool? SearchablePDFs = default(bool?), StampingChoice? StampingChoice = default(StampingChoice?), StampingSpec Stamping = default(StampingSpec), PrintIncludeRedactions? IncludeRedactions = default(PrintIncludeRedactions?), List<AnnotationType> AnnotationsToInclude = default(List<AnnotationType>), List<int?> RedactionsProfiles = default(List<int?>))
        {
            this.Id = Id;
            this.CreatedByUserId = CreatedByUserId;
            this.NumberOfDocuments = NumberOfDocuments;
            this.CreatedByUserName = CreatedByUserName;
            this.CreatedDateTime = CreatedDateTime;
            this.Status = Status;
            this.IsDeleted = IsDeleted;
            this.TagProfileId = TagProfileId;
            this.NumberOfErrors = NumberOfErrors;
            this.NumberOfDocumentsProcessed = NumberOfDocumentsProcessed;
            this.LastUpdatedDateTime = LastUpdatedDateTime;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.JobInfoMessage = JobInfoMessage;
            this.PagesToPrint = PagesToPrint;
            this.DownloadFileName = DownloadFileName;
            this.DownloadFileSize = DownloadFileSize;
            this.Name = Name;
            this.IncludeSlipsheet = IncludeSlipsheet;
            this.IncludeTranscriptWordList = IncludeTranscriptWordList;
            this.Orientation = Orientation;
            this.PrintFormat = PrintFormat;
            this.FileNameOrder = FileNameOrder;
            this.ImageSetId = ImageSetId;
            this.UseOriginalImageIfMissing = UseOriginalImageIfMissing;
            this.ColorDetectionSettings = ColorDetectionSettings;
            this.ImagingTemplateId = ImagingTemplateId;
            this.SearchablePDFs = SearchablePDFs;
            this.StampingChoice = StampingChoice;
            this.Stamping = Stamping;
            this.IncludeRedactions = IncludeRedactions;
            this.AnnotationsToInclude = AnnotationsToInclude;
            this.RedactionsProfiles = RedactionsProfiles;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDocuments
        /// </summary>
        [DataMember(Name="numberOfDocuments", EmitDefaultValue=false)]
        public int? NumberOfDocuments { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserName
        /// </summary>
        [DataMember(Name="createdByUserName", EmitDefaultValue=false)]
        public string CreatedByUserName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }


        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets TagProfileId
        /// </summary>
        [DataMember(Name="tagProfileId", EmitDefaultValue=false)]
        public int? TagProfileId { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfErrors
        /// </summary>
        [DataMember(Name="numberOfErrors", EmitDefaultValue=false)]
        public int? NumberOfErrors { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDocumentsProcessed
        /// </summary>
        [DataMember(Name="numberOfDocumentsProcessed", EmitDefaultValue=false)]
        public int? NumberOfDocumentsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDateTime
        /// </summary>
        [DataMember(Name="lastUpdatedDateTime", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets JobInfoMessage
        /// </summary>
        [DataMember(Name="jobInfoMessage", EmitDefaultValue=false)]
        public string JobInfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets PagesToPrint
        /// </summary>
        [DataMember(Name="pagesToPrint", EmitDefaultValue=false)]
        public int? PagesToPrint { get; set; }

        /// <summary>
        /// Gets or Sets DownloadFileName
        /// </summary>
        [DataMember(Name="downloadFileName", EmitDefaultValue=false)]
        public string DownloadFileName { get; set; }

        /// <summary>
        /// Gets or Sets DownloadFileSize
        /// </summary>
        [DataMember(Name="downloadFileSize", EmitDefaultValue=false)]
        public long? DownloadFileSize { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSlipsheet
        /// </summary>
        [DataMember(Name="includeSlipsheet", EmitDefaultValue=false)]
        public bool? IncludeSlipsheet { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTranscriptWordList
        /// </summary>
        [DataMember(Name="includeTranscriptWordList", EmitDefaultValue=false)]
        public bool? IncludeTranscriptWordList { get; set; }




        /// <summary>
        /// Gets or Sets ImageSetId
        /// </summary>
        [DataMember(Name="imageSetId", EmitDefaultValue=false)]
        public int? ImageSetId { get; set; }

        /// <summary>
        /// Gets or Sets UseOriginalImageIfMissing
        /// </summary>
        [DataMember(Name="useOriginalImageIfMissing", EmitDefaultValue=false)]
        public bool? UseOriginalImageIfMissing { get; set; }

        /// <summary>
        /// Gets or Sets ColorDetectionSettings
        /// </summary>
        [DataMember(Name="colorDetectionSettings", EmitDefaultValue=false)]
        public ColorDetectionSettings ColorDetectionSettings { get; set; }

        /// <summary>
        /// Gets or Sets ImagingTemplateId
        /// </summary>
        [DataMember(Name="imagingTemplateId", EmitDefaultValue=false)]
        public int? ImagingTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets SearchablePDFs
        /// </summary>
        [DataMember(Name="searchablePDFs", EmitDefaultValue=false)]
        public bool? SearchablePDFs { get; set; }


        /// <summary>
        /// Gets or Sets Stamping
        /// </summary>
        [DataMember(Name="stamping", EmitDefaultValue=false)]
        public StampingSpec Stamping { get; set; }


        /// <summary>
        /// Gets or Sets AnnotationsToInclude
        /// </summary>
        [DataMember(Name="annotationsToInclude", EmitDefaultValue=false)]
        public List<AnnotationType> AnnotationsToInclude { get; set; }

        /// <summary>
        /// Gets or Sets RedactionsProfiles
        /// </summary>
        [DataMember(Name="redactionsProfiles", EmitDefaultValue=false)]
        public List<int?> RedactionsProfiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrintJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  NumberOfDocuments: ").Append(NumberOfDocuments).Append("\n");
            sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  TagProfileId: ").Append(TagProfileId).Append("\n");
            sb.Append("  NumberOfErrors: ").Append(NumberOfErrors).Append("\n");
            sb.Append("  NumberOfDocumentsProcessed: ").Append(NumberOfDocumentsProcessed).Append("\n");
            sb.Append("  LastUpdatedDateTime: ").Append(LastUpdatedDateTime).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  JobInfoMessage: ").Append(JobInfoMessage).Append("\n");
            sb.Append("  PagesToPrint: ").Append(PagesToPrint).Append("\n");
            sb.Append("  DownloadFileName: ").Append(DownloadFileName).Append("\n");
            sb.Append("  DownloadFileSize: ").Append(DownloadFileSize).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IncludeSlipsheet: ").Append(IncludeSlipsheet).Append("\n");
            sb.Append("  IncludeTranscriptWordList: ").Append(IncludeTranscriptWordList).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  PrintFormat: ").Append(PrintFormat).Append("\n");
            sb.Append("  FileNameOrder: ").Append(FileNameOrder).Append("\n");
            sb.Append("  ImageSetId: ").Append(ImageSetId).Append("\n");
            sb.Append("  UseOriginalImageIfMissing: ").Append(UseOriginalImageIfMissing).Append("\n");
            sb.Append("  ColorDetectionSettings: ").Append(ColorDetectionSettings).Append("\n");
            sb.Append("  ImagingTemplateId: ").Append(ImagingTemplateId).Append("\n");
            sb.Append("  SearchablePDFs: ").Append(SearchablePDFs).Append("\n");
            sb.Append("  StampingChoice: ").Append(StampingChoice).Append("\n");
            sb.Append("  Stamping: ").Append(Stamping).Append("\n");
            sb.Append("  IncludeRedactions: ").Append(IncludeRedactions).Append("\n");
            sb.Append("  AnnotationsToInclude: ").Append(AnnotationsToInclude).Append("\n");
            sb.Append("  RedactionsProfiles: ").Append(RedactionsProfiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrintJob);
        }

        /// <summary>
        /// Returns true if PrintJob instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.NumberOfDocuments == input.NumberOfDocuments ||
                    (this.NumberOfDocuments != null &&
                    this.NumberOfDocuments.Equals(input.NumberOfDocuments))
                ) && 
                (
                    this.CreatedByUserName == input.CreatedByUserName ||
                    (this.CreatedByUserName != null &&
                    this.CreatedByUserName.Equals(input.CreatedByUserName))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.TagProfileId == input.TagProfileId ||
                    (this.TagProfileId != null &&
                    this.TagProfileId.Equals(input.TagProfileId))
                ) && 
                (
                    this.NumberOfErrors == input.NumberOfErrors ||
                    (this.NumberOfErrors != null &&
                    this.NumberOfErrors.Equals(input.NumberOfErrors))
                ) && 
                (
                    this.NumberOfDocumentsProcessed == input.NumberOfDocumentsProcessed ||
                    (this.NumberOfDocumentsProcessed != null &&
                    this.NumberOfDocumentsProcessed.Equals(input.NumberOfDocumentsProcessed))
                ) && 
                (
                    this.LastUpdatedDateTime == input.LastUpdatedDateTime ||
                    (this.LastUpdatedDateTime != null &&
                    this.LastUpdatedDateTime.Equals(input.LastUpdatedDateTime))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.JobInfoMessage == input.JobInfoMessage ||
                    (this.JobInfoMessage != null &&
                    this.JobInfoMessage.Equals(input.JobInfoMessage))
                ) && 
                (
                    this.PagesToPrint == input.PagesToPrint ||
                    (this.PagesToPrint != null &&
                    this.PagesToPrint.Equals(input.PagesToPrint))
                ) && 
                (
                    this.DownloadFileName == input.DownloadFileName ||
                    (this.DownloadFileName != null &&
                    this.DownloadFileName.Equals(input.DownloadFileName))
                ) && 
                (
                    this.DownloadFileSize == input.DownloadFileSize ||
                    (this.DownloadFileSize != null &&
                    this.DownloadFileSize.Equals(input.DownloadFileSize))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IncludeSlipsheet == input.IncludeSlipsheet ||
                    (this.IncludeSlipsheet != null &&
                    this.IncludeSlipsheet.Equals(input.IncludeSlipsheet))
                ) && 
                (
                    this.IncludeTranscriptWordList == input.IncludeTranscriptWordList ||
                    (this.IncludeTranscriptWordList != null &&
                    this.IncludeTranscriptWordList.Equals(input.IncludeTranscriptWordList))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.PrintFormat == input.PrintFormat ||
                    (this.PrintFormat != null &&
                    this.PrintFormat.Equals(input.PrintFormat))
                ) && 
                (
                    this.FileNameOrder == input.FileNameOrder ||
                    (this.FileNameOrder != null &&
                    this.FileNameOrder.Equals(input.FileNameOrder))
                ) && 
                (
                    this.ImageSetId == input.ImageSetId ||
                    (this.ImageSetId != null &&
                    this.ImageSetId.Equals(input.ImageSetId))
                ) && 
                (
                    this.UseOriginalImageIfMissing == input.UseOriginalImageIfMissing ||
                    (this.UseOriginalImageIfMissing != null &&
                    this.UseOriginalImageIfMissing.Equals(input.UseOriginalImageIfMissing))
                ) && 
                (
                    this.ColorDetectionSettings == input.ColorDetectionSettings ||
                    (this.ColorDetectionSettings != null &&
                    this.ColorDetectionSettings.Equals(input.ColorDetectionSettings))
                ) && 
                (
                    this.ImagingTemplateId == input.ImagingTemplateId ||
                    (this.ImagingTemplateId != null &&
                    this.ImagingTemplateId.Equals(input.ImagingTemplateId))
                ) && 
                (
                    this.SearchablePDFs == input.SearchablePDFs ||
                    (this.SearchablePDFs != null &&
                    this.SearchablePDFs.Equals(input.SearchablePDFs))
                ) && 
                (
                    this.StampingChoice == input.StampingChoice ||
                    (this.StampingChoice != null &&
                    this.StampingChoice.Equals(input.StampingChoice))
                ) && 
                (
                    this.Stamping == input.Stamping ||
                    (this.Stamping != null &&
                    this.Stamping.Equals(input.Stamping))
                ) && 
                (
                    this.IncludeRedactions == input.IncludeRedactions ||
                    (this.IncludeRedactions != null &&
                    this.IncludeRedactions.Equals(input.IncludeRedactions))
                ) && 
                (
                    this.AnnotationsToInclude == input.AnnotationsToInclude ||
                    this.AnnotationsToInclude != null &&
                    this.AnnotationsToInclude.SequenceEqual(input.AnnotationsToInclude)
                ) && 
                (
                    this.RedactionsProfiles == input.RedactionsProfiles ||
                    this.RedactionsProfiles != null &&
                    this.RedactionsProfiles.SequenceEqual(input.RedactionsProfiles)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.NumberOfDocuments != null)
                    hashCode = hashCode * 59 + this.NumberOfDocuments.GetHashCode();
                if (this.CreatedByUserName != null)
                    hashCode = hashCode * 59 + this.CreatedByUserName.GetHashCode();
                if (this.CreatedDateTime != null)
                    hashCode = hashCode * 59 + this.CreatedDateTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.TagProfileId != null)
                    hashCode = hashCode * 59 + this.TagProfileId.GetHashCode();
                if (this.NumberOfErrors != null)
                    hashCode = hashCode * 59 + this.NumberOfErrors.GetHashCode();
                if (this.NumberOfDocumentsProcessed != null)
                    hashCode = hashCode * 59 + this.NumberOfDocumentsProcessed.GetHashCode();
                if (this.LastUpdatedDateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDateTime.GetHashCode();
                if (this.StartDateTime != null)
                    hashCode = hashCode * 59 + this.StartDateTime.GetHashCode();
                if (this.EndDateTime != null)
                    hashCode = hashCode * 59 + this.EndDateTime.GetHashCode();
                if (this.JobInfoMessage != null)
                    hashCode = hashCode * 59 + this.JobInfoMessage.GetHashCode();
                if (this.PagesToPrint != null)
                    hashCode = hashCode * 59 + this.PagesToPrint.GetHashCode();
                if (this.DownloadFileName != null)
                    hashCode = hashCode * 59 + this.DownloadFileName.GetHashCode();
                if (this.DownloadFileSize != null)
                    hashCode = hashCode * 59 + this.DownloadFileSize.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IncludeSlipsheet != null)
                    hashCode = hashCode * 59 + this.IncludeSlipsheet.GetHashCode();
                if (this.IncludeTranscriptWordList != null)
                    hashCode = hashCode * 59 + this.IncludeTranscriptWordList.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.PrintFormat != null)
                    hashCode = hashCode * 59 + this.PrintFormat.GetHashCode();
                if (this.FileNameOrder != null)
                    hashCode = hashCode * 59 + this.FileNameOrder.GetHashCode();
                if (this.ImageSetId != null)
                    hashCode = hashCode * 59 + this.ImageSetId.GetHashCode();
                if (this.UseOriginalImageIfMissing != null)
                    hashCode = hashCode * 59 + this.UseOriginalImageIfMissing.GetHashCode();
                if (this.ColorDetectionSettings != null)
                    hashCode = hashCode * 59 + this.ColorDetectionSettings.GetHashCode();
                if (this.ImagingTemplateId != null)
                    hashCode = hashCode * 59 + this.ImagingTemplateId.GetHashCode();
                if (this.SearchablePDFs != null)
                    hashCode = hashCode * 59 + this.SearchablePDFs.GetHashCode();
                if (this.StampingChoice != null)
                    hashCode = hashCode * 59 + this.StampingChoice.GetHashCode();
                if (this.Stamping != null)
                    hashCode = hashCode * 59 + this.Stamping.GetHashCode();
                if (this.IncludeRedactions != null)
                    hashCode = hashCode * 59 + this.IncludeRedactions.GetHashCode();
                if (this.AnnotationsToInclude != null)
                    hashCode = hashCode * 59 + this.AnnotationsToInclude.GetHashCode();
                if (this.RedactionsProfiles != null)
                    hashCode = hashCode * 59 + this.RedactionsProfiles.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
