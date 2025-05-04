using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchGoodsReceiptDetail Entity
/// </summary>
public class BranchGoodsReceiptDetail : Entity<BranchGoodsReceiptDetailId>
{
    private BranchGoodsReceiptDetail() { }

    /// <summary>
    /// The unique identifier for the BranchGoodsReceiptDetail
    /// المعرف الفريد لـ BranchGoodsReceiptDetail
    /// </summary>
    public BranchGoodsReceiptDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceType of the BranchGoodsReceiptDetail
    /// PurchaseInvoiceType الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseInvoiceType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the BranchGoodsReceiptDetail
    /// GroupNumberFull الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the BranchGoodsReceiptDetail
    /// GuarantorSerial الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// IncomeType of the BranchGoodsReceiptDetail
    /// IncomeType الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// GroupDate of the BranchGoodsReceiptDetail
    /// GroupDate الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public DateTime? GroupDate { get; private set; }

    /// <summary>
    /// ItemCode of the BranchGoodsReceiptDetail
    /// ItemCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchGoodsReceiptDetail
    /// ItemUnit الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchGoodsReceiptDetail
    /// ItemQuantity الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchGoodsReceiptDetail
    /// FreeQuantity الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the BranchGoodsReceiptDetail
    /// PSize الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchGoodsReceiptDetail
    /// PQuantity الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// CompanyQuantity of the BranchGoodsReceiptDetail
    /// CompanyQuantity الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? CompanyQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchGoodsReceiptDetail
    /// WarehouseCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the BranchGoodsReceiptDetail
    /// WarehouseGroupCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// CPrice of the BranchGoodsReceiptDetail
    /// CPrice الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? CPrice { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchGoodsReceiptDetail
    /// ItemPriceShort الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchGoodsReceiptDetail
    /// StockCost الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the BranchGoodsReceiptDetail
    /// StockRate الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchGoodsReceiptDetail
    /// AccountCurrency الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchGoodsReceiptDetail
    /// AccountRate الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// WeightedAverageBefore of the BranchGoodsReceiptDetail
    /// WeightedAverageBefore الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WeightedAverageBefore { get; private set; }

    /// <summary>
    /// WeightedAverageAfter of the BranchGoodsReceiptDetail
    /// WeightedAverageAfter الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WeightedAverageAfter { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchGoodsReceiptDetail
    /// ExpireDate الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchGoodsReceiptDetail
    /// BatchNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchGoodsReceiptDetail
    /// CostCenterCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchGoodsReceiptDetail
    /// ProjectNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchGoodsReceiptDetail
    /// ActivityNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the BranchGoodsReceiptDetail
    /// PurchaseInvoiceNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// PurchaseType of the BranchGoodsReceiptDetail
    /// PurchaseType الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// DocSer of the BranchGoodsReceiptDetail
    /// DocSer الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchGoodsReceiptDetail
    /// DocTypeRef الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the BranchGoodsReceiptDetail
    /// DocJvTypeRef الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchGoodsReceiptDetail
    /// DocNoRef الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchGoodsReceiptDetail
    /// DocSerRef الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the BranchGoodsReceiptDetail
    /// DocSequenceRef الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// VendorCode of the BranchGoodsReceiptDetail
    /// VendorCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// DisAmt of the BranchGoodsReceiptDetail
    /// DisAmt الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatPercent of the BranchGoodsReceiptDetail
    /// VatPercent الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BranchGoodsReceiptDetail
    /// VatAmount الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// DiffAmt of the BranchGoodsReceiptDetail
    /// DiffAmt الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DiffAmt { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchGoodsReceiptDetail
    /// UseSerialNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchGoodsReceiptDetail
    /// RecordNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ReceiverNumber of the BranchGoodsReceiptDetail
    /// ReceiverNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchGoodsReceiptDetail
    /// DocSequence الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchGoodsReceiptDetail
    /// UseAttachment الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchGoodsReceiptDetail
    /// ReceiveAttachment الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchGoodsReceiptDetail
    /// ItemDescription الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BranchGoodsReceiptDetail
    /// Barcode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the BranchGoodsReceiptDetail
    /// UnderSellingFlag الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchGoodsReceiptDetail
    /// ExternalPostFlag الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemLength of the BranchGoodsReceiptDetail
    /// ItemLength الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchGoodsReceiptDetail
    /// ItemWidth الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchGoodsReceiptDetail
    /// ItemHeightShort الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchGoodsReceiptDetail
    /// ItemNumberShort الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the BranchGoodsReceiptDetail
    /// PostCode الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchGoodsReceiptDetail
    /// WeightedQuantity الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchGoodsReceiptDetail
    /// WeightedUnit الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ContainerNumber of the BranchGoodsReceiptDetail
    /// ContainerNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string ContainerNumber { get; private set; }

    /// <summary>
    /// DisAmtNotEffect of the BranchGoodsReceiptDetail
    /// DisAmtNotEffect الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? DisAmtNotEffect { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BranchGoodsReceiptDetail
    /// OtherAmountDiscount الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// OtherAmountItem of the BranchGoodsReceiptDetail
    /// OtherAmountItem الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchGoodsReceiptDetail
    /// VatAmountOther الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// WebServiceTransferDataDescription of the BranchGoodsReceiptDetail
    /// WebServiceTransferDataDescription الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public string WebServiceTransferDataDescription { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BranchGoodsReceiptDetail
    /// WebServiceTransferDataFlag الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchGoodsReceiptDetail
    /// CompanyNumberShort الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchGoodsReceiptDetail
    /// BranchNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchGoodsReceiptDetail
    /// BranchYear الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchGoodsReceiptDetail
    /// BranchUser الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchGoodsReceiptDetail
    /// ArgumentNumber الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// InvoiceCumulativeBalance of the BranchGoodsReceiptDetail
    /// InvoiceCumulativeBalance الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeBalance { get; private set; }

    /// <summary>
    /// InvoiceWeightedAverageForce of the BranchGoodsReceiptDetail
    /// InvoiceWeightedAverageForce الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceWeightedAverageForce { get; private set; }

    /// <summary>
    /// InvoiceCumulativeDifferenceFlag of the BranchGoodsReceiptDetail
    /// InvoiceCumulativeDifferenceFlag الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeDifferenceFlag { get; private set; }

    /// <summary>
    /// InvoiceCumulativeDifference of the BranchGoodsReceiptDetail
    /// InvoiceCumulativeDifference الخاص بـ BranchGoodsReceiptDetail
    /// </summary>
    public decimal? InvoiceCumulativeDifference { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    #endregion
}
}
