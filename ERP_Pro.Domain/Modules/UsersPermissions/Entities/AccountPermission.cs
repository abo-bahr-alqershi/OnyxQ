using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// AccountPermission Entity
/// </summary>
public class AccountPermission : Entity<AccountPermissionId>
{

    private AccountPermission() { }

    public AccountPermission(AccountPermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountPermission
    /// المعرف الفريد لـ AccountPermission
    /// </summary>
    public AccountPermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the AccountPermission
    /// AdditionalFlag الخاص بـ AccountPermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the AccountPermission
    /// ViewFlag الخاص بـ AccountPermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
