using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferOutTemp entity
/// </summary>
public sealed class TransferOutTempCreatedEvent : DomainEvent
{
    public TransferOutTempId TransferOutTempId { get; }

    public TransferOutTempCreatedEvent(TransferOutTempId transferouttempId)
    {
        TransferOutTempId = transferouttempId;
    }
}

public sealed class TransferOutTempUpdatedEvent : DomainEvent
{
    public TransferOutTempId TransferOutTempId { get; }

    public TransferOutTempUpdatedEvent(TransferOutTempId transferouttempId)
    {
        TransferOutTempId = transferouttempId;
    }
}

public sealed class TransferOutTempDeletedEvent : DomainEvent
{
    public TransferOutTempId TransferOutTempId { get; }

    public TransferOutTempDeletedEvent(TransferOutTempId transferouttempId)
    {
        TransferOutTempId = transferouttempId;
    }
}
}
