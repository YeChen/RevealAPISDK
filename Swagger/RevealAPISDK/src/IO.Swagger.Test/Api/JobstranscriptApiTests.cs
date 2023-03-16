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
    ///  Class for testing JobstranscriptApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobstranscriptApiTests
    {
        private JobstranscriptApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobstranscriptApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobstranscriptApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobstranscriptApi
            //Assert.IsInstanceOfType(typeof(JobstranscriptApi), instance, "instance is a JobstranscriptApi");
        }

        
        /// <summary>
        /// Test TranscriptJobProcessTranscripts
        /// </summary>
        [Test]
        public void TranscriptJobProcessTranscriptsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //TranscriptJobCreate body = null;
            //var response = instance.TranscriptJobProcessTranscripts(caseId, body);
            //Assert.IsInstanceOf<CreateJobResponse> (response, "response is CreateJobResponse");
        }
        
    }

}