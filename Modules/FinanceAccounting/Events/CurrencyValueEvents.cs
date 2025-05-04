using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CurrencyValue entity
/// </summary>
public sealed class CurrencyValueCreatedEvent : DomainEvent
{
    public CurrencyValueId CurrencyValueId { get; }

    public CurrencyValueCreatedEvent(CurrencyValueId currencyvalueId)
    {
        CurrencyValueId = currencyvalueId;
    }
}

public sealed class CurrencyValueUpdatedEvent : DomainEvent
{
    public CurrencyValueId CurrencyValueId { get; }

    public CurrencyValueUpdatedEvent(CurrencyValueId currencyvalueId)
    {
        CurrencyValueId = currencyvalueId;
    }
}

public sealed class CurrencyValueDeletedEvent : DomainEvent
{
    public CurrencyValueId CurrencyValueId { get; }

    public CurrencyValueDeletedEvent(CurrencyValueId currencyvalueId)
    {
        CurrencyValueId = currencyvalueId;
    }
}
}
