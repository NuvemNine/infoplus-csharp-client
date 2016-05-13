using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// Initializes a new instance of the <see cref="Item" />class.
        /// </summary>
        /// <param name="AccountCodeId">AccountCodeId.</param>
        /// <param name="LowStockContactId">LowStockContactId.</param>
        /// <param name="LegacyLowLevelContactId">LegacyLowLevelContactId.</param>
        /// <param name="LowStockCodeId">LowStockCodeId.</param>
        /// <param name="MajorGroupId">MajorGroupId (required).</param>
        /// <param name="SubGroupId">SubGroupId (required).</param>
        /// <param name="ProductCodeId">ProductCodeId.</param>
        /// <param name="SummaryCodeId">SummaryCodeId.</param>
        /// <param name="BuyerId">BuyerId.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="VendorSKU">VendorSKU.</param>
        /// <param name="Upc">Upc.</param>
        /// <param name="ItemDescription">ItemDescription (required).</param>
        /// <param name="PackingSlipDescription">PackingSlipDescription.</param>
        /// <param name="AbsoluteMax">AbsoluteMax.</param>
        /// <param name="AdditionalDescription">AdditionalDescription.</param>
        /// <param name="Backorder">Backorder (required).</param>
        /// <param name="ChargeCode">ChargeCode (required).</param>
        /// <param name="CommodityCode">CommodityCode.</param>
        /// <param name="CompCode">CompCode.</param>
        /// <param name="CriticalAmount">CriticalAmount (required).</param>
        /// <param name="OverallFixedReorderPoint">OverallFixedReorderPoint.</param>
        /// <param name="OverallLeadTime">OverallLeadTime.</param>
        /// <param name="ListPrice">ListPrice.</param>
        /// <param name="LotControlFlag">LotControlFlag.</param>
        /// <param name="MaxCycle">MaxCycle (required).</param>
        /// <param name="MaxInterim">MaxInterim (required).</param>
        /// <param name="NumericSortOrder">NumericSortOrder.</param>
        /// <param name="OutsideVendor">OutsideVendor.</param>
        /// <param name="PickNo">PickNo.</param>
        /// <param name="PodOrderSuffix">PodOrderSuffix.</param>
        /// <param name="PodRevDate">PodRevDate.</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="SeasonalItem">SeasonalItem (required).</param>
        /// <param name="RequiresProductionLot">RequiresProductionLot.</param>
        /// <param name="Sector">Sector.</param>
        /// <param name="Secure">Secure (required).</param>
        /// <param name="SerialCode">SerialCode (required).</param>
        /// <param name="UnitCode">UnitCode (required).</param>
        /// <param name="UnitsPerWrap">UnitsPerWrap (required).</param>
        /// <param name="WeightPerWrap">WeightPerWrap.</param>
        /// <param name="WrapCode">WrapCode (required).</param>
        /// <param name="ExtrinsicText1">ExtrinsicText1.</param>
        /// <param name="ExtrinsicText2">ExtrinsicText2.</param>
        /// <param name="ExtrinsicText3">ExtrinsicText3.</param>
        /// <param name="ExtrinsicNumber1">ExtrinsicNumber1.</param>
        /// <param name="ExtrinsicNumber2">ExtrinsicNumber2.</param>
        /// <param name="ExtrinsicDecimal1">ExtrinsicDecimal1.</param>
        /// <param name="ExtrinsicDecimal2">ExtrinsicDecimal2.</param>
        /// <param name="CasebreakEnabled">CasebreakEnabled.</param>
        /// <param name="ForwardLotMixingRule">ForwardLotMixingRule (required).</param>
        /// <param name="StorageLotMixingRule">StorageLotMixingRule (required).</param>
        /// <param name="ForwardItemMixingRule">ForwardItemMixingRule (required).</param>
        /// <param name="StorageItemMixingRule">StorageItemMixingRule (required).</param>
        /// <param name="AllocationRule">AllocationRule (required).</param>
        /// <param name="Hazmat">Hazmat (required).</param>

        public Item(int? AccountCodeId = null, int? LowStockContactId = null, int? LegacyLowLevelContactId = null, int? LowStockCodeId = null, int? MajorGroupId = null, int? SubGroupId = null, int? ProductCodeId = null, int? SummaryCodeId = null, int? BuyerId = null, int? LobId = null, string Sku = null, string VendorSKU = null, string Upc = null, string ItemDescription = null, string PackingSlipDescription = null, string AbsoluteMax = null, string AdditionalDescription = null, string Backorder = null, string ChargeCode = null, string CommodityCode = null, int? CompCode = null, int? CriticalAmount = null, int? OverallFixedReorderPoint = null, int? OverallLeadTime = null, double? ListPrice = null, string LotControlFlag = null, int? MaxCycle = null, int? MaxInterim = null, int? NumericSortOrder = null, int? OutsideVendor = null, string PickNo = null, int? PodOrderSuffix = null, string PodRevDate = null, string Status = null, string SeasonalItem = null, string RequiresProductionLot = null, string Sector = null, string Secure = null, string SerialCode = null, string UnitCode = null, int? UnitsPerWrap = null, double? WeightPerWrap = null, string WrapCode = null, string ExtrinsicText1 = null, string ExtrinsicText2 = null, string ExtrinsicText3 = null, int? ExtrinsicNumber1 = null, int? ExtrinsicNumber2 = null, double? ExtrinsicDecimal1 = null, double? ExtrinsicDecimal2 = null, string CasebreakEnabled = null, string ForwardLotMixingRule = null, string StorageLotMixingRule = null, string ForwardItemMixingRule = null, string StorageItemMixingRule = null, string AllocationRule = null, string Hazmat = null)
        {
            // to ensure "MajorGroupId" is required (not null)
            if (MajorGroupId == null)
            {
                throw new InvalidDataException("MajorGroupId is a required property for Item and cannot be null");
            }
            else
            {
                this.MajorGroupId = MajorGroupId;
            }
            // to ensure "SubGroupId" is required (not null)
            if (SubGroupId == null)
            {
                throw new InvalidDataException("SubGroupId is a required property for Item and cannot be null");
            }
            else
            {
                this.SubGroupId = SubGroupId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Item and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for Item and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "ItemDescription" is required (not null)
            if (ItemDescription == null)
            {
                throw new InvalidDataException("ItemDescription is a required property for Item and cannot be null");
            }
            else
            {
                this.ItemDescription = ItemDescription;
            }
            // to ensure "Backorder" is required (not null)
            if (Backorder == null)
            {
                throw new InvalidDataException("Backorder is a required property for Item and cannot be null");
            }
            else
            {
                this.Backorder = Backorder;
            }
            // to ensure "ChargeCode" is required (not null)
            if (ChargeCode == null)
            {
                throw new InvalidDataException("ChargeCode is a required property for Item and cannot be null");
            }
            else
            {
                this.ChargeCode = ChargeCode;
            }
            // to ensure "CriticalAmount" is required (not null)
            if (CriticalAmount == null)
            {
                throw new InvalidDataException("CriticalAmount is a required property for Item and cannot be null");
            }
            else
            {
                this.CriticalAmount = CriticalAmount;
            }
            // to ensure "MaxCycle" is required (not null)
            if (MaxCycle == null)
            {
                throw new InvalidDataException("MaxCycle is a required property for Item and cannot be null");
            }
            else
            {
                this.MaxCycle = MaxCycle;
            }
            // to ensure "MaxInterim" is required (not null)
            if (MaxInterim == null)
            {
                throw new InvalidDataException("MaxInterim is a required property for Item and cannot be null");
            }
            else
            {
                this.MaxInterim = MaxInterim;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Item and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "SeasonalItem" is required (not null)
            if (SeasonalItem == null)
            {
                throw new InvalidDataException("SeasonalItem is a required property for Item and cannot be null");
            }
            else
            {
                this.SeasonalItem = SeasonalItem;
            }
            // to ensure "Secure" is required (not null)
            if (Secure == null)
            {
                throw new InvalidDataException("Secure is a required property for Item and cannot be null");
            }
            else
            {
                this.Secure = Secure;
            }
            // to ensure "SerialCode" is required (not null)
            if (SerialCode == null)
            {
                throw new InvalidDataException("SerialCode is a required property for Item and cannot be null");
            }
            else
            {
                this.SerialCode = SerialCode;
            }
            // to ensure "UnitCode" is required (not null)
            if (UnitCode == null)
            {
                throw new InvalidDataException("UnitCode is a required property for Item and cannot be null");
            }
            else
            {
                this.UnitCode = UnitCode;
            }
            // to ensure "UnitsPerWrap" is required (not null)
            if (UnitsPerWrap == null)
            {
                throw new InvalidDataException("UnitsPerWrap is a required property for Item and cannot be null");
            }
            else
            {
                this.UnitsPerWrap = UnitsPerWrap;
            }
            // to ensure "WrapCode" is required (not null)
            if (WrapCode == null)
            {
                throw new InvalidDataException("WrapCode is a required property for Item and cannot be null");
            }
            else
            {
                this.WrapCode = WrapCode;
            }
            // to ensure "ForwardLotMixingRule" is required (not null)
            if (ForwardLotMixingRule == null)
            {
                throw new InvalidDataException("ForwardLotMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.ForwardLotMixingRule = ForwardLotMixingRule;
            }
            // to ensure "StorageLotMixingRule" is required (not null)
            if (StorageLotMixingRule == null)
            {
                throw new InvalidDataException("StorageLotMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.StorageLotMixingRule = StorageLotMixingRule;
            }
            // to ensure "ForwardItemMixingRule" is required (not null)
            if (ForwardItemMixingRule == null)
            {
                throw new InvalidDataException("ForwardItemMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.ForwardItemMixingRule = ForwardItemMixingRule;
            }
            // to ensure "StorageItemMixingRule" is required (not null)
            if (StorageItemMixingRule == null)
            {
                throw new InvalidDataException("StorageItemMixingRule is a required property for Item and cannot be null");
            }
            else
            {
                this.StorageItemMixingRule = StorageItemMixingRule;
            }
            // to ensure "AllocationRule" is required (not null)
            if (AllocationRule == null)
            {
                throw new InvalidDataException("AllocationRule is a required property for Item and cannot be null");
            }
            else
            {
                this.AllocationRule = AllocationRule;
            }
            // to ensure "Hazmat" is required (not null)
            if (Hazmat == null)
            {
                throw new InvalidDataException("Hazmat is a required property for Item and cannot be null");
            }
            else
            {
                this.Hazmat = Hazmat;
            }
            this.AccountCodeId = AccountCodeId;
            this.LowStockContactId = LowStockContactId;
            this.LegacyLowLevelContactId = LegacyLowLevelContactId;
            this.LowStockCodeId = LowStockCodeId;
            this.ProductCodeId = ProductCodeId;
            this.SummaryCodeId = SummaryCodeId;
            this.BuyerId = BuyerId;
            this.VendorSKU = VendorSKU;
            this.Upc = Upc;
            this.PackingSlipDescription = PackingSlipDescription;
            this.AbsoluteMax = AbsoluteMax;
            this.AdditionalDescription = AdditionalDescription;
            this.CommodityCode = CommodityCode;
            this.CompCode = CompCode;
            this.OverallFixedReorderPoint = OverallFixedReorderPoint;
            this.OverallLeadTime = OverallLeadTime;
            this.ListPrice = ListPrice;
            this.LotControlFlag = LotControlFlag;
            this.NumericSortOrder = NumericSortOrder;
            this.OutsideVendor = OutsideVendor;
            this.PickNo = PickNo;
            this.PodOrderSuffix = PodOrderSuffix;
            this.PodRevDate = PodRevDate;
            this.RequiresProductionLot = RequiresProductionLot;
            this.Sector = Sector;
            this.WeightPerWrap = WeightPerWrap;
            this.ExtrinsicText1 = ExtrinsicText1;
            this.ExtrinsicText2 = ExtrinsicText2;
            this.ExtrinsicText3 = ExtrinsicText3;
            this.ExtrinsicNumber1 = ExtrinsicNumber1;
            this.ExtrinsicNumber2 = ExtrinsicNumber2;
            this.ExtrinsicDecimal1 = ExtrinsicDecimal1;
            this.ExtrinsicDecimal2 = ExtrinsicDecimal2;
            this.CasebreakEnabled = CasebreakEnabled;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets AccountCodeId
        /// </summary>
        [DataMember(Name="accountCodeId", EmitDefaultValue=false)]
        public int? AccountCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockContactId
        /// </summary>
        [DataMember(Name="lowStockContactId", EmitDefaultValue=false)]
        public int? LowStockContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets LegacyLowLevelContactId
        /// </summary>
        [DataMember(Name="legacyLowLevelContactId", EmitDefaultValue=false)]
        public int? LegacyLowLevelContactId { get; set; }
    
        /// <summary>
        /// Gets or Sets LowStockCodeId
        /// </summary>
        [DataMember(Name="lowStockCodeId", EmitDefaultValue=false)]
        public int? LowStockCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets MajorGroupId
        /// </summary>
        [DataMember(Name="majorGroupId", EmitDefaultValue=false)]
        public int? MajorGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets SubGroupId
        /// </summary>
        [DataMember(Name="subGroupId", EmitDefaultValue=false)]
        public int? SubGroupId { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductCodeId
        /// </summary>
        [DataMember(Name="productCodeId", EmitDefaultValue=false)]
        public int? ProductCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets SummaryCodeId
        /// </summary>
        [DataMember(Name="summaryCodeId", EmitDefaultValue=false)]
        public int? SummaryCodeId { get; set; }
    
        /// <summary>
        /// Gets or Sets BuyerId
        /// </summary>
        [DataMember(Name="buyerId", EmitDefaultValue=false)]
        public int? BuyerId { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorSKU
        /// </summary>
        [DataMember(Name="vendorSKU", EmitDefaultValue=false)]
        public string VendorSKU { get; set; }
    
        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemDescription
        /// </summary>
        [DataMember(Name="itemDescription", EmitDefaultValue=false)]
        public string ItemDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets PackingSlipDescription
        /// </summary>
        [DataMember(Name="packingSlipDescription", EmitDefaultValue=false)]
        public string PackingSlipDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets AbsoluteMax
        /// </summary>
        [DataMember(Name="absoluteMax", EmitDefaultValue=false)]
        public string AbsoluteMax { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalDescription
        /// </summary>
        [DataMember(Name="additionalDescription", EmitDefaultValue=false)]
        public string AdditionalDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets Backorder
        /// </summary>
        [DataMember(Name="backorder", EmitDefaultValue=false)]
        public string Backorder { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeCode
        /// </summary>
        [DataMember(Name="chargeCode", EmitDefaultValue=false)]
        public string ChargeCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CommodityCode
        /// </summary>
        [DataMember(Name="commodityCode", EmitDefaultValue=false)]
        public string CommodityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CompCode
        /// </summary>
        [DataMember(Name="compCode", EmitDefaultValue=false)]
        public int? CompCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CriticalAmount
        /// </summary>
        [DataMember(Name="criticalAmount", EmitDefaultValue=false)]
        public int? CriticalAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallFixedReorderPoint
        /// </summary>
        [DataMember(Name="overallFixedReorderPoint", EmitDefaultValue=false)]
        public int? OverallFixedReorderPoint { get; set; }
    
        /// <summary>
        /// Gets or Sets OverallLeadTime
        /// </summary>
        [DataMember(Name="overallLeadTime", EmitDefaultValue=false)]
        public int? OverallLeadTime { get; set; }
    
        /// <summary>
        /// Gets or Sets ListPrice
        /// </summary>
        [DataMember(Name="listPrice", EmitDefaultValue=false)]
        public double? ListPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets LotControlFlag
        /// </summary>
        [DataMember(Name="lotControlFlag", EmitDefaultValue=false)]
        public string LotControlFlag { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxCycle
        /// </summary>
        [DataMember(Name="maxCycle", EmitDefaultValue=false)]
        public int? MaxCycle { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxInterim
        /// </summary>
        [DataMember(Name="maxInterim", EmitDefaultValue=false)]
        public int? MaxInterim { get; set; }
    
        /// <summary>
        /// Gets or Sets NumericSortOrder
        /// </summary>
        [DataMember(Name="numericSortOrder", EmitDefaultValue=false)]
        public int? NumericSortOrder { get; set; }
    
        /// <summary>
        /// Gets or Sets OutsideVendor
        /// </summary>
        [DataMember(Name="outsideVendor", EmitDefaultValue=false)]
        public int? OutsideVendor { get; set; }
    
        /// <summary>
        /// Gets or Sets PickNo
        /// </summary>
        [DataMember(Name="pickNo", EmitDefaultValue=false)]
        public string PickNo { get; set; }
    
        /// <summary>
        /// Gets or Sets PodOrderSuffix
        /// </summary>
        [DataMember(Name="podOrderSuffix", EmitDefaultValue=false)]
        public int? PodOrderSuffix { get; set; }
    
        /// <summary>
        /// Gets or Sets PodRevDate
        /// </summary>
        [DataMember(Name="podRevDate", EmitDefaultValue=false)]
        public string PodRevDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets SeasonalItem
        /// </summary>
        [DataMember(Name="seasonalItem", EmitDefaultValue=false)]
        public string SeasonalItem { get; set; }
    
        /// <summary>
        /// Gets or Sets RequiresProductionLot
        /// </summary>
        [DataMember(Name="requiresProductionLot", EmitDefaultValue=false)]
        public string RequiresProductionLot { get; set; }
    
        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; set; }
    
        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public string Secure { get; set; }
    
        /// <summary>
        /// Gets or Sets SerialCode
        /// </summary>
        [DataMember(Name="serialCode", EmitDefaultValue=false)]
        public string SerialCode { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitCode
        /// </summary>
        [DataMember(Name="unitCode", EmitDefaultValue=false)]
        public string UnitCode { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitsPerWrap
        /// </summary>
        [DataMember(Name="unitsPerWrap", EmitDefaultValue=false)]
        public int? UnitsPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public double? WeightPerWrap { get; set; }
    
        /// <summary>
        /// Gets or Sets VoidDate
        /// </summary>
        [DataMember(Name="voidDate", EmitDefaultValue=false)]
        public DateTime? VoidDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets WrapCode
        /// </summary>
        [DataMember(Name="wrapCode", EmitDefaultValue=false)]
        public string WrapCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText1
        /// </summary>
        [DataMember(Name="extrinsicText1", EmitDefaultValue=false)]
        public string ExtrinsicText1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText2
        /// </summary>
        [DataMember(Name="extrinsicText2", EmitDefaultValue=false)]
        public string ExtrinsicText2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText3
        /// </summary>
        [DataMember(Name="extrinsicText3", EmitDefaultValue=false)]
        public string ExtrinsicText3 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber1
        /// </summary>
        [DataMember(Name="extrinsicNumber1", EmitDefaultValue=false)]
        public int? ExtrinsicNumber1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber2
        /// </summary>
        [DataMember(Name="extrinsicNumber2", EmitDefaultValue=false)]
        public int? ExtrinsicNumber2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal1
        /// </summary>
        [DataMember(Name="extrinsicDecimal1", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal2
        /// </summary>
        [DataMember(Name="extrinsicDecimal2", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal2 { get; set; }
    
        /// <summary>
        /// Gets or Sets CasebreakEnabled
        /// </summary>
        [DataMember(Name="casebreakEnabled", EmitDefaultValue=false)]
        public string CasebreakEnabled { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ForwardLotMixingRule
        /// </summary>
        [DataMember(Name="forwardLotMixingRule", EmitDefaultValue=false)]
        public string ForwardLotMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageLotMixingRule
        /// </summary>
        [DataMember(Name="storageLotMixingRule", EmitDefaultValue=false)]
        public string StorageLotMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets ForwardItemMixingRule
        /// </summary>
        [DataMember(Name="forwardItemMixingRule", EmitDefaultValue=false)]
        public string ForwardItemMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets StorageItemMixingRule
        /// </summary>
        [DataMember(Name="storageItemMixingRule", EmitDefaultValue=false)]
        public string StorageItemMixingRule { get; set; }
    
        /// <summary>
        /// Gets or Sets AllocationRule
        /// </summary>
        [DataMember(Name="allocationRule", EmitDefaultValue=false)]
        public string AllocationRule { get; set; }
    
        /// <summary>
        /// Gets or Sets Hazmat
        /// </summary>
        [DataMember(Name="hazmat", EmitDefaultValue=false)]
        public string Hazmat { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountCodeId: ").Append(AccountCodeId).Append("\n");
            sb.Append("  LowStockContactId: ").Append(LowStockContactId).Append("\n");
            sb.Append("  LegacyLowLevelContactId: ").Append(LegacyLowLevelContactId).Append("\n");
            sb.Append("  LowStockCodeId: ").Append(LowStockCodeId).Append("\n");
            sb.Append("  MajorGroupId: ").Append(MajorGroupId).Append("\n");
            sb.Append("  SubGroupId: ").Append(SubGroupId).Append("\n");
            sb.Append("  ProductCodeId: ").Append(ProductCodeId).Append("\n");
            sb.Append("  SummaryCodeId: ").Append(SummaryCodeId).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
            sb.Append("  PackingSlipDescription: ").Append(PackingSlipDescription).Append("\n");
            sb.Append("  AbsoluteMax: ").Append(AbsoluteMax).Append("\n");
            sb.Append("  AdditionalDescription: ").Append(AdditionalDescription).Append("\n");
            sb.Append("  Backorder: ").Append(Backorder).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  CompCode: ").Append(CompCode).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CriticalAmount: ").Append(CriticalAmount).Append("\n");
            sb.Append("  OverallFixedReorderPoint: ").Append(OverallFixedReorderPoint).Append("\n");
            sb.Append("  OverallLeadTime: ").Append(OverallLeadTime).Append("\n");
            sb.Append("  ListPrice: ").Append(ListPrice).Append("\n");
            sb.Append("  LotControlFlag: ").Append(LotControlFlag).Append("\n");
            sb.Append("  MaxCycle: ").Append(MaxCycle).Append("\n");
            sb.Append("  MaxInterim: ").Append(MaxInterim).Append("\n");
            sb.Append("  NumericSortOrder: ").Append(NumericSortOrder).Append("\n");
            sb.Append("  OutsideVendor: ").Append(OutsideVendor).Append("\n");
            sb.Append("  PickNo: ").Append(PickNo).Append("\n");
            sb.Append("  PodOrderSuffix: ").Append(PodOrderSuffix).Append("\n");
            sb.Append("  PodRevDate: ").Append(PodRevDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SeasonalItem: ").Append(SeasonalItem).Append("\n");
            sb.Append("  RequiresProductionLot: ").Append(RequiresProductionLot).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  SerialCode: ").Append(SerialCode).Append("\n");
            sb.Append("  UnitCode: ").Append(UnitCode).Append("\n");
            sb.Append("  UnitsPerWrap: ").Append(UnitsPerWrap).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  VoidDate: ").Append(VoidDate).Append("\n");
            sb.Append("  WrapCode: ").Append(WrapCode).Append("\n");
            sb.Append("  ExtrinsicText1: ").Append(ExtrinsicText1).Append("\n");
            sb.Append("  ExtrinsicText2: ").Append(ExtrinsicText2).Append("\n");
            sb.Append("  ExtrinsicText3: ").Append(ExtrinsicText3).Append("\n");
            sb.Append("  ExtrinsicNumber1: ").Append(ExtrinsicNumber1).Append("\n");
            sb.Append("  ExtrinsicNumber2: ").Append(ExtrinsicNumber2).Append("\n");
            sb.Append("  ExtrinsicDecimal1: ").Append(ExtrinsicDecimal1).Append("\n");
            sb.Append("  ExtrinsicDecimal2: ").Append(ExtrinsicDecimal2).Append("\n");
            sb.Append("  CasebreakEnabled: ").Append(CasebreakEnabled).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ForwardLotMixingRule: ").Append(ForwardLotMixingRule).Append("\n");
            sb.Append("  StorageLotMixingRule: ").Append(StorageLotMixingRule).Append("\n");
            sb.Append("  ForwardItemMixingRule: ").Append(ForwardItemMixingRule).Append("\n");
            sb.Append("  StorageItemMixingRule: ").Append(StorageItemMixingRule).Append("\n");
            sb.Append("  AllocationRule: ").Append(AllocationRule).Append("\n");
            sb.Append("  Hazmat: ").Append(Hazmat).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="other">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.AccountCodeId == other.AccountCodeId ||
                    this.AccountCodeId != null &&
                    this.AccountCodeId.Equals(other.AccountCodeId)
                ) && 
                (
                    this.LowStockContactId == other.LowStockContactId ||
                    this.LowStockContactId != null &&
                    this.LowStockContactId.Equals(other.LowStockContactId)
                ) && 
                (
                    this.LegacyLowLevelContactId == other.LegacyLowLevelContactId ||
                    this.LegacyLowLevelContactId != null &&
                    this.LegacyLowLevelContactId.Equals(other.LegacyLowLevelContactId)
                ) && 
                (
                    this.LowStockCodeId == other.LowStockCodeId ||
                    this.LowStockCodeId != null &&
                    this.LowStockCodeId.Equals(other.LowStockCodeId)
                ) && 
                (
                    this.MajorGroupId == other.MajorGroupId ||
                    this.MajorGroupId != null &&
                    this.MajorGroupId.Equals(other.MajorGroupId)
                ) && 
                (
                    this.SubGroupId == other.SubGroupId ||
                    this.SubGroupId != null &&
                    this.SubGroupId.Equals(other.SubGroupId)
                ) && 
                (
                    this.ProductCodeId == other.ProductCodeId ||
                    this.ProductCodeId != null &&
                    this.ProductCodeId.Equals(other.ProductCodeId)
                ) && 
                (
                    this.SummaryCodeId == other.SummaryCodeId ||
                    this.SummaryCodeId != null &&
                    this.SummaryCodeId.Equals(other.SummaryCodeId)
                ) && 
                (
                    this.BuyerId == other.BuyerId ||
                    this.BuyerId != null &&
                    this.BuyerId.Equals(other.BuyerId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.VendorSKU == other.VendorSKU ||
                    this.VendorSKU != null &&
                    this.VendorSKU.Equals(other.VendorSKU)
                ) && 
                (
                    this.Upc == other.Upc ||
                    this.Upc != null &&
                    this.Upc.Equals(other.Upc)
                ) && 
                (
                    this.ItemDescription == other.ItemDescription ||
                    this.ItemDescription != null &&
                    this.ItemDescription.Equals(other.ItemDescription)
                ) && 
                (
                    this.PackingSlipDescription == other.PackingSlipDescription ||
                    this.PackingSlipDescription != null &&
                    this.PackingSlipDescription.Equals(other.PackingSlipDescription)
                ) && 
                (
                    this.AbsoluteMax == other.AbsoluteMax ||
                    this.AbsoluteMax != null &&
                    this.AbsoluteMax.Equals(other.AbsoluteMax)
                ) && 
                (
                    this.AdditionalDescription == other.AdditionalDescription ||
                    this.AdditionalDescription != null &&
                    this.AdditionalDescription.Equals(other.AdditionalDescription)
                ) && 
                (
                    this.Backorder == other.Backorder ||
                    this.Backorder != null &&
                    this.Backorder.Equals(other.Backorder)
                ) && 
                (
                    this.ChargeCode == other.ChargeCode ||
                    this.ChargeCode != null &&
                    this.ChargeCode.Equals(other.ChargeCode)
                ) && 
                (
                    this.CommodityCode == other.CommodityCode ||
                    this.CommodityCode != null &&
                    this.CommodityCode.Equals(other.CommodityCode)
                ) && 
                (
                    this.CompCode == other.CompCode ||
                    this.CompCode != null &&
                    this.CompCode.Equals(other.CompCode)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.CriticalAmount == other.CriticalAmount ||
                    this.CriticalAmount != null &&
                    this.CriticalAmount.Equals(other.CriticalAmount)
                ) && 
                (
                    this.OverallFixedReorderPoint == other.OverallFixedReorderPoint ||
                    this.OverallFixedReorderPoint != null &&
                    this.OverallFixedReorderPoint.Equals(other.OverallFixedReorderPoint)
                ) && 
                (
                    this.OverallLeadTime == other.OverallLeadTime ||
                    this.OverallLeadTime != null &&
                    this.OverallLeadTime.Equals(other.OverallLeadTime)
                ) && 
                (
                    this.ListPrice == other.ListPrice ||
                    this.ListPrice != null &&
                    this.ListPrice.Equals(other.ListPrice)
                ) && 
                (
                    this.LotControlFlag == other.LotControlFlag ||
                    this.LotControlFlag != null &&
                    this.LotControlFlag.Equals(other.LotControlFlag)
                ) && 
                (
                    this.MaxCycle == other.MaxCycle ||
                    this.MaxCycle != null &&
                    this.MaxCycle.Equals(other.MaxCycle)
                ) && 
                (
                    this.MaxInterim == other.MaxInterim ||
                    this.MaxInterim != null &&
                    this.MaxInterim.Equals(other.MaxInterim)
                ) && 
                (
                    this.NumericSortOrder == other.NumericSortOrder ||
                    this.NumericSortOrder != null &&
                    this.NumericSortOrder.Equals(other.NumericSortOrder)
                ) && 
                (
                    this.OutsideVendor == other.OutsideVendor ||
                    this.OutsideVendor != null &&
                    this.OutsideVendor.Equals(other.OutsideVendor)
                ) && 
                (
                    this.PickNo == other.PickNo ||
                    this.PickNo != null &&
                    this.PickNo.Equals(other.PickNo)
                ) && 
                (
                    this.PodOrderSuffix == other.PodOrderSuffix ||
                    this.PodOrderSuffix != null &&
                    this.PodOrderSuffix.Equals(other.PodOrderSuffix)
                ) && 
                (
                    this.PodRevDate == other.PodRevDate ||
                    this.PodRevDate != null &&
                    this.PodRevDate.Equals(other.PodRevDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SeasonalItem == other.SeasonalItem ||
                    this.SeasonalItem != null &&
                    this.SeasonalItem.Equals(other.SeasonalItem)
                ) && 
                (
                    this.RequiresProductionLot == other.RequiresProductionLot ||
                    this.RequiresProductionLot != null &&
                    this.RequiresProductionLot.Equals(other.RequiresProductionLot)
                ) && 
                (
                    this.Sector == other.Sector ||
                    this.Sector != null &&
                    this.Sector.Equals(other.Sector)
                ) && 
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) && 
                (
                    this.SerialCode == other.SerialCode ||
                    this.SerialCode != null &&
                    this.SerialCode.Equals(other.SerialCode)
                ) && 
                (
                    this.UnitCode == other.UnitCode ||
                    this.UnitCode != null &&
                    this.UnitCode.Equals(other.UnitCode)
                ) && 
                (
                    this.UnitsPerWrap == other.UnitsPerWrap ||
                    this.UnitsPerWrap != null &&
                    this.UnitsPerWrap.Equals(other.UnitsPerWrap)
                ) && 
                (
                    this.WeightPerWrap == other.WeightPerWrap ||
                    this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(other.WeightPerWrap)
                ) && 
                (
                    this.VoidDate == other.VoidDate ||
                    this.VoidDate != null &&
                    this.VoidDate.Equals(other.VoidDate)
                ) && 
                (
                    this.WrapCode == other.WrapCode ||
                    this.WrapCode != null &&
                    this.WrapCode.Equals(other.WrapCode)
                ) && 
                (
                    this.ExtrinsicText1 == other.ExtrinsicText1 ||
                    this.ExtrinsicText1 != null &&
                    this.ExtrinsicText1.Equals(other.ExtrinsicText1)
                ) && 
                (
                    this.ExtrinsicText2 == other.ExtrinsicText2 ||
                    this.ExtrinsicText2 != null &&
                    this.ExtrinsicText2.Equals(other.ExtrinsicText2)
                ) && 
                (
                    this.ExtrinsicText3 == other.ExtrinsicText3 ||
                    this.ExtrinsicText3 != null &&
                    this.ExtrinsicText3.Equals(other.ExtrinsicText3)
                ) && 
                (
                    this.ExtrinsicNumber1 == other.ExtrinsicNumber1 ||
                    this.ExtrinsicNumber1 != null &&
                    this.ExtrinsicNumber1.Equals(other.ExtrinsicNumber1)
                ) && 
                (
                    this.ExtrinsicNumber2 == other.ExtrinsicNumber2 ||
                    this.ExtrinsicNumber2 != null &&
                    this.ExtrinsicNumber2.Equals(other.ExtrinsicNumber2)
                ) && 
                (
                    this.ExtrinsicDecimal1 == other.ExtrinsicDecimal1 ||
                    this.ExtrinsicDecimal1 != null &&
                    this.ExtrinsicDecimal1.Equals(other.ExtrinsicDecimal1)
                ) && 
                (
                    this.ExtrinsicDecimal2 == other.ExtrinsicDecimal2 ||
                    this.ExtrinsicDecimal2 != null &&
                    this.ExtrinsicDecimal2.Equals(other.ExtrinsicDecimal2)
                ) && 
                (
                    this.CasebreakEnabled == other.CasebreakEnabled ||
                    this.CasebreakEnabled != null &&
                    this.CasebreakEnabled.Equals(other.CasebreakEnabled)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.ForwardLotMixingRule == other.ForwardLotMixingRule ||
                    this.ForwardLotMixingRule != null &&
                    this.ForwardLotMixingRule.Equals(other.ForwardLotMixingRule)
                ) && 
                (
                    this.StorageLotMixingRule == other.StorageLotMixingRule ||
                    this.StorageLotMixingRule != null &&
                    this.StorageLotMixingRule.Equals(other.StorageLotMixingRule)
                ) && 
                (
                    this.ForwardItemMixingRule == other.ForwardItemMixingRule ||
                    this.ForwardItemMixingRule != null &&
                    this.ForwardItemMixingRule.Equals(other.ForwardItemMixingRule)
                ) && 
                (
                    this.StorageItemMixingRule == other.StorageItemMixingRule ||
                    this.StorageItemMixingRule != null &&
                    this.StorageItemMixingRule.Equals(other.StorageItemMixingRule)
                ) && 
                (
                    this.AllocationRule == other.AllocationRule ||
                    this.AllocationRule != null &&
                    this.AllocationRule.Equals(other.AllocationRule)
                ) && 
                (
                    this.Hazmat == other.Hazmat ||
                    this.Hazmat != null &&
                    this.Hazmat.Equals(other.Hazmat)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.AccountCodeId != null)
                    hash = hash * 59 + this.AccountCodeId.GetHashCode();
                
                if (this.LowStockContactId != null)
                    hash = hash * 59 + this.LowStockContactId.GetHashCode();
                
                if (this.LegacyLowLevelContactId != null)
                    hash = hash * 59 + this.LegacyLowLevelContactId.GetHashCode();
                
                if (this.LowStockCodeId != null)
                    hash = hash * 59 + this.LowStockCodeId.GetHashCode();
                
                if (this.MajorGroupId != null)
                    hash = hash * 59 + this.MajorGroupId.GetHashCode();
                
                if (this.SubGroupId != null)
                    hash = hash * 59 + this.SubGroupId.GetHashCode();
                
                if (this.ProductCodeId != null)
                    hash = hash * 59 + this.ProductCodeId.GetHashCode();
                
                if (this.SummaryCodeId != null)
                    hash = hash * 59 + this.SummaryCodeId.GetHashCode();
                
                if (this.BuyerId != null)
                    hash = hash * 59 + this.BuyerId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.VendorSKU != null)
                    hash = hash * 59 + this.VendorSKU.GetHashCode();
                
                if (this.Upc != null)
                    hash = hash * 59 + this.Upc.GetHashCode();
                
                if (this.ItemDescription != null)
                    hash = hash * 59 + this.ItemDescription.GetHashCode();
                
                if (this.PackingSlipDescription != null)
                    hash = hash * 59 + this.PackingSlipDescription.GetHashCode();
                
                if (this.AbsoluteMax != null)
                    hash = hash * 59 + this.AbsoluteMax.GetHashCode();
                
                if (this.AdditionalDescription != null)
                    hash = hash * 59 + this.AdditionalDescription.GetHashCode();
                
                if (this.Backorder != null)
                    hash = hash * 59 + this.Backorder.GetHashCode();
                
                if (this.ChargeCode != null)
                    hash = hash * 59 + this.ChargeCode.GetHashCode();
                
                if (this.CommodityCode != null)
                    hash = hash * 59 + this.CommodityCode.GetHashCode();
                
                if (this.CompCode != null)
                    hash = hash * 59 + this.CompCode.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.CriticalAmount != null)
                    hash = hash * 59 + this.CriticalAmount.GetHashCode();
                
                if (this.OverallFixedReorderPoint != null)
                    hash = hash * 59 + this.OverallFixedReorderPoint.GetHashCode();
                
                if (this.OverallLeadTime != null)
                    hash = hash * 59 + this.OverallLeadTime.GetHashCode();
                
                if (this.ListPrice != null)
                    hash = hash * 59 + this.ListPrice.GetHashCode();
                
                if (this.LotControlFlag != null)
                    hash = hash * 59 + this.LotControlFlag.GetHashCode();
                
                if (this.MaxCycle != null)
                    hash = hash * 59 + this.MaxCycle.GetHashCode();
                
                if (this.MaxInterim != null)
                    hash = hash * 59 + this.MaxInterim.GetHashCode();
                
                if (this.NumericSortOrder != null)
                    hash = hash * 59 + this.NumericSortOrder.GetHashCode();
                
                if (this.OutsideVendor != null)
                    hash = hash * 59 + this.OutsideVendor.GetHashCode();
                
                if (this.PickNo != null)
                    hash = hash * 59 + this.PickNo.GetHashCode();
                
                if (this.PodOrderSuffix != null)
                    hash = hash * 59 + this.PodOrderSuffix.GetHashCode();
                
                if (this.PodRevDate != null)
                    hash = hash * 59 + this.PodRevDate.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.SeasonalItem != null)
                    hash = hash * 59 + this.SeasonalItem.GetHashCode();
                
                if (this.RequiresProductionLot != null)
                    hash = hash * 59 + this.RequiresProductionLot.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                if (this.SerialCode != null)
                    hash = hash * 59 + this.SerialCode.GetHashCode();
                
                if (this.UnitCode != null)
                    hash = hash * 59 + this.UnitCode.GetHashCode();
                
                if (this.UnitsPerWrap != null)
                    hash = hash * 59 + this.UnitsPerWrap.GetHashCode();
                
                if (this.WeightPerWrap != null)
                    hash = hash * 59 + this.WeightPerWrap.GetHashCode();
                
                if (this.VoidDate != null)
                    hash = hash * 59 + this.VoidDate.GetHashCode();
                
                if (this.WrapCode != null)
                    hash = hash * 59 + this.WrapCode.GetHashCode();
                
                if (this.ExtrinsicText1 != null)
                    hash = hash * 59 + this.ExtrinsicText1.GetHashCode();
                
                if (this.ExtrinsicText2 != null)
                    hash = hash * 59 + this.ExtrinsicText2.GetHashCode();
                
                if (this.ExtrinsicText3 != null)
                    hash = hash * 59 + this.ExtrinsicText3.GetHashCode();
                
                if (this.ExtrinsicNumber1 != null)
                    hash = hash * 59 + this.ExtrinsicNumber1.GetHashCode();
                
                if (this.ExtrinsicNumber2 != null)
                    hash = hash * 59 + this.ExtrinsicNumber2.GetHashCode();
                
                if (this.ExtrinsicDecimal1 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal1.GetHashCode();
                
                if (this.ExtrinsicDecimal2 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal2.GetHashCode();
                
                if (this.CasebreakEnabled != null)
                    hash = hash * 59 + this.CasebreakEnabled.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.ForwardLotMixingRule != null)
                    hash = hash * 59 + this.ForwardLotMixingRule.GetHashCode();
                
                if (this.StorageLotMixingRule != null)
                    hash = hash * 59 + this.StorageLotMixingRule.GetHashCode();
                
                if (this.ForwardItemMixingRule != null)
                    hash = hash * 59 + this.ForwardItemMixingRule.GetHashCode();
                
                if (this.StorageItemMixingRule != null)
                    hash = hash * 59 + this.StorageItemMixingRule.GetHashCode();
                
                if (this.AllocationRule != null)
                    hash = hash * 59 + this.AllocationRule.GetHashCode();
                
                if (this.Hazmat != null)
                    hash = hash * 59 + this.Hazmat.GetHashCode();
                
                return hash;
            }
        }

    }
}
