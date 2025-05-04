using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCostCenterLimit Entity
/// </summary>
public class CustomerCostCenterLimit : Entity<CustomerCostCenterLimitId>
{
    private CustomerCostCenterLimit() { }

    /// <summary>
    /// The unique identifier for the CustomerCostCenterLimit
    /// المعرف الفريد لـ CustomerCostCenterLimit
    /// </summary>
    public CustomerCostCenterLimitId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerCostCenterLimit
    /// CCode الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerCostCenterLimit
    /// AccountCurrency الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the CustomerCostCenterLimit
    /// CostCenterCode الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CreditLimit of the CustomerCostCenterLimit
    /// CreditLimit الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public decimal? CreditLimit { get; private set; }

    /// <summary>
    /// InvoiceLimit of the CustomerCostCenterLimit
    /// InvoiceLimit الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public decimal? InvoiceLimit { get; private set; }

    /// <summary>
    /// CustomerLimitPercent of the CustomerCostCenterLimit
    /// CustomerLimitPercent الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public decimal? CustomerLimitPercent { get; private set; }

    /// <summary>
    /// CustomerLimitType of the CustomerCostCenterLimit
    /// CustomerLimitType الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public decimal? CustomerLimitType { get; private set; }

    /// <summary>
    /// EmptyLimit of the CustomerCostCenterLimit
    /// EmptyLimit الخاص بـ CustomerCostCenterLimit
    /// </summary>
    public decimal? EmptyLimit { get; private set; }

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
