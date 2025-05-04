using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to MobileNotification entity
/// </summary>
public sealed class MobileNotificationCreatedEvent : DomainEvent
{
    public MobileNotificationId MobileNotificationId { get; }

    public MobileNotificationCreatedEvent(MobileNotificationId mobilenotificationId)
    {
        MobileNotificationId = mobilenotificationId;
    }
}

public sealed class MobileNotificationUpdatedEvent : DomainEvent
{
    public MobileNotificationId MobileNotificationId { get; }

    public MobileNotificationUpdatedEvent(MobileNotificationId mobilenotificationId)
    {
        MobileNotificationId = mobilenotificationId;
    }
}

public sealed class MobileNotificationDeletedEvent : DomainEvent
{
    public MobileNotificationId MobileNotificationId { get; }

    public MobileNotificationDeletedEvent(MobileNotificationId mobilenotificationId)
    {
        MobileNotificationId = mobilenotificationId;
    }
}
}
