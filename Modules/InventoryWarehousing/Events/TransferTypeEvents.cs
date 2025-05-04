using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to TransferType entity
/// </summary>
public sealed class TransferTypeCreatedEvent : DomainEvent
{
    public TransferTypeId TransferTypeId { get; }

    public TransferTypeCreatedEvent(TransferTypeId transfertypeId)
    {
        TransferTypeId = transfertypeId;
    }
}

public sealed class TransferTypeUpdatedEvent : DomainEvent
{
    public TransferTypeId TransferTypeId { get; }

    public TransferTypeUpdatedEvent(TransferTypeId transfertypeId)
    {
        TransferTypeId = transfertypeId;
    }
}

public sealed class TransferTypeDeletedEvent : DomainEvent
{
    public TransferTypeId TransferTypeId { get; }

    public TransferTypeDeletedEvent(TransferTypeId transfertypeId)
    {
        TransferTypeId = transfertypeId;
    }
}
}
