using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchReturnBillDetailRequest Entity
/// </summary>
public class BranchReturnBillDetailRequest : Entity<BranchReturnBillDetailRequestId>
{

    private BranchReturnBillDetailRequest() { }

    public BranchReturnBillDetailRequest(BranchReturnBillDetailRequestId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchReturnBillDetailRequest
    /// المعرف الفريد لـ BranchReturnBillDetailRequest
    /// </summary>
    public BranchReturnBillDetailRequestId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the BranchReturnBillDetailRequest
    /// ReturnBillDocumentType الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the BranchReturnBillDetailRequest
    /// ReturnBillNumberAlt الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// BillNumber of the BranchReturnBillDetailRequest
    /// BillNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchReturnBillDetailRequest
    /// BillDocumentTypeFull الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillSerial of the BranchReturnBillDetailRequest
    /// BillSerial الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemCode of the BranchReturnBillDetailRequest
    /// ItemCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchReturnBillDetailRequest
    /// ItemQuantity الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the BranchReturnBillDetailRequest
    /// PSize الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the BranchReturnBillDetailRequest
    /// PQuantity الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchReturnBillDetailRequest
    /// ItemPriceShort الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the BranchReturnBillDetailRequest
    /// StockCost الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchReturnBillDetailRequest
    /// WarehouseCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchReturnBillDetailRequest
    /// CostCenterCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchReturnBillDetailRequest
    /// ProjectNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchReturnBillDetailRequest
    /// ActivityNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// VendorCode of the BranchReturnBillDetailRequest
    /// VendorCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// SalesReturnType of the BranchReturnBillDetailRequest
    /// SalesReturnType الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchReturnBillDetailRequest
    /// ExpireDate الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the BranchReturnBillDetailRequest
    /// BatchNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchReturnBillDetailRequest
    /// FreeQuantity الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// FreeType of the BranchReturnBillDetailRequest
    /// FreeType الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? FreeType { get; private set; }

    /// <summary>
    /// ServiceItem of the BranchReturnBillDetailRequest
    /// ServiceItem الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ServiceItem { get; private set; }

    /// <summary>
    /// DisPer of the BranchReturnBillDetailRequest
    /// DisPer الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the BranchReturnBillDetailRequest
    /// DisAmt الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DisAmtMst of the BranchReturnBillDetailRequest
    /// DisAmtMst الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtMst { get; private set; }

    /// <summary>
    /// DisAmtDtl of the BranchReturnBillDetailRequest
    /// DisAmtDtl الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    /// <summary>
    /// VatPercent of the BranchReturnBillDetailRequest
    /// VatPercent الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the BranchReturnBillDetailRequest
    /// VatAmount الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchReturnBillDetailRequest
    /// OtherAmount الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// UseSerialNumber of the BranchReturnBillDetailRequest
    /// UseSerialNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceRecordNumber of the BranchReturnBillDetailRequest
    /// SalesInvoiceRecordNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? SalesInvoiceRecordNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchReturnBillDetailRequest
    /// RecordNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequenceSi of the BranchReturnBillDetailRequest
    /// DocSequenceSi الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DocSequenceSi { get; private set; }

    /// <summary>
    /// ItemDescription of the BranchReturnBillDetailRequest
    /// ItemDescription الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the BranchReturnBillDetailRequest
    /// Barcode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchReturnBillDetailRequest
    /// ExternalPostFlag الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the BranchReturnBillDetailRequest
    /// ReturnBillPaymentYear الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// UseAttachment of the BranchReturnBillDetailRequest
    /// UseAttachment الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the BranchReturnBillDetailRequest
    /// ReceiveAttachment الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// DisPer2 of the BranchReturnBillDetailRequest
    /// DisPer2 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer2 { get; private set; }

    /// <summary>
    /// DisAmtDtl2 of the BranchReturnBillDetailRequest
    /// DisAmtDtl2 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl2 { get; private set; }

    /// <summary>
    /// DisPer3 of the BranchReturnBillDetailRequest
    /// DisPer3 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisPer3 { get; private set; }

    /// <summary>
    /// DisAmtDtl3 of the BranchReturnBillDetailRequest
    /// DisAmtDtl3 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl3 { get; private set; }

    /// <summary>
    /// DisAmtDtlVat of the BranchReturnBillDetailRequest
    /// DisAmtDtlVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtlVat { get; private set; }

    /// <summary>
    /// DisAmtDtl2Vat of the BranchReturnBillDetailRequest
    /// DisAmtDtl2Vat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl2Vat { get; private set; }

    /// <summary>
    /// DisAmtDtl3Vat of the BranchReturnBillDetailRequest
    /// DisAmtDtl3Vat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtDtl3Vat { get; private set; }

    /// <summary>
    /// DisAmtMstVat of the BranchReturnBillDetailRequest
    /// DisAmtMstVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetailVat of the BranchReturnBillDetailRequest
    /// VatAmountDiscountDetailVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetailVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail2Vat of the BranchReturnBillDetailRequest
    /// VatAmountDiscountDetail2Vat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetail2Vat { get; private set; }

    /// <summary>
    /// VatAmountDiscountDetail3Vat of the BranchReturnBillDetailRequest
    /// VatAmountDiscountDetail3Vat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountDetail3Vat { get; private set; }

    /// <summary>
    /// VatAmountAfterDiscount of the BranchReturnBillDetailRequest
    /// VatAmountAfterDiscount الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountAfterDiscount { get; private set; }

    /// <summary>
    /// VatAmountBeforeDiscount of the BranchReturnBillDetailRequest
    /// VatAmountBeforeDiscount الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountBeforeDiscount { get; private set; }

    /// <summary>
    /// VatAmountDiscountMasterVat of the BranchReturnBillDetailRequest
    /// VatAmountDiscountMasterVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? VatAmountDiscountMasterVat { get; private set; }

    /// <summary>
    /// DisAmtAftrVat of the BranchReturnBillDetailRequest
    /// DisAmtAftrVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DisAmtAftrVat { get; private set; }

    /// <summary>
    /// ItemLength of the BranchReturnBillDetailRequest
    /// ItemLength الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the BranchReturnBillDetailRequest
    /// ItemWidth الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the BranchReturnBillDetailRequest
    /// ItemHeightShort الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the BranchReturnBillDetailRequest
    /// ItemNumberShort الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// PostCode of the BranchReturnBillDetailRequest
    /// PostCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// FieldDetail1 of the BranchReturnBillDetailRequest
    /// FieldDetail1 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the BranchReturnBillDetailRequest
    /// FieldDetail2 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the BranchReturnBillDetailRequest
    /// FieldDetail3 الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// SubCustomerCode of the BranchReturnBillDetailRequest
    /// SubCustomerCode الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchReturnBillDetailRequest
    /// CompanyNumberShort الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchReturnBillDetailRequest
    /// BranchNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchReturnBillDetailRequest
    /// BranchYear الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchReturnBillDetailRequest
    /// BranchUser الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchReturnBillDetailRequest
    /// ItemUnit الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the BranchReturnBillDetailRequest
    /// WeightedQuantity الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the BranchReturnBillDetailRequest
    /// WeightedUnit الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchReturnBillDetailRequest
    /// InsuranceLoadPercent الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the BranchReturnBillDetailRequest
    /// InsuranceLoadAmount الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the BranchReturnBillDetailRequest
    /// InsuranceAdditionalLimit الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// EmpNo of the BranchReturnBillDetailRequest
    /// EmpNo الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// DocSequence of the BranchReturnBillDetailRequest
    /// DocSequence الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ArgumentNumber of the BranchReturnBillDetailRequest
    /// ArgumentNumber الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// ItemPriceVat of the BranchReturnBillDetailRequest
    /// ItemPriceVat الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? ItemPriceVat { get; private set; }

    /// <summary>
    /// DocTypeRef of the BranchReturnBillDetailRequest
    /// DocTypeRef الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BranchReturnBillDetailRequest
    /// DocSerRef الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BranchReturnBillDetailRequest
    /// DocNoRef الخاص بـ BranchReturnBillDetailRequest
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BranchReturnBillMasterRequest BranchReturnBillMasterRequest { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
