using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferOutSubTemp entity
/// </summary>
public sealed class TransferOutSubTempCreatedEvent : DomainEvent
{
    public TransferOutSubTempId TransferOutSubTempId { get; }

    public TransferOutSubTempCreatedEvent(TransferOutSubTempId transferoutsubtempId)
    {
        TransferOutSubTempId = transferoutsubtempId;
    }
}

public sealed class TransferOutSubTempUpdatedEvent : DomainEvent
{
    public TransferOutSubTempId TransferOutSubTempId { get; }

    public TransferOutSubTempUpdatedEvent(TransferOutSubTempId transferoutsubtempId)
    {
        TransferOutSubTempId = transferoutsubtempId;
    }
}

public sealed class TransferOutSubTempDeletedEvent : DomainEvent
{
    public TransferOutSubTempId TransferOutSubTempId { get; }

    public TransferOutSubTempDeletedEvent(TransferOutSubTempId transferoutsubtempId)
    {
        TransferOutSubTempId = transferoutsubtempId;
    }
}
}
