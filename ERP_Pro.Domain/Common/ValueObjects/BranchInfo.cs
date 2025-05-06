using System;
using ERP_Pro.Domain.Common.Exceptions;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record BranchInfo
    {
        /// <summary> رقم الفرع </summary>
        public int BranchId { get; init; }
        /// <summary> اسم الفرع </summary>
        public string BranchName { get; init; }
        /// <summary> رقم المستودع </summary>
        public int? WarehouseId { get; init; }
        /// <summary> اسم المستودع </summary>
        public string? WarehouseName { get; init; }
        /// <summary> رقم الصندوق </summary>
        public int? CashierId { get; init; }
        /// <summary> اسم الصندوق </summary>
        public string? CashierName { get; init; }

        private BranchInfo(
            int branchId,
            string branchName,
            int? warehouseId = null,
            string? warehouseName = null,
            int? cashierId = null,
            string? cashierName = null)
        {
            if (branchId <= 0)
                throw new ValueObjectValidationException("Branch ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new ValueObjectValidationException("Branch name is required");

            if (warehouseId.HasValue && warehouseId.Value <= 0)
                throw new ValueObjectValidationException("Warehouse ID must be greater than zero");

            if (cashierId.HasValue && cashierId.Value <= 0)
                throw new ValueObjectValidationException("Cashier ID must be greater than zero");

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