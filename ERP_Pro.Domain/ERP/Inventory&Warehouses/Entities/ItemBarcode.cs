using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemBarcode : Entity
    {
        // Primary Key
        public string ItemCode { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public decimal PackageSize { get; private set; }
        public string Barcode { get; private set; }
        
        // Additional Info
        public string? BatchNumber { get; private set; }
        public DateTime? ExpiryDate { get; private set; }
        public bool NoSale { get; private set; }
        public bool NoPrint { get; private set; }
        public decimal? FlexNumber { get; private set; }
        public bool DealWithPurchaseFlag { get; private set; }
        public string? BarcodeLocalDescription { get; private set; }
        public string? BarcodeForeignDescription { get; private set; }
        public bool IsMainBarcode { get; private set; }
        
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

        private ItemBarcode() { } // For EF Core

        public ItemBarcode(
            string itemCode,
            string unitOfMeasure,
            decimal packageSize,
            string barcode,
            bool isMainBarcode = false)
        {
            ItemCode = itemCode;
            UnitOfMeasure = unitOfMeasure;
            PackageSize = packageSize;
            Barcode = barcode;
            IsMainBarcode = isMainBarcode;

            AddDomainEvent(new ItemBarcodeCreatedEvent(itemCode, barcode));
        }

        public void UpdateBarcodeInfo(
            string? batchNumber = null,
            DateTime? expiryDate = null,
            bool? noSale = null,
            bool? noPrint = null,
            decimal? flexNumber = null)
        {
            BatchNumber = batchNumber ?? BatchNumber;
            ExpiryDate = expiryDate ?? ExpiryDate;
            NoSale = noSale ?? NoSale;
            NoPrint = noPrint ?? NoPrint;
            FlexNumber = flexNumber ?? FlexNumber;

            AddDomainEvent(new ItemBarcodeUpdatedEvent(ItemCode, Barcode));
        }

        public void UpdateDescriptions(
            string? localDescription = null,
            string? foreignDescription = null)
        {
            BarcodeLocalDescription = localDescription ?? BarcodeLocalDescription;
            BarcodeForeignDescription = foreignDescription ?? BarcodeForeignDescription;

            AddDomainEvent(new ItemBarcodeDescriptionsUpdatedEvent(ItemCode, Barcode));
        }

        public void SetAsMainBarcode()
        {
            if (IsMainBarcode) return;

            IsMainBarcode = true;
            AddDomainEvent(new ItemBarcodeSetAsMainEvent(ItemCode, Barcode));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(ItemCode))
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(UnitOfMeasure))
                throw new DomainException("Unit of measure is required");

            if (PackageSize <= 0)
                throw new DomainException("Package size must be greater than zero");

            if (string.IsNullOrWhiteSpace(Barcode))
                throw new DomainException("Barcode is required");
        }
    }
} 