using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestAutoMaster Entity
/// </summary>
public class PurchaseRequestAutoMaster : Entity<PurchaseRequestAutoMasterId>
{

    private PurchaseRequestAutoMaster() { }

    public PurchaseRequestAutoMaster(PurchaseRequestAutoMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequestAutoMaster
    /// المعرف الفريد لـ PurchaseRequestAutoMaster
    /// </summary>
    public PurchaseRequestAutoMasterId Id { get; private set; }

    /// <summary>
    /// MethodType of the PurchaseRequestAutoMaster
    /// MethodType الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? MethodType { get; private set; }

    /// <summary>
    /// DocNo of the PurchaseRequestAutoMaster
    /// DocNo الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the PurchaseRequestAutoMaster
    /// DocSer الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the PurchaseRequestAutoMaster
    /// DocDate الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseRequestAutoMaster
    /// WarehouseCode الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseRequestAutoMaster
    /// CostCenterCode الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseRequestAutoMaster
    /// ProjectNumber الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseRequestAutoMaster
    /// ActivityNumber الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// HierarchyNumber of the PurchaseRequestAutoMaster
    /// HierarchyNumber الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// DocDesc of the PurchaseRequestAutoMaster
    /// DocDesc الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// SideRequest of the PurchaseRequestAutoMaster
    /// SideRequest الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string SideRequest { get; private set; }

    /// <summary>
    /// ApprovedFlag of the PurchaseRequestAutoMaster
    /// ApprovedFlag الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the PurchaseRequestAutoMaster
    /// ApprovalUserId الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the PurchaseRequestAutoMaster
    /// ApprovalDate الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the PurchaseRequestAutoMaster
    /// ApprovalDescription الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// UseMoreOne of the PurchaseRequestAutoMaster
    /// UseMoreOne الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? UseMoreOne { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequestAutoMaster
    /// CompanyNumberShort الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequestAutoMaster
    /// BranchNumber الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequestAutoMaster
    /// BranchYear الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequestAutoMaster
    /// BranchUser الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RequestAvailableDate of the PurchaseRequestAutoMaster
    /// RequestAvailableDate الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public DateTime? RequestAvailableDate { get; private set; }

    /// <summary>
    /// ProcessFlagAlt of the PurchaseRequestAutoMaster
    /// ProcessFlagAlt الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? ProcessFlagAlt { get; private set; }

    /// <summary>
    /// CalculateQuantityStockAge of the PurchaseRequestAutoMaster
    /// CalculateQuantityStockAge الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public decimal? CalculateQuantityStockAge { get; private set; }

    /// <summary>
    /// FromDate of the PurchaseRequestAutoMaster
    /// FromDate الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public DateTime? FromDate { get; private set; }

    /// <summary>
    /// ToDate of the PurchaseRequestAutoMaster
    /// ToDate الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public DateTime? ToDate { get; private set; }

    /// <summary>
    /// VendorCode of the PurchaseRequestAutoMaster
    /// VendorCode الخاص بـ PurchaseRequestAutoMaster
    /// </summary>
    public string VendorCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

