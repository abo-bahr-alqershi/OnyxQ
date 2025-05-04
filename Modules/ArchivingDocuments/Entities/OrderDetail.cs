using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// OrderDetail Entity
/// </summary>
public class OrderDetail : Entity<OrderDetailId>
{
    private OrderDetail() { }

    /// <summary>
    /// The unique identifier for the OrderDetail
    /// المعرف الفريد لـ OrderDetail
    /// </summary>
    public OrderDetailId Id { get; private set; }

    /// <summary>
    /// SalesOrderType of the OrderDetail
    /// SalesOrderType الخاص بـ OrderDetail
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// OrderNumber of the OrderDetail
    /// OrderNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// OrderSerial of the OrderDetail
    /// OrderSerial الخاص بـ OrderDetail
    /// </summary>
    public decimal? OrderSerial { get; private set; }

    /// <summary>
    /// ItemCode of the OrderDetail
    /// ItemCode الخاص بـ OrderDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the OrderDetail
    /// ItemQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the OrderDetail
    /// FreeQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the OrderDetail
    /// ItemUnit الخاص بـ OrderDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OrderDetail
    /// PSize الخاص بـ OrderDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the OrderDetail
    /// PQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the OrderDetail
    /// ItemPriceShort الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ReservationDate of the OrderDetail
    /// ReservationDate الخاص بـ OrderDetail
    /// </summary>
    public DateTime? ReservationDate { get; private set; }

    /// <summary>
    /// ReservationQuantity of the OrderDetail
    /// ReservationQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? ReservationQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the OrderDetail
    /// WarehouseCode الخاص بـ OrderDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReservedFlag of the OrderDetail
    /// ReservedFlag الخاص بـ OrderDetail
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the OrderDetail
    /// RecordNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Barcode of the OrderDetail
    /// Barcode الخاص بـ OrderDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the OrderDetail
    /// UseAttachment الخاص بـ OrderDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the OrderDetail
    /// ReceiveAttachment الخاص بـ OrderDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the OrderDetail
    /// ItemDescription الخاص بـ OrderDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OrderDetail
    /// ExternalPostFlag الخاص بـ OrderDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CanceledFlag of the OrderDetail
    /// CanceledFlag الخاص بـ OrderDetail
    /// </summary>
    public decimal? CanceledFlag { get; private set; }

    /// <summary>
    /// ExpireDate of the OrderDetail
    /// ExpireDate الخاص بـ OrderDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the OrderDetail
    /// BatchNumber الخاص بـ OrderDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// VatPercent of the OrderDetail
    /// VatPercent الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the OrderDetail
    /// VatAmount الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ItemLength of the OrderDetail
    /// ItemLength الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the OrderDetail
    /// ItemWidth الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the OrderDetail
    /// ItemHeightShort الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the OrderDetail
    /// ItemNumberShort الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the OrderDetail
    /// WeightedUnit الخاص بـ OrderDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the OrderDetail
    /// WeightedQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// DisAmt of the OrderDetail
    /// DisAmt الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the OrderDetail
    /// DisAmtMst الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the OrderDetail
    /// DisPer الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the OrderDetail
    /// DisAmtDtl الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the OrderDetail
    /// DisPer2 الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the OrderDetail
    /// DisAmtDtl2 الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the OrderDetail
    /// DisPer3 الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the OrderDetail
    /// DisAmtDtl3 الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the OrderDetail
    /// DisAmtDtlVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the OrderDetail
    /// DisAmtMstVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the OrderDetail
    /// VatAmountDiscountDetailVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the OrderDetail
    /// VatAmountAfterDiscount الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the OrderDetail
    /// VatAmountBeforeDiscount الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the OrderDetail
    /// VatAmountDiscountMasterVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DocSeq of the OrderDetail
    /// DocSeq الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// EmpNo of the OrderDetail
    /// EmpNo الخاص بـ OrderDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SubCustomerCode of the OrderDetail
    /// SubCustomerCode الخاص بـ OrderDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// FieldDetail1 of the OrderDetail
    /// FieldDetail1 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the OrderDetail
    /// FieldDetail2 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the OrderDetail
    /// FieldDetail3 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// PackageUnit of the OrderDetail
    /// PackageUnit الخاص بـ OrderDetail
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the OrderDetail
    /// PackageUnitSize الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the OrderDetail
    /// PackageQuantity الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the OrderDetail
    /// PackageLength الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the OrderDetail
    /// PackageWidth الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the OrderDetail
    /// PackageHeight الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the OrderDetail
    /// PackageSize الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the OrderDetail
    /// PackageWeight الخاص بـ OrderDetail
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the OrderDetail
    /// SalesInvoiceType الخاص بـ OrderDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// OtherAmount of the OrderDetail
    /// OtherAmount الخاص بـ OrderDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the OrderDetail
    /// InsuranceLoadPercent الخاص بـ OrderDetail
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the OrderDetail
    /// InsuranceLoadAmount الخاص بـ OrderDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the OrderDetail
    /// InsuranceAdditionalLimit الخاص بـ OrderDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the OrderDetail
    /// InsuranceApprovedCode الخاص بـ OrderDetail
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// ItemPriceVat of the OrderDetail
    /// ItemPriceVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// MeasurePrice of the OrderDetail
    /// MeasurePrice الخاص بـ OrderDetail
    /// </summary>
    public decimal? MeasurePrice { get; private set; }

    /// <summary>
    /// DocTypeRef of the OrderDetail
    /// DocTypeRef الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the OrderDetail
    /// DocNoRef الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the OrderDetail
    /// DocSerRef الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the OrderDetail
    /// DocSequenceRef الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// CostCenterCode of the OrderDetail
    /// CostCenterCode الخاص بـ OrderDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// StockCost of the OrderDetail
    /// StockCost الخاص بـ OrderDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// UsedItem of the OrderDetail
    /// UsedItem الخاص بـ OrderDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OrderDetail
    /// CompanyNumberShort الخاص بـ OrderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OrderDetail
    /// BranchNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OrderDetail
    /// BranchYear الخاص بـ OrderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OrderDetail
    /// BranchUser الخاص بـ OrderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ArgumentNumber of the OrderDetail
    /// ArgumentNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the OrderDetail
    /// OtherAmountDiscount الخاص بـ OrderDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the OrderDetail
    /// VatAmountOther الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// FTime of the OrderDetail
    /// FTime الخاص بـ OrderDetail
    /// </summary>
    public string FTime { get; private set; }

    /// <summary>
    /// TTime of the OrderDetail
    /// TTime الخاص بـ OrderDetail
    /// </summary>
    public string TTime { get; private set; }

    /// <summary>
    /// ProjectNumber of the OrderDetail
    /// ProjectNumber الخاص بـ OrderDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OrderDetail
    /// ActivityNumber الخاص بـ OrderDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the OrderDetail
    /// DisAmtAftrVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the OrderDetail
    /// DisAmtDtl2Vat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the OrderDetail
    /// DisAmtDtl3Vat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the OrderDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the OrderDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ OrderDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the OrderDetail
    /// PurchaseOrderNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the OrderDetail
    /// PurchaseOrderSerial الخاص بـ OrderDetail
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// FieldDetail4 of the OrderDetail
    /// FieldDetail4 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the OrderDetail
    /// FieldDetail5 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the OrderDetail
    /// FieldDetail6 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the OrderDetail
    /// FieldDetail7 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the OrderDetail
    /// FieldDetail8 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the OrderDetail
    /// FieldDetail9 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the OrderDetail
    /// FieldDetail10 الخاص بـ OrderDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// LevelNumber of the OrderDetail
    /// LevelNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceLevelNumber of the OrderDetail
    /// ItemPriceLevelNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? ItemPriceLevelNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OrderDetail
    /// BillDocumentTypeFull الخاص بـ OrderDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DisPerQtPrm of the OrderDetail
    /// DisPerQtPrm الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisPerQtPrm { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrmVat of the OrderDetail
    /// DisAmtDtlQtPrmVat الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrmVat { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrm of the OrderDetail
    /// DisAmtDtlQtPrm الخاص بـ OrderDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrm { get; private set; }

    /// <summary>
    /// DocSeqTmp of the OrderDetail
    /// DocSeqTmp الخاص بـ OrderDetail
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// PromoterGroupNumber of the OrderDetail
    /// PromoterGroupNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? PromoterGroupNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the OrderDetail
    /// QuotationPremiumSerial الخاص بـ OrderDetail
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the OrderDetail
    /// QuotationPremiumRecordNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the OrderDetail
    /// QuotationPremiumNumber الخاص بـ OrderDetail
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// OtherAmountItem of the OrderDetail
    /// OtherAmountItem الخاص بـ OrderDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the OrderDetail
    /// InsuranceAdditionalLimitMaster الخاص بـ OrderDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// FreeType of the OrderDetail
    /// FreeType الخاص بـ OrderDetail
    /// </summary>
    public decimal? FreeType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesOrder
    /// </summary>
    public SalesOrder SalesOrder { get; private set; }
    #endregion
}
}
