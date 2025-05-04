using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ListSelect entity
/// </summary>
public sealed class ListSelectCreatedEvent : DomainEvent
{
    public ListSelectId ListSelectId { get; }

    public ListSelectCreatedEvent(ListSelectId listselectId)
    {
        ListSelectId = listselectId;
    }
}

public sealed class ListSelectUpdatedEvent : DomainEvent
{
    public ListSelectId ListSelectId { get; }

    public ListSelectUpdatedEvent(ListSelectId listselectId)
    {
        ListSelectId = listselectId;
    }
}

public sealed class ListSelectDeletedEvent : DomainEvent
{
    public ListSelectId ListSelectId { get; }

    public ListSelectDeletedEvent(ListSelectId listselectId)
    {
        ListSelectId = listselectId;
    }
}
}
