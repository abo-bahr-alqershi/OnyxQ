using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CloseDayPeriods entity
/// </summary>
public sealed class CloseDayPeriodsCreatedEvent : DomainEvent
{
    public CloseDayPeriodsId CloseDayPeriodsId { get; }

    public CloseDayPeriodsCreatedEvent(CloseDayPeriodsId closedayperiodsId)
    {
        CloseDayPeriodsId = closedayperiodsId;
    }
}

public sealed class CloseDayPeriodsUpdatedEvent : DomainEvent
{
    public CloseDayPeriodsId CloseDayPeriodsId { get; }

    public CloseDayPeriodsUpdatedEvent(CloseDayPeriodsId closedayperiodsId)
    {
        CloseDayPeriodsId = closedayperiodsId;
    }
}

public sealed class CloseDayPeriodsDeletedEvent : DomainEvent
{
    public CloseDayPeriodsId CloseDayPeriodsId { get; }

    public CloseDayPeriodsDeletedEvent(CloseDayPeriodsId closedayperiodsId)
    {
        CloseDayPeriodsId = closedayperiodsId;
    }
}
}
