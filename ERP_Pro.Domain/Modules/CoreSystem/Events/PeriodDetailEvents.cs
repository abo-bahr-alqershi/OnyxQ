using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to PeriodDetail entity
/// </summary>
public sealed class PeriodDetailCreatedEvent : DomainEvent
{
    public PeriodDetailId PeriodDetailId { get; }

    public PeriodDetailCreatedEvent(PeriodDetailId perioddetailId)
    {
        PeriodDetailId = perioddetailId;
    }
}

public sealed class PeriodDetailUpdatedEvent : DomainEvent
{
    public PeriodDetailId PeriodDetailId { get; }

    public PeriodDetailUpdatedEvent(PeriodDetailId perioddetailId)
    {
        PeriodDetailId = perioddetailId;
    }
}

public sealed class PeriodDetailDeletedEvent : DomainEvent
{
    public PeriodDetailId PeriodDetailId { get; }

    public PeriodDetailDeletedEvent(PeriodDetailId perioddetailId)
    {
        PeriodDetailId = perioddetailId;
    }
}
}
