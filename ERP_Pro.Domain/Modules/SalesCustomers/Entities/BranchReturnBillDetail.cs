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
/// BranchReturnBillDetail Entity
/// </summary>
public class BranchReturnBillDetail : Entity<BranchReturnBillDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<BranchReturnBillMaster> _branchReturnBillMaster = new List<BranchReturnBillMaster>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private BranchReturnBillDetail() { }

    public BranchReturnBillDetail(BranchReturnBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchReturnBillDetail
    /// المعرف الفريد لـ BranchReturnBillDetail
    /// </summary>
    public BranchReturnBillDetailId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the BranchReturnBillDetail
    /// ReturnBillDocumentType الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the BranchReturnBillDetail
    /// ReturnBillNumberAlt الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// BillNumber of the BranchReturnBillDetail
    /// BillNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchReturnBillDetail
    /// BillDocumentTypeFull الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the BranchReturnBillDetail
    /// BillSerial الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchReturnBillDetail
    /// ItemUnit الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchReturnBillDetail
    /// ItemQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the BranchReturnBillDetail
    /// PSize الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchReturnBillDetail
    /// PQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchReturnBillDetail
    /// ItemPriceShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchReturnBillDetail
    /// StockCost الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VendorCode of the BranchReturnBillDetail
    /// VendorCode الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// SalesReturnType of the BranchReturnBillDetail
    /// SalesReturnType الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchReturnBillDetail
    /// ExpireDate الخاص بـ BranchReturnBillDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchReturnBillDetail
    /// BatchNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchReturnBillDetail
    /// FreeQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// FreeType of the BranchReturnBillDetail
    /// FreeType الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? FreeType { get; private set; }

    /// <summary>
    /// ServiceItem of the BranchReturnBillDetail
    /// ServiceItem الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// DisPer of the BranchReturnBillDetail
    /// DisPer الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the BranchReturnBillDetail
    /// DisAmt الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the BranchReturnBillDetail
    /// DisAmtMst الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the BranchReturnBillDetail
    /// DisAmtDtl الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the BranchReturnBillDetail
    /// DisAmtDtlVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the BranchReturnBillDetail
    /// DisAmtMstVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the BranchReturnBillDetail
    /// VatAmountDiscountDetailVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the BranchReturnBillDetail
    /// VatAmountAfterDiscount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the BranchReturnBillDetail
    /// VatAmountBeforeDiscount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the BranchReturnBillDetail
    /// VatAmountDiscountMasterVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the BranchReturnBillDetail
    /// DisAmtAftrVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// PercentPrice of the BranchReturnBillDetail
    /// PercentPrice الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? PercentPrice { get; private set; }

    /// <summary>
    /// PercentAmount of the BranchReturnBillDetail
    /// PercentAmount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? PercentAmount { get; private set; }

    /// <summary>
    /// ProcedureType of the BranchReturnBillDetail
    /// ProcedureType الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ProcedureType { get; private set; }

    /// <summary>
    /// PercentFlag of the BranchReturnBillDetail
    /// PercentFlag الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? PercentFlag { get; private set; }

    /// <summary>
    /// DisAftrVatMst of the BranchReturnBillDetail
    /// DisAftrVatMst الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAftrVatMst { get; private set; }

    /// <summary>
    /// VatPercent of the BranchReturnBillDetail
    /// VatPercent الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BranchReturnBillDetail
    /// VatAmount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchReturnBillDetail
    /// OtherAmount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// ReturnQuantity of the BranchReturnBillDetail
    /// ReturnQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnQuantity { get; private set; }

    /// <summary>
    /// ReturnFreeQuantity of the BranchReturnBillDetail
    /// ReturnFreeQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnFreeQuantity { get; private set; }

    /// <summary>
    /// ReturnQuantityYear of the BranchReturnBillDetail
    /// ReturnQuantityYear الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnQuantityYear { get; private set; }

    /// <summary>
    /// ReturnFreeQuantityYear of the BranchReturnBillDetail
    /// ReturnFreeQuantityYear الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnFreeQuantityYear { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchReturnBillDetail
    /// UseSerialNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the BranchReturnBillDetail
    /// SalesInvoiceRecordNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchReturnBillDetail
    /// RecordNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchReturnBillDetail
    /// DocSequence الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocSequenceSi of the BranchReturnBillDetail
    /// DocSequenceSi الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DocSequenceSi { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchReturnBillDetail
    /// ItemDescription الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BranchReturnBillDetail
    /// Barcode الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// EmpNo of the BranchReturnBillDetail
    /// EmpNo الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchReturnBillDetail
    /// ExternalPostFlag الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the BranchReturnBillDetail
    /// ReturnBillPaymentYear الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchReturnBillDetail
    /// UseAttachment الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchReturnBillDetail
    /// ReceiveAttachment الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisPer2 of the BranchReturnBillDetail
    /// DisPer2 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the BranchReturnBillDetail
    /// DisAmtDtl2 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the BranchReturnBillDetail
    /// DisPer3 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the BranchReturnBillDetail
    /// DisAmtDtl3 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// ItemLength of the BranchReturnBillDetail
    /// ItemLength الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchReturnBillDetail
    /// ItemWidth الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchReturnBillDetail
    /// ItemHeightShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchReturnBillDetail
    /// ItemNumberShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchReturnBillDetail
    /// WeightedQuantity الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchReturnBillDetail
    /// WeightedUnit الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// PostCode of the BranchReturnBillDetail
    /// PostCode الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// LevelNumber of the BranchReturnBillDetail
    /// LevelNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchReturnBillDetail
    /// InsuranceLoadPercent الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the BranchReturnBillDetail
    /// InsuranceLoadAmount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the BranchReturnBillDetail
    /// InsuranceAdditionalLimit الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BranchReturnBillDetail
    /// InsuranceAdditionalLimitMaster الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchReturnBillDetail
    /// DocTypeRef الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchReturnBillDetail
    /// DocNoRef الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchReturnBillDetail
    /// DocSerRef الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchReturnBillDetail
    /// CommissionPercent الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BranchReturnBillDetail
    /// CommissionAmountDetail الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BranchReturnBillDetail
    /// SubCustomerCode الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// FieldDetail1 of the BranchReturnBillDetail
    /// FieldDetail1 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the BranchReturnBillDetail
    /// FieldDetail2 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the BranchReturnBillDetail
    /// FieldDetail3 الخاص بـ BranchReturnBillDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// ItemPriceVat of the BranchReturnBillDetail
    /// ItemPriceVat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// RecordNumberReference of the BranchReturnBillDetail
    /// RecordNumberReference الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// UsedItem of the BranchReturnBillDetail
    /// UsedItem الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchReturnBillDetail
    /// VatAmountOther الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMasterShort of the BranchReturnBillDetail
    /// AdditionalDiscountAmountMasterShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountMasterShort { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetailShort of the BranchReturnBillDetail
    /// AdditionalDiscountAmountDetailShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? AdditionalDiscountAmountDetailShort { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BranchReturnBillDetail
    /// OtherAmountDiscount الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the BranchReturnBillDetail
    /// QuotationPremiumNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the BranchReturnBillDetail
    /// QuotationPremiumSerial الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the BranchReturnBillDetail
    /// QuotationPremiumRecordNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchReturnBillDetail
    /// CompanyNumberShort الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchReturnBillDetail
    /// BranchNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchReturnBillDetail
    /// BranchYear الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchReturnBillDetail
    /// BranchUser الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchReturnBillDetail
    /// ArgumentNumber الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the BranchReturnBillDetail
    /// DisAmtDtl2Vat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the BranchReturnBillDetail
    /// VatAmountDiscountDetail2Vat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the BranchReturnBillDetail
    /// DisAmtDtl3Vat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the BranchReturnBillDetail
    /// VatAmountDiscountDetail3Vat الخاص بـ BranchReturnBillDetail
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

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
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BranchReturnBillMaster> BranchReturnBillMaster => _branchReturnBillMaster;
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
