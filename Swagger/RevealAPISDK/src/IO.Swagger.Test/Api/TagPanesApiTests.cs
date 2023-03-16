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
    ///  Class for testing TagPanesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TagPanesApiTests
    {
        private TagPanesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TagPanesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TagPanesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TagPanesApi
            //Assert.IsInstanceOfType(typeof(TagPanesApi), instance, "instance is a TagPanesApi");
        }

        
        /// <summary>
        /// Test TagPanesUserProfilesGetAllTagPanes
        /// </summary>
        [Test]
        public void TagPanesUserProfilesGetAllTagPanesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.TagPanesUserProfilesGetAllTagPanes(caseId);
            //Assert.IsInstanceOf<List<TagPaneGet>> (response, "response is List<TagPaneGet>");
        }
        
        /// <summary>
        /// Test TagProfilePanesGetTagPane
        /// </summary>
        [Test]
        public void TagProfilePanesGetTagPaneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? profileId = null;
            //int? id = null;
            //int? userId = null;
            //var response = instance.TagProfilePanesGetTagPane(caseId, profileId, id, userId);
            //Assert.IsInstanceOf<TagPaneGet> (response, "response is TagPaneGet");
        }
        
        /// <summary>
        /// Test TagProfilePanesGetTagPanes
        /// </summary>
        [Test]
        public void TagProfilePanesGetTagPanesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? profileId = null;
            //int? userId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.TagProfilePanesGetTagPanes(caseId, profileId, userId, start, count);
            //Assert.IsInstanceOf<PaginatedOfIEnumerableOfTagPaneGet> (response, "response is PaginatedOfIEnumerableOfTagPaneGet");
        }
        
    }

}
