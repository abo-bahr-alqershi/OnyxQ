using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to DateLockUserScreen entity
/// </summary>
public sealed class DateLockUserScreenCreatedEvent : DomainEvent
{
    public DateLockUserScreenId DateLockUserScreenId { get; }

    public DateLockUserScreenCreatedEvent(DateLockUserScreenId datelockuserscreenId)
    {
        DateLockUserScreenId = datelockuserscreenId;
    }
}

public sealed class DateLockUserScreenUpdatedEvent : DomainEvent
{
    public DateLockUserScreenId DateLockUserScreenId { get; }

    public DateLockUserScreenUpdatedEvent(DateLockUserScreenId datelockuserscreenId)
    {
        DateLockUserScreenId = datelockuserscreenId;
    }
}

public sealed class DateLockUserScreenDeletedEvent : DomainEvent
{
    public DateLockUserScreenId DateLockUserScreenId { get; }

    public DateLockUserScreenDeletedEvent(DateLockUserScreenId datelockuserscreenId)
    {
        DateLockUserScreenId = datelockuserscreenId;
    }
}
}
