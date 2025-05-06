using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxItemMovement entity
/// </summary>
public sealed class TaxItemMovementCreatedEvent : DomainEvent
{
    public TaxItemMovementId TaxItemMovementId { get; }

    public TaxItemMovementCreatedEvent(TaxItemMovementId taxitemmovementId)
    {
        TaxItemMovementId = taxitemmovementId;
    }
}

public sealed class TaxItemMovementUpdatedEvent : DomainEvent
{
    public TaxItemMovementId TaxItemMovementId { get; }

    public TaxItemMovementUpdatedEvent(TaxItemMovementId taxitemmovementId)
    {
        TaxItemMovementId = taxitemmovementId;
    }
}

public sealed class TaxItemMovementDeletedEvent : DomainEvent
{
    public TaxItemMovementId TaxItemMovementId { get; }

    public TaxItemMovementDeletedEvent(TaxItemMovementId taxitemmovementId)
    {
        TaxItemMovementId = taxitemmovementId;
    }
}
}
