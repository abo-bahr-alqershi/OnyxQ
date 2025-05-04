using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CardSaleDiscountType entity
/// </summary>
public sealed class CardSaleDiscountTypeCreatedEvent : DomainEvent
{
    public CardSaleDiscountTypeId CardSaleDiscountTypeId { get; }

    public CardSaleDiscountTypeCreatedEvent(CardSaleDiscountTypeId cardsalediscounttypeId)
    {
        CardSaleDiscountTypeId = cardsalediscounttypeId;
    }
}

public sealed class CardSaleDiscountTypeUpdatedEvent : DomainEvent
{
    public CardSaleDiscountTypeId CardSaleDiscountTypeId { get; }

    public CardSaleDiscountTypeUpdatedEvent(CardSaleDiscountTypeId cardsalediscounttypeId)
    {
        CardSaleDiscountTypeId = cardsalediscounttypeId;
    }
}

public sealed class CardSaleDiscountTypeDeletedEvent : DomainEvent
{
    public CardSaleDiscountTypeId CardSaleDiscountTypeId { get; }

    public CardSaleDiscountTypeDeletedEvent(CardSaleDiscountTypeId cardsalediscounttypeId)
    {
        CardSaleDiscountTypeId = cardsalediscounttypeId;
    }
}
}
