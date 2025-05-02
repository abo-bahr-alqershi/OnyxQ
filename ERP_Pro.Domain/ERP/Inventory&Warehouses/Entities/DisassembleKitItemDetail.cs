using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class DisassembleKitItemDetail : Entity
    {
        #region Basic Info
        /// <summary> رقم مستند التفكيك. </summary>
        public long DocNo { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocSerial { get; private set; }
        /// <summary> تسلسل السطر بالمستند. </summary>
        public long DocSequence { get; private set; }
        /// <summary> كود الترحيل. </summary>
        public string? PostCode { get; private set; }
        /// <summary> رقم السطر الداخلي. </summary>
        public long? RecordNo { get; private set; }
        /// <summary> تسلسل السطر الرئيسي. </summary>
        public int? DocSequenceMain { get; private set; }
        /// <summary> رقم فرعي للسطر. </summary>
        public int? RecordSq { get; private set; }
        #endregion

        #region Cost Info
        /// <summary> مركز التكلفة. </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رقم المشروع. </summary>
        public string? ProjectNo { get; private set; }
        /// <summary> رقم النشاط. </summary>
        public string? ActivityNo { get; private set; }
        /// <summary> تكلفة الكيت المجمعة. </summary>
        public int? KitCost { get; private set; }
        /// <summary> نسبة التكلفة من الكيت. </summary>
        public int? PerCostFromKitItm { get; private set; }
        #endregion

        #region Kit Info
        public DisassembleKitInfo KitInfo { get; private set; }
        #endregion

        #region Warehouse Info
        public WarehouseInfo WarehouseInfo { get; private set; }
        #endregion

        #region Batch Info
        public BatchInfo BatchInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public DisassembleKitItem DisassembleKitItem { get; private set; }
        public Project Project { get; private set; }
        #endregion

        private DisassembleKitItemDetail() { }

        public static DisassembleKitItemDetail Create(
            long docNo,
            long? docSerial,
            long docSequence,
            string? postCode,
            long? recordNo,
            int? docSequenceMain,
            int? recordSq,
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? kitCost,
            int? perCostFromKitItm,
            DisassembleKitInfo kitInfo,
            WarehouseInfo warehouseInfo,
            BatchInfo batchInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var detail = new DisassembleKitItemDetail
            {
                DocNo = docNo,
                DocSerial = docSerial,
                DocSequence = docSequence,
                PostCode = postCode,
                RecordNo = recordNo,
                DocSequenceMain = docSequenceMain,
                RecordSq = recordSq,
                CostCenterCode = costCenterCode,
                ProjectNo = projectNo,
                ActivityNo = activityNo,
                KitCost = kitCost,
                PerCostFromKitItm = perCostFromKitItm,
                KitInfo = kitInfo,
                WarehouseInfo = warehouseInfo,
                BatchInfo = batchInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            detail.AddDomainEvent(new DisassembleKitItemDetailCreatedEvent(detail));
            return detail;
        }

        public void UpdateKitInfo(
            DisassembleKitInfo kitInfo,
            int userId,
            string terminal)
        {
            KitInfo = kitInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemDetailUpdatedEvent(this));
        }

        public void UpdateWarehouseInfo(
            WarehouseInfo warehouseInfo,
            int userId,
            string terminal)
        {
            WarehouseInfo = warehouseInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemDetailUpdatedEvent(this));
        }

        public void UpdateBatchInfo(
            BatchInfo batchInfo,
            int userId,
            string terminal)
        {
            BatchInfo = batchInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemDetailUpdatedEvent(this));
        }

        public void UpdateCostInfo(
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? kitCost,
            int? perCostFromKitItm,
            int userId,
            string terminal)
        {
            CostCenterCode = costCenterCode;
            ProjectNo = projectNo;
            ActivityNo = activityNo;
            KitCost = kitCost;
            PerCostFromKitItm = perCostFromKitItm;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemDetailUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (DocNo <= 0)
                throw new DomainException("Document number must be positive");

            if (DocSequence <= 0)
                throw new DomainException("Document sequence must be positive");

            if (KitInfo == null)
                throw new DomainException("Kit info is required");

            if (WarehouseInfo == null)
                throw new DomainException("Warehouse info is required");

            if (BatchInfo == null)
                throw new DomainException("Batch info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}