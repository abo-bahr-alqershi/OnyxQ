using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestExchangeCurrencyMaster entity
/// </summary>
public sealed class GeneralLedgerRequestExchangeCurrencyMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyMasterId GeneralLedgerRequestExchangeCurrencyMasterId { get; }

    public GeneralLedgerRequestExchangeCurrencyMasterCreatedEvent(GeneralLedgerRequestExchangeCurrencyMasterId generalledgerrequestexchangecurrencymasterId)
    {
        GeneralLedgerRequestExchangeCurrencyMasterId = generalledgerrequestexchangecurrencymasterId;
    }
}

public sealed class GeneralLedgerRequestExchangeCurrencyMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyMasterId GeneralLedgerRequestExchangeCurrencyMasterId { get; }

    public GeneralLedgerRequestExchangeCurrencyMasterUpdatedEvent(GeneralLedgerRequestExchangeCurrencyMasterId generalledgerrequestexchangecurrencymasterId)
    {
        GeneralLedgerRequestExchangeCurrencyMasterId = generalledgerrequestexchangecurrencymasterId;
    }
}

public sealed class GeneralLedgerRequestExchangeCurrencyMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyMasterId GeneralLedgerRequestExchangeCurrencyMasterId { get; }

    public GeneralLedgerRequestExchangeCurrencyMasterDeletedEvent(GeneralLedgerRequestExchangeCurrencyMasterId generalledgerrequestexchangecurrencymasterId)
    {
        GeneralLedgerRequestExchangeCurrencyMasterId = generalledgerrequestexchangecurrencymasterId;
    }
}
}
