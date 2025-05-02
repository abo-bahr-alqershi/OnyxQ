using System;
using ERP_Pro.Domain.Common;
using MediatR;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects
{
    public record ItemQuantities
    {
        public int? AvailableQuantity { get; }
        public int? PlusMinus { get; }
        public int? PackQuantity { get; }
        public int? ManualPackQuantity { get; }
        public int? ManualAvailablePackQuantity { get; }
        public int? IncreaseQuantity { get; }
        public int? BalanceQuantity { get; }

        private ItemQuantities(
            int? availableQuantity,
            int? plusMinus,
            int? packQuantity,
            int? manualPackQuantity,
            int? manualAvailablePackQuantity,
            int? increaseQuantity,
            int? balanceQuantity)
        {
            AvailableQuantity = availableQuantity;
            PlusMinus = plusMinus;
            PackQuantity = packQuantity;
            ManualPackQuantity = manualPackQuantity;
            ManualAvailablePackQuantity = manualAvailablePackQuantity;
            IncreaseQuantity = increaseQuantity;
            BalanceQuantity = balanceQuantity;
        }

        public static ItemQuantities Create(
            int? availableQuantity = null,
            int? plusMinus = null,
            int? packQuantity = null,
            int? manualPackQuantity = null,
            int? manualAvailablePackQuantity = null,
            int? increaseQuantity = null,
            int? balanceQuantity = null) =>
            new(availableQuantity, plusMinus, packQuantity, manualPackQuantity,
                manualAvailablePackQuantity, increaseQuantity, balanceQuantity);
    }

    public record ItemCosts
    {
        public int? WeightedAverage { get; }
        public int? PurchaseInvoicePrice { get; }
        public int? PurchaseInvoiceQuantity { get; }
        public int? PreviousInvoiceQuantity { get; }
        public int? BillDiscount { get; }
        public int? IncreaseCost { get; }
        public int? RealCost { get; }

        private ItemCosts(
            int? weightedAverage,
            int? purchaseInvoicePrice,
            int? purchaseInvoiceQuantity,
            int? previousInvoiceQuantity,
            int? billDiscount,
            int? increaseCost,
            int? realCost)
        {
            WeightedAverage = weightedAverage;
            PurchaseInvoicePrice = purchaseInvoicePrice;
            PurchaseInvoiceQuantity = purchaseInvoiceQuantity;
            PreviousInvoiceQuantity = previousInvoiceQuantity;
            BillDiscount = billDiscount;
            IncreaseCost = increaseCost;
            RealCost = realCost;
        }

        public static ItemCosts Create(
            int? weightedAverage = null,
            int? purchaseInvoicePrice = null,
            int? purchaseInvoiceQuantity = null,
            int? previousInvoiceQuantity = null,
            int? billDiscount = null,
            int? increaseCost = null,
            int? realCost = null) =>
            new(weightedAverage, purchaseInvoicePrice, purchaseInvoiceQuantity,
                previousInvoiceQuantity, billDiscount, increaseCost, realCost);
    }

    public record ItemDimensions
    {
        public int? Length { get; }
        public int? Width { get; }
        public int? Height { get; }
        public int? Number { get; }
        public int? WeightQuantity { get; }
        public string? WeightUnit { get; }

        private ItemDimensions(
            int? length,
            int? width,
            int? height,
            int? number,
            int? weightQuantity,
            string? weightUnit)
        {
            if (length.HasValue && length.Value < 0)
                throw new DomainException("Length cannot be negative");
            if (width.HasValue && width.Value < 0)
                throw new DomainException("Width cannot be negative");
            if (height.HasValue && height.Value < 0)
                throw new DomainException("Height cannot be negative");
            if (weightQuantity.HasValue && weightQuantity.Value < 0)
                throw new DomainException("Weight quantity cannot be negative");

            Length = length;
            Width = width;
            Height = height;
            Number = number;
            WeightQuantity = weightQuantity;
            WeightUnit = weightUnit;
        }

        public static ItemDimensions Create(
            int? length = null,
            int? width = null,
            int? height = null,
            int? number = null,
            int? weightQuantity = null,
            string? weightUnit = null) =>
            new(length, width, height, number, weightQuantity, weightUnit);
    }

    public record ReferenceInfo
    {
        public string? VendorCode { get; }
        public string? CostCenterCode { get; }
        public string? ProjectNumber { get; }
        public string? ActivityNumber { get; }
        public string? PostCode { get; }
        public short? DocumentTypeReference { get; }
        public long? DocumentNumberReference { get; }
        public long? DocumentSerialReference { get; }
        public int? DocumentSequenceReference { get; }

        private ReferenceInfo(
            string? vendorCode,
            string? costCenterCode,
            string? projectNumber,
            string? activityNumber,
            string? postCode,
            short? documentTypeReference,
            long? documentNumberReference,
            long? documentSerialReference,
            int? documentSequenceReference)
        {
            VendorCode = vendorCode;
            CostCenterCode = costCenterCode;
            ProjectNumber = projectNumber;
            ActivityNumber = activityNumber;
            PostCode = postCode;
            DocumentTypeReference = documentTypeReference;
            DocumentNumberReference = documentNumberReference;
            DocumentSerialReference = documentSerialReference;
            DocumentSequenceReference = documentSequenceReference;
        }

        public static ReferenceInfo Create(
            string? vendorCode = null,
            string? costCenterCode = null,
            string? projectNumber = null,
            string? activityNumber = null,
            string? postCode = null,
            short? documentTypeReference = null,
            long? documentNumberReference = null,
            long? documentSerialReference = null,
            int? documentSequenceReference = null) =>
            new(vendorCode, costCenterCode, projectNumber, activityNumber,
                postCode, documentTypeReference, documentNumberReference,
                documentSerialReference, documentSequenceReference);
    }

    public record BatchInfo
    {
        public string? BatchNumber { get; }
        public DateTime? ExpireDate { get; }
        public string? Barcode { get; }

        private BatchInfo(string? batchNumber, DateTime? expireDate, string? barcode)
        {
            BatchNumber = batchNumber;
            ExpireDate = expireDate;
            Barcode = barcode;
        }

        public static BatchInfo Create(
            string? batchNumber = null,
            DateTime? expireDate = null,
            string? barcode = null) =>
            new(batchNumber, expireDate, barcode);
    }

    public static class InventoryValidationRules
    {
        public static void ValidateAdjustmentQuantities(ItemQuantity newQuantity, ItemQuantity available)
        public static void ValidateBatchExpiration(DateTime expireDate, DateTime currentDate)
        public static void ValidateStockReservation(ItemQuantity requested, ItemQuantity available)
    }

    public record InventoryStatusQuery
    {
        public string ItemCode { get; init; }
        public string? WarehouseCode { get; init; }
        public DateTime? AsOfDate { get; init; }
    }

    public record StockMovementQuery
    {
        public string ItemCode { get; init; }
        public DateTime FromDate { get; init; }
        public DateTime ToDate { get; init; }
        public string? MovementType { get; init; }
    }

    public record WarehouseLocation
    {
        public string Code { get; }
        public string Name { get; }
        public string? Description { get; }
        public bool IsActive { get; }
        // Add validation and factory methods
    }

    public record StorageZone
    {
        public string Code { get; }
        public string Name { get; }
        public int? Capacity { get; }
        public string? ZoneType { get; }
        // Add validation and factory methods
    }

    public record ReorderPoint
    {
        public int MinimumQuantity { get; }
        public int MaximumQuantity { get; }
        public int ReorderQuantity { get; }
    }

    public record StockRotationPolicy
    {
        public string Method { get; } // FIFO, LIFO, etc.
        public int? MaximumShelfLife { get; }
        public bool RequiresBatchTracking { get; }
    }

    public record CreateInventoryAdjustmentCommand
    {
        public short AdjustmentType { get; }
        public DateTime DocumentDate { get; }
        public string? Description { get; }
        public List<AdjustmentDetailDto> Details { get; }
    }

    public record UpdateStockCountCommand
    {
        public Guid StockCountId { get; }
        public StockQuantities NewQuantities { get; }
        public SaleMetrics NewMetrics { get; }
    }

    public interface IInventoryValuationService
    {
        Money CalculateWeightedAverageCost(ItemCode itemCode);
        Money CalculateFIFOCost(ItemCode itemCode, BatchNumber batchNumber);
        Money CalculateLIFOCost(ItemCode itemCode, BatchNumber batchNumber);
    }

    public interface IStockReservationService
    {
        Task<bool> ReserveStockAsync(ItemCode itemCode, int quantity);
        Task ReleaseReservationAsync(Guid reservationId);
    }

    public class InventoryAdjustmentEventHandler : 
        INotificationHandler<InventoryAdjustmentCreatedEvent>,
        INotificationHandler<InventoryAdjustmentPostedEvent>
    {
        // Implement handlers for inventory adjustment events
    }

    public class StockCountEventHandler :
        INotificationHandler<StockCountCreatedEvent>,
        INotificationHandler<StockCountProcessedEvent>
    {
        // Implement handlers for stock count events
    }
} 