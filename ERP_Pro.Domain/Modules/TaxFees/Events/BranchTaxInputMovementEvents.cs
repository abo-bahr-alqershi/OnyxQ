using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to BranchTaxInputMovement entity
/// </summary>
public sealed class BranchTaxInputMovementCreatedEvent : DomainEvent
{
    public BranchTaxInputMovementId BranchTaxInputMovementId { get; }

    public BranchTaxInputMovementCreatedEvent(BranchTaxInputMovementId branchtaxinputmovementId)
    {
        BranchTaxInputMovementId = branchtaxinputmovementId;
    }
}

public sealed class BranchTaxInputMovementUpdatedEvent : DomainEvent
{
    public BranchTaxInputMovementId BranchTaxInputMovementId { get; }

    public BranchTaxInputMovementUpdatedEvent(BranchTaxInputMovementId branchtaxinputmovementId)
    {
        BranchTaxInputMovementId = branchtaxinputmovementId;
    }
}

public sealed class BranchTaxInputMovementDeletedEvent : DomainEvent
{
    public BranchTaxInputMovementId BranchTaxInputMovementId { get; }

    public BranchTaxInputMovementDeletedEvent(BranchTaxInputMovementId branchtaxinputmovementId)
    {
        BranchTaxInputMovementId = branchtaxinputmovementId;
    }
}
}
