using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCostCenterLimitRequest Entity
/// </summary>
public class CustomerCostCenterLimitRequest : Entity<CustomerCostCenterLimitRequestId>
{

    private CustomerCostCenterLimitRequest() { }

    public CustomerCostCenterLimitRequest(CustomerCostCenterLimitRequestId id, string accountCurrency)
    {
        Id = id;
        AccountCurrency = accountCurrency;
    }

    /// <summary>
    /// The unique identifier for the CustomerCostCenterLimitRequest
    /// المعرف الفريد لـ CustomerCostCenterLimitRequest
    /// </summary>
    public CustomerCostCenterLimitRequestId Id { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerCostCenterLimitRequest
    /// AccountCurrency الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CreditLimit of the CustomerCostCenterLimitRequest
    /// CreditLimit الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public decimal? CreditLimit { get; private set; }

    /// <summary>
    /// InvoiceLimit of the CustomerCostCenterLimitRequest
    /// InvoiceLimit الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public decimal? InvoiceLimit { get; private set; }

    /// <summary>
    /// EmptyLimit of the CustomerCostCenterLimitRequest
    /// EmptyLimit الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public decimal? EmptyLimit { get; private set; }

    /// <summary>
    /// CustomerLimitType of the CustomerCostCenterLimitRequest
    /// CustomerLimitType الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the CustomerCostCenterLimitRequest
    /// CustomerLimitPercent الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
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

