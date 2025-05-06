using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to PeriodDay entity
/// </summary>
public sealed class PeriodDayCreatedEvent : DomainEvent
{
    public PeriodDayId PeriodDayId { get; }

    public PeriodDayCreatedEvent(PeriodDayId perioddayId)
    {
        PeriodDayId = perioddayId;
    }
}

public sealed class PeriodDayUpdatedEvent : DomainEvent
{
    public PeriodDayId PeriodDayId { get; }

    public PeriodDayUpdatedEvent(PeriodDayId perioddayId)
    {
        PeriodDayId = perioddayId;
    }
}

public sealed class PeriodDayDeletedEvent : DomainEvent
{
    public PeriodDayId PeriodDayId { get; }

    public PeriodDayDeletedEvent(PeriodDayId perioddayId)
    {
        PeriodDayId = perioddayId;
    }
}
}
