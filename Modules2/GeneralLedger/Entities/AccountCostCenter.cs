using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountCostCenter Entity
/// </summary>
public class AccountCostCenter : Entity<AccountCostCenterId>
{

    private AccountCostCenter() { }

    public AccountCostCenter(AccountCostCenterId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountCostCenter
    /// المعرف الفريد لـ AccountCostCenter
    /// </summary>
    public AccountCostCenterId Id { get; private set; }

    /// <summary>
    /// CostCenterNumber of the AccountCostCenter
    /// CostCenterNumber الخاص بـ AccountCostCenter
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

