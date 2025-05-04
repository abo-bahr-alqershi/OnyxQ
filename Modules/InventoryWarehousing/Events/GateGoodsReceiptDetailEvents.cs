using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GateGoodsReceiptDetail entity
/// </summary>
public sealed class GateGoodsReceiptDetailCreatedEvent : DomainEvent
{
    public GateGoodsReceiptDetailId GateGoodsReceiptDetailId { get; }

    public GateGoodsReceiptDetailCreatedEvent(GateGoodsReceiptDetailId gategoodsreceiptdetailId)
    {
        GateGoodsReceiptDetailId = gategoodsreceiptdetailId;
    }
}

public sealed class GateGoodsReceiptDetailUpdatedEvent : DomainEvent
{
    public GateGoodsReceiptDetailId GateGoodsReceiptDetailId { get; }

    public GateGoodsReceiptDetailUpdatedEvent(GateGoodsReceiptDetailId gategoodsreceiptdetailId)
    {
        GateGoodsReceiptDetailId = gategoodsreceiptdetailId;
    }
}

public sealed class GateGoodsReceiptDetailDeletedEvent : DomainEvent
{
    public GateGoodsReceiptDetailId GateGoodsReceiptDetailId { get; }

    public GateGoodsReceiptDetailDeletedEvent(GateGoodsReceiptDetailId gategoodsreceiptdetailId)
    {
        GateGoodsReceiptDetailId = gategoodsreceiptdetailId;
    }
}
}
