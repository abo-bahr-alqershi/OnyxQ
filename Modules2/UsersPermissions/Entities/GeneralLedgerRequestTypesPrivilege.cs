using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// GeneralLedgerRequestTypesPrivilege Entity
/// </summary>
public class GeneralLedgerRequestTypesPrivilege : Entity<GeneralLedgerRequestTypesPrivilegeId>
{

    private GeneralLedgerRequestTypesPrivilege() { }

    public GeneralLedgerRequestTypesPrivilege(GeneralLedgerRequestTypesPrivilegeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestTypesPrivilege
    /// المعرف الفريد لـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public GeneralLedgerRequestTypesPrivilegeId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralLedgerRequestTypesPrivilege
    /// AdditionalFlag الخاص بـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralLedgerRequestTypesPrivilege
    /// ViewFlag الخاص بـ GeneralLedgerRequestTypesPrivilege
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
    public GeneralLedgerRequestTypes GeneralLedgerRequestTypes { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

