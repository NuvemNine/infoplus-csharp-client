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
    ///  Class for testing ZoneApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ZoneApiTests
    {
        private ZoneApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ZoneApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZoneApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ZoneApi
            Assert.IsInstanceOfType(typeof(ZoneApi), instance, "instance is a ZoneApi");
        }

        
        /// <summary>
        /// Test AddZone
        /// </summary>
        [Test]
        public void AddZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Zone body = null;
            //var response = instance.AddZone(body);
            //Assert.IsInstanceOf<Zone> (response, "response is Zone");
        }
        
        /// <summary>
        /// Test DeleteZone
        /// </summary>
        [Test]
        public void DeleteZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? zoneId = null;
            //instance.DeleteZone(zoneId);
            
        }
        
        /// <summary>
        /// Test GetZoneByFilter
        /// </summary>
        [Test]
        public void GetZoneByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetZoneByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Zone>> (response, "response is List<Zone>");
        }
        
        /// <summary>
        /// Test GetZoneById
        /// </summary>
        [Test]
        public void GetZoneByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? zoneId = null;
            //var response = instance.GetZoneById(zoneId);
            //Assert.IsInstanceOf<Zone> (response, "response is Zone");
        }
        
        /// <summary>
        /// Test UpdateZone
        /// </summary>
        [Test]
        public void UpdateZoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Zone body = null;
            //instance.UpdateZone(body);
            
        }
        
        /// <summary>
        /// Test UpdateZoneCustomFields
        /// </summary>
        [Test]
        public void UpdateZoneCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Zone body = null;
            //instance.UpdateZoneCustomFields(body);
            
        }
        
    }

}