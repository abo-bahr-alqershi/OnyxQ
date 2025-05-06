using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to PeriodExchangeRateDay entity
/// </summary>
public sealed class PeriodExchangeRateDayCreatedEvent : DomainEvent
{
    public PeriodExchangeRateDayId PeriodExchangeRateDayId { get; }

    public PeriodExchangeRateDayCreatedEvent(PeriodExchangeRateDayId periodexchangeratedayId)
    {
        PeriodExchangeRateDayId = periodexchangeratedayId;
    }
}

public sealed class PeriodExchangeRateDayUpdatedEvent : DomainEvent
{
    public PeriodExchangeRateDayId PeriodExchangeRateDayId { get; }

    public PeriodExchangeRateDayUpdatedEvent(PeriodExchangeRateDayId periodexchangeratedayId)
    {
        PeriodExchangeRateDayId = periodexchangeratedayId;
    }
}

public sealed class PeriodExchangeRateDayDeletedEvent : DomainEvent
{
    public PeriodExchangeRateDayId PeriodExchangeRateDayId { get; }

    public PeriodExchangeRateDayDeletedEvent(PeriodExchangeRateDayId periodexchangeratedayId)
    {
        PeriodExchangeRateDayId = periodexchangeratedayId;
    }
}
}
