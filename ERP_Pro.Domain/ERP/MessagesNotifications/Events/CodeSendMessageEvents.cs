using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.MessagesNotifications.Entities;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events;

/// <summary>
/// Event raised when a code send message is created
/// حدث يتم رفعه عند إنشاء رسالة إرسال الرمز
/// </summary>
public class CodeSendMessageCreatedEvent : DomainEvent
{
    public CodeSendMessage Message { get; }

    public CodeSendMessageCreatedEvent(CodeSendMessage message)
    {
        Message = message;
    }
}

/// <summary>
/// Event raised when a code send message is updated
/// حدث يتم رفعه عند تحديث رسالة إرسال الرمز
/// </summary>
public class CodeSendMessageUpdatedEvent : DomainEvent
{
    public CodeSendMessage Message { get; }

    public CodeSendMessageUpdatedEvent(CodeSendMessage message)
    {
        Message = message;
    }
} 