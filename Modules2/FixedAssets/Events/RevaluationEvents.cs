using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FixedAssets.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Events
{
/// <summary>
/// Events related to Revaluation entity
/// </summary>
public sealed class RevaluationCreatedEvent : DomainEvent
{
    public RevaluationId RevaluationId { get; }

    public RevaluationCreatedEvent(RevaluationId revaluationId)
    {
        RevaluationId = revaluationId;
    }
}

public sealed class RevaluationUpdatedEvent : DomainEvent
{
    public RevaluationId RevaluationId { get; }

    public RevaluationUpdatedEvent(RevaluationId revaluationId)
    {
        RevaluationId = revaluationId;
    }
}

public sealed class RevaluationDeletedEvent : DomainEvent
{
    public RevaluationId RevaluationId { get; }

    public RevaluationDeletedEvent(RevaluationId revaluationId)
    {
        RevaluationId = revaluationId;
    }
}
}
