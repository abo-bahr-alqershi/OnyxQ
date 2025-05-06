using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ScreenLabel entity
/// </summary>
public sealed class ScreenLabelCreatedEvent : DomainEvent
{
    public ScreenLabelId ScreenLabelId { get; }

    public ScreenLabelCreatedEvent(ScreenLabelId screenlabelId)
    {
        ScreenLabelId = screenlabelId;
    }
}

public sealed class ScreenLabelUpdatedEvent : DomainEvent
{
    public ScreenLabelId ScreenLabelId { get; }

    public ScreenLabelUpdatedEvent(ScreenLabelId screenlabelId)
    {
        ScreenLabelId = screenlabelId;
    }
}

public sealed class ScreenLabelDeletedEvent : DomainEvent
{
    public ScreenLabelId ScreenLabelId { get; }

    public ScreenLabelDeletedEvent(ScreenLabelId screenlabelId)
    {
        ScreenLabelId = screenlabelId;
    }
}
}
