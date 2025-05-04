using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل رسالة إرسال كود ويحتوي على تفاصيل الإرسال للمستخدمين.
public class CodeSendMessage : Entity<CodeSendMessageId>
{
    // المعرف الفريد لرسالة إرسال الكود (مفتاح رئيسي).
    public CodeSendMessageId Id { get; private set; }
    // رقم السجل المرتبط بالرسالة.
    public decimal? RecordNumber { get; private set; }
    // نوع الكود المرسل.
    public decimal? CodeType { get; private set; }
    // رقم الموظف المرسل إليه الكود.
    public decimal? EmpNo { get; private set; }
    // نوع الإرسال (جوال/بريد).
    public decimal? SendType { get; private set; }
    // رقم الجوال المرسل إليه الكود.
    public string MobileNumber { get; private set; }
    // البريد الإلكتروني المرسل إليه الكود.
    public string Email { get; private set; }
    // علم التعطيل البديل.
    public decimal? InactiveFlagAlt { get; private set; }
    // تاريخ التعطيل البديل.
    public DateTime? InactiveDateAlt { get; private set; }
    // رقم المستخدم الذي قام بالتعطيل.
    public decimal? InactiveUserNumber { get; private set; }
    // سبب التعطيل البديل.
    public string InactiveReasonAlt { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص برسالة إرسال الكود
    #endregion
}
}
