using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل كيان شاشة مخصصة ويحتوي على تفاصيل الحقول والعناصر المخصصة في الشاشة.
public class DedicatedScreenDetail : Entity<DedicatedScreenDetailId>
{
    // المعرف الفريد لتفاصيل الشاشة المخصصة (مفتاح رئيسي).
    public DedicatedScreenDetailId Id { get; private set; }
    // رقم النموذج المرتبط.
    public decimal? FormNumber { get; private set; }
    // اسم الكائن المختصر.
    public string ObjectNameShort { get; private set; }
    // اسم الحقل المختصر.
    public string FieldNameShort { get; private set; }
    // رقم الحقل.
    public decimal? FieldNumber { get; private set; }
    // رقم التسمية المختصر.
    public decimal? LabelNumberShort { get; private set; }
    // نوع الحقل المختصر.
    public decimal? FieldTypeShort { get; private set; }
    // الحقل السابق.
    public decimal? FieldPrevious { get; private set; }
    // رأس الحقل.
    public decimal? FieldHeader { get; private set; }
    // إلزامية الحقل.
    public decimal? FieldMandatory { get; private set; }
    // نوع القائمة المرتبطة بالحقل.
    public decimal? FlagListType { get; private set; }
    // شرط القائمة المرتبطة بالحقل.
    public string FlagListWhere { get; private set; }
    // كود العلامة.
    public string FlagCode { get; private set; }
    // اسم الجدول الأخير.
    public string LastTable { get; private set; }
    // اسم العمود الأخير.
    public string LastColumnName { get; private set; }
    // قيمة العمود الأخير.
    public string LastColumnValue { get; private set; }
    // عرض الحقل.
    public decimal? FieldWidth { get; private set; }
    // تحديث الحقل.
    public decimal? FieldUpdate { get; private set; }
    // رقم ترتيب الحقل المختصر.
    public decimal? OrderNumberShort { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بتفاصيل الشاشة المخصصة
    #endregion
}
}
