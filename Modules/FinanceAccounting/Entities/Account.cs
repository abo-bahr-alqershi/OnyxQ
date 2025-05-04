using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// Account Entity
/// </summary>
public class Account : Entity<AccountId>
{
    private Account() { }

    /// <summary>
    /// The unique identifier for the Account
    /// المعرف الفريد لـ Account
    /// </summary>
    public AccountId Id { get; private set; }

    /// <summary>
    /// AccountCode of the Account
    /// AccountCode الخاص بـ Account
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountName of the Account
    /// AccountName الخاص بـ Account
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// AccountNameEnglishFull of the Account
    /// AccountNameEnglishFull الخاص بـ Account
    /// </summary>
    public string AccountNameEnglishFull { get; private set; }

    /// <summary>
    /// AccountLevel of the Account
    /// AccountLevel الخاص بـ Account
    /// </summary>
    public decimal? AccountLevel { get; private set; }

    /// <summary>
    /// ParentAccountCode of the Account
    /// ParentAccountCode الخاص بـ Account
    /// </summary>
    public string ParentAccountCode { get; private set; }

    /// <summary>
    /// AccountSmCode of the Account
    /// AccountSmCode الخاص بـ Account
    /// </summary>
    public decimal? AccountSmCode { get; private set; }

    /// <summary>
    /// AccountGrouping of the Account
    /// AccountGrouping الخاص بـ Account
    /// </summary>
    public decimal? AccountGrouping { get; private set; }

    /// <summary>
    /// AccountReport of the Account
    /// AccountReport الخاص بـ Account
    /// </summary>
    public decimal? AccountReport { get; private set; }

    /// <summary>
    /// AccountAnalysis of the Account
    /// AccountAnalysis الخاص بـ Account
    /// </summary>
    public decimal? AccountAnalysis { get; private set; }

    /// <summary>
    /// ClassNumber of the Account
    /// ClassNumber الخاص بـ Account
    /// </summary>
    public decimal? ClassNumber { get; private set; }

    /// <summary>
    /// AccountCloseFlag of the Account
    /// AccountCloseFlag الخاص بـ Account
    /// </summary>
    public decimal? AccountCloseFlag { get; private set; }

    /// <summary>
    /// Dr of the Account
    /// Dr الخاص بـ Account
    /// </summary>
    public decimal? Dr { get; private set; }

    /// <summary>
    /// CurdifCode of the Account
    /// CurdifCode الخاص بـ Account
    /// </summary>
    public string CurdifCode { get; private set; }

    /// <summary>
    /// UseCostCenter of the Account
    /// UseCostCenter الخاص بـ Account
    /// </summary>
    public decimal? UseCostCenter { get; private set; }

    /// <summary>
    /// UseProject of the Account
    /// UseProject الخاص بـ Account
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// ConnectionPeriod of the Account
    /// ConnectionPeriod الخاص بـ Account
    /// </summary>
    public decimal? ConnectionPeriod { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the Account
    /// FavoriteAccountFlag الخاص بـ Account
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// FlowType of the Account
    /// FlowType الخاص بـ Account
    /// </summary>
    public decimal? FlowType { get; private set; }

    /// <summary>
    /// InactiveReason of the Account
    /// InactiveReason الخاص بـ Account
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the Account
    /// InactiveDate الخاص بـ Account
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// ConfigLastDate of the Account
    /// ConfigLastDate الخاص بـ Account
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the Account
    /// AccountOperationNumber الخاص بـ Account
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// AccountExpenseType of the Account
    /// AccountExpenseType الخاص بـ Account
    /// </summary>
    public decimal? AccountExpenseType { get; private set; }

    /// <summary>
    /// UseExportBranch of the Account
    /// UseExportBranch الخاص بـ Account
    /// </summary>
    public decimal? UseExportBranch { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Account
    /// ImportExcelFlag الخاص بـ Account
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// AccountDetailType of the Account
    /// AccountDetailType الخاص بـ Account
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// UseActive of the Account
    /// UseActive الخاص بـ Account
    /// </summary>
    public decimal? UseActive { get; private set; }

    /// <summary>
    /// UseTdsFlag of the Account
    /// UseTdsFlag الخاص بـ Account
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// AdvanceExpenseRevenueFlag of the Account
    /// AdvanceExpenseRevenueFlag الخاص بـ Account
    /// </summary>
    public decimal? AdvanceExpenseRevenueFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Account to GeneralLedgerAccountDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetail> GeneralLedgerAccountDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to GeneralLedgerAccountDetailGroups
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetailGroups> GeneralLedgerAccountDetailGroupses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to GeneralLedgerTaxAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerTaxAccount> GeneralLedgerTaxAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountActivity
    /// </summary>
    public IReadOnlyCollection<AccountActivity> AccountActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountCostCenter
    /// </summary>
    public IReadOnlyCollection<AccountCostCenter> AccountCostCenters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountTree
    /// </summary>
    public IReadOnlyCollection<AccountTree> AccountTrees { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountClass
    /// </summary>
    public AccountClass AccountClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountGroup
    /// </summary>
    public AccountGroup AccountGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountReportType
    /// </summary>
    public AccountReportType AccountReportType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountType
    /// </summary>
    public AccountType AccountType { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountCurrency
    /// </summary>
    public IReadOnlyCollection<AccountCurrency> AccountCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to BankCash
    /// </summary>
    public IReadOnlyCollection<BankCash> BankCashes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to HandCash
    /// </summary>
    public IReadOnlyCollection<HandCash> HandCashes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to InterfaceAccount
    /// </summary>
    public IReadOnlyCollection<InterfaceAccount> InterfaceAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to OutgoingAccount
    /// </summary>
    public IReadOnlyCollection<OutgoingAccount> OutgoingAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to BankAdjustmentMaster
    /// </summary>
    public IReadOnlyCollection<BankAdjustmentMaster> BankAdjustmentMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CashManagementMaster
    /// </summary>
    public IReadOnlyCollection<CashManagementMaster> CashManagementMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CurrencyDifferenceTemp
    /// </summary>
    public IReadOnlyCollection<CurrencyDifferenceTemp> CurrencyDifferenceTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountCostCenterLimit
    /// </summary>
    public IReadOnlyCollection<AccountCostCenterLimit> AccountCostCenterLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AssociationAccount
    /// </summary>
    public IReadOnlyCollection<AssociationAccount> AssociationAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CustomerAccount
    /// </summary>
    public IReadOnlyCollection<CustomerAccount> CustomerAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to VendorAccount
    /// </summary>
    public IReadOnlyCollection<VendorAccount> VendorAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to VendorTdsAccount
    /// </summary>
    public IReadOnlyCollection<VendorTdsAccount> VendorTdsAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CustomerGroup
    /// </summary>
    public IReadOnlyCollection<CustomerGroup> CustomerGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to SalesCharge
    /// </summary>
    public IReadOnlyCollection<SalesCharge> SalesCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CustomerFines
    /// </summary>
    public IReadOnlyCollection<CustomerFines> CustomerFineses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to VendorGroup
    /// </summary>
    public IReadOnlyCollection<VendorGroup> VendorGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to AccountsPayableCharge
    /// </summary>
    public IReadOnlyCollection<AccountsPayableCharge> AccountsPayableCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to ConnectAccountInventoryByGl
    /// </summary>
    public IReadOnlyCollection<ConnectAccountInventoryByGl> ConnectAccountInventoryByGls { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to PerformaInvoiceBillExpand
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillExpand> PerformaInvoiceBillExpands { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to GuaranteeAccount
    /// </summary>
    public IReadOnlyCollection<GuaranteeAccount> GuaranteeAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to GuaranteeIssue
    /// </summary>
    public IReadOnlyCollection<GuaranteeIssue> GuaranteeIssues { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to StationOutgoingDetail
    /// </summary>
    public IReadOnlyCollection<StationOutgoingDetail> StationOutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to TaxCodeDetail
    /// </summary>
    public IReadOnlyCollection<TaxCodeDetail> TaxCodeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to YearBalanceTemp
    /// </summary>
    public IReadOnlyCollection<YearBalanceTemp> YearBalanceTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to CostCenter
    /// </summary>
    public IReadOnlyCollection<CostCenter> CostCenters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to ExchangeRate
    /// </summary>
    public IReadOnlyCollection<ExchangeRate> ExchangeRates { get; private set; }
    /// <summary>
    /// One-to-many relationship: Account to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    #endregion
}
}
