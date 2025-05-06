using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// ReturnBillDetail Entity
/// </summary>
public class ReturnBillDetail : Entity<ReturnBillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<ReturnBillMaster> _returnBillMaster = new List<ReturnBillMaster>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private ReturnBillDetail() { }

    public ReturnBillDetail(ReturnBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReturnBillDetail
    /// المعرف الفريد لـ ReturnBillDetail
    /// </summary>
    public ReturnBillDetailId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the ReturnBillDetail
    /// ReturnBillDocumentType الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the ReturnBillDetail
    /// ReturnBillNumberAlt الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// BillNumber of the ReturnBillDetail
    /// BillNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ReturnBillDetail
    /// BillDocumentTypeFull الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the ReturnBillDetail
    /// BillSerial الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemQuantity of the ReturnBillDetail
    /// ItemQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the ReturnBillDetail
    /// PSize الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the ReturnBillDetail
    /// PQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ReturnBillDetail
    /// ItemPriceShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the ReturnBillDetail
    /// StockCost الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VendorCode of the ReturnBillDetail
    /// VendorCode الخاص بـ ReturnBillDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// SalesReturnType of the ReturnBillDetail
    /// SalesReturnType الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// ExpireDate of the ReturnBillDetail
    /// ExpireDate الخاص بـ ReturnBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ReturnBillDetail
    /// BatchNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the ReturnBillDetail
    /// FreeQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ServiceItem of the ReturnBillDetail
    /// ServiceItem الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// DisPer of the ReturnBillDetail
    /// DisPer الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the ReturnBillDetail
    /// DisAmt الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the ReturnBillDetail
    /// DisAmtMst الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the ReturnBillDetail
    /// DisAmtDtl الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the ReturnBillDetail
    /// DisAmtDtlVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the ReturnBillDetail
    /// DisAmtMstVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the ReturnBillDetail
    /// VatAmountDiscountDetailVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the ReturnBillDetail
    /// VatAmountAfterDiscount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the ReturnBillDetail
    /// VatAmountBeforeDiscount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the ReturnBillDetail
    /// VatAmountDiscountMasterVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the ReturnBillDetail
    /// DisAmtAftrVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// VatPercent of the ReturnBillDetail
    /// VatPercent الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the ReturnBillDetail
    /// VatAmount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the ReturnBillDetail
    /// OtherAmount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// ReturnQuantity of the ReturnBillDetail
    /// ReturnQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnQuantity { get; private set; }

    /// <summary>
    /// ReturnFreeQuantity of the ReturnBillDetail
    /// ReturnFreeQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnFreeQuantity { get; private set; }

    /// <summary>
    /// UseSerialNumber of the ReturnBillDetail
    /// UseSerialNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// DisAftrVatMst of the ReturnBillDetail
    /// DisAftrVatMst الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAftrVatMst { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the ReturnBillDetail
    /// SalesInvoiceRecordNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ReturnBillDetail
    /// RecordNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberReference of the ReturnBillDetail
    /// RecordNumberReference الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// DocSequence of the ReturnBillDetail
    /// DocSequence الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceSi of the ReturnBillDetail
    /// DocSequenceSi الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DocSequenceSi { get; private set; }

    /// <summary>
    /// ItemDescription of the ReturnBillDetail
    /// ItemDescription الخاص بـ ReturnBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the ReturnBillDetail
    /// Barcode الخاص بـ ReturnBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReturnBillDetail
    /// ExternalPostFlag الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the ReturnBillDetail
    /// ReturnBillPaymentYear الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the ReturnBillDetail
    /// UseAttachment الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the ReturnBillDetail
    /// ReceiveAttachment الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisPer2 of the ReturnBillDetail
    /// DisPer2 الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the ReturnBillDetail
    /// DisAmtDtl2 الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the ReturnBillDetail
    /// DisPer3 الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the ReturnBillDetail
    /// DisAmtDtl3 الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// ItemPriceVat of the ReturnBillDetail
    /// ItemPriceVat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// ItemLength of the ReturnBillDetail
    /// ItemLength الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the ReturnBillDetail
    /// ItemWidth الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the ReturnBillDetail
    /// ItemHeightShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the ReturnBillDetail
    /// ItemNumberShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the ReturnBillDetail
    /// PostCode الخاص بـ ReturnBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// WeightedUnit of the ReturnBillDetail
    /// WeightedUnit الخاص بـ ReturnBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the ReturnBillDetail
    /// WeightedQuantity الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// FieldDetail1 of the ReturnBillDetail
    /// FieldDetail1 الخاص بـ ReturnBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the ReturnBillDetail
    /// FieldDetail2 الخاص بـ ReturnBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the ReturnBillDetail
    /// FieldDetail3 الخاص بـ ReturnBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the ReturnBillDetail
    /// InsuranceLoadPercent الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the ReturnBillDetail
    /// InsuranceLoadAmount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the ReturnBillDetail
    /// InsuranceAdditionalLimit الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// EmpNo of the ReturnBillDetail
    /// EmpNo الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// DocTypeRef of the ReturnBillDetail
    /// DocTypeRef الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ReturnBillDetail
    /// DocNoRef الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ReturnBillDetail
    /// DocSerRef الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// SubCustomerCode of the ReturnBillDetail
    /// SubCustomerCode الخاص بـ ReturnBillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// CommissionPercent of the ReturnBillDetail
    /// CommissionPercent الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the ReturnBillDetail
    /// CommissionAmountDetail الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// ArgumentNumber of the ReturnBillDetail
    /// ArgumentNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// UsedItem of the ReturnBillDetail
    /// UsedItem الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// VatAmountOther of the ReturnBillDetail
    /// VatAmountOther الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the ReturnBillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the ReturnBillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the ReturnBillDetail
    /// OtherAmountDiscount الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the ReturnBillDetail
    /// QuotationPremiumNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the ReturnBillDetail
    /// QuotationPremiumSerial الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the ReturnBillDetail
    /// QuotationPremiumRecordNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReturnBillDetail
    /// CompanyNumberShort الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReturnBillDetail
    /// BranchNumber الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReturnBillDetail
    /// BranchYear الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReturnBillDetail
    /// BranchUser الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the ReturnBillDetail
    /// DisAmtDtl2Vat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the ReturnBillDetail
    /// DisAmtDtl3Vat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the ReturnBillDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the ReturnBillDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// ReturnQuantityYear of the ReturnBillDetail
    /// ReturnQuantityYear الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnQuantityYear { get; private set; }

    /// <summary>
    /// ReturnFreeQuantityYear of the ReturnBillDetail
    /// ReturnFreeQuantityYear الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? ReturnFreeQuantityYear { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the ReturnBillDetail
    /// InsuranceAdditionalLimitMaster الخاص بـ ReturnBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// FreeType of the ReturnBillDetail
    /// FreeType الخاص بـ ReturnBillDetail
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
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ReturnBillMaster> ReturnBillMaster => _returnBillMaster;
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

