using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل نوع الحساب ويحتوي على جميع خصائص أنواع الحسابات
/// </summary>
public class AccountType : Entity<AccountTypeId>
{

    private AccountType() { }

    public AccountType(AccountTypeId id, decimal? accountType)
    {
        Id = id;
        AccountType = accountType;
    }

    /// <summary>
    /// معرف فريد لنوع الحساب
    /// </summary>
    public AccountTypeId Id { get; private set; }

    /// <summary>
    /// نوع الحساب
    /// </summary>
    public decimal? AccountType { get; private set; }

    /// <summary>
    /// اسم نوع الحساب
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// اسم نوع الحساب بالإنجليزية
    /// </summary>
    public string AccountNameEnglish { get; private set; }

    /// <summary>
    /// علم التأثر بالمعاملات
    /// </summary>
    public decimal? AffectedByTransactionFlag { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

