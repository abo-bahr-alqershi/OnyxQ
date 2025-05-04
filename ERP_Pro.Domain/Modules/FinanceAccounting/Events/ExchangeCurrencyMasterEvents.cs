using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ExchangeCurrencyMaster entity
/// </summary>
public sealed class ExchangeCurrencyMasterCreatedEvent : DomainEvent
{
    public ExchangeCurrencyMasterId ExchangeCurrencyMasterId { get; }

    public ExchangeCurrencyMasterCreatedEvent(ExchangeCurrencyMasterId exchangecurrencymasterId)
    {
        ExchangeCurrencyMasterId = exchangecurrencymasterId;
    }
}

public sealed class ExchangeCurrencyMasterUpdatedEvent : DomainEvent
{
    public ExchangeCurrencyMasterId ExchangeCurrencyMasterId { get; }

    public ExchangeCurrencyMasterUpdatedEvent(ExchangeCurrencyMasterId exchangecurrencymasterId)
    {
        ExchangeCurrencyMasterId = exchangecurrencymasterId;
    }
}

public sealed class ExchangeCurrencyMasterDeletedEvent : DomainEvent
{
    public ExchangeCurrencyMasterId ExchangeCurrencyMasterId { get; }

    public ExchangeCurrencyMasterDeletedEvent(ExchangeCurrencyMasterId exchangecurrencymasterId)
    {
        ExchangeCurrencyMasterId = exchangecurrencymasterId;
    }
}
}
