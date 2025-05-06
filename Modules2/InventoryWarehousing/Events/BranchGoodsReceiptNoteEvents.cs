using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BranchGoodsReceiptNote entity
/// </summary>
public sealed class BranchGoodsReceiptNoteCreatedEvent : DomainEvent
{
    public BranchGoodsReceiptNoteId BranchGoodsReceiptNoteId { get; }

    public BranchGoodsReceiptNoteCreatedEvent(BranchGoodsReceiptNoteId branchgoodsreceiptnoteId)
    {
        BranchGoodsReceiptNoteId = branchgoodsreceiptnoteId;
    }
}

public sealed class BranchGoodsReceiptNoteUpdatedEvent : DomainEvent
{
    public BranchGoodsReceiptNoteId BranchGoodsReceiptNoteId { get; }

    public BranchGoodsReceiptNoteUpdatedEvent(BranchGoodsReceiptNoteId branchgoodsreceiptnoteId)
    {
        BranchGoodsReceiptNoteId = branchgoodsreceiptnoteId;
    }
}

public sealed class BranchGoodsReceiptNoteDeletedEvent : DomainEvent
{
    public BranchGoodsReceiptNoteId BranchGoodsReceiptNoteId { get; }

    public BranchGoodsReceiptNoteDeletedEvent(BranchGoodsReceiptNoteId branchgoodsreceiptnoteId)
    {
        BranchGoodsReceiptNoteId = branchgoodsreceiptnoteId;
    }
}
}
