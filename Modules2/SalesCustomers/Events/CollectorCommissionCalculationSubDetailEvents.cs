using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectorCommissionCalculationSubDetail entity
/// </summary>
public sealed class CollectorCommissionCalculationSubDetailCreatedEvent : DomainEvent
{
    public CollectorCommissionCalculationSubDetailId CollectorCommissionCalculationSubDetailId { get; }

    public CollectorCommissionCalculationSubDetailCreatedEvent(CollectorCommissionCalculationSubDetailId collectorcommissioncalculationsubdetailId)
    {
        CollectorCommissionCalculationSubDetailId = collectorcommissioncalculationsubdetailId;
    }
}

public sealed class CollectorCommissionCalculationSubDetailUpdatedEvent : DomainEvent
{
    public CollectorCommissionCalculationSubDetailId CollectorCommissionCalculationSubDetailId { get; }

    public CollectorCommissionCalculationSubDetailUpdatedEvent(CollectorCommissionCalculationSubDetailId collectorcommissioncalculationsubdetailId)
    {
        CollectorCommissionCalculationSubDetailId = collectorcommissioncalculationsubdetailId;
    }
}

public sealed class CollectorCommissionCalculationSubDetailDeletedEvent : DomainEvent
{
    public CollectorCommissionCalculationSubDetailId CollectorCommissionCalculationSubDetailId { get; }

    public CollectorCommissionCalculationSubDetailDeletedEvent(CollectorCommissionCalculationSubDetailId collectorcommissioncalculationsubdetailId)
    {
        CollectorCommissionCalculationSubDetailId = collectorcommissioncalculationsubdetailId;
    }
}
}
