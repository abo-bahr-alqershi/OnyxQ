using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to GateGoodsReceiptMaster entity
/// </summary>
public sealed class GateGoodsReceiptMasterCreatedEvent : DomainEvent
{
    public GateGoodsReceiptMasterId GateGoodsReceiptMasterId { get; }

    public GateGoodsReceiptMasterCreatedEvent(GateGoodsReceiptMasterId gategoodsreceiptmasterId)
    {
        GateGoodsReceiptMasterId = gategoodsreceiptmasterId;
    }
}

public sealed class GateGoodsReceiptMasterUpdatedEvent : DomainEvent
{
    public GateGoodsReceiptMasterId GateGoodsReceiptMasterId { get; }

    public GateGoodsReceiptMasterUpdatedEvent(GateGoodsReceiptMasterId gategoodsreceiptmasterId)
    {
        GateGoodsReceiptMasterId = gategoodsreceiptmasterId;
    }
}

public sealed class GateGoodsReceiptMasterDeletedEvent : DomainEvent
{
    public GateGoodsReceiptMasterId GateGoodsReceiptMasterId { get; }

    public GateGoodsReceiptMasterDeletedEvent(GateGoodsReceiptMasterId gategoodsreceiptmasterId)
    {
        GateGoodsReceiptMasterId = gategoodsreceiptmasterId;
    }
}
}
