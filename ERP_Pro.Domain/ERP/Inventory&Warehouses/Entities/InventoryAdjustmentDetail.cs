using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class InventoryAdjustmentDetail : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
    /// <summary> نوع التسوية. </summary>
        public short AdjustmentType { get; private set; }
    /// <summary> رقم مستند التسوية. </summary>
        public long DocumentNumber { get; private set; }
    /// <summary> الرقم التسلسلي للمستند. </summary>
        public long DocumentSerial { get; private set; }
        /// <summary> تسلسل السطر بالمستند. </summary>
        public long DocumentSequence { get; private set; }
    /// <summary> كود الصنف. </summary>
        public ItemCode ItemCode { get; private set; }
    /// <summary> وحدة الصنف. </summary>
    public string ItemUnit { get; private set; }
    /// <summary> حجم العبوة. </summary>
    public int PackSize { get; private set; }
        /// <summary> وصف الصنف. </summary>
        public string? ItemDescription { get; private set; }
        #endregion

        #region Quantities
        /// <summary> الكمية المتاحة. </summary>
        public int? AvailableQuantity { get; private set; }
        /// <summary> كمية الزيادة أو النقصان. </summary>
        public int? PlusMinus { get; private set; }
    /// <summary> كمية العبوة. </summary>
        public int? PackQuantity { get; private set; }
    /// <summary> كمية العبوة المدخلة يدويًا. </summary>
        public int? ManualPackQuantity { get; private set; }
    /// <summary> كمية العبوة المتاحة يدويًا. </summary>
        public int? ManualAvailablePackQuantity { get; private set; }
        /// <summary> كمية الزيادة في التسوية. </summary>
        public int? IncreaseQuantity { get; private set; }
        /// <summary> كمية الرصيد النهائي. </summary>
        public int? BalanceQuantity { get; private set; }
        #endregion

        #region Costs
        /// <summary> المتوسط المرجح للسعر. </summary>
        public int? WeightedAverage { get; private set; }
    /// <summary> سعر الشراء بالفاتورة. </summary>
    public int? PurchaseInvoicePrice { get; private set; }
    /// <summary> كمية الشراء بالفاتورة. </summary>
        public int? PurchaseInvoiceQuantity { get; private set; }
    /// <summary> كمية الشراء السابقة بالفاتورة. </summary>
        public int? PreviousInvoiceQuantity { get; private set; }
    /// <summary> خصم الفاتورة. </summary>
    public int? BillDiscount { get; private set; }
        /// <summary> تكلفة الزيادة في التسوية. </summary>
        public int? IncreaseCost { get; private set; }
        /// <summary> التكلفة الحقيقية. </summary>
        public int? RealCost { get; private set; }
        #endregion

        #region References
        /// <summary> كود المستودع. </summary>
        public long? WarehouseCode { get; private set; }
        /// <summary> رقم التشغيلة/الدفعة. </summary>
        public string? BatchNumber { get; private set; }
        /// <summary> تاريخ انتهاء الدفعة. </summary>
        public DateTime? ExpireDate { get; private set; }
        /// <summary> الباركود المستخدم. </summary>
        public string? Barcode { get; private set; }
    /// <summary> كود المورد. </summary>
    public string? VendorCode { get; private set; }
    /// <summary> مركز التكلفة. </summary>
    public string? CostCenterCode { get; private set; }
    /// <summary> رقم المشروع. </summary>
        public string? ProjectNumber { get; private set; }
    /// <summary> رقم النشاط. </summary>
        public string? ActivityNumber { get; private set; }
        /// <summary> كود الترحيل. </summary>
        public string? PostCode { get; private set; }
        /// <summary> نوع المستند المرجعي. </summary>
        public short? DocumentTypeReference { get; private set; }
        /// <summary> رقم المستند المرجعي. </summary>
        public long? DocumentNumberReference { get; private set; }
        /// <summary> الرقم التسلسلي للمستند المرجعي. </summary>
        public long? DocumentSerialReference { get; private set; }
        /// <summary> رقم مرجعي إضافي. </summary>
        public int? ArgumentNumber { get; private set; }
        /// <summary> رقم السطر الداخلي. </summary>
        public long? RecordNumber { get; private set; }
        /// <summary> تسلسل السطر المرجعي. </summary>
        public int? DocumentSequenceReference { get; private set; }
        #endregion

        #region Item Info
    /// <summary> طول العنصر. </summary>
    public int? ItemLength { get; private set; }
    /// <summary> عرض العنصر. </summary>
    public int? ItemWidth { get; private set; }
    /// <summary> ارتفاع العنصر. </summary>
    public int? ItemHeight { get; private set; }
    /// <summary> رقم العنصر الإضافي. </summary>
    public int? ItemNumber { get; private set; }
    /// <summary> كمية الوزن. </summary>
        public int? WeightQuantity { get; private set; }
    /// <summary> وحدة الوزن. </summary>
    public string? WeightUnit { get; private set; }
        /// <summary> علم استخدام الرقم التسلسلي. </summary>
        public bool? UseSerialNumber { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
    /// <summary> رقم الفرع. </summary>
        public int BranchNumber { get; private set; }
    /// <summary> السنة المالية للفرع. </summary>
    public short? BranchYear { get; private set; }
    /// <summary> مستخدم الفرع. </summary>
    public short BranchUser { get; private set; }
    /// <summary> عدد مرات التعديل. </summary>
    public long? UpdateCount { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual InventoryAdjustment InventoryAdjustment { get; private set; }
        public virtual Project Project { get; private set; }
        #endregion

        private InventoryAdjustmentDetail() { } // For EF Core

        public static InventoryAdjustmentDetail Create(
            short adjustmentType,
            long documentNumber,
            long documentSerial,
            long documentSequence,
            ItemCode itemCode,
            string itemUnit,
            int packSize,
            long? warehouseCode,
            CompanyInfo companyInfo,
            BranchInfo branchInfo)
        {
            var detail = new InventoryAdjustmentDetail
            {
                Id = Guid.NewGuid(),
                AdjustmentType = adjustmentType,
                DocumentNumber = documentNumber,
                DocumentSerial = documentSerial,
                DocumentSequence = documentSequence,
                ItemCode = itemCode,
                ItemUnit = itemUnit,
                PackSize = packSize,
                WarehouseCode = warehouseCode,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo
            };

            detail.AddDomainEvent(new InventoryAdjustmentDetailCreatedEvent(detail));
            return detail;
        }

        public void UpdateQuantities(
            int? availableQuantity,
            int? plusMinus,
            int? packQuantity = null,
            int? manualPackQuantity = null,
            int? manualAvailablePackQuantity = null,
            int? increaseQuantity = null,
            int? balanceQuantity = null)
        {
            var oldAvailableQuantity = AvailableQuantity;
            var oldPlusMinus = PlusMinus;
            var oldPackQuantity = PackQuantity;
            var oldManualPackQuantity = ManualPackQuantity;
            var oldManualAvailablePackQuantity = ManualAvailablePackQuantity;
            var oldIncreaseQuantity = IncreaseQuantity;
            var oldBalanceQuantity = BalanceQuantity;

            AvailableQuantity = availableQuantity;
            PlusMinus = plusMinus;
            PackQuantity = packQuantity;
            ManualPackQuantity = manualPackQuantity;
            ManualAvailablePackQuantity = manualAvailablePackQuantity;
            IncreaseQuantity = increaseQuantity;
            BalanceQuantity = balanceQuantity;

            AddDomainEvent(new InventoryAdjustmentDetailQuantitiesUpdatedEvent(
                this,
                oldAvailableQuantity, oldPlusMinus, oldPackQuantity,
                oldManualPackQuantity, oldManualAvailablePackQuantity,
                oldIncreaseQuantity, oldBalanceQuantity,
                availableQuantity, plusMinus, packQuantity,
                manualPackQuantity, manualAvailablePackQuantity,
                increaseQuantity, balanceQuantity));
        }

        public void UpdateCosts(
            int? weightedAverage,
            int? purchaseInvoicePrice = null,
            int? purchaseInvoiceQuantity = null,
            int? previousInvoiceQuantity = null,
            int? billDiscount = null,
            int? increaseCost = null,
            int? realCost = null)
        {
            var oldWeightedAverage = WeightedAverage;
            var oldPurchaseInvoicePrice = PurchaseInvoicePrice;
            var oldPurchaseInvoiceQuantity = PurchaseInvoiceQuantity;
            var oldPreviousInvoiceQuantity = PreviousInvoiceQuantity;
            var oldBillDiscount = BillDiscount;
            var oldIncreaseCost = IncreaseCost;
            var oldRealCost = RealCost;

            WeightedAverage = weightedAverage;
            PurchaseInvoicePrice = purchaseInvoicePrice;
            PurchaseInvoiceQuantity = purchaseInvoiceQuantity;
            PreviousInvoiceQuantity = previousInvoiceQuantity;
            BillDiscount = billDiscount;
            IncreaseCost = increaseCost;
            RealCost = realCost;

            AddDomainEvent(new InventoryAdjustmentDetailCostsUpdatedEvent(
                this,
                oldWeightedAverage, oldPurchaseInvoicePrice,
                oldPurchaseInvoiceQuantity, oldPreviousInvoiceQuantity,
                oldBillDiscount, oldIncreaseCost, oldRealCost,
                weightedAverage, purchaseInvoicePrice,
                purchaseInvoiceQuantity, previousInvoiceQuantity,
                billDiscount, increaseCost, realCost));
        }

        public void UpdateBatchInfo(string batchNumber, DateTime? expireDate)
        {
            var oldBatchNumber = BatchNumber;
            var oldExpireDate = ExpireDate;

            BatchNumber = batchNumber;
            ExpireDate = expireDate;

            AddDomainEvent(new InventoryAdjustmentDetailBatchInfoUpdatedEvent(
                this, oldBatchNumber, oldExpireDate, batchNumber, expireDate));
        }

        public void UpdateItemDimensions(
            int? length,
            int? width,
            int? height,
            int? number,
            int? weightQuantity = null,
            string? weightUnit = null)
        {
            var oldLength = ItemLength;
            var oldWidth = ItemWidth;
            var oldHeight = ItemHeight;
            var oldNumber = ItemNumber;
            var oldWeightQuantity = WeightQuantity;
            var oldWeightUnit = WeightUnit;

            ItemLength = length;
            ItemWidth = width;
            ItemHeight = height;
            ItemNumber = number;
            WeightQuantity = weightQuantity;
            WeightUnit = weightUnit;

            AddDomainEvent(new InventoryAdjustmentDetailDimensionsUpdatedEvent(
                this,
                oldLength, oldWidth, oldHeight, oldNumber,
                oldWeightQuantity, oldWeightUnit,
                length, width, height, number,
                weightQuantity, weightUnit));
        }

        public void UpdateReferences(
            string? vendorCode = null,
            string? costCenterCode = null,
            string? projectNumber = null,
            string? activityNumber = null,
            string? postCode = null,
            short? documentTypeReference = null,
            long? documentNumberReference = null,
            long? documentSerialReference = null,
            int? documentSequenceReference = null)
        {
            var oldVendorCode = VendorCode;
            var oldCostCenterCode = CostCenterCode;
            var oldProjectNumber = ProjectNumber;
            var oldActivityNumber = ActivityNumber;
            var oldPostCode = PostCode;
            var oldDocumentTypeReference = DocumentTypeReference;
            var oldDocumentNumberReference = DocumentNumberReference;
            var oldDocumentSerialReference = DocumentSerialReference;
            var oldDocumentSequenceReference = DocumentSequenceReference;

            VendorCode = vendorCode;
            CostCenterCode = costCenterCode;
            ProjectNumber = projectNumber;
            ActivityNumber = activityNumber;
            PostCode = postCode;
            DocumentTypeReference = documentTypeReference;
            DocumentNumberReference = documentNumberReference;
            DocumentSerialReference = documentSerialReference;
            DocumentSequenceReference = documentSequenceReference;

            AddDomainEvent(new InventoryAdjustmentDetailReferencesUpdatedEvent(
                this,
                oldVendorCode, oldCostCenterCode, oldProjectNumber,
                oldActivityNumber, oldPostCode, oldDocumentTypeReference,
                oldDocumentNumberReference, oldDocumentSerialReference,
                oldDocumentSequenceReference,
                vendorCode, costCenterCode, projectNumber,
                activityNumber, postCode, documentTypeReference,
                documentNumberReference, documentSerialReference,
                documentSequenceReference));
        }

        private void ValidateState()
        {
            if (DocumentNumber <= 0)
                throw new DomainException("Document number must be positive");

            if (DocumentSerial <= 0)
                throw new DomainException("Document serial must be positive");

            if (DocumentSequence <= 0)
                throw new DomainException("Document sequence must be positive");

            if (ItemCode == null)
                throw new DomainException("Item code is required");

            if (string.IsNullOrWhiteSpace(ItemUnit))
                throw new DomainException("Item unit is required");

            if (PackSize <= 0)
                throw new DomainException("Pack size must be positive");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");

            if (BranchInfo == null)
                throw new DomainException("Branch information is required");
        }
    }
}