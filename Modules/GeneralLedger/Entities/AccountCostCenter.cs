using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountCostCenter Entity
/// </summary>
public class AccountCostCenter : Entity<AccountCostCenterId>
{
    private AccountCostCenter() { }

    /// <summary>
    /// The unique identifier for the AccountCostCenter
    /// المعرف الفريد لـ AccountCostCenter
    /// </summary>
    public AccountCostCenterId Id { get; private set; }

    /// <summary>
    /// AccountCode of the AccountCostCenter
    /// AccountCode الخاص بـ AccountCostCenter
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountCostCenter
    /// CostCenterCode الخاص بـ AccountCostCenter
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterNumber of the AccountCostCenter
    /// CostCenterNumber الخاص بـ AccountCostCenter
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
