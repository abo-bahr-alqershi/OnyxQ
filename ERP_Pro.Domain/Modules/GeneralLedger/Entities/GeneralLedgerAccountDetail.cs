using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAccountDetail Entity
/// </summary>
public class GeneralLedgerAccountDetail : Entity<GeneralLedgerAccountDetailId>
{

    private GeneralLedgerAccountDetail() { }

    public GeneralLedgerAccountDetail(GeneralLedgerAccountDetailId id, string accountDetailCode, decimal? accountDetailType)
    {
        Id = id;
        AccountDetailCode = accountDetailCode;
        AccountDetailType = accountDetailType;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetail
    /// المعرف الفريد لـ GeneralLedgerAccountDetail
    /// </summary>
    public GeneralLedgerAccountDetailId Id { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerAccountDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailLastName of the GeneralLedgerAccountDetail
    /// AccountDetailLastName الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string AccountDetailLastName { get; private set; }

    /// <summary>
    /// AccountDetailFullName of the GeneralLedgerAccountDetail
    /// AccountDetailFullName الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string AccountDetailFullName { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerAccountDetail
    /// AccountDetailType الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailTypeDetail of the GeneralLedgerAccountDetail
    /// AccountDetailTypeDetail الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? AccountDetailTypeDetail { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the GeneralLedgerAccountDetail
    /// FavoriteAccountFlag الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the GeneralLedgerAccountDetail
    /// InactiveFlagAlt الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the GeneralLedgerAccountDetail
    /// InactiveReasonAlt الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the GeneralLedgerAccountDetail
    /// InactiveDateAlt الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the GeneralLedgerAccountDetail
    /// InactiveUserId الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? InactiveUserId { get; private set; }

    /// <summary>
    /// Field1 of the GeneralLedgerAccountDetail
    /// Field1 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GeneralLedgerAccountDetail
    /// Field2 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GeneralLedgerAccountDetail
    /// Field3 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GeneralLedgerAccountDetail
    /// Field4 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GeneralLedgerAccountDetail
    /// Field5 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GeneralLedgerAccountDetail
    /// Field6 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GeneralLedgerAccountDetail
    /// Field7 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GeneralLedgerAccountDetail
    /// Field8 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GeneralLedgerAccountDetail
    /// Field9 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GeneralLedgerAccountDetail
    /// Field10 الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the GeneralLedgerAccountDetail
    /// ConnectionBranchNumber الخاص بـ GeneralLedgerAccountDetail
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerAccountCodeDetailGroups GeneralLedgerAccountCodeDetailGroups { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
