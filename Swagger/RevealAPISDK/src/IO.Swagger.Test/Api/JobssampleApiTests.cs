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
    ///  Class for testing JobssampleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobssampleApiTests
    {
        private JobssampleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobssampleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobssampleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobssampleApi
            //Assert.IsInstanceOfType(typeof(JobssampleApi), instance, "instance is a JobssampleApi");
        }

        
        /// <summary>
        /// Test SampleJobDelete
        /// </summary>
        [Test]
        public void SampleJobDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //instance.SampleJobDelete(caseId, id);
            
        }
        
        /// <summary>
        /// Test SampleJobGet
        /// </summary>
        [Test]
        public void SampleJobGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //var response = instance.SampleJobGet(caseId, id);
            //Assert.IsInstanceOf<SampleJob> (response, "response is SampleJob");
        }
        
        /// <summary>
        /// Test SampleJobGetList
        /// </summary>
        [Test]
        public void SampleJobGetListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? userId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.SampleJobGetList(caseId, userId, start, count);
            //Assert.IsInstanceOf<PaginatedOfIEnumerableOfSampleJob> (response, "response is PaginatedOfIEnumerableOfSampleJob");
        }
        
        /// <summary>
        /// Test SampleJobPost
        /// </summary>
        [Test]
        public void SampleJobPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //SampleJobCreate body = null;
            //var response = instance.SampleJobPost(caseId, body);
            //Assert.IsInstanceOf<CreateJobResponse> (response, "response is CreateJobResponse");
        }
        
    }

}