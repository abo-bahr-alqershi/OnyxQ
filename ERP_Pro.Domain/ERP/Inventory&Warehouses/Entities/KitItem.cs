using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class KitItem : Entity
    {
        /// <summary> رقم تعريف الكيت. </summary>
        public string? KitItemNumber { get; private set; }
        /// <summary> كود الصنف. </summary>
        public string? ItemCode { get; private set; }
        /// <summary> وحدة الصنف. </summary>
        public string ItemUnit { get; private set; }
        /// <summary> حجم العبوة. </summary>
        public int PackSize { get; private set; }
        /// <summary> كمية العنصر في الكيت. </summary>
        public int? ItemQuantity { get; private set; }
        /// <summary> كمية العبوة في الكيت. </summary>
        public int? PackQuantity { get; private set; }
        /// <summary> نسبة تكلفة العنصر من الكيت. </summary>
        public int? PercentCostFromKit { get; private set; }
        /// <summary> أقل كمية ممكنة للعنصر في الكيت. </summary>
        public int? MinimumItemQuantity { get; private set; }
        /// <summary> أكبر كمية. </summary>
        public int? MaximumItemQuantity { get; private set; }
        /// <summary> المستخدم الذي أضاف السطر. </summary>
        public int? AddedUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> أولوية التقرير. </summary>
        public long? ReportPriority { get; private set; }
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        /// <summary> تحقق الكمية في نظام RMS. </summary>
        public bool? CheckAvailableQuantityInRMS { get; private set; }
        /// <summary> ملاحظات. </summary>
        public string? Note { get; private set; }
        /// <summary> نوع البيع في الـ RMS. </summary>
        public string? UseRMSSaleType { get; private set; }
        /// <summary> السماح بتجاوز الكمية. </summary>
        public bool? ExceedItemQuantity { get; private set; }
        /// <summary> السماح بحذف العنصر من الكيت. </summary>
        public bool? AllowDeleteItem { get; private set; }
        
        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion
        
        #region Navigation Properties
        public Item Item { get; private set; } // Navigation
        #endregion

        private KitItem() { } // For EF Core

        public static KitItem Create(
            string? kitItemNumber,
            string? itemCode,
            string itemUnit,
            int packSize,
            int? itemQuantity = null,
            int? packQuantity = null,
            int? percentCostFromKit = null,
            int? minimumItemQuantity = null,
            int? maximumItemQuantity = null,
            bool? checkAvailableQuantityInRMS = null,
            string? note = null,
            string? useRMSSaleType = null,
            bool? exceedItemQuantity = null,
            bool? allowDeleteItem = null,
            int userId = 0,
            string terminal = "")
        {
            var kitItem = new KitItem
            {
                KitItemNumber = kitItemNumber,
                ItemCode = itemCode,
                ItemUnit = itemUnit,
                PackSize = packSize,
                ItemQuantity = itemQuantity,
                PackQuantity = packQuantity,
                PercentCostFromKit = percentCostFromKit,
                MinimumItemQuantity = minimumItemQuantity,
                MaximumItemQuantity = maximumItemQuantity,
                CheckAvailableQuantityInRMS = checkAvailableQuantityInRMS,
                Note = note,
                UseRMSSaleType = useRMSSaleType,
                ExceedItemQuantity = exceedItemQuantity,
                AllowDeleteItem = allowDeleteItem,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            kitItem.AddDomainEvent(new KitItemCreatedEvent(kitItem));
            return kitItem;
        }

        public void UpdateQuantityLimits(
            int? minimumItemQuantity,
            int? maximumItemQuantity,
            int userId,
            string terminal)
        {
            MinimumItemQuantity = minimumItemQuantity;
            MaximumItemQuantity = maximumItemQuantity;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemUpdatedEvent(this));
        }

        public void UpdateQuantities(
            int? itemQuantity,
            int? packQuantity,
            int? percentCostFromKit,
            int userId,
            string terminal)
        {
            ItemQuantity = itemQuantity;
            PackQuantity = packQuantity;
            PercentCostFromKit = percentCostFromKit;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemUpdatedEvent(this));
        }

        public void UpdateSettings(
            bool? checkAvailableQuantityInRMS,
            string? note,
            string? useRMSSaleType,
            bool? exceedItemQuantity,
            bool? allowDeleteItem,
            int userId,
            string terminal)
        {
            CheckAvailableQuantityInRMS = checkAvailableQuantityInRMS;
            Note = note;
            UseRMSSaleType = useRMSSaleType;
            ExceedItemQuantity = exceedItemQuantity;
            AllowDeleteItem = allowDeleteItem;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemUpdatedEvent(this));
        }
    }
}