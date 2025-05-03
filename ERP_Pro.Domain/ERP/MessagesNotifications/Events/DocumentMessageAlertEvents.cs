using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events;

/// <summary>
/// Event raised when a document message alert is created
/// حدث يتم رفعه عند إنشاء تنبيه رسالة المستند
/// </summary>
public class DocumentMessageAlertCreatedEvent : DomainEvent
{
    public DocumentMessageAlert Alert { get; }

    public DocumentMessageAlertCreatedEvent(DocumentMessageAlert alert)
    {
        Alert = alert;
    }
}

/// <summary>
/// Event raised when a document message alert is updated
/// حدث يتم رفعه عند تحديث تنبيه رسالة المستند
/// </summary>
public class DocumentMessageAlertUpdatedEvent : DomainEvent
{
    public DocumentMessageAlert Alert { get; }

    public DocumentMessageAlertUpdatedEvent(DocumentMessageAlert alert)
    {
        Alert = alert;
    }
} 