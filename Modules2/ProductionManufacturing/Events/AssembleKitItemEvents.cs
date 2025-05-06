using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to AssembleKitItem entity
/// </summary>
public sealed class AssembleKitItemCreatedEvent : DomainEvent
{
    public AssembleKitItemId AssembleKitItemId { get; }

    public AssembleKitItemCreatedEvent(AssembleKitItemId assemblekititemId)
    {
        AssembleKitItemId = assemblekititemId;
    }
}

public sealed class AssembleKitItemUpdatedEvent : DomainEvent
{
    public AssembleKitItemId AssembleKitItemId { get; }

    public AssembleKitItemUpdatedEvent(AssembleKitItemId assemblekititemId)
    {
        AssembleKitItemId = assemblekititemId;
    }
}

public sealed class AssembleKitItemDeletedEvent : DomainEvent
{
    public AssembleKitItemId AssembleKitItemId { get; }

    public AssembleKitItemDeletedEvent(AssembleKitItemId assemblekititemId)
    {
        AssembleKitItemId = assemblekititemId;
    }
}
}
