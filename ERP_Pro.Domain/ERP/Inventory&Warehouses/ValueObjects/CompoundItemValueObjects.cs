using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public record CompoundItemInfo
    {
        public string ItemCode { get; }
        public string ItemUnit { get; }
        public int PackSize { get; }
        public decimal Quantity { get; }

        private CompoundItemInfo(string itemCode, string itemUnit, int packSize, decimal quantity)
        {
            if (string.IsNullOrWhiteSpace(itemCode))
                throw new DomainException("Item code cannot be empty");
            if (string.IsNullOrWhiteSpace(itemUnit))
                throw new DomainException("Item unit cannot be empty");
            if (packSize <= 0)
                throw new DomainException("Pack size must be positive");
            if (quantity < 0)
                throw new DomainException("Quantity cannot be negative");

            ItemCode = itemCode;
            ItemUnit = itemUnit;
            PackSize = packSize;
            Quantity = quantity;
        }

        public static CompoundItemInfo Create(
            string itemCode,
            string itemUnit,
            int packSize,
            decimal quantity) =>
            new(itemCode, itemUnit, packSize, quantity);
    }

    public record CompoundItemCost
    {
        public decimal Cost { get; }
        public decimal? StandardCost { get; }
        public decimal? WeightedAverageCost { get; }

        private CompoundItemCost(decimal cost, decimal? standardCost = null, decimal? weightedAverageCost = null)
        {
            if (cost < 0)
                throw new DomainException("Cost cannot be negative");
            if (standardCost.HasValue && standardCost.Value < 0)
                throw new DomainException("Standard cost cannot be negative");
            if (weightedAverageCost.HasValue && weightedAverageCost.Value < 0)
                throw new DomainException("Weighted average cost cannot be negative");

            Cost = cost;
            StandardCost = standardCost;
            WeightedAverageCost = weightedAverageCost;
        }

        public static CompoundItemCost Create(
            decimal cost,
            decimal? standardCost = null,
            decimal? weightedAverageCost = null) =>
            new(cost, standardCost, weightedAverageCost);
    }

    public record CompoundItemQuantities
    {
        public decimal Available { get; }
        public decimal? Minimum { get; }
        public decimal? Maximum { get; }
        public decimal? ReorderLevel { get; }

        private CompoundItemQuantities(
            decimal available,
            decimal? minimum = null,
            decimal? maximum = null,
            decimal? reorderLevel = null)
        {
            if (available < 0)
                throw new DomainException("Available quantity cannot be negative");
            if (minimum.HasValue && minimum.Value < 0)
                throw new DomainException("Minimum quantity cannot be negative");
            if (maximum.HasValue && maximum.Value < 0)
                throw new DomainException("Maximum quantity cannot be negative");
            if (reorderLevel.HasValue && reorderLevel.Value < 0)
                throw new DomainException("Reorder level cannot be negative");

            Available = available;
            Minimum = minimum;
            Maximum = maximum;
            ReorderLevel = reorderLevel;
        }

        public static CompoundItemQuantities Create(
            decimal available,
            decimal? minimum = null,
            decimal? maximum = null,
            decimal? reorderLevel = null) =>
            new(available, minimum, maximum, reorderLevel);
    }
} 