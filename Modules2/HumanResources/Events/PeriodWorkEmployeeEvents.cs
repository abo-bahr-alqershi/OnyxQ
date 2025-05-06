using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Events
{
/// <summary>
/// Events related to PeriodWorkEmployee entity
/// </summary>
public sealed class PeriodWorkEmployeeCreatedEvent : DomainEvent
{
    public PeriodWorkEmployeeId PeriodWorkEmployeeId { get; }

    public PeriodWorkEmployeeCreatedEvent(PeriodWorkEmployeeId periodworkemployeeId)
    {
        PeriodWorkEmployeeId = periodworkemployeeId;
    }
}

public sealed class PeriodWorkEmployeeUpdatedEvent : DomainEvent
{
    public PeriodWorkEmployeeId PeriodWorkEmployeeId { get; }

    public PeriodWorkEmployeeUpdatedEvent(PeriodWorkEmployeeId periodworkemployeeId)
    {
        PeriodWorkEmployeeId = periodworkemployeeId;
    }
}

public sealed class PeriodWorkEmployeeDeletedEvent : DomainEvent
{
    public PeriodWorkEmployeeId PeriodWorkEmployeeId { get; }

    public PeriodWorkEmployeeDeletedEvent(PeriodWorkEmployeeId periodworkemployeeId)
    {
        PeriodWorkEmployeeId = periodworkemployeeId;
    }
}
}
