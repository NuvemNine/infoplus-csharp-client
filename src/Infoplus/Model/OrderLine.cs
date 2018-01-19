/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// OrderLine
    /// </summary>
    [DataContract]
    public partial class OrderLine :  IEquatable<OrderLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine" /> class.
        /// </summary>
        /// <param name="OrderAssemblyInstructions">OrderAssemblyInstructions.</param>
        /// <param name="ItemAccountCodeId">ItemAccountCodeId (required).</param>
        /// <param name="ItemLegacyLowStockContactId">ItemLegacyLowStockContactId (required).</param>
        /// <param name="ItemMajorGroupId">ItemMajorGroupId (required).</param>
        /// <param name="ItemSubGroupId">ItemSubGroupId (required).</param>
        /// <param name="ItemProductCodeId">ItemProductCodeId.</param>
        /// <param name="ItemSummaryCodeId">ItemSummaryCodeId (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public OrderLine(string OrderAssemblyInstructions = default(string), int? ItemAccountCodeId = default(int?), int? ItemLegacyLowStockContactId = default(int?), int? ItemMajorGroupId = default(int?), int? ItemSubGroupId = default(int?), int? ItemProductCodeId = default(int?), int? ItemSummaryCodeId = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "ItemAccountCodeId" is required (not null)
            if (ItemAccountCodeId == null)
            {
                throw new InvalidDataException("ItemAccountCodeId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemAccountCodeId = ItemAccountCodeId;
            }
            // to ensure "ItemLegacyLowStockContactId" is required (not null)
            if (ItemLegacyLowStockContactId == null)
            {
                throw new InvalidDataException("ItemLegacyLowStockContactId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemLegacyLowStockContactId = ItemLegacyLowStockContactId;
            }
            // to ensure "ItemMajorGroupId" is required (not null)
            if (ItemMajorGroupId == null)
            {
                throw new InvalidDataException("ItemMajorGroupId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemMajorGroupId = ItemMajorGroupId;
            }
            // to ensure "ItemSubGroupId" is required (not null)
            if (ItemSubGroupId == null)
            {
                throw new InvalidDataException("ItemSubGroupId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemSubGroupId = ItemSubGroupId;
            }
            // to ensure "ItemSummaryCodeId" is required (not null)
            if (ItemSummaryCodeId == null)
            {
                throw new InvalidDataException("ItemSummaryCodeId is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.ItemSummaryCodeId = ItemSummaryCodeId;
            }
            this.OrderAssemblyInstructions = OrderAssemblyInstructions;
            this.ItemProductCodeId = ItemProductCodeId;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public decimal? OrderNo { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }

        /// <summary>
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; private set; }

        /// <summary>
        /// Gets or Sets OrderedQty
        /// </summary>
        [DataMember(Name="orderedQty", EmitDefaultValue=false)]
        public int? OrderedQty { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedQty
        /// </summary>
        [DataMember(Name="allowedQty", EmitDefaultValue=false)]
        public int? AllowedQty { get; private set; }

        /// <summary>
        /// Gets or Sets ShippedQty
        /// </summary>
        [DataMember(Name="shippedQty", EmitDefaultValue=false)]
        public int? ShippedQty { get; private set; }

        /// <summary>
        /// Gets or Sets BackorderQty
        /// </summary>
        [DataMember(Name="backorderQty", EmitDefaultValue=false)]
        public int? BackorderQty { get; private set; }

        /// <summary>
        /// Gets or Sets RevDate
        /// </summary>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; private set; }

        /// <summary>
        /// Gets or Sets ChargeCode
        /// </summary>
        [DataMember(Name="chargeCode", EmitDefaultValue=false)]
        public string ChargeCode { get; private set; }

        /// <summary>
        /// Gets or Sets DistributionCode
        /// </summary>
        [DataMember(Name="distributionCode", EmitDefaultValue=false)]
        public string DistributionCode { get; private set; }

        /// <summary>
        /// Gets or Sets Upc
        /// </summary>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; private set; }

        /// <summary>
        /// Gets or Sets VendorSKU
        /// </summary>
        [DataMember(Name="vendorSKU", EmitDefaultValue=false)]
        public string VendorSKU { get; private set; }

        /// <summary>
        /// Gets or Sets OrderSourceSKU
        /// </summary>
        [DataMember(Name="orderSourceSKU", EmitDefaultValue=false)]
        public string OrderSourceSKU { get; private set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="unitCost", EmitDefaultValue=false)]
        public decimal? UnitCost { get; private set; }

        /// <summary>
        /// Gets or Sets UnitSell
        /// </summary>
        [DataMember(Name="unitSell", EmitDefaultValue=false)]
        public decimal? UnitSell { get; private set; }

        /// <summary>
        /// Gets or Sets UnitDiscount
        /// </summary>
        [DataMember(Name="unitDiscount", EmitDefaultValue=false)]
        public decimal? UnitDiscount { get; private set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="extendedCost", EmitDefaultValue=false)]
        public decimal? ExtendedCost { get; private set; }

        /// <summary>
        /// Gets or Sets ExtendedSell
        /// </summary>
        [DataMember(Name="extendedSell", EmitDefaultValue=false)]
        public decimal? ExtendedSell { get; private set; }

        /// <summary>
        /// Gets or Sets ExtendedDiscount
        /// </summary>
        [DataMember(Name="extendedDiscount", EmitDefaultValue=false)]
        public decimal? ExtendedDiscount { get; private set; }

        /// <summary>
        /// Gets or Sets NcExtendedSell
        /// </summary>
        [DataMember(Name="ncExtendedSell", EmitDefaultValue=false)]
        public decimal? NcExtendedSell { get; private set; }

        /// <summary>
        /// Gets or Sets ItemWeight
        /// </summary>
        [DataMember(Name="itemWeight", EmitDefaultValue=false)]
        public decimal? ItemWeight { get; private set; }

        /// <summary>
        /// Gets or Sets ProductionLot
        /// </summary>
        [DataMember(Name="productionLot", EmitDefaultValue=false)]
        public string ProductionLot { get; private set; }

        /// <summary>
        /// Gets or Sets WeightPerWrap
        /// </summary>
        [DataMember(Name="weightPerWrap", EmitDefaultValue=false)]
        public decimal? WeightPerWrap { get; private set; }

        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; private set; }

        /// <summary>
        /// Gets or Sets OrderAssemblyInstructions
        /// </summary>
        [DataMember(Name="orderAssemblyInstructions", EmitDefaultValue=false)]
        public string OrderAssemblyInstructions { get; set; }

        /// <summary>
        /// Gets or Sets ItemAccountCodeId
        /// </summary>
        [DataMember(Name="itemAccountCodeId", EmitDefaultValue=false)]
        public int? ItemAccountCodeId { get; set; }

        /// <summary>
        /// Gets or Sets ItemLegacyLowStockContactId
        /// </summary>
        [DataMember(Name="itemLegacyLowStockContactId", EmitDefaultValue=false)]
        public int? ItemLegacyLowStockContactId { get; set; }

        /// <summary>
        /// Gets or Sets ItemMajorGroupId
        /// </summary>
        [DataMember(Name="itemMajorGroupId", EmitDefaultValue=false)]
        public int? ItemMajorGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ItemSubGroupId
        /// </summary>
        [DataMember(Name="itemSubGroupId", EmitDefaultValue=false)]
        public int? ItemSubGroupId { get; set; }

        /// <summary>
        /// Gets or Sets ItemProductCodeId
        /// </summary>
        [DataMember(Name="itemProductCodeId", EmitDefaultValue=false)]
        public int? ItemProductCodeId { get; set; }

        /// <summary>
        /// Gets or Sets ItemSummaryCodeId
        /// </summary>
        [DataMember(Name="itemSummaryCodeId", EmitDefaultValue=false)]
        public int? ItemSummaryCodeId { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  OrderedQty: ").Append(OrderedQty).Append("\n");
            sb.Append("  AllowedQty: ").Append(AllowedQty).Append("\n");
            sb.Append("  ShippedQty: ").Append(ShippedQty).Append("\n");
            sb.Append("  BackorderQty: ").Append(BackorderQty).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
            sb.Append("  DistributionCode: ").Append(DistributionCode).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  VendorSKU: ").Append(VendorSKU).Append("\n");
            sb.Append("  OrderSourceSKU: ").Append(OrderSourceSKU).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitSell: ").Append(UnitSell).Append("\n");
            sb.Append("  UnitDiscount: ").Append(UnitDiscount).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  ExtendedSell: ").Append(ExtendedSell).Append("\n");
            sb.Append("  ExtendedDiscount: ").Append(ExtendedDiscount).Append("\n");
            sb.Append("  NcExtendedSell: ").Append(NcExtendedSell).Append("\n");
            sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
            sb.Append("  ProductionLot: ").Append(ProductionLot).Append("\n");
            sb.Append("  WeightPerWrap: ").Append(WeightPerWrap).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  OrderAssemblyInstructions: ").Append(OrderAssemblyInstructions).Append("\n");
            sb.Append("  ItemAccountCodeId: ").Append(ItemAccountCodeId).Append("\n");
            sb.Append("  ItemLegacyLowStockContactId: ").Append(ItemLegacyLowStockContactId).Append("\n");
            sb.Append("  ItemMajorGroupId: ").Append(ItemMajorGroupId).Append("\n");
            sb.Append("  ItemSubGroupId: ").Append(ItemSubGroupId).Append("\n");
            sb.Append("  ItemProductCodeId: ").Append(ItemProductCodeId).Append("\n");
            sb.Append("  ItemSummaryCodeId: ").Append(ItemSummaryCodeId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderLine);
        }

        /// <summary>
        /// Returns true if OrderLine instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.PoNoId == input.PoNoId ||
                    (this.PoNoId != null &&
                    this.PoNoId.Equals(input.PoNoId))
                ) && 
                (
                    this.OrderedQty == input.OrderedQty ||
                    (this.OrderedQty != null &&
                    this.OrderedQty.Equals(input.OrderedQty))
                ) && 
                (
                    this.AllowedQty == input.AllowedQty ||
                    (this.AllowedQty != null &&
                    this.AllowedQty.Equals(input.AllowedQty))
                ) && 
                (
                    this.ShippedQty == input.ShippedQty ||
                    (this.ShippedQty != null &&
                    this.ShippedQty.Equals(input.ShippedQty))
                ) && 
                (
                    this.BackorderQty == input.BackorderQty ||
                    (this.BackorderQty != null &&
                    this.BackorderQty.Equals(input.BackorderQty))
                ) && 
                (
                    this.RevDate == input.RevDate ||
                    (this.RevDate != null &&
                    this.RevDate.Equals(input.RevDate))
                ) && 
                (
                    this.ChargeCode == input.ChargeCode ||
                    (this.ChargeCode != null &&
                    this.ChargeCode.Equals(input.ChargeCode))
                ) && 
                (
                    this.DistributionCode == input.DistributionCode ||
                    (this.DistributionCode != null &&
                    this.DistributionCode.Equals(input.DistributionCode))
                ) && 
                (
                    this.Upc == input.Upc ||
                    (this.Upc != null &&
                    this.Upc.Equals(input.Upc))
                ) && 
                (
                    this.VendorSKU == input.VendorSKU ||
                    (this.VendorSKU != null &&
                    this.VendorSKU.Equals(input.VendorSKU))
                ) && 
                (
                    this.OrderSourceSKU == input.OrderSourceSKU ||
                    (this.OrderSourceSKU != null &&
                    this.OrderSourceSKU.Equals(input.OrderSourceSKU))
                ) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && 
                (
                    this.UnitSell == input.UnitSell ||
                    (this.UnitSell != null &&
                    this.UnitSell.Equals(input.UnitSell))
                ) && 
                (
                    this.UnitDiscount == input.UnitDiscount ||
                    (this.UnitDiscount != null &&
                    this.UnitDiscount.Equals(input.UnitDiscount))
                ) && 
                (
                    this.ExtendedCost == input.ExtendedCost ||
                    (this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(input.ExtendedCost))
                ) && 
                (
                    this.ExtendedSell == input.ExtendedSell ||
                    (this.ExtendedSell != null &&
                    this.ExtendedSell.Equals(input.ExtendedSell))
                ) && 
                (
                    this.ExtendedDiscount == input.ExtendedDiscount ||
                    (this.ExtendedDiscount != null &&
                    this.ExtendedDiscount.Equals(input.ExtendedDiscount))
                ) && 
                (
                    this.NcExtendedSell == input.NcExtendedSell ||
                    (this.NcExtendedSell != null &&
                    this.NcExtendedSell.Equals(input.NcExtendedSell))
                ) && 
                (
                    this.ItemWeight == input.ItemWeight ||
                    (this.ItemWeight != null &&
                    this.ItemWeight.Equals(input.ItemWeight))
                ) && 
                (
                    this.ProductionLot == input.ProductionLot ||
                    (this.ProductionLot != null &&
                    this.ProductionLot.Equals(input.ProductionLot))
                ) && 
                (
                    this.WeightPerWrap == input.WeightPerWrap ||
                    (this.WeightPerWrap != null &&
                    this.WeightPerWrap.Equals(input.WeightPerWrap))
                ) && 
                (
                    this.Sector == input.Sector ||
                    (this.Sector != null &&
                    this.Sector.Equals(input.Sector))
                ) && 
                (
                    this.OrderAssemblyInstructions == input.OrderAssemblyInstructions ||
                    (this.OrderAssemblyInstructions != null &&
                    this.OrderAssemblyInstructions.Equals(input.OrderAssemblyInstructions))
                ) && 
                (
                    this.ItemAccountCodeId == input.ItemAccountCodeId ||
                    (this.ItemAccountCodeId != null &&
                    this.ItemAccountCodeId.Equals(input.ItemAccountCodeId))
                ) && 
                (
                    this.ItemLegacyLowStockContactId == input.ItemLegacyLowStockContactId ||
                    (this.ItemLegacyLowStockContactId != null &&
                    this.ItemLegacyLowStockContactId.Equals(input.ItemLegacyLowStockContactId))
                ) && 
                (
                    this.ItemMajorGroupId == input.ItemMajorGroupId ||
                    (this.ItemMajorGroupId != null &&
                    this.ItemMajorGroupId.Equals(input.ItemMajorGroupId))
                ) && 
                (
                    this.ItemSubGroupId == input.ItemSubGroupId ||
                    (this.ItemSubGroupId != null &&
                    this.ItemSubGroupId.Equals(input.ItemSubGroupId))
                ) && 
                (
                    this.ItemProductCodeId == input.ItemProductCodeId ||
                    (this.ItemProductCodeId != null &&
                    this.ItemProductCodeId.Equals(input.ItemProductCodeId))
                ) && 
                (
                    this.ItemSummaryCodeId == input.ItemSummaryCodeId ||
                    (this.ItemSummaryCodeId != null &&
                    this.ItemSummaryCodeId.Equals(input.ItemSummaryCodeId))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrderNo != null)
                    hashCode = hashCode * 59 + this.OrderNo.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.PoNoId != null)
                    hashCode = hashCode * 59 + this.PoNoId.GetHashCode();
                if (this.OrderedQty != null)
                    hashCode = hashCode * 59 + this.OrderedQty.GetHashCode();
                if (this.AllowedQty != null)
                    hashCode = hashCode * 59 + this.AllowedQty.GetHashCode();
                if (this.ShippedQty != null)
                    hashCode = hashCode * 59 + this.ShippedQty.GetHashCode();
                if (this.BackorderQty != null)
                    hashCode = hashCode * 59 + this.BackorderQty.GetHashCode();
                if (this.RevDate != null)
                    hashCode = hashCode * 59 + this.RevDate.GetHashCode();
                if (this.ChargeCode != null)
                    hashCode = hashCode * 59 + this.ChargeCode.GetHashCode();
                if (this.DistributionCode != null)
                    hashCode = hashCode * 59 + this.DistributionCode.GetHashCode();
                if (this.Upc != null)
                    hashCode = hashCode * 59 + this.Upc.GetHashCode();
                if (this.VendorSKU != null)
                    hashCode = hashCode * 59 + this.VendorSKU.GetHashCode();
                if (this.OrderSourceSKU != null)
                    hashCode = hashCode * 59 + this.OrderSourceSKU.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UnitSell != null)
                    hashCode = hashCode * 59 + this.UnitSell.GetHashCode();
                if (this.UnitDiscount != null)
                    hashCode = hashCode * 59 + this.UnitDiscount.GetHashCode();
                if (this.ExtendedCost != null)
                    hashCode = hashCode * 59 + this.ExtendedCost.GetHashCode();
                if (this.ExtendedSell != null)
                    hashCode = hashCode * 59 + this.ExtendedSell.GetHashCode();
                if (this.ExtendedDiscount != null)
                    hashCode = hashCode * 59 + this.ExtendedDiscount.GetHashCode();
                if (this.NcExtendedSell != null)
                    hashCode = hashCode * 59 + this.NcExtendedSell.GetHashCode();
                if (this.ItemWeight != null)
                    hashCode = hashCode * 59 + this.ItemWeight.GetHashCode();
                if (this.ProductionLot != null)
                    hashCode = hashCode * 59 + this.ProductionLot.GetHashCode();
                if (this.WeightPerWrap != null)
                    hashCode = hashCode * 59 + this.WeightPerWrap.GetHashCode();
                if (this.Sector != null)
                    hashCode = hashCode * 59 + this.Sector.GetHashCode();
                if (this.OrderAssemblyInstructions != null)
                    hashCode = hashCode * 59 + this.OrderAssemblyInstructions.GetHashCode();
                if (this.ItemAccountCodeId != null)
                    hashCode = hashCode * 59 + this.ItemAccountCodeId.GetHashCode();
                if (this.ItemLegacyLowStockContactId != null)
                    hashCode = hashCode * 59 + this.ItemLegacyLowStockContactId.GetHashCode();
                if (this.ItemMajorGroupId != null)
                    hashCode = hashCode * 59 + this.ItemMajorGroupId.GetHashCode();
                if (this.ItemSubGroupId != null)
                    hashCode = hashCode * 59 + this.ItemSubGroupId.GetHashCode();
                if (this.ItemProductCodeId != null)
                    hashCode = hashCode * 59 + this.ItemProductCodeId.GetHashCode();
                if (this.ItemSummaryCodeId != null)
                    hashCode = hashCode * 59 + this.ItemSummaryCodeId.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
