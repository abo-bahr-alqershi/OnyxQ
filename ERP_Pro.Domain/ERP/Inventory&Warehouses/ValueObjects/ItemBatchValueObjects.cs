using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects
{
    public record BatchDescription
    {
        public string Value { get; }
        public bool HasColumn { get; }

        private BatchDescription(string value, bool hasColumn)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length > 100)
                throw new DomainException("Batch description cannot exceed 100 characters");
            Value = value ?? string.Empty;
            HasColumn = hasColumn;
        }

        public static BatchDescription Create(string value, bool hasColumn) => new(value, hasColumn);
    }

    public record UnitConfiguration
    {
        public bool IsMainUnit { get; }
        public bool IsSaleUnit { get; }
        public bool IsPurchaseUnit { get; }
        public bool IsStockUnit { get; }
        public bool IsPriceUnit { get; }
        public bool IsStoreUnit { get; }
        public bool IsChiefUnit { get; }
        public bool NoSale { get; }

        private UnitConfiguration(
            bool isMainUnit,
            bool isSaleUnit,
            bool isPurchaseUnit,
            bool isStockUnit,
            bool isPriceUnit,
            bool isStoreUnit,
            bool isChiefUnit,
            bool noSale)
        {
            IsMainUnit = isMainUnit;
            IsSaleUnit = isSaleUnit;
            IsPurchaseUnit = isPurchaseUnit;
            IsStockUnit = isStockUnit;
            IsPriceUnit = isPriceUnit;
            IsStoreUnit = isStoreUnit;
            IsChiefUnit = isChiefUnit;
            NoSale = noSale;
        }

        public static UnitConfiguration Create(
            bool isMainUnit = false,
            bool isSaleUnit = false,
            bool isPurchaseUnit = false,
            bool isStockUnit = false,
            bool isPriceUnit = false,
            bool isStoreUnit = false,
            bool isChiefUnit = false,
            bool noSale = false) =>
            new(isMainUnit, isSaleUnit, isPurchaseUnit, isStockUnit, isPriceUnit, isStoreUnit, isChiefUnit, noSale);
    }

    public record UnitDescription
    {
        public string Value { get; }
        public string Language { get; }

        private UnitDescription(string value, string language)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DomainException("Unit description cannot be empty");
            if (string.IsNullOrWhiteSpace(language))
                throw new DomainException("Language code cannot be empty");
            Value = value;
            Language = language;
        }

        public static UnitDescription Create(string value, string language) => new(value, language);
    }

    public record InactiveInfo
    {
        public bool IsInactive { get; }
        public string? Reason { get; }
        public int? UserId { get; }
        public DateTime? InactiveDate { get; }

        private InactiveInfo(bool isInactive, string? reason, int? userId, DateTime? inactiveDate)
        {
            if (isInactive && string.IsNullOrWhiteSpace(reason))
                throw new DomainException("Reason is required when marking as inactive");
            if (isInactive && !userId.HasValue)
                throw new DomainException("User ID is required when marking as inactive");
            if (isInactive && !inactiveDate.HasValue)
                throw new DomainException("Inactive date is required when marking as inactive");

            IsInactive = isInactive;
            Reason = reason;
            UserId = userId;
            InactiveDate = inactiveDate;
        }

        public static InactiveInfo Create(bool isInactive, string? reason = null, int? userId = null, DateTime? inactiveDate = null) =>
            new(isInactive, reason, userId, inactiveDate);

        public static InactiveInfo Active => new(false, null, null, null);
    }
} 