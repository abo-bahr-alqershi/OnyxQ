using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SystemType entity
/// </summary>
public sealed class SystemTypeCreatedEvent : DomainEvent
{
    public SystemTypeId SystemTypeId { get; }

    public SystemTypeCreatedEvent(SystemTypeId systemtypeId)
    {
        SystemTypeId = systemtypeId;
    }
}

public sealed class SystemTypeUpdatedEvent : DomainEvent
{
    public SystemTypeId SystemTypeId { get; }

    public SystemTypeUpdatedEvent(SystemTypeId systemtypeId)
    {
        SystemTypeId = systemtypeId;
    }
}

public sealed class SystemTypeDeletedEvent : DomainEvent
{
    public SystemTypeId SystemTypeId { get; }

    public SystemTypeDeletedEvent(SystemTypeId systemtypeId)
    {
        SystemTypeId = systemtypeId;
    }
}
}
