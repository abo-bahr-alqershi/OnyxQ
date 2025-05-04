using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountGroup Entity
/// </summary>
public class AccountGroup : Entity<AccountGroupId>
{

    private AccountGroup() { }

    public AccountGroup(AccountGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountGroup
    /// المعرف الفريد لـ AccountGroup
    /// </summary>
    public AccountGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the AccountGroup
    /// GroupNumber الخاص بـ AccountGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupName of the AccountGroup
    /// GroupName الخاص بـ AccountGroup
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the AccountGroup
    /// GroupNameEnglish الخاص بـ AccountGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
