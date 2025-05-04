using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectorCommissionCalculationDetail entity
/// </summary>
public sealed class CollectorCommissionCalculationDetailCreatedEvent : DomainEvent
{
    public CollectorCommissionCalculationDetailId CollectorCommissionCalculationDetailId { get; }

    public CollectorCommissionCalculationDetailCreatedEvent(CollectorCommissionCalculationDetailId collectorcommissioncalculationdetailId)
    {
        CollectorCommissionCalculationDetailId = collectorcommissioncalculationdetailId;
    }
}

public sealed class CollectorCommissionCalculationDetailUpdatedEvent : DomainEvent
{
    public CollectorCommissionCalculationDetailId CollectorCommissionCalculationDetailId { get; }

    public CollectorCommissionCalculationDetailUpdatedEvent(CollectorCommissionCalculationDetailId collectorcommissioncalculationdetailId)
    {
        CollectorCommissionCalculationDetailId = collectorcommissioncalculationdetailId;
    }
}

public sealed class CollectorCommissionCalculationDetailDeletedEvent : DomainEvent
{
    public CollectorCommissionCalculationDetailId CollectorCommissionCalculationDetailId { get; }

    public CollectorCommissionCalculationDetailDeletedEvent(CollectorCommissionCalculationDetailId collectorcommissioncalculationdetailId)
    {
        CollectorCommissionCalculationDetailId = collectorcommissioncalculationdetailId;
    }
}
}
