using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class KitItemDetail : Entity
    {
        #region Basic Info
        /// <summary> رقم المستند. </summary>
        public long DocumentNumber { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocumentSerial { get; private set; }
        /// <summary> رقم الكيت. </summary>
        public string? KitItemNumber { get; private set; }
        /// <summary> كود الصنف. </summary>
        public string? ItemCode { get; private set; }
        /// <summary> وحدة الصنف. </summary>
        public string? ItemUnit { get; private set; }
        /// <summary> حجم العبوة. </summary>
        public int PackSize { get; private set; }
        /// <summary> كمية العنصر في الكيت. </summary>
        public int? ItemQuantity { get; private set; }
        /// <summary> كمية العبوة في الكيت. </summary>
        public int? PackQuantity { get; private set; }
        /// <summary> الكمية القياسية. </summary>
        public int? StandardQuantity { get; private set; }
        /// <summary> الكمية المتاحة. </summary>
        public int? AvailableQuantity { get; private set; }
        /// <summary> كود المستودع. </summary>
        public long? WarehouseCode { get; private set; }
        /// <summary> تكلفة العنصر. </summary>
        public int? ItemCost { get; private set; }
        /// <summary> كمية الكيت. </summary>
        public int? KitQuantity { get; private set; }
        /// <summary> إجمالي الكمية. </summary>
        public int? TotalQuantity { get; private set; }
        /// <summary> إجمالي جزئي للكمية. </summary>
        public int? PartialTotalQuantity { get; private set; }
        /// <summary> رقم السطر الداخلي. </summary>
        public long? RecordNumber { get; private set; }
        /// <summary> تسلسل السطر بالمستند. </summary>
        public long? DocumentSequence { get; private set; }
        /// <summary> كود الترحيل. </summary>
        public string? PostCode { get; private set; }
        /// <summary> تسلسل السطر الرئيسي. </summary>
        public int? MainDocumentSequence { get; private set; }
        #endregion

        #region Cost Info
        /// <summary> مركز التكلفة. </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رقم المشروع. </summary>
        public string? ProjectNumber { get; private set; }
        /// <summary> رقم النشاط. </summary>
        public string? ActivityNumber { get; private set; }
        #endregion
        
        #region Batch Info
        /// <summary> تاريخ انتهاء الدفعة. </summary>
        public DateTime? ExpireDate { get; private set; }
        /// <summary> رقم التشغيلة/الدفعة. </summary>
        public string? BatchNumber { get; private set; }
        /// <summary> رقم تسلسلي فرعي للسطر. </summary>
        public int? RecordSequence { get; private set; }
        #endregion
        
        #region Bill Info
        public long BillSerial { get; private set; }
        public string BillCurrency { get; private set; }
        public decimal? BillAmount { get; private set; }
        public DateTime? BillDate { get; private set; }
        public string AccountCode { get; private set; }
        public string? CustomerCode { get; private set; }
        #endregion
        
        #region Kit Info
        public long? KitNumber { get; private set; }
        public long? KitSerial { get; private set; }
        public DateTime KitDate { get; private set; }
        public decimal? KitAmount { get; private set; }
        public decimal? PaidAmount { get; private set; }
        public decimal? OtherPaidAmount { get; private set; }
        public string? KitNote { get; private set; }
        public bool? KitPaid { get; private set; }
        #endregion
        
        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion
        
        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion
        
        #region Navigation Properties
        public Project Project { get; private set; } // Navigation
        #endregion

        private KitItemDetail() { } // For EF Core

        public static KitItemDetail Create(
            long documentNumber,
            int packSize,
            string? kitItemNumber = null,
            long? documentSerial = null,
            string? itemCode = null,
            string? itemUnit = null,
            int? itemQuantity = null,
            int? packQuantity = null,
            int? standardQuantity = null,
            int? availableQuantity = null,
            long? warehouseCode = null,
            string? costCenterCode = null,
            string? projectNumber = null,
            string? activityNumber = null,
            int? itemCost = null,
            int? kitQuantity = null,
            int? totalQuantity = null,
            int? partialTotalQuantity = null,
            long? recordNumber = null,
            long? documentSequence = null,
            string? postCode = null,
            DateTime? expireDate = null,
            string? batchNumber = null,
            int? recordSequence = null,
            int? mainDocumentSequence = null,
            CompanyInfo companyInfo = null,
            int userId = 0,
            string terminal = "")
        {
            var kitItemDetail = new KitItemDetail
            {
                DocumentNumber = documentNumber,
                DocumentSerial = documentSerial,
                KitItemNumber = kitItemNumber,
                ItemCode = itemCode,
                ItemUnit = itemUnit,
                PackSize = packSize,
                ItemQuantity = itemQuantity,
                PackQuantity = packQuantity,
                StandardQuantity = standardQuantity,
                AvailableQuantity = availableQuantity,
                WarehouseCode = warehouseCode,
                CostCenterCode = costCenterCode,
                ProjectNumber = projectNumber,
                ActivityNumber = activityNumber,
                ItemCost = itemCost,
                KitQuantity = kitQuantity,
                TotalQuantity = totalQuantity,
                PartialTotalQuantity = partialTotalQuantity,
                RecordNumber = recordNumber,
                DocumentSequence = documentSequence,
                PostCode = postCode,
                ExpireDate = expireDate,
                BatchNumber = batchNumber,
                RecordSequence = recordSequence,
                MainDocumentSequence = mainDocumentSequence,
                CompanyInfo = companyInfo ?? throw new ArgumentNullException(nameof(companyInfo)),
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            kitItemDetail.AddDomainEvent(new KitItemDetailCreatedEvent(kitItemDetail));
            return kitItemDetail;
        }

        public void UpdateBatchInfo(
            string? batchNumber,
            DateTime? expireDate,
            int? recordSequence,
            int userId,
            string terminal)
        {
            BatchNumber = batchNumber ?? BatchNumber;
            ExpireDate = expireDate ?? ExpireDate;
            RecordSequence = recordSequence ?? RecordSequence;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemDetailBatchUpdatedEvent(this));
        }

        public void UpdateKitInfo(
            long? kitNumber,
            long? kitSerial,
            DateTime kitDate,
            decimal? kitAmount,
            decimal? paidAmount,
            decimal? otherPaidAmount,
            string? kitNote,
            bool? kitPaid,
            int userId,
            string terminal)
        {
            KitNumber = kitNumber;
            KitSerial = kitSerial;
            KitDate = kitDate;
            KitAmount = kitAmount;
            PaidAmount = paidAmount;
            OtherPaidAmount = otherPaidAmount;
            KitNote = kitNote;
            KitPaid = kitPaid;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemDetailUpdatedEvent(this));
        }

        public void UpdateCostInfo(
            string? costCenterCode,
            string? projectNumber,
            string? activityNumber,
            int? itemCost,
            int userId,
            string terminal)
        {
            CostCenterCode = costCenterCode ?? CostCenterCode;
            ProjectNumber = projectNumber ?? ProjectNumber;
            ActivityNumber = activityNumber ?? ActivityNumber;
            ItemCost = itemCost ?? ItemCost;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemDetailCostUpdatedEvent(this));
        }

        public void UpdateQuantities(
            int? itemQuantity,
            int? packQuantity,
            int? standardQuantity,
            int? availableQuantity,
            int? kitQuantity,
            int? totalQuantity,
            int? partialTotalQuantity,
            int userId,
            string terminal)
        {
            ItemQuantity = itemQuantity ?? ItemQuantity;
            PackQuantity = packQuantity ?? PackQuantity;
            StandardQuantity = standardQuantity ?? StandardQuantity;
            AvailableQuantity = availableQuantity ?? AvailableQuantity;
            KitQuantity = kitQuantity ?? KitQuantity;
            TotalQuantity = totalQuantity ?? TotalQuantity;
            PartialTotalQuantity = partialTotalQuantity ?? PartialTotalQuantity;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            
            AddDomainEvent(new KitItemDetailQuantitiesUpdatedEvent(this));
        }
    }
}