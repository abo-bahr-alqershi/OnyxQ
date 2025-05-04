using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountCodeDetailGroups Entity
/// </summary>
public class GeneralLedgerAccountCodeDetailGroups : Entity<GeneralLedgerAccountCodeDetailGroupsId>
{
    private GeneralLedgerAccountCodeDetailGroups() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountCodeDetailGroups
    /// المعرف الفريد لـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroupsId Id { get; private set; }

    /// <summary>
    /// GroupCode of the GeneralLedgerAccountCodeDetailGroups
    /// GroupCode الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public decimal? GroupCode { get; private set; }

    /// <summary>
    /// GroupLastNameShort of the GeneralLedgerAccountCodeDetailGroups
    /// GroupLastNameShort الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public string GroupLastNameShort { get; private set; }

    /// <summary>
    /// GroupFirstNameShort of the GeneralLedgerAccountCodeDetailGroups
    /// GroupFirstNameShort الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public string GroupFirstNameShort { get; private set; }

    /// <summary>
    /// GroupConnectionCode of the GeneralLedgerAccountCodeDetailGroups
    /// GroupConnectionCode الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public decimal? GroupConnectionCode { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerAccountCodeDetailGroups
    /// AccountCode الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAccountCodeDetailGroups
    /// AccountDetailType الخاص بـ GeneralLedgerAccountCodeDetailGroups
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GeneralLedgerAccountCodeDetailGroups to GeneralLedgerAccountDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetail> GeneralLedgerAccountDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerAccountDetailGroups
    /// </summary>
    public GeneralLedgerAccountDetailGroups GeneralLedgerAccountDetailGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralLedgerAccountCodeDetailGroups to GeneralLedgerAccountCodeDetailGroupsPrivilege
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountCodeDetailGroupsPrivilege> GeneralLedgerAccountCodeDetailGroupsPrivileges { get; private set; }
    #endregion
}
}
