using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class InventoryAdjustmentDetailCreatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }

        public InventoryAdjustmentDetailCreatedEvent(InventoryAdjustmentDetail detail)
        {
            Detail = detail;
        }
    }

    public class InventoryAdjustmentDetailQuantitiesUpdatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }
        public int? OldAvailableQuantity { get; }
        public int? OldPlusMinus { get; }
        public int? OldPackQuantity { get; }
        public int? OldManualPackQuantity { get; }
        public int? OldManualAvailablePackQuantity { get; }
        public int? OldIncreaseQuantity { get; }
        public int? OldBalanceQuantity { get; }
        public int? NewAvailableQuantity { get; }
        public int? NewPlusMinus { get; }
        public int? NewPackQuantity { get; }
        public int? NewManualPackQuantity { get; }
        public int? NewManualAvailablePackQuantity { get; }
        public int? NewIncreaseQuantity { get; }
        public int? NewBalanceQuantity { get; }

        public InventoryAdjustmentDetailQuantitiesUpdatedEvent(
            InventoryAdjustmentDetail detail,
            int? oldAvailableQuantity,
            int? oldPlusMinus,
            int? oldPackQuantity,
            int? oldManualPackQuantity,
            int? oldManualAvailablePackQuantity,
            int? oldIncreaseQuantity,
            int? oldBalanceQuantity,
            int? newAvailableQuantity,
            int? newPlusMinus,
            int? newPackQuantity,
            int? newManualPackQuantity,
            int? newManualAvailablePackQuantity,
            int? newIncreaseQuantity,
            int? newBalanceQuantity)
        {
            Detail = detail;
            OldAvailableQuantity = oldAvailableQuantity;
            OldPlusMinus = oldPlusMinus;
            OldPackQuantity = oldPackQuantity;
            OldManualPackQuantity = oldManualPackQuantity;
            OldManualAvailablePackQuantity = oldManualAvailablePackQuantity;
            OldIncreaseQuantity = oldIncreaseQuantity;
            OldBalanceQuantity = oldBalanceQuantity;
            NewAvailableQuantity = newAvailableQuantity;
            NewPlusMinus = newPlusMinus;
            NewPackQuantity = newPackQuantity;
            NewManualPackQuantity = newManualPackQuantity;
            NewManualAvailablePackQuantity = newManualAvailablePackQuantity;
            NewIncreaseQuantity = newIncreaseQuantity;
            NewBalanceQuantity = newBalanceQuantity;
        }
    }

    public class InventoryAdjustmentDetailCostsUpdatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }
        public int? OldWeightedAverage { get; }
        public int? OldPurchaseInvoicePrice { get; }
        public int? OldPurchaseInvoiceQuantity { get; }
        public int? OldPreviousInvoiceQuantity { get; }
        public int? OldBillDiscount { get; }
        public int? OldIncreaseCost { get; }
        public int? OldRealCost { get; }
        public int? NewWeightedAverage { get; }
        public int? NewPurchaseInvoicePrice { get; }
        public int? NewPurchaseInvoiceQuantity { get; }
        public int? NewPreviousInvoiceQuantity { get; }
        public int? NewBillDiscount { get; }
        public int? NewIncreaseCost { get; }
        public int? NewRealCost { get; }

        public InventoryAdjustmentDetailCostsUpdatedEvent(
            InventoryAdjustmentDetail detail,
            int? oldWeightedAverage,
            int? oldPurchaseInvoicePrice,
            int? oldPurchaseInvoiceQuantity,
            int? oldPreviousInvoiceQuantity,
            int? oldBillDiscount,
            int? oldIncreaseCost,
            int? oldRealCost,
            int? newWeightedAverage,
            int? newPurchaseInvoicePrice,
            int? newPurchaseInvoiceQuantity,
            int? newPreviousInvoiceQuantity,
            int? newBillDiscount,
            int? newIncreaseCost,
            int? newRealCost)
        {
            Detail = detail;
            OldWeightedAverage = oldWeightedAverage;
            OldPurchaseInvoicePrice = oldPurchaseInvoicePrice;
            OldPurchaseInvoiceQuantity = oldPurchaseInvoiceQuantity;
            OldPreviousInvoiceQuantity = oldPreviousInvoiceQuantity;
            OldBillDiscount = oldBillDiscount;
            OldIncreaseCost = oldIncreaseCost;
            OldRealCost = oldRealCost;
            NewWeightedAverage = newWeightedAverage;
            NewPurchaseInvoicePrice = newPurchaseInvoicePrice;
            NewPurchaseInvoiceQuantity = newPurchaseInvoiceQuantity;
            NewPreviousInvoiceQuantity = newPreviousInvoiceQuantity;
            NewBillDiscount = newBillDiscount;
            NewIncreaseCost = newIncreaseCost;
            NewRealCost = newRealCost;
        }
    }

    public class InventoryAdjustmentDetailBatchInfoUpdatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }
        public string? OldBatchNumber { get; }
        public DateTime? OldExpireDate { get; }
        public string? NewBatchNumber { get; }
        public DateTime? NewExpireDate { get; }

        public InventoryAdjustmentDetailBatchInfoUpdatedEvent(
            InventoryAdjustmentDetail detail,
            string? oldBatchNumber,
            DateTime? oldExpireDate,
            string? newBatchNumber,
            DateTime? newExpireDate)
        {
            Detail = detail;
            OldBatchNumber = oldBatchNumber;
            OldExpireDate = oldExpireDate;
            NewBatchNumber = newBatchNumber;
            NewExpireDate = newExpireDate;
        }
    }

    public class InventoryAdjustmentDetailDimensionsUpdatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }
        public int? OldLength { get; }
        public int? OldWidth { get; }
        public int? OldHeight { get; }
        public int? OldNumber { get; }
        public int? OldWeightQuantity { get; }
        public string? OldWeightUnit { get; }
        public int? NewLength { get; }
        public int? NewWidth { get; }
        public int? NewHeight { get; }
        public int? NewNumber { get; }
        public int? NewWeightQuantity { get; }
        public string? NewWeightUnit { get; }

        public InventoryAdjustmentDetailDimensionsUpdatedEvent(
            InventoryAdjustmentDetail detail,
            int? oldLength,
            int? oldWidth,
            int? oldHeight,
            int? oldNumber,
            int? oldWeightQuantity,
            string? oldWeightUnit,
            int? newLength,
            int? newWidth,
            int? newHeight,
            int? newNumber,
            int? newWeightQuantity,
            string? newWeightUnit)
        {
            Detail = detail;
            OldLength = oldLength;
            OldWidth = oldWidth;
            OldHeight = oldHeight;
            OldNumber = oldNumber;
            OldWeightQuantity = oldWeightQuantity;
            OldWeightUnit = oldWeightUnit;
            NewLength = newLength;
            NewWidth = newWidth;
            NewHeight = newHeight;
            NewNumber = newNumber;
            NewWeightQuantity = newWeightQuantity;
            NewWeightUnit = newWeightUnit;
        }
    }

    public class InventoryAdjustmentDetailReferencesUpdatedEvent : DomainEvent
    {
        public InventoryAdjustmentDetail Detail { get; }
        public string? OldVendorCode { get; }
        public string? OldCostCenterCode { get; }
        public string? OldProjectNumber { get; }
        public string? OldActivityNumber { get; }
        public string? OldPostCode { get; }
        public short? OldDocumentTypeReference { get; }
        public long? OldDocumentNumberReference { get; }
        public long? OldDocumentSerialReference { get; }
        public int? OldDocumentSequenceReference { get; }
        public string? NewVendorCode { get; }
        public string? NewCostCenterCode { get; }
        public string? NewProjectNumber { get; }
        public string? NewActivityNumber { get; }
        public string? NewPostCode { get; }
        public short? NewDocumentTypeReference { get; }
        public long? NewDocumentNumberReference { get; }
        public long? NewDocumentSerialReference { get; }
        public int? NewDocumentSequenceReference { get; }

        public InventoryAdjustmentDetailReferencesUpdatedEvent(
            InventoryAdjustmentDetail detail,
            string? oldVendorCode,
            string? oldCostCenterCode,
            string? oldProjectNumber,
            string? oldActivityNumber,
            string? oldPostCode,
            short? oldDocumentTypeReference,
            long? oldDocumentNumberReference,
            long? oldDocumentSerialReference,
            int? oldDocumentSequenceReference,
            string? newVendorCode,
            string? newCostCenterCode,
            string? newProjectNumber,
            string? newActivityNumber,
            string? newPostCode,
            short? newDocumentTypeReference,
            long? newDocumentNumberReference,
            long? newDocumentSerialReference,
            int? newDocumentSequenceReference)
        {
            Detail = detail;
            OldVendorCode = oldVendorCode;
            OldCostCenterCode = oldCostCenterCode;
            OldProjectNumber = oldProjectNumber;
            OldActivityNumber = oldActivityNumber;
            OldPostCode = oldPostCode;
            OldDocumentTypeReference = oldDocumentTypeReference;
            OldDocumentNumberReference = oldDocumentNumberReference;
            OldDocumentSerialReference = oldDocumentSerialReference;
            OldDocumentSequenceReference = oldDocumentSequenceReference;
            NewVendorCode = newVendorCode;
            NewCostCenterCode = newCostCenterCode;
            NewProjectNumber = newProjectNumber;
            NewActivityNumber = newActivityNumber;
            NewPostCode = newPostCode;
            NewDocumentTypeReference = newDocumentTypeReference;
            NewDocumentNumberReference = newDocumentNumberReference;
            NewDocumentSerialReference = newDocumentSerialReference;
            NewDocumentSequenceReference = newDocumentSequenceReference;
        }
    }
} 