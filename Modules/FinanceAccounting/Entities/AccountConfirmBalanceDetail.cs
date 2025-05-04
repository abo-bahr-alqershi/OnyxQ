using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountConfirmBalanceDetail Entity
/// </summary>
public class AccountConfirmBalanceDetail : Entity<AccountConfirmBalanceDetailId>
{
    private AccountConfirmBalanceDetail() { }

    /// <summary>
    /// The unique identifier for the AccountConfirmBalanceDetail
    /// المعرف الفريد لـ AccountConfirmBalanceDetail
    /// </summary>
    public AccountConfirmBalanceDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountConfirmBalanceDetail
    /// DocNo الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountConfirmBalanceDetail
    /// DocSer الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCode of the AccountConfirmBalanceDetail
    /// AccountCode الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AccountConfirmBalanceDetail
    /// AccountDetailCode الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountConfirmBalanceDetail
    /// AccountDetailType الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountConfirmBalanceDetail
    /// AccountCurrency الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountConfirmBalanceDetail
    /// CostCenterCode الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountConfirmBalanceDetail
    /// ProjectNumber الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountConfirmBalanceDetail
    /// ActivityNumber الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RepCode of the AccountConfirmBalanceDetail
    /// RepCode الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// BalanceAmount of the AccountConfirmBalanceDetail
    /// BalanceAmount الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? BalanceAmount { get; private set; }

    /// <summary>
    /// BalanceAmountManual of the AccountConfirmBalanceDetail
    /// BalanceAmountManual الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? BalanceAmountManual { get; private set; }

    /// <summary>
    /// ConfirmDescription of the AccountConfirmBalanceDetail
    /// ConfirmDescription الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string ConfirmDescription { get; private set; }

    /// <summary>
    /// ConfirmDate of the AccountConfirmBalanceDetail
    /// ConfirmDate الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public DateTime? ConfirmDate { get; private set; }

    /// <summary>
    /// CustomerConfirmDescription of the AccountConfirmBalanceDetail
    /// CustomerConfirmDescription الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public string CustomerConfirmDescription { get; private set; }

    /// <summary>
    /// ConfirmClassFlag of the AccountConfirmBalanceDetail
    /// ConfirmClassFlag الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? ConfirmClassFlag { get; private set; }

    /// <summary>
    /// CustomerConfirmFlag of the AccountConfirmBalanceDetail
    /// CustomerConfirmFlag الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? CustomerConfirmFlag { get; private set; }

    /// <summary>
    /// CustomerConfirmDate of the AccountConfirmBalanceDetail
    /// CustomerConfirmDate الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public DateTime? CustomerConfirmDate { get; private set; }

    /// <summary>
    /// AccountRate of the AccountConfirmBalanceDetail
    /// AccountRate الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountConfirmBalanceDetail
    /// RecordNumber الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountConfirmBalanceDetail
    /// CompanyNumberShort الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountConfirmBalanceDetail
    /// BranchNumber الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountConfirmBalanceDetail
    /// BranchYear الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountConfirmBalanceDetail
    /// BranchUser الخاص بـ AccountConfirmBalanceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountConfirmBalanceMaster
    /// </summary>
    public AccountConfirmBalanceMaster AccountConfirmBalanceMaster { get; private set; }
    #endregion
}
}
