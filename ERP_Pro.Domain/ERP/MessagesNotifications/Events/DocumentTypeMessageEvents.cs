using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events;

/// <summary>
/// Event raised when a document type message is created
/// حدث يتم رفعه عند إنشاء رسالة نوع المستند
/// </summary>
public class DocumentTypeMessageCreatedEvent : DomainEvent
{
    public DocumentTypeMessage Message { get; }

    public DocumentTypeMessageCreatedEvent(DocumentTypeMessage message)
    {
        Message = message;
    }
}

/// <summary>
/// Event raised when a document type message is updated
/// حدث يتم رفعه عند تحديث رسالة نوع المستند
/// </summary>
public class DocumentTypeMessageUpdatedEvent : DomainEvent
{
    public DocumentTypeMessage Message { get; }

    public DocumentTypeMessageUpdatedEvent(DocumentTypeMessage message)
    {
        Message = message;
    }
} 