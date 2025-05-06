using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to CompensationQuantityCalculationDetail entity
/// </summary>
public sealed class CompensationQuantityCalculationDetailCreatedEvent : DomainEvent
{
    public CompensationQuantityCalculationDetailId CompensationQuantityCalculationDetailId { get; }

    public CompensationQuantityCalculationDetailCreatedEvent(CompensationQuantityCalculationDetailId compensationquantitycalculationdetailId)
    {
        CompensationQuantityCalculationDetailId = compensationquantitycalculationdetailId;
    }
}

public sealed class CompensationQuantityCalculationDetailUpdatedEvent : DomainEvent
{
    public CompensationQuantityCalculationDetailId CompensationQuantityCalculationDetailId { get; }

    public CompensationQuantityCalculationDetailUpdatedEvent(CompensationQuantityCalculationDetailId compensationquantitycalculationdetailId)
    {
        CompensationQuantityCalculationDetailId = compensationquantitycalculationdetailId;
    }
}

public sealed class CompensationQuantityCalculationDetailDeletedEvent : DomainEvent
{
    public CompensationQuantityCalculationDetailId CompensationQuantityCalculationDetailId { get; }

    public CompensationQuantityCalculationDetailDeletedEvent(CompensationQuantityCalculationDetailId compensationquantitycalculationdetailId)
    {
        CompensationQuantityCalculationDetailId = compensationquantitycalculationdetailId;
    }
}
}
