using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchGoodsReceiptDetail entity
/// </summary>
public sealed class BranchGoodsReceiptDetailCreatedEvent : DomainEvent
{
    public BranchGoodsReceiptDetailId BranchGoodsReceiptDetailId { get; }

    public BranchGoodsReceiptDetailCreatedEvent(BranchGoodsReceiptDetailId branchgoodsreceiptdetailId)
    {
        BranchGoodsReceiptDetailId = branchgoodsreceiptdetailId;
    }
}

public sealed class BranchGoodsReceiptDetailUpdatedEvent : DomainEvent
{
    public BranchGoodsReceiptDetailId BranchGoodsReceiptDetailId { get; }

    public BranchGoodsReceiptDetailUpdatedEvent(BranchGoodsReceiptDetailId branchgoodsreceiptdetailId)
    {
        BranchGoodsReceiptDetailId = branchgoodsreceiptdetailId;
    }
}

public sealed class BranchGoodsReceiptDetailDeletedEvent : DomainEvent
{
    public BranchGoodsReceiptDetailId BranchGoodsReceiptDetailId { get; }

    public BranchGoodsReceiptDetailDeletedEvent(BranchGoodsReceiptDetailId branchgoodsreceiptdetailId)
    {
        BranchGoodsReceiptDetailId = branchgoodsreceiptdetailId;
    }
}
}
