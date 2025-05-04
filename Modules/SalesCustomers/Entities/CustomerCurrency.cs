using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCurrency Entity
/// </summary>
public class CustomerCurrency : Entity<CustomerCurrencyId>
{
    private CustomerCurrency() { }

    /// <summary>
    /// The unique identifier for the CustomerCurrency
    /// المعرف الفريد لـ CustomerCurrency
    /// </summary>
    public CustomerCurrencyId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerCurrency
    /// CCode الخاص بـ CustomerCurrency
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerCurrency
    /// AccountCurrency الخاص بـ CustomerCurrency
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CreditLimit of the CustomerCurrency
    /// CreditLimit الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? CreditLimit { get; private set; }

    /// <summary>
    /// InvoiceLimit of the CustomerCurrency
    /// InvoiceLimit الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? InvoiceLimit { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the CustomerCurrency
    /// CustomerLimitPercent الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }

    /// <summary>
    /// CustomerLimitType of the CustomerCurrency
    /// CustomerLimitType الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// LevelNumber of the CustomerCurrency
    /// LevelNumber الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerCurrency
    /// InactiveFlag الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// ConfirmLastDate of the CustomerCurrency
    /// ConfirmLastDate الخاص بـ CustomerCurrency
    /// </summary>
    public DateTime? ConfirmLastDate { get; private set; }

    /// <summary>
    /// LevelNumberCash of the CustomerCurrency
    /// LevelNumberCash الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? LevelNumberCash { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CustomerCurrency
    /// ExternalPostFlag الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// InactiveSales of the CustomerCurrency
    /// InactiveSales الخاص بـ CustomerCurrency
    /// </summary>
    public decimal? InactiveSales { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CustomerCurrency to PrivilegeCustomer
    /// </summary>
    public IReadOnlyCollection<PrivilegeCustomer> PrivilegeCustomers { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PricingLevel
    /// </summary>
    public PricingLevel PricingLevel { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerCurrency to CustomerLimitSale
    /// </summary>
    public IReadOnlyCollection<CustomerLimitSale> CustomerLimitSales { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerCurrency to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
