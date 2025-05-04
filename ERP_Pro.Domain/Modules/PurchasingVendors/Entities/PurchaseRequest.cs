using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequest Entity
/// </summary>
public class PurchaseRequest : Entity<PurchaseRequestId>
{

    private PurchaseRequest() { }

    public PurchaseRequest(PurchaseRequestId id, decimal? priceSerial)
    {
        Id = id;
        PriceSerial = priceSerial;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequest
    /// المعرف الفريد لـ PurchaseRequest
    /// </summary>
    public PurchaseRequestId Id { get; private set; }

    /// <summary>
    /// PriceNumber of the PurchaseRequest
    /// PriceNumber الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// PriceSerial of the PurchaseRequest
    /// PriceSerial الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? PriceSerial { get; private set; }

    /// <summary>
    /// PriceDate of the PurchaseRequest
    /// PriceDate الخاص بـ PurchaseRequest
    /// </summary>
    public DateTime? PriceDate { get; private set; }

    /// <summary>
    /// HierarchyNumber of the PurchaseRequest
    /// HierarchyNumber الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// PriceDescription of the PurchaseRequest
    /// PriceDescription الخاص بـ PurchaseRequest
    /// </summary>
    public string PriceDescription { get; private set; }

    /// <summary>
    /// SideRequest of the PurchaseRequest
    /// SideRequest الخاص بـ PurchaseRequest
    /// </summary>
    public string SideRequest { get; private set; }

    /// <summary>
    /// RequestAvailableDate of the PurchaseRequest
    /// RequestAvailableDate الخاص بـ PurchaseRequest
    /// </summary>
    public DateTime? RequestAvailableDate { get; private set; }

    /// <summary>
    /// PriceSelected of the PurchaseRequest
    /// PriceSelected الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? PriceSelected { get; private set; }

    /// <summary>
    /// PricePartial of the PurchaseRequest
    /// PricePartial الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? PricePartial { get; private set; }

    /// <summary>
    /// ApprovedFlag of the PurchaseRequest
    /// ApprovedFlag الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the PurchaseRequest
    /// ApprovalUserId الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the PurchaseRequest
    /// ApprovalDate الخاص بـ PurchaseRequest
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the PurchaseRequest
    /// ApprovalDescription الخاص بـ PurchaseRequest
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// AssignedToUserId of the PurchaseRequest
    /// AssignedToUserId الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? AssignedToUserId { get; private set; }

    /// <summary>
    /// AssignedUserId of the PurchaseRequest
    /// AssignedUserId الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? AssignedUserId { get; private set; }

    /// <summary>
    /// AssignedDate of the PurchaseRequest
    /// AssignedDate الخاص بـ PurchaseRequest
    /// </summary>
    public DateTime? AssignedDate { get; private set; }

    /// <summary>
    /// OutgoingRequestType of the PurchaseRequest
    /// OutgoingRequestType الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? OutgoingRequestType { get; private set; }

    /// <summary>
    /// OutgoingRequestNumber of the PurchaseRequest
    /// OutgoingRequestNumber الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? OutgoingRequestNumber { get; private set; }

    /// <summary>
    /// OutgoingRequestSerial of the PurchaseRequest
    /// OutgoingRequestSerial الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? OutgoingRequestSerial { get; private set; }

    /// <summary>
    /// InactiveFlag of the PurchaseRequest
    /// InactiveFlag الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PurchaseRequest
    /// InactivatedByUserId الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the PurchaseRequest
    /// InactiveReason الخاص بـ PurchaseRequest
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the PurchaseRequest
    /// InactiveDate الخاص بـ PurchaseRequest
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PurchaseRequest
    /// ReferenceNumber الخاص بـ PurchaseRequest
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// VendorCode of the PurchaseRequest
    /// VendorCode الخاص بـ PurchaseRequest
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the PurchaseRequest
    /// VendorName الخاص بـ PurchaseRequest
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequest
    /// CompanyNumberShort الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequest
    /// BranchNumber الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequest
    /// BranchYear الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequest
    /// BranchUser الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// UseAutoSyncVendor of the PurchaseRequest
    /// UseAutoSyncVendor الخاص بـ PurchaseRequest
    /// </summary>
    public decimal? UseAutoSyncVendor { get; private set; }

    /// <summary>
    /// AccountCurrency of the PurchaseRequest
    /// AccountCurrency الخاص بـ PurchaseRequest
    /// </summary>
    public string AccountCurrency { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PurchaseRequestType PurchaseRequestType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
