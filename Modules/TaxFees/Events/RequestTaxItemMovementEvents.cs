using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to RequestTaxItemMovement entity
/// </summary>
public sealed class RequestTaxItemMovementCreatedEvent : DomainEvent
{
    public RequestTaxItemMovementId RequestTaxItemMovementId { get; }

    public RequestTaxItemMovementCreatedEvent(RequestTaxItemMovementId requesttaxitemmovementId)
    {
        RequestTaxItemMovementId = requesttaxitemmovementId;
    }
}

public sealed class RequestTaxItemMovementUpdatedEvent : DomainEvent
{
    public RequestTaxItemMovementId RequestTaxItemMovementId { get; }

    public RequestTaxItemMovementUpdatedEvent(RequestTaxItemMovementId requesttaxitemmovementId)
    {
        RequestTaxItemMovementId = requesttaxitemmovementId;
    }
}

public sealed class RequestTaxItemMovementDeletedEvent : DomainEvent
{
    public RequestTaxItemMovementId RequestTaxItemMovementId { get; }

    public RequestTaxItemMovementDeletedEvent(RequestTaxItemMovementId requesttaxitemmovementId)
    {
        RequestTaxItemMovementId = requesttaxitemmovementId;
    }
}
}
