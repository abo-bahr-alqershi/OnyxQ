using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to PeriodBranchClose entity
/// </summary>
public sealed class PeriodBranchCloseCreatedEvent : DomainEvent
{
    public PeriodBranchCloseId PeriodBranchCloseId { get; }

    public PeriodBranchCloseCreatedEvent(PeriodBranchCloseId periodbranchcloseId)
    {
        PeriodBranchCloseId = periodbranchcloseId;
    }
}

public sealed class PeriodBranchCloseUpdatedEvent : DomainEvent
{
    public PeriodBranchCloseId PeriodBranchCloseId { get; }

    public PeriodBranchCloseUpdatedEvent(PeriodBranchCloseId periodbranchcloseId)
    {
        PeriodBranchCloseId = periodbranchcloseId;
    }
}

public sealed class PeriodBranchCloseDeletedEvent : DomainEvent
{
    public PeriodBranchCloseId PeriodBranchCloseId { get; }

    public PeriodBranchCloseDeletedEvent(PeriodBranchCloseId periodbranchcloseId)
    {
        PeriodBranchCloseId = periodbranchcloseId;
    }
}
}
