using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestExchangeCurrencyDetail entity
/// </summary>
public sealed class GeneralLedgerRequestExchangeCurrencyDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyDetailId GeneralLedgerRequestExchangeCurrencyDetailId { get; }

    public GeneralLedgerRequestExchangeCurrencyDetailCreatedEvent(GeneralLedgerRequestExchangeCurrencyDetailId generalledgerrequestexchangecurrencydetailId)
    {
        GeneralLedgerRequestExchangeCurrencyDetailId = generalledgerrequestexchangecurrencydetailId;
    }
}

public sealed class GeneralLedgerRequestExchangeCurrencyDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyDetailId GeneralLedgerRequestExchangeCurrencyDetailId { get; }

    public GeneralLedgerRequestExchangeCurrencyDetailUpdatedEvent(GeneralLedgerRequestExchangeCurrencyDetailId generalledgerrequestexchangecurrencydetailId)
    {
        GeneralLedgerRequestExchangeCurrencyDetailId = generalledgerrequestexchangecurrencydetailId;
    }
}

public sealed class GeneralLedgerRequestExchangeCurrencyDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestExchangeCurrencyDetailId GeneralLedgerRequestExchangeCurrencyDetailId { get; }

    public GeneralLedgerRequestExchangeCurrencyDetailDeletedEvent(GeneralLedgerRequestExchangeCurrencyDetailId generalledgerrequestexchangecurrencydetailId)
    {
        GeneralLedgerRequestExchangeCurrencyDetailId = generalledgerrequestexchangecurrencydetailId;
    }
}
}
