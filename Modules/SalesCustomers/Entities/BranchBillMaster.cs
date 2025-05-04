using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchBillMaster Entity
/// </summary>
public class BranchBillMaster : Entity<BranchBillMasterId>
{
    private BranchBillMaster() { }

    /// <summary>
    /// The unique identifier for the BranchBillMaster
    /// المعرف الفريد لـ BranchBillMaster
    /// </summary>
    public BranchBillMasterId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchBillMaster
    /// BillDocumentTypeFull الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchBillMaster
    /// BillNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchBillMaster
    /// BillSerial الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the BranchBillMaster
    /// BillDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillCurrency of the BranchBillMaster
    /// BillCurrency الخاص بـ BranchBillMaster
    /// </summary>
    public string BillCurrency { get; private set; }

    /// <summary>
    /// BillRate of the BranchBillMaster
    /// BillRate الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BranchBillMaster
    /// StockRateShort الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the BranchBillMaster
    /// CCode الخاص بـ BranchBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the BranchBillMaster
    /// CName الخاص بـ BranchBillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountCode of the BranchBillMaster
    /// AccountCode الخاص بـ BranchBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the BranchBillMaster
    /// ChequeNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the BranchBillMaster
    /// NoteNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the BranchBillMaster
    /// ChequeAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the BranchBillMaster
    /// ChequeDueDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// BillDueDate of the BranchBillMaster
    /// BillDueDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// BillPostFlag of the BranchBillMaster
    /// BillPostFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillPostFlag { get; private set; }

    /// <summary>
    /// DiscAmt of the BranchBillMaster
    /// DiscAmt الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the BranchBillMaster
    /// DiscAmtMst الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the BranchBillMaster
    /// DiscAmtDtl الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the BranchBillMaster
    /// DiscAmtMstVat الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the BranchBillMaster
    /// VatAmountDiscountMaster الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchBillMaster
    /// OtherAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the BranchBillMaster
    /// VatAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// BillAmount of the BranchBillMaster
    /// BillAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// CouponAmount of the BranchBillMaster
    /// CouponAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CouponAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchBillMaster
    /// WarehouseCode الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RegionCode of the BranchBillMaster
    /// RegionCode الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the BranchBillMaster
    /// RepCode الخاص بـ BranchBillMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// EmpNo of the BranchBillMaster
    /// EmpNo الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchBillMaster
    /// ReferenceNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the BranchBillMaster
    /// CashNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchBillMaster
    /// CostCenterCode الخاص بـ BranchBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchBillMaster
    /// ProjectNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchBillMaster
    /// ActivityNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the BranchBillMaster
    /// CreditCardNumberFull الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// CreditCardAmount of the BranchBillMaster
    /// CreditCardAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardAmount { get; private set; }

    /// <summary>
    /// CreditCard of the BranchBillMaster
    /// CreditCard الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCard { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BranchBillMaster
    /// SalesInvoiceType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchBillMaster
    /// AttachmentCount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ExportFlag of the BranchBillMaster
    /// ExportFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchBillMaster
    /// StandByFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// CancelFlag of the BranchBillMaster
    /// CancelFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CancelFlag { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BranchBillMaster
    /// ColumnNumberShort الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the BranchBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ BranchBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the BranchBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchBillMaster
    /// AccountDescription الخاص بـ BranchBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchBillMaster
    /// CommissionPercent الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BranchBillMaster
    /// ProcessedFlagFull الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BranchBillMaster
    /// BillPaymentYear الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchBillMaster
    /// ExternalPostFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the BranchBillMaster
    /// DocSerExtrnl الخاص بـ BranchBillMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CalcTaxInsuranceCompanyFlag of the BranchBillMaster
    /// CalcTaxInsuranceCompanyFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CalcTaxInsuranceCompanyFlag { get; private set; }

    /// <summary>
    /// CalcInsuranceLoadAmountMethod of the BranchBillMaster
    /// CalcInsuranceLoadAmountMethod الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CalcInsuranceLoadAmountMethod { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BranchBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// LoadNumber of the BranchBillMaster
    /// LoadNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// LoadSerial of the BranchBillMaster
    /// LoadSerial الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? LoadSerial { get; private set; }

    /// <summary>
    /// AuditReference of the BranchBillMaster
    /// AuditReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchBillMaster
    /// AuditReferenceDescription الخاص بـ BranchBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchBillMaster
    /// AuditReferenceUserId الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchBillMaster
    /// AuditReferenceDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// BillNumberConnection of the BranchBillMaster
    /// BillNumberConnection الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillNumberConnection { get; private set; }

    /// <summary>
    /// BillSerialConnection of the BranchBillMaster
    /// BillSerialConnection الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillSerialConnection { get; private set; }

    /// <summary>
    /// PatientNumber of the BranchBillMaster
    /// PatientNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// DctrNo of the BranchBillMaster
    /// DctrNo الخاص بـ BranchBillMaster
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// PatientType of the BranchBillMaster
    /// PatientType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PatientType { get; private set; }

    /// <summary>
    /// DocNoAdmson of the BranchBillMaster
    /// DocNoAdmson الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocNoAdmson { get; private set; }

    /// <summary>
    /// DocSrlAdmson of the BranchBillMaster
    /// DocSrlAdmson الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocSrlAdmson { get; private set; }

    /// <summary>
    /// AdvancePaymentPercentContract of the BranchBillMaster
    /// AdvancePaymentPercentContract الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AdvancePaymentPercentContract { get; private set; }

    /// <summary>
    /// Field1 of the BranchBillMaster
    /// Field1 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchBillMaster
    /// Field2 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchBillMaster
    /// Field3 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchBillMaster
    /// Field4 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchBillMaster
    /// Field5 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchBillMaster
    /// Field6 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchBillMaster
    /// Field7 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchBillMaster
    /// Field8 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchBillMaster
    /// Field9 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchBillMaster
    /// Field10 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the BranchBillMaster
    /// Field11 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the BranchBillMaster
    /// Field12 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the BranchBillMaster
    /// Field13 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the BranchBillMaster
    /// Field14 الخاص بـ BranchBillMaster
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// HoursDocumentNumberReference of the BranchBillMaster
    /// HoursDocumentNumberReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// HoursDocumentTypeReference of the BranchBillMaster
    /// HoursDocumentTypeReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? HoursDocumentTypeReference { get; private set; }

    /// <summary>
    /// HoursDocumentSerialReference of the BranchBillMaster
    /// HoursDocumentSerialReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? HoursDocumentSerialReference { get; private set; }

    /// <summary>
    /// CTel of the BranchBillMaster
    /// CTel الخاص بـ BranchBillMaster
    /// </summary>
    public string CTel { get; private set; }

    /// <summary>
    /// CAddress of the BranchBillMaster
    /// CAddress الخاص بـ BranchBillMaster
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// ReceiveName of the BranchBillMaster
    /// ReceiveName الخاص بـ BranchBillMaster
    /// </summary>
    public string ReceiveName { get; private set; }

    /// <summary>
    /// DocNoPda of the BranchBillMaster
    /// DocNoPda الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// PdaName of the BranchBillMaster
    /// PdaName الخاص بـ BranchBillMaster
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// CreditCardNumberSecond of the BranchBillMaster
    /// CreditCardNumberSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardAmountSecond of the BranchBillMaster
    /// CreditCardAmountSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardNumberThird of the BranchBillMaster
    /// CreditCardNumberThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardNumberThird { get; private set; }

    /// <summary>
    /// CreditCardAmountThird of the BranchBillMaster
    /// CreditCardAmountThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardAmountThird { get; private set; }

    /// <summary>
    /// DriverNo of the BranchBillMaster
    /// DriverNo الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the BranchBillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the BranchBillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BranchBillMaster
    /// OtherAmountDiscount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BranchBillMaster
    /// CalcTypeNumberTax الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// PaidAmount of the BranchBillMaster
    /// PaidAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidBillFlag of the BranchBillMaster
    /// PaidBillFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PaidBillFlag { get; private set; }

    /// <summary>
    /// PaidUserId of the BranchBillMaster
    /// PaidUserId الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PaidUserId { get; private set; }

    /// <summary>
    /// PaidDate of the BranchBillMaster
    /// PaidDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// ReceiveInvoiceBill of the BranchBillMaster
    /// ReceiveInvoiceBill الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceBill { get; private set; }

    /// <summary>
    /// ReceiveInvoiceUserId of the BranchBillMaster
    /// ReceiveInvoiceUserId الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceUserId { get; private set; }

    /// <summary>
    /// ReceiveInvoiceDate of the BranchBillMaster
    /// ReceiveInvoiceDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }

    /// <summary>
    /// BillValuedFlag of the BranchBillMaster
    /// BillValuedFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillValuedFlag { get; private set; }

    /// <summary>
    /// ValueDate of the BranchBillMaster
    /// ValueDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// PosPostFlag of the BranchBillMaster
    /// PosPostFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PosPostFlag { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReference of the BranchBillMaster
    /// CreditDocumentNumberReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReference { get; private set; }

    /// <summary>
    /// BillWithoutAutoOtherAmount of the BranchBillMaster
    /// BillWithoutAutoOtherAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillWithoutAutoOtherAmount { get; private set; }

    /// <summary>
    /// CreditValued of the BranchBillMaster
    /// CreditValued الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditValued { get; private set; }

    /// <summary>
    /// CreditValuedSecond of the BranchBillMaster
    /// CreditValuedSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditValuedSecond { get; private set; }

    /// <summary>
    /// CreditValuedThird of the BranchBillMaster
    /// CreditValuedThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditValuedThird { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReferenceSecond of the BranchBillMaster
    /// CreditDocumentNumberReferenceSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReferenceThird of the BranchBillMaster
    /// CreditDocumentNumberReferenceThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditValueDate of the BranchBillMaster
    /// CreditValueDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? CreditValueDate { get; private set; }

    /// <summary>
    /// CreditValueDateSecond of the BranchBillMaster
    /// CreditValueDateSecond الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? CreditValueDateSecond { get; private set; }

    /// <summary>
    /// CreditValueDateThird of the BranchBillMaster
    /// CreditValueDateThird الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? CreditValueDateThird { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercent of the BranchBillMaster
    /// CreditCardCommissionPercent الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercent { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentSecond of the BranchBillMaster
    /// CreditCardCommissionPercentSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentSecond { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentThird of the BranchBillMaster
    /// CreditCardCommissionPercentThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentThird { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmount of the BranchBillMaster
    /// CreditCardMaxCommissionAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmount { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountSecond of the BranchBillMaster
    /// CreditCardMaxCommissionAmountSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountThird of the BranchBillMaster
    /// CreditCardMaxCommissionAmountThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountThird { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumber of the BranchBillMaster
    /// CreditCardCustomerNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardCustomerNumber { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberSecond of the BranchBillMaster
    /// CreditCardCustomerNumberSecond الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardCustomerNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberThird of the BranchBillMaster
    /// CreditCardCustomerNumberThird الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardCustomerNumberThird { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReference of the BranchBillMaster
    /// CreditCardDocumentNumberReference الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReference { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceSecond of the BranchBillMaster
    /// CreditCardDocumentNumberReferenceSecond الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceThird of the BranchBillMaster
    /// CreditCardDocumentNumberReferenceThird الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditCardDescription of the BranchBillMaster
    /// CreditCardDescription الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardDescription { get; private set; }

    /// <summary>
    /// CreditCardDescriptionSecond of the BranchBillMaster
    /// CreditCardDescriptionSecond الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardDescriptionSecond { get; private set; }

    /// <summary>
    /// CreditCardDescriptionThird of the BranchBillMaster
    /// CreditCardDescriptionThird الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditCardDescriptionThird { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the BranchBillMaster
    /// QuotationPremiumNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the BranchBillMaster
    /// QuotationPremiumSerial الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the BranchBillMaster
    /// QuotationPremiumRecordNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// PromoterCode of the BranchBillMaster
    /// PromoterCode الخاص بـ BranchBillMaster
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchBillMaster
    /// DocBrnNo الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumber of the BranchBillMaster
    /// CompanyNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CompanyNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the BranchBillMaster
    /// MobileNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? MobileNumber { get; private set; }

    /// <summary>
    /// SendTelephoneSuccessFlag of the BranchBillMaster
    /// SendTelephoneSuccessFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? SendTelephoneSuccessFlag { get; private set; }

    /// <summary>
    /// SendTelephoneResultCode of the BranchBillMaster
    /// SendTelephoneResultCode الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? SendTelephoneResultCode { get; private set; }

    /// <summary>
    /// NotUseQuotationPremium of the BranchBillMaster
    /// NotUseQuotationPremium الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? NotUseQuotationPremium { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the BranchBillMaster
    /// InsuranceCompanyNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the BranchBillMaster
    /// InsuranceBenefitNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the BranchBillMaster
    /// InsurancePersonName الخاص بـ BranchBillMaster
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the BranchBillMaster
    /// InsuranceCardNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the BranchBillMaster
    /// InsuranceCardNumberFamily الخاص بـ BranchBillMaster
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the BranchBillMaster
    /// InsuranceRelationType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the BranchBillMaster
    /// InsuranceClassNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchBillMaster
    /// InsuranceLoadPercent الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceDiagnosis of the BranchBillMaster
    /// InsuranceDiagnosis الخاص بـ BranchBillMaster
    /// </summary>
    public string InsuranceDiagnosis { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the BranchBillMaster
    /// InsuranceMedicalNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the BranchBillMaster
    /// InsuranceApprovedCode الخاص بـ BranchBillMaster
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the BranchBillMaster
    /// InsuranceCashAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BranchBillMaster
    /// InsuranceAdditionalLimitMaster الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDocument of the BranchBillMaster
    /// InsuranceAdditionalLimitDocument الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDocument { get; private set; }

    /// <summary>
    /// InsuranceMedicineChronicFlag of the BranchBillMaster
    /// InsuranceMedicineChronicFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceMedicineChronicFlag { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the BranchBillMaster
    /// InsuranceLimitAmountLocalDocument الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    /// <summary>
    /// BillStatusType of the BranchBillMaster
    /// BillStatusType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BillStatusType { get; private set; }

    /// <summary>
    /// ProcedureType of the BranchBillMaster
    /// ProcedureType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ProcedureType { get; private set; }

    /// <summary>
    /// PercentAmount of the BranchBillMaster
    /// PercentAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PercentAmount { get; private set; }

    /// <summary>
    /// ClinicNumber of the BranchBillMaster
    /// ClinicNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ClinicNumber { get; private set; }

    /// <summary>
    /// VisitTypeNumber of the BranchBillMaster
    /// VisitTypeNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? VisitTypeNumber { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the BranchBillMaster
    /// PeriodNumberShort الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// DocNoRes of the BranchBillMaster
    /// DocNoRes الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocNoRes { get; private set; }

    /// <summary>
    /// DocSrlRes of the BranchBillMaster
    /// DocSrlRes الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocSrlRes { get; private set; }

    /// <summary>
    /// BlockResultFlag of the BranchBillMaster
    /// BlockResultFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BlockResultFlag { get; private set; }

    /// <summary>
    /// SfdaDoctorNumber of the BranchBillMaster
    /// SfdaDoctorNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string SfdaDoctorNumber { get; private set; }

    /// <summary>
    /// SfdaPatientId of the BranchBillMaster
    /// SfdaPatientId الخاص بـ BranchBillMaster
    /// </summary>
    public string SfdaPatientId { get; private set; }

    /// <summary>
    /// SfdaProspectNumber of the BranchBillMaster
    /// SfdaProspectNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string SfdaProspectNumber { get; private set; }

    /// <summary>
    /// SfdaProspectDate of the BranchBillMaster
    /// SfdaProspectDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? SfdaProspectDate { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BranchBillMaster
    /// CommissionAmountDetail الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// ConnectionSalesInvoiceWithOutgoing of the BranchBillMaster
    /// ConnectionSalesInvoiceWithOutgoing الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ConnectionSalesInvoiceWithOutgoing { get; private set; }

    /// <summary>
    /// CCodeCsh of the BranchBillMaster
    /// CCodeCsh الخاص بـ BranchBillMaster
    /// </summary>
    public string CCodeCsh { get; private set; }

    /// <summary>
    /// CouponFlag of the BranchBillMaster
    /// CouponFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CouponFlag { get; private set; }

    /// <summary>
    /// CustomerGCC of the BranchBillMaster
    /// CustomerGCC الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// ReceiveNote of the BranchBillMaster
    /// ReceiveNote الخاص بـ BranchBillMaster
    /// </summary>
    public string ReceiveNote { get; private set; }

    /// <summary>
    /// TankCode of the BranchBillMaster
    /// TankCode الخاص بـ BranchBillMaster
    /// </summary>
    public string TankCode { get; private set; }

    /// <summary>
    /// PointReplaceAmount of the BranchBillMaster
    /// PointReplaceAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointReplaceAmount { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchBillMaster
    /// VatAmountOther الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CTaxCode of the BranchBillMaster
    /// CTaxCode الخاص بـ BranchBillMaster
    /// </summary>
    public string CTaxCode { get; private set; }

    /// <summary>
    /// ContractDate of the BranchBillMaster
    /// ContractDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ContractNumber of the BranchBillMaster
    /// ContractNumber الخاص بـ BranchBillMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// CreditNoDiscount of the BranchBillMaster
    /// CreditNoDiscount الخاص بـ BranchBillMaster
    /// </summary>
    public string CreditNoDiscount { get; private set; }

    /// <summary>
    /// CreditDiscountPercent of the BranchBillMaster
    /// CreditDiscountPercent الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CreditDiscountPercent { get; private set; }

    /// <summary>
    /// DocSrlCntrct of the BranchBillMaster
    /// DocSrlCntrct الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocSrlCntrct { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the BranchBillMaster
    /// ContractBatchNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// PointTypeNumber of the BranchBillMaster
    /// PointTypeNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointCalculationTypeNumber of the BranchBillMaster
    /// PointCalculationTypeNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointCalculationTypeNumber { get; private set; }

    /// <summary>
    /// PointCount of the BranchBillMaster
    /// PointCount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointCountAll of the BranchBillMaster
    /// PointCountAll الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointCountAll { get; private set; }

    /// <summary>
    /// PointReplaceCount of the BranchBillMaster
    /// PointReplaceCount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PointReplaceCount { get; private set; }

    /// <summary>
    /// AssessmentAmount of the BranchBillMaster
    /// AssessmentAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AssessmentAmount { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the BranchBillMaster
    /// DiscAmtAftrVat الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// AccountAmount of the BranchBillMaster
    /// AccountAmount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountCode of the BranchBillMaster
    /// AccountCode الخاص بـ BranchBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchBillMaster
    /// AccountDetailCode الخاص بـ BranchBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchBillMaster
    /// AccountDetailType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// PaymentAccount of the BranchBillMaster
    /// PaymentAccount الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BranchBillMaster
    /// CalcVatPriceType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// OutgoingBillType of the BranchBillMaster
    /// OutgoingBillType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? OutgoingBillType { get; private set; }

    /// <summary>
    /// RmsBillDocumentType of the BranchBillMaster
    /// RmsBillDocumentType الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? RmsBillDocumentType { get; private set; }

    /// <summary>
    /// RmsFreeFlag of the BranchBillMaster
    /// RmsFreeFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? RmsFreeFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BranchBillMaster
    /// WebServiceTransferDataFlag الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceUuid of the BranchBillMaster
    /// WebServiceUuid الخاص بـ BranchBillMaster
    /// </summary>
    public string WebServiceUuid { get; private set; }

    /// <summary>
    /// DocMSq of the BranchBillMaster
    /// DocMSq الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BranchBillMaster
    /// CreatedDateClock الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// PostUserId of the BranchBillMaster
    /// PostUserId الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchBillMaster
    /// PostDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchBillMaster
    /// UnpostUserId الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchBillMaster
    /// UnpostDate الخاص بـ BranchBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchBillMaster
    /// CompanyNumberShort الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchBillMaster
    /// BranchNumber الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchBillMaster
    /// BranchYear الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchBillMaster
    /// BranchUser الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDetail of the BranchBillMaster
    /// InsuranceAdditionalLimitDetail الخاص بـ BranchBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDetail { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: BranchBillMaster to BranchBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchBillDetail> BranchBillDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
