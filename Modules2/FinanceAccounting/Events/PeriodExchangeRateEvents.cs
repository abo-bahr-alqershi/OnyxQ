using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to PeriodExchangeRate entity
/// </summary>
public sealed class PeriodExchangeRateCreatedEvent : DomainEvent
{
    public PeriodExchangeRateId PeriodExchangeRateId { get; }

    public PeriodExchangeRateCreatedEvent(PeriodExchangeRateId periodexchangerateId)
    {
        PeriodExchangeRateId = periodexchangerateId;
    }
}

public sealed class PeriodExchangeRateUpdatedEvent : DomainEvent
{
    public PeriodExchangeRateId PeriodExchangeRateId { get; }

    public PeriodExchangeRateUpdatedEvent(PeriodExchangeRateId periodexchangerateId)
    {
        PeriodExchangeRateId = periodexchangerateId;
    }
}

public sealed class PeriodExchangeRateDeletedEvent : DomainEvent
{
    public PeriodExchangeRateId PeriodExchangeRateId { get; }

    public PeriodExchangeRateDeletedEvent(PeriodExchangeRateId periodexchangerateId)
    {
        PeriodExchangeRateId = periodexchangerateId;
    }
}
}
