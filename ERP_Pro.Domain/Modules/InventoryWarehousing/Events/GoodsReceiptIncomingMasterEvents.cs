using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GoodsReceiptIncomingMaster entity
/// </summary>
public sealed class GoodsReceiptIncomingMasterCreatedEvent : DomainEvent
{
    public GoodsReceiptIncomingMasterId GoodsReceiptIncomingMasterId { get; }

    public GoodsReceiptIncomingMasterCreatedEvent(GoodsReceiptIncomingMasterId goodsreceiptincomingmasterId)
    {
        GoodsReceiptIncomingMasterId = goodsreceiptincomingmasterId;
    }
}

public sealed class GoodsReceiptIncomingMasterUpdatedEvent : DomainEvent
{
    public GoodsReceiptIncomingMasterId GoodsReceiptIncomingMasterId { get; }

    public GoodsReceiptIncomingMasterUpdatedEvent(GoodsReceiptIncomingMasterId goodsreceiptincomingmasterId)
    {
        GoodsReceiptIncomingMasterId = goodsreceiptincomingmasterId;
    }
}

public sealed class GoodsReceiptIncomingMasterDeletedEvent : DomainEvent
{
    public GoodsReceiptIncomingMasterId GoodsReceiptIncomingMasterId { get; }

    public GoodsReceiptIncomingMasterDeletedEvent(GoodsReceiptIncomingMasterId goodsreceiptincomingmasterId)
    {
        GoodsReceiptIncomingMasterId = goodsreceiptincomingmasterId;
    }
}
}
