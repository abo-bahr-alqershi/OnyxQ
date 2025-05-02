using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public record TransferExpenseInfo
    {
        public string AccountCode { get; }
        public string? AccountDtlCode { get; }
        public short? AccountDtlType { get; }
        public string CurrencyCode { get; }
        public int? AccountRate { get; }
        public string? CostCenterCode { get; }
        public string? ProjectNo { get; }
        public string? ActivityNo { get; }
        public int? Amount { get; }
        public int? InventoryAmount { get; }

        private TransferExpenseInfo(
            string accountCode,
            string? accountDtlCode,
            short? accountDtlType,
            string currencyCode,
            int? accountRate,
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? amount,
            int? inventoryAmount)
        {
            if (string.IsNullOrWhiteSpace(accountCode))
                throw new DomainException("Account code is required");
            if (string.IsNullOrWhiteSpace(currencyCode))
                throw new DomainException("Currency code is required");

            AccountCode = accountCode;
            AccountDtlCode = accountDtlCode;
            AccountDtlType = accountDtlType;
            CurrencyCode = currencyCode;
            AccountRate = accountRate;
            CostCenterCode = costCenterCode;
            ProjectNo = projectNo;
            ActivityNo = activityNo;
            Amount = amount;
            InventoryAmount = inventoryAmount;
        }

        public static TransferExpenseInfo Create(
            string accountCode,
            string? accountDtlCode,
            short? accountDtlType,
            string currencyCode,
            int? accountRate,
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? amount,
            int? inventoryAmount)
        {
            return new TransferExpenseInfo(
                accountCode, accountDtlCode, accountDtlType, currencyCode,
                accountRate, costCenterCode, projectNo, activityNo,
                amount, inventoryAmount);
        }
    }
} 