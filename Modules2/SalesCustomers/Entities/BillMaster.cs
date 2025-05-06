using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.InsuranceClaims.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillMaster Entity
/// </summary>
public class BillMaster : Entity<BillMasterId>
{

    private BillMaster() { }

    public BillMaster(BillMasterId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the BillMaster
    /// المعرف الفريد لـ BillMaster
    /// </summary>
    public BillMasterId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BillMaster
    /// BillDocumentTypeFull الخاص بـ BillMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BillMaster
    /// BillNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillMaster
    /// BillSerial الخاص بـ BillMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the BillMaster
    /// BillDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillRate of the BillMaster
    /// BillRate الخاص بـ BillMaster
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BillMaster
    /// StockRateShort الخاص بـ BillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CName of the BillMaster
    /// CName الخاص بـ BillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// ChequeNumber of the BillMaster
    /// ChequeNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the BillMaster
    /// NoteNumber الخاص بـ BillMaster
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the BillMaster
    /// ChequeAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the BillMaster
    /// ChequeDueDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// BillDueDate of the BillMaster
    /// BillDueDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// BillPostFlag of the BillMaster
    /// BillPostFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? BillPostFlag { get; private set; }

    /// <summary>
    /// DiscAmt of the BillMaster
    /// DiscAmt الخاص بـ BillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the BillMaster
    /// DiscAmtMst الخاص بـ BillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the BillMaster
    /// DiscAmtDtl الخاص بـ BillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the BillMaster
    /// DiscAmtMstVat الخاص بـ BillMaster
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the BillMaster
    /// VatAmountDiscountMaster الخاص بـ BillMaster
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// OtherAmount of the BillMaster
    /// OtherAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the BillMaster
    /// VatAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// BillAmount of the BillMaster
    /// BillAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// CouponAmount of the BillMaster
    /// CouponAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? CouponAmount { get; private set; }

    /// <summary>
    /// EmpNo of the BillMaster
    /// EmpNo الخاص بـ BillMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BillMaster
    /// ReferenceNumber الخاص بـ BillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the BillMaster
    /// CashNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CreditCardAmount of the BillMaster
    /// CreditCardAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardAmount { get; private set; }

    /// <summary>
    /// CreditCard of the BillMaster
    /// CreditCard الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCard { get; private set; }

    /// <summary>
    /// AttachmentCount of the BillMaster
    /// AttachmentCount الخاص بـ BillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ExportFlag of the BillMaster
    /// ExportFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// StandByFlag of the BillMaster
    /// StandByFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the BillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ BillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the BillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ BillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// AccountDescription of the BillMaster
    /// AccountDescription الخاص بـ BillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CommissionPercent of the BillMaster
    /// CommissionPercent الخاص بـ BillMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BillMaster
    /// ProcessedFlagFull الخاص بـ BillMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BillMaster
    /// BillPaymentYear الخاص بـ BillMaster
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BillMaster
    /// ExternalPostFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// LoadNumber of the BillMaster
    /// LoadNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? LoadNumber { get; private set; }

    /// <summary>
    /// LoadSerial of the BillMaster
    /// LoadSerial الخاص بـ BillMaster
    /// </summary>
    public decimal? LoadSerial { get; private set; }

    /// <summary>
    /// AuditReference of the BillMaster
    /// AuditReference الخاص بـ BillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BillMaster
    /// AuditReferenceDescription الخاص بـ BillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BillMaster
    /// AuditReferenceUserId الخاص بـ BillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BillMaster
    /// AuditReferenceDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// BillNumberConnection of the BillMaster
    /// BillNumberConnection الخاص بـ BillMaster
    /// </summary>
    public decimal? BillNumberConnection { get; private set; }

    /// <summary>
    /// BillSerialConnection of the BillMaster
    /// BillSerialConnection الخاص بـ BillMaster
    /// </summary>
    public decimal? BillSerialConnection { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BillMaster
    /// CalcTypeNumberTax الخاص بـ BillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// AccountAmount of the BillMaster
    /// AccountAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// Field1 of the BillMaster
    /// Field1 الخاص بـ BillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BillMaster
    /// Field2 الخاص بـ BillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BillMaster
    /// Field3 الخاص بـ BillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BillMaster
    /// Field4 الخاص بـ BillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BillMaster
    /// Field5 الخاص بـ BillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BillMaster
    /// Field6 الخاص بـ BillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BillMaster
    /// Field7 الخاص بـ BillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BillMaster
    /// Field8 الخاص بـ BillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BillMaster
    /// Field9 الخاص بـ BillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BillMaster
    /// Field10 الخاص بـ BillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the BillMaster
    /// Field11 الخاص بـ BillMaster
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the BillMaster
    /// Field12 الخاص بـ BillMaster
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the BillMaster
    /// Field13 الخاص بـ BillMaster
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the BillMaster
    /// Field14 الخاص بـ BillMaster
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// CTel of the BillMaster
    /// CTel الخاص بـ BillMaster
    /// </summary>
    public string CTel { get; private set; }

    /// <summary>
    /// CAddress of the BillMaster
    /// CAddress الخاص بـ BillMaster
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// ReceiveName of the BillMaster
    /// ReceiveName الخاص بـ BillMaster
    /// </summary>
    public string ReceiveName { get; private set; }

    /// <summary>
    /// DocNoPda of the BillMaster
    /// DocNoPda الخاص بـ BillMaster
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// PdaName of the BillMaster
    /// PdaName الخاص بـ BillMaster
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// CreditCardNumberSecond of the BillMaster
    /// CreditCardNumberSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardAmountSecond of the BillMaster
    /// CreditCardAmountSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardNumberThird of the BillMaster
    /// CreditCardNumberThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardNumberThird { get; private set; }

    /// <summary>
    /// CreditCardAmountThird of the BillMaster
    /// CreditCardAmountThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardAmountThird { get; private set; }

    /// <summary>
    /// DriverNo of the BillMaster
    /// DriverNo الخاص بـ BillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the BillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ BillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the BillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ BillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BillMaster
    /// OtherAmountDiscount الخاص بـ BillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// PaidAmount of the BillMaster
    /// PaidAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidBillFlag of the BillMaster
    /// PaidBillFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? PaidBillFlag { get; private set; }

    /// <summary>
    /// PaidUserId of the BillMaster
    /// PaidUserId الخاص بـ BillMaster
    /// </summary>
    public decimal? PaidUserId { get; private set; }

    /// <summary>
    /// PaidDate of the BillMaster
    /// PaidDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// ReceiveInvoiceBill of the BillMaster
    /// ReceiveInvoiceBill الخاص بـ BillMaster
    /// </summary>
    public decimal? ReceiveInvoiceBill { get; private set; }

    /// <summary>
    /// ReceiveInvoiceUserId of the BillMaster
    /// ReceiveInvoiceUserId الخاص بـ BillMaster
    /// </summary>
    public decimal? ReceiveInvoiceUserId { get; private set; }

    /// <summary>
    /// ReceiveInvoiceDate of the BillMaster
    /// ReceiveInvoiceDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }

    /// <summary>
    /// BillValuedFlag of the BillMaster
    /// BillValuedFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? BillValuedFlag { get; private set; }

    /// <summary>
    /// ValueDate of the BillMaster
    /// ValueDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// PosPostFlag of the BillMaster
    /// PosPostFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? PosPostFlag { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReference of the BillMaster
    /// CreditDocumentNumberReference الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReference { get; private set; }

    /// <summary>
    /// BillWithoutAutoOtherAmount of the BillMaster
    /// BillWithoutAutoOtherAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? BillWithoutAutoOtherAmount { get; private set; }

    /// <summary>
    /// CreditValued of the BillMaster
    /// CreditValued الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditValued { get; private set; }

    /// <summary>
    /// CreditValuedSecond of the BillMaster
    /// CreditValuedSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditValuedSecond { get; private set; }

    /// <summary>
    /// CreditValuedThird of the BillMaster
    /// CreditValuedThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditValuedThird { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReferenceSecond of the BillMaster
    /// CreditDocumentNumberReferenceSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditDocumentNumberReferenceThird of the BillMaster
    /// CreditDocumentNumberReferenceThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditValueDate of the BillMaster
    /// CreditValueDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? CreditValueDate { get; private set; }

    /// <summary>
    /// CreditValueDateSecond of the BillMaster
    /// CreditValueDateSecond الخاص بـ BillMaster
    /// </summary>
    public DateTime? CreditValueDateSecond { get; private set; }

    /// <summary>
    /// CreditValueDateThird of the BillMaster
    /// CreditValueDateThird الخاص بـ BillMaster
    /// </summary>
    public DateTime? CreditValueDateThird { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercent of the BillMaster
    /// CreditCardCommissionPercent الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercent { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentSecond of the BillMaster
    /// CreditCardCommissionPercentSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentSecond { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentThird of the BillMaster
    /// CreditCardCommissionPercentThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentThird { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the BillMaster
    /// QuotationPremiumNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the BillMaster
    /// QuotationPremiumSerial الخاص بـ BillMaster
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the BillMaster
    /// QuotationPremiumRecordNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the BillMaster
    /// DocBrnNo الخاص بـ BillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumber of the BillMaster
    /// CompanyNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? CompanyNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the BillMaster
    /// MobileNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? MobileNumber { get; private set; }

    /// <summary>
    /// SendTelephoneSuccessFlag of the BillMaster
    /// SendTelephoneSuccessFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? SendTelephoneSuccessFlag { get; private set; }

    /// <summary>
    /// SendTelephoneResultCode of the BillMaster
    /// SendTelephoneResultCode الخاص بـ BillMaster
    /// </summary>
    public decimal? SendTelephoneResultCode { get; private set; }

    /// <summary>
    /// NotUseQuotationPremium of the BillMaster
    /// NotUseQuotationPremium الخاص بـ BillMaster
    /// </summary>
    public decimal? NotUseQuotationPremium { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the BillMaster
    /// InsuranceCompanyNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the BillMaster
    /// InsuranceBenefitNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the BillMaster
    /// InsurancePersonName الخاص بـ BillMaster
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the BillMaster
    /// InsuranceCardNumber الخاص بـ BillMaster
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the BillMaster
    /// InsuranceCardNumberFamily الخاص بـ BillMaster
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the BillMaster
    /// InsuranceRelationType الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the BillMaster
    /// InsuranceClassNumber الخاص بـ BillMaster
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BillMaster
    /// InsuranceLoadPercent الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceDiagnosis of the BillMaster
    /// InsuranceDiagnosis الخاص بـ BillMaster
    /// </summary>
    public string InsuranceDiagnosis { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the BillMaster
    /// InsuranceMedicalNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the BillMaster
    /// InsuranceApprovedCode الخاص بـ BillMaster
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the BillMaster
    /// InsuranceCashAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BillMaster
    /// CommissionAmountDetail الخاص بـ BillMaster
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// ConnectionSalesInvoiceWithOutgoing of the BillMaster
    /// ConnectionSalesInvoiceWithOutgoing الخاص بـ BillMaster
    /// </summary>
    public decimal? ConnectionSalesInvoiceWithOutgoing { get; private set; }

    /// <summary>
    /// CCodeCsh of the BillMaster
    /// CCodeCsh الخاص بـ BillMaster
    /// </summary>
    public string CCodeCsh { get; private set; }

    /// <summary>
    /// CouponFlag of the BillMaster
    /// CouponFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? CouponFlag { get; private set; }

    /// <summary>
    /// CustomerGCC of the BillMaster
    /// CustomerGCC الخاص بـ BillMaster
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// ReceiveNote of the BillMaster
    /// ReceiveNote الخاص بـ BillMaster
    /// </summary>
    public string ReceiveNote { get; private set; }

    /// <summary>
    /// TankCode of the BillMaster
    /// TankCode الخاص بـ BillMaster
    /// </summary>
    public string TankCode { get; private set; }

    /// <summary>
    /// PointReplaceAmount of the BillMaster
    /// PointReplaceAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? PointReplaceAmount { get; private set; }

    /// <summary>
    /// VatAmountOther of the BillMaster
    /// VatAmountOther الخاص بـ BillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CTaxCode of the BillMaster
    /// CTaxCode الخاص بـ BillMaster
    /// </summary>
    public string CTaxCode { get; private set; }

    /// <summary>
    /// ContractDate of the BillMaster
    /// ContractDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ContractNumber of the BillMaster
    /// ContractNumber الخاص بـ BillMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// CreditNoDiscount of the BillMaster
    /// CreditNoDiscount الخاص بـ BillMaster
    /// </summary>
    public string CreditNoDiscount { get; private set; }

    /// <summary>
    /// CreditDiscountPercent of the BillMaster
    /// CreditDiscountPercent الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditDiscountPercent { get; private set; }

    /// <summary>
    /// DocSrlCntrct of the BillMaster
    /// DocSrlCntrct الخاص بـ BillMaster
    /// </summary>
    public decimal? DocSrlCntrct { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the BillMaster
    /// ContractBatchNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// PointTypeNumber of the BillMaster
    /// PointTypeNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointCalculationTypeNumber of the BillMaster
    /// PointCalculationTypeNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? PointCalculationTypeNumber { get; private set; }

    /// <summary>
    /// PointCount of the BillMaster
    /// PointCount الخاص بـ BillMaster
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointCountAll of the BillMaster
    /// PointCountAll الخاص بـ BillMaster
    /// </summary>
    public decimal? PointCountAll { get; private set; }

    /// <summary>
    /// PointReplaceCount of the BillMaster
    /// PointReplaceCount الخاص بـ BillMaster
    /// </summary>
    public decimal? PointReplaceCount { get; private set; }

    /// <summary>
    /// AssessmentAmount of the BillMaster
    /// AssessmentAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? AssessmentAmount { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the BillMaster
    /// DiscAmtAftrVat الخاص بـ BillMaster
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// CalcInsuranceLoadAmountMethod of the BillMaster
    /// CalcInsuranceLoadAmountMethod الخاص بـ BillMaster
    /// </summary>
    public decimal? CalcInsuranceLoadAmountMethod { get; private set; }

    /// <summary>
    /// AccountCode of the BillMaster
    /// AccountCode الخاص بـ BillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BillMaster
    /// AccountDetailCode الخاص بـ BillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BillMaster
    /// AccountDetailType الخاص بـ BillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// PaymentAccount of the BillMaster
    /// PaymentAccount الخاص بـ BillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// PostUserId of the BillMaster
    /// PostUserId الخاص بـ BillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BillMaster
    /// PostDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BillMaster
    /// UnpostUserId الخاص بـ BillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BillMaster
    /// UnpostDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillMaster
    /// CompanyNumberShort الخاص بـ BillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillMaster
    /// BranchNumber الخاص بـ BillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillMaster
    /// BranchYear الخاص بـ BillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillMaster
    /// BranchUser الخاص بـ BillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxInsuranceCompanyFlag of the BillMaster
    /// CalcTaxInsuranceCompanyFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? CalcTaxInsuranceCompanyFlag { get; private set; }

    /// <summary>
    /// PatientNumber of the BillMaster
    /// PatientNumber الخاص بـ BillMaster
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// DctrNo of the BillMaster
    /// DctrNo الخاص بـ BillMaster
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// PatientType of the BillMaster
    /// PatientType الخاص بـ BillMaster
    /// </summary>
    public decimal? PatientType { get; private set; }

    /// <summary>
    /// DocNoAdmson of the BillMaster
    /// DocNoAdmson الخاص بـ BillMaster
    /// </summary>
    public decimal? DocNoAdmson { get; private set; }

    /// <summary>
    /// DocSrlAdmson of the BillMaster
    /// DocSrlAdmson الخاص بـ BillMaster
    /// </summary>
    public decimal? DocSrlAdmson { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the BillMaster
    /// DocSerExtrnl الخاص بـ BillMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CancelFlag of the BillMaster
    /// CancelFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? CancelFlag { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BillMaster
    /// CalcVatPriceType الخاص بـ BillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// OutgoingBillType of the BillMaster
    /// OutgoingBillType الخاص بـ BillMaster
    /// </summary>
    public decimal? OutgoingBillType { get; private set; }

    /// <summary>
    /// SfdaDoctorNumber of the BillMaster
    /// SfdaDoctorNumber الخاص بـ BillMaster
    /// </summary>
    public string SfdaDoctorNumber { get; private set; }

    /// <summary>
    /// SfdaPatientId of the BillMaster
    /// SfdaPatientId الخاص بـ BillMaster
    /// </summary>
    public string SfdaPatientId { get; private set; }

    /// <summary>
    /// SfdaProspectNumber of the BillMaster
    /// SfdaProspectNumber الخاص بـ BillMaster
    /// </summary>
    public string SfdaProspectNumber { get; private set; }

    /// <summary>
    /// SfdaProspectDate of the BillMaster
    /// SfdaProspectDate الخاص بـ BillMaster
    /// </summary>
    public DateTime? SfdaProspectDate { get; private set; }

    /// <summary>
    /// RmsBillDocumentType of the BillMaster
    /// RmsBillDocumentType الخاص بـ BillMaster
    /// </summary>
    public decimal? RmsBillDocumentType { get; private set; }

    /// <summary>
    /// RmsFreeFlag of the BillMaster
    /// RmsFreeFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? RmsFreeFlag { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmount of the BillMaster
    /// CreditCardMaxCommissionAmount الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmount { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountSecond of the BillMaster
    /// CreditCardMaxCommissionAmountSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountThird of the BillMaster
    /// CreditCardMaxCommissionAmountThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountThird { get; private set; }

    /// <summary>
    /// HoursDocumentNumberReference of the BillMaster
    /// HoursDocumentNumberReference الخاص بـ BillMaster
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// HoursDocumentTypeReference of the BillMaster
    /// HoursDocumentTypeReference الخاص بـ BillMaster
    /// </summary>
    public decimal? HoursDocumentTypeReference { get; private set; }

    /// <summary>
    /// HoursDocumentSerialReference of the BillMaster
    /// HoursDocumentSerialReference الخاص بـ BillMaster
    /// </summary>
    public decimal? HoursDocumentSerialReference { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BillMaster
    /// InsuranceAdditionalLimitMaster الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// InsuranceMedicineChronicFlag of the BillMaster
    /// InsuranceMedicineChronicFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceMedicineChronicFlag { get; private set; }

    /// <summary>
    /// DocMSq of the BillMaster
    /// DocMSq الخاص بـ BillMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// AdvancePaymentPercentContract of the BillMaster
    /// AdvancePaymentPercentContract الخاص بـ BillMaster
    /// </summary>
    public decimal? AdvancePaymentPercentContract { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumber of the BillMaster
    /// CreditCardCustomerNumber الخاص بـ BillMaster
    /// </summary>
    public string CreditCardCustomerNumber { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberSecond of the BillMaster
    /// CreditCardCustomerNumberSecond الخاص بـ BillMaster
    /// </summary>
    public string CreditCardCustomerNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberThird of the BillMaster
    /// CreditCardCustomerNumberThird الخاص بـ BillMaster
    /// </summary>
    public string CreditCardCustomerNumberThird { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReference of the BillMaster
    /// CreditCardDocumentNumberReference الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReference { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceSecond of the BillMaster
    /// CreditCardDocumentNumberReferenceSecond الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceThird of the BillMaster
    /// CreditCardDocumentNumberReferenceThird الخاص بـ BillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditCardDescription of the BillMaster
    /// CreditCardDescription الخاص بـ BillMaster
    /// </summary>
    public string CreditCardDescription { get; private set; }

    /// <summary>
    /// CreditCardDescriptionSecond of the BillMaster
    /// CreditCardDescriptionSecond الخاص بـ BillMaster
    /// </summary>
    public string CreditCardDescriptionSecond { get; private set; }

    /// <summary>
    /// CreditCardDescriptionThird of the BillMaster
    /// CreditCardDescriptionThird الخاص بـ BillMaster
    /// </summary>
    public string CreditCardDescriptionThird { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BillMaster
    /// CreatedDateClock الخاص بـ BillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// BillStatusType of the BillMaster
    /// BillStatusType الخاص بـ BillMaster
    /// </summary>
    public decimal? BillStatusType { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDocument of the BillMaster
    /// InsuranceAdditionalLimitDocument الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDocument { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDetail of the BillMaster
    /// InsuranceAdditionalLimitDetail الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDetail { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the BillMaster
    /// InsuranceLimitAmountLocalDocument الخاص بـ BillMaster
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BillMaster
    /// WebServiceTransferDataFlag الخاص بـ BillMaster
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceUuid of the BillMaster
    /// WebServiceUuid الخاص بـ BillMaster
    /// </summary>
    public string WebServiceUuid { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesType SalesType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CreditCardType CreditCardType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

