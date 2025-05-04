using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryBarcodeConfig entity
/// </summary>
public sealed class InventoryBarcodeConfigCreatedEvent : DomainEvent
{
    public InventoryBarcodeConfigId InventoryBarcodeConfigId { get; }

    public InventoryBarcodeConfigCreatedEvent(InventoryBarcodeConfigId inventorybarcodeconfigId)
    {
        InventoryBarcodeConfigId = inventorybarcodeconfigId;
    }
}

public sealed class InventoryBarcodeConfigUpdatedEvent : DomainEvent
{
    public InventoryBarcodeConfigId InventoryBarcodeConfigId { get; }

    public InventoryBarcodeConfigUpdatedEvent(InventoryBarcodeConfigId inventorybarcodeconfigId)
    {
        InventoryBarcodeConfigId = inventorybarcodeconfigId;
    }
}

public sealed class InventoryBarcodeConfigDeletedEvent : DomainEvent
{
    public InventoryBarcodeConfigId InventoryBarcodeConfigId { get; }

    public InventoryBarcodeConfigDeletedEvent(InventoryBarcodeConfigId inventorybarcodeconfigId)
    {
        InventoryBarcodeConfigId = inventorybarcodeconfigId;
    }
}
}
