using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to TransferQuantityApprovedTemp entity
/// </summary>
public sealed class TransferQuantityApprovedTempCreatedEvent : DomainEvent
{
    public TransferQuantityApprovedTempId TransferQuantityApprovedTempId { get; }

    public TransferQuantityApprovedTempCreatedEvent(TransferQuantityApprovedTempId transferquantityapprovedtempId)
    {
        TransferQuantityApprovedTempId = transferquantityapprovedtempId;
    }
}

public sealed class TransferQuantityApprovedTempUpdatedEvent : DomainEvent
{
    public TransferQuantityApprovedTempId TransferQuantityApprovedTempId { get; }

    public TransferQuantityApprovedTempUpdatedEvent(TransferQuantityApprovedTempId transferquantityapprovedtempId)
    {
        TransferQuantityApprovedTempId = transferquantityapprovedtempId;
    }
}

public sealed class TransferQuantityApprovedTempDeletedEvent : DomainEvent
{
    public TransferQuantityApprovedTempId TransferQuantityApprovedTempId { get; }

    public TransferQuantityApprovedTempDeletedEvent(TransferQuantityApprovedTempId transferquantityapprovedtempId)
    {
        TransferQuantityApprovedTempId = transferquantityapprovedtempId;
    }
}
}
