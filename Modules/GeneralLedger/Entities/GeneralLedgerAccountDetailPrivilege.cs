using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountDetailPrivilege Entity
/// </summary>
public class GeneralLedgerAccountDetailPrivilege : Entity<GeneralLedgerAccountDetailPrivilegeId>
{
    private GeneralLedgerAccountDetailPrivilege() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailPrivilege
    /// المعرف الفريد لـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public GeneralLedgerAccountDetailPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the GeneralLedgerAccountDetailPrivilege
    /// UserId الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerAccountDetailPrivilege
    /// AccountDetailCode الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAccountDetailPrivilege
    /// AccountDetailType الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerAccountDetailPrivilege
    /// CurCode الخاص بـ GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public string CurCode { get; private set; }

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
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerAccountDetailCurrency
    /// </summary>
    public GeneralLedgerAccountDetailCurrency GeneralLedgerAccountDetailCurrency { get; private set; }
    #endregion
}
}
