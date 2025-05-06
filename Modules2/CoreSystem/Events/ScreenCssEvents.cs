using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ScreenCss entity
/// </summary>
public sealed class ScreenCssCreatedEvent : DomainEvent
{
    public ScreenCssId ScreenCssId { get; }

    public ScreenCssCreatedEvent(ScreenCssId screencssId)
    {
        ScreenCssId = screencssId;
    }
}

public sealed class ScreenCssUpdatedEvent : DomainEvent
{
    public ScreenCssId ScreenCssId { get; }

    public ScreenCssUpdatedEvent(ScreenCssId screencssId)
    {
        ScreenCssId = screencssId;
    }
}

public sealed class ScreenCssDeletedEvent : DomainEvent
{
    public ScreenCssId ScreenCssId { get; }

    public ScreenCssDeletedEvent(ScreenCssId screencssId)
    {
        ScreenCssId = screencssId;
    }
}
}
