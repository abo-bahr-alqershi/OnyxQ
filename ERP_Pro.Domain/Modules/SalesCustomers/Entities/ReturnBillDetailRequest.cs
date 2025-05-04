using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// ReturnBillDetailRequest Entity
/// </summary>
public class ReturnBillDetailRequest : Entity<ReturnBillDetailRequestId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Employee> _employee = new List<Employee>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<ReturnBillMasterRequest> _returnBillMasterRequest = new List<ReturnBillMasterRequest>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private ReturnBillDetailRequest() { }

    public ReturnBillDetailRequest(ReturnBillDetailRequestId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReturnBillDetailRequest
    /// المعرف الفريد لـ ReturnBillDetailRequest
    /// </summary>
    public ReturnBillDetailRequestId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the ReturnBillDetailRequest
    /// ReturnBillDocumentType الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the ReturnBillDetailRequest
    /// ReturnBillNumberAlt الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// BillNumber of the ReturnBillDetailRequest
    /// BillNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ReturnBillDetailRequest
    /// BillDocumentTypeFull الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the ReturnBillDetailRequest
    /// BillSerial الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemQuantity of the ReturnBillDetailRequest
    /// ItemQuantity الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the ReturnBillDetailRequest
    /// PSize الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the ReturnBillDetailRequest
    /// PQuantity الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ReturnBillDetailRequest
    /// ItemPriceShort الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the ReturnBillDetailRequest
    /// StockCost الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// VendorCode of the ReturnBillDetailRequest
    /// VendorCode الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// SalesReturnType of the ReturnBillDetailRequest
    /// SalesReturnType الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// ExpireDate of the ReturnBillDetailRequest
    /// ExpireDate الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ReturnBillDetailRequest
    /// BatchNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the ReturnBillDetailRequest
    /// FreeQuantity الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ServiceItem of the ReturnBillDetailRequest
    /// ServiceItem الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// DisPer of the ReturnBillDetailRequest
    /// DisPer الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the ReturnBillDetailRequest
    /// DisAmt الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the ReturnBillDetailRequest
    /// DisAmtMst الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the ReturnBillDetailRequest
    /// DisAmtDtl الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// VatPercent of the ReturnBillDetailRequest
    /// VatPercent الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the ReturnBillDetailRequest
    /// VatAmount الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the ReturnBillDetailRequest
    /// OtherAmount الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the ReturnBillDetailRequest
    /// UseSerialNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the ReturnBillDetailRequest
    /// SalesInvoiceRecordNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ReturnBillDetailRequest
    /// RecordNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequenceSi of the ReturnBillDetailRequest
    /// DocSequenceSi الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DocSequenceSi { get; private set; }

    /// <summary>
    /// ItemDescription of the ReturnBillDetailRequest
    /// ItemDescription الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the ReturnBillDetailRequest
    /// Barcode الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReturnBillDetailRequest
    /// ExternalPostFlag الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the ReturnBillDetailRequest
    /// ReturnBillPaymentYear الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the ReturnBillDetailRequest
    /// UseAttachment الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the ReturnBillDetailRequest
    /// ReceiveAttachment الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisPer2 of the ReturnBillDetailRequest
    /// DisPer2 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the ReturnBillDetailRequest
    /// DisAmtDtl2 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the ReturnBillDetailRequest
    /// DisPer3 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the ReturnBillDetailRequest
    /// DisAmtDtl3 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// ItemLength of the ReturnBillDetailRequest
    /// ItemLength الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the ReturnBillDetailRequest
    /// ItemWidth الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the ReturnBillDetailRequest
    /// ItemHeightShort الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the ReturnBillDetailRequest
    /// ItemNumberShort الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the ReturnBillDetailRequest
    /// PostCode الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// FieldDetail1 of the ReturnBillDetailRequest
    /// FieldDetail1 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the ReturnBillDetailRequest
    /// FieldDetail2 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the ReturnBillDetailRequest
    /// FieldDetail3 الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// SubCustomerCode of the ReturnBillDetailRequest
    /// SubCustomerCode الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReturnBillDetailRequest
    /// CompanyNumberShort الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReturnBillDetailRequest
    /// BranchNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReturnBillDetailRequest
    /// BranchYear الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReturnBillDetailRequest
    /// BranchUser الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the ReturnBillDetailRequest
    /// ItemUnit الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the ReturnBillDetailRequest
    /// WeightedQuantity الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the ReturnBillDetailRequest
    /// WeightedUnit الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the ReturnBillDetailRequest
    /// InsuranceLoadPercent الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the ReturnBillDetailRequest
    /// InsuranceLoadAmount الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the ReturnBillDetailRequest
    /// InsuranceAdditionalLimit الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// DocSequence of the ReturnBillDetailRequest
    /// DocSequence الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ArgumentNumber of the ReturnBillDetailRequest
    /// ArgumentNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// UsedItem of the ReturnBillDetailRequest
    /// UsedItem الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// ItemPriceVat of the ReturnBillDetailRequest
    /// ItemPriceVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the ReturnBillDetailRequest
    /// DisAmtDtlVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the ReturnBillDetailRequest
    /// DisAmtDtl2Vat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the ReturnBillDetailRequest
    /// DisAmtDtl3Vat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the ReturnBillDetailRequest
    /// DisAmtMstVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the ReturnBillDetailRequest
    /// VatAmountDiscountDetailVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the ReturnBillDetailRequest
    /// VatAmountDiscountDetail2Vat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the ReturnBillDetailRequest
    /// VatAmountDiscountDetail3Vat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the ReturnBillDetailRequest
    /// VatAmountAfterDiscount الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the ReturnBillDetailRequest
    /// VatAmountBeforeDiscount الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the ReturnBillDetailRequest
    /// VatAmountDiscountMasterVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the ReturnBillDetailRequest
    /// DisAmtAftrVat الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// LevelNumber of the ReturnBillDetailRequest
    /// LevelNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemPriceLevelNumber of the ReturnBillDetailRequest
    /// ItemPriceLevelNumber الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? ItemPriceLevelNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the ReturnBillDetailRequest
    /// DocTypeRef الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ReturnBillDetailRequest
    /// DocSerRef الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ReturnBillDetailRequest
    /// DocNoRef الخاص بـ ReturnBillDetailRequest
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// FreeType of the ReturnBillDetailRequest
    /// FreeType الخاص بـ ReturnBillDetailRequest
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
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Employee> Employee => _employee;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ReturnBillMasterRequest> ReturnBillMasterRequest => _returnBillMasterRequest;
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
