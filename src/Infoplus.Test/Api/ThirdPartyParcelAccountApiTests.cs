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
    ///  Class for testing ThirdPartyParcelAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ThirdPartyParcelAccountApiTests
    {
        private ThirdPartyParcelAccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ThirdPartyParcelAccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ThirdPartyParcelAccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ThirdPartyParcelAccountApi
            Assert.IsInstanceOfType(typeof(ThirdPartyParcelAccountApi), instance, "instance is a ThirdPartyParcelAccountApi");
        }

        
        /// <summary>
        /// Test AddThirdPartyParcelAccount
        /// </summary>
        [Test]
        public void AddThirdPartyParcelAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ThirdPartyParcelAccount body = null;
            //var response = instance.AddThirdPartyParcelAccount(body);
            //Assert.IsInstanceOf<ThirdPartyParcelAccount> (response, "response is ThirdPartyParcelAccount");
        }
        
        /// <summary>
        /// Test DeleteThirdPartyParcelAccount
        /// </summary>
        [Test]
        public void DeleteThirdPartyParcelAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? thirdPartyParcelAccountId = null;
            //instance.DeleteThirdPartyParcelAccount(thirdPartyParcelAccountId);
            
        }
        
        /// <summary>
        /// Test GetThirdPartyParcelAccountByFilter
        /// </summary>
        [Test]
        public void GetThirdPartyParcelAccountByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetThirdPartyParcelAccountByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<ThirdPartyParcelAccount>> (response, "response is List<ThirdPartyParcelAccount>");
        }
        
        /// <summary>
        /// Test GetThirdPartyParcelAccountById
        /// </summary>
        [Test]
        public void GetThirdPartyParcelAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? thirdPartyParcelAccountId = null;
            //var response = instance.GetThirdPartyParcelAccountById(thirdPartyParcelAccountId);
            //Assert.IsInstanceOf<ThirdPartyParcelAccount> (response, "response is ThirdPartyParcelAccount");
        }
        
        /// <summary>
        /// Test UpdateThirdPartyParcelAccount
        /// </summary>
        [Test]
        public void UpdateThirdPartyParcelAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ThirdPartyParcelAccount body = null;
            //instance.UpdateThirdPartyParcelAccount(body);
            
        }
        
    }

}
