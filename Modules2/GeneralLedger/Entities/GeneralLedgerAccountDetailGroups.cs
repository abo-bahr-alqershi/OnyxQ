using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountDetailGroups Entity
/// </summary>
public class GeneralLedgerAccountDetailGroups : Entity<GeneralLedgerAccountDetailGroupsId>
{

    private GeneralLedgerAccountDetailGroups() { }

    public GeneralLedgerAccountDetailGroups(GeneralLedgerAccountDetailGroupsId id, decimal? groupCode)
    {
        Id = id;
        GroupCode = groupCode;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailGroups
    /// المعرف الفريد لـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public GeneralLedgerAccountDetailGroupsId Id { get; private set; }

    /// <summary>
    /// GroupCode of the GeneralLedgerAccountDetailGroups
    /// GroupCode الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public decimal? GroupCode { get; private set; }

    /// <summary>
    /// GroupLastNameShort of the GeneralLedgerAccountDetailGroups
    /// GroupLastNameShort الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string GroupLastNameShort { get; private set; }

    /// <summary>
    /// GroupFirstNameShort of the GeneralLedgerAccountDetailGroups
    /// GroupFirstNameShort الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string GroupFirstNameShort { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAccountDetailGroups
    /// AccountDetailType الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailTypeDetail of the GeneralLedgerAccountDetailGroups
    /// AccountDetailTypeDetail الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public decimal? AccountDetailTypeDetail { get; private set; }

    /// <summary>
    /// Field1 of the GeneralLedgerAccountDetailGroups
    /// Field1 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GeneralLedgerAccountDetailGroups
    /// Field2 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GeneralLedgerAccountDetailGroups
    /// Field3 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GeneralLedgerAccountDetailGroups
    /// Field4 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GeneralLedgerAccountDetailGroups
    /// Field5 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GeneralLedgerAccountDetailGroups
    /// Field6 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GeneralLedgerAccountDetailGroups
    /// Field7 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GeneralLedgerAccountDetailGroups
    /// Field8 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GeneralLedgerAccountDetailGroups
    /// Field9 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GeneralLedgerAccountDetailGroups
    /// Field10 الخاص بـ GeneralLedgerAccountDetailGroups
    /// </summary>
    public string Field10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

