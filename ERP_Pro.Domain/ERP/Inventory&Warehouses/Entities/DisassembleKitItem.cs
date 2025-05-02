using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class DisassembleKitItem : AggregateRoot
    {
        #region Basic Info
        /// <summary> رقم مستند التفكيك. </summary>
        public long DocNo { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocSerial { get; private set; }
        /// <summary> تاريخ المستند. </summary>
        public DateTime DocDate { get; private set; }
        /// <summary> المستودع المحول منه. </summary>
        public long? FromWarehouse { get; private set; }
        /// <summary> المستودع المحول إليه. </summary>
        public long? ToWarehouse { get; private set; }
        /// <summary> مركز التكلفة. </summary>
        public string? CostCenterCode { get; private set; }
        /// <summary> رقم المشروع. </summary>
        public string? ProjectNo { get; private set; }
        /// <summary> رقم النشاط. </summary>
        public string? ActivityNo { get; private set; }
        /// <summary> سعر المخزون. </summary>
        public int? StockRate { get; private set; }
        /// <summary> وصف المستند. </summary>
        public string? DocDesc { get; private set; }
        /// <summary> رقم مرجعي إضافي. </summary>
        public string? RefNo { get; private set; }
        /// <summary> رقم مستند التجميع الأصلي. </summary>
        public int? AssembleDocNo { get; private set; }
        /// <summary> الرقم التسلسلي للتجميع الأصلي. </summary>
        public long? AssembleDocSer { get; private set; }
        /// <summary> تم الترحيل للمحاسبة (1=نعم). </summary>
        public bool? DocPost { get; private set; }
        /// <summary> عملية معلقة (1=نعم). </summary>
        public bool? Hung { get; private set; }
        /// <summary> رقم الموظف المرتبط. </summary>
        public long? EmployeeNo { get; private set; }
        /// <summary> المستخدم الذي أضاف السطر. </summary>
        public int? AddedByUserId { get; private set; }
        /// <summary> تاريخ الإضافة. </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر. </summary>
        public int? UpdatedByUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل. </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> المستخدم الذي رحل المستند. </summary>
        public int? PostUserId { get; private set; }
        /// <summary> تاريخ الترحيل. </summary>
        public DateTime? PostDate { get; private set; }
        /// <summary> المستخدم الذي ألغى الترحيل. </summary>
        public int? UnpostUserId { get; private set; }
        /// <summary> تاريخ إلغاء الترحيل. </summary>
        public DateTime? UnpostDate { get; private set; }
        /// <summary> مرجع التدقيق. </summary>
        public bool? AuditRef { get; private set; }
        /// <summary> وصف مرجع التدقيق. </summary>
        public string? AuditRefDesc { get; private set; }
        /// <summary> رقم المستخدم لمرجع التدقيق. </summary>
        public int? AuditRefUserId { get; private set; }
        /// <summary> تاريخ مرجع التدقيق. </summary>
        public DateTime? AuditRefDate { get; private set; }
        /// <summary> رقم الفرع. </summary>
        public int BranchNo { get; private set; }
        /// <summary> السنة المالية للفرع. </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع. </summary>
        public short? BranchUser { get; private set; }
        /// <summary> عدد مرات التعديل. </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> أولوية التقرير. </summary>
        public long? ReportPriority { get; private set; }
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        /// <summary> تسلسل السطر الرئيسي. </summary>
        public int? DocSequenceMain { get; private set; }
        /// <summary> نوع العملية. </summary>
        public int? TypeNo { get; private set; }
        #endregion

        #region Kit Info
        public DisassembleKitInfo KitInfo { get; private set; }
        #endregion

        #region Warehouse Info
        public WarehouseInfo WarehouseInfo { get; private set; }
        #endregion

        #region Document Info
        public DocumentInfo DocumentInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public Project Project { get; private set; }
        public ICollection<DisassembleKitItemDetail> DisassembleKitItemDetails { get; private set; }
        #endregion

        private DisassembleKitItem() 
        {
            DisassembleKitItemDetails = new List<DisassembleKitItemDetail>();
        }

        public static DisassembleKitItem Create(
            long docNo,
            long? docSerial,
            DateTime docDate,
            string? docDesc,
            string? refNo,
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? stockRate,
            DisassembleKitInfo kitInfo,
            WarehouseInfo warehouseInfo,
            DocumentInfo documentInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var item = new DisassembleKitItem
            {
                DocNo = docNo,
                DocSerial = docSerial,
                DocDate = docDate,
                DocDesc = docDesc,
                RefNo = refNo,
                CostCenterCode = costCenterCode,
                ProjectNo = projectNo,
                ActivityNo = activityNo,
                StockRate = stockRate,
                KitInfo = kitInfo,
                WarehouseInfo = warehouseInfo,
                DocumentInfo = documentInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            item.AddDomainEvent(new DisassembleKitItemCreatedEvent(item));
            return item;
        }

        public void UpdateKitInfo(
            DisassembleKitInfo kitInfo,
            int userId,
            string terminal)
        {
            KitInfo = kitInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemUpdatedEvent(this));
        }

        public void UpdateWarehouseInfo(
            WarehouseInfo warehouseInfo,
            int userId,
            string terminal)
        {
            WarehouseInfo = warehouseInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemUpdatedEvent(this));
        }

        public void UpdateCostInfo(
            string? costCenterCode,
            string? projectNo,
            string? activityNo,
            int? stockRate,
            int userId,
            string terminal)
        {
            CostCenterCode = costCenterCode;
            ProjectNo = projectNo;
            ActivityNo = activityNo;
            StockRate = stockRate;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new DisassembleKitItemUpdatedEvent(this));
        }

        public void AddDetail(DisassembleKitItemDetail detail)
        {
            if (detail == null)
                throw new DomainException("Detail cannot be null");

            ((List<DisassembleKitItemDetail>)DisassembleKitItemDetails).Add(detail);
            AddDomainEvent(new DisassembleKitItemDetailAddedEvent(this, detail));
        }

        private void ValidateState()
        {
            if (DocNo <= 0)
                throw new DomainException("Document number must be positive");

            if (DocDate == default)
                throw new DomainException("Document date is required");

            if (KitInfo == null)
                throw new DomainException("Kit info is required");

            if (WarehouseInfo == null)
                throw new DomainException("Warehouse info is required");

            if (DocumentInfo == null)
                throw new DomainException("Document info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}