using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to ItemsTransferQuantityTemp entity
/// </summary>
public sealed class ItemsTransferQuantityTempCreatedEvent : DomainEvent
{
    public ItemsTransferQuantityTempId ItemsTransferQuantityTempId { get; }

    public ItemsTransferQuantityTempCreatedEvent(ItemsTransferQuantityTempId itemstransferquantitytempId)
    {
        ItemsTransferQuantityTempId = itemstransferquantitytempId;
    }
}

public sealed class ItemsTransferQuantityTempUpdatedEvent : DomainEvent
{
    public ItemsTransferQuantityTempId ItemsTransferQuantityTempId { get; }

    public ItemsTransferQuantityTempUpdatedEvent(ItemsTransferQuantityTempId itemstransferquantitytempId)
    {
        ItemsTransferQuantityTempId = itemstransferquantitytempId;
    }
}

public sealed class ItemsTransferQuantityTempDeletedEvent : DomainEvent
{
    public ItemsTransferQuantityTempId ItemsTransferQuantityTempId { get; }

    public ItemsTransferQuantityTempDeletedEvent(ItemsTransferQuantityTempId itemstransferquantitytempId)
    {
        ItemsTransferQuantityTempId = itemstransferquantitytempId;
    }
}
}
