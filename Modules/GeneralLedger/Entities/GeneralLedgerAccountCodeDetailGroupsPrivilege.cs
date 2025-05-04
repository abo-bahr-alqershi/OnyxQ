using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountCodeDetailGroupsPrivilege Entity
/// </summary>
public class GeneralLedgerAccountCodeDetailGroupsPrivilege : Entity<GeneralLedgerAccountCodeDetailGroupsPrivilegeId>
{
    private GeneralLedgerAccountCodeDetailGroupsPrivilege() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// المعرف الفريد لـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroupsPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// UserId الخاص بـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// GroupCode of the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// GroupCode الخاص بـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public decimal? GroupCode { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// AccountCode الخاص بـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AdditionalFlag of the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// AdditionalFlag الخاص بـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// ViewFlag الخاص بـ GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroups GeneralLedgerAccountCodeDetailGroups { get; private set; }
    #endregion
}
}
