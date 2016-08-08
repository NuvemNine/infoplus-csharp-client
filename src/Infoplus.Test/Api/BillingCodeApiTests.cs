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
    ///  Class for testing BillingCodeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingCodeApiTests
    {
        private BillingCodeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingCodeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingCodeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' BillingCodeApi
            Assert.IsInstanceOfType(typeof(BillingCodeApi), instance, "instance is a BillingCodeApi");
        }

        
        /// <summary>
        /// Test AddBillingCode
        /// </summary>
        [Test]
        public void AddBillingCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCode body = null;
            //var response = instance.AddBillingCode(body);
            //Assert.IsInstanceOf<BillingCode> (response, "response is BillingCode");
        }
        
        /// <summary>
        /// Test DeleteBillingCode
        /// </summary>
        [Test]
        public void DeleteBillingCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeId = null;
            //instance.DeleteBillingCode(billingCodeId);
            
        }
        
        /// <summary>
        /// Test GetBillingCodeByFilter
        /// </summary>
        [Test]
        public void GetBillingCodeByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetBillingCodeByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<BillingCode>> (response, "response is List<BillingCode>");
        }
        
        /// <summary>
        /// Test GetBillingCodeById
        /// </summary>
        [Test]
        public void GetBillingCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? billingCodeId = null;
            //var response = instance.GetBillingCodeById(billingCodeId);
            //Assert.IsInstanceOf<BillingCode> (response, "response is BillingCode");
        }
        
        /// <summary>
        /// Test UpdateBillingCode
        /// </summary>
        [Test]
        public void UpdateBillingCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCode body = null;
            //instance.UpdateBillingCode(body);
            
        }
        
        /// <summary>
        /// Test UpdateBillingCodeCustomFields
        /// </summary>
        [Test]
        public void UpdateBillingCodeCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillingCode body = null;
            //instance.UpdateBillingCodeCustomFields(body);
            
        }
        
    }

}