using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryItemQrCode entity
/// </summary>
public sealed class InventoryItemQrCodeCreatedEvent : DomainEvent
{
    public InventoryItemQrCodeId InventoryItemQrCodeId { get; }

    public InventoryItemQrCodeCreatedEvent(InventoryItemQrCodeId inventoryitemqrcodeId)
    {
        InventoryItemQrCodeId = inventoryitemqrcodeId;
    }
}

public sealed class InventoryItemQrCodeUpdatedEvent : DomainEvent
{
    public InventoryItemQrCodeId InventoryItemQrCodeId { get; }

    public InventoryItemQrCodeUpdatedEvent(InventoryItemQrCodeId inventoryitemqrcodeId)
    {
        InventoryItemQrCodeId = inventoryitemqrcodeId;
    }
}

public sealed class InventoryItemQrCodeDeletedEvent : DomainEvent
{
    public InventoryItemQrCodeId InventoryItemQrCodeId { get; }

    public InventoryItemQrCodeDeletedEvent(InventoryItemQrCodeId inventoryitemqrcodeId)
    {
        InventoryItemQrCodeId = inventoryitemqrcodeId;
    }
}
}
