using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MessageCss entity
/// </summary>
public sealed class MessageCssCreatedEvent : DomainEvent
{
    public MessageCssId MessageCssId { get; }

    public MessageCssCreatedEvent(MessageCssId messagecssId)
    {
        MessageCssId = messagecssId;
    }
}

public sealed class MessageCssUpdatedEvent : DomainEvent
{
    public MessageCssId MessageCssId { get; }

    public MessageCssUpdatedEvent(MessageCssId messagecssId)
    {
        MessageCssId = messagecssId;
    }
}

public sealed class MessageCssDeletedEvent : DomainEvent
{
    public MessageCssId MessageCssId { get; }

    public MessageCssDeletedEvent(MessageCssId messagecssId)
    {
        MessageCssId = messagecssId;
    }
}
}
