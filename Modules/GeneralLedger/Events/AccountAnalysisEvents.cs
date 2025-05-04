using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to AccountAnalysis entity
/// </summary>
public sealed class AccountAnalysisCreatedEvent : DomainEvent
{
    public AccountAnalysisId AccountAnalysisId { get; }

    public AccountAnalysisCreatedEvent(AccountAnalysisId accountanalysisId)
    {
        AccountAnalysisId = accountanalysisId;
    }
}

public sealed class AccountAnalysisUpdatedEvent : DomainEvent
{
    public AccountAnalysisId AccountAnalysisId { get; }

    public AccountAnalysisUpdatedEvent(AccountAnalysisId accountanalysisId)
    {
        AccountAnalysisId = accountanalysisId;
    }
}

public sealed class AccountAnalysisDeletedEvent : DomainEvent
{
    public AccountAnalysisId AccountAnalysisId { get; }

    public AccountAnalysisDeletedEvent(AccountAnalysisId accountanalysisId)
    {
        AccountAnalysisId = accountanalysisId;
    }
}
}
