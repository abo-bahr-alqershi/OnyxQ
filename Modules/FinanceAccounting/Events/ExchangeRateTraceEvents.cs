using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ExchangeRateTrace entity
/// </summary>
public sealed class ExchangeRateTraceCreatedEvent : DomainEvent
{
    public ExchangeRateTraceId ExchangeRateTraceId { get; }

    public ExchangeRateTraceCreatedEvent(ExchangeRateTraceId exchangeratetraceId)
    {
        ExchangeRateTraceId = exchangeratetraceId;
    }
}

public sealed class ExchangeRateTraceUpdatedEvent : DomainEvent
{
    public ExchangeRateTraceId ExchangeRateTraceId { get; }

    public ExchangeRateTraceUpdatedEvent(ExchangeRateTraceId exchangeratetraceId)
    {
        ExchangeRateTraceId = exchangeratetraceId;
    }
}

public sealed class ExchangeRateTraceDeletedEvent : DomainEvent
{
    public ExchangeRateTraceId ExchangeRateTraceId { get; }

    public ExchangeRateTraceDeletedEvent(ExchangeRateTraceId exchangeratetraceId)
    {
        ExchangeRateTraceId = exchangeratetraceId;
    }
}
}
