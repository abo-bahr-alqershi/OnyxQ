using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptDetail entity
/// </summary>
public sealed class GoodsReceiptDetailCreatedEvent : DomainEvent
{
    public GoodsReceiptDetailId GoodsReceiptDetailId { get; }

    public GoodsReceiptDetailCreatedEvent(GoodsReceiptDetailId goodsreceiptdetailId)
    {
        GoodsReceiptDetailId = goodsreceiptdetailId;
    }
}

public sealed class GoodsReceiptDetailUpdatedEvent : DomainEvent
{
    public GoodsReceiptDetailId GoodsReceiptDetailId { get; }

    public GoodsReceiptDetailUpdatedEvent(GoodsReceiptDetailId goodsreceiptdetailId)
    {
        GoodsReceiptDetailId = goodsreceiptdetailId;
    }
}

public sealed class GoodsReceiptDetailDeletedEvent : DomainEvent
{
    public GoodsReceiptDetailId GoodsReceiptDetailId { get; }

    public GoodsReceiptDetailDeletedEvent(GoodsReceiptDetailId goodsreceiptdetailId)
    {
        GoodsReceiptDetailId = goodsreceiptdetailId;
    }
}
}
