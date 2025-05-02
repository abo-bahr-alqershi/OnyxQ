using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class ItemBatchCreatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string BatchNumber { get; }

        public ItemBatchCreatedEvent(string itemCode, string batchNumber)
        {
            ItemCode = itemCode;
            BatchNumber = batchNumber;
        }
    }

    public class ItemBatchDescriptionUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string BatchNumber { get; }
        public int DescriptionNumber { get; }

        public ItemBatchDescriptionUpdatedEvent(string itemCode, string batchNumber, int descriptionNumber)
        {
            ItemCode = itemCode;
            BatchNumber = batchNumber;
            DescriptionNumber = descriptionNumber;
        }
    }

    public class ItemBatchBranchInfoUpdatedEvent : DomainEvent
    {
        public string ItemCode { get; }
        public string BatchNumber { get; }

        public ItemBatchBranchInfoUpdatedEvent(string itemCode, string batchNumber)
        {
            ItemCode = itemCode;
            BatchNumber = batchNumber;
        }
    }

    public class ItemBatchUnitConfigurationUpdatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public UnitConfiguration OldConfiguration { get; }
        public UnitConfiguration NewConfiguration { get; }

        public ItemBatchUnitConfigurationUpdatedEvent(
            ItemBatch itemBatch,
            UnitConfiguration oldConfiguration,
            UnitConfiguration newConfiguration)
        {
            ItemBatch = itemBatch;
            OldConfiguration = oldConfiguration;
            NewConfiguration = newConfiguration;
        }
    }

    public class ItemBatchDeactivatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public string Reason { get; }
        public int UserId { get; }

        public ItemBatchDeactivatedEvent(
            ItemBatch itemBatch,
            string reason,
            int userId)
        {
            ItemBatch = itemBatch;
            Reason = reason;
            UserId = userId;
        }
    }

    public class ItemBatchActivatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public int UserId { get; }

        public ItemBatchActivatedEvent(ItemBatch itemBatch, int userId)
        {
            ItemBatch = itemBatch;
            UserId = userId;
        }
    }

    public class ItemBatchUnitDescriptionUpdatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public UnitDescription OldDescription { get; }
        public UnitDescription NewDescription { get; }

        public ItemBatchUnitDescriptionUpdatedEvent(
            ItemBatch itemBatch,
            UnitDescription oldDescription,
            UnitDescription newDescription)
        {
            ItemBatch = itemBatch;
            OldDescription = oldDescription;
            NewDescription = newDescription;
        }
    }

    public class ItemBatchBarcodeUpdatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public string Barcode { get; }

        public ItemBatchBarcodeUpdatedEvent(ItemBatch itemBatch, string barcode)
        {
            ItemBatch = itemBatch;
            Barcode = barcode;
        }
    }

    public class ItemBatchUnitInfoUpdatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public int? OldUnitLevel { get; }
        public int? OldWeightUnit { get; }
        public int? NewUnitLevel { get; }
        public int? NewWeightUnit { get; }

        public ItemBatchUnitInfoUpdatedEvent(
            ItemBatch itemBatch,
            int? oldUnitLevel,
            int? oldWeightUnit,
            int? newUnitLevel,
            int? newWeightUnit)
        {
            ItemBatch = itemBatch;
            OldUnitLevel = oldUnitLevel;
            OldWeightUnit = oldWeightUnit;
            NewUnitLevel = newUnitLevel;
            NewWeightUnit = newWeightUnit;
        }
    }

    public class ItemBatchFlagsUpdatedEvent : DomainEvent
    {
        public ItemBatch ItemBatch { get; }
        public bool? ExceptionDiscountCardFlag { get; }
        public bool? QrCodeMethodNumber { get; }
        public bool? UseSerialNumber { get; }

        public ItemBatchFlagsUpdatedEvent(
            ItemBatch itemBatch,
            bool? exceptionDiscountCardFlag,
            bool? qrCodeMethodNumber,
            bool? useSerialNumber)
        {
            ItemBatch = itemBatch;
            ExceptionDiscountCardFlag = exceptionDiscountCardFlag;
            QrCodeMethodNumber = qrCodeMethodNumber;
            UseSerialNumber = useSerialNumber;
        }
    }
} 