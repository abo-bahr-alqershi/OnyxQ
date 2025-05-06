using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل رسالة نوع المستند ويحتوي على خصائص الرسالة المرتبطة بأنواع المستندات.
public class DocumentTypeMessage : Entity<DocumentTypeMessageId>
{
    private DocumentTypeMessage() { }

    public DocumentTypeMessage(DocumentTypeMessageId id, decimal? docTyp)
    {
        Id = id;
        DocTyp = docTyp;
    }

    // المعرف الفريد لرسالة نوع المستند (مفتاح رئيسي).
    public DocumentTypeMessageId Id { get; private set; }
    // نوع المستند المرتبط بالرسالة.
    public decimal? DocTyp { get; private set; }
    // علم التعطيل البديل للرسالة.
    public decimal? InactiveFlagAlt { get; private set; }
    // رقم ترتيب الرسالة.
    public decimal? OrderNumberShort { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص برسالة نوع المستند
    #endregion
}
}
