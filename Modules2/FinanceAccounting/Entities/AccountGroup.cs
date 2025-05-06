using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مجموعة الحسابات ويحتوي على جميع خصائص مجموعات الحسابات
/// </summary>
public class AccountGroup : Entity<AccountGroupId>
{

    private AccountGroup() { }

    public AccountGroup(AccountGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// معرف فريد لمجموعة الحسابات
    /// </summary>
    public AccountGroupId Id { get; private set; }

    /// <summary>
    /// رقم المجموعة
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// اسم المجموعة
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// اسم المجموعة بالإنجليزية
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

