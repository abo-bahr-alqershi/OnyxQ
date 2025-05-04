using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MessageUser entity
/// </summary>
public sealed class MessageUserCreatedEvent : DomainEvent
{
    public MessageUserId MessageUserId { get; }

    public MessageUserCreatedEvent(MessageUserId messageuserId)
    {
        MessageUserId = messageuserId;
    }
}

public sealed class MessageUserUpdatedEvent : DomainEvent
{
    public MessageUserId MessageUserId { get; }

    public MessageUserUpdatedEvent(MessageUserId messageuserId)
    {
        MessageUserId = messageuserId;
    }
}

public sealed class MessageUserDeletedEvent : DomainEvent
{
    public MessageUserId MessageUserId { get; }

    public MessageUserDeletedEvent(MessageUserId messageuserId)
    {
        MessageUserId = messageuserId;
    }
}
}
