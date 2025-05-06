using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to AssociationAccount entity
/// </summary>
public sealed class AssociationAccountCreatedEvent : DomainEvent
{
    public AssociationAccountId AssociationAccountId { get; }

    public AssociationAccountCreatedEvent(AssociationAccountId associationaccountId)
    {
        AssociationAccountId = associationaccountId;
    }
}

public sealed class AssociationAccountUpdatedEvent : DomainEvent
{
    public AssociationAccountId AssociationAccountId { get; }

    public AssociationAccountUpdatedEvent(AssociationAccountId associationaccountId)
    {
        AssociationAccountId = associationaccountId;
    }
}

public sealed class AssociationAccountDeletedEvent : DomainEvent
{
    public AssociationAccountId AssociationAccountId { get; }

    public AssociationAccountDeletedEvent(AssociationAccountId associationaccountId)
    {
        AssociationAccountId = associationaccountId;
    }
}
}
