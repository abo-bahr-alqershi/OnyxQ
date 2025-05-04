using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BinDetail entity
/// </summary>
public sealed class BinDetailCreatedEvent : DomainEvent
{
    public BinDetailId BinDetailId { get; }

    public BinDetailCreatedEvent(BinDetailId bindetailId)
    {
        BinDetailId = bindetailId;
    }
}

public sealed class BinDetailUpdatedEvent : DomainEvent
{
    public BinDetailId BinDetailId { get; }

    public BinDetailUpdatedEvent(BinDetailId bindetailId)
    {
        BinDetailId = bindetailId;
    }
}

public sealed class BinDetailDeletedEvent : DomainEvent
{
    public BinDetailId BinDetailId { get; }

    public BinDetailDeletedEvent(BinDetailId bindetailId)
    {
        BinDetailId = bindetailId;
    }
}
}
