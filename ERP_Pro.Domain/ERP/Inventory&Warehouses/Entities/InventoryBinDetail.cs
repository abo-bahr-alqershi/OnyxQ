using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class InventoryBinDetail : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> كود الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? BinCode { get; private set; }
        /// <summary> اسم الـ BIN بالعربي. </summary>
        public string BinAName { get; private set; }
        /// <summary> اسم الـ BIN بالإنجليزي. </summary>
        public string? BinEName { get; private set; }
        /// <summary> علم الترحيل الخارجي. </summary>
        public int? ExternalPost { get; private set; }
        /// <summary> علم الموقع الافتراضي (1=نعم). </summary>
        public bool? DefaultFlag { get; private set; }
        public long? WarehouseCode { get; private set; }
        #endregion

        #region Location Info
        /// <summary> اسم الـ BIN بالعربي. </summary>
        public string BinName { get; private set; }
        /// <summary> اسم الـ BIN بالإنجليزي. </summary>
        public string? BinDescription { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Section { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Row { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Column { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Level { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Zone { get; private set; }
        /// <summary> اسم الموقع التخزيني داخل المستودع (BIN). </summary>
        public string? Area { get; private set; }
        #endregion

        #region Status
        public bool IsActive { get; private set; }
        public bool IsLocked { get; private set; }
        public bool IsTemporary { get; private set; }
        /// <summary> سعة الموقع أو عدد الوحدات الممكنة. </summary>
        public int? Capacity { get; private set; }
        /// <summary> الوزن المسموح للـ BIN. </summary>
        public int? Weight { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        /// <summary> الوزن المسموح للـ BIN. </summary>
        public int? CurrentOccupancy { get; private set; }
        /// <summary> الوزن المسموح للـ BIN. </summary>
        public int? MinimumThreshold { get; private set; }
        /// <summary> الوزن المسموح للـ BIN. </summary>
        public int? MaximumThreshold { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> المستخدم الذي أضاف السطر. </summary>
        public int? AddedByUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedByUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> أولوية التقرير. </summary>
        public int? ReportPriority { get; private set; }
        #endregion

        #region Navigation Properties
        public Warehouse Warehouse { get; private set; } // Navigation
        public ICollection<InventoryBin> InventoryBins { get; private set; } = new List<InventoryBin>(); // Inverse Navigation
        #endregion

        private InventoryBinDetail() { } // For EF Core

        public static InventoryBinDetail Create(
            string binCode,
            string binName,
            long warehouseCode,
            int userId,
            string terminal)
        {
            if (string.IsNullOrWhiteSpace(binCode))
                throw new DomainException("Bin code cannot be empty");
            if (string.IsNullOrWhiteSpace(binName))
                throw new DomainException("Bin name cannot be empty");

            var binDetail = new InventoryBinDetail
            {
                Id = Guid.NewGuid(),
                BinCode = binCode,
                BinName = binName,
                WarehouseCode = warehouseCode,
                IsActive = true,
                IsLocked = false,
                IsTemporary = false,
                AddedByUserId = userId,
                AddedDate = DateTime.UtcNow,
                AddedTerminal = terminal,
                UpdateCount = 0
            };

            binDetail.AddDomainEvent(new InventoryBinDetailCreatedEvent(binDetail));
            return binDetail;
        }

        public void UpdateDescription(string description)
        {
            var oldDescription = BinDescription;
            BinDescription = description;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailDescriptionUpdatedEvent(this, oldDescription, description));
        }

        public void UpdateLocation(
            string? section,
            string? row,
            string? column,
            string? level,
            string? zone,
            string? area)
        {
            var oldSection = Section;
            var oldRow = Row;
            var oldColumn = Column;
            var oldLevel = Level;
            var oldZone = Zone;
            var oldArea = Area;

            Section = section;
            Row = row;
            Column = column;
            Level = level;
            Zone = zone;
            Area = area;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailLocationUpdatedEvent(
                this, oldSection, oldRow, oldColumn, oldLevel, oldZone, oldArea,
                section, row, column, level, zone, area));
        }

        public void Activate()
        {
            if (IsActive)
                throw new DomainException("Bin is already active");

            IsActive = true;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailActivatedEvent(this));
        }

        public void Deactivate()
        {
            if (!IsActive)
                throw new DomainException("Bin is already inactive");

            IsActive = false;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailDeactivatedEvent(this));
        }

        public void Lock()
        {
            if (IsLocked)
                throw new DomainException("Bin is already locked");

            IsLocked = true;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailLockedEvent(this));
        }

        public void Unlock()
        {
            if (!IsLocked)
                throw new DomainException("Bin is already unlocked");

            IsLocked = false;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailUnlockedEvent(this));
        }

        public void UpdateCapacity(int capacity, int? minimumThreshold = null, int? maximumThreshold = null)
        {
            if (capacity < 0)
                throw new DomainException("Capacity cannot be negative");
            if (minimumThreshold.HasValue && minimumThreshold.Value < 0)
                throw new DomainException("Minimum threshold cannot be negative");
            if (maximumThreshold.HasValue && maximumThreshold.Value < 0)
                throw new DomainException("Maximum threshold cannot be negative");
            if (minimumThreshold.HasValue && maximumThreshold.HasValue && minimumThreshold.Value > maximumThreshold.Value)
                throw new DomainException("Minimum threshold cannot be greater than maximum threshold");

            var oldCapacity = Capacity;
            var oldMinThreshold = MinimumThreshold;
            var oldMaxThreshold = MaximumThreshold;

            Capacity = capacity;
            MinimumThreshold = minimumThreshold;
            MaximumThreshold = maximumThreshold;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailCapacityUpdatedEvent(
                this, oldCapacity, oldMinThreshold, oldMaxThreshold,
                capacity, minimumThreshold, maximumThreshold));
        }

        public void UpdateOccupancy(int occupancy)
        {
            if (occupancy < 0)
                throw new DomainException("Occupancy cannot be negative");
            if (Capacity.HasValue && occupancy > Capacity.Value)
                throw new DomainException("Occupancy cannot exceed capacity");

            var oldOccupancy = CurrentOccupancy;
            CurrentOccupancy = occupancy;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinDetailOccupancyUpdatedEvent(this, oldOccupancy, occupancy));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(BinCode))
                throw new DomainException("Bin code cannot be empty");

            if (string.IsNullOrWhiteSpace(BinName))
                throw new DomainException("Bin name cannot be empty");

            if (WarehouseCode <= 0)
                throw new DomainException("Warehouse code must be positive");

            if (Capacity.HasValue && Capacity.Value < 0)
                throw new DomainException("Capacity cannot be negative");

            if (CurrentOccupancy.HasValue && CurrentOccupancy.Value < 0)
                throw new DomainException("Current occupancy cannot be negative");

            if (MinimumThreshold.HasValue && MinimumThreshold.Value < 0)
                throw new DomainException("Minimum threshold cannot be negative");

            if (MaximumThreshold.HasValue && MaximumThreshold.Value < 0)
                throw new DomainException("Maximum threshold cannot be negative");

            if (MinimumThreshold.HasValue && MaximumThreshold.HasValue && MinimumThreshold.Value > MaximumThreshold.Value)
                throw new DomainException("Minimum threshold cannot be greater than maximum threshold");

            if (Capacity.HasValue && CurrentOccupancy.HasValue && CurrentOccupancy.Value > Capacity.Value)
                throw new DomainException("Current occupancy cannot exceed capacity");
        }
    }
}