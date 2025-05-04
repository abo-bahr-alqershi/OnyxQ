using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MessageUserDetail entity
/// </summary>
public sealed class MessageUserDetailCreatedEvent : DomainEvent
{
    public MessageUserDetailId MessageUserDetailId { get; }

    public MessageUserDetailCreatedEvent(MessageUserDetailId messageuserdetailId)
    {
        MessageUserDetailId = messageuserdetailId;
    }
}

public sealed class MessageUserDetailUpdatedEvent : DomainEvent
{
    public MessageUserDetailId MessageUserDetailId { get; }

    public MessageUserDetailUpdatedEvent(MessageUserDetailId messageuserdetailId)
    {
        MessageUserDetailId = messageuserdetailId;
    }
}

public sealed class MessageUserDetailDeletedEvent : DomainEvent
{
    public MessageUserDetailId MessageUserDetailId { get; }

    public MessageUserDetailDeletedEvent(MessageUserDetailId messageuserdetailId)
    {
        MessageUserDetailId = messageuserdetailId;
    }
}
}
