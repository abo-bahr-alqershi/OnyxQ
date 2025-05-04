using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل إغلاق الفترة المالية الحالية للفرع ويحتوي على تفاصيل العملة وسعر الصرف.
public class PeriodBranchCurrentClose : Entity<PeriodBranchCurrentCloseId>
{
    private PeriodBranchCurrentClose() { }

    public PeriodBranchCurrentClose(PeriodBranchCurrentCloseId id, decimal? periodNumberShort, decimal? branchNumber, string curCode)
    {
        Id = id;
        PeriodNumberShort = periodNumberShort;
        BranchNumber = branchNumber;
        CurCode = curCode;
    }

    // المعرف الفريد لإغلاق الفترة الحالية للفرع (مفتاح رئيسي).
    public PeriodBranchCurrentCloseId Id { get; private set; }

    // رقم الفترة المالية المختصر.
    public decimal? PeriodNumberShort { get; private set; }

    // رقم الفرع.
    public decimal? BranchNumber { get; private set; }

    // كود العملة المستخدمة في الإغلاق.
    public string CurCode { get; private set; }

    // سعر صرف العملة في الإغلاق.
    public decimal? CurRate { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بإغلاق الفترة الحالية للفرع
    #endregion
}
}
