using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to ReceiptWatch entity
/// </summary>
public sealed class ReceiptWatchCreatedEvent : DomainEvent
{
    public ReceiptWatchId ReceiptWatchId { get; }

    public ReceiptWatchCreatedEvent(ReceiptWatchId receiptwatchId)
    {
        ReceiptWatchId = receiptwatchId;
    }
}

public sealed class ReceiptWatchUpdatedEvent : DomainEvent
{
    public ReceiptWatchId ReceiptWatchId { get; }

    public ReceiptWatchUpdatedEvent(ReceiptWatchId receiptwatchId)
    {
        ReceiptWatchId = receiptwatchId;
    }
}

public sealed class ReceiptWatchDeletedEvent : DomainEvent
{
    public ReceiptWatchId ReceiptWatchId { get; }

    public ReceiptWatchDeletedEvent(ReceiptWatchId receiptwatchId)
    {
        ReceiptWatchId = receiptwatchId;
    }
}
}
