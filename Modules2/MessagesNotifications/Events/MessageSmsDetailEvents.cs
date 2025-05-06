using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MessageSmsDetail entity
/// </summary>
public sealed class MessageSmsDetailCreatedEvent : DomainEvent
{
    public MessageSmsDetailId MessageSmsDetailId { get; }

    public MessageSmsDetailCreatedEvent(MessageSmsDetailId messagesmsdetailId)
    {
        MessageSmsDetailId = messagesmsdetailId;
    }
}

public sealed class MessageSmsDetailUpdatedEvent : DomainEvent
{
    public MessageSmsDetailId MessageSmsDetailId { get; }

    public MessageSmsDetailUpdatedEvent(MessageSmsDetailId messagesmsdetailId)
    {
        MessageSmsDetailId = messagesmsdetailId;
    }
}

public sealed class MessageSmsDetailDeletedEvent : DomainEvent
{
    public MessageSmsDetailId MessageSmsDetailId { get; }

    public MessageSmsDetailDeletedEvent(MessageSmsDetailId messagesmsdetailId)
    {
        MessageSmsDetailId = messagesmsdetailId;
    }
}
}
