using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditItemMaster Entity
/// </summary>
public class AuditItemMaster : Entity<AuditItemMasterId>
{

    private AuditItemMaster() { }

    public AuditItemMaster(AuditItemMasterId id, decimal? auditNumber, decimal? auditType)
    {
        Id = id;
        AuditNumber = auditNumber;
        AuditType = auditType;
    }

    /// <summary>
    /// The unique identifier for the AuditItemMaster
    /// المعرف الفريد لـ AuditItemMaster
    /// </summary>
    public AuditItemMasterId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AuditItemMaster
    /// AuditNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AuditItemMaster
    /// AuditType الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocType of the AuditItemMaster
    /// DocType الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditItemMaster
    /// JournalVoucherTypeFull الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditItemMaster
    /// DocNo الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditItemMaster
    /// DocSer الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AuditItemMaster
    /// DocDate الخاص بـ AuditItemMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the AuditItemMaster
    /// AccountCode الخاص بـ AuditItemMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditItemMaster
    /// AccountDetailCode الخاص بـ AuditItemMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditItemMaster
    /// AccountDetailType الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditItemMaster
    /// AccountCurrency الخاص بـ AuditItemMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CCode of the AuditItemMaster
    /// CCode الخاص بـ AuditItemMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditItemMaster
    /// VendorCode الخاص بـ AuditItemMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CVName of the AuditItemMaster
    /// CVName الخاص بـ AuditItemMaster
    /// </summary>
    public string CVName { get; private set; }

    /// <summary>
    /// Amount of the AuditItemMaster
    /// Amount الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// DiscAmt of the AuditItemMaster
    /// DiscAmt الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// OtherAmount of the AuditItemMaster
    /// OtherAmount الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the AuditItemMaster
    /// VatAmount الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// CommissionPercent of the AuditItemMaster
    /// CommissionPercent الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// DocRate of the AuditItemMaster
    /// DocRate الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// StockRate of the AuditItemMaster
    /// StockRate الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// AccountDescription of the AuditItemMaster
    /// AccountDescription الخاص بـ AuditItemMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditItemMaster
    /// ReferenceNumber الخاص بـ AuditItemMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the AuditItemMaster
    /// CashNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the AuditItemMaster
    /// ChequeNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the AuditItemMaster
    /// WarehouseCode الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditItemMaster
    /// CostCenterCode الخاص بـ AuditItemMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// RegionCode of the AuditItemMaster
    /// RegionCode الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the AuditItemMaster
    /// RepCode الخاص بـ AuditItemMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the AuditItemMaster
    /// LetterCreditNumber الخاص بـ AuditItemMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// LoadNumber of the AuditItemMaster
    /// LoadNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// LoadSerial of the AuditItemMaster
    /// LoadSerial الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? LoadSerial { get; private set; }

    /// <summary>
    /// FDocumentNumber of the AuditItemMaster
    /// FDocumentNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? FDocumentNumber { get; private set; }

    /// <summary>
    /// FDocumentSerial of the AuditItemMaster
    /// FDocumentSerial الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? FDocumentSerial { get; private set; }

    /// <summary>
    /// ReasonDelete of the AuditItemMaster
    /// ReasonDelete الخاص بـ AuditItemMaster
    /// </summary>
    public string ReasonDelete { get; private set; }

    /// <summary>
    /// DocDueDate of the AuditItemMaster
    /// DocDueDate الخاص بـ AuditItemMaster
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AuditItemMaster
    /// ExternalPostFlag الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AuditItemMaster
    /// ProcessedFlagFull الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// BillPaymentYear of the AuditItemMaster
    /// BillPaymentYear الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// PurchaseType of the AuditItemMaster
    /// PurchaseType الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// ExpenseAccountCode of the AuditItemMaster
    /// ExpenseAccountCode الخاص بـ AuditItemMaster
    /// </summary>
    public string ExpenseAccountCode { get; private set; }

    /// <summary>
    /// ExpenseAccountCurrency of the AuditItemMaster
    /// ExpenseAccountCurrency الخاص بـ AuditItemMaster
    /// </summary>
    public string ExpenseAccountCurrency { get; private set; }

    /// <summary>
    /// ExpenseAmount of the AuditItemMaster
    /// ExpenseAmount الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseRate of the AuditItemMaster
    /// ExpenseRate الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? ExpenseRate { get; private set; }

    /// <summary>
    /// UserId of the AuditItemMaster
    /// UserId الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditItemMaster
    /// AuditDate الخاص بـ AuditItemMaster
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// PostUserId of the AuditItemMaster
    /// PostUserId الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the AuditItemMaster
    /// PostDate الخاص بـ AuditItemMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the AuditItemMaster
    /// UnpostUserId الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the AuditItemMaster
    /// UnpostDate الخاص بـ AuditItemMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// TerminalName of the AuditItemMaster
    /// TerminalName الخاص بـ AuditItemMaster
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditItemMaster
    /// CompanyNumberShort الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditItemMaster
    /// BranchNumber الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditItemMaster
    /// BranchYear الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditItemMaster
    /// BranchUser الخاص بـ AuditItemMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
