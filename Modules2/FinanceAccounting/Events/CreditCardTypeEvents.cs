using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CreditCardType entity
/// </summary>
public sealed class CreditCardTypeCreatedEvent : DomainEvent
{
    public CreditCardTypeId CreditCardTypeId { get; }

    public CreditCardTypeCreatedEvent(CreditCardTypeId creditcardtypeId)
    {
        CreditCardTypeId = creditcardtypeId;
    }
}

public sealed class CreditCardTypeUpdatedEvent : DomainEvent
{
    public CreditCardTypeId CreditCardTypeId { get; }

    public CreditCardTypeUpdatedEvent(CreditCardTypeId creditcardtypeId)
    {
        CreditCardTypeId = creditcardtypeId;
    }
}

public sealed class CreditCardTypeDeletedEvent : DomainEvent
{
    public CreditCardTypeId CreditCardTypeId { get; }

    public CreditCardTypeDeletedEvent(CreditCardTypeId creditcardtypeId)
    {
        CreditCardTypeId = creditcardtypeId;
    }
}
}
