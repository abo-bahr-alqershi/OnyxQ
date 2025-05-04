using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BatchNumberContent entity
/// </summary>
public sealed class BatchNumberContentCreatedEvent : DomainEvent
{
    public BatchNumberContentId BatchNumberContentId { get; }

    public BatchNumberContentCreatedEvent(BatchNumberContentId batchnumbercontentId)
    {
        BatchNumberContentId = batchnumbercontentId;
    }
}

public sealed class BatchNumberContentUpdatedEvent : DomainEvent
{
    public BatchNumberContentId BatchNumberContentId { get; }

    public BatchNumberContentUpdatedEvent(BatchNumberContentId batchnumbercontentId)
    {
        BatchNumberContentId = batchnumbercontentId;
    }
}

public sealed class BatchNumberContentDeletedEvent : DomainEvent
{
    public BatchNumberContentId BatchNumberContentId { get; }

    public BatchNumberContentDeletedEvent(BatchNumberContentId batchnumbercontentId)
    {
        BatchNumberContentId = batchnumbercontentId;
    }
}
}
