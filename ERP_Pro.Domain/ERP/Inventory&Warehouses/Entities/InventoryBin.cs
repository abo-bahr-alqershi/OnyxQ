using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class InventoryBin : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        public ItemCode ItemCode { get; private set; }
        public string ItemUnit { get; private set; }
        public int PackSize { get; private set; }
        public long WarehouseCode { get; private set; }
        public string BinCode { get; private set; }
        #endregion

        #region Batch Info
        public DateTime? ExpireDate { get; private set; }
        public string? BatchNumber { get; private set; }
        #endregion

        #region Status
        public bool DefaultFlag { get; private set; }
        public int? ExternalPost { get; private set; }
        #endregion

        #region Audit Info
        public int? AddedByUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedByUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long? UpdateCount { get; private set; }
        public long? ReportPriority { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Item Item { get; private set; }
        public virtual InventoryBinDetail InventoryBinDetail { get; private set; }
        #endregion

        private InventoryBin() { } // For EF Core

        public static InventoryBin Create(
            ItemCode itemCode,
            string itemUnit,
            int packSize,
            long warehouseCode,
            string binCode,
            int userId,
            string terminal)
        {
            if (string.IsNullOrWhiteSpace(binCode))
                throw new DomainException("Bin code cannot be empty");

            var bin = new InventoryBin
            {
                Id = Guid.NewGuid(),
                ItemCode = itemCode,
                ItemUnit = itemUnit,
                PackSize = packSize,
                WarehouseCode = warehouseCode,
                BinCode = binCode,
                DefaultFlag = false,
                AddedByUserId = userId,
                AddedDate = DateTime.UtcNow,
                AddedTerminal = terminal,
                UpdateCount = 0
            };

            bin.AddDomainEvent(new InventoryBinCreatedEvent(bin));
            return bin;
        }

        public void UpdateBatchInfo(string batchNumber, DateTime? expireDate)
        {
            var oldBatchNumber = BatchNumber;
            var oldExpireDate = ExpireDate;

            BatchNumber = batchNumber;
            ExpireDate = expireDate;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinBatchInfoUpdatedEvent(this, oldBatchNumber, oldExpireDate, batchNumber, expireDate));
        }

        public void SetAsDefault()
        {
            if (DefaultFlag)
                throw new DomainException("Bin is already set as default");

            DefaultFlag = true;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinSetAsDefaultEvent(this));
        }

        public void UnsetAsDefault()
        {
            if (!DefaultFlag)
                throw new DomainException("Bin is not set as default");

            DefaultFlag = false;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinUnsetAsDefaultEvent(this));
        }

        public void UpdateExternalPost(int externalPost)
        {
            var oldExternalPost = ExternalPost;
            ExternalPost = externalPost;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinExternalPostUpdatedEvent(this, oldExternalPost, externalPost));
        }

        public void UpdateReportPriority(long priority)
        {
            var oldPriority = ReportPriority;
            ReportPriority = priority;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new InventoryBinReportPriorityUpdatedEvent(this, oldPriority, priority));
        }

        private void ValidateState()
        {
            if (ItemCode == null)
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(ItemUnit))
                throw new DomainException("Item unit is required");

            if (PackSize <= 0)
                throw new DomainException("Pack size must be positive");

            if (WarehouseCode <= 0)
                throw new DomainException("Warehouse code must be positive");

            if (string.IsNullOrWhiteSpace(BinCode))
                throw new DomainException("Bin code cannot be empty");
        }
    }
}