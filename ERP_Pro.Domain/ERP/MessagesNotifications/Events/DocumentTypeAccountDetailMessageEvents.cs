using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events;

/// <summary>
/// Event raised when a document type account detail message is created
/// حدث يتم رفعه عند إنشاء رسالة تفاصيل حساب نوع المستند
/// </summary>
public class DocumentTypeAccountDetailMessageCreatedEvent : DomainEvent
{
    public DocumentTypeAccountDetailMessage Message { get; }

    public DocumentTypeAccountDetailMessageCreatedEvent(DocumentTypeAccountDetailMessage message)
    {
        Message = message;
    }
}

/// <summary>
/// Event raised when a document type account detail message is updated
/// حدث يتم رفعه عند تحديث رسالة تفاصيل حساب نوع المستند
/// </summary>
public class DocumentTypeAccountDetailMessageUpdatedEvent : DomainEvent
{
    public DocumentTypeAccountDetailMessage Message { get; }

    public DocumentTypeAccountDetailMessageUpdatedEvent(DocumentTypeAccountDetailMessage message)
    {
        Message = message;
    }
} 