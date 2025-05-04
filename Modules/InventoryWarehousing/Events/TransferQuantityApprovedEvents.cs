using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to TransferQuantityApproved entity
/// </summary>
public sealed class TransferQuantityApprovedCreatedEvent : DomainEvent
{
    public TransferQuantityApprovedId TransferQuantityApprovedId { get; }

    public TransferQuantityApprovedCreatedEvent(TransferQuantityApprovedId transferquantityapprovedId)
    {
        TransferQuantityApprovedId = transferquantityapprovedId;
    }
}

public sealed class TransferQuantityApprovedUpdatedEvent : DomainEvent
{
    public TransferQuantityApprovedId TransferQuantityApprovedId { get; }

    public TransferQuantityApprovedUpdatedEvent(TransferQuantityApprovedId transferquantityapprovedId)
    {
        TransferQuantityApprovedId = transferquantityapprovedId;
    }
}

public sealed class TransferQuantityApprovedDeletedEvent : DomainEvent
{
    public TransferQuantityApprovedId TransferQuantityApprovedId { get; }

    public TransferQuantityApprovedDeletedEvent(TransferQuantityApprovedId transferquantityapprovedId)
    {
        TransferQuantityApprovedId = transferquantityapprovedId;
    }
}
}
