using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class Item : AggregateRoot
    {
        // Primary Key and Basic Info
        public string ItemCode { get; private set; }
        public string ItemArabicName { get; private set; }
        public string? ItemEnglishName { get; private set; }
        public string GroupCode { get; private set; }
        public string? GroupClassCode { get; private set; }
        public string? ManagementCode { get; private set; }
        public string? SubGroupCode { get; private set; }
        
        // Item Properties
        public decimal? ItemSize { get; private set; }
        public int? ItemType { get; private set; }
        public decimal? PrimaryCost { get; private set; }
        public decimal? WeightedAverageCost { get; private set; }
        public string? Description { get; private set; }
        public string? AlternativeCode { get; private set; }
        public string? ManufacturerCode { get; private set; }
        
        // Status Flags
        public bool IsBlocked { get; private set; }
        public bool IsInactive { get; private set; }
        public string? InactiveReason { get; private set; }
        public DateTime? InactiveDate { get; private set; }
        public int? InactiveUserId { get; private set; }
        
        // Item Type Flags
        public bool IsServiceItem { get; private set; }
        public bool IsCashSale { get; private set; }
        public bool NoReturnSale { get; private set; }
        public int? ReturnPeriod { get; private set; }
        public bool IsKitItem { get; private set; }
        
        // Tracking Flags
        public bool UseExpiryDate { get; private set; }
        public bool UseBatchNumber { get; private set; }
        public bool UseSerialNumber { get; private set; }
        public bool UseAttachment { get; private set; }
        
        // Tax and Discount
        public int? VatType { get; private set; }
        public decimal? VatPercentage { get; private set; }
        public bool AllowDiscount { get; private set; }
        public decimal? DiscountPercentage { get; private set; }
        public bool AllowDiscountPurchaseInvoice { get; private set; }
        public bool IsRestrictedItem { get; private set; }
        public decimal? DiscountPercentagePurchaseInvoice { get; private set; }
        
        // Quantity Settings
        public bool AllowFreeQuantity { get; private set; }
        public decimal? FreeQuantityPercentage { get; private set; }
        public bool UseQuantityFraction { get; private set; }
        public bool AllowUnderSelling { get; private set; }
        
        // Classification
        public int? GroupNumber { get; private set; }
        public int? ItemLevel { get; private set; }
        
        // Additional Info
        public string? ImagePath { get; private set; }
        public int? DaysToExpire { get; private set; }
        public decimal? MinimumLimitCostPercentage { get; private set; }
        public decimal? MaximumLimitCostPercentage { get; private set; }
        
        // Custom Fields
        public string? Field1 { get; private set; }
        public string? Field2 { get; private set; }
        public string? Field3 { get; private set; }
        public string? Field4 { get; private set; }
        public string? Field5 { get; private set; }
        public string? Field6 { get; private set; }
        public string? Field7 { get; private set; }
        public string? Field8 { get; private set; }
        public string? Field9 { get; private set; }
        public string? Field10 { get; private set; }
        
        // References
        public string? AssistantNumber { get; private set; }
        public string? DetailNumber { get; private set; }
        
        // Physical Properties
        public decimal? Length { get; private set; }
        public decimal? Width { get; private set; }
        public decimal? Height { get; private set; }
        public decimal? Size { get; private set; }
        public decimal? Area { get; private set; }
        public decimal? Weight { get; private set; }
        
        // Item Details
        public string? Season { get; private set; }
        public string? Origin { get; private set; }
        public string? Mark { get; private set; }
        public string? Company { get; private set; }
        public string? Country { get; private set; }
        public DateTime? IncomeDate { get; private set; }
        
        // Business Rules
        public bool IsRequirement { get; private set; }
        public bool IsItemStore { get; private set; }
        public bool IsAsset { get; private set; }
        public bool HasCommission { get; private set; }
        public int? CommissionType { get; private set; }
        public decimal? CommissionAmount { get; private set; }
        
        // References
        public int? ActivityNumber { get; private set; }
        public string? VendorCode { get; private set; }
        public string? VendorCurrency { get; private set; }
        public decimal? VendorPrice { get; private set; }
        public string? VendorItemCode { get; private set; }
        
        // System Settings
        public int? HotKey { get; private set; }
        public int? LowLimitPrintFirst { get; private set; }
        public int? LowLimitPrintSecond { get; private set; }
        public int? LowLimitApprovedRequestAttachment { get; private set; }
        public int? LowLimitNotApprovedRequestAttachment { get; private set; }
        public bool ImportFromExcel { get; private set; }
        
        // Document References
        public int? DocumentTypeReference { get; private set; }
        public int? DocumentNumberReference { get; private set; }
        public long? DocumentSerialReference { get; private set; }
        
        // Additional Properties
        public bool IsWeighted { get; private set; }
        public int? BalanceNumber { get; private set; }
        public int? ReturnItemBeforeExpiryPeriod { get; private set; }
        public string? MeasurementUnitReport { get; private set; }
        public int? PurchaseInvoiceBillNumber { get; private set; }
        public bool UseGrant { get; private set; }
        public int? GrantPeriod { get; private set; }
        
        // Item Characteristics
        public string? Color { get; private set; }
        public string? Measure { get; private set; }
        public bool UseWeight { get; private set; }
        public bool ConnectItemSalesOrderIncome { get; private set; }
        public string? BrochureLink { get; private set; }
        public string? YoutubeLink { get; private set; }
        
        // Additional Flags
        public bool UseEmployeeFlag { get; private set; }
        public bool AlternativeMultipleFlag { get; private set; }
        public string? ForeignDescription { get; private set; }
        public bool IsRestaurantComboItem { get; private set; }
        public bool IsUsedItem { get; private set; }
        public bool IsMRPItem { get; private set; }
        public int? MRPItemClass { get; private set; }
        public int? CostPercentage { get; private set; }
        public decimal? ProfitMarginPercentage { get; private set; }
        public bool CheckAvailableQuantityInReservation { get; private set; }
        
        // Food Service
        public string? FoodGroupNumber { get; private set; }
        public bool UseAutoPostRMSDataToInventory { get; private set; }
        public bool IsHPSItem { get; private set; }
        public bool IsGenericItem { get; private set; }
        public int? ProcedureType { get; private set; }
        
        // Cost Information
        public string? HSNCode { get; private set; }
        public decimal? StandardCost { get; private set; }
        public decimal? LastProductionCost { get; private set; }
        public int? ItemOrderNumber { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public int? PrintReport { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }
        
        // Short Names
        public string? ShortLocalName { get; private set; }
        public string? ShortForeignName { get; private set; }
        
        // Quantity Limits
        public decimal? MinimumQuantity { get; private set; }
        public decimal? MaximumQuantity { get; private set; }
        
        // Additional Classifications
        public string? SubFoodGroupNumber { get; private set; }
        public int? SampleType { get; private set; }
        
        // Service Flags
        public bool IsRentalService { get; private set; }
        public bool PostWithAdmit { get; private set; }
        public bool PostWithRent { get; private set; }
        public bool HasPercentage { get; private set; }
        public bool IsBirthService { get; private set; }
        public bool IsEquipmentService { get; private set; }
        public int? SurgeryClass { get; private set; }
        public decimal? ServiceSort { get; private set; }
        
        // Additional Service Flags
        public bool IsCssdFlag { get; private set; }
        public bool IsLaundryFlag { get; private set; }
        public bool UseQRCode { get; private set; }
        
        // Quantity Thresholds
        public decimal? MinimumLimitQuantity { get; private set; }
        public decimal? MaximumLimitQuantity { get; private set; }
        public decimal? ReorderLevelQuantity { get; private set; }
        public decimal? DefaultAssemblyOrderQuantity { get; private set; }
        
        // RMS Integration
        public bool FillItemComponentInRMSInvoice { get; private set; }
        public bool UsePriceExpiryDateOptional { get; private set; }
        public bool UsePriceBatchNumberOptional { get; private set; }
        
        // Additional References
        public string? PurchaseServiceAccountCode { get; private set; }
        
        // Additional Flags
        public bool IsFeedItem { get; private set; }
        public bool IsInsuranceFlag { get; private set; }
        
        // Tracking
        public string? GTINCode { get; private set; }
        public bool UseSerialNumberType { get; private set; }
        public bool UseQRCodeType { get; private set; }
        public int? QRCodeMethodNumber { get; private set; }
        public bool UseBatchNumberAutoSequence { get; private set; }
        public int? BatchNumberMethodNumberSequence { get; private set; }
        
        // Service Level
        public decimal? ExecutionTAT { get; private set; }
        public int? ExecutionTATUnit { get; private set; }
        public bool HideItemChiefScreen { get; private set; }
        
        // Kit Item Settings
        public int? KitItemClassificationType { get; private set; }
        public int? StatisticalClass { get; private set; }
        public bool GetAvailableQuantityFromComponent { get; private set; }
        public decimal? KitItemRank { get; private set; }
        
        // Additional Settings
        public decimal? LimitQuantitySaleCost { get; private set; }
        public int? WeightValueItem { get; private set; }
        public bool UseItemInCSSSystem { get; private set; }
        public decimal? InitialPrimaryCost { get; private set; }
        public bool CheckItemPiecesMandatory { get; private set; }
        public decimal? ExcessPercentage { get; private set; }
        public bool UsedInKitItem { get; private set; }
        public bool IsMWSCheck { get; private set; }
        public int? DefaultTimeMinutes { get; private set; }
        public decimal? LostPercentageInPurchase { get; private set; }

        // Navigation Properties
        public virtual ItemGroup ItemGroup { get; private set; }
        public virtual IReadOnlyCollection<ItemPrice> ItemPrices => _itemPrices.AsReadOnly();
        public virtual IReadOnlyCollection<ItemMovement> ItemMovements => _itemMovements.AsReadOnly();
        public virtual IReadOnlyCollection<ItemBarcode> Barcodes => _barcodes.AsReadOnly();
        public virtual IReadOnlyCollection<ItemBatch> Batches => _batches.AsReadOnly();

        // Private Collections
        private readonly List<ItemPrice> _itemPrices = new();
        private readonly List<ItemMovement> _itemMovements = new();
        private readonly List<ItemBarcode> _barcodes = new();
        private readonly List<ItemBatch> _batches = new();

        private Item() { } // For EF Core

        public Item(
            string itemCode,
            string arabicName,
            string groupCode,
            bool isServiceItem = false)
        {
            ItemCode = itemCode;
            ItemArabicName = arabicName;
            GroupCode = groupCode;
            IsServiceItem = isServiceItem;

            AddDomainEvent(new ItemCreatedEvent(ItemCode, arabicName));
        }

        public void UpdateBasicInfo(
            string arabicName,
            string? englishName = null,
            string? description = null,
            string? alternativeCode = null)
        {
            ItemArabicName = arabicName;
            ItemEnglishName = englishName;
            Description = description;
            AlternativeCode = alternativeCode;

            AddDomainEvent(new ItemUpdatedEvent(ItemCode));
        }

        public void UpdateCosts(
            decimal? primaryCost = null,
            decimal? weightedAverageCost = null,
            decimal? standardCost = null,
            decimal? lastProductionCost = null)
        {
            PrimaryCost = primaryCost ?? PrimaryCost;
            WeightedAverageCost = weightedAverageCost ?? WeightedAverageCost;
            StandardCost = standardCost ?? StandardCost;
            LastProductionCost = lastProductionCost ?? LastProductionCost;

            AddDomainEvent(new ItemCostsUpdatedEvent(ItemCode));
        }

        public void Deactivate(string reason, int userId)
        {
            if (IsInactive) return;

            IsInactive = true;
            InactiveReason = reason;
            InactiveDate = DateTime.UtcNow;
            InactiveUserId = userId;

            AddDomainEvent(new ItemDeactivatedEvent(ItemCode, reason));
        }

        public void Activate()
        {
            if (!IsInactive) return;

            IsInactive = false;
            InactiveReason = null;
            InactiveDate = null;
            InactiveUserId = null;

            AddDomainEvent(new ItemActivatedEvent(ItemCode));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(ItemCode))
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(ItemArabicName))
                throw new DomainException("Item Arabic name is required");

            if (string.IsNullOrWhiteSpace(GroupCode))
                throw new DomainException("Group code is required");
        }
    }
} 