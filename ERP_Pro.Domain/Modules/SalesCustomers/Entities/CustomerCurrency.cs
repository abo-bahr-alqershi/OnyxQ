using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCurrency Entity
/// </summary>
public class CustomerCurrency : Entity<CustomerCurrencyId>
{

    private CustomerCurrency() { }

    public CustomerCurrency(CustomerCurrencyId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerCurrency
    /// المعرف الفريد لـ CustomerCurrency
    /// </summary>
    public CustomerCurrencyId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public PricingLevel PricingLevel { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
