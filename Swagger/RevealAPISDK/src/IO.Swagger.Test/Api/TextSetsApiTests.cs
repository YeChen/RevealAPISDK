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
    ///  Class for testing TextSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TextSetsApiTests
    {
        private TextSetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TextSetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TextSetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TextSetsApi
            //Assert.IsInstanceOfType(typeof(TextSetsApi), instance, "instance is a TextSetsApi");
        }

        
        /// <summary>
        /// Test DocumentTextSetsCreateTextSet
        /// </summary>
        [Test]
        public void DocumentTextSetsCreateTextSetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //DocumentTextSetCreate body = null;
            //var response = instance.DocumentTextSetsCreateTextSet(caseId, body);
            //Assert.IsInstanceOf<DocumentTextSet> (response, "response is DocumentTextSet");
        }
        
        /// <summary>
        /// Test DocumentTextSetsGet
        /// </summary>
        [Test]
        public void DocumentTextSetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.DocumentTextSetsGet(caseId, start, count);
            //Assert.IsInstanceOf<PaginatedOfListOfDocumentTextSet2> (response, "response is PaginatedOfListOfDocumentTextSet2");
        }
        
        /// <summary>
        /// Test DocumentTextSetsGetCreateTextSetFormData
        /// </summary>
        [Test]
        public void DocumentTextSetsGetCreateTextSetFormDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //var response = instance.DocumentTextSetsGetCreateTextSetFormData(caseId);
            //Assert.IsInstanceOf<BulkActionForm> (response, "response is BulkActionForm");
        }
        
    }

}
