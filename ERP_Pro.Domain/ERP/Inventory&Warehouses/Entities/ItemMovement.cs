using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class ItemMovement : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        public DocumentNumber DocumentNumber { get; private set; }
        public DocumentType DocumentType { get; private set; }
        public DocumentType? BillDocumentType { get; private set; }
        public DateTime ItemDate { get; private set; }
        public string Description { get; private set; }
        public string ReferenceNumber { get; private set; }
        public long DocumentSerial { get; private set; }
        public long? DocumentSequence { get; private set; }
        #endregion

        #region Item Details
        public ItemCode ItemCode { get; private set; }
        public string Barcode { get; private set; }
        public ItemQuantity Quantity { get; private set; }
        public ItemQuantity FreeQuantity { get; private set; }
        public UnitMeasure ItemUnit { get; private set; }
        public PackageSize PackSize { get; private set; }
        public ItemQuantity PackQuantity { get; private set; }
        public ItemQuantity PartialFreeQuantity { get; private set; }
        public Money ItemCost { get; private set; }
        public ItemDimensions Dimensions { get; private set; }
        public Weight Weight { get; private set; }
        #endregion

        #region Location Info
        public WarehouseId WarehouseId { get; private set; }
        public WarehouseGroupId WarehouseGroupId { get; private set; }
        public BatchNumber BatchNumber { get; private set; }
        public DateTime ExpireDate { get; private set; }
        #endregion

        #region Financial Info
        public Money StockCost { get; private set; }
        public Money VatAmount { get; private set; }
        public Money DiscountAmount { get; private set; }
        public CurrencyCode CurrencyCode { get; private set; }
        public ExchangeRate AccountRate { get; private set; }
        public ExchangeRate StockRate { get; private set; }
        public DiscountInfo PrimaryDiscount { get; private set; }
        public DiscountInfo SecondaryDiscount { get; private set; }
        public DiscountInfo TertiaryDiscount { get; private set; }
        public Money OtherAmount { get; private set; }
        public Money VatAmountOther { get; private set; }
        public Percentage VatPercent { get; private set; }
        #endregion

        #region References
        public CostCenterCode CostCenterCode { get; private set; }
        public ProjectNumber ProjectNumber { get; private set; }
        public ActivityNumber ActivityNumber { get; private set; }
        public AccountDetailInfo AccountDetail { get; private set; }
        public CustomerCode CustomerCode { get; private set; }
        public VendorCode VendorCode { get; private set; }
        public GoodsReceiptInfo GoodsReceipt { get; private set; }
        public EmployeeNumber EmployeeNumber { get; private set; }
        #endregion

        #region Movement Info
        public MovementType MovementType { get; private set; }
        public bool? ReturnType { get; private set; }
        public int? ExternalPost { get; private set; }
        public int? Serial { get; private set; }
        public long? OutNumber { get; private set; }
        public long? OutGoodsReceiptSerial { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        public BranchInfo BranchInfo { get; private set; }
        #endregion

        #region Audit Info
        public DateTime? AddedDate { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Warehouse Warehouse { get; private set; }
        #endregion

        private ItemMovement() { }

        public static ItemMovement Create(
            DocumentType documentType,
            DocumentNumber documentNumber,
            ItemCode itemCode,
            ItemQuantity quantity,
            UnitMeasure itemUnit,
            WarehouseId warehouseId,
            DateTime itemDate,
            CompanyInfo companyInfo,
            BranchInfo branchInfo)
        {
            var movement = new ItemMovement
            {
                Id = Guid.NewGuid(),
                DocumentType = documentType,
                DocumentNumber = documentNumber,
                ItemCode = itemCode,
                Quantity = quantity,
                ItemUnit = itemUnit,
                WarehouseId = warehouseId,
                ItemDate = itemDate,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo
            };

            movement.AddDomainEvent(new ItemMovementCreatedEvent(movement));
            return movement;
        }

        public void UpdateQuantity(ItemQuantity newQuantity)
        {
            if (newQuantity.Value < 0)
                throw new DomainException("Quantity cannot be negative");

            var oldQuantity = Quantity;
            Quantity = newQuantity;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new ItemMovementQuantityUpdatedEvent(this, oldQuantity, newQuantity));
        }

        public void AddFreeQuantity(ItemQuantity freeQuantity)
        {
            if (freeQuantity.Value < 0)
                throw new DomainException("Free quantity cannot be negative");

            FreeQuantity = freeQuantity;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new ItemMovementFreeQuantityAddedEvent(this, freeQuantity));
        }

        public void UpdateCost(Money newCost)
        {
            if (newCost.Amount < 0)
                throw new DomainException("Cost cannot be negative");

            var oldCost = ItemCost;
            ItemCost = newCost;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new ItemMovementCostUpdatedEvent(this, oldCost, newCost));
        }

        public void ApplyDiscount(DiscountInfo discount)
        {
            if (discount.Percentage < 0 || discount.Percentage > 100)
                throw new DomainException("Discount percentage must be between 0 and 100");

            PrimaryDiscount = discount;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new ItemMovementDiscountAppliedEvent(this, discount));
        }

        public void SetBatchInfo(BatchNumber batchNumber, DateTime expireDate)
        {
            if (expireDate < ItemDate)
                throw new DomainException("Expiry date cannot be earlier than item date");

            BatchNumber = batchNumber;
            ExpireDate = expireDate;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new ItemMovementBatchInfoSetEvent(this, batchNumber, expireDate));
        }
    }
}