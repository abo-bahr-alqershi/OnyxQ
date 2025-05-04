using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferInSubMainTemp entity
/// </summary>
public sealed class TransferInSubMainTempCreatedEvent : DomainEvent
{
    public TransferInSubMainTempId TransferInSubMainTempId { get; }

    public TransferInSubMainTempCreatedEvent(TransferInSubMainTempId transferinsubmaintempId)
    {
        TransferInSubMainTempId = transferinsubmaintempId;
    }
}

public sealed class TransferInSubMainTempUpdatedEvent : DomainEvent
{
    public TransferInSubMainTempId TransferInSubMainTempId { get; }

    public TransferInSubMainTempUpdatedEvent(TransferInSubMainTempId transferinsubmaintempId)
    {
        TransferInSubMainTempId = transferinsubmaintempId;
    }
}

public sealed class TransferInSubMainTempDeletedEvent : DomainEvent
{
    public TransferInSubMainTempId TransferInSubMainTempId { get; }

    public TransferInSubMainTempDeletedEvent(TransferInSubMainTempId transferinsubmaintempId)
    {
        TransferInSubMainTempId = transferinsubmaintempId;
    }
}
}
