using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptNoteTypes entity
/// </summary>
public sealed class GoodsReceiptNoteTypesCreatedEvent : DomainEvent
{
    public GoodsReceiptNoteTypesId GoodsReceiptNoteTypesId { get; }

    public GoodsReceiptNoteTypesCreatedEvent(GoodsReceiptNoteTypesId goodsreceiptnotetypesId)
    {
        GoodsReceiptNoteTypesId = goodsreceiptnotetypesId;
    }
}

public sealed class GoodsReceiptNoteTypesUpdatedEvent : DomainEvent
{
    public GoodsReceiptNoteTypesId GoodsReceiptNoteTypesId { get; }

    public GoodsReceiptNoteTypesUpdatedEvent(GoodsReceiptNoteTypesId goodsreceiptnotetypesId)
    {
        GoodsReceiptNoteTypesId = goodsreceiptnotetypesId;
    }
}

public sealed class GoodsReceiptNoteTypesDeletedEvent : DomainEvent
{
    public GoodsReceiptNoteTypesId GoodsReceiptNoteTypesId { get; }

    public GoodsReceiptNoteTypesDeletedEvent(GoodsReceiptNoteTypesId goodsreceiptnotetypesId)
    {
        GoodsReceiptNoteTypesId = goodsreceiptnotetypesId;
    }
}
}
