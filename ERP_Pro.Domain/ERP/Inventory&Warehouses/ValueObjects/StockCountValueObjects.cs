using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects
{
    public record ItemInfo
    {
        public string Code { get; }
        public string Name { get; }
        public string Unit { get; }
        public int? PackSize { get; }
        public string GroupCode { get; }
        public string GroupClassCode { get; }
        public string SubGroupCode { get; }
        public string ManagerCode { get; }
        public int? ItemType { get; }
        public int? ItemOrder { get; }

        private ItemInfo(
            string code,
            string name,
            string unit,
            int? packSize,
            string groupCode,
            string groupClassCode,
            string subGroupCode,
            string managerCode,
            int? itemType,
            int? itemOrder)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new DomainException("Item code cannot be empty");
            if (string.IsNullOrWhiteSpace(unit))
                throw new DomainException("Item unit cannot be empty");

            Code = code;
            Name = name ?? string.Empty;
            Unit = unit;
            PackSize = packSize;
            GroupCode = groupCode ?? string.Empty;
            GroupClassCode = groupClassCode ?? string.Empty;
            SubGroupCode = subGroupCode ?? string.Empty;
            ManagerCode = managerCode ?? string.Empty;
            ItemType = itemType;
            ItemOrder = itemOrder;
        }

        public static ItemInfo Create(
            string code,
            string name,
            string unit,
            int? packSize = null,
            string groupCode = null,
            string groupClassCode = null,
            string subGroupCode = null,
            string managerCode = null,
            int? itemType = null,
            int? itemOrder = null) =>
            new(code, name, unit, packSize, groupCode, groupClassCode, subGroupCode, managerCode, itemType, itemOrder);
    }

    public record StockQuantities
    {
        public int? Opening { get; }
        public int? Incoming { get; }
        public int? Sale { get; }
        public int? PointOfSale { get; }
        public int? NetSale { get; }
        public int? Available { get; }
        public int? NotReceived { get; }
        public int? TotalIncoming { get; }
        public int? FromWarehouse { get; }
        public int? ToWarehouse { get; }

        private StockQuantities(
            int? opening,
            int? incoming,
            int? sale,
            int? pointOfSale,
            int? netSale,
            int? available,
            int? notReceived,
            int? totalIncoming,
            int? fromWarehouse,
            int? toWarehouse)
        {
            Opening = opening;
            Incoming = incoming;
            Sale = sale;
            PointOfSale = pointOfSale;
            NetSale = netSale;
            Available = available;
            NotReceived = notReceived;
            TotalIncoming = totalIncoming;
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;
        }

        public static StockQuantities Create(
            int? opening = null,
            int? incoming = null,
            int? sale = null,
            int? pointOfSale = null,
            int? netSale = null,
            int? available = null,
            int? notReceived = null,
            int? totalIncoming = null,
            int? fromWarehouse = null,
            int? toWarehouse = null) =>
            new(opening, incoming, sale, pointOfSale, netSale, available, notReceived, totalIncoming, fromWarehouse, toWarehouse);
    }

    public record SaleMetrics
    {
        public int? AverageDailyQuantity { get; }
        public int? AverageGeneralQuantity { get; }
        public int? QuantityPercentage { get; }
        public int? ItemAge { get; }
        public int? AgePeriod { get; }
        public int? ItemRatio { get; }
        public int? SaleRatio { get; }
        public int? AverageQuantityPeriod { get; }
        public int? PeriodDays { get; }

        private SaleMetrics(
            int? averageDailyQuantity,
            int? averageGeneralQuantity,
            int? quantityPercentage,
            int? itemAge,
            int? agePeriod,
            int? itemRatio,
            int? saleRatio,
            int? averageQuantityPeriod,
            int? periodDays)
        {
            AverageDailyQuantity = averageDailyQuantity;
            AverageGeneralQuantity = averageGeneralQuantity;
            QuantityPercentage = quantityPercentage;
            ItemAge = itemAge;
            AgePeriod = agePeriod;
            ItemRatio = itemRatio;
            SaleRatio = saleRatio;
            AverageQuantityPeriod = averageQuantityPeriod;
            PeriodDays = periodDays;
        }

        public static SaleMetrics Create(
            int? averageDailyQuantity = null,
            int? averageGeneralQuantity = null,
            int? quantityPercentage = null,
            int? itemAge = null,
            int? agePeriod = null,
            int? itemRatio = null,
            int? saleRatio = null,
            int? averageQuantityPeriod = null,
            int? periodDays = null) =>
            new(averageDailyQuantity, averageGeneralQuantity, quantityPercentage, itemAge, agePeriod, itemRatio, saleRatio, averageQuantityPeriod, periodDays);
    }

    public record LocationInfo
    {
        public long? CityNumber { get; }
        public long? RegionCode { get; }
        public string AssistantNumber { get; }
        public string DetailNumber { get; }
        public int? ActivityNumber { get; }

        private LocationInfo(
            long? cityNumber,
            long? regionCode,
            string assistantNumber,
            string detailNumber,
            int? activityNumber)
        {
            CityNumber = cityNumber;
            RegionCode = regionCode;
            AssistantNumber = assistantNumber ?? string.Empty;
            DetailNumber = detailNumber ?? string.Empty;
            ActivityNumber = activityNumber;
        }

        public static LocationInfo Create(
            long? cityNumber = null,
            long? regionCode = null,
            string assistantNumber = null,
            string detailNumber = null,
            int? activityNumber = null) =>
            new(cityNumber, regionCode, assistantNumber, detailNumber, activityNumber);
    }
} 