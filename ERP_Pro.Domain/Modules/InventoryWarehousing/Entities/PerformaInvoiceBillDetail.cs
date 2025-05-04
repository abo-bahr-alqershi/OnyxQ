using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillDetail Entity
/// </summary>
public class PerformaInvoiceBillDetail : Entity<PerformaInvoiceBillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<PerformaInvoiceBillMaster> _performaInvoiceBillMaster = new List<PerformaInvoiceBillMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private PerformaInvoiceBillDetail() { }

    public PerformaInvoiceBillDetail(PerformaInvoiceBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillDetail
    /// المعرف الفريد لـ PerformaInvoiceBillDetail
    /// </summary>
    public PerformaInvoiceBillDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseType of the PerformaInvoiceBillDetail
    /// PurchaseType الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the PerformaInvoiceBillDetail
    /// BillDocumentTypeFull الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillDetail
    /// BillNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ItemNameShort of the PerformaInvoiceBillDetail
    /// ItemNameShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string ItemNameShort { get; private set; }

    /// <summary>
    /// ItemQuantity of the PerformaInvoiceBillDetail
    /// ItemQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the PerformaInvoiceBillDetail
    /// FreeQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the PerformaInvoiceBillDetail
    /// PSize الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PerformaInvoiceBillDetail
    /// PQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PerformaInvoiceBillDetail
    /// ItemPriceShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the PerformaInvoiceBillDetail
    /// StockCost الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// IncomeQuantity of the PerformaInvoiceBillDetail
    /// IncomeQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? IncomeQuantity { get; private set; }

    /// <summary>
    /// IncomeFreeQuantity of the PerformaInvoiceBillDetail
    /// IncomeFreeQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? IncomeFreeQuantity { get; private set; }

    /// <summary>
    /// ExpireDate of the PerformaInvoiceBillDetail
    /// ExpireDate الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PerformaInvoiceBillDetail
    /// BatchNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisAmtMst of the PerformaInvoiceBillDetail
    /// DisAmtMst الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the PerformaInvoiceBillDetail
    /// DisPer الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PerformaInvoiceBillDetail
    /// DisAmtDtl الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the PerformaInvoiceBillDetail
    /// DisPer2 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the PerformaInvoiceBillDetail
    /// DisAmtDtl2 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the PerformaInvoiceBillDetail
    /// DisPer3 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the PerformaInvoiceBillDetail
    /// DisAmtDtl3 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmt of the PerformaInvoiceBillDetail
    /// DisAmt الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatPercent of the PerformaInvoiceBillDetail
    /// VatPercent الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PerformaInvoiceBillDetail
    /// VatAmount الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// AdditionalAmount of the PerformaInvoiceBillDetail
    /// AdditionalAmount الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? AdditionalAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the PerformaInvoiceBillDetail
    /// OtherAmount الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the PerformaInvoiceBillDetail
    /// UseSerialNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the PerformaInvoiceBillDetail
    /// RecordNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the PerformaInvoiceBillDetail
    /// DocSequence الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceGrnPo of the PerformaInvoiceBillDetail
    /// DocSequenceGrnPo الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocSequenceGrnPo { get; private set; }

    /// <summary>
    /// ItemDescription of the PerformaInvoiceBillDetail
    /// ItemDescription الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the PerformaInvoiceBillDetail
    /// Barcode الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the PerformaInvoiceBillDetail
    /// PurchaseOrderNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the PerformaInvoiceBillDetail
    /// PurchaseOrderSerial الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// GoodsReceiptNumber of the PerformaInvoiceBillDetail
    /// GoodsReceiptNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? GoodsReceiptNumber { get; private set; }

    /// <summary>
    /// GoodsReceiptSerial of the PerformaInvoiceBillDetail
    /// GoodsReceiptSerial الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? GoodsReceiptSerial { get; private set; }

    /// <summary>
    /// UseAttachment of the PerformaInvoiceBillDetail
    /// UseAttachment الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PerformaInvoiceBillDetail
    /// ReceiveAttachment الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisAmtNotEffect of the PerformaInvoiceBillDetail
    /// DisAmtNotEffect الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DisAmtNotEffect { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the PerformaInvoiceBillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the PerformaInvoiceBillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// ItemLength of the PerformaInvoiceBillDetail
    /// ItemLength الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PerformaInvoiceBillDetail
    /// ItemWidth الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PerformaInvoiceBillDetail
    /// ItemHeightShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PerformaInvoiceBillDetail
    /// ItemNumberShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the PerformaInvoiceBillDetail
    /// PostCode الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// UnitSize of the PerformaInvoiceBillDetail
    /// UnitSize الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? UnitSize { get; private set; }

    /// <summary>
    /// UserQuantity of the PerformaInvoiceBillDetail
    /// UserQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? UserQuantity { get; private set; }

    /// <summary>
    /// GroupReference of the PerformaInvoiceBillDetail
    /// GroupReference الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string GroupReference { get; private set; }

    /// <summary>
    /// DocType of the PerformaInvoiceBillDetail
    /// DocType الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocSequencePo of the PerformaInvoiceBillDetail
    /// DocSequencePo الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocSequencePo { get; private set; }

    /// <summary>
    /// PurchaseOrderOrderNumber of the PerformaInvoiceBillDetail
    /// PurchaseOrderOrderNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string PurchaseOrderOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderOrderSerial of the PerformaInvoiceBillDetail
    /// PurchaseOrderOrderSerial الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string PurchaseOrderOrderSerial { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PerformaInvoiceBillDetail
    /// WeightedQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the PerformaInvoiceBillDetail
    /// WeightedUnit الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ServiceItemShort of the PerformaInvoiceBillDetail
    /// ServiceItemShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ServiceItemShort { get; private set; }

    /// <summary>
    /// FreeQuantityProfit of the PerformaInvoiceBillDetail
    /// FreeQuantityProfit الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? FreeQuantityProfit { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PerformaInvoiceBillDetail
    /// ItemPriceVat الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ContractNumber of the PerformaInvoiceBillDetail
    /// ContractNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContainerNumber of the PerformaInvoiceBillDetail
    /// ContainerNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string ContainerNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the PerformaInvoiceBillDetail
    /// ContractSerial الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the PerformaInvoiceBillDetail
    /// ContractBatchNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// FreightNumber of the PerformaInvoiceBillDetail
    /// FreightNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FreightNumber { get; private set; }

    /// <summary>
    /// FreightSerial of the PerformaInvoiceBillDetail
    /// FreightSerial الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FreightSerial { get; private set; }

    /// <summary>
    /// FreightDocumentSequence of the PerformaInvoiceBillDetail
    /// FreightDocumentSequence الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? FreightDocumentSequence { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the PerformaInvoiceBillDetail
    /// OtherAmountDiscount الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the PerformaInvoiceBillDetail
    /// VatAmountOther الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// DocNoRef of the PerformaInvoiceBillDetail
    /// DocNoRef الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PerformaInvoiceBillDetail
    /// DocSerRef الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypRef of the PerformaInvoiceBillDetail
    /// DocTypRef الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PerformaInvoiceBillDetail
    /// DocSequenceRef الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillDetail
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillDetail
    /// BranchNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillDetail
    /// BranchYear الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillDetail
    /// BranchUser الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PerformaInvoiceBillDetail
    /// ArgumentNumber الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// OtherAmountItem of the PerformaInvoiceBillDetail
    /// OtherAmountItem الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// PackageUnit of the PerformaInvoiceBillDetail
    /// PackageUnit الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the PerformaInvoiceBillDetail
    /// PackageUnitSize الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the PerformaInvoiceBillDetail
    /// PackageQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the PerformaInvoiceBillDetail
    /// PackageLength الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the PerformaInvoiceBillDetail
    /// PackageWidth الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the PerformaInvoiceBillDetail
    /// PackageHeight الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the PerformaInvoiceBillDetail
    /// PackageSize الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the PerformaInvoiceBillDetail
    /// PackageWeight الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// SalePrice of the PerformaInvoiceBillDetail
    /// SalePrice الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? SalePrice { get; private set; }

    /// <summary>
    /// FieldDetail1 of the PerformaInvoiceBillDetail
    /// FieldDetail1 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the PerformaInvoiceBillDetail
    /// FieldDetail2 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the PerformaInvoiceBillDetail
    /// FieldDetail3 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the PerformaInvoiceBillDetail
    /// FieldDetail4 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the PerformaInvoiceBillDetail
    /// FieldDetail5 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the PerformaInvoiceBillDetail
    /// FieldDetail6 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the PerformaInvoiceBillDetail
    /// FieldDetail7 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the PerformaInvoiceBillDetail
    /// FieldDetail8 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the PerformaInvoiceBillDetail
    /// FieldDetail9 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the PerformaInvoiceBillDetail
    /// FieldDetail10 الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// BarcodePrintFlag of the PerformaInvoiceBillDetail
    /// BarcodePrintFlag الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? BarcodePrintFlag { get; private set; }

    /// <summary>
    /// LastIncomePrice of the PerformaInvoiceBillDetail
    /// LastIncomePrice الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? LastIncomePrice { get; private set; }

    /// <summary>
    /// ActualQuantity of the PerformaInvoiceBillDetail
    /// ActualQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? ActualQuantity { get; private set; }

    /// <summary>
    /// LossQuantity of the PerformaInvoiceBillDetail
    /// LossQuantity الخاص بـ PerformaInvoiceBillDetail
    /// </summary>
    public decimal? LossQuantity { get; private set; }

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
    public ICollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMaster => _performaInvoiceBillMaster;
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
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
