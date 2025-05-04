using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to NewsCss entity
/// </summary>
public sealed class NewsCssCreatedEvent : DomainEvent
{
    public NewsCssId NewsCssId { get; }

    public NewsCssCreatedEvent(NewsCssId newscssId)
    {
        NewsCssId = newscssId;
    }
}

public sealed class NewsCssUpdatedEvent : DomainEvent
{
    public NewsCssId NewsCssId { get; }

    public NewsCssUpdatedEvent(NewsCssId newscssId)
    {
        NewsCssId = newscssId;
    }
}

public sealed class NewsCssDeletedEvent : DomainEvent
{
    public NewsCssId NewsCssId { get; }

    public NewsCssDeletedEvent(NewsCssId newscssId)
    {
        NewsCssId = newscssId;
    }
}
}
