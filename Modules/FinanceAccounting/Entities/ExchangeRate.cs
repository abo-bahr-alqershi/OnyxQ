using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ExchangeRate Entity
/// </summary>
public class ExchangeRate : Entity<ExchangeRateId>
{
    private ExchangeRate() { }

    /// <summary>
    /// The unique identifier for the ExchangeRate
    /// المعرف الفريد لـ ExchangeRate
    /// </summary>
    public ExchangeRateId Id { get; private set; }

    /// <summary>
    /// CurNo of the ExchangeRate
    /// CurNo الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// CurCode of the ExchangeRate
    /// CurCode الخاص بـ ExchangeRate
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurName of the ExchangeRate
    /// CurName الخاص بـ ExchangeRate
    /// </summary>
    public string CurName { get; private set; }

    /// <summary>
    /// CurEName of the ExchangeRate
    /// CurEName الخاص بـ ExchangeRate
    /// </summary>
    public string CurEName { get; private set; }

    /// <summary>
    /// CurRate of the ExchangeRate
    /// CurRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CurRatePos of the ExchangeRate
    /// CurRatePos الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurRatePos { get; private set; }

    /// <summary>
    /// CurFraction of the ExchangeRate
    /// CurFraction الخاص بـ ExchangeRate
    /// </summary>
    public string CurFraction { get; private set; }

    /// <summary>
    /// CurEFraction of the ExchangeRate
    /// CurEFraction الخاص بـ ExchangeRate
    /// </summary>
    public string CurEFraction { get; private set; }

    /// <summary>
    /// LFField of the ExchangeRate
    /// LFField الخاص بـ ExchangeRate
    /// </summary>
    public decimal? LFField { get; private set; }

    /// <summary>
    /// StockCurrency of the ExchangeRate
    /// StockCurrency الخاص بـ ExchangeRate
    /// </summary>
    public decimal? StockCurrency { get; private set; }

    /// <summary>
    /// MaxCurrencyRate of the ExchangeRate
    /// MaxCurrencyRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? MaxCurrencyRate { get; private set; }

    /// <summary>
    /// MinCurrencyRate of the ExchangeRate
    /// MinCurrencyRate الخاص بـ ExchangeRate
    /// </summary>
    public decimal? MinCurrencyRate { get; private set; }

    /// <summary>
    /// CurFrcNo of the ExchangeRate
    /// CurFrcNo الخاص بـ ExchangeRate
    /// </summary>
    public decimal? CurFrcNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GeneralLedgerAccountDetailCurrency
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetailCurrency> GeneralLedgerAccountDetailCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GeneralLedgerCurrencyUserLimit
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerCurrencyUserLimit> GeneralLedgerCurrencyUserLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceMaster> GeneralLedgerEditBudgetBalanceMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to AccountCurrency
    /// </summary>
    public IReadOnlyCollection<AccountCurrency> AccountCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to CurrencyValue
    /// </summary>
    public IReadOnlyCollection<CurrencyValue> CurrencyValues { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to BudgetBalanceMaster
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceMaster> BudgetBalanceMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to CustomerCurrency
    /// </summary>
    public IReadOnlyCollection<CustomerCurrency> CustomerCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to VendorCurrency
    /// </summary>
    public IReadOnlyCollection<VendorCurrency> VendorCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to VendorItem
    /// </summary>
    public IReadOnlyCollection<VendorItem> VendorItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to PricingLevel
    /// </summary>
    public IReadOnlyCollection<PricingLevel> PricingLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to WorkOrderMaster
    /// </summary>
    public IReadOnlyCollection<WorkOrderMaster> WorkOrderMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GuaranteeIssue
    /// </summary>
    public IReadOnlyCollection<GuaranteeIssue> GuaranteeIssues { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to GeneralLedgerAccountDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetail> GeneralLedgerAccountDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: ExchangeRate to VoucherDetails
    /// </summary>
    public IReadOnlyCollection<VoucherDetails> VoucherDetailses { get; private set; }
    #endregion
}
}
