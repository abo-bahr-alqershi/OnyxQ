using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory&Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory&Warehouses.Entities
{
    public class StockCount : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم مستند الجرد أو التسوية. </summary>
        public long? DocumentNumber { get; private set; }
        /// <summary> تاريخ المستند. </summary>
        public DateTime? DocumentDate { get; private set; }
        /// <summary> تاريخ دخول الصنف. </summary>
        public DateTime? IncomeDate { get; private set; }
        #endregion

        #region Item Info
        /// <summary> كود الصنف. </summary>
        public string? ItemCode { get; private set; }
        /// <summary> اسم الصنف. </summary>
        public string? ItemName { get; private set; }
        /// <summary> وحدة الصنف. </summary>
        public string ItemUnit { get; private set; }
        /// <summary> حجم العبوة. </summary>
        public int? PackSize { get; private set; }
        /// <summary> كود المستودع. </summary>
        public long? WarehouseCode { get; private set; }
        /// <summary> رقم التشغيلة/الدفعة. </summary>
        public string BatchNumber { get; private set; }
        /// <summary> كمية الافتتاح. </summary>
        public int? OpeningQuantity { get; private set; }
        /// <summary> كمية الوارد. </summary>
        public int? IncomingQuantity { get; private set; }
        /// <summary> كمية المبيعات. </summary>
        public int? SaleQuantity { get; private set; }
        /// <summary> كمية نقطة البيع. </summary>
        public int? PointOfSaleQuantity { get; private set; }
        /// <summary> صافي المبيعات. </summary>
        public int? NetSaleQuantity { get; private set; }
        /// <summary> الكمية المتاحة. </summary>
        public int? AvailableQuantity { get; private set; }
        /// <summary> متوسط المبيعات اليومي. </summary>
        public int? AverageDailySaleQuantity { get; private set; }
        /// <summary> متوسط المبيعات العام. </summary>
        public int? AverageGeneralSaleQuantity { get; private set; }
        /// <summary> نسبة المبيعات للكمية. </summary>
        public int? SaleQuantityPercentage { get; private set; }
        /// <summary> عمر المبيعات للصنف. </summary>
        public int? ItemSaleAge { get; private set; }
        /// <summary> فترة عمر مبيعات الصنف. </summary>
        public int? ItemSaleAgePeriod { get; private set; }
        /// <summary> عمر الصنف في المخزون. </summary>
        public int? ItemAge { get; private set; }
        /// <summary> نسبة الصنف. </summary>
        public int? ItemRatio { get; private set; }
        /// <summary> نسبة مبيعات الصنف. </summary>
        public int? ItemSaleRatio { get; private set; }
        /// <summary> كمية لم يتم استلامها. </summary>
        public int? NotReceivedQuantity { get; private set; }
        /// <summary> مجموع كمية الوارد. </summary>
        public int? TotalIncomingQuantity { get; private set; }
        /// <summary> كمية محولة من المستودع. </summary>
        public int? QuantityFromWarehouse { get; private set; }
        /// <summary> كمية محولة إلى المستودع. </summary>
        public int? QuantityToWarehouse { get; private set; }
        /// <summary> متوسط الكمية لفترة محددة. </summary>
        public int? AverageQuantityPeriod { get; private set; }
        /// <summary> كود مجموعة الصنف. </summary>
        public string? GroupCode { get; private set; }
        /// <summary> كود تصنيف المجموعة. </summary>
        public string? GroupClassCode { get; private set; }
        /// <summary> كود مدير الصنف. </summary>
        public string? ManagerCode { get; private set; }
        /// <summary> كود المجموعة الفرعية. </summary>
        public string? SubGroupCode { get; private set; }
        /// <summary> رقم مساعد. </summary>
        public string? AssistantNumber { get; private set; }
        /// <summary> رقم تفصيلي. </summary>
        public string? DetailNumber { get; private set; }
        /// <summary> رقم النشاط المرتبط. </summary>
        public int? ActivityNumber { get; private set; }
        /// <summary> نوع الصنف. </summary>
        public int? ItemType { get; private set; }
        /// <summary> رقم المدينة. </summary>
        public long? CityNumber { get; private set; }
        /// <summary> رقم المنطقة. </summary>
        public long? RegionCode { get; private set; }
        /// <summary> ترتيب الصنف. </summary>
        public int? ItemOrder { get; private set; }
        /// <summary> عدد أيام الفترة. </summary>
        public int? PeriodDays { get; private set; }
        #endregion

        #region Metrics
        public SaleMetrics Metrics { get; private set; }
        #endregion

        #region Location
        public LocationInfo Location { get; private set; }
        #endregion

        #region Status
        /// <summary> تم معالجة السطر (1=نعم). </summary>
        public bool? IsProcessed { get; private set; }
        /// <summary> أولوية التقرير. </summary>
        public long? ReportPriority { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        /// <summary> رقم الفرع. </summary>
        public int BranchNumber { get; private set; }
        /// <summary> السنة المالية للفرع. </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع. </summary>
        public short? BranchUser { get; private set; }
        #endregion

        #region Audit Info
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
        /// <summary> الجهاز عند الإضافة. </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> الجهاز عند التعديل. </summary>
        public string? UpdatedTerminal { get; private set; }
        #endregion

        private StockCount() { } // For EF Core

        public static StockCount Create(
            long documentNumber,
            DateTime documentDate,
            ItemInfo itemInfo,
            string batchNumber,
            long warehouseCode,
            CompanyInfo companyInfo,
            BranchInfo branchInfo)
        {
            var stockCount = new StockCount
            {
                Id = Guid.NewGuid(),
                DocumentNumber = documentNumber,
                DocumentDate = documentDate,
                ItemInfo = itemInfo,
                BatchNumber = batchNumber,
                WarehouseCode = warehouseCode,
                CompanyInfo = companyInfo,
                BranchInfo = branchInfo,
                IsProcessed = false,
                AddedDate = DateTime.UtcNow,
                Quantities = StockQuantities.Create(),
                Metrics = SaleMetrics.Create(),
                Location = LocationInfo.Create()
            };

            stockCount.AddDomainEvent(new StockCountCreatedEvent(stockCount));
            return stockCount;
        }

        public void UpdateQuantities(StockQuantities quantities)
        {
            var oldQuantities = Quantities;
            Quantities = quantities;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new StockCountQuantitiesUpdatedEvent(this, oldQuantities, quantities));
        }

        public void UpdateMetrics(SaleMetrics metrics)
        {
            var oldMetrics = Metrics;
            Metrics = metrics;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new StockCountMetricsUpdatedEvent(this, oldMetrics, metrics));
        }

        public void UpdateLocation(LocationInfo location)
        {
            var oldLocation = Location;
            Location = location;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new StockCountLocationUpdatedEvent(this, oldLocation, location));
        }

        public void MarkAsProcessed(int userId)
        {
            if (IsProcessed == true)
                throw new DomainException("Stock count is already processed");

            IsProcessed = true;
            UpdatedUserId = userId;
            UpdatedDate = DateTime.UtcNow;

            AddDomainEvent(new StockCountProcessedEvent(this, userId));
        }

        private void ValidateState()
        {
            if (!DocumentNumber.HasValue)
                throw new DomainException("Document number is required");

            if (!DocumentDate.HasValue)
                throw new DomainException("Document date is required");

            if (ItemInfo == null)
                throw new DomainException("Item information is required");

            if (string.IsNullOrWhiteSpace(BatchNumber))
                throw new DomainException("Batch number is required");

            if (!WarehouseCode.HasValue)
                throw new DomainException("Warehouse code is required");
        }
    }
}