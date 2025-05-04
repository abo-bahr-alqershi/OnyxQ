using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeAccountsPayable Entity
/// </summary>
public class PrivilegeAccountsPayable : Entity<PrivilegeAccountsPayableId>
{

    private PrivilegeAccountsPayable() { }

    public PrivilegeAccountsPayable(PrivilegeAccountsPayableId id, decimal? accountsPayableType, decimal? pType)
    {
        Id = id;
        AccountsPayableType = accountsPayableType;
        PType = pType;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeAccountsPayable
    /// المعرف الفريد لـ PrivilegeAccountsPayable
    /// </summary>
    public PrivilegeAccountsPayableId Id { get; private set; }

    /// <summary>
    /// AccountsPayableType of the PrivilegeAccountsPayable
    /// AccountsPayableType الخاص بـ PrivilegeAccountsPayable
    /// </summary>
    public decimal? AccountsPayableType { get; private set; }

    /// <summary>
    /// PType of the PrivilegeAccountsPayable
    /// PType الخاص بـ PrivilegeAccountsPayable
    /// </summary>
    public decimal? PType { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeAccountsPayable
    /// AdditionalFlag الخاص بـ PrivilegeAccountsPayable
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeAccountsPayable
    /// ViewFlag الخاص بـ PrivilegeAccountsPayable
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
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
