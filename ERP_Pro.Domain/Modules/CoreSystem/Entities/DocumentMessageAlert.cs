using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل تنبيه رسالة المستند ويحتوي على خصائص التنبيه والرسائل المرتبطة بالمستندات.
public class DocumentMessageAlert : Entity<DocumentMessageAlertId>
{
    // المعرف الفريد لتنبيه رسالة المستند (مفتاح رئيسي).
    public DocumentMessageAlertId Id { get; private set; }
    // نوع المستند المرتبط بالتنبيه.
    public decimal? DocTyp { get; private set; }
    // نص الرسالة.
    public string MessageText { get; private set; }
    // علم التنبيه.
    public decimal? AlertFlag { get; private set; }
    // رقم ترتيب الرسالة.
    public decimal? OrderNumberShort { get; private set; }
    // نوع الإرسال (جوال/بريد).
    public decimal? SendType { get; private set; }
    // علم التعطيل البديل للرسالة.
    public decimal? InactiveFlagAlt { get; private set; }
    // تاريخ التعطيل البديل.
    public DateTime? InactiveDateAlt { get; private set; }
    // رقم المستخدم الذي قام بالتعطيل.
    public decimal? InactiveUserNumber { get; private set; }
    // سبب التعطيل البديل.
    public string InactiveReasonAlt { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بتنبيه رسالة المستند
    #endregion
}
}
