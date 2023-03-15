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
using SwaggerDateConverter = RevealAPI.Sdk.Client.SwaggerDateConverter;

namespace RevealAPI.Sdk.Models.Resources
{
    /// <summary>
    /// Defines FolderItemType
    /// </summary>
    
    public enum FolderItemType
    {
        
        /// <summary>
        /// Enum Work for value: Work
        /// </summary>
        
        Work = Work,
        
        /// <summary>
        /// Enum Document for value: Document
        /// </summary>
        
        Document = Document,
        
        /// <summary>
        /// Enum Assignment for value: Assignment
        /// </summary>
        
        Assignment = Assignment,
        
        /// <summary>
        /// Enum Transcript for value: Transcript
        /// </summary>
        
        Transcript = Transcript,
        
        /// <summary>
        /// Enum Imports for value: Imports
        /// </summary>
        
        Imports = Imports,
        
        /// <summary>
        /// Enum SecuredByTeam for value: SecuredByTeam
        /// </summary>
        
        SecuredByTeam = SecuredByTeam,
        
        /// <summary>
        /// Enum SecuredByUser for value: SecuredByUser
        /// </summary>
        
        SecuredByUser = SecuredByUser,
        
        /// <summary>
        /// Enum Unsecured for value: Unsecured
        /// </summary>
        
        Unsecured = Unsecured,
        
        /// <summary>
        /// Enum Redaction for value: Redaction
        /// </summary>
        
        Redaction = Redaction,
        
        /// <summary>
        /// Enum AssignmentByBatch for value: AssignmentByBatch
        /// </summary>
        
        AssignmentByBatch = AssignmentByBatch,
        
        /// <summary>
        /// Enum AssignmentByCustodian for value: AssignmentByCustodian
        /// </summary>
        
        AssignmentByCustodian = AssignmentByCustodian,
        
        /// <summary>
        /// Enum AssignmentByJob for value: AssignmentByJob
        /// </summary>
        
        AssignmentByJob = AssignmentByJob,
        
        /// <summary>
        /// Enum AssignmentByFolderIsReviewed for value: AssignmentByFolderIsReviewed
        /// </summary>
        
        AssignmentByFolderIsReviewed = AssignmentByFolderIsReviewed,
        
        /// <summary>
        /// Enum AssignmentByFolderIsNotReviewed for value: AssignmentByFolderIsNotReviewed
        /// </summary>
        
        AssignmentByFolderIsNotReviewed = AssignmentByFolderIsNotReviewed,
        
        /// <summary>
        /// Enum AssignmentByJobIsReviewed for value: AssignmentByJobIsReviewed
        /// </summary>
        
        AssignmentByJobIsReviewed = AssignmentByJobIsReviewed,
        
        /// <summary>
        /// Enum AssignmentByJobIsNotReviewed for value: AssignmentByJobIsNotReviewed
        /// </summary>
        
        AssignmentByJobIsNotReviewed = AssignmentByJobIsNotReviewed,
        
        /// <summary>
        /// Enum TagProfileIsReviewed for value: TagProfileIsReviewed
        /// </summary>
        
        TagProfileIsReviewed = TagProfileIsReviewed,
        
        /// <summary>
        /// Enum TagProfileIsNotReviewed for value: TagProfileIsNotReviewed
        /// </summary>
        
        TagProfileIsNotReviewed = TagProfileIsNotReviewed,
        
        /// <summary>
        /// Enum SavedSearch for value: SavedSearch
        /// </summary>
        
        SavedSearch = SavedSearch,
        
        /// <summary>
        /// Enum SearchHistory for value: SearchHistory
        /// </summary>
        
        SearchHistory = SearchHistory,
        
        /// <summary>
        /// Enum AdminView for value: AdminView
        /// </summary>
        
        AdminView = AdminView,
        
        /// <summary>
        /// Enum SearchView for value: SearchView
        /// </summary>
        
        SearchView = SearchView,
        
        /// <summary>
        /// Enum Secured for value: Secured
        /// </summary>
        
        Secured = Secured,
        
        /// <summary>
        /// Enum AssignmentLabel for value: AssignmentLabel
        /// </summary>
        
        AssignmentLabel = AssignmentLabel,
        
        /// <summary>
        /// Enum AssignmentByBatchFolder for value: AssignmentByBatchFolder
        /// </summary>
        
        AssignmentByBatchFolder = AssignmentByBatchFolder,
        
        /// <summary>
        /// Enum AssignmentByReviewer for value: AssignmentByReviewer
        /// </summary>
        
        AssignmentByReviewer = AssignmentByReviewer,
        
        /// <summary>
        /// Enum WorkByUser for value: WorkByUser
        /// </summary>
        
        WorkByUser = WorkByUser,
        
        /// <summary>
        /// Enum WorkFolderAll for value: WorkFolderAll
        /// </summary>
        
        WorkFolderAll = WorkFolderAll,
        
        /// <summary>
        /// Enum TranscriptByUser for value: TranscriptByUser
        /// </summary>
        
        TranscriptByUser = TranscriptByUser,
        
        /// <summary>
        /// Enum TranscriptAll for value: TranscriptAll
        /// </summary>
        
        TranscriptAll = TranscriptAll,
        
        /// <summary>
        /// Enum RedactionByUser for value: RedactionByUser
        /// </summary>
        
        RedactionByUser = RedactionByUser,
        
        /// <summary>
        /// Enum RedactionAll for value: RedactionAll
        /// </summary>
        
        RedactionAll = RedactionAll,
        
        /// <summary>
        /// Enum SavedSearchByUser for value: SavedSearchByUser
        /// </summary>
        
        SavedSearchByUser = SavedSearchByUser,
        
        /// <summary>
        /// Enum SavedSearchAll for value: SavedSearchAll
        /// </summary>
        
        SavedSearchAll = SavedSearchAll,
        
        /// <summary>
        /// Enum Filter for value: Filter
        /// </summary>
        
        Filter = Filter,
        
        /// <summary>
        /// Enum AnnotationFilter for value: AnnotationFilter
        /// </summary>
        
        AnnotationFilter = AnnotationFilter,
        
        /// <summary>
        /// Enum TagFilter for value: TagFilter
        /// </summary>
        
        TagFilter = TagFilter,
        
        /// <summary>
        /// Enum PrivilegedTagFilter for value: PrivilegedTagFilter
        /// </summary>
        
        PrivilegedTagFilter = PrivilegedTagFilter,
        
        /// <summary>
        /// Enum DocumentStatusFilter for value: DocumentStatusFilter
        /// </summary>
        
        DocumentStatusFilter = DocumentStatusFilter,
        
        /// <summary>
        /// Enum OriginalFilter for value: OriginalFilter
        /// </summary>
        
        OriginalFilter = OriginalFilter,
        
        /// <summary>
        /// Enum DeduplicationFilter for value: DeduplicationFilter
        /// </summary>
        
        DeduplicationFilter = DeduplicationFilter,
        
        /// <summary>
        /// Enum CustodianFilter for value: CustodianFilter
        /// </summary>
        
        CustodianFilter = CustodianFilter,
        
        /// <summary>
        /// Enum FormatFilter for value: FormatFilter
        /// </summary>
        
        FormatFilter = FormatFilter,
        
        /// <summary>
        /// Enum ReviewStatusFilter for value: ReviewStatusFilter
        /// </summary>
        
        ReviewStatusFilter = ReviewStatusFilter,
        
        /// <summary>
        /// Enum PeopleFilter for value: PeopleFilter
        /// </summary>
        
        PeopleFilter = PeopleFilter,
        
        /// <summary>
        /// Enum EntitiesFilter for value: EntitiesFilter
        /// </summary>
        
        EntitiesFilter = EntitiesFilter,
        
        /// <summary>
        /// Enum SentimentFilter for value: SentimentFilter
        /// </summary>
        
        SentimentFilter = SentimentFilter
    }

}