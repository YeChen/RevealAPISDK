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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ViewApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ViewApiTests
    {
        private ViewApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ViewApi
            //Assert.IsInstanceOfType(typeof(ViewApi), instance, "instance is a ViewApi");
        }

        
        /// <summary>
        /// Test ViewRouteGetJobsUrl
        /// </summary>
        [Test]
        public void ViewRouteGetJobsUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.ViewRouteGetJobsUrl(caseId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ViewRouteGetProjectAdminUrl
        /// </summary>
        [Test]
        public void ViewRouteGetProjectAdminUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.ViewRouteGetProjectAdminUrl(caseId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ViewRouteGetReportsUrl
        /// </summary>
        [Test]
        public void ViewRouteGetReportsUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.ViewRouteGetReportsUrl(caseId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ViewRouteGetReviewDocumentViewerUrl
        /// </summary>
        [Test]
        public void ViewRouteGetReviewDocumentViewerUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? docIndex = null;
            //int? gridPageIndex = null;
            //int? assignmentFolderId = null;
            //DocumentQuery body = null;
            //var response = instance.ViewRouteGetReviewDocumentViewerUrl(caseId, docIndex, gridPageIndex, assignmentFolderId, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ViewRouteGetReviewDocumentViewerUrl2
        /// </summary>
        [Test]
        public void ViewRouteGetReviewDocumentViewerUrl2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? assignmentFolderId = null;
            //DocumentViewerSearchCriteria body = null;
            //var response = instance.ViewRouteGetReviewDocumentViewerUrl2(caseId, assignmentFolderId, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ViewRouteGetTeamDocumentsUrl
        /// </summary>
        [Test]
        public void ViewRouteGetTeamDocumentsUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.ViewRouteGetTeamDocumentsUrl(caseId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
