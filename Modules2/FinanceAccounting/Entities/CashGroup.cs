using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل مجموعة النقدية ويحتوي على جميع خصائص مجموعات النقدية
/// </summary>
public class CashGroup : Entity<CashGroupId>
{

    private CashGroup() { }

    public CashGroup(CashGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// المعرف الفريد لمجموعة النقدية
    /// </summary>
    public CashGroupId Id { get; private set; }

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

