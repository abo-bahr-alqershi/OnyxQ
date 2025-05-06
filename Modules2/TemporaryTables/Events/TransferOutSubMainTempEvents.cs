using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferOutSubMainTemp entity
/// </summary>
public sealed class TransferOutSubMainTempCreatedEvent : DomainEvent
{
    public TransferOutSubMainTempId TransferOutSubMainTempId { get; }

    public TransferOutSubMainTempCreatedEvent(TransferOutSubMainTempId transferoutsubmaintempId)
    {
        TransferOutSubMainTempId = transferoutsubmaintempId;
    }
}

public sealed class TransferOutSubMainTempUpdatedEvent : DomainEvent
{
    public TransferOutSubMainTempId TransferOutSubMainTempId { get; }

    public TransferOutSubMainTempUpdatedEvent(TransferOutSubMainTempId transferoutsubmaintempId)
    {
        TransferOutSubMainTempId = transferoutsubmaintempId;
    }
}

public sealed class TransferOutSubMainTempDeletedEvent : DomainEvent
{
    public TransferOutSubMainTempId TransferOutSubMainTempId { get; }

    public TransferOutSubMainTempDeletedEvent(TransferOutSubMainTempId transferoutsubmaintempId)
    {
        TransferOutSubMainTempId = transferoutsubmaintempId;
    }
}
}
