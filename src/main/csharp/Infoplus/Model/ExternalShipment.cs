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
    public partial class ExternalShipment :  IEquatable<ExternalShipment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShipment" /> class.
        /// Initializes a new instance of the <see cref="ExternalShipment" />class.
        /// </summary>
        /// <param name="OrderId">OrderId (required).</param>
        /// <param name="CarrierId">CarrierId (required).</param>
        /// <param name="ParcelAccountId">ParcelAccountId (required).</param>
        /// <param name="ThirdPartyParcelAccountId">ThirdPartyParcelAccountId.</param>
        /// <param name="Freight">Freight.</param>
        /// <param name="TrackingNo">TrackingNo (required).</param>
        /// <param name="Dim1In">Dim1In.</param>
        /// <param name="Dim2In">Dim2In.</param>
        /// <param name="Dim3In">Dim3In.</param>
        /// <param name="WeightLbs">WeightLbs.</param>
        /// <param name="DimWeight">DimWeight.</param>
        /// <param name="Residential">Residential (default to false).</param>
        /// <param name="Zone">Zone.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ExternalShipment(double? OrderId = null, int? CarrierId = null, int? ParcelAccountId = null, int? ThirdPartyParcelAccountId = null, double? Freight = null, string TrackingNo = null, double? Dim1In = null, double? Dim2In = null, double? Dim3In = null, double? WeightLbs = null, double? DimWeight = null, bool? Residential = null, string Zone = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for ExternalShipment and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            // to ensure "CarrierId" is required (not null)
            if (CarrierId == null)
            {
                throw new InvalidDataException("CarrierId is a required property for ExternalShipment and cannot be null");
            }
            else
            {
                this.CarrierId = CarrierId;
            }
            // to ensure "ParcelAccountId" is required (not null)
            if (ParcelAccountId == null)
            {
                throw new InvalidDataException("ParcelAccountId is a required property for ExternalShipment and cannot be null");
            }
            else
            {
                this.ParcelAccountId = ParcelAccountId;
            }
            // to ensure "TrackingNo" is required (not null)
            if (TrackingNo == null)
            {
                throw new InvalidDataException("TrackingNo is a required property for ExternalShipment and cannot be null");
            }
            else
            {
                this.TrackingNo = TrackingNo;
            }
            this.ThirdPartyParcelAccountId = ThirdPartyParcelAccountId;
            this.Freight = Freight;
            this.Dim1In = Dim1In;
            this.Dim2In = Dim2In;
            this.Dim3In = Dim3In;
            this.WeightLbs = WeightLbs;
            this.DimWeight = DimWeight;
            // use default value if no "Residential" provided
            if (Residential == null)
            {
                this.Residential = false;
            }
            else
            {
                this.Residential = Residential;
            }
            this.Zone = Zone;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public double? OrderId { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrierId", EmitDefaultValue=false)]
        public int? CarrierId { get; set; }
    
        /// <summary>
        /// Gets or Sets ParcelAccountId
        /// </summary>
        [DataMember(Name="parcelAccountId", EmitDefaultValue=false)]
        public int? ParcelAccountId { get; set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyParcelAccountId
        /// </summary>
        [DataMember(Name="thirdPartyParcelAccountId", EmitDefaultValue=false)]
        public int? ThirdPartyParcelAccountId { get; set; }
    
        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="freight", EmitDefaultValue=false)]
        public double? Freight { get; set; }
    
        /// <summary>
        /// Gets or Sets TrackingNo
        /// </summary>
        [DataMember(Name="trackingNo", EmitDefaultValue=false)]
        public string TrackingNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim1In
        /// </summary>
        [DataMember(Name="dim1In", EmitDefaultValue=false)]
        public double? Dim1In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim2In
        /// </summary>
        [DataMember(Name="dim2In", EmitDefaultValue=false)]
        public double? Dim2In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim3In
        /// </summary>
        [DataMember(Name="dim3In", EmitDefaultValue=false)]
        public double? Dim3In { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; set; }
    
        /// <summary>
        /// Gets or Sets DimWeight
        /// </summary>
        [DataMember(Name="dimWeight", EmitDefaultValue=false)]
        public double? DimWeight { get; set; }
    
        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public bool? Residential { get; set; }
    
        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string Zone { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
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
            sb.Append("class ExternalShipment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  ParcelAccountId: ").Append(ParcelAccountId).Append("\n");
            sb.Append("  ThirdPartyParcelAccountId: ").Append(ThirdPartyParcelAccountId).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
            sb.Append("  Dim1In: ").Append(Dim1In).Append("\n");
            sb.Append("  Dim2In: ").Append(Dim2In).Append("\n");
            sb.Append("  Dim3In: ").Append(Dim3In).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  DimWeight: ").Append(DimWeight).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExternalShipment);
        }

        /// <summary>
        /// Returns true if ExternalShipment instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalShipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalShipment other)
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
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
                ) && 
                (
                    this.ParcelAccountId == other.ParcelAccountId ||
                    this.ParcelAccountId != null &&
                    this.ParcelAccountId.Equals(other.ParcelAccountId)
                ) && 
                (
                    this.ThirdPartyParcelAccountId == other.ThirdPartyParcelAccountId ||
                    this.ThirdPartyParcelAccountId != null &&
                    this.ThirdPartyParcelAccountId.Equals(other.ThirdPartyParcelAccountId)
                ) && 
                (
                    this.Freight == other.Freight ||
                    this.Freight != null &&
                    this.Freight.Equals(other.Freight)
                ) && 
                (
                    this.TrackingNo == other.TrackingNo ||
                    this.TrackingNo != null &&
                    this.TrackingNo.Equals(other.TrackingNo)
                ) && 
                (
                    this.Dim1In == other.Dim1In ||
                    this.Dim1In != null &&
                    this.Dim1In.Equals(other.Dim1In)
                ) && 
                (
                    this.Dim2In == other.Dim2In ||
                    this.Dim2In != null &&
                    this.Dim2In.Equals(other.Dim2In)
                ) && 
                (
                    this.Dim3In == other.Dim3In ||
                    this.Dim3In != null &&
                    this.Dim3In.Equals(other.Dim3In)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
                ) && 
                (
                    this.DimWeight == other.DimWeight ||
                    this.DimWeight != null &&
                    this.DimWeight.Equals(other.DimWeight)
                ) && 
                (
                    this.Residential == other.Residential ||
                    this.Residential != null &&
                    this.Residential.Equals(other.Residential)
                ) && 
                (
                    this.Zone == other.Zone ||
                    this.Zone != null &&
                    this.Zone.Equals(other.Zone)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                
                if (this.CarrierId != null)
                    hash = hash * 59 + this.CarrierId.GetHashCode();
                
                if (this.ParcelAccountId != null)
                    hash = hash * 59 + this.ParcelAccountId.GetHashCode();
                
                if (this.ThirdPartyParcelAccountId != null)
                    hash = hash * 59 + this.ThirdPartyParcelAccountId.GetHashCode();
                
                if (this.Freight != null)
                    hash = hash * 59 + this.Freight.GetHashCode();
                
                if (this.TrackingNo != null)
                    hash = hash * 59 + this.TrackingNo.GetHashCode();
                
                if (this.Dim1In != null)
                    hash = hash * 59 + this.Dim1In.GetHashCode();
                
                if (this.Dim2In != null)
                    hash = hash * 59 + this.Dim2In.GetHashCode();
                
                if (this.Dim3In != null)
                    hash = hash * 59 + this.Dim3In.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.DimWeight != null)
                    hash = hash * 59 + this.DimWeight.GetHashCode();
                
                if (this.Residential != null)
                    hash = hash * 59 + this.Residential.GetHashCode();
                
                if (this.Zone != null)
                    hash = hash * 59 + this.Zone.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
