using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل مستند الفرع ويحتوي على جميع تفاصيل المستندات الخاصة بالفروع.
public class BranchDocument : Entity<BranchDocumentId>
{
    private BranchDocument() { }

    public BranchDocument(BranchDocumentId id, decimal? codeNumber)
    {
        Id = id;
        CodeNumber = codeNumber;
    }

    // المعرف الفريد لمستند الفرع (مفتاح رئيسي).
    public BranchDocumentId Id { get; private set; }

    // رقم الكود الخاص بالمستند.
    public decimal? CodeNumber { get; private set; }

    // رقم المستند.
    public string DocNo { get; private set; }

    // تاريخ إصدار المستند.
    public DateTime? IssueDate { get; private set; }

    // تاريخ انتهاء المستند.
    public DateTime? EndDate { get; private set; }

    // مدة التنبيه للمستند.
    public decimal? DurAlrm { get; private set; }

    // تاريخ تجديد المستند.
    public string RenewalDate { get; private set; }

    // مكان إصدار المستند.
    public string IssuePlace { get; private set; }

    // حقل إضافي 1.
    public string Field1 { get; private set; }
    // حقل إضافي 2.
    public string Field2 { get; private set; }
    // حقل إضافي 3.
    public string Field3 { get; private set; }
    // حقل إضافي 4.
    public string Field4 { get; private set; }
    // حقل إضافي 5.
    public string Field5 { get; private set; }
    // حقل إضافي 6.
    public string Field6 { get; private set; }
    // حقل إضافي 7.
    public string Field7 { get; private set; }
    // حقل إضافي 8.
    public string Field8 { get; private set; }
    // حقل إضافي 9.
    public string Field9 { get; private set; }
    // حقل إضافي 10.
    public string Field10 { get; private set; }

    // علم التعطيل للمستند.
    public decimal? InactiveFlag { get; private set; }

    // معرف المستخدم الذي قام بتعطيل المستند.
    public decimal? InactivatedByUserId { get; private set; }

    // تاريخ تعطيل المستند.
    public DateTime? InactiveDate { get; private set; }

    // سبب تعطيل المستند.
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    // الفرع المرتبط بهذا المستند.
    public Branch Branch { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بمستند الفرع
    #endregion
}
}
