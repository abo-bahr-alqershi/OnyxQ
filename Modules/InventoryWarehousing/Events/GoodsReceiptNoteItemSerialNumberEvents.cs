using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptNoteItemSerialNumber entity
/// </summary>
public sealed class GoodsReceiptNoteItemSerialNumberCreatedEvent : DomainEvent
{
    public GoodsReceiptNoteItemSerialNumberId GoodsReceiptNoteItemSerialNumberId { get; }

    public GoodsReceiptNoteItemSerialNumberCreatedEvent(GoodsReceiptNoteItemSerialNumberId goodsreceiptnoteitemserialnumberId)
    {
        GoodsReceiptNoteItemSerialNumberId = goodsreceiptnoteitemserialnumberId;
    }
}

public sealed class GoodsReceiptNoteItemSerialNumberUpdatedEvent : DomainEvent
{
    public GoodsReceiptNoteItemSerialNumberId GoodsReceiptNoteItemSerialNumberId { get; }

    public GoodsReceiptNoteItemSerialNumberUpdatedEvent(GoodsReceiptNoteItemSerialNumberId goodsreceiptnoteitemserialnumberId)
    {
        GoodsReceiptNoteItemSerialNumberId = goodsreceiptnoteitemserialnumberId;
    }
}

public sealed class GoodsReceiptNoteItemSerialNumberDeletedEvent : DomainEvent
{
    public GoodsReceiptNoteItemSerialNumberId GoodsReceiptNoteItemSerialNumberId { get; }

    public GoodsReceiptNoteItemSerialNumberDeletedEvent(GoodsReceiptNoteItemSerialNumberId goodsreceiptnoteitemserialnumberId)
    {
        GoodsReceiptNoteItemSerialNumberId = goodsreceiptnoteitemserialnumberId;
    }
}
}
