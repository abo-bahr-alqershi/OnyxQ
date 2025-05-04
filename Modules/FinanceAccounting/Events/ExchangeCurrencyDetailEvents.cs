using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ExchangeCurrencyDetail entity
/// </summary>
public sealed class ExchangeCurrencyDetailCreatedEvent : DomainEvent
{
    public ExchangeCurrencyDetailId ExchangeCurrencyDetailId { get; }

    public ExchangeCurrencyDetailCreatedEvent(ExchangeCurrencyDetailId exchangecurrencydetailId)
    {
        ExchangeCurrencyDetailId = exchangecurrencydetailId;
    }
}

public sealed class ExchangeCurrencyDetailUpdatedEvent : DomainEvent
{
    public ExchangeCurrencyDetailId ExchangeCurrencyDetailId { get; }

    public ExchangeCurrencyDetailUpdatedEvent(ExchangeCurrencyDetailId exchangecurrencydetailId)
    {
        ExchangeCurrencyDetailId = exchangecurrencydetailId;
    }
}

public sealed class ExchangeCurrencyDetailDeletedEvent : DomainEvent
{
    public ExchangeCurrencyDetailId ExchangeCurrencyDetailId { get; }

    public ExchangeCurrencyDetailDeletedEvent(ExchangeCurrencyDetailId exchangecurrencydetailId)
    {
        ExchangeCurrencyDetailId = exchangecurrencydetailId;
    }
}
}
