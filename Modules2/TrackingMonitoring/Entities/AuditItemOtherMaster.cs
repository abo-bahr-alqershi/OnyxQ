using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;
namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditItemOtherMaster Entity
/// </summary>
public class AuditItemOtherMaster : Entity<AuditItemOtherMasterId>
{

    private AuditItemOtherMaster() { }

    public AuditItemOtherMaster(AuditItemOtherMasterId id, decimal? auditNumber, decimal? auditType)
    {
        Id = id;
        AuditNumber = auditNumber;
        AuditType = auditType;
    }

    /// <summary>
    /// The unique identifier for the AuditItemOtherMaster
    /// المعرف الفريد لـ AuditItemOtherMaster
    /// </summary>
    public AuditItemOtherMasterId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AuditItemOtherMaster
    /// AuditNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AuditItemOtherMaster
    /// AuditType الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocType of the AuditItemOtherMaster
    /// DocType الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditItemOtherMaster
    /// JournalVoucherTypeFull الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditItemOtherMaster
    /// DocNo الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditItemOtherMaster
    /// DocSer الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AuditItemOtherMaster
    /// DocDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the AuditItemOtherMaster
    /// AccountCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditItemOtherMaster
    /// AccountDetailCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditItemOtherMaster
    /// AccountDetailType الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditItemOtherMaster
    /// AccountCurrency الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CCode of the AuditItemOtherMaster
    /// CCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditItemOtherMaster
    /// VendorCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CVName of the AuditItemOtherMaster
    /// CVName الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string CVName { get; private set; }

    /// <summary>
    /// DocAmt of the AuditItemOtherMaster
    /// DocAmt الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// DiscAmt of the AuditItemOtherMaster
    /// DiscAmt الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// OtherAmount of the AuditItemOtherMaster
    /// OtherAmount الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the AuditItemOtherMaster
    /// VatAmount الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// CommissionPercent of the AuditItemOtherMaster
    /// CommissionPercent الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// DocRate of the AuditItemOtherMaster
    /// DocRate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// StockRate of the AuditItemOtherMaster
    /// StockRate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocDesc of the AuditItemOtherMaster
    /// DocDesc الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditItemOtherMaster
    /// ReferenceNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the AuditItemOtherMaster
    /// CashNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the AuditItemOtherMaster
    /// ChequeNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the AuditItemOtherMaster
    /// WarehouseCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditItemOtherMaster
    /// CostCenterCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AuditItemOtherMaster
    /// ProjectNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AuditItemOtherMaster
    /// ActivityNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the AuditItemOtherMaster
    /// RegionCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the AuditItemOtherMaster
    /// RepCode الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// HierarchyNumber of the AuditItemOtherMaster
    /// HierarchyNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the AuditItemOtherMaster
    /// LetterCreditNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// ReasonDelete of the AuditItemOtherMaster
    /// ReasonDelete الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string ReasonDelete { get; private set; }

    /// <summary>
    /// DocDueDate of the AuditItemOtherMaster
    /// DocDueDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AuditItemOtherMaster
    /// ExternalPostFlag الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AuditItemOtherMaster
    /// ProcessedFlagFull الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DocPy of the AuditItemOtherMaster
    /// DocPy الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// PurchaseType of the AuditItemOtherMaster
    /// PurchaseType الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// SideRequest of the AuditItemOtherMaster
    /// SideRequest الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string SideRequest { get; private set; }

    /// <summary>
    /// RequestAvailableDate of the AuditItemOtherMaster
    /// RequestAvailableDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? RequestAvailableDate { get; private set; }

    /// <summary>
    /// DocTypeRef of the AuditItemOtherMaster
    /// DocTypeRef الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the AuditItemOtherMaster
    /// DocJvTypeRef الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AuditItemOtherMaster
    /// DocNoRef الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AuditItemOtherMaster
    /// DocSerRef الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ApprovedFlagShort of the AuditItemOtherMaster
    /// ApprovedFlagShort الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? ApprovedFlagShort { get; private set; }

    /// <summary>
    /// ApprovedByUserId of the AuditItemOtherMaster
    /// ApprovedByUserId الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? ApprovedByUserId { get; private set; }

    /// <summary>
    /// ApprovedDate of the AuditItemOtherMaster
    /// ApprovedDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? ApprovedDate { get; private set; }

    /// <summary>
    /// InactiveFlag of the AuditItemOtherMaster
    /// InactiveFlag الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AuditItemOtherMaster
    /// InactivatedByUserId الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AuditItemOtherMaster
    /// InactiveDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AuditItemOtherMaster
    /// InactiveReason الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// UserId of the AuditItemOtherMaster
    /// UserId الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditItemOtherMaster
    /// AuditDate الخاص بـ AuditItemOtherMaster
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// TerminalName of the AuditItemOtherMaster
    /// TerminalName الخاص بـ AuditItemOtherMaster
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditItemOtherMaster
    /// CompanyNumberShort الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditItemOtherMaster
    /// BranchNumber الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditItemOtherMaster
    /// BranchYear الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditItemOtherMaster
    /// BranchUser الخاص بـ AuditItemOtherMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

