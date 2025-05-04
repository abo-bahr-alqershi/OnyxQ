using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestCompensationQuantityCalculationDetail entity
/// </summary>
public sealed class RequestCompensationQuantityCalculationDetailCreatedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationDetailId RequestCompensationQuantityCalculationDetailId { get; }

    public RequestCompensationQuantityCalculationDetailCreatedEvent(RequestCompensationQuantityCalculationDetailId requestcompensationquantitycalculationdetailId)
    {
        RequestCompensationQuantityCalculationDetailId = requestcompensationquantitycalculationdetailId;
    }
}

public sealed class RequestCompensationQuantityCalculationDetailUpdatedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationDetailId RequestCompensationQuantityCalculationDetailId { get; }

    public RequestCompensationQuantityCalculationDetailUpdatedEvent(RequestCompensationQuantityCalculationDetailId requestcompensationquantitycalculationdetailId)
    {
        RequestCompensationQuantityCalculationDetailId = requestcompensationquantitycalculationdetailId;
    }
}

public sealed class RequestCompensationQuantityCalculationDetailDeletedEvent : DomainEvent
{
    public RequestCompensationQuantityCalculationDetailId RequestCompensationQuantityCalculationDetailId { get; }

    public RequestCompensationQuantityCalculationDetailDeletedEvent(RequestCompensationQuantityCalculationDetailId requestcompensationquantitycalculationdetailId)
    {
        RequestCompensationQuantityCalculationDetailId = requestcompensationquantitycalculationdetailId;
    }
}
}
