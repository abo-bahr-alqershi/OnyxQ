using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CardSale entity
/// </summary>
public sealed class CardSaleCreatedEvent : DomainEvent
{
    public CardSaleId CardSaleId { get; }

    public CardSaleCreatedEvent(CardSaleId cardsaleId)
    {
        CardSaleId = cardsaleId;
    }
}

public sealed class CardSaleUpdatedEvent : DomainEvent
{
    public CardSaleId CardSaleId { get; }

    public CardSaleUpdatedEvent(CardSaleId cardsaleId)
    {
        CardSaleId = cardsaleId;
    }
}

public sealed class CardSaleDeletedEvent : DomainEvent
{
    public CardSaleId CardSaleId { get; }

    public CardSaleDeletedEvent(CardSaleId cardsaleId)
    {
        CardSaleId = cardsaleId;
    }
}
}
