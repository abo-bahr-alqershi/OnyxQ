using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CreditCardGroup entity
/// </summary>
public sealed class CreditCardGroupCreatedEvent : DomainEvent
{
    public CreditCardGroupId CreditCardGroupId { get; }

    public CreditCardGroupCreatedEvent(CreditCardGroupId creditcardgroupId)
    {
        CreditCardGroupId = creditcardgroupId;
    }
}

public sealed class CreditCardGroupUpdatedEvent : DomainEvent
{
    public CreditCardGroupId CreditCardGroupId { get; }

    public CreditCardGroupUpdatedEvent(CreditCardGroupId creditcardgroupId)
    {
        CreditCardGroupId = creditcardgroupId;
    }
}

public sealed class CreditCardGroupDeletedEvent : DomainEvent
{
    public CreditCardGroupId CreditCardGroupId { get; }

    public CreditCardGroupDeletedEvent(CreditCardGroupId creditcardgroupId)
    {
        CreditCardGroupId = creditcardgroupId;
    }
}
}
