using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountMessage Entity
/// </summary>
public class AccountMessage : Entity<AccountMessageId>
{

    private AccountMessage() { }

    public AccountMessage(AccountMessageId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountMessage
    /// المعرف الفريد لـ AccountMessage
    /// </summary>
    public AccountMessageId Id { get; private set; }

    /// <summary>
    /// AccountCode of the AccountMessage
    /// AccountCode الخاص بـ AccountMessage
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// MobileNumber of the AccountMessage
    /// MobileNumber الخاص بـ AccountMessage
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the AccountMessage
    /// Email الخاص بـ AccountMessage
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// MoveType of the AccountMessage
    /// MoveType الخاص بـ AccountMessage
    /// </summary>
    public decimal? MoveType { get; private set; }

    /// <summary>
    /// TransactionTypeShort of the AccountMessage
    /// TransactionTypeShort الخاص بـ AccountMessage
    /// </summary>
    public decimal? TransactionTypeShort { get; private set; }

    /// <summary>
    /// SendType of the AccountMessage
    /// SendType الخاص بـ AccountMessage
    /// </summary>
    public decimal? SendType { get; private set; }

    /// <summary>
    /// PostTypeShort of the AccountMessage
    /// PostTypeShort الخاص بـ AccountMessage
    /// </summary>
    public decimal? PostTypeShort { get; private set; }

    /// <summary>
    /// BalanceAmount of the AccountMessage
    /// BalanceAmount الخاص بـ AccountMessage
    /// </summary>
    public decimal? BalanceAmount { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the AccountMessage
    /// InactiveFlagAlt الخاص بـ AccountMessage
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the AccountMessage
    /// InactiveDateAlt الخاص بـ AccountMessage
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserNumber of the AccountMessage
    /// InactiveUserNumber الخاص بـ AccountMessage
    /// </summary>
    public decimal? InactiveUserNumber { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the AccountMessage
    /// InactiveReasonAlt الخاص بـ AccountMessage
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountMessage
    /// CompanyNumberShort الخاص بـ AccountMessage
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountMessage
    /// BranchNumber الخاص بـ AccountMessage
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountMessage
    /// BranchYear الخاص بـ AccountMessage
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountMessage
    /// BranchUser الخاص بـ AccountMessage
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// SendLanguageNumber of the AccountMessage
    /// SendLanguageNumber الخاص بـ AccountMessage
    /// </summary>
    public decimal? SendLanguageNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
