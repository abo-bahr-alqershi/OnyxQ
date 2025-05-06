using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptNote entity
/// </summary>
public sealed class GoodsReceiptNoteCreatedEvent : DomainEvent
{
    public GoodsReceiptNoteId GoodsReceiptNoteId { get; }

    public GoodsReceiptNoteCreatedEvent(GoodsReceiptNoteId goodsreceiptnoteId)
    {
        GoodsReceiptNoteId = goodsreceiptnoteId;
    }
}

public sealed class GoodsReceiptNoteUpdatedEvent : DomainEvent
{
    public GoodsReceiptNoteId GoodsReceiptNoteId { get; }

    public GoodsReceiptNoteUpdatedEvent(GoodsReceiptNoteId goodsreceiptnoteId)
    {
        GoodsReceiptNoteId = goodsreceiptnoteId;
    }
}

public sealed class GoodsReceiptNoteDeletedEvent : DomainEvent
{
    public GoodsReceiptNoteId GoodsReceiptNoteId { get; }

    public GoodsReceiptNoteDeletedEvent(GoodsReceiptNoteId goodsreceiptnoteId)
    {
        GoodsReceiptNoteId = goodsreceiptnoteId;
    }
}
}
