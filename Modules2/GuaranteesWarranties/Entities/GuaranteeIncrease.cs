using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;
namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeIncrease Entity
/// </summary>
public class GuaranteeIncrease : Entity<GuaranteeIncreaseId>
{

    private GuaranteeIncrease() { }

    public GuaranteeIncrease(GuaranteeIncreaseId id, decimal? incrementNumber)
    {
        Id = id;
        IncrementNumber = incrementNumber;
    }

    /// <summary>
    /// The unique identifier for the GuaranteeIncrease
    /// المعرف الفريد لـ GuaranteeIncrease
    /// </summary>
    public GuaranteeIncreaseId Id { get; private set; }

    /// <summary>
    /// IncrementNumber of the GuaranteeIncrease
    /// IncrementNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? IncrementNumber { get; private set; }

    /// <summary>
    /// IncrementSerial of the GuaranteeIncrease
    /// IncrementSerial الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? IncrementSerial { get; private set; }

    /// <summary>
    /// IncrementDate of the GuaranteeIncrease
    /// IncrementDate الخاص بـ GuaranteeIncrease
    /// </summary>
    public DateTime? IncrementDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GuaranteeIncrease
    /// ReferenceNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// GroupSerial of the GuaranteeIncrease
    /// GroupSerial الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupSerial { get; private set; }

    /// <summary>
    /// GroupFunctionNumber of the GuaranteeIncrease
    /// GroupFunctionNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupFunctionNumber { get; private set; }

    /// <summary>
    /// EndDate of the GuaranteeIncrease
    /// EndDate الخاص بـ GuaranteeIncrease
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// GroupIncreaseNumber of the GuaranteeIncrease
    /// GroupIncreaseNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupIncreaseNumber { get; private set; }

    /// <summary>
    /// GroupAmountNew of the GuaranteeIncrease
    /// GroupAmountNew الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupAmountNew { get; private set; }

    /// <summary>
    /// CostCenterCode of the GuaranteeIncrease
    /// CostCenterCode الخاص بـ GuaranteeIncrease
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GuaranteeIncrease
    /// ProjectNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GuaranteeIncrease
    /// ActivityNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the GuaranteeIncrease
    /// AccountCurrency الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the GuaranteeIncrease
    /// AccountRate الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// GroupIncreaseCommission of the GuaranteeIncrease
    /// GroupIncreaseCommission الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupIncreaseCommission { get; private set; }

    /// <summary>
    /// GroupTotalCommission of the GuaranteeIncrease
    /// GroupTotalCommission الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupTotalCommission { get; private set; }

    /// <summary>
    /// AccountCodeGoodsReceiptIssue of the GuaranteeIncrease
    /// AccountCodeGoodsReceiptIssue الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountCodeGoodsReceiptIssue { get; private set; }

    /// <summary>
    /// AccountCodeGoodsReceiptMargin of the GuaranteeIncrease
    /// AccountCodeGoodsReceiptMargin الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountCodeGoodsReceiptMargin { get; private set; }

    /// <summary>
    /// GroupMarginAmount of the GuaranteeIncrease
    /// GroupMarginAmount الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupMarginAmount { get; private set; }

    /// <summary>
    /// DocDesc of the GuaranteeIncrease
    /// DocDesc الخاص بـ GuaranteeIncrease
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// GroupCloseFlag of the GuaranteeIncrease
    /// GroupCloseFlag الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? GroupCloseFlag { get; private set; }

    /// <summary>
    /// CommissionRate of the GuaranteeIncrease
    /// CommissionRate الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? CommissionRate { get; private set; }

    /// <summary>
    /// IncrementDocumentDate of the GuaranteeIncrease
    /// IncrementDocumentDate الخاص بـ GuaranteeIncrease
    /// </summary>
    public DateTime? IncrementDocumentDate { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the GuaranteeIncrease
    /// JournalVoucherTypeFull الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the GuaranteeIncrease
    /// JournalDocumentNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the GuaranteeIncrease
    /// JournalSerial الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalDocumentDate of the GuaranteeIncrease
    /// JournalDocumentDate الخاص بـ GuaranteeIncrease
    /// </summary>
    public DateTime? JournalDocumentDate { get; private set; }

    /// <summary>
    /// JournalSerialClose of the GuaranteeIncrease
    /// JournalSerialClose الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? JournalSerialClose { get; private set; }

    /// <summary>
    /// DocPy of the GuaranteeIncrease
    /// DocPy الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeIncrease
    /// DocNo الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AccountDetailGoodsReceiptIssueCode of the GuaranteeIncrease
    /// AccountDetailGoodsReceiptIssueCode الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountDetailGoodsReceiptIssueCode { get; private set; }

    /// <summary>
    /// AccountDetailGoodsReceiptMarginCode of the GuaranteeIncrease
    /// AccountDetailGoodsReceiptMarginCode الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountDetailGoodsReceiptMarginCode { get; private set; }

    /// <summary>
    /// AccountDetailTypeGoodsReceiptIssue of the GuaranteeIncrease
    /// AccountDetailTypeGoodsReceiptIssue الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? AccountDetailTypeGoodsReceiptIssue { get; private set; }

    /// <summary>
    /// AccountDetailTypeGoodsReceiptMargin of the GuaranteeIncrease
    /// AccountDetailTypeGoodsReceiptMargin الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? AccountDetailTypeGoodsReceiptMargin { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeIncrease
    /// CompanyNumberShort الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeIncrease
    /// BranchNumber الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeIncrease
    /// BranchYear الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeIncrease
    /// BranchUser الخاص بـ GuaranteeIncrease
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailSubGoodsReceiptIssueCode of the GuaranteeIncrease
    /// AccountDetailSubGoodsReceiptIssueCode الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountDetailSubGoodsReceiptIssueCode { get; private set; }

    /// <summary>
    /// AccountDetailSubGoodsReceiptMarginCode of the GuaranteeIncrease
    /// AccountDetailSubGoodsReceiptMarginCode الخاص بـ GuaranteeIncrease
    /// </summary>
    public string AccountDetailSubGoodsReceiptMarginCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GuaranteeIssue GuaranteeIssue { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

