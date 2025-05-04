using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// StockAdjustmentDetail Entity
/// </summary>
public class StockAdjustmentDetail : Entity<StockAdjustmentDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<StockAdjustment> _stockAdjustment = new List<StockAdjustment>();

    private StockAdjustmentDetail() { }

    public StockAdjustmentDetail(StockAdjustmentDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StockAdjustmentDetail
    /// المعرف الفريد لـ StockAdjustmentDetail
    /// </summary>
    public StockAdjustmentDetailId Id { get; private set; }

    /// <summary>
    /// AdjustmentType of the StockAdjustmentDetail
    /// AdjustmentType الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? AdjustmentType { get; private set; }

    /// <summary>
    /// DocNo of the StockAdjustmentDetail
    /// DocNo الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// WarehouseCode of the StockAdjustmentDetail
    /// WarehouseCode الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the StockAdjustmentDetail
    /// ExpireDate الخاص بـ StockAdjustmentDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the StockAdjustmentDetail
    /// BatchNumber الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// Barcode of the StockAdjustmentDetail
    /// Barcode الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// WeightedAverage of the StockAdjustmentDetail
    /// WeightedAverage الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? WeightedAverage { get; private set; }

    /// <summary>
    /// AvailableQuantity of the StockAdjustmentDetail
    /// AvailableQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// PlusMinus of the StockAdjustmentDetail
    /// PlusMinus الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PlusMinus { get; private set; }

    /// <summary>
    /// PSize of the StockAdjustmentDetail
    /// PSize الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the StockAdjustmentDetail
    /// PQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// UseSerialNumber of the StockAdjustmentDetail
    /// UseSerialNumber الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the StockAdjustmentDetail
    /// RecordNumber الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the StockAdjustmentDetail
    /// DocSequence الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the StockAdjustmentDetail
    /// ItemDescription الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// ManualPartialQuantity of the StockAdjustmentDetail
    /// ManualPartialQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ManualPartialQuantity { get; private set; }

    /// <summary>
    /// ManualAvailableQuantity of the StockAdjustmentDetail
    /// ManualAvailableQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ManualAvailableQuantity { get; private set; }

    /// <summary>
    /// PurchaseInvoicePrice of the StockAdjustmentDetail
    /// PurchaseInvoicePrice الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PurchaseInvoicePrice { get; private set; }

    /// <summary>
    /// PurchaseInvoiceItemQuantity of the StockAdjustmentDetail
    /// PurchaseInvoiceItemQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PurchaseInvoiceItemQuantity { get; private set; }

    /// <summary>
    /// PriceItemQuantity of the StockAdjustmentDetail
    /// PriceItemQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? PriceItemQuantity { get; private set; }

    /// <summary>
    /// BillDiscount of the StockAdjustmentDetail
    /// BillDiscount الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? BillDiscount { get; private set; }

    /// <summary>
    /// DocTypeRef of the StockAdjustmentDetail
    /// DocTypeRef الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the StockAdjustmentDetail
    /// DocNoRef الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the StockAdjustmentDetail
    /// DocSerRef الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// VendorCode of the StockAdjustmentDetail
    /// VendorCode الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the StockAdjustmentDetail
    /// CostCenterCode الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// IncomeQuantity of the StockAdjustmentDetail
    /// IncomeQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? IncomeQuantity { get; private set; }

    /// <summary>
    /// IncomeCost of the StockAdjustmentDetail
    /// IncomeCost الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? IncomeCost { get; private set; }

    /// <summary>
    /// BalanceQuantity of the StockAdjustmentDetail
    /// BalanceQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? BalanceQuantity { get; private set; }

    /// <summary>
    /// RealCost of the StockAdjustmentDetail
    /// RealCost الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? RealCost { get; private set; }

    /// <summary>
    /// ItemLength of the StockAdjustmentDetail
    /// ItemLength الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the StockAdjustmentDetail
    /// ItemWidth الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the StockAdjustmentDetail
    /// ItemHeightShort الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the StockAdjustmentDetail
    /// ItemNumberShort الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the StockAdjustmentDetail
    /// PostCode الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the StockAdjustmentDetail
    /// WeightedQuantity الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the StockAdjustmentDetail
    /// WeightedUnit الخاص بـ StockAdjustmentDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the StockAdjustmentDetail
    /// ArgumentNumber الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StockAdjustmentDetail
    /// CompanyNumberShort الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StockAdjustmentDetail
    /// BranchNumber الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StockAdjustmentDetail
    /// BranchYear الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StockAdjustmentDetail
    /// BranchUser الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSequenceRef of the StockAdjustmentDetail
    /// DocSequenceRef الخاص بـ StockAdjustmentDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<StockAdjustment> StockAdjustment => _stockAdjustment;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
