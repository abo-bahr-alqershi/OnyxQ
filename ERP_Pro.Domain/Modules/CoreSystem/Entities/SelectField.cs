using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل حقل اختيار ويحتوي على جميع خصائص الحقل المرتبط بالنماذج والفروع.
public class SelectField : Entity<SelectFieldId>
{

    private SelectField() { }

    public SelectField(SelectFieldId id, decimal? formNumber, decimal? fieldId, decimal? branchNumber)
    {
        Id = id;
        FormNumber = formNumber;
        FieldId = fieldId;
        BranchNumber = branchNumber;
    }

    // المعرف الفريد لحقل الاختيار (مفتاح رئيسي).
    public SelectFieldId Id { get; private set; }

    // رقم النموذج المرتبط بالحقل.
    public decimal? FormNumber { get; private set; }

    // رقم الحقل.
    public decimal? FieldId { get; private set; }

    // اسم الحقل.
    public string FieldName { get; private set; }

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
