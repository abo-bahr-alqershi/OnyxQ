using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record BranchInfo
    {
        /// <summary> رقم الفرع </summary>
        public int BranchId { get; }
        /// <summary> اسم الفرع </summary>
        public string BranchName { get; }
        /// <summary> رقم المستودع </summary>
        public int? WarehouseId { get; }
        /// <summary> اسم المستودع </summary>
        public string? WarehouseName { get; }
        /// <summary> رقم الصندوق </summary>
        public int? CashierId { get; }
        /// <summary> اسم الصندوق </summary>
        public string? CashierName { get; }

        private BranchInfo(
            int branchId,
            string branchName,
            int? warehouseId = null,
            string? warehouseName = null,
            int? cashierId = null,
            string? cashierName = null)
        {
            if (branchId <= 0)
                throw new DomainException("Branch ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new DomainException("Branch name is required");

            if (warehouseId.HasValue && warehouseId.Value <= 0)
                throw new DomainException("Warehouse ID must be greater than zero");

            if (cashierId.HasValue && cashierId.Value <= 0)
                throw new DomainException("Cashier ID must be greater than zero");

            BranchId = branchId;
            BranchName = branchName;
            WarehouseId = warehouseId;
            WarehouseName = warehouseName;
            CashierId = cashierId;
            CashierName = cashierName;
        }

        public static BranchInfo Create(
            int branchId,
            string branchName,
            int? warehouseId = null,
            string? warehouseName = null,
            int? cashierId = null,
            string? cashierName = null) =>
            new(branchId, branchName, warehouseId, warehouseName, cashierId, cashierName);
    }
} 