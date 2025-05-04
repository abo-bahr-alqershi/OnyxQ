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

    public GeneralLedgerAccountCodeDetailGroups(GeneralLedgerAccountCodeDetailGroupsId id, decimal? groupCode, string accountCode)
    {
        Id = id;
        GroupCode = groupCode;
        AccountCode = accountCode;
    }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerAccountDetailGroups GeneralLedgerAccountDetailGroups { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
