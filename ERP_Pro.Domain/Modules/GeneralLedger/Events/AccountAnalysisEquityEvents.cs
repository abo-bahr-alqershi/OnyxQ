using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountAnalysisEquity entity
/// </summary>
public sealed class AccountAnalysisEquityCreatedEvent : DomainEvent
{
    public AccountAnalysisEquityId AccountAnalysisEquityId { get; }

    public AccountAnalysisEquityCreatedEvent(AccountAnalysisEquityId accountanalysisequityId)
    {
        AccountAnalysisEquityId = accountanalysisequityId;
    }
}

public sealed class AccountAnalysisEquityUpdatedEvent : DomainEvent
{
    public AccountAnalysisEquityId AccountAnalysisEquityId { get; }

    public AccountAnalysisEquityUpdatedEvent(AccountAnalysisEquityId accountanalysisequityId)
    {
        AccountAnalysisEquityId = accountanalysisequityId;
    }
}

public sealed class AccountAnalysisEquityDeletedEvent : DomainEvent
{
    public AccountAnalysisEquityId AccountAnalysisEquityId { get; }

    public AccountAnalysisEquityDeletedEvent(AccountAnalysisEquityId accountanalysisequityId)
    {
        AccountAnalysisEquityId = accountanalysisequityId;
    }
}
}
