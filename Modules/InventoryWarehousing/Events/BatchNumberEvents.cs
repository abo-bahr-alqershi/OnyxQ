using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BatchNumber entity
/// </summary>
public sealed class BatchNumberCreatedEvent : DomainEvent
{
    public BatchNumberId BatchNumberId { get; }

    public BatchNumberCreatedEvent(BatchNumberId batchnumberId)
    {
        BatchNumberId = batchnumberId;
    }
}

public sealed class BatchNumberUpdatedEvent : DomainEvent
{
    public BatchNumberId BatchNumberId { get; }

    public BatchNumberUpdatedEvent(BatchNumberId batchnumberId)
    {
        BatchNumberId = batchnumberId;
    }
}

public sealed class BatchNumberDeletedEvent : DomainEvent
{
    public BatchNumberId BatchNumberId { get; }

    public BatchNumberDeletedEvent(BatchNumberId batchnumberId)
    {
        BatchNumberId = batchnumberId;
    }
}
}
