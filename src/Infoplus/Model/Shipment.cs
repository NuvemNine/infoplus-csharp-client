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
    /// Shipment
    /// </summary>
    [DataContract]
    public partial class Shipment :  IEquatable<Shipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Shipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="CartonNo">CartonNo.</param>
        /// <param name="NumberOfCartons">NumberOfCartons.</param>
        /// <param name="Shipped">Shipped (default to false).</param>
        /// <param name="CarrierServiceId">CarrierServiceId.</param>
        /// <param name="Dim1In">Dim1In.</param>
        /// <param name="Dim2In">Dim2In.</param>
        /// <param name="Dim3In">Dim3In.</param>
        /// <param name="EstimatedZone">EstimatedZone.</param>
        /// <param name="CarrierCompany">CarrierCompany (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Shipment(int? Id = default(int?), int? WarehouseId = default(int?), int? CartonNo = default(int?), int? NumberOfCartons = default(int?), bool? Shipped = false, int? CarrierServiceId = default(int?), decimal? Dim1In = default(decimal?), decimal? Dim2In = default(decimal?), decimal? Dim3In = default(decimal?), string EstimatedZone = default(string), string CarrierCompany = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Shipment and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "CarrierCompany" is required (not null)
            if (CarrierCompany == null)
            {
                throw new InvalidDataException("CarrierCompany is a required property for Shipment and cannot be null");
            }
            else
            {
                this.CarrierCompany = CarrierCompany;
            }
            this.Id = Id;
            this.CartonNo = CartonNo;
            this.NumberOfCartons = NumberOfCartons;
            // use default value if no "Shipped" provided
            if (Shipped == null)
            {
                this.Shipped = false;
            }
            else
            {
                this.Shipped = Shipped;
            }
            this.CarrierServiceId = CarrierServiceId;
            this.Dim1In = Dim1In;
            this.Dim2In = Dim2In;
            this.Dim3In = Dim3In;
            this.EstimatedZone = EstimatedZone;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }

        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }

        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveredDate
        /// </summary>
        [DataMember(Name="deliveredDate", EmitDefaultValue=false)]
        public DateTime? DeliveredDate { get; private set; }

        /// <summary>
        /// Gets or Sets TrackingNo
        /// </summary>
        [DataMember(Name="trackingNo", EmitDefaultValue=false)]
        public string TrackingNo { get; private set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }

        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public decimal? OrderNo { get; private set; }

        /// <summary>
        /// Gets or Sets CartonNo
        /// </summary>
        [DataMember(Name="cartonNo", EmitDefaultValue=false)]
        public int? CartonNo { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfCartons
        /// </summary>
        [DataMember(Name="numberOfCartons", EmitDefaultValue=false)]
        public int? NumberOfCartons { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets Shipped
        /// </summary>
        [DataMember(Name="shipped", EmitDefaultValue=false)]
        public bool? Shipped { get; set; }

        /// <summary>
        /// Gets or Sets CarrierServiceId
        /// </summary>
        [DataMember(Name="carrierServiceId", EmitDefaultValue=false)]
        public int? CarrierServiceId { get; set; }

        /// <summary>
        /// Gets or Sets Dim1In
        /// </summary>
        [DataMember(Name="dim1In", EmitDefaultValue=false)]
        public decimal? Dim1In { get; set; }

        /// <summary>
        /// Gets or Sets Dim2In
        /// </summary>
        [DataMember(Name="dim2In", EmitDefaultValue=false)]
        public decimal? Dim2In { get; set; }

        /// <summary>
        /// Gets or Sets Dim3In
        /// </summary>
        [DataMember(Name="dim3In", EmitDefaultValue=false)]
        public decimal? Dim3In { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedZone
        /// </summary>
        [DataMember(Name="estimatedZone", EmitDefaultValue=false)]
        public string EstimatedZone { get; set; }

        /// <summary>
        /// Gets or Sets ParcelAccountNo
        /// </summary>
        [DataMember(Name="parcelAccountNo", EmitDefaultValue=false)]
        public string ParcelAccountNo { get; private set; }

        /// <summary>
        /// Gets or Sets ThirdPartyParcelAccountNo
        /// </summary>
        [DataMember(Name="thirdPartyParcelAccountNo", EmitDefaultValue=false)]
        public string ThirdPartyParcelAccountNo { get; private set; }

        /// <summary>
        /// Gets or Sets ShipmentID
        /// </summary>
        [DataMember(Name="shipmentID", EmitDefaultValue=false)]
        public string ShipmentID { get; private set; }

        /// <summary>
        /// Gets or Sets ManifestId
        /// </summary>
        [DataMember(Name="manifestId", EmitDefaultValue=false)]
        public int? ManifestId { get; private set; }

        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public bool? Residential { get; private set; }

        /// <summary>
        /// Gets or Sets BillingOption
        /// </summary>
        [DataMember(Name="billingOption", EmitDefaultValue=false)]
        public string BillingOption { get; private set; }

        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public decimal? WeightLbs { get; private set; }

        /// <summary>
        /// Gets or Sets DimWeight
        /// </summary>
        [DataMember(Name="dimWeight", EmitDefaultValue=false)]
        public decimal? DimWeight { get; private set; }

        /// <summary>
        /// Gets or Sets LicensePlateNumber
        /// </summary>
        [DataMember(Name="licensePlateNumber", EmitDefaultValue=false)]
        public string LicensePlateNumber { get; private set; }

        /// <summary>
        /// Gets or Sets ChargedFreightAmount
        /// </summary>
        [DataMember(Name="chargedFreightAmount", EmitDefaultValue=false)]
        public decimal? ChargedFreightAmount { get; private set; }

        /// <summary>
        /// Gets or Sets PublishedFreightAmount
        /// </summary>
        [DataMember(Name="publishedFreightAmount", EmitDefaultValue=false)]
        public decimal? PublishedFreightAmount { get; private set; }

        /// <summary>
        /// Gets or Sets RetailFreightAmount
        /// </summary>
        [DataMember(Name="retailFreightAmount", EmitDefaultValue=false)]
        public decimal? RetailFreightAmount { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalShippingSystemId
        /// </summary>
        [DataMember(Name="externalShippingSystemId", EmitDefaultValue=false)]
        public int? ExternalShippingSystemId { get; private set; }

        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name="shipmentType", EmitDefaultValue=false)]
        public string ShipmentType { get; private set; }

        /// <summary>
        /// Gets or Sets CarrierCompany
        /// </summary>
        [DataMember(Name="carrierCompany", EmitDefaultValue=false)]
        public string CarrierCompany { get; set; }

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
            sb.Append("class Shipment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  DeliveredDate: ").Append(DeliveredDate).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CartonNo: ").Append(CartonNo).Append("\n");
            sb.Append("  NumberOfCartons: ").Append(NumberOfCartons).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Shipped: ").Append(Shipped).Append("\n");
            sb.Append("  CarrierServiceId: ").Append(CarrierServiceId).Append("\n");
            sb.Append("  Dim1In: ").Append(Dim1In).Append("\n");
            sb.Append("  Dim2In: ").Append(Dim2In).Append("\n");
            sb.Append("  Dim3In: ").Append(Dim3In).Append("\n");
            sb.Append("  EstimatedZone: ").Append(EstimatedZone).Append("\n");
            sb.Append("  ParcelAccountNo: ").Append(ParcelAccountNo).Append("\n");
            sb.Append("  ThirdPartyParcelAccountNo: ").Append(ThirdPartyParcelAccountNo).Append("\n");
            sb.Append("  ShipmentID: ").Append(ShipmentID).Append("\n");
            sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  BillingOption: ").Append(BillingOption).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  DimWeight: ").Append(DimWeight).Append("\n");
            sb.Append("  LicensePlateNumber: ").Append(LicensePlateNumber).Append("\n");
            sb.Append("  ChargedFreightAmount: ").Append(ChargedFreightAmount).Append("\n");
            sb.Append("  PublishedFreightAmount: ").Append(PublishedFreightAmount).Append("\n");
            sb.Append("  RetailFreightAmount: ").Append(RetailFreightAmount).Append("\n");
            sb.Append("  ExternalShippingSystemId: ").Append(ExternalShippingSystemId).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
            sb.Append("  CarrierCompany: ").Append(CarrierCompany).Append("\n");
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
            return this.Equals(input as Shipment);
        }

        /// <summary>
        /// Returns true if Shipment instances are equal
        /// </summary>
        /// <param name="input">Instance of Shipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipment input)
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
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) && 
                (
                    this.DeliveredDate == input.DeliveredDate ||
                    (this.DeliveredDate != null &&
                    this.DeliveredDate.Equals(input.DeliveredDate))
                ) && 
                (
                    this.TrackingNo == input.TrackingNo ||
                    (this.TrackingNo != null &&
                    this.TrackingNo.Equals(input.TrackingNo))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.CartonNo == input.CartonNo ||
                    (this.CartonNo != null &&
                    this.CartonNo.Equals(input.CartonNo))
                ) && 
                (
                    this.NumberOfCartons == input.NumberOfCartons ||
                    (this.NumberOfCartons != null &&
                    this.NumberOfCartons.Equals(input.NumberOfCartons))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Shipped == input.Shipped ||
                    (this.Shipped != null &&
                    this.Shipped.Equals(input.Shipped))
                ) && 
                (
                    this.CarrierServiceId == input.CarrierServiceId ||
                    (this.CarrierServiceId != null &&
                    this.CarrierServiceId.Equals(input.CarrierServiceId))
                ) && 
                (
                    this.Dim1In == input.Dim1In ||
                    (this.Dim1In != null &&
                    this.Dim1In.Equals(input.Dim1In))
                ) && 
                (
                    this.Dim2In == input.Dim2In ||
                    (this.Dim2In != null &&
                    this.Dim2In.Equals(input.Dim2In))
                ) && 
                (
                    this.Dim3In == input.Dim3In ||
                    (this.Dim3In != null &&
                    this.Dim3In.Equals(input.Dim3In))
                ) && 
                (
                    this.EstimatedZone == input.EstimatedZone ||
                    (this.EstimatedZone != null &&
                    this.EstimatedZone.Equals(input.EstimatedZone))
                ) && 
                (
                    this.ParcelAccountNo == input.ParcelAccountNo ||
                    (this.ParcelAccountNo != null &&
                    this.ParcelAccountNo.Equals(input.ParcelAccountNo))
                ) && 
                (
                    this.ThirdPartyParcelAccountNo == input.ThirdPartyParcelAccountNo ||
                    (this.ThirdPartyParcelAccountNo != null &&
                    this.ThirdPartyParcelAccountNo.Equals(input.ThirdPartyParcelAccountNo))
                ) && 
                (
                    this.ShipmentID == input.ShipmentID ||
                    (this.ShipmentID != null &&
                    this.ShipmentID.Equals(input.ShipmentID))
                ) && 
                (
                    this.ManifestId == input.ManifestId ||
                    (this.ManifestId != null &&
                    this.ManifestId.Equals(input.ManifestId))
                ) && 
                (
                    this.Residential == input.Residential ||
                    (this.Residential != null &&
                    this.Residential.Equals(input.Residential))
                ) && 
                (
                    this.BillingOption == input.BillingOption ||
                    (this.BillingOption != null &&
                    this.BillingOption.Equals(input.BillingOption))
                ) && 
                (
                    this.WeightLbs == input.WeightLbs ||
                    (this.WeightLbs != null &&
                    this.WeightLbs.Equals(input.WeightLbs))
                ) && 
                (
                    this.DimWeight == input.DimWeight ||
                    (this.DimWeight != null &&
                    this.DimWeight.Equals(input.DimWeight))
                ) && 
                (
                    this.LicensePlateNumber == input.LicensePlateNumber ||
                    (this.LicensePlateNumber != null &&
                    this.LicensePlateNumber.Equals(input.LicensePlateNumber))
                ) && 
                (
                    this.ChargedFreightAmount == input.ChargedFreightAmount ||
                    (this.ChargedFreightAmount != null &&
                    this.ChargedFreightAmount.Equals(input.ChargedFreightAmount))
                ) && 
                (
                    this.PublishedFreightAmount == input.PublishedFreightAmount ||
                    (this.PublishedFreightAmount != null &&
                    this.PublishedFreightAmount.Equals(input.PublishedFreightAmount))
                ) && 
                (
                    this.RetailFreightAmount == input.RetailFreightAmount ||
                    (this.RetailFreightAmount != null &&
                    this.RetailFreightAmount.Equals(input.RetailFreightAmount))
                ) && 
                (
                    this.ExternalShippingSystemId == input.ExternalShippingSystemId ||
                    (this.ExternalShippingSystemId != null &&
                    this.ExternalShippingSystemId.Equals(input.ExternalShippingSystemId))
                ) && 
                (
                    this.ShipmentType == input.ShipmentType ||
                    (this.ShipmentType != null &&
                    this.ShipmentType.Equals(input.ShipmentType))
                ) && 
                (
                    this.CarrierCompany == input.CarrierCompany ||
                    (this.CarrierCompany != null &&
                    this.CarrierCompany.Equals(input.CarrierCompany))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.DeliveredDate != null)
                    hashCode = hashCode * 59 + this.DeliveredDate.GetHashCode();
                if (this.TrackingNo != null)
                    hashCode = hashCode * 59 + this.TrackingNo.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.OrderNo != null)
                    hashCode = hashCode * 59 + this.OrderNo.GetHashCode();
                if (this.CartonNo != null)
                    hashCode = hashCode * 59 + this.CartonNo.GetHashCode();
                if (this.NumberOfCartons != null)
                    hashCode = hashCode * 59 + this.NumberOfCartons.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Shipped != null)
                    hashCode = hashCode * 59 + this.Shipped.GetHashCode();
                if (this.CarrierServiceId != null)
                    hashCode = hashCode * 59 + this.CarrierServiceId.GetHashCode();
                if (this.Dim1In != null)
                    hashCode = hashCode * 59 + this.Dim1In.GetHashCode();
                if (this.Dim2In != null)
                    hashCode = hashCode * 59 + this.Dim2In.GetHashCode();
                if (this.Dim3In != null)
                    hashCode = hashCode * 59 + this.Dim3In.GetHashCode();
                if (this.EstimatedZone != null)
                    hashCode = hashCode * 59 + this.EstimatedZone.GetHashCode();
                if (this.ParcelAccountNo != null)
                    hashCode = hashCode * 59 + this.ParcelAccountNo.GetHashCode();
                if (this.ThirdPartyParcelAccountNo != null)
                    hashCode = hashCode * 59 + this.ThirdPartyParcelAccountNo.GetHashCode();
                if (this.ShipmentID != null)
                    hashCode = hashCode * 59 + this.ShipmentID.GetHashCode();
                if (this.ManifestId != null)
                    hashCode = hashCode * 59 + this.ManifestId.GetHashCode();
                if (this.Residential != null)
                    hashCode = hashCode * 59 + this.Residential.GetHashCode();
                if (this.BillingOption != null)
                    hashCode = hashCode * 59 + this.BillingOption.GetHashCode();
                if (this.WeightLbs != null)
                    hashCode = hashCode * 59 + this.WeightLbs.GetHashCode();
                if (this.DimWeight != null)
                    hashCode = hashCode * 59 + this.DimWeight.GetHashCode();
                if (this.LicensePlateNumber != null)
                    hashCode = hashCode * 59 + this.LicensePlateNumber.GetHashCode();
                if (this.ChargedFreightAmount != null)
                    hashCode = hashCode * 59 + this.ChargedFreightAmount.GetHashCode();
                if (this.PublishedFreightAmount != null)
                    hashCode = hashCode * 59 + this.PublishedFreightAmount.GetHashCode();
                if (this.RetailFreightAmount != null)
                    hashCode = hashCode * 59 + this.RetailFreightAmount.GetHashCode();
                if (this.ExternalShippingSystemId != null)
                    hashCode = hashCode * 59 + this.ExternalShippingSystemId.GetHashCode();
                if (this.ShipmentType != null)
                    hashCode = hashCode * 59 + this.ShipmentType.GetHashCode();
                if (this.CarrierCompany != null)
                    hashCode = hashCode * 59 + this.CarrierCompany.GetHashCode();
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
