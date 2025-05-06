using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MessageSms entity
/// </summary>
public sealed class MessageSmsCreatedEvent : DomainEvent
{
    public MessageSmsId MessageSmsId { get; }

    public MessageSmsCreatedEvent(MessageSmsId messagesmsId)
    {
        MessageSmsId = messagesmsId;
    }
}

public sealed class MessageSmsUpdatedEvent : DomainEvent
{
    public MessageSmsId MessageSmsId { get; }

    public MessageSmsUpdatedEvent(MessageSmsId messagesmsId)
    {
        MessageSmsId = messagesmsId;
    }
}

public sealed class MessageSmsDeletedEvent : DomainEvent
{
    public MessageSmsId MessageSmsId { get; }

    public MessageSmsDeletedEvent(MessageSmsId messagesmsId)
    {
        MessageSmsId = messagesmsId;
    }
}
}
