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

    /// <summary>
    /// The unique identifier for the AccountPermission
    /// المعرف الفريد لـ AccountPermission
    /// </summary>
    public AccountPermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the AccountPermission
    /// UserId الخاص بـ AccountPermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AccountCode of the AccountPermission
    /// AccountCode الخاص بـ AccountPermission
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountPermission
    /// AccountCurrency الخاص بـ AccountPermission
    /// </summary>
    public string AccountCurrency { get; private set; }

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
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
