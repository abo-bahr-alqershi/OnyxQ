using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class UnitConversion : AggregateRoot
    {
        #region Basic Info
        /// <summary> رقم تحويل الوحدة (رئيسي) </summary>
        public long? ManualMeasureNo { get; private set; }
        /// <summary> كود الوحدة الأساسية (من) </summary>
        public string? ManualMeasureCode { get; private set; }
        /// <summary> كود الوحدة المحولة (إلى) </summary>
        public string? ObservedMeasureCode { get; private set; }
        /// <summary> رقم مرجعي أو معامل التحويل </summary>
        public int? ArgumentNo { get; private set; }
        /// <summary> المستخدم الذي أضاف السطر </summary>
        public int? AddedUserId { get; private set; }
        /// <summary> تاريخ الإضافة </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر </summary>
        public int? UpdatedUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> عدد مرات التحديث </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> أولوية التقرير </summary>
        public long? ReportPriority { get; private set; }
        /// <summary> اسم الجهاز عند الإضافة </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> اسم الجهاز عند التعديل </summary>
        public string? UpdatedTerminal { get; private set; }
        public string? GroupAName { get; private set; }
        public string? GroupEName { get; private set; }
        public bool? AdminUser { get; private set; }
        public bool? RestGrp { get; private set; }
        #endregion

        #region Unit Info
        public UnitConversionInfo ConversionInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private UnitConversion() { } // For EF Core

        public static UnitConversion Create(
            long? manualMeasureNo,
            UnitConversionInfo conversionInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var conversion = new UnitConversion
            {
                ManualMeasureNo = manualMeasureNo,
                ConversionInfo = conversionInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            conversion.AddDomainEvent(new UnitConversionCreatedEvent(conversion));
            return conversion;
        }

        public void UpdateConversionInfo(
            UnitConversionInfo conversionInfo,
            int userId,
            string terminal)
        {
            ConversionInfo = conversionInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new UnitConversionUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (ConversionInfo == null)
                throw new DomainException("Conversion info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}