using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptIncomingDetail entity
/// </summary>
public sealed class GoodsReceiptIncomingDetailCreatedEvent : DomainEvent
{
    public GoodsReceiptIncomingDetailId GoodsReceiptIncomingDetailId { get; }

    public GoodsReceiptIncomingDetailCreatedEvent(GoodsReceiptIncomingDetailId goodsreceiptincomingdetailId)
    {
        GoodsReceiptIncomingDetailId = goodsreceiptincomingdetailId;
    }
}

public sealed class GoodsReceiptIncomingDetailUpdatedEvent : DomainEvent
{
    public GoodsReceiptIncomingDetailId GoodsReceiptIncomingDetailId { get; }

    public GoodsReceiptIncomingDetailUpdatedEvent(GoodsReceiptIncomingDetailId goodsreceiptincomingdetailId)
    {
        GoodsReceiptIncomingDetailId = goodsreceiptincomingdetailId;
    }
}

public sealed class GoodsReceiptIncomingDetailDeletedEvent : DomainEvent
{
    public GoodsReceiptIncomingDetailId GoodsReceiptIncomingDetailId { get; }

    public GoodsReceiptIncomingDetailDeletedEvent(GoodsReceiptIncomingDetailId goodsreceiptincomingdetailId)
    {
        GoodsReceiptIncomingDetailId = goodsreceiptincomingdetailId;
    }
}
}
