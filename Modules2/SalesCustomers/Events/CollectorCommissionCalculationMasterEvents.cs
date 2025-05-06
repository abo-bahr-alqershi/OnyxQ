using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CollectorCommissionCalculationMaster entity
/// </summary>
public sealed class CollectorCommissionCalculationMasterCreatedEvent : DomainEvent
{
    public CollectorCommissionCalculationMasterId CollectorCommissionCalculationMasterId { get; }

    public CollectorCommissionCalculationMasterCreatedEvent(CollectorCommissionCalculationMasterId collectorcommissioncalculationmasterId)
    {
        CollectorCommissionCalculationMasterId = collectorcommissioncalculationmasterId;
    }
}

public sealed class CollectorCommissionCalculationMasterUpdatedEvent : DomainEvent
{
    public CollectorCommissionCalculationMasterId CollectorCommissionCalculationMasterId { get; }

    public CollectorCommissionCalculationMasterUpdatedEvent(CollectorCommissionCalculationMasterId collectorcommissioncalculationmasterId)
    {
        CollectorCommissionCalculationMasterId = collectorcommissioncalculationmasterId;
    }
}

public sealed class CollectorCommissionCalculationMasterDeletedEvent : DomainEvent
{
    public CollectorCommissionCalculationMasterId CollectorCommissionCalculationMasterId { get; }

    public CollectorCommissionCalculationMasterDeletedEvent(CollectorCommissionCalculationMasterId collectorcommissioncalculationmasterId)
    {
        CollectorCommissionCalculationMasterId = collectorcommissioncalculationmasterId;
    }
}
}
