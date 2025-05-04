using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AssociationTransaction entity
/// </summary>
public sealed class AssociationTransactionCreatedEvent : DomainEvent
{
    public AssociationTransactionId AssociationTransactionId { get; }

    public AssociationTransactionCreatedEvent(AssociationTransactionId associationtransactionId)
    {
        AssociationTransactionId = associationtransactionId;
    }
}

public sealed class AssociationTransactionUpdatedEvent : DomainEvent
{
    public AssociationTransactionId AssociationTransactionId { get; }

    public AssociationTransactionUpdatedEvent(AssociationTransactionId associationtransactionId)
    {
        AssociationTransactionId = associationtransactionId;
    }
}

public sealed class AssociationTransactionDeletedEvent : DomainEvent
{
    public AssociationTransactionId AssociationTransactionId { get; }

    public AssociationTransactionDeletedEvent(AssociationTransactionId associationtransactionId)
    {
        AssociationTransactionId = associationtransactionId;
    }
}
}
