using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class AssembleKitItem : AggregateRoot
    {
        /// <summary> رقم مستند عملية تجميع الكيت. </summary>
        public long DocNo { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocSerial { get; private set; }
        /// <summary> تاريخ المستند. </summary>
        public DateTime DocDate { get; private set; }
        /// <summary> المستودع المحول منه. </summary>
        public long? FromWarehouse { get; private set; }
        /// <summary> المستودع المحول إليه. </summary>
        public long? ToWarehouse { get; private set; }
        /// <summary> نوع مبلغ المصروفات. </summary>
        public bool? ExpenseAmountType { get; private set; }
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
        /// <summary> مبلغ المصروفات. </summary>
        public int? ExpenseAmount { get; private set; }
        /// <summary> تم معالجة السطر (1=نعم). </summary>
        public bool? Processed { get; private set; }
        /// <summary> عملية معلقة (1=نعم). </summary>
        public bool? Hung { get; private set; }
        /// <summary> تم الترحيل للمحاسبة (1=نعم). </summary>
        public bool? DocPost { get; private set; }
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
        /// <summary> رقم الشركة. </summary>
        public short CompanyNo { get; private set; }
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
        /// <summary> نوع العملية. </summary>
        public int? TypeNo { get; private set; }
        /// <summary> رقم مستند الإنتاج. </summary>
        public bool? ProductionDoc { get; private set; }
        /// <summary> تسلسل السطر الرئيسي. </summary>
        public int? DocSequenceMain { get; private set; }
        /// <summary> نوع المصروف الإضافي. </summary>
        public bool? AddExpenseType { get; private set; }

        // Document Info
        public DocumentInfo DocumentInfo { get; private set; }
        
        // Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        
        // Audit Info
        public AuditInfo AuditInfo { get; private set; }

        // Navigation Properties
        public virtual Project Project { get; private set; }
        public virtual ICollection<AssembleKitItemDetail> AssembleKitItemDetails { get; private set; }

        private AssembleKitItem() { } // For EF Core

        public AssembleKitItem(
            DocumentInfo documentInfo,
            CompanyInfo companyInfo,
            AuditInfo auditInfo,
            long? fromWarehouse = null,
            long? toWarehouse = null,
            bool? expenseAmountType = null)
        {
            DocumentInfo = documentInfo;
            CompanyInfo = companyInfo;
            AuditInfo = auditInfo;
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;
            ExpenseAmountType = expenseAmountType;

            AssembleKitItemDetails = new List<AssembleKitItemDetail>();
            AddDomainEvent(new AssembleKitItemCreatedEvent(this));
        }

        public void UpdateWarehouseInfo(
            long? fromWarehouse,
            long? toWarehouse)
        {
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;

            AddDomainEvent(new AssembleKitItemWarehouseUpdatedEvent(this));
        }

        public void UpdateReferences(
            string? costCenterCode = null,
            string? projectNo = null,
            string? activityNo = null,
            int? stockRate = null,
            int? expenseAmount = null,
            long? employeeNo = null)
        {
            CostCenterCode = costCenterCode ?? CostCenterCode;
            ProjectNo = projectNo ?? ProjectNo;
            ActivityNo = activityNo ?? ActivityNo;
            StockRate = stockRate ?? StockRate;
            ExpenseAmount = expenseAmount ?? ExpenseAmount;
            EmployeeNo = employeeNo ?? EmployeeNo;

            AddDomainEvent(new AssembleKitItemReferencesUpdatedEvent(this));
        }

        public void UpdateSettings(
            bool? addExpenseType = null,
            int? typeNo = null,
            bool? productionDoc = null)
        {
            AddExpenseType = addExpenseType ?? AddExpenseType;
            TypeNo = typeNo ?? TypeNo;
            ProductionDoc = productionDoc ?? ProductionDoc;

            AddDomainEvent(new AssembleKitItemSettingsUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (DocumentInfo == null)
                throw new DomainException("Document info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}