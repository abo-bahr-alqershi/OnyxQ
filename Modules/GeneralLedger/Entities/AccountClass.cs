using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountClass Entity
/// </summary>
public class AccountClass : Entity<AccountClassId>
{
    private AccountClass() { }

    /// <summary>
    /// The unique identifier for the AccountClass
    /// المعرف الفريد لـ AccountClass
    /// </summary>
    public AccountClassId Id { get; private set; }

    /// <summary>
    /// ClassNumber of the AccountClass
    /// ClassNumber الخاص بـ AccountClass
    /// </summary>
    public decimal? ClassNumber { get; private set; }

    /// <summary>
    /// ClassNameArabic of the AccountClass
    /// ClassNameArabic الخاص بـ AccountClass
    /// </summary>
    public string ClassNameArabic { get; private set; }

    /// <summary>
    /// ClassNameEnglish of the AccountClass
    /// ClassNameEnglish الخاص بـ AccountClass
    /// </summary>
    public string ClassNameEnglish { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AccountClass to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    #endregion
}
}
