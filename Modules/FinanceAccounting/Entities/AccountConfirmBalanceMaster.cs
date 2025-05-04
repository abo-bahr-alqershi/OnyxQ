using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountConfirmBalanceMaster Entity
/// </summary>
public class AccountConfirmBalanceMaster : Entity<AccountConfirmBalanceMasterId>
{
    private AccountConfirmBalanceMaster() { }

    /// <summary>
    /// The unique identifier for the AccountConfirmBalanceMaster
    /// المعرف الفريد لـ AccountConfirmBalanceMaster
    /// </summary>
    public AccountConfirmBalanceMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountConfirmBalanceMaster
    /// DocNo الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountConfirmBalanceMaster
    /// DocSer الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AccountConfirmBalanceMaster
    /// DocDate الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the AccountConfirmBalanceMaster
    /// DocDesc الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountConfirmBalanceMaster
    /// ReferenceNumber الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BalanceType of the AccountConfirmBalanceMaster
    /// BalanceType الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BalanceType { get; private set; }

    /// <summary>
    /// ConfirmGroupType of the AccountConfirmBalanceMaster
    /// ConfirmGroupType الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ConfirmGroupType { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountConfirmBalanceMaster
    /// ProcessedFlagFull الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the AccountConfirmBalanceMaster
    /// ApprovedFlag الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the AccountConfirmBalanceMaster
    /// ApprovalUserId الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the AccountConfirmBalanceMaster
    /// ApprovalDate الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the AccountConfirmBalanceMaster
    /// ApprovalDescription الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountConfirmBalanceMaster
    /// CompanyNumberShort الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountConfirmBalanceMaster
    /// BranchNumber الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountConfirmBalanceMaster
    /// BranchYear الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountConfirmBalanceMaster
    /// BranchUser الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AccountConfirmBalanceMaster to AccountConfirmBalanceDetail
    /// </summary>
    public IReadOnlyCollection<AccountConfirmBalanceDetail> AccountConfirmBalanceDetails { get; private set; }
    #endregion
}
}
