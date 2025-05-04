using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FixedAssets.Events
{
/// <summary>
/// Events related to Reevaluate entity
/// </summary>
public sealed class ReevaluateCreatedEvent : DomainEvent
{
    public ReevaluateId ReevaluateId { get; }

    public ReevaluateCreatedEvent(ReevaluateId reevaluateId)
    {
        ReevaluateId = reevaluateId;
    }
}

public sealed class ReevaluateUpdatedEvent : DomainEvent
{
    public ReevaluateId ReevaluateId { get; }

    public ReevaluateUpdatedEvent(ReevaluateId reevaluateId)
    {
        ReevaluateId = reevaluateId;
    }
}

public sealed class ReevaluateDeletedEvent : DomainEvent
{
    public ReevaluateId ReevaluateId { get; }

    public ReevaluateDeletedEvent(ReevaluateId reevaluateId)
    {
        ReevaluateId = reevaluateId;
    }
}
}
