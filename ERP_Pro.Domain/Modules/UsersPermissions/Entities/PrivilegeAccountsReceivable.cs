using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeAccountsReceivable Entity
/// </summary>
public class PrivilegeAccountsReceivable : Entity<PrivilegeAccountsReceivableId>
{

    private PrivilegeAccountsReceivable() { }

    public PrivilegeAccountsReceivable(PrivilegeAccountsReceivableId id, decimal? arType, decimal? sType)
    {
        Id = id;
        ArType = arType;
        SType = sType;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeAccountsReceivable
    /// المعرف الفريد لـ PrivilegeAccountsReceivable
    /// </summary>
    public PrivilegeAccountsReceivableId Id { get; private set; }

    /// <summary>
    /// ArType of the PrivilegeAccountsReceivable
    /// ArType الخاص بـ PrivilegeAccountsReceivable
    /// </summary>
    public decimal? ArType { get; private set; }

    /// <summary>
    /// SType of the PrivilegeAccountsReceivable
    /// SType الخاص بـ PrivilegeAccountsReceivable
    /// </summary>
    public decimal? SType { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeAccountsReceivable
    /// AdditionalFlag الخاص بـ PrivilegeAccountsReceivable
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeAccountsReceivable
    /// ViewFlag الخاص بـ PrivilegeAccountsReceivable
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// FillFlag of the PrivilegeAccountsReceivable
    /// FillFlag الخاص بـ PrivilegeAccountsReceivable
    /// </summary>
    public decimal? FillFlag { get; private set; }

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
