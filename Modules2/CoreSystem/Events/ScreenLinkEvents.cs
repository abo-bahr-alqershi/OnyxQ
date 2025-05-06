using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ScreenLink entity
/// </summary>
public sealed class ScreenLinkCreatedEvent : DomainEvent
{
    public ScreenLinkId ScreenLinkId { get; }

    public ScreenLinkCreatedEvent(ScreenLinkId screenlinkId)
    {
        ScreenLinkId = screenlinkId;
    }
}

public sealed class ScreenLinkUpdatedEvent : DomainEvent
{
    public ScreenLinkId ScreenLinkId { get; }

    public ScreenLinkUpdatedEvent(ScreenLinkId screenlinkId)
    {
        ScreenLinkId = screenlinkId;
    }
}

public sealed class ScreenLinkDeletedEvent : DomainEvent
{
    public ScreenLinkId ScreenLinkId { get; }

    public ScreenLinkDeletedEvent(ScreenLinkId screenlinkId)
    {
        ScreenLinkId = screenlinkId;
    }
}
}
