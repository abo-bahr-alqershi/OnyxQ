using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to BatchNumberContentMaster entity
/// </summary>
public sealed class BatchNumberContentMasterCreatedEvent : DomainEvent
{
    public BatchNumberContentMasterId BatchNumberContentMasterId { get; }

    public BatchNumberContentMasterCreatedEvent(BatchNumberContentMasterId batchnumbercontentmasterId)
    {
        BatchNumberContentMasterId = batchnumbercontentmasterId;
    }
}

public sealed class BatchNumberContentMasterUpdatedEvent : DomainEvent
{
    public BatchNumberContentMasterId BatchNumberContentMasterId { get; }

    public BatchNumberContentMasterUpdatedEvent(BatchNumberContentMasterId batchnumbercontentmasterId)
    {
        BatchNumberContentMasterId = batchnumbercontentmasterId;
    }
}

public sealed class BatchNumberContentMasterDeletedEvent : DomainEvent
{
    public BatchNumberContentMasterId BatchNumberContentMasterId { get; }

    public BatchNumberContentMasterDeletedEvent(BatchNumberContentMasterId batchnumbercontentmasterId)
    {
        BatchNumberContentMasterId = batchnumbercontentmasterId;
    }
}
}
