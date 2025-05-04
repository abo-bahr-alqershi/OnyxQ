using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryQrCodeMethodDetail entity
/// </summary>
public sealed class InventoryQrCodeMethodDetailCreatedEvent : DomainEvent
{
    public InventoryQrCodeMethodDetailId InventoryQrCodeMethodDetailId { get; }

    public InventoryQrCodeMethodDetailCreatedEvent(InventoryQrCodeMethodDetailId inventoryqrcodemethoddetailId)
    {
        InventoryQrCodeMethodDetailId = inventoryqrcodemethoddetailId;
    }
}

public sealed class InventoryQrCodeMethodDetailUpdatedEvent : DomainEvent
{
    public InventoryQrCodeMethodDetailId InventoryQrCodeMethodDetailId { get; }

    public InventoryQrCodeMethodDetailUpdatedEvent(InventoryQrCodeMethodDetailId inventoryqrcodemethoddetailId)
    {
        InventoryQrCodeMethodDetailId = inventoryqrcodemethoddetailId;
    }
}

public sealed class InventoryQrCodeMethodDetailDeletedEvent : DomainEvent
{
    public InventoryQrCodeMethodDetailId InventoryQrCodeMethodDetailId { get; }

    public InventoryQrCodeMethodDetailDeletedEvent(InventoryQrCodeMethodDetailId inventoryqrcodemethoddetailId)
    {
        InventoryQrCodeMethodDetailId = inventoryqrcodemethoddetailId;
    }
}
}
