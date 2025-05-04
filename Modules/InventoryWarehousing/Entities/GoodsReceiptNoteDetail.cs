using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNoteDetail Entity
/// </summary>
public class GoodsReceiptNoteDetail : Entity<GoodsReceiptNoteDetailId>
{
    private GoodsReceiptNoteDetail() { }

    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteDetail
    /// المعرف الفريد لـ GoodsReceiptNoteDetail
    /// </summary>
    public GoodsReceiptNoteDetailId Id { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GoodsReceiptNoteDetail
    /// GroupNumberFull الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the GoodsReceiptNoteDetail
    /// GuarantorSerial الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// GoodsReceiptType of the GoodsReceiptNoteDetail
    /// GoodsReceiptType الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? GoodsReceiptType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the GoodsReceiptNoteDetail
    /// PurchaseOrderNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the GoodsReceiptNoteDetail
    /// PurchaseOrderSerial الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// ItemCode of the GoodsReceiptNoteDetail
    /// ItemCode الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the GoodsReceiptNoteDetail
    /// ItemQuantity الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the GoodsReceiptNoteDetail
    /// FreeQuantity الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the GoodsReceiptNoteDetail
    /// ItemUnit الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the GoodsReceiptNoteDetail
    /// PSize الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the GoodsReceiptNoteDetail
    /// PQuantity الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the GoodsReceiptNoteDetail
    /// ItemPriceShort الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the GoodsReceiptNoteDetail
    /// CostCenterCode الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the GoodsReceiptNoteDetail
    /// WarehouseCode الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the GoodsReceiptNoteDetail
    /// ExpireDate الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the GoodsReceiptNoteDetail
    /// BatchNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the GoodsReceiptNoteDetail
    /// ItemDescription الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the GoodsReceiptNoteDetail
    /// Barcode الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseSerialNumber of the GoodsReceiptNoteDetail
    /// UseSerialNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GoodsReceiptNoteDetail
    /// RecordNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the GoodsReceiptNoteDetail
    /// UseAttachment الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the GoodsReceiptNoteDetail
    /// ReceiveAttachment الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DocSequence of the GoodsReceiptNoteDetail
    /// DocSequence الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequencePo of the GoodsReceiptNoteDetail
    /// DocSequencePo الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? DocSequencePo { get; private set; }

    /// <summary>
    /// ItemLength of the GoodsReceiptNoteDetail
    /// ItemLength الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the GoodsReceiptNoteDetail
    /// ItemWidth الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the GoodsReceiptNoteDetail
    /// ItemHeightShort الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the GoodsReceiptNoteDetail
    /// ItemNumberShort الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the GoodsReceiptNoteDetail
    /// WeightedQuantity الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the GoodsReceiptNoteDetail
    /// WeightedUnit الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ProjectNumber of the GoodsReceiptNoteDetail
    /// ProjectNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GoodsReceiptNoteDetail
    /// ActivityNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ItemPriceVat of the GoodsReceiptNoteDetail
    /// ItemPriceVat الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ArgumentNumber of the GoodsReceiptNoteDetail
    /// ArgumentNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptNoteDetail
    /// CompanyNumberShort الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptNoteDetail
    /// BranchNumber الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptNoteDetail
    /// BranchYear الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptNoteDetail
    /// BranchUser الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// FieldDetail1 of the GoodsReceiptNoteDetail
    /// FieldDetail1 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the GoodsReceiptNoteDetail
    /// FieldDetail2 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the GoodsReceiptNoteDetail
    /// FieldDetail3 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the GoodsReceiptNoteDetail
    /// FieldDetail4 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the GoodsReceiptNoteDetail
    /// FieldDetail5 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the GoodsReceiptNoteDetail
    /// FieldDetail6 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the GoodsReceiptNoteDetail
    /// FieldDetail7 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the GoodsReceiptNoteDetail
    /// FieldDetail8 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the GoodsReceiptNoteDetail
    /// FieldDetail9 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the GoodsReceiptNoteDetail
    /// FieldDetail10 الخاص بـ GoodsReceiptNoteDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GoodsReceiptNoteMaster
    /// </summary>
    public GoodsReceiptNoteMaster GoodsReceiptNoteMaster { get; private set; }
    #endregion
}
}
