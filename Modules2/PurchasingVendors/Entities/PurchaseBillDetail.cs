using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseBillDetail Entity
/// </summary>
public class PurchaseBillDetail : Entity<PurchaseBillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<PurchaseBillMaster> _purchaseBillMaster = new List<PurchaseBillMaster>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private PurchaseBillDetail() { }

    public PurchaseBillDetail(PurchaseBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseBillDetail
    /// المعرف الفريد لـ PurchaseBillDetail
    /// </summary>
    public PurchaseBillDetailId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the PurchaseBillDetail
    /// ReturnBillDocumentType الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the PurchaseBillDetail
    /// ReturnBillNumberAlt الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// BillNumber of the PurchaseBillDetail
    /// BillNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the PurchaseBillDetail
    /// BillDocumentTypeFull الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the PurchaseBillDetail
    /// BillSerial الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseBillDetail
    /// ItemQuantity الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the PurchaseBillDetail
    /// PSize الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseBillDetail
    /// PQuantity الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PurchaseBillDetail
    /// ItemPriceShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the PurchaseBillDetail
    /// StockCost الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// ExpireDate of the PurchaseBillDetail
    /// ExpireDate الخاص بـ PurchaseBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PurchaseBillDetail
    /// BatchNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the PurchaseBillDetail
    /// FreeQuantity الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// DisPer of the PurchaseBillDetail
    /// DisPer الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PurchaseBillDetail
    /// DisAmtDtl الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisPer2 of the PurchaseBillDetail
    /// DisPer2 الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the PurchaseBillDetail
    /// DisAmtDtl2 الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the PurchaseBillDetail
    /// DisPer3 الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the PurchaseBillDetail
    /// DisAmtDtl3 الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtMst of the PurchaseBillDetail
    /// DisAmtMst الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmt of the PurchaseBillDetail
    /// DisAmt الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// VatPercent of the PurchaseBillDetail
    /// VatPercent الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseBillDetail
    /// VatAmount الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the PurchaseBillDetail
    /// OtherAmount الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the PurchaseBillDetail
    /// UseSerialNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the PurchaseBillDetail
    /// SalesInvoiceRecordNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseBillDetail
    /// RecordNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseBillDetail
    /// DocSequence الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequencePi of the PurchaseBillDetail
    /// DocSequencePi الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocSequencePi { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseBillDetail
    /// ItemDescription الخاص بـ PurchaseBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// UseAttachment of the PurchaseBillDetail
    /// UseAttachment الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PurchaseBillDetail
    /// ReceiveAttachment الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisAmtNotEffect of the PurchaseBillDetail
    /// DisAmtNotEffect الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DisAmtNotEffect { get; private set; }

    /// <summary>
    /// Barcode of the PurchaseBillDetail
    /// Barcode الخاص بـ PurchaseBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseBillDetail
    /// ItemLength الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseBillDetail
    /// ItemWidth الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseBillDetail
    /// ItemHeightShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseBillDetail
    /// ItemNumberShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the PurchaseBillDetail
    /// PostCode الخاص بـ PurchaseBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseBillDetail
    /// WeightedQuantity الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseBillDetail
    /// WeightedUnit الخاص بـ PurchaseBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// DocTypeRef of the PurchaseBillDetail
    /// DocTypeRef الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the PurchaseBillDetail
    /// DocNoRef الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PurchaseBillDetail
    /// DocSerRef الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PurchaseBillDetail
    /// DocSequenceRef الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// ServiceItemShort of the PurchaseBillDetail
    /// ServiceItemShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ServiceItemShort { get; private set; }

    /// <summary>
    /// ItemPriceVat of the PurchaseBillDetail
    /// ItemPriceVat الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseBillDetail
    /// ArgumentNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the PurchaseBillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the PurchaseBillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the PurchaseBillDetail
    /// OtherAmountDiscount الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the PurchaseBillDetail
    /// VatAmountOther الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseBillDetail
    /// CompanyNumberShort الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseBillDetail
    /// BranchNumber الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseBillDetail
    /// BranchYear الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseBillDetail
    /// BranchUser الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// OtherAmountItem of the PurchaseBillDetail
    /// OtherAmountItem الخاص بـ PurchaseBillDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// FieldDetail1 of the PurchaseBillDetail
    /// FieldDetail1 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the PurchaseBillDetail
    /// FieldDetail2 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the PurchaseBillDetail
    /// FieldDetail3 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the PurchaseBillDetail
    /// FieldDetail4 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the PurchaseBillDetail
    /// FieldDetail5 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the PurchaseBillDetail
    /// FieldDetail6 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the PurchaseBillDetail
    /// FieldDetail7 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the PurchaseBillDetail
    /// FieldDetail8 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the PurchaseBillDetail
    /// FieldDetail9 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the PurchaseBillDetail
    /// FieldDetail10 الخاص بـ PurchaseBillDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

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
    public ICollection<PurchaseBillMaster> PurchaseBillMaster => _purchaseBillMaster;
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

