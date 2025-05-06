using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مستند تأكيد رصيد الحساب ويحتوي على جميع خصائص تأكيدات الأرصدة
/// </summary>
public class AccountConfirmBalanceMaster : Entity<AccountConfirmBalanceMasterId>
{

    private AccountConfirmBalanceMaster() { }

    public AccountConfirmBalanceMaster(AccountConfirmBalanceMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// المعرف الفريد لـ AccountConfirmBalanceMaster
    /// </summary>
    public AccountConfirmBalanceMasterId Id { get; private set; }

    /// <summary>
    /// DocNo الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BalanceType الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BalanceType { get; private set; }

    /// <summary>
    /// ConfirmGroupType الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ConfirmGroupType { get; private set; }

    /// <summary>
    /// ProcessedFlagFull الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser الخاص بـ AccountConfirmBalanceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

