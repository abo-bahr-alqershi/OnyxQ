using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountCurrency Entity
/// </summary>
public class AccountCurrency : Entity<AccountCurrencyId>
{
    private AccountCurrency() { }

    /// <summary>
    /// The unique identifier for the AccountCurrency
    /// المعرف الفريد لـ AccountCurrency
    /// </summary>
    public AccountCurrencyId Id { get; private set; }

    /// <summary>
    /// AccountCode of the AccountCurrency
    /// AccountCode الخاص بـ AccountCurrency
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountCurrency
    /// AccountCurrency الخاص بـ AccountCurrency
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountCurrency
    /// InactiveFlag الخاص بـ AccountCurrency
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// UsedFlag of the AccountCurrency
    /// UsedFlag الخاص بـ AccountCurrency
    /// </summary>
    public decimal? UsedFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AccountCurrency to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to AccountPermission
    /// </summary>
    public IReadOnlyCollection<AccountPermission> AccountPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAdvanceExpenseRevenueMaster> GeneralLedgerAdvanceExpenseRevenueMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyDetail> GeneralLedgerRequestExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GeneralLedgerVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerVoucherMasterAccount> GeneralLedgerVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to CostDetail
    /// </summary>
    public IReadOnlyCollection<CostDetail> CostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to VoucherDetail
    /// </summary>
    public IReadOnlyCollection<VoucherDetail> VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OpeningBalance
    /// </summary>
    public IReadOnlyCollection<OpeningBalance> OpeningBalances { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BankAdjustmentDetail
    /// </summary>
    public IReadOnlyCollection<BankAdjustmentDetail> BankAdjustmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to CashAtBankDetail
    /// </summary>
    public IReadOnlyCollection<CashAtBankDetail> CashAtBankDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to CashInHandDetail
    /// </summary>
    public IReadOnlyCollection<CashInHandDetail> CashInHandDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to CashManagementDetail
    /// </summary>
    public IReadOnlyCollection<CashManagementDetail> CashManagementDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to ExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyDetail> ExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to PostDetail
    /// </summary>
    public IReadOnlyCollection<PostDetail> PostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to ProfitLossClosingTemp
    /// </summary>
    public IReadOnlyCollection<ProfitLossClosingTemp> ProfitLossClosingTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BudgetApprovalRequestFinanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetApprovalRequestFinanceDetail> BudgetApprovalRequestFinanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscount> BillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BillMasterAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BranchBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchBillMaster> BranchBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OutgoingMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingMaster> OutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BranchReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillMaster> BranchReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OutgoingBillMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingBillMaster> OutgoingBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to AccountsPayableOtherCharge
    /// </summary>
    public IReadOnlyCollection<AccountsPayableOtherCharge> AccountsPayableOtherCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to AccountsPayableOtherChargeItem
    /// </summary>
    public IReadOnlyCollection<AccountsPayableOtherChargeItem> AccountsPayableOtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to StockAdjustment
    /// </summary>
    public IReadOnlyCollection<StockAdjustment> StockAdjustments { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to PerformaInvoiceBillJournal
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillJournal> PerformaInvoiceBillJournals { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to KitDetail
    /// </summary>
    public IReadOnlyCollection<KitDetail> KitDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GuaranteeIncrease
    /// </summary>
    public IReadOnlyCollection<GuaranteeIncrease> GuaranteeIncreases { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GuaranteeIssue
    /// </summary>
    public IReadOnlyCollection<GuaranteeIssue> GuaranteeIssues { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to GuaranteeDetail
    /// </summary>
    public IReadOnlyCollection<GuaranteeDetail> GuaranteeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to Note
    /// </summary>
    public IReadOnlyCollection<Note> Notes { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to RequestJournalDetail
    /// </summary>
    public IReadOnlyCollection<RequestJournalDetail> RequestJournalDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to RequestVoucherDetail
    /// </summary>
    public IReadOnlyCollection<RequestVoucherDetail> RequestVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OtherCharge
    /// </summary>
    public IReadOnlyCollection<OtherCharge> OtherCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BranchOtherCharge
    /// </summary>
    public IReadOnlyCollection<BranchOtherCharge> BranchOtherCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OtherChargeItem
    /// </summary>
    public IReadOnlyCollection<OtherChargeItem> OtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BranchOtherChargeItem
    /// </summary>
    public IReadOnlyCollection<BranchOtherChargeItem> BranchOtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OtherChargeItemOthers
    /// </summary>
    public IReadOnlyCollection<OtherChargeItemOthers> OtherChargeItemOtherses { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to OtherChargeOthers
    /// </summary>
    public IReadOnlyCollection<OtherChargeOthers> OtherChargeOtherses { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to LetterOfCreditDetail
    /// </summary>
    public IReadOnlyCollection<LetterOfCreditDetail> LetterOfCreditDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to LetterOfCreditMaster
    /// </summary>
    public IReadOnlyCollection<LetterOfCreditMaster> LetterOfCreditMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to BankCash
    /// </summary>
    public IReadOnlyCollection<BankCash> BankCashes { get; private set; }
    /// <summary>
    /// One-to-many relationship: AccountCurrency to HandCash
    /// </summary>
    public IReadOnlyCollection<HandCash> HandCashes { get; private set; }
    #endregion
}
}
