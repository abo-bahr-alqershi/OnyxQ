using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to ItemUnitBarcode entity
/// </summary>
public sealed class ItemUnitBarcodeCreatedEvent : DomainEvent
{
    public ItemUnitBarcodeId ItemUnitBarcodeId { get; }

    public ItemUnitBarcodeCreatedEvent(ItemUnitBarcodeId itemunitbarcodeId)
    {
        ItemUnitBarcodeId = itemunitbarcodeId;
    }
}

public sealed class ItemUnitBarcodeUpdatedEvent : DomainEvent
{
    public ItemUnitBarcodeId ItemUnitBarcodeId { get; }

    public ItemUnitBarcodeUpdatedEvent(ItemUnitBarcodeId itemunitbarcodeId)
    {
        ItemUnitBarcodeId = itemunitbarcodeId;
    }
}

public sealed class ItemUnitBarcodeDeletedEvent : DomainEvent
{
    public ItemUnitBarcodeId ItemUnitBarcodeId { get; }

    public ItemUnitBarcodeDeletedEvent(ItemUnitBarcodeId itemunitbarcodeId)
    {
        ItemUnitBarcodeId = itemunitbarcodeId;
    }
}
}
