using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillDetail Entity
/// </summary>
public class BillDetail : Entity<BillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<BillMaster> _billMaster = new List<BillMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private BillDetail() { }

    public BillDetail(BillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BillDetail
    /// المعرف الفريد لـ BillDetail
    /// </summary>
    public BillDetailId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BillDetail
    /// BillDocumentTypeFull الخاص بـ BillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BillDetail
    /// BillNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the BillDetail
    /// ItemQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the BillDetail
    /// PSize الخاص بـ BillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BillDetail
    /// PQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BillDetail
    /// ItemPriceShort الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BillDetail
    /// StockCost الخاص بـ BillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// OutgoingQuantity of the BillDetail
    /// OutgoingQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? OutgoingQuantity { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantity of the BillDetail
    /// OutgoingFreeQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? OutgoingFreeQuantity { get; private set; }

    /// <summary>
    /// ExpireDate of the BillDetail
    /// ExpireDate الخاص بـ BillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BillDetail
    /// BatchNumber الخاص بـ BillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the BillDetail
    /// FreeQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// DisPer of the BillDetail
    /// DisPer الخاص بـ BillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the BillDetail
    /// DisAmt الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the BillDetail
    /// DisAmtMst الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the BillDetail
    /// DisAmtDtl الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAftrVatMst of the BillDetail
    /// DisAftrVatMst الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAftrVatMst { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the BillDetail
    /// DisAmtDtlVat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the BillDetail
    /// DisAmtMstVat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the BillDetail
    /// VatAmountDiscountDetailVat الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the BillDetail
    /// VatAmountAfterDiscount الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the BillDetail
    /// VatAmountBeforeDiscount الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the BillDetail
    /// VatAmountDiscountMasterVat الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the BillDetail
    /// DisAmtAftrVat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BillDetail
    /// OtherAmountDiscount الخاص بـ BillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatPercent of the BillDetail
    /// VatPercent الخاص بـ BillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BillDetail
    /// VatAmount الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BillDetail
    /// OtherAmount الخاص بـ BillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BillDetail
    /// UseSerialNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ServiceItem of the BillDetail
    /// ServiceItem الخاص بـ BillDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the BillDetail
    /// RecordNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BillDetail
    /// DocSequence الخاص بـ BillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the BillDetail
    /// ItemDescription الخاص بـ BillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BillDetail
    /// SalesInvoiceType الخاص بـ BillDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// Barcode of the BillDetail
    /// Barcode الخاص بـ BillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// SalesOrderNumber of the BillDetail
    /// SalesOrderNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? SalesOrderNumber { get; private set; }

    /// <summary>
    /// SalesOrderSerial of the BillDetail
    /// SalesOrderSerial الخاص بـ BillDetail
    /// </summary>
    public decimal? SalesOrderSerial { get; private set; }

    /// <summary>
    /// DocTypeRef of the BillDetail
    /// DocTypeRef الخاص بـ BillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BillDetail
    /// DocNoRef الخاص بـ BillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BillDetail
    /// DocSerRef الخاص بـ BillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillDetail
    /// ExternalPostFlag الخاص بـ BillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BillDetail
    /// BillPaymentYear الخاص بـ BillDetail
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the BillDetail
    /// UseAttachment الخاص بـ BillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BillDetail
    /// ReceiveAttachment الخاص بـ BillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the BillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ BillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the BillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ BillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// DisPer2 of the BillDetail
    /// DisPer2 الخاص بـ BillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the BillDetail
    /// DisAmtDtl2 الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the BillDetail
    /// DisPer3 الخاص بـ BillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the BillDetail
    /// DisAmtDtl3 الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// RecordNumberReference of the BillDetail
    /// RecordNumberReference الخاص بـ BillDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// EmpNo of the BillDetail
    /// EmpNo الخاص بـ BillDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ItemLength of the BillDetail
    /// ItemLength الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemPriceVat of the BillDetail
    /// ItemPriceVat الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ItemWidth of the BillDetail
    /// ItemWidth الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BillDetail
    /// ItemHeightShort الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BillDetail
    /// ItemNumberShort الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the BillDetail
    /// WeightedUnit الخاص بـ BillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BillDetail
    /// WeightedQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// PostCode of the BillDetail
    /// PostCode الخاص بـ BillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the BillDetail
    /// QuotationPremiumNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the BillDetail
    /// QuotationPremiumSerial الخاص بـ BillDetail
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the BillDetail
    /// QuotationPremiumRecordNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BillDetail
    /// InsuranceLoadPercent الخاص بـ BillDetail
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the BillDetail
    /// InsuranceLoadAmount الخاص بـ BillDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the BillDetail
    /// InsuranceAdditionalLimit الخاص بـ BillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the BillDetail
    /// InsuranceApprovedCode الخاص بـ BillDetail
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BillDetail
    /// SubCustomerCode الخاص بـ BillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// ItemPriceOutgoing of the BillDetail
    /// ItemPriceOutgoing الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemPriceOutgoing { get; private set; }

    /// <summary>
    /// PackageUnit of the BillDetail
    /// PackageUnit الخاص بـ BillDetail
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the BillDetail
    /// PackageUnitSize الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the BillDetail
    /// PackageQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the BillDetail
    /// PackageLength الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the BillDetail
    /// PackageWidth الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the BillDetail
    /// PackageHeight الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the BillDetail
    /// PackageSize الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the BillDetail
    /// PackageWeight الخاص بـ BillDetail
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// FieldDetail1 of the BillDetail
    /// FieldDetail1 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the BillDetail
    /// FieldDetail2 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the BillDetail
    /// FieldDetail3 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// MeasurePrice of the BillDetail
    /// MeasurePrice الخاص بـ BillDetail
    /// </summary>
    public decimal? MeasurePrice { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BillDetail
    /// ArgumentNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CouponQuantity of the BillDetail
    /// CouponQuantity الخاص بـ BillDetail
    /// </summary>
    public decimal? CouponQuantity { get; private set; }

    /// <summary>
    /// DocSeqTmp of the BillDetail
    /// DocSeqTmp الخاص بـ BillDetail
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// UsedItem of the BillDetail
    /// UsedItem الخاص بـ BillDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// VatAmountOther of the BillDetail
    /// VatAmountOther الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// PromoterGroupNumber of the BillDetail
    /// PromoterGroupNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? PromoterGroupNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillDetail
    /// CompanyNumberShort الخاص بـ BillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillDetail
    /// BranchNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillDetail
    /// BranchYear الخاص بـ BillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillDetail
    /// BranchUser الخاص بـ BillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CommissionPercent of the BillDetail
    /// CommissionPercent الخاص بـ BillDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BillDetail
    /// CommissionAmountDetail الخاص بـ BillDetail
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// DocSequenceRef of the BillDetail
    /// DocSequenceRef الخاص بـ BillDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// DisPerQtPrm of the BillDetail
    /// DisPerQtPrm الخاص بـ BillDetail
    /// </summary>
    public decimal? DisPerQtPrm { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrm of the BillDetail
    /// DisAmtDtlQtPrm الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrm { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrmVat of the BillDetail
    /// DisAmtDtlQtPrmVat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrmVat { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the BillDetail
    /// DisAmtDtl2Vat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the BillDetail
    /// DisAmtDtl3Vat الخاص بـ BillDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the BillDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the BillDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ BillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// FieldDetail4 of the BillDetail
    /// FieldDetail4 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the BillDetail
    /// FieldDetail5 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the BillDetail
    /// FieldDetail6 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the BillDetail
    /// FieldDetail7 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the BillDetail
    /// FieldDetail8 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the BillDetail
    /// FieldDetail9 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the BillDetail
    /// FieldDetail10 الخاص بـ BillDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// LevelNumber of the BillDetail
    /// LevelNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceLevelNumber of the BillDetail
    /// ItemPriceLevelNumber الخاص بـ BillDetail
    /// </summary>
    public decimal? ItemPriceLevelNumber { get; private set; }

    /// <summary>
    /// OtherAmountItem of the BillDetail
    /// OtherAmountItem الخاص بـ BillDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// OutgoingQuantityYear of the BillDetail
    /// OutgoingQuantityYear الخاص بـ BillDetail
    /// </summary>
    public decimal? OutgoingQuantityYear { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantityYear of the BillDetail
    /// OutgoingFreeQuantityYear الخاص بـ BillDetail
    /// </summary>
    public decimal? OutgoingFreeQuantityYear { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BillDetail
    /// InsuranceAdditionalLimitMaster الخاص بـ BillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// FreeType of the BillDetail
    /// FreeType الخاص بـ BillDetail
    /// </summary>
    public decimal? FreeType { get; private set; }

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
    public ICollection<BillMaster> BillMaster => _billMaster;
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
