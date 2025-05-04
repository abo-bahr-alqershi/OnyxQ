using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل تحكم التسلسل ويحتوي على جميع خصائص التحكم في التسلسل.
public class SequenceControl : Entity<SequenceControlId>
{

    private SequenceControl() { }

    public SequenceControl(SequenceControlId id, string sTableName, string sColumnName)
    {
        Id = id;
        STableName = sTableName;
        SColumnName = sColumnName;
    }

    // المعرف الفريد لتحكم التسلسل (مفتاح رئيسي).
    public SequenceControlId Id { get; private set; }

    // اسم الجدول المرتبط بالتسلسل.
    public string STableName { get; private set; }

    // اسم العمود المرتبط بالتسلسل.
    public string SColumnName { get; private set; }

    // نوع التسلسل.
    public decimal? SSequenceType { get; private set; }

    // عمود إضافي 1.
    public string SColumn1 { get; private set; }

    // عمود إضافي 2.
    public string SColumn2 { get; private set; }

    // عمود إضافي 3.
    public string SColumn3 { get; private set; }

    // عمود إضافي 4.
    public string SColumn4 { get; private set; }

    // عمود إضافي 5.
    public string SColumn5 { get; private set; }

    // عمود إضافي 6.
    public string SColumn6 { get; private set; }

    // قيمة الزيادة في التسلسل.
    public decimal? SIncreaseByValue { get; private set; }

    // القيمة الابتدائية للتسلسل.
    public decimal? SInitialValue { get; private set; }

    // تسلسل التجميع.
    public string SSequenceConcat { get; private set; }

    // اسم التريجر.
    public string TriggerName { get; private set; }

    // علم فقط إذا كان فارغاً.
    public decimal? OnlyIfNullFlag { get; private set; }

    // رقم الشركة المختصر.
    public decimal? CompanyNumberShort { get; private set; }

    // رقم الفرع.
    public decimal? BranchNumber { get; private set; }

    // سنة الفرع.
    public decimal? BranchYear { get; private set; }

    // المستخدم المسؤول عن الفرع.
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
