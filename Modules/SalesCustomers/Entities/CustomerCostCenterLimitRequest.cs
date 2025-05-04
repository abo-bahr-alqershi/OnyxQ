using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCostCenterLimitRequest Entity
/// </summary>
public class CustomerCostCenterLimitRequest : Entity<CustomerCostCenterLimitRequestId>
{
    private CustomerCostCenterLimitRequest() { }

    /// <summary>
    /// The unique identifier for the CustomerCostCenterLimitRequest
    /// المعرف الفريد لـ CustomerCostCenterLimitRequest
    /// </summary>
    public CustomerCostCenterLimitRequestId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerCostCenterLimitRequest
    /// CCode الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerCostCenterLimitRequest
    /// AccountCurrency الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the CustomerCostCenterLimitRequest
    /// CostCenterCode الخاص بـ CustomerCostCenterLimitRequest
    /// </summary>
    public string CostCenterCode { get; private set; }

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
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
