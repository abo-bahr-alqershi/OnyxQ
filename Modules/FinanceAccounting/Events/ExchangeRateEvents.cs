using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ExchangeRate entity
/// </summary>
public sealed class ExchangeRateCreatedEvent : DomainEvent
{
    public ExchangeRateId ExchangeRateId { get; }

    public ExchangeRateCreatedEvent(ExchangeRateId exchangerateId)
    {
        ExchangeRateId = exchangerateId;
    }
}

public sealed class ExchangeRateUpdatedEvent : DomainEvent
{
    public ExchangeRateId ExchangeRateId { get; }

    public ExchangeRateUpdatedEvent(ExchangeRateId exchangerateId)
    {
        ExchangeRateId = exchangerateId;
    }
}

public sealed class ExchangeRateDeletedEvent : DomainEvent
{
    public ExchangeRateId ExchangeRateId { get; }

    public ExchangeRateDeletedEvent(ExchangeRateId exchangerateId)
    {
        ExchangeRateId = exchangerateId;
    }
}
}
