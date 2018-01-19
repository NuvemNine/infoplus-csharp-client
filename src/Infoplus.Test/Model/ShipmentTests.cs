/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using Newtonsoft.Json;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing Shipment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ShipmentTests
    {
        // TODO uncomment below to declare an instance variable for Shipment
        //private Shipment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Shipment
            //instance = new Shipment();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Shipment
        /// </summary>
        [Test]
        public void ShipmentInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Shipment
            //Assert.IsInstanceOfType<Shipment> (instance, "variable 'instance' is a Shipment");
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
        /// Test the property 'ShipDate'
        /// </summary>
        [Test]
        public void ShipDateTest()
        {
            // TODO unit test for the property 'ShipDate'
        }
        /// <summary>
        /// Test the property 'DeliveredDate'
        /// </summary>
        [Test]
        public void DeliveredDateTest()
        {
            // TODO unit test for the property 'DeliveredDate'
        }
        /// <summary>
        /// Test the property 'TrackingNo'
        /// </summary>
        [Test]
        public void TrackingNoTest()
        {
            // TODO unit test for the property 'TrackingNo'
        }
        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
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
        /// Test the property 'OrderNo'
        /// </summary>
        [Test]
        public void OrderNoTest()
        {
            // TODO unit test for the property 'OrderNo'
        }
        /// <summary>
        /// Test the property 'CartonNo'
        /// </summary>
        [Test]
        public void CartonNoTest()
        {
            // TODO unit test for the property 'CartonNo'
        }
        /// <summary>
        /// Test the property 'NumberOfCartons'
        /// </summary>
        [Test]
        public void NumberOfCartonsTest()
        {
            // TODO unit test for the property 'NumberOfCartons'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Shipped'
        /// </summary>
        [Test]
        public void ShippedTest()
        {
            // TODO unit test for the property 'Shipped'
        }
        /// <summary>
        /// Test the property 'CarrierServiceId'
        /// </summary>
        [Test]
        public void CarrierServiceIdTest()
        {
            // TODO unit test for the property 'CarrierServiceId'
        }
        /// <summary>
        /// Test the property 'Dim1In'
        /// </summary>
        [Test]
        public void Dim1InTest()
        {
            // TODO unit test for the property 'Dim1In'
        }
        /// <summary>
        /// Test the property 'Dim2In'
        /// </summary>
        [Test]
        public void Dim2InTest()
        {
            // TODO unit test for the property 'Dim2In'
        }
        /// <summary>
        /// Test the property 'Dim3In'
        /// </summary>
        [Test]
        public void Dim3InTest()
        {
            // TODO unit test for the property 'Dim3In'
        }
        /// <summary>
        /// Test the property 'EstimatedZone'
        /// </summary>
        [Test]
        public void EstimatedZoneTest()
        {
            // TODO unit test for the property 'EstimatedZone'
        }
        /// <summary>
        /// Test the property 'ParcelAccountNo'
        /// </summary>
        [Test]
        public void ParcelAccountNoTest()
        {
            // TODO unit test for the property 'ParcelAccountNo'
        }
        /// <summary>
        /// Test the property 'ThirdPartyParcelAccountNo'
        /// </summary>
        [Test]
        public void ThirdPartyParcelAccountNoTest()
        {
            // TODO unit test for the property 'ThirdPartyParcelAccountNo'
        }
        /// <summary>
        /// Test the property 'ShipmentID'
        /// </summary>
        [Test]
        public void ShipmentIDTest()
        {
            // TODO unit test for the property 'ShipmentID'
        }
        /// <summary>
        /// Test the property 'ManifestId'
        /// </summary>
        [Test]
        public void ManifestIdTest()
        {
            // TODO unit test for the property 'ManifestId'
        }
        /// <summary>
        /// Test the property 'Residential'
        /// </summary>
        [Test]
        public void ResidentialTest()
        {
            // TODO unit test for the property 'Residential'
        }
        /// <summary>
        /// Test the property 'BillingOption'
        /// </summary>
        [Test]
        public void BillingOptionTest()
        {
            // TODO unit test for the property 'BillingOption'
        }
        /// <summary>
        /// Test the property 'WeightLbs'
        /// </summary>
        [Test]
        public void WeightLbsTest()
        {
            // TODO unit test for the property 'WeightLbs'
        }
        /// <summary>
        /// Test the property 'DimWeight'
        /// </summary>
        [Test]
        public void DimWeightTest()
        {
            // TODO unit test for the property 'DimWeight'
        }
        /// <summary>
        /// Test the property 'LicensePlateNumber'
        /// </summary>
        [Test]
        public void LicensePlateNumberTest()
        {
            // TODO unit test for the property 'LicensePlateNumber'
        }
        /// <summary>
        /// Test the property 'ChargedFreightAmount'
        /// </summary>
        [Test]
        public void ChargedFreightAmountTest()
        {
            // TODO unit test for the property 'ChargedFreightAmount'
        }
        /// <summary>
        /// Test the property 'PublishedFreightAmount'
        /// </summary>
        [Test]
        public void PublishedFreightAmountTest()
        {
            // TODO unit test for the property 'PublishedFreightAmount'
        }
        /// <summary>
        /// Test the property 'RetailFreightAmount'
        /// </summary>
        [Test]
        public void RetailFreightAmountTest()
        {
            // TODO unit test for the property 'RetailFreightAmount'
        }
        /// <summary>
        /// Test the property 'ExternalShippingSystemId'
        /// </summary>
        [Test]
        public void ExternalShippingSystemIdTest()
        {
            // TODO unit test for the property 'ExternalShippingSystemId'
        }
        /// <summary>
        /// Test the property 'ShipmentType'
        /// </summary>
        [Test]
        public void ShipmentTypeTest()
        {
            // TODO unit test for the property 'ShipmentType'
        }
        /// <summary>
        /// Test the property 'CarrierCompany'
        /// </summary>
        [Test]
        public void CarrierCompanyTest()
        {
            // TODO unit test for the property 'CarrierCompany'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }

    }

}
