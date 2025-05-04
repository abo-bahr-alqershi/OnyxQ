using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptNoteDetail entity
/// </summary>
public sealed class GoodsReceiptNoteDetailCreatedEvent : DomainEvent
{
    public GoodsReceiptNoteDetailId GoodsReceiptNoteDetailId { get; }

    public GoodsReceiptNoteDetailCreatedEvent(GoodsReceiptNoteDetailId goodsreceiptnotedetailId)
    {
        GoodsReceiptNoteDetailId = goodsreceiptnotedetailId;
    }
}

public sealed class GoodsReceiptNoteDetailUpdatedEvent : DomainEvent
{
    public GoodsReceiptNoteDetailId GoodsReceiptNoteDetailId { get; }

    public GoodsReceiptNoteDetailUpdatedEvent(GoodsReceiptNoteDetailId goodsreceiptnotedetailId)
    {
        GoodsReceiptNoteDetailId = goodsreceiptnotedetailId;
    }
}

public sealed class GoodsReceiptNoteDetailDeletedEvent : DomainEvent
{
    public GoodsReceiptNoteDetailId GoodsReceiptNoteDetailId { get; }

    public GoodsReceiptNoteDetailDeletedEvent(GoodsReceiptNoteDetailId goodsreceiptnotedetailId)
    {
        GoodsReceiptNoteDetailId = goodsreceiptnotedetailId;
    }
}
}
