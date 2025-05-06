using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Events
{
/// <summary>
/// Events related to AssembleKitItemDetail entity
/// </summary>
public sealed class AssembleKitItemDetailCreatedEvent : DomainEvent
{
    public AssembleKitItemDetailId AssembleKitItemDetailId { get; }

    public AssembleKitItemDetailCreatedEvent(AssembleKitItemDetailId assemblekititemdetailId)
    {
        AssembleKitItemDetailId = assemblekititemdetailId;
    }
}

public sealed class AssembleKitItemDetailUpdatedEvent : DomainEvent
{
    public AssembleKitItemDetailId AssembleKitItemDetailId { get; }

    public AssembleKitItemDetailUpdatedEvent(AssembleKitItemDetailId assemblekititemdetailId)
    {
        AssembleKitItemDetailId = assemblekititemdetailId;
    }
}

public sealed class AssembleKitItemDetailDeletedEvent : DomainEvent
{
    public AssembleKitItemDetailId AssembleKitItemDetailId { get; }

    public AssembleKitItemDetailDeletedEvent(AssembleKitItemDetailId assemblekititemdetailId)
    {
        AssembleKitItemDetailId = assemblekititemdetailId;
    }
}
}
