using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseOrderDetailBackupTemp Entity
/// </summary>
public class PurchaseOrderDetailBackupTemp : Entity<PurchaseOrderDetailBackupTempId>
{

    private PurchaseOrderDetailBackupTemp() { }

    public PurchaseOrderDetailBackupTemp(PurchaseOrderDetailBackupTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseOrderDetailBackupTemp
    /// المعرف الفريد لـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public PurchaseOrderDetailBackupTempId Id { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the PurchaseOrderDetailBackupTemp
    /// PurchaseOrderNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the PurchaseOrderDetailBackupTemp
    /// PurchaseOrderSerial الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// VendorCode of the PurchaseOrderDetailBackupTemp
    /// VendorCode الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// PurchaseOrderDate of the PurchaseOrderDetailBackupTemp
    /// PurchaseOrderDate الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public DateTime? PurchaseOrderDate { get; private set; }

    /// <summary>
    /// DocSeqTmp of the PurchaseOrderDetailBackupTemp
    /// DocSeqTmp الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// DocMSq of the PurchaseOrderDetailBackupTemp
    /// DocMSq الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// ItemCode of the PurchaseOrderDetailBackupTemp
    /// ItemCode الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseOrderDetailBackupTemp
    /// ItemQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the PurchaseOrderDetailBackupTemp
    /// FreeQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// PSize of the PurchaseOrderDetailBackupTemp
    /// PSize الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseOrderDetailBackupTemp
    /// PQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseOrderDetailBackupTemp
    /// WarehouseCode الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// DocTypeRef of the PurchaseOrderDetailBackupTemp
    /// DocTypeRef الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// PriceNumber of the PurchaseOrderDetailBackupTemp
    /// PriceNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// PriceSerial of the PurchaseOrderDetailBackupTemp
    /// PriceSerial الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PriceSerial { get; private set; }

    /// <summary>
    /// QuotationNumber of the PurchaseOrderDetailBackupTemp
    /// QuotationNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? QuotationNumber { get; private set; }

    /// <summary>
    /// QuotationSerial of the PurchaseOrderDetailBackupTemp
    /// QuotationSerial الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? QuotationSerial { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PurchaseOrderDetailBackupTemp
    /// ItemPriceShort الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseOrderDetailBackupTemp
    /// RecordNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseOrderDetailBackupTemp
    /// ItemDescription الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the PurchaseOrderDetailBackupTemp
    /// Barcode الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the PurchaseOrderDetailBackupTemp
    /// UseAttachment الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PurchaseOrderDetailBackupTemp
    /// ReceiveAttachment الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AvailableQuantity of the PurchaseOrderDetailBackupTemp
    /// AvailableQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseOrderDetailBackupTemp
    /// DocSequence الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequencePrq of the PurchaseOrderDetailBackupTemp
    /// DocSequencePrq الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocSequencePrq { get; private set; }

    /// <summary>
    /// CanceledFlag of the PurchaseOrderDetailBackupTemp
    /// CanceledFlag الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? CanceledFlag { get; private set; }

    /// <summary>
    /// ExpireDate of the PurchaseOrderDetailBackupTemp
    /// ExpireDate الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PurchaseOrderDetailBackupTemp
    /// BatchNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseOrderDetailBackupTemp
    /// ItemLength الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseOrderDetailBackupTemp
    /// ItemWidth الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseOrderDetailBackupTemp
    /// ItemHeightShort الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseOrderDetailBackupTemp
    /// ItemNumberShort الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// DisAmt of the PurchaseOrderDetailBackupTemp
    /// DisAmt الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the PurchaseOrderDetailBackupTemp
    /// DisAmtMst الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisPer of the PurchaseOrderDetailBackupTemp
    /// DisPer الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PurchaseOrderDetailBackupTemp
    /// DisAmtDtl الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the PurchaseOrderDetailBackupTemp
    /// DisPer2 الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the PurchaseOrderDetailBackupTemp
    /// DisAmtDtl2 الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the PurchaseOrderDetailBackupTemp
    /// DisPer3 الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the PurchaseOrderDetailBackupTemp
    /// DisAmtDtl3 الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// UnitSize of the PurchaseOrderDetailBackupTemp
    /// UnitSize الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? UnitSize { get; private set; }

    /// <summary>
    /// UserQuantity of the PurchaseOrderDetailBackupTemp
    /// UserQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? UserQuantity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseOrderDetailBackupTemp
    /// CompanyNumberShort الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseOrderDetailBackupTemp
    /// BranchNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseOrderDetailBackupTemp
    /// BranchYear الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseOrderDetailBackupTemp
    /// BranchUser الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the PurchaseOrderDetailBackupTemp
    /// ItemUnit الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseOrderDetailBackupTemp
    /// WeightedQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseOrderDetailBackupTemp
    /// CostCenterCode الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseOrderDetailBackupTemp
    /// ProjectNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseOrderDetailBackupTemp
    /// ActivityNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseOrderDetailBackupTemp
    /// WeightedUnit الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// OtherAmount of the PurchaseOrderDetailBackupTemp
    /// OtherAmount الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PurchaseOrderDetailBackupTemp
    /// ItemPriceVat الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseOrderDetailBackupTemp
    /// VatAmount الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the PurchaseOrderDetailBackupTemp
    /// VatPercent الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseOrderDetailBackupTemp
    /// ArgumentNumber الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// DlvryDate of the PurchaseOrderDetailBackupTemp
    /// DlvryDate الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public DateTime? DlvryDate { get; private set; }

    /// <summary>
    /// PackageUnit of the PurchaseOrderDetailBackupTemp
    /// PackageUnit الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the PurchaseOrderDetailBackupTemp
    /// PackageUnitSize الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the PurchaseOrderDetailBackupTemp
    /// PackageQuantity الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the PurchaseOrderDetailBackupTemp
    /// PackageLength الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the PurchaseOrderDetailBackupTemp
    /// PackageWidth الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the PurchaseOrderDetailBackupTemp
    /// PackageHeight الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the PurchaseOrderDetailBackupTemp
    /// PackageSize الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the PurchaseOrderDetailBackupTemp
    /// PackageWeight الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// DocNoRef of the PurchaseOrderDetailBackupTemp
    /// DocNoRef الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PurchaseOrderDetailBackupTemp
    /// DocSerRef الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PurchaseOrderDetailBackupTemp
    /// DocSequenceRef الخاص بـ PurchaseOrderDetailBackupTemp
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
