using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to CompensationQuantityCalculationMaster entity
/// </summary>
public sealed class CompensationQuantityCalculationMasterCreatedEvent : DomainEvent
{
    public CompensationQuantityCalculationMasterId CompensationQuantityCalculationMasterId { get; }

    public CompensationQuantityCalculationMasterCreatedEvent(CompensationQuantityCalculationMasterId compensationquantitycalculationmasterId)
    {
        CompensationQuantityCalculationMasterId = compensationquantitycalculationmasterId;
    }
}

public sealed class CompensationQuantityCalculationMasterUpdatedEvent : DomainEvent
{
    public CompensationQuantityCalculationMasterId CompensationQuantityCalculationMasterId { get; }

    public CompensationQuantityCalculationMasterUpdatedEvent(CompensationQuantityCalculationMasterId compensationquantitycalculationmasterId)
    {
        CompensationQuantityCalculationMasterId = compensationquantitycalculationmasterId;
    }
}

public sealed class CompensationQuantityCalculationMasterDeletedEvent : DomainEvent
{
    public CompensationQuantityCalculationMasterId CompensationQuantityCalculationMasterId { get; }

    public CompensationQuantityCalculationMasterDeletedEvent(CompensationQuantityCalculationMasterId compensationquantitycalculationmasterId)
    {
        CompensationQuantityCalculationMasterId = compensationquantitycalculationmasterId;
    }
}
}
