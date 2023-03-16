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
    ///  Class for testing JobshitReportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobshitReportApiTests
    {
        private JobshitReportApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobshitReportApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobshitReportApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobshitReportApi
            //Assert.IsInstanceOfType(typeof(JobshitReportApi), instance, "instance is a JobshitReportApi");
        }

        
        /// <summary>
        /// Test HitReportCreate
        /// </summary>
        [Test]
        public void HitReportCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //HitReportJob body = null;
            //var response = instance.HitReportCreate(caseId, body);
            //Assert.IsInstanceOf<HitReportJob> (response, "response is HitReportJob");
        }
        
        /// <summary>
        /// Test HitReportDelete
        /// </summary>
        [Test]
        public void HitReportDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //instance.HitReportDelete(caseId, id);
            
        }
        
        /// <summary>
        /// Test HitReportGet
        /// </summary>
        [Test]
        public void HitReportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //var response = instance.HitReportGet(caseId, id);
            //Assert.IsInstanceOf<HitReportJob> (response, "response is HitReportJob");
        }
        
        /// <summary>
        /// Test HitReportGetAll
        /// </summary>
        [Test]
        public void HitReportGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.HitReportGetAll(caseId, start, count);
            //Assert.IsInstanceOf<PaginatedOfIEnumerableOfHitReportJob> (response, "response is PaginatedOfIEnumerableOfHitReportJob");
        }
        
    }

}
