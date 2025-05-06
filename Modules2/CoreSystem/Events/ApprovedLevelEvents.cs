using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedLevel entity
/// </summary>
public sealed class ApprovedLevelCreatedEvent : DomainEvent
{
    public ApprovedLevelId ApprovedLevelId { get; }

    public ApprovedLevelCreatedEvent(ApprovedLevelId approvedlevelId)
    {
        ApprovedLevelId = approvedlevelId;
    }
}

public sealed class ApprovedLevelUpdatedEvent : DomainEvent
{
    public ApprovedLevelId ApprovedLevelId { get; }

    public ApprovedLevelUpdatedEvent(ApprovedLevelId approvedlevelId)
    {
        ApprovedLevelId = approvedlevelId;
    }
}

public sealed class ApprovedLevelDeletedEvent : DomainEvent
{
    public ApprovedLevelId ApprovedLevelId { get; }

    public ApprovedLevelDeletedEvent(ApprovedLevelId approvedlevelId)
    {
        ApprovedLevelId = approvedlevelId;
    }
}
}
