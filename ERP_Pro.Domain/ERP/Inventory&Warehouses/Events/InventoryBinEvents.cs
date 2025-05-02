using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class InventoryBinCreatedEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }

        public InventoryBinCreatedEvent(InventoryBin inventoryBin)
        {
            InventoryBin = inventoryBin;
        }
    }

    public class InventoryBinBatchInfoUpdatedEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }
        public string? OldBatchNumber { get; }
        public DateTime? OldExpireDate { get; }
        public string? NewBatchNumber { get; }
        public DateTime? NewExpireDate { get; }

        public InventoryBinBatchInfoUpdatedEvent(
            InventoryBin inventoryBin,
            string? oldBatchNumber,
            DateTime? oldExpireDate,
            string? newBatchNumber,
            DateTime? newExpireDate)
        {
            InventoryBin = inventoryBin;
            OldBatchNumber = oldBatchNumber;
            OldExpireDate = oldExpireDate;
            NewBatchNumber = newBatchNumber;
            NewExpireDate = newExpireDate;
        }
    }

    public class InventoryBinSetAsDefaultEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }

        public InventoryBinSetAsDefaultEvent(InventoryBin inventoryBin)
        {
            InventoryBin = inventoryBin;
        }
    }

    public class InventoryBinUnsetAsDefaultEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }

        public InventoryBinUnsetAsDefaultEvent(InventoryBin inventoryBin)
        {
            InventoryBin = inventoryBin;
        }
    }

    public class InventoryBinExternalPostUpdatedEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }
        public int? OldExternalPost { get; }
        public int? NewExternalPost { get; }

        public InventoryBinExternalPostUpdatedEvent(
            InventoryBin inventoryBin,
            int? oldExternalPost,
            int? newExternalPost)
        {
            InventoryBin = inventoryBin;
            OldExternalPost = oldExternalPost;
            NewExternalPost = newExternalPost;
        }
    }

    public class InventoryBinReportPriorityUpdatedEvent : DomainEvent
    {
        public InventoryBin InventoryBin { get; }
        public long? OldPriority { get; }
        public long? NewPriority { get; }

        public InventoryBinReportPriorityUpdatedEvent(
            InventoryBin inventoryBin,
            long? oldPriority,
            long? newPriority)
        {
            InventoryBin = inventoryBin;
            OldPriority = oldPriority;
            NewPriority = newPriority;
        }
    }
} 