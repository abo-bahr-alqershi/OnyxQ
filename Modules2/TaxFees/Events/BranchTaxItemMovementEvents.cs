using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to BranchTaxItemMovement entity
/// </summary>
public sealed class BranchTaxItemMovementCreatedEvent : DomainEvent
{
    public BranchTaxItemMovementId BranchTaxItemMovementId { get; }

    public BranchTaxItemMovementCreatedEvent(BranchTaxItemMovementId branchtaxitemmovementId)
    {
        BranchTaxItemMovementId = branchtaxitemmovementId;
    }
}

public sealed class BranchTaxItemMovementUpdatedEvent : DomainEvent
{
    public BranchTaxItemMovementId BranchTaxItemMovementId { get; }

    public BranchTaxItemMovementUpdatedEvent(BranchTaxItemMovementId branchtaxitemmovementId)
    {
        BranchTaxItemMovementId = branchtaxitemmovementId;
    }
}

public sealed class BranchTaxItemMovementDeletedEvent : DomainEvent
{
    public BranchTaxItemMovementId BranchTaxItemMovementId { get; }

    public BranchTaxItemMovementDeletedEvent(BranchTaxItemMovementId branchtaxitemmovementId)
    {
        BranchTaxItemMovementId = branchtaxitemmovementId;
    }
}
}
