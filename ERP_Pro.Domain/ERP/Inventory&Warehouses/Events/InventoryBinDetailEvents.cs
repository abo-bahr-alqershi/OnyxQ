using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class InventoryBinDetailCreatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }

        public InventoryBinDetailCreatedEvent(InventoryBinDetail inventoryBinDetail)
        {
            InventoryBinDetail = inventoryBinDetail;
        }
    }

    public class InventoryBinDetailDescriptionUpdatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }
        public string? OldDescription { get; }
        public string? NewDescription { get; }

        public InventoryBinDetailDescriptionUpdatedEvent(
            InventoryBinDetail inventoryBinDetail,
            string? oldDescription,
            string? newDescription)
        {
            InventoryBinDetail = inventoryBinDetail;
            OldDescription = oldDescription;
            NewDescription = newDescription;
        }
    }

    public class InventoryBinDetailLocationUpdatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }
        public string? OldSection { get; }
        public string? OldRow { get; }
        public string? OldColumn { get; }
        public string? OldLevel { get; }
        public string? OldZone { get; }
        public string? OldArea { get; }
        public string? NewSection { get; }
        public string? NewRow { get; }
        public string? NewColumn { get; }
        public string? NewLevel { get; }
        public string? NewZone { get; }
        public string? NewArea { get; }

        public InventoryBinDetailLocationUpdatedEvent(
            InventoryBinDetail inventoryBinDetail,
            string? oldSection,
            string? oldRow,
            string? oldColumn,
            string? oldLevel,
            string? oldZone,
            string? oldArea,
            string? newSection,
            string? newRow,
            string? newColumn,
            string? newLevel,
            string? newZone,
            string? newArea)
        {
            InventoryBinDetail = inventoryBinDetail;
            OldSection = oldSection;
            OldRow = oldRow;
            OldColumn = oldColumn;
            OldLevel = oldLevel;
            OldZone = oldZone;
            OldArea = oldArea;
            NewSection = newSection;
            NewRow = newRow;
            NewColumn = newColumn;
            NewLevel = newLevel;
            NewZone = newZone;
            NewArea = newArea;
        }
    }

    public class InventoryBinDetailActivatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }

        public InventoryBinDetailActivatedEvent(InventoryBinDetail inventoryBinDetail)
        {
            InventoryBinDetail = inventoryBinDetail;
        }
    }

    public class InventoryBinDetailDeactivatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }

        public InventoryBinDetailDeactivatedEvent(InventoryBinDetail inventoryBinDetail)
        {
            InventoryBinDetail = inventoryBinDetail;
        }
    }

    public class InventoryBinDetailLockedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }

        public InventoryBinDetailLockedEvent(InventoryBinDetail inventoryBinDetail)
        {
            InventoryBinDetail = inventoryBinDetail;
        }
    }

    public class InventoryBinDetailUnlockedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }

        public InventoryBinDetailUnlockedEvent(InventoryBinDetail inventoryBinDetail)
        {
            InventoryBinDetail = inventoryBinDetail;
        }
    }

    public class InventoryBinDetailCapacityUpdatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }
        public int? OldCapacity { get; }
        public int? OldMinimumThreshold { get; }
        public int? OldMaximumThreshold { get; }
        public int NewCapacity { get; }
        public int? NewMinimumThreshold { get; }
        public int? NewMaximumThreshold { get; }

        public InventoryBinDetailCapacityUpdatedEvent(
            InventoryBinDetail inventoryBinDetail,
            int? oldCapacity,
            int? oldMinimumThreshold,
            int? oldMaximumThreshold,
            int newCapacity,
            int? newMinimumThreshold,
            int? newMaximumThreshold)
        {
            InventoryBinDetail = inventoryBinDetail;
            OldCapacity = oldCapacity;
            OldMinimumThreshold = oldMinimumThreshold;
            OldMaximumThreshold = oldMaximumThreshold;
            NewCapacity = newCapacity;
            NewMinimumThreshold = newMinimumThreshold;
            NewMaximumThreshold = newMaximumThreshold;
        }
    }

    public class InventoryBinDetailOccupancyUpdatedEvent : DomainEvent
    {
        public InventoryBinDetail InventoryBinDetail { get; }
        public int? OldOccupancy { get; }
        public int NewOccupancy { get; }

        public InventoryBinDetailOccupancyUpdatedEvent(
            InventoryBinDetail inventoryBinDetail,
            int? oldOccupancy,
            int newOccupancy)
        {
            InventoryBinDetail = inventoryBinDetail;
            OldOccupancy = oldOccupancy;
            NewOccupancy = newOccupancy;
        }
    }
} 