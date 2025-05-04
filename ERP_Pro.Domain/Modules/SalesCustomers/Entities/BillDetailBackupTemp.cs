using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillDetailBackupTemp Entity
/// </summary>
public class BillDetailBackupTemp : Entity<BillDetailBackupTempId>
{

    private BillDetailBackupTemp() { }

    public BillDetailBackupTemp(BillDetailBackupTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BillDetailBackupTemp
    /// المعرف الفريد لـ BillDetailBackupTemp
    /// </summary>
    public BillDetailBackupTempId Id { get; private set; }

    /// <summary>
    /// BillNumber of the BillDetailBackupTemp
    /// BillNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDate of the BillDetailBackupTemp
    /// BillDate الخاص بـ BillDetailBackupTemp
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// CCode of the BillDetailBackupTemp
    /// CCode الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the BillDetailBackupTemp
    /// CName الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountDescription of the BillDetailBackupTemp
    /// AccountDescription الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ItemCode of the BillDetailBackupTemp
    /// ItemCode الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BillDetailBackupTemp
    /// ItemUnit الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BillDetailBackupTemp
    /// PSize الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the BillDetailBackupTemp
    /// WarehouseCode الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the BillDetailBackupTemp
    /// ExpireDate الخاص بـ BillDetailBackupTemp
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BillDetailBackupTemp
    /// BatchNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// WeightedUnit of the BillDetailBackupTemp
    /// WeightedUnit الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BillDetailBackupTemp
    /// WeightedQuantity الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BillDetailBackupTemp
    /// ArgumentNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ItemLength of the BillDetailBackupTemp
    /// ItemLength الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BillDetailBackupTemp
    /// ItemWidth الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BillDetailBackupTemp
    /// ItemHeightShort الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BillDetailBackupTemp
    /// ItemNumberShort الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// MeasurePrice of the BillDetailBackupTemp
    /// MeasurePrice الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? MeasurePrice { get; private set; }

    /// <summary>
    /// ItemQuantity of the BillDetailBackupTemp
    /// ItemQuantity الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BillDetailBackupTemp
    /// FreeQuantity الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// LevelNumber of the BillDetailBackupTemp
    /// LevelNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BillDetailBackupTemp
    /// ItemPriceShort الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemPriceVat of the BillDetailBackupTemp
    /// ItemPriceVat الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// DisPer of the BillDetailBackupTemp
    /// DisPer الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the BillDetailBackupTemp
    /// DisAmtDtl الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the BillDetailBackupTemp
    /// DisAmtDtlVat الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisPer2 of the BillDetailBackupTemp
    /// DisPer2 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the BillDetailBackupTemp
    /// DisAmtDtl2 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the BillDetailBackupTemp
    /// DisAmtDtl2Vat الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisPer3 of the BillDetailBackupTemp
    /// DisPer3 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the BillDetailBackupTemp
    /// DisAmtDtl3 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the BillDetailBackupTemp
    /// DisAmtDtl3Vat الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// CostCenterCode of the BillDetailBackupTemp
    /// CostCenterCode الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BillDetailBackupTemp
    /// ProjectNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BillDetailBackupTemp
    /// ActivityNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// EmpNo of the BillDetailBackupTemp
    /// EmpNo الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ItemDescription of the BillDetailBackupTemp
    /// ItemDescription الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BillDetailBackupTemp
    /// Barcode الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// RecordNumber of the BillDetailBackupTemp
    /// RecordNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the BillDetailBackupTemp
    /// BranchNumber الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// FieldDetail1 of the BillDetailBackupTemp
    /// FieldDetail1 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the BillDetailBackupTemp
    /// FieldDetail2 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the BillDetailBackupTemp
    /// FieldDetail3 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the BillDetailBackupTemp
    /// FieldDetail4 الخاص بـ BillDetailBackupTemp
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// DocTypeRef of the BillDetailBackupTemp
    /// DocTypeRef الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BillDetailBackupTemp
    /// DocNoRef الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BillDetailBackupTemp
    /// DocSerRef الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSeqTmp of the BillDetailBackupTemp
    /// DocSeqTmp الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// DocMSq of the BillDetailBackupTemp
    /// DocMSq الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// DocType of the BillDetailBackupTemp
    /// DocType الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// ReservedFlag of the BillDetailBackupTemp
    /// ReservedFlag الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ReservedFlag { get; private set; }

    /// <summary>
    /// ReservationDate of the BillDetailBackupTemp
    /// ReservationDate الخاص بـ BillDetailBackupTemp
    /// </summary>
    public DateTime? ReservationDate { get; private set; }

    /// <summary>
    /// ReservationQuantity of the BillDetailBackupTemp
    /// ReservationQuantity الخاص بـ BillDetailBackupTemp
    /// </summary>
    public decimal? ReservationQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
