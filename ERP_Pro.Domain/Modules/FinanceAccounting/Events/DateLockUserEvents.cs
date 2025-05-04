using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to DateLockUser entity
/// </summary>
public sealed class DateLockUserCreatedEvent : DomainEvent
{
    public DateLockUserId DateLockUserId { get; }

    public DateLockUserCreatedEvent(DateLockUserId datelockuserId)
    {
        DateLockUserId = datelockuserId;
    }
}

public sealed class DateLockUserUpdatedEvent : DomainEvent
{
    public DateLockUserId DateLockUserId { get; }

    public DateLockUserUpdatedEvent(DateLockUserId datelockuserId)
    {
        DateLockUserId = datelockuserId;
    }
}

public sealed class DateLockUserDeletedEvent : DomainEvent
{
    public DateLockUserId DateLockUserId { get; }

    public DateLockUserDeletedEvent(DateLockUserId datelockuserId)
    {
        DateLockUserId = datelockuserId;
    }
}
}
