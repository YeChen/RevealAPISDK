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
    ///  Class for testing FolderssecuredApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FolderssecuredApiTests
    {
        private FolderssecuredApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FolderssecuredApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FolderssecuredApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FolderssecuredApi
            //Assert.IsInstanceOfType(typeof(FolderssecuredApi), instance, "instance is a FolderssecuredApi");
        }

        
        /// <summary>
        /// Test SecuredFoldersV2GetFolders
        /// </summary>
        [Test]
        public void SecuredFoldersV2GetFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? folderId = null;
            //int? userId = null;
            //string uniqueId = null;
            //bool? isAdminView = null;
            //var response = instance.SecuredFoldersV2GetFolders(caseId, folderId, userId, uniqueId, isAdminView);
            //Assert.IsInstanceOf<List<FolderItem>> (response, "response is List<FolderItem>");
        }
        
    }

}
