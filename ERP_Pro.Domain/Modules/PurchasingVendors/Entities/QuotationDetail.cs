using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationDetail Entity
/// </summary>
public class QuotationDetail : Entity<QuotationDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Quotation> _quotation = new List<Quotation>();

    private QuotationDetail() { }

    public QuotationDetail(QuotationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the QuotationDetail
    /// المعرف الفريد لـ QuotationDetail
    /// </summary>
    public QuotationDetailId Id { get; private set; }

    /// <summary>
    /// QuotationType of the QuotationDetail
    /// QuotationType الخاص بـ QuotationDetail
    /// </summary>
    public decimal? QuotationType { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the QuotationDetail
    /// QuotationNumberFull الخاص بـ QuotationDetail
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// ItemQuantity of the QuotationDetail
    /// ItemQuantity الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the QuotationDetail
    /// PSize الخاص بـ QuotationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the QuotationDetail
    /// PQuantity الخاص بـ QuotationDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the QuotationDetail
    /// ItemPriceShort الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// WarehouseCode of the QuotationDetail
    /// WarehouseCode الخاص بـ QuotationDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// VatPercent of the QuotationDetail
    /// VatPercent الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the QuotationDetail
    /// VatAmount الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the QuotationDetail
    /// RecordNumber الخاص بـ QuotationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Barcode of the QuotationDetail
    /// Barcode الخاص بـ QuotationDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseAttachment of the QuotationDetail
    /// UseAttachment الخاص بـ QuotationDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// FreeQuantity of the QuotationDetail
    /// FreeQuantity الخاص بـ QuotationDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the QuotationDetail
    /// ReceiveAttachment الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// ItemLength of the QuotationDetail
    /// ItemLength الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the QuotationDetail
    /// ItemWidth الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the QuotationDetail
    /// ItemHeightShort الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the QuotationDetail
    /// ItemNumberShort الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the QuotationDetail
    /// WeightedUnit الخاص بـ QuotationDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the QuotationDetail
    /// WeightedQuantity الخاص بـ QuotationDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// ItemDescription of the QuotationDetail
    /// ItemDescription الخاص بـ QuotationDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// DisPer of the QuotationDetail
    /// DisPer الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the QuotationDetail
    /// DisAmtDtl الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the QuotationDetail
    /// DisPer2 الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the QuotationDetail
    /// DisAmtDtl2 الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the QuotationDetail
    /// DisPer3 الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the QuotationDetail
    /// DisAmtDtl3 الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtMst of the QuotationDetail
    /// DisAmtMst الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmt of the QuotationDetail
    /// DisAmt الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the QuotationDetail
    /// DisAmtDtlVat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the QuotationDetail
    /// DisAmtMstVat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the QuotationDetail
    /// VatAmountDiscountDetailVat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the QuotationDetail
    /// VatAmountAfterDiscount الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the QuotationDetail
    /// VatAmountBeforeDiscount الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the QuotationDetail
    /// VatAmountDiscountMasterVat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// OtherAmount of the QuotationDetail
    /// OtherAmount الخاص بـ QuotationDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// ItemPriceVat of the QuotationDetail
    /// ItemPriceVat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the QuotationDetail
    /// SalesInvoiceType الخاص بـ QuotationDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// FieldDetail1 of the QuotationDetail
    /// FieldDetail1 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the QuotationDetail
    /// FieldDetail2 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the QuotationDetail
    /// FieldDetail3 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the QuotationDetail
    /// ExternalPostFlag الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ExpireDate of the QuotationDetail
    /// ExpireDate الخاص بـ QuotationDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the QuotationDetail
    /// BatchNumber الخاص بـ QuotationDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ArgumentNumber of the QuotationDetail
    /// ArgumentNumber الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// StockCost of the QuotationDetail
    /// StockCost الخاص بـ QuotationDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// UsedItem of the QuotationDetail
    /// UsedItem الخاص بـ QuotationDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// DocSequence of the QuotationDetail
    /// DocSequence الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuotationDetail
    /// CompanyNumberShort الخاص بـ QuotationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the QuotationDetail
    /// BranchNumber الخاص بـ QuotationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the QuotationDetail
    /// BranchYear الخاص بـ QuotationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuotationDetail
    /// BranchUser الخاص بـ QuotationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the QuotationDetail
    /// OtherAmountDiscount الخاص بـ QuotationDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the QuotationDetail
    /// VatAmountOther الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CostCenterCode of the QuotationDetail
    /// CostCenterCode الخاص بـ QuotationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the QuotationDetail
    /// ProjectNumber الخاص بـ QuotationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the QuotationDetail
    /// ActivityNumber الخاص بـ QuotationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the QuotationDetail
    /// DisAmtDtl2Vat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the QuotationDetail
    /// DisAmtDtl3Vat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the QuotationDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the QuotationDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ QuotationDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// FieldDetail4 of the QuotationDetail
    /// FieldDetail4 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the QuotationDetail
    /// FieldDetail5 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the QuotationDetail
    /// FieldDetail6 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the QuotationDetail
    /// FieldDetail7 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the QuotationDetail
    /// FieldDetail8 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the QuotationDetail
    /// FieldDetail9 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the QuotationDetail
    /// FieldDetail10 الخاص بـ QuotationDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// LevelNumber of the QuotationDetail
    /// LevelNumber الخاص بـ QuotationDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceLevelNumber of the QuotationDetail
    /// ItemPriceLevelNumber الخاص بـ QuotationDetail
    /// </summary>
    public decimal? ItemPriceLevelNumber { get; private set; }

    /// <summary>
    /// OtherAmountItem of the QuotationDetail
    /// OtherAmountItem الخاص بـ QuotationDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// DocNoRef of the QuotationDetail
    /// DocNoRef الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the QuotationDetail
    /// DocSerRef الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypeRef of the QuotationDetail
    /// DocTypeRef الخاص بـ QuotationDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// FreeType of the QuotationDetail
    /// FreeType الخاص بـ QuotationDetail
    /// </summary>
    public decimal? FreeType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Quotation> Quotation => _quotation;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
