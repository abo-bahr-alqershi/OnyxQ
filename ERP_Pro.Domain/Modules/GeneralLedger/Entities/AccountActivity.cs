using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountActivity Entity
/// </summary>
public class AccountActivity : Entity<AccountActivityId>
{

    private AccountActivity() { }

    public AccountActivity(AccountActivityId id, string activityNumber)
    {
        Id = id;
        ActivityNumber = activityNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountActivity
    /// المعرف الفريد لـ AccountActivity
    /// </summary>
    public AccountActivityId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountActivity
    /// ActivityNumber الخاص بـ AccountActivity
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
