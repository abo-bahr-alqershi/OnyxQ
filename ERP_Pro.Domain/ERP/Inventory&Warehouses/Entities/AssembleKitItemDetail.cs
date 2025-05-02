using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class AssembleKitItemDetail : Entity
    {
        /// <summary> رقم مستند التجميع. </summary>
        public long DocNo { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long? DocSerial { get; private set; }
        /// <summary> رقم الكيت. </summary>
        public string? KitItemNo { get; private set; }
        /// <summary> وحدة العنصر المجمع. </summary>
        public string ItemUnit { get; private set; }
        /// <summary> حجم العبوة. </summary>
        public int? PackSize { get; private set; }
        /// <summary> كمية العنصر. </summary>
        public int? ItemQty { get; private set; }
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
        /// <summary> تكلفة الكيت المجمعة. </summary>
        public int? KitCost { get; private set; }
        /// <summary> مبلغ المصروفات. </summary>
        public int? ExpenseAmount { get; private set; }
        /// <summary> رقم السطر الداخلي. </summary>
        public long? RecordNo { get; private set; }
        /// <summary> تسلسل السطر بالمستند. </summary>
        public long DocSequence { get; private set; }
        /// <summary> كود الترحيل. </summary>
        public string? PostCode { get; private set; }
        /// <summary> تاريخ انتهاء الدفعة. </summary>
        public DateTime? ExpireDate { get; private set; }
        /// <summary> رقم التشغيلة/الدفعة. </summary>
        public string? BatchNo { get; private set; }
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
        /// <summary> سعر العنصر. </summary>
        public int? ItemPrice { get; private set; }
        /// <summary> نوع المستند المرجعي. </summary>
        public int? DocTypeRef { get; private set; }
        /// <summary> رقم المستند المرجعي. </summary>
        public int? DocNoRef { get; private set; }
        /// <summary> الرقم التسلسلي للمستند المرجعي. </summary>
        public int? DocSerRef { get; private set; }
        /// <summary> تسلسل السطر المرجعي. </summary>
        public int? DocSequenceRef { get; private set; }
        /// <summary> تسلسل السطر الرئيسي. </summary>
        public int? DocSequenceMain { get; private set; }
        /// <summary> رقم فرعي للسطر. </summary>
        public int? RecordSq { get; private set; }
        public AssembleKitItem AssembleKitItem { get; private set; } // Navigation
        public Project Project { get; private set; } // Navigation

        private AssembleKitItemDetail() { } // For EF Core

        public AssembleKitItemDetail(
            long docNo,
            long docSequence,
            string itemUnit,
            CompanyInfo companyInfo,
            long? docSerial = null,
            string? kitItemNo = null,
            int? packSize = null,
            int? itemQty = null)
        {
            DocNo = docNo;
            DocSequence = docSequence;
            ItemUnit = itemUnit;
            CompanyInfo = companyInfo;
            DocSerial = docSerial;
            KitItemNo = kitItemNo;
            PackSize = packSize;
            ItemQty = itemQty;

            AddDomainEvent(new AssembleKitItemDetailCreatedEvent(this));
        }

        public void UpdateWarehouseInfo(
            long? fromWarehouse,
            long? toWarehouse)
        {
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;

            AddDomainEvent(new AssembleKitItemDetailWarehouseUpdatedEvent(this));
        }

        public void UpdateReferences(
            string? costCenterCode = null,
            string? projectNo = null,
            string? activityNo = null,
            int? kitCost = null,
            int? expenseAmount = null)
        {
            CostCenterCode = costCenterCode ?? CostCenterCode;
            ProjectNo = projectNo ?? ProjectNo;
            ActivityNo = activityNo ?? ActivityNo;
            KitCost = kitCost ?? KitCost;
            ExpenseAmount = expenseAmount ?? ExpenseAmount;

            AddDomainEvent(new AssembleKitItemDetailReferencesUpdatedEvent(this));
        }

        public void UpdateBatchInfo(
            string? batchNo = null,
            DateTime? expireDate = null)
        {
            BatchNo = batchNo ?? BatchNo;
            ExpireDate = expireDate ?? ExpireDate;

            AddDomainEvent(new AssembleKitItemDetailBatchUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (DocNo <= 0)
                throw new DomainException("Document number is required");

            if (DocSequence <= 0)
                throw new DomainException("Document sequence is required");

            if (string.IsNullOrWhiteSpace(ItemUnit))
                throw new DomainException("Item unit is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");
        }
    }
}