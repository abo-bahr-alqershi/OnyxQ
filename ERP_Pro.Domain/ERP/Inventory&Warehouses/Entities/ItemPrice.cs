using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemPrice : Entity
    {
        // Primary Key Components
        public int LevelNumber { get; private set; }
        public string ItemCode { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public decimal PackageSize { get; private set; }
        public int WarehouseCode { get; private set; }
        public string BatchNumber { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        
        // Price Info
        public decimal? FromQuantity { get; private set; }
        public decimal? ToQuantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal? DoctorPrice { get; private set; }
        public decimal? MinimumPrice { get; private set; }
        public decimal? MaximumPrice { get; private set; }
        public bool ImportFromExcel { get; private set; }
        
        // Branch Info
        public int BranchNumber { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public int? PrintReport { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }

        // Navigation Properties
        public virtual Item Item { get; private set; }
        public virtual UnitOfMeasure Unit { get; private set; }
        public virtual Warehouse Warehouse { get; private set; }

        private ItemPrice() { } // For EF Core

        public ItemPrice(
            int levelNumber,
            string itemCode,
            string unitOfMeasure,
            decimal packageSize,
            int warehouseCode,
            string batchNumber,
            DateTime expiryDate,
            decimal price,
            int branchNumber)
        {
            LevelNumber = levelNumber;
            ItemCode = itemCode;
            UnitOfMeasure = unitOfMeasure;
            PackageSize = packageSize;
            WarehouseCode = warehouseCode;
            BatchNumber = batchNumber;
            ExpiryDate = expiryDate;
            Price = price;
            BranchNumber = branchNumber;

            AddDomainEvent(new ItemPriceCreatedEvent(itemCode, levelNumber, price));
        }

        public void UpdatePrice(
            decimal price,
            decimal? doctorPrice = null,
            decimal? minimumPrice = null,
            decimal? maximumPrice = null)
        {
            var oldPrice = Price;
            Price = price;
            DoctorPrice = doctorPrice ?? DoctorPrice;
            MinimumPrice = minimumPrice ?? MinimumPrice;
            MaximumPrice = maximumPrice ?? MaximumPrice;

            AddDomainEvent(new ItemPriceUpdatedEvent(ItemCode, LevelNumber, oldPrice, price));
        }

        public void UpdateQuantityRange(decimal? fromQuantity, decimal? toQuantity)
        {
            FromQuantity = fromQuantity;
            ToQuantity = toQuantity;

            AddDomainEvent(new ItemPriceQuantityRangeUpdatedEvent(ItemCode, LevelNumber));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(ItemCode))
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(UnitOfMeasure))
                throw new DomainException("Unit of measure is required");

            if (PackageSize <= 0)
                throw new DomainException("Package size must be greater than zero");

            if (Price < 0)
                throw new DomainException("Price cannot be negative");

            if (FromQuantity.HasValue && ToQuantity.HasValue && FromQuantity > ToQuantity)
                throw new DomainException("From quantity cannot be greater than to quantity");

            if (MinimumPrice.HasValue && MaximumPrice.HasValue && MinimumPrice > MaximumPrice)
                throw new DomainException("Minimum price cannot be greater than maximum price");
        }
    }
} 