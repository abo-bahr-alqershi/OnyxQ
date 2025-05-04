using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to DateLock entity
/// </summary>
public sealed class DateLockCreatedEvent : DomainEvent
{
    public DateLockId DateLockId { get; }

    public DateLockCreatedEvent(DateLockId datelockId)
    {
        DateLockId = datelockId;
    }
}

public sealed class DateLockUpdatedEvent : DomainEvent
{
    public DateLockId DateLockId { get; }

    public DateLockUpdatedEvent(DateLockId datelockId)
    {
        DateLockId = datelockId;
    }
}

public sealed class DateLockDeletedEvent : DomainEvent
{
    public DateLockId DateLockId { get; }

    public DateLockDeletedEvent(DateLockId datelockId)
    {
        DateLockId = datelockId;
    }
}
}
