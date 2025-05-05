using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseOrderDetail Entity
/// </summary>
public class PurchaseOrderDetail : Entity<PurchaseOrderDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<PurchaseOrder> _purchaseOrder = new List<PurchaseOrder>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private PurchaseOrderDetail() { }

    public PurchaseOrderDetail(PurchaseOrderDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseOrderDetail
    /// المعرف الفريد لـ PurchaseOrderDetail
    /// </summary>
    public PurchaseOrderDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the PurchaseOrderDetail
    /// PurchaseOrderType الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the PurchaseOrderDetail
    /// PurchaseOrderNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseOrderDetail
    /// ItemQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the PurchaseOrderDetail
    /// FreeQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the PurchaseOrderDetail
    /// PSize الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseOrderDetail
    /// PQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// DocTypeRef of the PurchaseOrderDetail
    /// DocTypeRef الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// PriceNumber of the PurchaseOrderDetail
    /// PriceNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// PriceSerial of the PurchaseOrderDetail
    /// PriceSerial الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PriceSerial { get; private set; }

    /// <summary>
    /// QuotationNumber of the PurchaseOrderDetail
    /// QuotationNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? QuotationNumber { get; private set; }

    /// <summary>
    /// QuotationSerial of the PurchaseOrderDetail
    /// QuotationSerial الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? QuotationSerial { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PurchaseOrderDetail
    /// ItemPriceShort الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseOrderDetail
    /// RecordNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseOrderDetail
    /// ItemDescription الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the PurchaseOrderDetail
    /// Barcode الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the PurchaseOrderDetail
    /// UseAttachment الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PurchaseOrderDetail
    /// ReceiveAttachment الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// PurchaseInvoiceQuantity of the PurchaseOrderDetail
    /// PurchaseInvoiceQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PurchaseInvoiceQuantity { get; private set; }

    /// <summary>
    /// PurchaseInvoiceFreeQuantity of the PurchaseOrderDetail
    /// PurchaseInvoiceFreeQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PurchaseInvoiceFreeQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantity of the PurchaseOrderDetail
    /// AvailableQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// ItemCostWeightedAverage of the PurchaseOrderDetail
    /// ItemCostWeightedAverage الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemCostWeightedAverage { get; private set; }

    /// <summary>
    /// LastIncomePrice of the PurchaseOrderDetail
    /// LastIncomePrice الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? LastIncomePrice { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseOrderDetail
    /// DocSequence الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequencePrq of the PurchaseOrderDetail
    /// DocSequencePrq الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocSequencePrq { get; private set; }

    /// <summary>
    /// CanceledFlag of the PurchaseOrderDetail
    /// CanceledFlag الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? CanceledFlag { get; private set; }

    /// <summary>
    /// ExpireDate of the PurchaseOrderDetail
    /// ExpireDate الخاص بـ PurchaseOrderDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PurchaseOrderDetail
    /// BatchNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PurchaseOrderDetail
    /// ItemPriceVat الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseOrderDetail
    /// ItemLength الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseOrderDetail
    /// ItemWidth الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseOrderDetail
    /// ItemHeightShort الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseOrderDetail
    /// ItemNumberShort الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// DisAmt of the PurchaseOrderDetail
    /// DisAmt الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the PurchaseOrderDetail
    /// DisAmtMst الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the PurchaseOrderDetail
    /// DisPer الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PurchaseOrderDetail
    /// DisAmtDtl الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the PurchaseOrderDetail
    /// DisPer2 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the PurchaseOrderDetail
    /// DisAmtDtl2 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the PurchaseOrderDetail
    /// DisPer3 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the PurchaseOrderDetail
    /// DisAmtDtl3 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// UnitSize of the PurchaseOrderDetail
    /// UnitSize الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? UnitSize { get; private set; }

    /// <summary>
    /// UserQuantity of the PurchaseOrderDetail
    /// UserQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? UserQuantity { get; private set; }

    /// <summary>
    /// NotBillPreviousQuantity of the PurchaseOrderDetail
    /// NotBillPreviousQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? NotBillPreviousQuantity { get; private set; }

    /// <summary>
    /// BillPreviousQuantity of the PurchaseOrderDetail
    /// BillPreviousQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? BillPreviousQuantity { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseOrderDetail
    /// WeightedQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseOrderDetail
    /// WeightedUnit الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseOrderDetail
    /// CostCenterCode الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseOrderDetail
    /// ProjectNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseOrderDetail
    /// ActivityNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// OtherAmount of the PurchaseOrderDetail
    /// OtherAmount الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatPercent of the PurchaseOrderDetail
    /// VatPercent الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseOrderDetail
    /// VatAmount الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseOrderDetail
    /// ArgumentNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// DlvryDate of the PurchaseOrderDetail
    /// DlvryDate الخاص بـ PurchaseOrderDetail
    /// </summary>
    public DateTime? DlvryDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseOrderDetail
    /// CompanyNumberShort الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseOrderDetail
    /// BranchNumber الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseOrderDetail
    /// BranchYear الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseOrderDetail
    /// BranchUser الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PackageUnit of the PurchaseOrderDetail
    /// PackageUnit الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the PurchaseOrderDetail
    /// PackageUnitSize الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the PurchaseOrderDetail
    /// PackageQuantity الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the PurchaseOrderDetail
    /// PackageLength الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the PurchaseOrderDetail
    /// PackageWidth الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the PurchaseOrderDetail
    /// PackageHeight الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the PurchaseOrderDetail
    /// PackageSize الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the PurchaseOrderDetail
    /// PackageWeight الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// DocNoRef of the PurchaseOrderDetail
    /// DocNoRef الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PurchaseOrderDetail
    /// DocSerRef الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PurchaseOrderDetail
    /// DocSequenceRef الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// ProjectNumberReference of the PurchaseOrderDetail
    /// ProjectNumberReference الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string ProjectNumberReference { get; private set; }

    /// <summary>
    /// SalePrice of the PurchaseOrderDetail
    /// SalePrice الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? SalePrice { get; private set; }

    /// <summary>
    /// DocSeqTmp of the PurchaseOrderDetail
    /// DocSeqTmp الخاص بـ PurchaseOrderDetail
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// FieldDetail1 of the PurchaseOrderDetail
    /// FieldDetail1 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the PurchaseOrderDetail
    /// FieldDetail2 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the PurchaseOrderDetail
    /// FieldDetail3 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the PurchaseOrderDetail
    /// FieldDetail4 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the PurchaseOrderDetail
    /// FieldDetail5 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the PurchaseOrderDetail
    /// FieldDetail6 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the PurchaseOrderDetail
    /// FieldDetail7 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the PurchaseOrderDetail
    /// FieldDetail8 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the PurchaseOrderDetail
    /// FieldDetail9 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the PurchaseOrderDetail
    /// FieldDetail10 الخاص بـ PurchaseOrderDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PurchaseOrder> PurchaseOrder => _purchaseOrder;
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

