using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class Warehouse : AggregateRoot
    {
        // Primary Key
        public Guid Id { get; private set; }
        public long WarehouseCode { get; private set; }
        
        // Basic Info
        public string WarehouseArabicName { get; private set; }
        public string? WarehouseEnglishName { get; private set; }
        public string? Location { get; private set; }
        public string? TelephoneNumber { get; private set; }
        public bool IsActive { get; private set; } = true;
        
        // Warehouse Configuration
        public string? WarehouseKeeper { get; private set; }
        public Guid WarehouseGroupId { get; private set; }
        public WarehouseType Type { get; private set; }
        public bool UseBillOfEntry { get; private set; }
        public bool AllowSales { get; private set; } = true;
        public bool CheckAvailableQuantity { get; private set; }
        
        // Location Info
        public string? GeographicPosition { get; private set; }
        public string? Latitude { get; private set; }
        public string? Longitude { get; private set; }
        public string? GlobalLocationNumber { get; private set; }
        public string? WarehouseLocalAddress { get; private set; }
        public string? WarehouseForeignAddress { get; private set; }
        
        // References
        public string? TransferAccountId { get; private set; }
        public string? CostCenterId { get; private set; }
        public Guid? CountryId { get; private set; }
        public Guid? ProvinceId { get; private set; }
        public Guid? CityId { get; private set; }
        public Guid? RegionId { get; private set; }
        
        // Operational Settings
        public bool UseAutoReceiveWarehouseTransfer { get; private set; }
        public int PriceLevel { get; private set; }
        public bool IsServiceWarehouse { get; private set; }
        public decimal WarehouseCostLimit { get; private set; }
        public bool ForDamagedItems { get; private set; }
        public bool UseBinManagement { get; private set; }
        
        // Additional Info (Value Objects)
        public WarehouseOperationalInfo OperationalInfo { get; private set; }
        public WarehouseBusinessInfo BusinessInfo { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }
        public int? PrintReport { get; private set; } // PR_REP field

        // Navigation Properties
        public virtual WarehouseGroup WarehouseGroup { get; private set; }
        public virtual Account TransferAccount { get; private set; }
        public virtual CostCenter CostCenter { get; private set; }
        public virtual Country Country { get; private set; }
        public virtual Province Province { get; private set; }
        public virtual City City { get; private set; }
        public virtual Region Region { get; private set; }

        // Collections
        public virtual IReadOnlyCollection<InventoryBinDetail> InventoryBinDetails => _inventoryBinDetails.AsReadOnly();
        public virtual IReadOnlyCollection<ItemMovement> ItemMovements => _itemMovements.AsReadOnly();
        public virtual IReadOnlyCollection<ItemPrice> ItemPrices => _itemPrices.AsReadOnly();
        public virtual IReadOnlyCollection<WarehousePrivilege> Privileges => _privileges.AsReadOnly();

        // Private Collections
        private readonly List<InventoryBinDetail> _inventoryBinDetails = new();
        private readonly List<ItemMovement> _itemMovements = new();
        private readonly List<ItemPrice> _itemPrices = new();
        private readonly List<WarehousePrivilege> _privileges = new();

        // Constructors
        private Warehouse() { } // For EF Core

        public Warehouse(
            long warehouseCode,
            string arabicName,
            Guid warehouseGroupId,
            WarehouseType type,
            WarehouseOperationalInfo operationalInfo,
            WarehouseBusinessInfo businessInfo)
        {
            Id = Guid.NewGuid();
            WarehouseCode = warehouseCode;
            WarehouseArabicName = arabicName;
            WarehouseGroupId = warehouseGroupId;
            Type = type;
            OperationalInfo = operationalInfo;
            BusinessInfo = businessInfo;
            
            AddDomainEvent(new WarehouseCreatedEvent(Id, warehouseCode, arabicName));
        }

        // Methods
        public void UpdateBasicInfo(
            string arabicName,
            string? englishName,
            string? location,
            string? telephone)
        {
            WarehouseArabicName = arabicName;
            WarehouseEnglishName = englishName;
            Location = location;
            TelephoneNumber = telephone;
            
            AddDomainEvent(new WarehouseUpdatedEvent(Id));
        }

        public void UpdateOperationalInfo(WarehouseOperationalInfo operationalInfo)
        {
            OperationalInfo = operationalInfo;
            AddDomainEvent(new WarehouseOperationalInfoUpdatedEvent(Id));
        }

        public void UpdateBusinessInfo(WarehouseBusinessInfo businessInfo)
        {
            BusinessInfo = businessInfo;
            AddDomainEvent(new WarehouseBusinessInfoUpdatedEvent(Id));
        }

        public void Deactivate()
        {
            if (!IsActive) return;
            
            IsActive = false;
            AddDomainEvent(new WarehouseDeactivatedEvent(Id));
        }

        public void Activate()
        {
            if (IsActive) return;
            
            IsActive = true;
            AddDomainEvent(new WarehouseActivatedEvent(Id));
        }

        public void UpdateLocation(
            string? latitude,
            string? longitude,
            string? gln,
            string? localAddress,
            string? foreignAddress)
        {
            Latitude = latitude;
            Longitude = longitude;
            GlobalLocationNumber = gln;
            WarehouseLocalAddress = localAddress;
            WarehouseForeignAddress = foreignAddress;
            
            AddDomainEvent(new WarehouseLocationUpdatedEvent(Id));
        }

        public void UpdateOperationalSettings(
            bool useAutoReceive,
            int priceLevel,
            bool isService,
            decimal costLimit,
            bool forDamaged,
            bool useBin)
        {
            UseAutoReceiveWarehouseTransfer = useAutoReceive;
            PriceLevel = priceLevel;
            IsServiceWarehouse = isService;
            WarehouseCostLimit = costLimit;
            ForDamagedItems = forDamaged;
            UseBinManagement = useBin;
            
            AddDomainEvent(new WarehouseSettingsUpdatedEvent(Id));
        }

        // Helper Methods
        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(WarehouseArabicName))
                throw new DomainException("Warehouse Arabic name is required");
                
            if (WarehouseCode <= 0)
                throw new DomainException("Invalid warehouse code");
        }
    }

    public enum WarehouseType
    {
        Regular = 0,
        Transit = 1,
        Virtual = 2,
        Service = 3
    }
}