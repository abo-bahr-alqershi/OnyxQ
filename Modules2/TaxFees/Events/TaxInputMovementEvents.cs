using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to TaxInputMovement entity
/// </summary>
public sealed class TaxInputMovementCreatedEvent : DomainEvent
{
    public TaxInputMovementId TaxInputMovementId { get; }

    public TaxInputMovementCreatedEvent(TaxInputMovementId taxinputmovementId)
    {
        TaxInputMovementId = taxinputmovementId;
    }
}

public sealed class TaxInputMovementUpdatedEvent : DomainEvent
{
    public TaxInputMovementId TaxInputMovementId { get; }

    public TaxInputMovementUpdatedEvent(TaxInputMovementId taxinputmovementId)
    {
        TaxInputMovementId = taxinputmovementId;
    }
}

public sealed class TaxInputMovementDeletedEvent : DomainEvent
{
    public TaxInputMovementId TaxInputMovementId { get; }

    public TaxInputMovementDeletedEvent(TaxInputMovementId taxinputmovementId)
    {
        TaxInputMovementId = taxinputmovementId;
    }
}
}
