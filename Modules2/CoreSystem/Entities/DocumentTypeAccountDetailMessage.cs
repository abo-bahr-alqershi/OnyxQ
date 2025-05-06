using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل رسالة تفاصيل حساب نوع المستند ويحتوي على خصائص الرسالة المرتبطة بتفاصيل الحساب وأنواع المستندات.
public class DocumentTypeAccountDetailMessage : Entity<DocumentTypeAccountDetailMessageId>
{
    // المعرف الفريد لرسالة تفاصيل حساب نوع المستند (مفتاح رئيسي).
    public DocumentTypeAccountDetailMessageId Id { get; private set; }
    // نوع المستند المرتبط بالرسالة.
    public decimal? DocTyp { get; private set; }
    // نوع تفاصيل الحساب المرتبط بالرسالة.
    public decimal? AccountDetailType { get; private set; }
    // نص الرسالة.
    public string MessageText { get; private set; }
    // رقم ترتيب الرسالة.
    public decimal? OrderNumberShort { get; private set; }
    // علم التعطيل البديل للرسالة.
    public decimal? InactiveFlagAlt { get; private set; }
    // تاريخ التعطيل البديل.
    public DateTime? InactiveDateAlt { get; private set; }
    // رقم المستخدم الذي قام بالتعطيل.
    public decimal? InactiveUserNumber { get; private set; }
    // سبب التعطيل البديل.
    public string InactiveReasonAlt { get; private set; }
    // علم خاص لنص الرسالة.
    public decimal? MessageTextSpecialFlag { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص برسالة تفاصيل حساب نوع المستند
    #endregion
}
}
