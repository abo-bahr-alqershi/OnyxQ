using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestCompensationQuantityCalculationMaster entity
/// </summary>
public sealed class RequestCompensationQuantityCalculationMasterCreatedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationMasterId RequestCompensationQuantityCalculationMasterId { get; }

    public RequestCompensationQuantityCalculationMasterCreatedEvent(RequestCompensationQuantityCalculationMasterId requestcompensationquantitycalculationmasterId)
    {
        RequestCompensationQuantityCalculationMasterId = requestcompensationquantitycalculationmasterId;
    }
}

public sealed class RequestCompensationQuantityCalculationMasterUpdatedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationMasterId RequestCompensationQuantityCalculationMasterId { get; }

    public RequestCompensationQuantityCalculationMasterUpdatedEvent(RequestCompensationQuantityCalculationMasterId requestcompensationquantitycalculationmasterId)
    {
        RequestCompensationQuantityCalculationMasterId = requestcompensationquantitycalculationmasterId;
    }
}

public sealed class RequestCompensationQuantityCalculationMasterDeletedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationMasterId RequestCompensationQuantityCalculationMasterId { get; }

    public RequestCompensationQuantityCalculationMasterDeletedEvent(RequestCompensationQuantityCalculationMasterId requestcompensationquantitycalculationmasterId)
    {
        RequestCompensationQuantityCalculationMasterId = requestcompensationquantitycalculationmasterId;
    }
}
}
