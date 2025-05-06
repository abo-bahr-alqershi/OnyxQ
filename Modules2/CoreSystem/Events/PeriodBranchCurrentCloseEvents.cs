using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to PeriodBranchCurrentClose entity
/// </summary>
public sealed class PeriodBranchCurrentCloseCreatedEvent : DomainEvent
{
    public PeriodBranchCurrentCloseId PeriodBranchCurrentCloseId { get; }

    public PeriodBranchCurrentCloseCreatedEvent(PeriodBranchCurrentCloseId periodbranchcurrentcloseId)
    {
        PeriodBranchCurrentCloseId = periodbranchcurrentcloseId;
    }
}

public sealed class PeriodBranchCurrentCloseUpdatedEvent : DomainEvent
{
    public PeriodBranchCurrentCloseId PeriodBranchCurrentCloseId { get; }

    public PeriodBranchCurrentCloseUpdatedEvent(PeriodBranchCurrentCloseId periodbranchcurrentcloseId)
    {
        PeriodBranchCurrentCloseId = periodbranchcurrentcloseId;
    }
}

public sealed class PeriodBranchCurrentCloseDeletedEvent : DomainEvent
{
    public PeriodBranchCurrentCloseId PeriodBranchCurrentCloseId { get; }

    public PeriodBranchCurrentCloseDeletedEvent(PeriodBranchCurrentCloseId periodbranchcurrentcloseId)
    {
        PeriodBranchCurrentCloseId = periodbranchcurrentcloseId;
    }
}
}
