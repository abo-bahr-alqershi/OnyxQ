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
/// BranchBillDetail Entity
/// </summary>
public class BranchBillDetail : Entity<BranchBillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<BranchBillMaster> _branchBillMaster = new List<BranchBillMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private BranchBillDetail() { }

    public BranchBillDetail(BranchBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchBillDetail
    /// المعرف الفريد لـ BranchBillDetail
    /// </summary>
    public BranchBillDetailId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchBillDetail
    /// BillDocumentTypeFull الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchBillDetail
    /// BillNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchBillDetail
    /// ItemQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchBillDetail
    /// ItemUnit الخاص بـ BranchBillDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchBillDetail
    /// PSize الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchBillDetail
    /// PQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchBillDetail
    /// ItemPriceShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchBillDetail
    /// StockCost الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// OutgoingQuantity of the BranchBillDetail
    /// OutgoingQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OutgoingQuantity { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantity of the BranchBillDetail
    /// OutgoingFreeQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OutgoingFreeQuantity { get; private set; }

    /// <summary>
    /// OutgoingQuantityYear of the BranchBillDetail
    /// OutgoingQuantityYear الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OutgoingQuantityYear { get; private set; }

    /// <summary>
    /// OutgoingFreeQuantityYear of the BranchBillDetail
    /// OutgoingFreeQuantityYear الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OutgoingFreeQuantityYear { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchBillDetail
    /// ExpireDate الخاص بـ BranchBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchBillDetail
    /// BatchNumber الخاص بـ BranchBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchBillDetail
    /// FreeQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// FreeType of the BranchBillDetail
    /// FreeType الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? FreeType { get; private set; }

    /// <summary>
    /// DisPer of the BranchBillDetail
    /// DisPer الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the BranchBillDetail
    /// DisAmt الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the BranchBillDetail
    /// DisAmtMst الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the BranchBillDetail
    /// DisAmtDtl الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAftrVatMst of the BranchBillDetail
    /// DisAftrVatMst الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAftrVatMst { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the BranchBillDetail
    /// DisAmtDtlVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the BranchBillDetail
    /// DisAmtMstVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the BranchBillDetail
    /// VatAmountDiscountDetailVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the BranchBillDetail
    /// VatAmountAfterDiscount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the BranchBillDetail
    /// VatAmountBeforeDiscount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the BranchBillDetail
    /// VatAmountDiscountMasterVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the BranchBillDetail
    /// DisAmtAftrVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// DisPerQtPrm of the BranchBillDetail
    /// DisPerQtPrm الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisPerQtPrm { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrm of the BranchBillDetail
    /// DisAmtDtlQtPrm الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrm { get; private set; }

    /// <summary>
    /// DisAmtDtlQtPrmVat of the BranchBillDetail
    /// DisAmtDtlQtPrmVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtlQtPrmVat { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BranchBillDetail
    /// OtherAmountDiscount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatPercent of the BranchBillDetail
    /// VatPercent الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BranchBillDetail
    /// VatAmount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchBillDetail
    /// OtherAmount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// OtherAmountItem of the BranchBillDetail
    /// OtherAmountItem الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? OtherAmountItem { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchBillDetail
    /// UseSerialNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// ServiceItem of the BranchBillDetail
    /// ServiceItem الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchBillDetail
    /// RecordNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchBillDetail
    /// DocSequence الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchBillDetail
    /// ItemDescription الخاص بـ BranchBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BranchBillDetail
    /// SalesInvoiceType الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// Barcode of the BranchBillDetail
    /// Barcode الخاص بـ BranchBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// SalesOrderNumber of the BranchBillDetail
    /// SalesOrderNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? SalesOrderNumber { get; private set; }

    /// <summary>
    /// SalesOrderSerial of the BranchBillDetail
    /// SalesOrderSerial الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? SalesOrderSerial { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchBillDetail
    /// DocTypeRef الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchBillDetail
    /// DocNoRef الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchBillDetail
    /// DocSerRef الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchBillDetail
    /// ExternalPostFlag الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BranchBillDetail
    /// BillPaymentYear الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchBillDetail
    /// UseAttachment الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchBillDetail
    /// ReceiveAttachment الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the BranchBillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the BranchBillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// DisPer2 of the BranchBillDetail
    /// DisPer2 الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the BranchBillDetail
    /// DisAmtDtl2 الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the BranchBillDetail
    /// DisAmtDtl2Vat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the BranchBillDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// DisPer3 of the BranchBillDetail
    /// DisPer3 الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the BranchBillDetail
    /// DisAmtDtl3 الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the BranchBillDetail
    /// DisAmtDtl3Vat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the BranchBillDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// RecordNumberReference of the BranchBillDetail
    /// RecordNumberReference الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// EmpNo of the BranchBillDetail
    /// EmpNo الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ItemLength of the BranchBillDetail
    /// ItemLength الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemPriceVat of the BranchBillDetail
    /// ItemPriceVat الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchBillDetail
    /// ItemWidth الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchBillDetail
    /// ItemHeightShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchBillDetail
    /// ItemNumberShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchBillDetail
    /// WeightedUnit الخاص بـ BranchBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchBillDetail
    /// WeightedQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// PostCode of the BranchBillDetail
    /// PostCode الخاص بـ BranchBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the BranchBillDetail
    /// QuotationPremiumNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the BranchBillDetail
    /// QuotationPremiumSerial الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the BranchBillDetail
    /// QuotationPremiumRecordNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchBillDetail
    /// InsuranceLoadPercent الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the BranchBillDetail
    /// InsuranceLoadAmount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the BranchBillDetail
    /// InsuranceAdditionalLimit الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BranchBillDetail
    /// InsuranceAdditionalLimitMaster الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the BranchBillDetail
    /// InsuranceApprovedCode الخاص بـ BranchBillDetail
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BranchBillDetail
    /// SubCustomerCode الخاص بـ BranchBillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// ItemPriceOutgoing of the BranchBillDetail
    /// ItemPriceOutgoing الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ItemPriceOutgoing { get; private set; }

    /// <summary>
    /// PackageUnit of the BranchBillDetail
    /// PackageUnit الخاص بـ BranchBillDetail
    /// </summary>
    public string PackageUnit { get; private set; }

    /// <summary>
    /// PackageUnitSize of the BranchBillDetail
    /// PackageUnitSize الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageUnitSize { get; private set; }

    /// <summary>
    /// PackageQuantity of the BranchBillDetail
    /// PackageQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageQuantity { get; private set; }

    /// <summary>
    /// PackageLength of the BranchBillDetail
    /// PackageLength الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageLength { get; private set; }

    /// <summary>
    /// PackageWidth of the BranchBillDetail
    /// PackageWidth الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageWidth { get; private set; }

    /// <summary>
    /// PackageHeight of the BranchBillDetail
    /// PackageHeight الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageHeight { get; private set; }

    /// <summary>
    /// PackageSize of the BranchBillDetail
    /// PackageSize الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageSize { get; private set; }

    /// <summary>
    /// PackageWeight of the BranchBillDetail
    /// PackageWeight الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PackageWeight { get; private set; }

    /// <summary>
    /// FieldDetail1 of the BranchBillDetail
    /// FieldDetail1 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the BranchBillDetail
    /// FieldDetail2 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the BranchBillDetail
    /// FieldDetail3 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the BranchBillDetail
    /// FieldDetail4 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the BranchBillDetail
    /// FieldDetail5 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the BranchBillDetail
    /// FieldDetail6 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the BranchBillDetail
    /// FieldDetail7 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the BranchBillDetail
    /// FieldDetail8 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the BranchBillDetail
    /// FieldDetail9 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the BranchBillDetail
    /// FieldDetail10 الخاص بـ BranchBillDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// PercentPrice of the BranchBillDetail
    /// PercentPrice الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PercentPrice { get; private set; }

    /// <summary>
    /// PercentAmount of the BranchBillDetail
    /// PercentAmount الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PercentAmount { get; private set; }

    /// <summary>
    /// ProcedureType of the BranchBillDetail
    /// ProcedureType الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ProcedureType { get; private set; }

    /// <summary>
    /// PercentFlag of the BranchBillDetail
    /// PercentFlag الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PercentFlag { get; private set; }

    /// <summary>
    /// LevelNumber of the BranchBillDetail
    /// LevelNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// MeasurePrice of the BranchBillDetail
    /// MeasurePrice الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? MeasurePrice { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchBillDetail
    /// ArgumentNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CouponQuantity of the BranchBillDetail
    /// CouponQuantity الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? CouponQuantity { get; private set; }

    /// <summary>
    /// DocSeqTmp of the BranchBillDetail
    /// DocSeqTmp الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocSeqTmp { get; private set; }

    /// <summary>
    /// UsedItem of the BranchBillDetail
    /// UsedItem الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchBillDetail
    /// VatAmountOther الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// PromoterGroupNumber of the BranchBillDetail
    /// PromoterGroupNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? PromoterGroupNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchBillDetail
    /// CompanyNumberShort الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchBillDetail
    /// BranchNumber الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchBillDetail
    /// BranchYear الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchBillDetail
    /// BranchUser الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchBillDetail
    /// CommissionPercent الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BranchBillDetail
    /// CommissionAmountDetail الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// DocSequenceRef of the BranchBillDetail
    /// DocSequenceRef الخاص بـ BranchBillDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BranchBillMaster> BranchBillMaster => _branchBillMaster;
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
