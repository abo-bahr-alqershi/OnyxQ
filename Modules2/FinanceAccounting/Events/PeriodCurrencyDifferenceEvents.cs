using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to PeriodCurrencyDifference entity
/// </summary>
public sealed class PeriodCurrencyDifferenceCreatedEvent : DomainEvent
{
    public PeriodCurrencyDifferenceId PeriodCurrencyDifferenceId { get; }

    public PeriodCurrencyDifferenceCreatedEvent(PeriodCurrencyDifferenceId periodcurrencydifferenceId)
    {
        PeriodCurrencyDifferenceId = periodcurrencydifferenceId;
    }
}

public sealed class PeriodCurrencyDifferenceUpdatedEvent : DomainEvent
{
    public PeriodCurrencyDifferenceId PeriodCurrencyDifferenceId { get; }

    public PeriodCurrencyDifferenceUpdatedEvent(PeriodCurrencyDifferenceId periodcurrencydifferenceId)
    {
        PeriodCurrencyDifferenceId = periodcurrencydifferenceId;
    }
}

public sealed class PeriodCurrencyDifferenceDeletedEvent : DomainEvent
{
    public PeriodCurrencyDifferenceId PeriodCurrencyDifferenceId { get; }

    public PeriodCurrencyDifferenceDeletedEvent(PeriodCurrencyDifferenceId periodcurrencydifferenceId)
    {
        PeriodCurrencyDifferenceId = periodcurrencydifferenceId;
    }
}
}
