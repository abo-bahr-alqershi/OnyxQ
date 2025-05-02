using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Events
{
    public class StockCountCreatedEvent : DomainEvent
    {
        public StockCount StockCount { get; }

        public StockCountCreatedEvent(StockCount stockCount)
        {
            StockCount = stockCount;
        }
    }

    public class StockCountQuantitiesUpdatedEvent : DomainEvent
    {
        public StockCount StockCount { get; }
        public StockQuantities OldQuantities { get; }
        public StockQuantities NewQuantities { get; }

        public StockCountQuantitiesUpdatedEvent(
            StockCount stockCount,
            StockQuantities oldQuantities,
            StockQuantities newQuantities)
        {
            StockCount = stockCount;
            OldQuantities = oldQuantities;
            NewQuantities = newQuantities;
        }
    }

    public class StockCountMetricsUpdatedEvent : DomainEvent
    {
        public StockCount StockCount { get; }
        public SaleMetrics OldMetrics { get; }
        public SaleMetrics NewMetrics { get; }

        public StockCountMetricsUpdatedEvent(
            StockCount stockCount,
            SaleMetrics oldMetrics,
            SaleMetrics newMetrics)
        {
            StockCount = stockCount;
            OldMetrics = oldMetrics;
            NewMetrics = newMetrics;
        }
    }

    public class StockCountProcessedEvent : DomainEvent
    {
        public StockCount StockCount { get; }
        public int UserId { get; }

        public StockCountProcessedEvent(StockCount stockCount, int userId)
        {
            StockCount = stockCount;
            UserId = userId;
        }
    }

    public class StockCountLocationUpdatedEvent : DomainEvent
    {
        public StockCount StockCount { get; }
        public LocationInfo OldLocation { get; }
        public LocationInfo NewLocation { get; }

        public StockCountLocationUpdatedEvent(
            StockCount stockCount,
            LocationInfo oldLocation,
            LocationInfo newLocation)
        {
            StockCount = stockCount;
            OldLocation = oldLocation;
            NewLocation = newLocation;
        }
    }
} 