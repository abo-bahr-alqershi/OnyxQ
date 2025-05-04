using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountDetailMessage Entity
/// </summary>
public class AccountDetailMessage : Entity<AccountDetailMessageId>
{

    private AccountDetailMessage() { }

    public AccountDetailMessage(AccountDetailMessageId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountDetailMessage
    /// المعرف الفريد لـ AccountDetailMessage
    /// </summary>
    public AccountDetailMessageId Id { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AccountDetailMessage
    /// AccountDetailCode الخاص بـ AccountDetailMessage
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// MobileNumber of the AccountDetailMessage
    /// MobileNumber الخاص بـ AccountDetailMessage
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the AccountDetailMessage
    /// Email الخاص بـ AccountDetailMessage
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// MoveType of the AccountDetailMessage
    /// MoveType الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? MoveType { get; private set; }

    /// <summary>
    /// TransactionTypeShort of the AccountDetailMessage
    /// TransactionTypeShort الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? TransactionTypeShort { get; private set; }

    /// <summary>
    /// SendType of the AccountDetailMessage
    /// SendType الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? SendType { get; private set; }

    /// <summary>
    /// PostTypeShort of the AccountDetailMessage
    /// PostTypeShort الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? PostTypeShort { get; private set; }

    /// <summary>
    /// BalanceAmount of the AccountDetailMessage
    /// BalanceAmount الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? BalanceAmount { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the AccountDetailMessage
    /// InactiveFlagAlt الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the AccountDetailMessage
    /// InactiveDateAlt الخاص بـ AccountDetailMessage
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserNumber of the AccountDetailMessage
    /// InactiveUserNumber الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? InactiveUserNumber { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the AccountDetailMessage
    /// InactiveReasonAlt الخاص بـ AccountDetailMessage
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountDetailMessage
    /// AccountDetailType الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// SendLanguageNumber of the AccountDetailMessage
    /// SendLanguageNumber الخاص بـ AccountDetailMessage
    /// </summary>
    public decimal? SendLanguageNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
