using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مجموعة مراكز التكلفة ويحتوي على جميع خصائص مجموعات مراكز التكلفة
/// </summary>
public class CostCenterGroup : Entity<CostCenterGroupId>
{

    private CostCenterGroup() { }

    public CostCenterGroup(CostCenterGroupId id, decimal? groupNumber)
    {
        Id = id;
        GroupNumber = groupNumber;
    }

    /// <summary>
    /// معرف فريد لمجموعة مراكز التكلفة
    /// </summary>
    public CostCenterGroupId Id { get; private set; }

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

