using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountDetailPrivilege Entity
/// </summary>
public class GeneralLedgerAccountDetailPrivilege : Entity<GeneralLedgerAccountDetailPrivilegeId>
{

    private GeneralLedgerAccountDetailPrivilege() { }

    public GeneralLedgerAccountDetailPrivilege(GeneralLedgerAccountDetailPrivilegeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailPrivilege
    /// المعرف الفريد لـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public GeneralLedgerAccountDetailPrivilegeId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralLedgerAccountDetailPrivilege
    /// AdditionalFlag الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralLedgerAccountDetailPrivilege
    /// ViewFlag الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerAccountDetailCurrency GeneralLedgerAccountDetailCurrency { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

