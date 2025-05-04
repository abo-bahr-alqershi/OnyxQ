using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// GeneralLedgerRequestTypesPrivilege Entity
/// </summary>
public class GeneralLedgerRequestTypesPrivilege : Entity<GeneralLedgerRequestTypesPrivilegeId>
{
    private GeneralLedgerRequestTypesPrivilege() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestTypesPrivilege
    /// المعرف الفريد لـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public GeneralLedgerRequestTypesPrivilegeId Id { get; private set; }

    /// <summary>
    /// RequestDocumentType of the GeneralLedgerRequestTypesPrivilege
    /// RequestDocumentType الخاص بـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public decimal? RequestDocumentType { get; private set; }

    /// <summary>
    /// RequestTypeShort of the GeneralLedgerRequestTypesPrivilege
    /// RequestTypeShort الخاص بـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public decimal? RequestTypeShort { get; private set; }

    /// <summary>
    /// UserId of the GeneralLedgerRequestTypesPrivilege
    /// UserId الخاص بـ GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

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
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerRequestTypes
    /// </summary>
    public GeneralLedgerRequestTypes GeneralLedgerRequestTypes { get; private set; }
    #endregion
}
}
