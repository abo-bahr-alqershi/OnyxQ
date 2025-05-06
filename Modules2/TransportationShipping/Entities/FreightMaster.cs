using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects;
namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// FreightMaster Entity
/// </summary>
public class FreightMaster : Entity<FreightMasterId>
{

    private FreightMaster() { }

    public FreightMaster(FreightMasterId id, string freightSerial)
    {
        Id = id;
        FreightSerial = freightSerial;
    }

    /// <summary>
    /// The unique identifier for the FreightMaster
    /// المعرف الفريد لـ FreightMaster
    /// </summary>
    public FreightMasterId Id { get; private set; }

    /// <summary>
    /// FreightNumber of the FreightMaster
    /// FreightNumber الخاص بـ FreightMaster
    /// </summary>
    public string FreightNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the FreightMaster
    /// PurchaseOrderType الخاص بـ FreightMaster
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the FreightMaster
    /// PurchaseOrderNumber الخاص بـ FreightMaster
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the FreightMaster
    /// PurchaseOrderSerial الخاص بـ FreightMaster
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// FreightPolicyType of the FreightMaster
    /// FreightPolicyType الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightPolicyType { get; private set; }

    /// <summary>
    /// FreightDate of the FreightMaster
    /// FreightDate الخاص بـ FreightMaster
    /// </summary>
    public DateTime? FreightDate { get; private set; }

    /// <summary>
    /// FreightLastDate of the FreightMaster
    /// FreightLastDate الخاص بـ FreightMaster
    /// </summary>
    public DateTime? FreightLastDate { get; private set; }

    /// <summary>
    /// DeliveryDate of the FreightMaster
    /// DeliveryDate الخاص بـ FreightMaster
    /// </summary>
    public DateTime? DeliveryDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the FreightMaster
    /// ReferenceNumber الخاص بـ FreightMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PlaceDelivery of the FreightMaster
    /// PlaceDelivery الخاص بـ FreightMaster
    /// </summary>
    public string PlaceDelivery { get; private set; }

    /// <summary>
    /// PaymentTerms of the FreightMaster
    /// PaymentTerms الخاص بـ FreightMaster
    /// </summary>
    public string PaymentTerms { get; private set; }

    /// <summary>
    /// ModeDispatch of the FreightMaster
    /// ModeDispatch الخاص بـ FreightMaster
    /// </summary>
    public string ModeDispatch { get; private set; }

    /// <summary>
    /// PortOfArrival of the FreightMaster
    /// PortOfArrival الخاص بـ FreightMaster
    /// </summary>
    public string PortOfArrival { get; private set; }

    /// <summary>
    /// FreightType of the FreightMaster
    /// FreightType الخاص بـ FreightMaster
    /// </summary>
    public string FreightType { get; private set; }

    /// <summary>
    /// FreightMethod of the FreightMaster
    /// FreightMethod الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightMethod { get; private set; }

    /// <summary>
    /// PortOfFreight of the FreightMaster
    /// PortOfFreight الخاص بـ FreightMaster
    /// </summary>
    public string PortOfFreight { get; private set; }

    /// <summary>
    /// FreightCompany of the FreightMaster
    /// FreightCompany الخاص بـ FreightMaster
    /// </summary>
    public string FreightCompany { get; private set; }

    /// <summary>
    /// FreightDescription of the FreightMaster
    /// FreightDescription الخاص بـ FreightMaster
    /// </summary>
    public string FreightDescription { get; private set; }

    /// <summary>
    /// FreightExpense of the FreightMaster
    /// FreightExpense الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightExpense { get; private set; }

    /// <summary>
    /// FreightUnit of the FreightMaster
    /// FreightUnit الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightUnit { get; private set; }

    /// <summary>
    /// FreightUnitPrice of the FreightMaster
    /// FreightUnitPrice الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightUnitPrice { get; private set; }

    /// <summary>
    /// FreightAccountCurrency of the FreightMaster
    /// FreightAccountCurrency الخاص بـ FreightMaster
    /// </summary>
    public string FreightAccountCurrency { get; private set; }

    /// <summary>
    /// ContainerId of the FreightMaster
    /// ContainerId الخاص بـ FreightMaster
    /// </summary>
    public string ContainerId { get; private set; }

    /// <summary>
    /// ContainerNumber of the FreightMaster
    /// ContainerNumber الخاص بـ FreightMaster
    /// </summary>
    public decimal? ContainerNumber { get; private set; }

    /// <summary>
    /// ContainerSize of the FreightMaster
    /// ContainerSize الخاص بـ FreightMaster
    /// </summary>
    public decimal? ContainerSize { get; private set; }

    /// <summary>
    /// ContainerQuantity of the FreightMaster
    /// ContainerQuantity الخاص بـ FreightMaster
    /// </summary>
    public decimal? ContainerQuantity { get; private set; }

    /// <summary>
    /// FreightPartial of the FreightMaster
    /// FreightPartial الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightPartial { get; private set; }

    /// <summary>
    /// FreightAmount of the FreightMaster
    /// FreightAmount الخاص بـ FreightMaster
    /// </summary>
    public decimal? FreightAmount { get; private set; }

    /// <summary>
    /// FreightLine of the FreightMaster
    /// FreightLine الخاص بـ FreightMaster
    /// </summary>
    public string FreightLine { get; private set; }

    /// <summary>
    /// OriginCountry of the FreightMaster
    /// OriginCountry الخاص بـ FreightMaster
    /// </summary>
    public string OriginCountry { get; private set; }

    /// <summary>
    /// ExportCountry of the FreightMaster
    /// ExportCountry الخاص بـ FreightMaster
    /// </summary>
    public string ExportCountry { get; private set; }

    /// <summary>
    /// CommitmentNumber of the FreightMaster
    /// CommitmentNumber الخاص بـ FreightMaster
    /// </summary>
    public string CommitmentNumber { get; private set; }

    /// <summary>
    /// CommitmentDate of the FreightMaster
    /// CommitmentDate الخاص بـ FreightMaster
    /// </summary>
    public DateTime? CommitmentDate { get; private set; }

    /// <summary>
    /// CommitmentEndDate of the FreightMaster
    /// CommitmentEndDate الخاص بـ FreightMaster
    /// </summary>
    public DateTime? CommitmentEndDate { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the FreightMaster
    /// ProcessedFlagAlt الخاص بـ FreightMaster
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// FreightSerial of the FreightMaster
    /// FreightSerial الخاص بـ FreightMaster
    /// </summary>
    public string FreightSerial { get; private set; }

    /// <summary>
    /// FreightAccountCode of the FreightMaster
    /// FreightAccountCode الخاص بـ FreightMaster
    /// </summary>
    public string FreightAccountCode { get; private set; }

    /// <summary>
    /// VendorCode of the FreightMaster
    /// VendorCode الخاص بـ FreightMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the FreightMaster
    /// VendorName الخاص بـ FreightMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// DocNo of the FreightMaster
    /// DocNo الخاص بـ FreightMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the FreightMaster
    /// DocSer الخاص بـ FreightMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDesc of the FreightMaster
    /// DocDesc الخاص بـ FreightMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the FreightMaster
    /// CompanyNumberShort الخاص بـ FreightMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the FreightMaster
    /// BranchNumber الخاص بـ FreightMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the FreightMaster
    /// BranchYear الخاص بـ FreightMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the FreightMaster
    /// BranchUser الخاص بـ FreightMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PurchaseOrderCompany of the FreightMaster
    /// PurchaseOrderCompany الخاص بـ FreightMaster
    /// </summary>
    public string PurchaseOrderCompany { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

