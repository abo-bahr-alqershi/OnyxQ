using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class CompoundItemDetail : Entity
    {
        #region Basic Info
        /// <summary> رقم المستند. </summary>
        public long DocumentNumber { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocumentSerial { get; private set; }
        /// <summary> تسلسل السطر بالمستند. </summary>
        public long DocumentSequence { get; private set; }
        #endregion

        #region Component Info
        /// <summary> كود المكون. </summary>
        public string ComponentCode { get; private set; }
        /// <summary> اسم المكون. </summary>
        public string? ComponentName { get; private set; }
        /// <summary> وحدة المكون. </summary>
        public string ComponentUnit { get; private set; }
        /// <summary> حجم عبوة المكون. </summary>
        public int ComponentPackSize { get; private set; }
        /// <summary> كمية المكون. </summary>
        public decimal ComponentQuantity { get; private set; }
        /// <summary> مكون اختياري (1=نعم). </summary>
        public bool IsOptional { get; private set; }
        /// <summary> أقل كمية ممكنة للمكون. </summary>
        public decimal? MinimumQuantity { get; private set; }
        /// <summary> أكبر كمية للمكون. </summary>
        public decimal? MaximumQuantity { get; private set; }
        #endregion

        #region Warehouse Info
        /// <summary> المستودع المحول منه. </summary>
        public long? FromWarehouse { get; private set; }
        /// <summary> المستودع المحول إليه. </summary>
        public long? ToWarehouse { get; private set; }
        /// <summary> تاريخ انتهاء الدفعة. </summary>
        public DateTime? ExpireDate { get; private set; }
        /// <summary> رقم التشغيلة/الدفعة. </summary>
        public string? BatchNumber { get; private set; }
        #endregion

        #region References
        /// <summary> مركز التكلفة. </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رقم المشروع. </summary>
        public string? ProjectNumber { get; private set; }
        /// <summary> رقم النشاط. </summary>
        public string? ActivityNumber { get; private set; }
        #endregion

        #region Company Info
        /// <summary> رقم الشركة. </summary>
        public short CompanyNumber { get; private set; }
        /// <summary> رقم الفرع. </summary>
        public int BranchNumber { get; private set; }
        /// <summary> السنة المالية للفرع. </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع. </summary>
        public short? BranchUser { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> المستخدم الذي أضاف السطر. </summary>
        public int? AddedByUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedByUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual CompoundItem CompoundItem { get; private set; }
        public virtual Project Project { get; private set; }
        #endregion

        private CompoundItemDetail() { } // For EF Core

        public static CompoundItemDetail Create(
            long documentNumber,
            long? documentSerial,
            long documentSequence,
            string componentCode,
            string componentUnit,
            int componentPackSize,
            decimal componentQuantity,
            bool isOptional,
            short companyNumber,
            int branchNumber,
            int userId,
            string terminal)
        {
            if (string.IsNullOrWhiteSpace(componentCode))
                throw new DomainException("Component code cannot be empty");
            if (string.IsNullOrWhiteSpace(componentUnit))
                throw new DomainException("Component unit cannot be empty");
            if (componentPackSize <= 0)
                throw new DomainException("Component pack size must be positive");
            if (componentQuantity < 0)
                throw new DomainException("Component quantity cannot be negative");

            var detail = new CompoundItemDetail
            {
                DocumentNumber = documentNumber,
                DocumentSerial = documentSerial,
                DocumentSequence = documentSequence,
                ComponentCode = componentCode,
                ComponentUnit = componentUnit,
                ComponentPackSize = componentPackSize,
                ComponentQuantity = componentQuantity,
                IsOptional = isOptional,
                CompanyNumber = companyNumber,
                BranchNumber = branchNumber,
                AddedByUserId = userId,
                AddedDate = DateTime.Now,
                AddedTerminal = terminal,
                UpdateCount = 0
            };

            detail.AddDomainEvent(new CompoundItemDetailCreatedEvent(detail));
            return detail;
        }

        public void UpdateComponent(
            string componentCode,
            string componentUnit,
            int componentPackSize,
            decimal componentQuantity,
            bool isOptional,
            decimal? minimumQuantity = null,
            decimal? maximumQuantity = null)
        {
            if (string.IsNullOrWhiteSpace(componentCode))
                throw new DomainException("Component code cannot be empty");
            if (string.IsNullOrWhiteSpace(componentUnit))
                throw new DomainException("Component unit cannot be empty");
            if (componentPackSize <= 0)
                throw new DomainException("Component pack size must be positive");
            if (componentQuantity < 0)
                throw new DomainException("Component quantity cannot be negative");
            if (minimumQuantity.HasValue && minimumQuantity.Value < 0)
                throw new DomainException("Minimum quantity cannot be negative");
            if (maximumQuantity.HasValue && maximumQuantity.Value < 0)
                throw new DomainException("Maximum quantity cannot be negative");
            if (minimumQuantity.HasValue && maximumQuantity.HasValue && minimumQuantity.Value > maximumQuantity.Value)
                throw new DomainException("Minimum quantity cannot be greater than maximum quantity");

            ComponentCode = componentCode;
            ComponentUnit = componentUnit;
            ComponentPackSize = componentPackSize;
            ComponentQuantity = componentQuantity;
            IsOptional = isOptional;
            MinimumQuantity = minimumQuantity;
            MaximumQuantity = maximumQuantity;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;

            AddDomainEvent(new CompoundItemDetailUpdatedEvent(this));
        }

        public void UpdateWarehouseInfo(
            long? fromWarehouse,
            long? toWarehouse,
            DateTime? expireDate = null,
            string? batchNumber = null)
        {
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;
            ExpireDate = expireDate;
            BatchNumber = batchNumber;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;

            AddDomainEvent(new CompoundItemDetailUpdatedEvent(this));
        }

        public void UpdateReferences(
            string? costCenterCode = null,
            string? projectNumber = null,
            string? activityNumber = null)
        {
            CostCenterCode = costCenterCode;
            ProjectNumber = projectNumber;
            ActivityNumber = activityNumber;
            UpdatedDate = DateTime.Now;
            UpdateCount = (UpdateCount ?? 0) + 1;

            AddDomainEvent(new CompoundItemDetailUpdatedEvent(this));
        }
    }
} 