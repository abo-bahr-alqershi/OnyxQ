using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountType Entity
/// </summary>
public class AccountType : Entity<AccountTypeId>
{
    private AccountType() { }

    /// <summary>
    /// The unique identifier for the AccountType
    /// المعرف الفريد لـ AccountType
    /// </summary>
    public AccountTypeId Id { get; private set; }

    /// <summary>
    /// AccountType of the AccountType
    /// AccountType الخاص بـ AccountType
    /// </summary>
    public decimal? AccountType { get; private set; }

    /// <summary>
    /// AccountName of the AccountType
    /// AccountName الخاص بـ AccountType
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// AccountNameEnglish of the AccountType
    /// AccountNameEnglish الخاص بـ AccountType
    /// </summary>
    public string AccountNameEnglish { get; private set; }

    /// <summary>
    /// AffectedByTransactionFlag of the AccountType
    /// AffectedByTransactionFlag الخاص بـ AccountType
    /// </summary>
    public decimal? AffectedByTransactionFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AccountType to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    #endregion
}
}
