using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferInSubTemp entity
/// </summary>
public sealed class TransferInSubTempCreatedEvent : DomainEvent
{
    public TransferInSubTempId TransferInSubTempId { get; }

    public TransferInSubTempCreatedEvent(TransferInSubTempId transferinsubtempId)
    {
        TransferInSubTempId = transferinsubtempId;
    }
}

public sealed class TransferInSubTempUpdatedEvent : DomainEvent
{
    public TransferInSubTempId TransferInSubTempId { get; }

    public TransferInSubTempUpdatedEvent(TransferInSubTempId transferinsubtempId)
    {
        TransferInSubTempId = transferinsubtempId;
    }
}

public sealed class TransferInSubTempDeletedEvent : DomainEvent
{
    public TransferInSubTempId TransferInSubTempId { get; }

    public TransferInSubTempDeletedEvent(TransferInSubTempId transferinsubtempId)
    {
        TransferInSubTempId = transferinsubtempId;
    }
}
}
