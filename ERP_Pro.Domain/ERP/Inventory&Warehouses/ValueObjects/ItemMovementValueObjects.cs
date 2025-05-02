using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects
{
    public record DocumentNumber
    {
        public long Value { get; }

        private DocumentNumber(long value)
        {
            if (value <= 0)
                throw new DomainException("Document number must be positive");
            Value = value;
        }

        public static DocumentNumber Create(long value) => new(value);
    }

    public record DocumentType
    {
        public int Value { get; }
        public string Name { get; }

        private DocumentType(int value, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Document type name cannot be empty");
            Value = value;
            Name = name;
        }

        public static DocumentType Create(int value, string name) => new(value, name);
    }

    public record ItemCode
    {
        public string Value { get; }

        private ItemCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DomainException("Item code cannot be empty");
            Value = value;
        }

        public static ItemCode Create(string value) => new(value);
    }

    public record ItemQuantity
    {
        public decimal Value { get; }

        private ItemQuantity(decimal value)
        {
            if (value < 0)
                throw new DomainException("Quantity cannot be negative");
            Value = value;
        }

        public static ItemQuantity Create(decimal value) => new(value);
        public static ItemQuantity Zero => new(0);
    }

    public record UnitMeasure
    {
        public string Code { get; }
        public string Name { get; }

        private UnitMeasure(string code, string name)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new DomainException("Unit measure code cannot be empty");
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Unit measure name cannot be empty");
            Code = code;
            Name = name;
        }

        public static UnitMeasure Create(string code, string name) => new(code, name);
    }

    public record PackageSize
    {
        public int Value { get; }

        private PackageSize(int value)
        {
            if (value <= 0)
                throw new DomainException("Package size must be positive");
            Value = value;
        }

        public static PackageSize Create(int value) => new(value);
    }

    public record ItemDimensions
    {
        public decimal Length { get; }
        public decimal Width { get; }
        public decimal Height { get; }

        private ItemDimensions(decimal length, decimal width, decimal height)
        {
            if (length < 0 || width < 0 || height < 0)
                throw new DomainException("Dimensions cannot be negative");
            Length = length;
            Width = width;
            Height = height;
        }

        public static ItemDimensions Create(decimal length, decimal width, decimal height) 
            => new(length, width, height);
    }

    public record Weight
    {
        public decimal Value { get; }
        public string Unit { get; }

        private Weight(decimal value, string unit)
        {
            if (value < 0)
                throw new DomainException("Weight cannot be negative");
            if (string.IsNullOrWhiteSpace(unit))
                throw new DomainException("Weight unit cannot be empty");
            Value = value;
            Unit = unit;
        }

        public static Weight Create(decimal value, string unit) => new(value, unit);
    }

    public record BatchNumber
    {
        public string Value { get; }

        private BatchNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DomainException("Batch number cannot be empty");
            Value = value;
        }

        public static BatchNumber Create(string value) => new(value);
    }

    public record DiscountInfo
    {
        public decimal Amount { get; }
        public decimal Percentage { get; }
        public decimal AmountWithVat { get; }

        private DiscountInfo(decimal amount, decimal percentage, decimal amountWithVat)
        {
            if (amount < 0)
                throw new DomainException("Discount amount cannot be negative");
            if (percentage < 0 || percentage > 100)
                throw new DomainException("Discount percentage must be between 0 and 100");
            if (amountWithVat < 0)
                throw new DomainException("Discount amount with VAT cannot be negative");

            Amount = amount;
            Percentage = percentage;
            AmountWithVat = amountWithVat;
        }

        public static DiscountInfo Create(decimal amount, decimal percentage, decimal amountWithVat) 
            => new(amount, percentage, amountWithVat);
    }

    public record CompanyInfo
    {
        public short Number { get; }
        public string Name { get; }

        private CompanyInfo(short number, string name)
        {
            if (number <= 0)
                throw new DomainException("Company number must be positive");
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Company name cannot be empty");
            Number = number;
            Name = name;
        }

        public static CompanyInfo Create(short number, string name) => new(number, name);
    }

    public record BranchInfo
    {
        public int Number { get; }
        public short? Year { get; }
        public short? UserId { get; }

        private BranchInfo(int number, short? year = null, short? userId = null)
        {
            if (number <= 0)
                throw new DomainException("Branch number must be positive");
            Number = number;
            Year = year;
            UserId = userId;
        }

        public static BranchInfo Create(int number, short? year = null, short? userId = null) 
            => new(number, year, userId);
    }

    public record GoodsReceiptInfo
    {
        public long Number { get; }
        public long? Serial { get; }

        private GoodsReceiptInfo(long number, long? serial = null)
        {
            if (number <= 0)
                throw new DomainException("Goods receipt number must be positive");
            Number = number;
            Serial = serial;
        }

        public static GoodsReceiptInfo Create(long number, long? serial = null) 
            => new(number, serial);
    }

    public record AccountDetailInfo
    {
        public string Code { get; }
        public short Type { get; }

        private AccountDetailInfo(string code, short type)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new DomainException("Account detail code cannot be empty");
            Code = code;
            Type = type;
        }

        public static AccountDetailInfo Create(string code, short type) => new(code, type);
    }

    public enum MovementType
    {
        In = 1,
        Out = 2,
        Transfer = 3,
        Adjustment = 4
    }
} 