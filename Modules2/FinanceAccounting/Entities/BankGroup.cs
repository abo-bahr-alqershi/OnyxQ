using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BankGroup Entity
/// الكلاس يمثل مجموعة البنوك ويحتوي على جميع خصائص مجموعات البنوك
/// </summary>
public class BankGroup : Entity<BankGroupId>
{

    private BankGroup() { }

    public BankGroup(BankGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// The unique identifier for the BankGroup
    /// المعرف الفريد لـ BankGroup
    /// معرف فريد لمجموعة البنوك
    /// </summary>
    public BankGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the BankGroup
    /// GroupNumber الخاص بـ BankGroup
    /// رقم المجموعة
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupName of the BankGroup
    /// GroupName الخاص بـ BankGroup
    /// اسم المجموعة
    /// </summary>
    public string GroupName { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the BankGroup
    /// GroupNameEnglish الخاص بـ BankGroup
    /// اسم المجموعة بالإنجليزية
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

