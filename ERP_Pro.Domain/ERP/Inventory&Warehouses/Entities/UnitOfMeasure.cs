using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class UnitOfMeasure : Entity
    {
        // Primary Key
        public string MeasureCode { get; private set; }
        
        // Basic Info
        public string MeasureName { get; private set; }
        public string? MeasureForeignName { get; private set; }
        public int? MeasureType { get; private set; }
        public int? MeasureWeightType { get; private set; }
        public int? MeasureWeightConnection { get; private set; }
        public decimal? DefaultSize { get; private set; }
        public bool AllowUpdate { get; private set; }
        public string? MeasureCodeGB { get; private set; }
        
        // Audit Fields
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public int? PrintReport { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }

        private UnitOfMeasure() { } // For EF Core

        public UnitOfMeasure(
            string measureCode,
            string measureName,
            bool allowUpdate = true)
        {
            MeasureCode = measureCode;
            MeasureName = measureName;
            AllowUpdate = allowUpdate;

            AddDomainEvent(new UnitOfMeasureCreatedEvent(measureCode, measureName));
        }

        public void UpdateBasicInfo(
            string measureName,
            string? measureForeignName = null,
            int? measureType = null,
            decimal? defaultSize = null)
        {
            MeasureName = measureName;
            MeasureForeignName = measureForeignName ?? MeasureForeignName;
            MeasureType = measureType ?? MeasureType;
            DefaultSize = defaultSize ?? DefaultSize;

            AddDomainEvent(new UnitOfMeasureUpdatedEvent(MeasureCode));
        }

        public void UpdateWeightInfo(
            int? weightType = null,
            int? weightConnection = null)
        {
            MeasureWeightType = weightType ?? MeasureWeightType;
            MeasureWeightConnection = weightConnection ?? MeasureWeightConnection;

            AddDomainEvent(new UnitOfMeasureWeightInfoUpdatedEvent(MeasureCode));
        }

        public void UpdateGBCode(string? gbCode)
        {
            MeasureCodeGB = gbCode;
            AddDomainEvent(new UnitOfMeasureGBCodeUpdatedEvent(MeasureCode, gbCode));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(MeasureCode))
                throw new DomainException("Measure code is required");

            if (string.IsNullOrWhiteSpace(MeasureName))
                throw new DomainException("Measure name is required");
        }
    }
} 