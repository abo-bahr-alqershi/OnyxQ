using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CurrencyDifferenceTemp entity
/// </summary>
public sealed class CurrencyDifferenceTempCreatedEvent : DomainEvent
{
    public CurrencyDifferenceTempId CurrencyDifferenceTempId { get; }

    public CurrencyDifferenceTempCreatedEvent(CurrencyDifferenceTempId currencydifferencetempId)
    {
        CurrencyDifferenceTempId = currencydifferencetempId;
    }
}

public sealed class CurrencyDifferenceTempUpdatedEvent : DomainEvent
{
    public CurrencyDifferenceTempId CurrencyDifferenceTempId { get; }

    public CurrencyDifferenceTempUpdatedEvent(CurrencyDifferenceTempId currencydifferencetempId)
    {
        CurrencyDifferenceTempId = currencydifferencetempId;
    }
}

public sealed class CurrencyDifferenceTempDeletedEvent : DomainEvent
{
    public CurrencyDifferenceTempId CurrencyDifferenceTempId { get; }

    public CurrencyDifferenceTempDeletedEvent(CurrencyDifferenceTempId currencydifferencetempId)
    {
        CurrencyDifferenceTempId = currencydifferencetempId;
    }
}
}
