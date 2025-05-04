using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptNoteMaster entity
/// </summary>
public sealed class GoodsReceiptNoteMasterCreatedEvent : DomainEvent
{
    public GoodsReceiptNoteMasterId GoodsReceiptNoteMasterId { get; }

    public GoodsReceiptNoteMasterCreatedEvent(GoodsReceiptNoteMasterId goodsreceiptnotemasterId)
    {
        GoodsReceiptNoteMasterId = goodsreceiptnotemasterId;
    }
}

public sealed class GoodsReceiptNoteMasterUpdatedEvent : DomainEvent
{
    public GoodsReceiptNoteMasterId GoodsReceiptNoteMasterId { get; }

    public GoodsReceiptNoteMasterUpdatedEvent(GoodsReceiptNoteMasterId goodsreceiptnotemasterId)
    {
        GoodsReceiptNoteMasterId = goodsreceiptnotemasterId;
    }
}

public sealed class GoodsReceiptNoteMasterDeletedEvent : DomainEvent
{
    public GoodsReceiptNoteMasterId GoodsReceiptNoteMasterId { get; }

    public GoodsReceiptNoteMasterDeletedEvent(GoodsReceiptNoteMasterId goodsreceiptnotemasterId)
    {
        GoodsReceiptNoteMasterId = goodsreceiptnotemasterId;
    }
}
}
