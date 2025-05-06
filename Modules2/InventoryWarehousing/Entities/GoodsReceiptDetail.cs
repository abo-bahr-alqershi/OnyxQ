using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptDetail Entity
/// </summary>
public class GoodsReceiptDetail : Entity<GoodsReceiptDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();
    private readonly List<GoodsReceiptNote> _goodsReceiptNote = new List<GoodsReceiptNote>();

    private GoodsReceiptDetail() { }

    public GoodsReceiptDetail(GoodsReceiptDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GoodsReceiptDetail
    /// المعرف الفريد لـ GoodsReceiptDetail
    /// </summary>
    public GoodsReceiptDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceType of the GoodsReceiptDetail
    /// PurchaseInvoiceType الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseInvoiceType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GoodsReceiptDetail
    /// GroupNumberFull الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// IncomeType of the GoodsReceiptDetail
    /// IncomeType الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// GroupDate of the GoodsReceiptDetail
    /// GroupDate الخاص بـ GoodsReceiptDetail
    /// </summary>
    public DateTime? GroupDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the GoodsReceiptDetail
    /// ItemQuantity الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the GoodsReceiptDetail
    /// FreeQuantity الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the GoodsReceiptDetail
    /// PSize الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the GoodsReceiptDetail
    /// PQuantity الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// CompanyQuantity of the GoodsReceiptDetail
    /// CompanyQuantity الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the GoodsReceiptDetail
    /// WarehouseGroupCode الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// CPrice of the GoodsReceiptDetail
    /// CPrice الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? CPrice { get; private set; }

    /// <summary>
    /// ItemPriceShort of the GoodsReceiptDetail
    /// ItemPriceShort الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the GoodsReceiptDetail
    /// StockCost الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the GoodsReceiptDetail
    /// StockRate الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// AccountRate of the GoodsReceiptDetail
    /// AccountRate الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// WeightedAverageBefore of the GoodsReceiptDetail
    /// WeightedAverageBefore الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? WeightedAverageBefore { get; private set; }

    /// <summary>
    /// WeightedAverageAfter of the GoodsReceiptDetail
    /// WeightedAverageAfter الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? WeightedAverageAfter { get; private set; }

    /// <summary>
    /// ExpireDate of the GoodsReceiptDetail
    /// ExpireDate الخاص بـ GoodsReceiptDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the GoodsReceiptDetail
    /// BatchNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the GoodsReceiptDetail
    /// PurchaseInvoiceNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// PurchaseType of the GoodsReceiptDetail
    /// PurchaseType الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// DocSer of the GoodsReceiptDetail
    /// DocSer الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocTypeRef of the GoodsReceiptDetail
    /// DocTypeRef الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the GoodsReceiptDetail
    /// DocJvTypeRef الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GoodsReceiptDetail
    /// DocNoRef الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the GoodsReceiptDetail
    /// DocSerRef الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the GoodsReceiptDetail
    /// DocSequenceRef الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// VendorCode of the GoodsReceiptDetail
    /// VendorCode الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// DisAmt of the GoodsReceiptDetail
    /// DisAmt الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatPercent of the GoodsReceiptDetail
    /// VatPercent الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the GoodsReceiptDetail
    /// VatAmount الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// DiffAmt of the GoodsReceiptDetail
    /// DiffAmt الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DiffAmt { get; private set; }

    /// <summary>
    /// UseSerialNumber of the GoodsReceiptDetail
    /// UseSerialNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GoodsReceiptDetail
    /// RecordNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ReceiverNumber of the GoodsReceiptDetail
    /// ReceiverNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// DocSequence of the GoodsReceiptDetail
    /// DocSequence الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// UseAttachment of the GoodsReceiptDetail
    /// UseAttachment الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the GoodsReceiptDetail
    /// ReceiveAttachment الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the GoodsReceiptDetail
    /// ItemDescription الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the GoodsReceiptDetail
    /// Barcode الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the GoodsReceiptDetail
    /// UnderSellingFlag الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GoodsReceiptDetail
    /// ExternalPostFlag الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemLength of the GoodsReceiptDetail
    /// ItemLength الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the GoodsReceiptDetail
    /// ItemWidth الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the GoodsReceiptDetail
    /// ItemHeightShort الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the GoodsReceiptDetail
    /// ItemNumberShort الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the GoodsReceiptDetail
    /// PostCode الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the GoodsReceiptDetail
    /// WeightedQuantity الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the GoodsReceiptDetail
    /// WeightedUnit الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the GoodsReceiptDetail
    /// ArgumentNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ContainerNumber of the GoodsReceiptDetail
    /// ContainerNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string ContainerNumber { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the GoodsReceiptDetail
    /// OtherAmountDiscount الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the GoodsReceiptDetail
    /// VatAmountOther الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptDetail
    /// CompanyNumberShort الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptDetail
    /// BranchNumber الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptDetail
    /// BranchYear الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptDetail
    /// BranchUser الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// OtherAmountItem of the GoodsReceiptDetail
    /// OtherAmountItem الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the GoodsReceiptDetail
    /// WebServiceTransferDataFlag الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the GoodsReceiptDetail
    /// WebServiceTransferDataDescription الخاص بـ GoodsReceiptDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

    /// <summary>
    /// DisAmtNotEffect of the GoodsReceiptDetail
    /// DisAmtNotEffect الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? DisAmtNotEffect { get; private set; }

    /// <summary>
    /// AvailableQuantityBefore of the GoodsReceiptDetail
    /// AvailableQuantityBefore الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? AvailableQuantityBefore { get; private set; }

    /// <summary>
    /// InvoiceCumulativeBalance of the GoodsReceiptDetail
    /// InvoiceCumulativeBalance الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeBalance { get; private set; }

    /// <summary>
    /// InvoiceWeightedAverageForce of the GoodsReceiptDetail
    /// InvoiceWeightedAverageForce الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceWeightedAverageForce { get; private set; }

    /// <summary>
    /// InvoiceCumulativeDifferenceFlag of the GoodsReceiptDetail
    /// InvoiceCumulativeDifferenceFlag الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeDifferenceFlag { get; private set; }

    /// <summary>
    /// InvoiceCumulativeDifference of the GoodsReceiptDetail
    /// InvoiceCumulativeDifference الخاص بـ GoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeDifference { get; private set; }

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
    public ICollection<ExchangeRate> ExchangeRate => _exchangeRate;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GoodsReceiptNote> GoodsReceiptNote => _goodsReceiptNote;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

