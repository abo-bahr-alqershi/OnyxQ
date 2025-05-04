using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SystemFlag entity
/// </summary>
public sealed class SystemFlagCreatedEvent : DomainEvent
{
    public SystemFlagId SystemFlagId { get; }

    public SystemFlagCreatedEvent(SystemFlagId systemflagId)
    {
        SystemFlagId = systemflagId;
    }
}

public sealed class SystemFlagUpdatedEvent : DomainEvent
{
    public SystemFlagId SystemFlagId { get; }

    public SystemFlagUpdatedEvent(SystemFlagId systemflagId)
    {
        SystemFlagId = systemflagId;
    }
}

public sealed class SystemFlagDeletedEvent : DomainEvent
{
    public SystemFlagId SystemFlagId { get; }

    public SystemFlagDeletedEvent(SystemFlagId systemflagId)
    {
        SystemFlagId = systemflagId;
    }
}
}
