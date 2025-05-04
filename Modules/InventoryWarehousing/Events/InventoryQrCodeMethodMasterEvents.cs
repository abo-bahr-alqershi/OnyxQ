using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to InventoryQrCodeMethodMaster entity
/// </summary>
public sealed class InventoryQrCodeMethodMasterCreatedEvent : DomainEvent
{
    public InventoryQrCodeMethodMasterId InventoryQrCodeMethodMasterId { get; }

    public InventoryQrCodeMethodMasterCreatedEvent(InventoryQrCodeMethodMasterId inventoryqrcodemethodmasterId)
    {
        InventoryQrCodeMethodMasterId = inventoryqrcodemethodmasterId;
    }
}

public sealed class InventoryQrCodeMethodMasterUpdatedEvent : DomainEvent
{
    public InventoryQrCodeMethodMasterId InventoryQrCodeMethodMasterId { get; }

    public InventoryQrCodeMethodMasterUpdatedEvent(InventoryQrCodeMethodMasterId inventoryqrcodemethodmasterId)
    {
        InventoryQrCodeMethodMasterId = inventoryqrcodemethodmasterId;
    }
}

public sealed class InventoryQrCodeMethodMasterDeletedEvent : DomainEvent
{
    public InventoryQrCodeMethodMasterId InventoryQrCodeMethodMasterId { get; }

    public InventoryQrCodeMethodMasterDeletedEvent(InventoryQrCodeMethodMasterId inventoryqrcodemethodmasterId)
    {
        InventoryQrCodeMethodMasterId = inventoryqrcodemethodmasterId;
    }
}
}
