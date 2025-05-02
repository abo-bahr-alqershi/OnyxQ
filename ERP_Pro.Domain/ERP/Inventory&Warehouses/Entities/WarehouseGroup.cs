using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class WarehouseGroup : AggregateRoot
    {
        // Primary Key
        public Guid Id { get; private set; }
        public long WarehouseGroupCode { get; private set; }
        
        // Basic Info
        public string WarehouseGroupArabicName { get; private set; }
        public string? WarehouseGroupEnglishName { get; private set; }
        public bool IsActive { get; private set; } = true;
        
        // Document Types
        public DocumentTypeInfo RequestType { get; private set; }
        public DocumentTypeInfo IncomingType { get; private set; }
        public DocumentTypeInfo OutgoingType { get; private set; }
        public DocumentTypeInfo TransferType { get; private set; }
        public DocumentTypeInfo StockType { get; private set; }
        public DocumentTypeInfo InventoryType { get; private set; }
        public DocumentTypeInfo PurchaseType { get; private set; }
        public DocumentTypeInfo PurchaseOrderType { get; private set; }
        public DocumentTypeInfo GoodsReceiptNoteType { get; private set; }
        
        // Settings
        public bool InventoryAccountingSystemPostDetail { get; private set; }
        public bool InventoryAccountingSystemCostCenterTree { get; private set; }
        public bool InventoryAccountingSystemBudgetBalanceDetail { get; private set; }
        public bool InventoryAccountingSystemAccountTree { get; private set; }
        public bool UserRestricted { get; private set; }
        public bool ShowMobileScreen { get; private set; }
        public bool CalculateTaxFreeQuantityFlag { get; private set; }
        public bool DocumentDateManual { get; private set; }
        public decimal LossQuantity { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }

        // Navigation Properties
        public virtual IReadOnlyCollection<Warehouse> Warehouses => _warehouses.AsReadOnly();
        public virtual IReadOnlyCollection<SalesDiscount> SalesDiscounts => _salesDiscounts.AsReadOnly();
        public virtual IReadOnlyCollection<SalesFreeQty> SalesFreeQties => _salesFreeQties.AsReadOnly();

        // Private Collections
        private readonly List<Warehouse> _warehouses = new();
        private readonly List<SalesDiscount> _salesDiscounts = new();
        private readonly List<SalesFreeQty> _salesFreeQties = new();

        // Constructors
        private WarehouseGroup() { } // For EF Core

        public WarehouseGroup(
            long groupCode,
            string arabicName,
            string? englishName = null)
        {
            Id = Guid.NewGuid();
            WarehouseGroupCode = groupCode;
            WarehouseGroupArabicName = arabicName;
            WarehouseGroupEnglishName = englishName;
            
            AddDomainEvent(new WarehouseGroupCreatedEvent(Id, groupCode, arabicName));
        }

        // Methods
        public void UpdateBasicInfo(
            string arabicName,
            string? englishName)
        {
            WarehouseGroupArabicName = arabicName;
            WarehouseGroupEnglishName = englishName;
            
            AddDomainEvent(new WarehouseGroupUpdatedEvent(Id));
        }

        public void Deactivate()
        {
            if (!IsActive) return;
            
            IsActive = false;
            AddDomainEvent(new WarehouseGroupDeactivatedEvent(Id));
        }

        public void Activate()
        {
            if (IsActive) return;
            
            IsActive = true;
            AddDomainEvent(new WarehouseGroupActivatedEvent(Id));
        }

        public void UpdateDocumentType(
            DocumentTypeCategory category,
            string code,
            string arabicName,
            string englishName)
        {
            var docType = new DocumentTypeInfo(code, arabicName, englishName);
            
            switch (category)
            {
                case DocumentTypeCategory.Request:
                    RequestType = docType;
                    break;
                case DocumentTypeCategory.Incoming:
                    IncomingType = docType;
                    break;
                case DocumentTypeCategory.Outgoing:
                    OutgoingType = docType;
                    break;
                case DocumentTypeCategory.Transfer:
                    TransferType = docType;
                    break;
                case DocumentTypeCategory.Stock:
                    StockType = docType;
                    break;
                case DocumentTypeCategory.Inventory:
                    InventoryType = docType;
                    break;
                case DocumentTypeCategory.Purchase:
                    PurchaseType = docType;
                    break;
                case DocumentTypeCategory.PurchaseOrder:
                    PurchaseOrderType = docType;
                    break;
                case DocumentTypeCategory.GoodsReceiptNote:
                    GoodsReceiptNoteType = docType;
                    break;
                default:
                    throw new DomainException("Invalid document type category");
            }
            
            AddDomainEvent(new WarehouseGroupDocumentTypeUpdatedEvent(Id, category));
        }

        public void UpdateSettings(
            bool postDetail,
            bool costCenterTree,
            bool budgetBalanceDetail,
            bool accountTree,
            bool userRestricted,
            bool showMobileScreen,
            bool calculateTaxFreeQuantity,
            bool documentDateManual,
            decimal lossQuantity)
        {
            InventoryAccountingSystemPostDetail = postDetail;
            InventoryAccountingSystemCostCenterTree = costCenterTree;
            InventoryAccountingSystemBudgetBalanceDetail = budgetBalanceDetail;
            InventoryAccountingSystemAccountTree = accountTree;
            UserRestricted = userRestricted;
            ShowMobileScreen = showMobileScreen;
            CalculateTaxFreeQuantityFlag = calculateTaxFreeQuantity;
            DocumentDateManual = documentDateManual;
            LossQuantity = lossQuantity;
            
            AddDomainEvent(new WarehouseGroupSettingsUpdatedEvent(Id));
        }

        // Helper Methods
        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(WarehouseGroupArabicName))
                throw new DomainException("Warehouse group Arabic name is required");
                
            if (WarehouseGroupCode <= 0)
                throw new DomainException("Invalid warehouse group code");
        }
    }

    public class DocumentTypeInfo
    {
        public string Code { get; private set; }
        public string ArabicName { get; private set; }
        public string EnglishName { get; private set; }

        public DocumentTypeInfo(string code, string arabicName, string englishName)
        {
            Code = code;
            ArabicName = arabicName;
            EnglishName = englishName;
        }
    }

    public enum DocumentTypeCategory
    {
        Request,
        Incoming,
        Outgoing,
        Transfer,
        Stock,
        Inventory,
        Purchase,
        PurchaseOrder,
        GoodsReceiptNote
    }
}