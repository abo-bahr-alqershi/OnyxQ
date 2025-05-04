using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to ProfitLossClosingTemp entity
/// </summary>
public sealed class ProfitLossClosingTempCreatedEvent : DomainEvent
{
    public ProfitLossClosingTempId ProfitLossClosingTempId { get; }

    public ProfitLossClosingTempCreatedEvent(ProfitLossClosingTempId profitlossclosingtempId)
    {
        ProfitLossClosingTempId = profitlossclosingtempId;
    }
}

public sealed class ProfitLossClosingTempUpdatedEvent : DomainEvent
{
    public ProfitLossClosingTempId ProfitLossClosingTempId { get; }

    public ProfitLossClosingTempUpdatedEvent(ProfitLossClosingTempId profitlossclosingtempId)
    {
        ProfitLossClosingTempId = profitlossclosingtempId;
    }
}

public sealed class ProfitLossClosingTempDeletedEvent : DomainEvent
{
    public ProfitLossClosingTempId ProfitLossClosingTempId { get; }

    public ProfitLossClosingTempDeletedEvent(ProfitLossClosingTempId profitlossclosingtempId)
    {
        ProfitLossClosingTempId = profitlossclosingtempId;
    }
}
}
