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
    ///  Class for testing ItemBuyerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemBuyerApiTests
    {
        private ItemBuyerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemBuyerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemBuyerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ItemBuyerApi
            Assert.IsInstanceOfType(typeof(ItemBuyerApi), instance, "instance is a ItemBuyerApi");
        }

        
        /// <summary>
        /// Test GetItemBuyerBySearchText
        /// </summary>
        [Test]
        public void GetItemBuyerBySearchTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetItemBuyerBySearchText(searchText, page, limit);
            //Assert.IsInstanceOf<List<ItemBuyer>> (response, "response is List<ItemBuyer>");
        }
        
        /// <summary>
        /// Test GetTranslateBuyerById
        /// </summary>
        [Test]
        public void GetTranslateBuyerByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemBuyerId = null;
            //var response = instance.GetTranslateBuyerById(itemBuyerId);
            //Assert.IsInstanceOf<ItemBuyer> (response, "response is ItemBuyer");
        }
        
    }

}
