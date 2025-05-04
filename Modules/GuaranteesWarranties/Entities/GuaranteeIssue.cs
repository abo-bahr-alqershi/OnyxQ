using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeIssue Entity
/// </summary>
public class GuaranteeIssue : Entity<GuaranteeIssueId>
{
    private GuaranteeIssue() { }

    /// <summary>
    /// The unique identifier for the GuaranteeIssue
    /// المعرف الفريد لـ GuaranteeIssue
    /// </summary>
    public GuaranteeIssueId Id { get; private set; }

    /// <summary>
    /// GroupTypeFull of the GuaranteeIssue
    /// GroupTypeFull الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GuaranteeIssue
    /// GroupNumberFull الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// GroupSerial of the GuaranteeIssue
    /// GroupSerial الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupSerial { get; private set; }

    /// <summary>
    /// AccountCode of the GuaranteeIssue
    /// AccountCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GuaranteeIssue
    /// AccountDetailCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GuaranteeIssue
    /// AccountDetailType الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the GuaranteeIssue
    /// AccountCurrency الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the GuaranteeIssue
    /// AccountRate الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CCode of the GuaranteeIssue
    /// CCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the GuaranteeIssue
    /// VendorCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the GuaranteeIssue
    /// CostCenterCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GuaranteeIssue
    /// ProjectNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GuaranteeIssue
    /// ActivityNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// GuaranteedName of the GuaranteeIssue
    /// GuaranteedName الخاص بـ GuaranteeIssue
    /// </summary>
    public string GuaranteedName { get; private set; }

    /// <summary>
    /// GroupAmount of the GuaranteeIssue
    /// GroupAmount الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupAmount { get; private set; }

    /// <summary>
    /// IssueDate of the GuaranteeIssue
    /// IssueDate الخاص بـ GuaranteeIssue
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// EndDate of the GuaranteeIssue
    /// EndDate الخاص بـ GuaranteeIssue
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// GroupStatus of the GuaranteeIssue
    /// GroupStatus الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupStatus { get; private set; }

    /// <summary>
    /// GroupTypeNumber of the GuaranteeIssue
    /// GroupTypeNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupTypeNumber { get; private set; }

    /// <summary>
    /// GroupTypeOther of the GuaranteeIssue
    /// GroupTypeOther الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupTypeOther { get; private set; }

    /// <summary>
    /// GroupFunctionNumber of the GuaranteeIssue
    /// GroupFunctionNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupFunctionNumber { get; private set; }

    /// <summary>
    /// GroupFunctionOthers of the GuaranteeIssue
    /// GroupFunctionOthers الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupFunctionOthers { get; private set; }

    /// <summary>
    /// GroupReason of the GuaranteeIssue
    /// GroupReason الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupReason { get; private set; }

    /// <summary>
    /// GroupPurpose of the GuaranteeIssue
    /// GroupPurpose الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupPurpose { get; private set; }

    /// <summary>
    /// BankNumber of the GuaranteeIssue
    /// BankNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BankName of the GuaranteeIssue
    /// BankName الخاص بـ GuaranteeIssue
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// GroupCommission of the GuaranteeIssue
    /// GroupCommission الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupCommission { get; private set; }

    /// <summary>
    /// CommissionAccount of the GuaranteeIssue
    /// CommissionAccount الخاص بـ GuaranteeIssue
    /// </summary>
    public string CommissionAccount { get; private set; }

    /// <summary>
    /// CommissionAccountCurrency of the GuaranteeIssue
    /// CommissionAccountCurrency الخاص بـ GuaranteeIssue
    /// </summary>
    public string CommissionAccountCurrency { get; private set; }

    /// <summary>
    /// CommissionRate of the GuaranteeIssue
    /// CommissionRate الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? CommissionRate { get; private set; }

    /// <summary>
    /// AccountCodeGoodsReceiptIssue of the GuaranteeIssue
    /// AccountCodeGoodsReceiptIssue الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountCodeGoodsReceiptIssue { get; private set; }

    /// <summary>
    /// AccountCodeGoodsReceiptMargin of the GuaranteeIssue
    /// AccountCodeGoodsReceiptMargin الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountCodeGoodsReceiptMargin { get; private set; }

    /// <summary>
    /// GroupMarginAmount of the GuaranteeIssue
    /// GroupMarginAmount الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupMarginAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GuaranteeIssue
    /// ReferenceNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// GroupCloseFlag of the GuaranteeIssue
    /// GroupCloseFlag الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GroupCloseFlag { get; private set; }

    /// <summary>
    /// BuildingType of the GuaranteeIssue
    /// BuildingType الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BuildingType { get; private set; }

    /// <summary>
    /// BuildingRegisterNumber of the GuaranteeIssue
    /// BuildingRegisterNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public string BuildingRegisterNumber { get; private set; }

    /// <summary>
    /// GroupDescription of the GuaranteeIssue
    /// GroupDescription الخاص بـ GuaranteeIssue
    /// </summary>
    public string GroupDescription { get; private set; }

    /// <summary>
    /// BuildingMaterialEstimatedValue of the GuaranteeIssue
    /// BuildingMaterialEstimatedValue الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BuildingMaterialEstimatedValue { get; private set; }

    /// <summary>
    /// GrantAmountByBuild of the GuaranteeIssue
    /// GrantAmountByBuild الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? GrantAmountByBuild { get; private set; }

    /// <summary>
    /// ReceiveGuarantor of the GuaranteeIssue
    /// ReceiveGuarantor الخاص بـ GuaranteeIssue
    /// </summary>
    public string ReceiveGuarantor { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the GuaranteeIssue
    /// JournalVoucherTypeFull الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the GuaranteeIssue
    /// JournalDocumentNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the GuaranteeIssue
    /// JournalSerial الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalSerialClose of the GuaranteeIssue
    /// JournalSerialClose الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? JournalSerialClose { get; private set; }

    /// <summary>
    /// JournalDocumentDate of the GuaranteeIssue
    /// JournalDocumentDate الخاص بـ GuaranteeIssue
    /// </summary>
    public DateTime? JournalDocumentDate { get; private set; }

    /// <summary>
    /// JournalDocumentDateClose of the GuaranteeIssue
    /// JournalDocumentDateClose الخاص بـ GuaranteeIssue
    /// </summary>
    public DateTime? JournalDocumentDateClose { get; private set; }

    /// <summary>
    /// DocPy of the GuaranteeIssue
    /// DocPy الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the GuaranteeIssue
    /// LetterCreditNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeIssue
    /// DocNo الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeIssue
    /// CompanyNumberShort الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeIssue
    /// BranchNumber الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeIssue
    /// BranchYear الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeIssue
    /// BranchUser الخاص بـ GuaranteeIssue
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GuaranteeIssue
    /// AccountDetailSubCode الخاص بـ GuaranteeIssue
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GuaranteeIssue to GuaranteeAccount
    /// </summary>
    public IReadOnlyCollection<GuaranteeAccount> GuaranteeAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: GuaranteeIssue to GuaranteeIncrease
    /// </summary>
    public IReadOnlyCollection<GuaranteeIncrease> GuaranteeIncreases { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GuaranteeType
    /// </summary>
    public GuaranteeType GuaranteeType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion
}
}
