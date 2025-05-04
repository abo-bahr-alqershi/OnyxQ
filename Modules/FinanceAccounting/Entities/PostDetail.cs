using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// PostDetail Entity
/// </summary>
public class PostDetail : Entity<PostDetailId>
{
    private PostDetail() { }

    /// <summary>
    /// The unique identifier for the PostDetail
    /// المعرف الفريد لـ PostDetail
    /// </summary>
    public PostDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the PostDetail
    /// DocType الخاص بـ PostDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the PostDetail
    /// JournalVoucherTypeFull الخاص بـ PostDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the PostDetail
    /// DocNo الخاص بـ PostDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the PostDetail
    /// DocSer الخاص بـ PostDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// WarehouseCode of the PostDetail
    /// WarehouseCode الخاص بـ PostDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PostDetail
    /// CostCenterCode الخاص بـ PostDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PostDetail
    /// ProjectNumber الخاص بـ PostDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PostDetail
    /// ActivityNumber الخاص بـ PostDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashNumber of the PostDetail
    /// CashNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCode of the PostDetail
    /// AccountCode الخاص بـ PostDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PostDetail
    /// AccountDetailCode الخاص بـ PostDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the PostDetail
    /// AccountDetailSubCode الخاص بـ PostDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PostDetail
    /// AccountDetailType الخاص بـ PostDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the PostDetail
    /// AccountCurrency الخاص بـ PostDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DrAmt of the PostDetail
    /// DrAmt الخاص بـ PostDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the PostDetail
    /// CreditAmount الخاص بـ PostDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// DrAmtF of the PostDetail
    /// DrAmtF الخاص بـ PostDetail
    /// </summary>
    public decimal? DrAmtF { get; private set; }

    /// <summary>
    /// CreditAmountForeignShort of the PostDetail
    /// CreditAmountForeignShort الخاص بـ PostDetail
    /// </summary>
    public decimal? CreditAmountForeignShort { get; private set; }

    /// <summary>
    /// Amount of the PostDetail
    /// Amount الخاص بـ PostDetail
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the PostDetail
    /// AmountForeign الخاص بـ PostDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// DocDate of the PostDetail
    /// DocDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDueDate of the PostDetail
    /// DocDueDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// DocDesc of the PostDetail
    /// DocDesc الخاص بـ PostDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// Month of the PostDetail
    /// Month الخاص بـ PostDetail
    /// </summary>
    public decimal? Month { get; private set; }

    /// <summary>
    /// DYear of the PostDetail
    /// DYear الخاص بـ PostDetail
    /// </summary>
    public decimal? DYear { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PostDetail
    /// ReferenceNumber الخاص بـ PostDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocPost of the PostDetail
    /// DocPost الخاص بـ PostDetail
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// DocClose of the PostDetail
    /// DocClose الخاص بـ PostDetail
    /// </summary>
    public decimal? DocClose { get; private set; }

    /// <summary>
    /// InvoiceCloseFlag of the PostDetail
    /// InvoiceCloseFlag الخاص بـ PostDetail
    /// </summary>
    public decimal? InvoiceCloseFlag { get; private set; }

    /// <summary>
    /// CashBalanceBefore of the PostDetail
    /// CashBalanceBefore الخاص بـ PostDetail
    /// </summary>
    public decimal? CashBalanceBefore { get; private set; }

    /// <summary>
    /// CashBalanceAfter of the PostDetail
    /// CashBalanceAfter الخاص بـ PostDetail
    /// </summary>
    public decimal? CashBalanceAfter { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the PostDetail
    /// LetterCreditNumber الخاص بـ PostDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// CCode of the PostDetail
    /// CCode الخاص بـ PostDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the PostDetail
    /// VendorCode الخاص بـ PostDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CVCode of the PostDetail
    /// CVCode الخاص بـ PostDetail
    /// </summary>
    public string CVCode { get; private set; }

    /// <summary>
    /// VendorCCode of the PostDetail
    /// VendorCCode الخاص بـ PostDetail
    /// </summary>
    public string VendorCCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the PostDetail
    /// ColumnNumberShort الخاص بـ PostDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// RepCode of the PostDetail
    /// RepCode الخاص بـ PostDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CreditCardTypeFull of the PostDetail
    /// CreditCardTypeFull الخاص بـ PostDetail
    /// </summary>
    public decimal? CreditCardTypeFull { get; private set; }

    /// <summary>
    /// RegionCode of the PostDetail
    /// RegionCode الخاص بـ PostDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// HierarchyNumber of the PostDetail
    /// HierarchyNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the PostDetail
    /// WorkOrderNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the PostDetail
    /// WorkOrderSerial الخاص بـ PostDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ChequeNumber of the PostDetail
    /// ChequeNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the PostDetail
    /// NoteNumber الخاص بـ PostDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the PostDetail
    /// ChequeValuedFlag الخاص بـ PostDetail
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the PostDetail
    /// DocTypeRef الخاص بـ PostDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the PostDetail
    /// DocJvTypeRef الخاص بـ PostDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the PostDetail
    /// DocNoRef الخاص بـ PostDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PostDetail
    /// DocSerRef الخاص بـ PostDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequence of the PostDetail
    /// DocSequence الخاص بـ PostDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PostDetail
    /// ExternalPostFlag الخاص بـ PostDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the PostDetail
    /// RecordNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the PostDetail
    /// GuarantorCode الخاص بـ PostDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the PostDetail
    /// WarehouseGroupCode الخاص بـ PostDetail
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// TerminalName of the PostDetail
    /// TerminalName الخاص بـ PostDetail
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// InstallType of the PostDetail
    /// InstallType الخاص بـ PostDetail
    /// </summary>
    public decimal? InstallType { get; private set; }

    /// <summary>
    /// MoveDocumentPaymentYearShort of the PostDetail
    /// MoveDocumentPaymentYearShort الخاص بـ PostDetail
    /// </summary>
    public decimal? MoveDocumentPaymentYearShort { get; private set; }

    /// <summary>
    /// FromCostCenterCode of the PostDetail
    /// FromCostCenterCode الخاص بـ PostDetail
    /// </summary>
    public string FromCostCenterCode { get; private set; }

    /// <summary>
    /// FBranchNumber of the PostDetail
    /// FBranchNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? FBranchNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the PostDetail
    /// DocBrnNo الخاص بـ PostDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CashierNumber of the PostDetail
    /// CashierNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the PostDetail
    /// InsuranceCompanyNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the PostDetail
    /// InsuranceBenefitNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the PostDetail
    /// InsuranceCardNumber الخاص بـ PostDetail
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the PostDetail
    /// InsuranceCardNumberFamily الخاص بـ PostDetail
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the PostDetail
    /// InsuranceRelationType الخاص بـ PostDetail
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// AuditReference of the PostDetail
    /// AuditReference الخاص بـ PostDetail
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the PostDetail
    /// AuditReferenceDescription الخاص بـ PostDetail
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the PostDetail
    /// AuditReferenceUserId الخاص بـ PostDetail
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the PostDetail
    /// AuditReferenceDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ConfirmFlag of the PostDetail
    /// ConfirmFlag الخاص بـ PostDetail
    /// </summary>
    public decimal? ConfirmFlag { get; private set; }

    /// <summary>
    /// ConfirmDescription of the PostDetail
    /// ConfirmDescription الخاص بـ PostDetail
    /// </summary>
    public string ConfirmDescription { get; private set; }

    /// <summary>
    /// ConfirmUserId of the PostDetail
    /// ConfirmUserId الخاص بـ PostDetail
    /// </summary>
    public decimal? ConfirmUserId { get; private set; }

    /// <summary>
    /// ConfirmDate of the PostDetail
    /// ConfirmDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? ConfirmDate { get; private set; }

    /// <summary>
    /// PostUserId of the PostDetail
    /// PostUserId الخاص بـ PostDetail
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the PostDetail
    /// PostDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the PostDetail
    /// UnpostUserId الخاص بـ PostDetail
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the PostDetail
    /// UnpostDate الخاص بـ PostDetail
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PostDetail
    /// DocSequenceRef الخاص بـ PostDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// RecordNumberReference of the PostDetail
    /// RecordNumberReference الخاص بـ PostDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// CreditCardNumber of the PostDetail
    /// CreditCardNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? CreditCardNumber { get; private set; }

    /// <summary>
    /// CreditCardNumberReference of the PostDetail
    /// CreditCardNumberReference الخاص بـ PostDetail
    /// </summary>
    public decimal? CreditCardNumberReference { get; private set; }

    /// <summary>
    /// CreditCardDescription of the PostDetail
    /// CreditCardDescription الخاص بـ PostDetail
    /// </summary>
    public string CreditCardDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PostDetail
    /// CompanyNumberShort الخاص بـ PostDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PostDetail
    /// BranchNumber الخاص بـ PostDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PostDetail
    /// BranchYear الخاص بـ PostDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PostDetail
    /// BranchUser الخاص بـ PostDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocNoMnl of the PostDetail
    /// DocNoMnl الخاص بـ PostDetail
    /// </summary>
    public string DocNoMnl { get; private set; }

    /// <summary>
    /// DocDateMnl of the PostDetail
    /// DocDateMnl الخاص بـ PostDetail
    /// </summary>
    public DateTime? DocDateMnl { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PeriodDetail
    /// </summary>
    public PeriodDetail PeriodDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PostMaster
    /// </summary>
    public PostMaster PostMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion
}
}
