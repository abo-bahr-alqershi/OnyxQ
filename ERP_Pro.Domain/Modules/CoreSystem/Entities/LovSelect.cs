using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل كيان اختيار القيم (LOV) ويحتوي على جميع خصائص القيم المختارة في النظام.
public class LovSelect : Entity<LovSelectId>
{
    private LovSelect() { }

    public LovSelect(LovSelectId id, string lovName)
    {
        Id = id;
        LovName = lovName;
    }

    // المعرف الفريد للقيمة المختارة (مفتاح رئيسي).
    public LovSelectId Id { get; private set; }
    // رقم القيمة المختارة.
    public decimal? LovNumber { get; private set; }
    // اسم القيمة المختارة.
    public string LovName { get; private set; }
    // رقم التسمية للقيمة المختارة.
    public decimal? LovLabelNumber { get; private set; }
    // استعلام SQL الخاص بالقيمة المختارة.
    public string LovSql { get; private set; }
    // القيمة السابقة.
    public string LovPrevious { get; private set; }
    // خاصية التجميع.
    public string GroupByShort { get; private set; }
    // عدد أعمدة القيمة المختارة.
    public decimal? LovColumnCount { get; private set; }
    // تسمية الأعمدة.
    public string LovColumnLabel { get; private set; }
    // عرض الأعمدة.
    public string LovColumnWidth { get; private set; }
    // إخفاء الأعمدة.
    public string LovColumnHide { get; private set; }
    // ترتيب افتراضي.
    public string DfltOrdr { get; private set; }
    // الأعمدة من اليسار لليمين.
    public string LovColumnLeftToRight { get; private set; }
    // الأعمدة من اليمين لليسار.
    public string LovColumnRightToLeft { get; private set; }
    // شرط where للتقارير المعتمدة.
    public string ReportDependentWhere { get; private set; }
    // عمود الإرجاع في التقرير.
    public string ReportReturnColumn { get; private set; }
    // علم خاص للقيمة المختارة.
    public decimal? LovSpecialFlag { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بالقيم المختارة
    #endregion
}
}
