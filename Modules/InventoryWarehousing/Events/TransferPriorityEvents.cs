using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to TransferPriority entity
/// </summary>
public sealed class TransferPriorityCreatedEvent : DomainEvent
{
    public TransferPriorityId TransferPriorityId { get; }

    public TransferPriorityCreatedEvent(TransferPriorityId transferpriorityId)
    {
        TransferPriorityId = transferpriorityId;
    }
}

public sealed class TransferPriorityUpdatedEvent : DomainEvent
{
    public TransferPriorityId TransferPriorityId { get; }

    public TransferPriorityUpdatedEvent(TransferPriorityId transferpriorityId)
    {
        TransferPriorityId = transferpriorityId;
    }
}

public sealed class TransferPriorityDeletedEvent : DomainEvent
{
    public TransferPriorityId TransferPriorityId { get; }

    public TransferPriorityDeletedEvent(TransferPriorityId transferpriorityId)
    {
        TransferPriorityId = transferpriorityId;
    }
}
}
