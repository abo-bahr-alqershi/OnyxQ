using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to BranchRequestTaxItemMovement entity
/// </summary>
public sealed class BranchRequestTaxItemMovementCreatedEvent : DomainEvent
{
    public BranchRequestTaxItemMovementId BranchRequestTaxItemMovementId { get; }

    public BranchRequestTaxItemMovementCreatedEvent(BranchRequestTaxItemMovementId branchrequesttaxitemmovementId)
    {
        BranchRequestTaxItemMovementId = branchrequesttaxitemmovementId;
    }
}

public sealed class BranchRequestTaxItemMovementUpdatedEvent : DomainEvent
{
    public BranchRequestTaxItemMovementId BranchRequestTaxItemMovementId { get; }

    public BranchRequestTaxItemMovementUpdatedEvent(BranchRequestTaxItemMovementId branchrequesttaxitemmovementId)
    {
        BranchRequestTaxItemMovementId = branchrequesttaxitemmovementId;
    }
}

public sealed class BranchRequestTaxItemMovementDeletedEvent : DomainEvent
{
    public BranchRequestTaxItemMovementId BranchRequestTaxItemMovementId { get; }

    public BranchRequestTaxItemMovementDeletedEvent(BranchRequestTaxItemMovementId branchrequesttaxitemmovementId)
    {
        BranchRequestTaxItemMovementId = branchrequesttaxitemmovementId;
    }
}
}
