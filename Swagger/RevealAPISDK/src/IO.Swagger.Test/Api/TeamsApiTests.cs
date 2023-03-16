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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamsApiTests
    {
        private TeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamsApi
            //Assert.IsInstanceOfType(typeof(TeamsApi), instance, "instance is a TeamsApi");
        }

        
        /// <summary>
        /// Test TeamV2DeleteById
        /// </summary>
        [Test]
        public void TeamV2DeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //instance.TeamV2DeleteById(caseId, id);
            
        }
        
        /// <summary>
        /// Test TeamV2DeleteByName
        /// </summary>
        [Test]
        public void TeamV2DeleteByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //string name = null;
            //instance.TeamV2DeleteByName(caseId, name);
            
        }
        
        /// <summary>
        /// Test TeamV2GetMembers
        /// </summary>
        [Test]
        public void TeamV2GetMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //var response = instance.TeamV2GetMembers(caseId, id);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamV2GetTeamById
        /// </summary>
        [Test]
        public void TeamV2GetTeamByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? id = null;
            //var response = instance.TeamV2GetTeamById(caseId, id);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamV2GetTeamByName
        /// </summary>
        [Test]
        public void TeamV2GetTeamByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //string name = null;
            //int? userId = null;
            //var response = instance.TeamV2GetTeamByName(caseId, name, userId);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamV2GetTeams
        /// </summary>
        [Test]
        public void TeamV2GetTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //int? userId = null;
            //int? start = null;
            //int? count = null;
            //var response = instance.TeamV2GetTeams(caseId, userId, start, count);
            //Assert.IsInstanceOf<PaginatedOfListOfTeam> (response, "response is PaginatedOfListOfTeam");
        }
        
        /// <summary>
        /// Test TeamV2Post
        /// </summary>
        [Test]
        public void TeamV2PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //TeamCreate body = null;
            //var response = instance.TeamV2Post(caseId, body);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamV2SetMembers
        /// </summary>
        [Test]
        public void TeamV2SetMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? caseId = null;
            //string id = null;
            //List<MemberStatus> body = null;
            //instance.TeamV2SetMembers(caseId, id, body);
            
        }
        
    }

}
