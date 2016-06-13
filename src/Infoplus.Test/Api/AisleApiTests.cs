/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v1.0
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
    ///  Class for testing AisleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AisleApiTests
    {
        private AisleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AisleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AisleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AisleApi
            Assert.IsInstanceOfType(typeof(AisleApi), instance, "instance is a AisleApi");
        }

        
        /// <summary>
        /// Test AddAisle
        /// </summary>
        [Test]
        public void AddAisleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Aisle body = null;
            //var response = instance.AddAisle(body);
            //Assert.IsInstanceOf<Aisle> (response, "response is Aisle");
        }
        
        /// <summary>
        /// Test DeleteAisle
        /// </summary>
        [Test]
        public void DeleteAisleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? aisleId = null;
            //instance.DeleteAisle(aisleId);
            
        }
        
        /// <summary>
        /// Test GetAisleByFilter
        /// </summary>
        [Test]
        public void GetAisleByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetAisleByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Aisle>> (response, "response is List<Aisle>");
        }
        
        /// <summary>
        /// Test GetAisleById
        /// </summary>
        [Test]
        public void GetAisleByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? aisleId = null;
            //var response = instance.GetAisleById(aisleId);
            //Assert.IsInstanceOf<Aisle> (response, "response is Aisle");
        }
        
        /// <summary>
        /// Test UpdateAisle
        /// </summary>
        [Test]
        public void UpdateAisleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Aisle body = null;
            //instance.UpdateAisle(body);
            
        }
        
    }

}