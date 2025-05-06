using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferInTemp entity
/// </summary>
public sealed class TransferInTempCreatedEvent : DomainEvent
{
    public TransferInTempId TransferInTempId { get; }

    public TransferInTempCreatedEvent(TransferInTempId transferintempId)
    {
        TransferInTempId = transferintempId;
    }
}

public sealed class TransferInTempUpdatedEvent : DomainEvent
{
    public TransferInTempId TransferInTempId { get; }

    public TransferInTempUpdatedEvent(TransferInTempId transferintempId)
    {
        TransferInTempId = transferintempId;
    }
}

public sealed class TransferInTempDeletedEvent : DomainEvent
{
    public TransferInTempId TransferInTempId { get; }

    public TransferInTempDeletedEvent(TransferInTempId transferintempId)
    {
        TransferInTempId = transferintempId;
    }
}
}
