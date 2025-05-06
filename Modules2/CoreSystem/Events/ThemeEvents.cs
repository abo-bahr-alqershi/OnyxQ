using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Theme entity
/// </summary>
public sealed class ThemeCreatedEvent : DomainEvent
{
    public ThemeId ThemeId { get; }

    public ThemeCreatedEvent(ThemeId themeId)
    {
        ThemeId = themeId;
    }
}

public sealed class ThemeUpdatedEvent : DomainEvent
{
    public ThemeId ThemeId { get; }

    public ThemeUpdatedEvent(ThemeId themeId)
    {
        ThemeId = themeId;
    }
}

public sealed class ThemeDeletedEvent : DomainEvent
{
    public ThemeId ThemeId { get; }

    public ThemeDeletedEvent(ThemeId themeId)
    {
        ThemeId = themeId;
    }
}
}
