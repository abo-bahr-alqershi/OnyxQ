using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to OpeningBalance entity
/// </summary>
public sealed class OpeningBalanceCreatedEvent : DomainEvent
{
    public OpeningBalanceId OpeningBalanceId { get; }

    public OpeningBalanceCreatedEvent(OpeningBalanceId openingbalanceId)
    {
        OpeningBalanceId = openingbalanceId;
    }
}

public sealed class OpeningBalanceUpdatedEvent : DomainEvent
{
    public OpeningBalanceId OpeningBalanceId { get; }

    public OpeningBalanceUpdatedEvent(OpeningBalanceId openingbalanceId)
    {
        OpeningBalanceId = openingbalanceId;
    }
}

public sealed class OpeningBalanceDeletedEvent : DomainEvent
{
    public OpeningBalanceId OpeningBalanceId { get; }

    public OpeningBalanceDeletedEvent(OpeningBalanceId openingbalanceId)
    {
        OpeningBalanceId = openingbalanceId;
    }
}
}
