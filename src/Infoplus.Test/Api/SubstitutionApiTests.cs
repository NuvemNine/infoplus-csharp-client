/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Infoplus.Client;
using Infoplus.Api;
using Infoplus.Model;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing SubstitutionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubstitutionApiTests
    {
        private SubstitutionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubstitutionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubstitutionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' SubstitutionApi
            Assert.IsInstanceOfType(typeof(SubstitutionApi), instance, "instance is a SubstitutionApi");
        }

        
        /// <summary>
        /// Test AddSubstitution
        /// </summary>
        [Test]
        public void AddSubstitutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Substitution body = null;
            //var response = instance.AddSubstitution(body);
            //Assert.IsInstanceOf<Substitution> (response, "response is Substitution");
        }
        
        /// <summary>
        /// Test DeleteSubstitution
        /// </summary>
        [Test]
        public void DeleteSubstitutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? substitutionId = null;
            //instance.DeleteSubstitution(substitutionId);
            
        }
        
        /// <summary>
        /// Test GetSubstitutionByFilter
        /// </summary>
        [Test]
        public void GetSubstitutionByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetSubstitutionByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Substitution>> (response, "response is List<Substitution>");
        }
        
        /// <summary>
        /// Test GetSubstitutionById
        /// </summary>
        [Test]
        public void GetSubstitutionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? substitutionId = null;
            //var response = instance.GetSubstitutionById(substitutionId);
            //Assert.IsInstanceOf<Substitution> (response, "response is Substitution");
        }
        
        /// <summary>
        /// Test UpdateSubstitution
        /// </summary>
        [Test]
        public void UpdateSubstitutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Substitution body = null;
            //instance.UpdateSubstitution(body);
            
        }
        
        /// <summary>
        /// Test UpdateSubstitutionCustomFields
        /// </summary>
        [Test]
        public void UpdateSubstitutionCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Substitution body = null;
            //instance.UpdateSubstitutionCustomFields(body);
            
        }
        
    }

}