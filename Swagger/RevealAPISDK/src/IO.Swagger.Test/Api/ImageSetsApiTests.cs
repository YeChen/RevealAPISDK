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
    ///  Class for testing ImageSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImageSetsApiTests
    {
        private ImageSetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageSetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageSetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImageSetsApi
            //Assert.IsInstanceOfType(typeof(ImageSetsApi), instance, "instance is a ImageSetsApi");
        }

        
        /// <summary>
        /// Test ImageSetV2Get
        /// </summary>
        [Test]
        public void ImageSetV2GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //var response = instance.ImageSetV2Get(caseId, id);
            //Assert.IsInstanceOf<ImageSet> (response, "response is ImageSet");
        }
        
        /// <summary>
        /// Test ImageSetV2GetList
        /// </summary>
        [Test]
        public void ImageSetV2GetListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.ImageSetV2GetList(caseId, start, count);
            //Assert.IsInstanceOf<PaginatedOfListOfImageSet> (response, "response is PaginatedOfListOfImageSet");
        }
        
        /// <summary>
        /// Test ImageSetV2Post
        /// </summary>
        [Test]
        public void ImageSetV2PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //ImageSetCreate body = null;
            //var response = instance.ImageSetV2Post(caseId, body);
            //Assert.IsInstanceOf<ImageSetCreate> (response, "response is ImageSetCreate");
        }
        
    }

}
