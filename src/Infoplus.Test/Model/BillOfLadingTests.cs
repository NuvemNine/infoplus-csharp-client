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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Infoplus.Api;
using Infoplus.Model;
using Infoplus.Client;
using System.Reflection;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing BillOfLading
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BillOfLadingTests
    {
        // TODO uncomment below to declare an instance variable for BillOfLading
        //private BillOfLading instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BillOfLading
            //instance = new BillOfLading();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillOfLading
        /// </summary>
        [Test]
        public void BillOfLadingInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BillOfLading
            //Assert.IsInstanceOfType<BillOfLading> (instance, "variable 'instance' is a BillOfLading");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'ModifyDate'
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO unit test for the property 'ModifyDate'
        }
        /// <summary>
        /// Test the property 'LobId'
        /// </summary>
        [Test]
        public void LobIdTest()
        {
            // TODO unit test for the property 'LobId'
        }
        /// <summary>
        /// Test the property 'BolNo'
        /// </summary>
        [Test]
        public void BolNoTest()
        {
            // TODO unit test for the property 'BolNo'
        }
        /// <summary>
        /// Test the property 'BolDate'
        /// </summary>
        [Test]
        public void BolDateTest()
        {
            // TODO unit test for the property 'BolDate'
        }
        /// <summary>
        /// Test the property 'ShipFromName'
        /// </summary>
        [Test]
        public void ShipFromNameTest()
        {
            // TODO unit test for the property 'ShipFromName'
        }
        /// <summary>
        /// Test the property 'ShipFromAddress'
        /// </summary>
        [Test]
        public void ShipFromAddressTest()
        {
            // TODO unit test for the property 'ShipFromAddress'
        }
        /// <summary>
        /// Test the property 'ShipFromCity'
        /// </summary>
        [Test]
        public void ShipFromCityTest()
        {
            // TODO unit test for the property 'ShipFromCity'
        }
        /// <summary>
        /// Test the property 'ShipFromState'
        /// </summary>
        [Test]
        public void ShipFromStateTest()
        {
            // TODO unit test for the property 'ShipFromState'
        }
        /// <summary>
        /// Test the property 'ShipFromZip'
        /// </summary>
        [Test]
        public void ShipFromZipTest()
        {
            // TODO unit test for the property 'ShipFromZip'
        }
        /// <summary>
        /// Test the property 'Sid'
        /// </summary>
        [Test]
        public void SidTest()
        {
            // TODO unit test for the property 'Sid'
        }
        /// <summary>
        /// Test the property 'IsShipFromFOB'
        /// </summary>
        [Test]
        public void IsShipFromFOBTest()
        {
            // TODO unit test for the property 'IsShipFromFOB'
        }
        /// <summary>
        /// Test the property 'ShipToName'
        /// </summary>
        [Test]
        public void ShipToNameTest()
        {
            // TODO unit test for the property 'ShipToName'
        }
        /// <summary>
        /// Test the property 'ShipToAddress'
        /// </summary>
        [Test]
        public void ShipToAddressTest()
        {
            // TODO unit test for the property 'ShipToAddress'
        }
        /// <summary>
        /// Test the property 'ShipToCity'
        /// </summary>
        [Test]
        public void ShipToCityTest()
        {
            // TODO unit test for the property 'ShipToCity'
        }
        /// <summary>
        /// Test the property 'ShipToState'
        /// </summary>
        [Test]
        public void ShipToStateTest()
        {
            // TODO unit test for the property 'ShipToState'
        }
        /// <summary>
        /// Test the property 'ShipToZip'
        /// </summary>
        [Test]
        public void ShipToZipTest()
        {
            // TODO unit test for the property 'ShipToZip'
        }
        /// <summary>
        /// Test the property 'ShipToLocationNo'
        /// </summary>
        [Test]
        public void ShipToLocationNoTest()
        {
            // TODO unit test for the property 'ShipToLocationNo'
        }
        /// <summary>
        /// Test the property 'Cid'
        /// </summary>
        [Test]
        public void CidTest()
        {
            // TODO unit test for the property 'Cid'
        }
        /// <summary>
        /// Test the property 'IsShipToFOB'
        /// </summary>
        [Test]
        public void IsShipToFOBTest()
        {
            // TODO unit test for the property 'IsShipToFOB'
        }
        /// <summary>
        /// Test the property 'BillToName'
        /// </summary>
        [Test]
        public void BillToNameTest()
        {
            // TODO unit test for the property 'BillToName'
        }
        /// <summary>
        /// Test the property 'BillToAddress'
        /// </summary>
        [Test]
        public void BillToAddressTest()
        {
            // TODO unit test for the property 'BillToAddress'
        }
        /// <summary>
        /// Test the property 'BillToCity'
        /// </summary>
        [Test]
        public void BillToCityTest()
        {
            // TODO unit test for the property 'BillToCity'
        }
        /// <summary>
        /// Test the property 'BillToState'
        /// </summary>
        [Test]
        public void BillToStateTest()
        {
            // TODO unit test for the property 'BillToState'
        }
        /// <summary>
        /// Test the property 'BillToZip'
        /// </summary>
        [Test]
        public void BillToZipTest()
        {
            // TODO unit test for the property 'BillToZip'
        }
        /// <summary>
        /// Test the property 'IsTrailerLoadedByShipper'
        /// </summary>
        [Test]
        public void IsTrailerLoadedByShipperTest()
        {
            // TODO unit test for the property 'IsTrailerLoadedByShipper'
        }
        /// <summary>
        /// Test the property 'ByDriver'
        /// </summary>
        [Test]
        public void ByDriverTest()
        {
            // TODO unit test for the property 'ByDriver'
        }
        /// <summary>
        /// Test the property 'CodAmount'
        /// </summary>
        [Test]
        public void CodAmountTest()
        {
            // TODO unit test for the property 'CodAmount'
        }
        /// <summary>
        /// Test the property 'FeeTermsCollect'
        /// </summary>
        [Test]
        public void FeeTermsCollectTest()
        {
            // TODO unit test for the property 'FeeTermsCollect'
        }
        /// <summary>
        /// Test the property 'FeeTermsPrepaid'
        /// </summary>
        [Test]
        public void FeeTermsPrepaidTest()
        {
            // TODO unit test for the property 'FeeTermsPrepaid'
        }
        /// <summary>
        /// Test the property 'CustomerCheckAcceptable'
        /// </summary>
        [Test]
        public void CustomerCheckAcceptableTest()
        {
            // TODO unit test for the property 'CustomerCheckAcceptable'
        }
        /// <summary>
        /// Test the property 'CarrierName'
        /// </summary>
        [Test]
        public void CarrierNameTest()
        {
            // TODO unit test for the property 'CarrierName'
        }
        /// <summary>
        /// Test the property 'TrailerNo'
        /// </summary>
        [Test]
        public void TrailerNoTest()
        {
            // TODO unit test for the property 'TrailerNo'
        }
        /// <summary>
        /// Test the property 'SealNo'
        /// </summary>
        [Test]
        public void SealNoTest()
        {
            // TODO unit test for the property 'SealNo'
        }
        /// <summary>
        /// Test the property 'Scac'
        /// </summary>
        [Test]
        public void ScacTest()
        {
            // TODO unit test for the property 'Scac'
        }
        /// <summary>
        /// Test the property 'ProNo'
        /// </summary>
        [Test]
        public void ProNoTest()
        {
            // TODO unit test for the property 'ProNo'
        }
        /// <summary>
        /// Test the property 'Prepaid'
        /// </summary>
        [Test]
        public void PrepaidTest()
        {
            // TODO unit test for the property 'Prepaid'
        }
        /// <summary>
        /// Test the property 'Collect'
        /// </summary>
        [Test]
        public void CollectTest()
        {
            // TODO unit test for the property 'Collect'
        }
        /// <summary>
        /// Test the property 'ThirdParty'
        /// </summary>
        [Test]
        public void ThirdPartyTest()
        {
            // TODO unit test for the property 'ThirdParty'
        }
        /// <summary>
        /// Test the property 'IsThisAMasterBOL'
        /// </summary>
        [Test]
        public void IsThisAMasterBOLTest()
        {
            // TODO unit test for the property 'IsThisAMasterBOL'
        }
        /// <summary>
        /// Test the property 'MasterBOLId'
        /// </summary>
        [Test]
        public void MasterBOLIdTest()
        {
            // TODO unit test for the property 'MasterBOLId'
        }
        /// <summary>
        /// Test the property 'IsFreightCountedByShipper'
        /// </summary>
        [Test]
        public void IsFreightCountedByShipperTest()
        {
            // TODO unit test for the property 'IsFreightCountedByShipper'
        }
        /// <summary>
        /// Test the property 'ByDriverPallets'
        /// </summary>
        [Test]
        public void ByDriverPalletsTest()
        {
            // TODO unit test for the property 'ByDriverPallets'
        }
        /// <summary>
        /// Test the property 'ByDriverPieces'
        /// </summary>
        [Test]
        public void ByDriverPiecesTest()
        {
            // TODO unit test for the property 'ByDriverPieces'
        }
        /// <summary>
        /// Test the property 'SpecialInstructions'
        /// </summary>
        [Test]
        public void SpecialInstructionsTest()
        {
            // TODO unit test for the property 'SpecialInstructions'
        }
        /// <summary>
        /// Test the property 'OrderInfoLines'
        /// </summary>
        [Test]
        public void OrderInfoLinesTest()
        {
            // TODO unit test for the property 'OrderInfoLines'
        }
        /// <summary>
        /// Test the property 'CarrierInfoLines'
        /// </summary>
        [Test]
        public void CarrierInfoLinesTest()
        {
            // TODO unit test for the property 'CarrierInfoLines'
        }

    }

}