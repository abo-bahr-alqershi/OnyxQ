using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class ItemLevelMeasure : AggregateRoot
    {
        #region Basic Info
        /// <summary> رقم المستوى </summary>
        public short LevelNumber { get; private set; }
        /// <summary> قيمة العلامة </summary>
        public int? FlagValue { get; private set; }
        /// <summary> كود العلامة </summary>
        public string? FlagCode { get; private set; }
        /// <summary> نوع المقارنة </summary>
        public int? ComparisonType { get; private set; }
        /// <summary> نوع المعامل </summary>
        public short? ArgumentType { get; private set; }
        /// <summary> من نسبة المبلغ </summary>
        public decimal? FromAmountPercentage { get; private set; }
        /// <summary> إلى نسبة المبلغ </summary>
        public decimal? ToAmountPercentage { get; private set; }
        #endregion

        #region Item Info
        /// <summary> معلومات الصنف </summary>
        public CompoundItemInfo ItemInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual Item Item { get; private set; }
        #endregion

        private ItemLevelMeasure() { } // For EF Core

        public static ItemLevelMeasure Create(
            short levelNumber,
            CompoundItemInfo itemInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var measure = new ItemLevelMeasure
            {
                LevelNumber = levelNumber,
                ItemInfo = itemInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            measure.AddDomainEvent(new ItemLevelMeasureCreatedEvent(measure));
            return measure;
        }

        public void UpdateMeasurementInfo(
            int? flagValue,
            string? flagCode,
            int? comparisonType,
            short? argumentType,
            decimal? fromAmountPercentage,
            decimal? toAmountPercentage,
            int userId,
            string terminal)
        {
            FlagValue = flagValue;
            FlagCode = flagCode;
            ComparisonType = comparisonType;
            ArgumentType = argumentType;
            FromAmountPercentage = fromAmountPercentage;
            ToAmountPercentage = toAmountPercentage;

            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new ItemLevelMeasureUpdatedEvent(this));
        }

        public void UpdateItemInfo(CompoundItemInfo itemInfo, int userId, string terminal)
        {
            ItemInfo = itemInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new ItemLevelMeasureUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (LevelNumber <= 0)
                throw new DomainException("Level number must be positive");

            if (ItemInfo == null)
                throw new DomainException("Item info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}