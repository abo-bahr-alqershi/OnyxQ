using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class Measurement : Entity
    {
        public string? MeasurementCode { get; private set; }
        public string? MeasurementArabicName { get; private set; }
        public string? MeasurementForeignName { get; private set; }
        public bool? MeasurementType { get; private set; }
        public short? MeasurementWeightType { get; private set; }
        public bool? MeasurementWeightConnection { get; private set; }
        public long? DefaultSize { get; private set; }
        public bool? AllowUpdate { get; private set; }
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long? UpdateCount { get; private set; }
        public long? ReportPriority { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }
        public string? MeasurementCodeGlobalBase { get; private set; }

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private Measurement() { } // For EF Core

        public static Measurement Create(
            string? measurementCode,
            string? measurementArabicName,
            string? measurementForeignName,
            bool? measurementType = null,
            short? measurementWeightType = null,
            bool? measurementWeightConnection = null,
            long? defaultSize = null,
            bool? allowUpdate = null,
            string? measurementCodeGlobalBase = null,
            int userId = 0,
            string terminal = "")
        {
            var measurement = new Measurement
            {
                MeasurementCode = measurementCode,
                MeasurementArabicName = measurementArabicName,
                MeasurementForeignName = measurementForeignName,
                MeasurementType = measurementType,
                MeasurementWeightType = measurementWeightType,
                MeasurementWeightConnection = measurementWeightConnection,
                DefaultSize = defaultSize,
                AllowUpdate = allowUpdate,
                MeasurementCodeGlobalBase = measurementCodeGlobalBase,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            measurement.AddDomainEvent(new MeasurementCreatedEvent(measurement));
            return measurement;
        }

        public void UpdateMeasurementInfo(
            string? measurementArabicName,
            string? measurementForeignName,
            bool? measurementType,
            int userId,
            string terminal)
        {
            MeasurementArabicName = measurementArabicName ?? MeasurementArabicName;
            MeasurementForeignName = measurementForeignName ?? MeasurementForeignName;
            MeasurementType = measurementType ?? MeasurementType;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new MeasurementUpdatedEvent(this));
        }

        public void UpdateWeightSettings(
            short? measurementWeightType,
            bool? measurementWeightConnection,
            long? defaultSize,
            string? measurementCodeGlobalBase,
            int userId,
            string terminal)
        {
            MeasurementWeightType = measurementWeightType ?? MeasurementWeightType;
            MeasurementWeightConnection = measurementWeightConnection ?? MeasurementWeightConnection;
            DefaultSize = defaultSize ?? DefaultSize;
            MeasurementCodeGlobalBase = measurementCodeGlobalBase ?? MeasurementCodeGlobalBase;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new MeasurementUpdatedEvent(this));
        }

        public void SetAllowUpdate(bool allowUpdate, int userId, string terminal)
        {
            AllowUpdate = allowUpdate;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new MeasurementUpdatedEvent(this));
        }
    }
}