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
/// ReturnBillMaster Entity
/// </summary>
public class ReturnBillMaster : Entity<ReturnBillMasterId>
{
    private ReturnBillMaster() { }

    /// <summary>
    /// The unique identifier for the ReturnBillMaster
    /// المعرف الفريد لـ ReturnBillMaster
    /// </summary>
    public ReturnBillMasterId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the ReturnBillMaster
    /// ReturnBillDocumentType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the ReturnBillMaster
    /// ReturnBillNumberAlt الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the ReturnBillMaster
    /// ReturnBillSerial الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// PYear of the ReturnBillMaster
    /// PYear الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnBillDate of the ReturnBillMaster
    /// ReturnBillDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? ReturnBillDate { get; private set; }

    /// <summary>
    /// ReturnBillCurrency of the ReturnBillMaster
    /// ReturnBillCurrency الخاص بـ ReturnBillMaster
    /// </summary>
    public string ReturnBillCurrency { get; private set; }

    /// <summary>
    /// ReturnBillRate of the ReturnBillMaster
    /// ReturnBillRate الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the ReturnBillMaster
    /// StockRateShort الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the ReturnBillMaster
    /// CCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the ReturnBillMaster
    /// CName الخاص بـ ReturnBillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountCode of the ReturnBillMaster
    /// AccountCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the ReturnBillMaster
    /// ChequeNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the ReturnBillMaster
    /// ChequeAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the ReturnBillMaster
    /// ChequeDueDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the ReturnBillMaster
    /// ReturnBillDueDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// ReturnBillPostFlag of the ReturnBillMaster
    /// ReturnBillPostFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillPostFlag { get; private set; }

    /// <summary>
    /// DiscAmt of the ReturnBillMaster
    /// DiscAmt الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the ReturnBillMaster
    /// DiscAmtMst الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the ReturnBillMaster
    /// DiscAmtDtl الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the ReturnBillMaster
    /// DiscAmtMstVat الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the ReturnBillMaster
    /// VatAmountDiscountMaster الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// BillAmount of the ReturnBillMaster
    /// BillAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// VatAmount of the ReturnBillMaster
    /// VatAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the ReturnBillMaster
    /// OtherAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the ReturnBillMaster
    /// WarehouseCode الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RegionCode of the ReturnBillMaster
    /// RegionCode الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CashNumber of the ReturnBillMaster
    /// CashNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the ReturnBillMaster
    /// CostCenterCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ReturnBillMaster
    /// ProjectNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ReturnBillMaster
    /// ActivityNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the ReturnBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the ReturnBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// RepCode of the ReturnBillMaster
    /// RepCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// EmpNo of the ReturnBillMaster
    /// EmpNo الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SalesReturnType of the ReturnBillMaster
    /// SalesReturnType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// CommissionPercent of the ReturnBillMaster
    /// CommissionPercent الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ReturnBillMaster
    /// ReferenceNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the ReturnBillMaster
    /// AccountDescription الخاص بـ ReturnBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the ReturnBillMaster
    /// AttachmentCount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ReturnReason of the ReturnBillMaster
    /// ReturnReason الخاص بـ ReturnBillMaster
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the ReturnBillMaster
    /// ProcessedFlagFull الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// PreviousYear of the ReturnBillMaster
    /// PreviousYear الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// ClassifyNumber of the ReturnBillMaster
    /// ClassifyNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ClassifyNumber { get; private set; }

    /// <summary>
    /// ClassifySerial of the ReturnBillMaster
    /// ClassifySerial الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ClassifySerial { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the ReturnBillMaster
    /// ReturnBillPaymentYear الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReturnBillMaster
    /// ExternalPostFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the ReturnBillMaster
    /// DiscAmtAftrVat الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// AuditReference of the ReturnBillMaster
    /// AuditReference الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the ReturnBillMaster
    /// AuditReferenceDescription الخاص بـ ReturnBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the ReturnBillMaster
    /// AuditReferenceUserId الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the ReturnBillMaster
    /// AuditReferenceDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// WarehouseCodeBill of the ReturnBillMaster
    /// WarehouseCodeBill الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? WarehouseCodeBill { get; private set; }

    /// <summary>
    /// CostCenterCodeBill of the ReturnBillMaster
    /// CostCenterCodeBill الخاص بـ ReturnBillMaster
    /// </summary>
    public string CostCenterCodeBill { get; private set; }

    /// <summary>
    /// RepCodeBill of the ReturnBillMaster
    /// RepCodeBill الخاص بـ ReturnBillMaster
    /// </summary>
    public string RepCodeBill { get; private set; }

    /// <summary>
    /// ReturnType of the ReturnBillMaster
    /// ReturnType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnType { get; private set; }

    /// <summary>
    /// PaidReturnBillFlag of the ReturnBillMaster
    /// PaidReturnBillFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PaidReturnBillFlag { get; private set; }

    /// <summary>
    /// PaidUserId of the ReturnBillMaster
    /// PaidUserId الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PaidUserId { get; private set; }

    /// <summary>
    /// PaidDate of the ReturnBillMaster
    /// PaidDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// ReceiveInvoiceReturnBill of the ReturnBillMaster
    /// ReceiveInvoiceReturnBill الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceReturnBill { get; private set; }

    /// <summary>
    /// ReceiveInvoiceUserId of the ReturnBillMaster
    /// ReceiveInvoiceUserId الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceUserId { get; private set; }

    /// <summary>
    /// ReceiveInvoiceDate of the ReturnBillMaster
    /// ReceiveInvoiceDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }

    /// <summary>
    /// StandByFlag of the ReturnBillMaster
    /// StandByFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// NoteNumber of the ReturnBillMaster
    /// NoteNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DriverNo of the ReturnBillMaster
    /// DriverNo الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DocBrnNo of the ReturnBillMaster
    /// DocBrnNo الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ReservationType of the ReturnBillMaster
    /// ReservationType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReservationType { get; private set; }

    /// <summary>
    /// PromoterCode of the ReturnBillMaster
    /// PromoterCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// DocNoPda of the ReturnBillMaster
    /// DocNoPda الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// PdaName of the ReturnBillMaster
    /// PdaName الخاص بـ ReturnBillMaster
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the ReturnBillMaster
    /// InsuranceCompanyNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the ReturnBillMaster
    /// InsuranceBenefitNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the ReturnBillMaster
    /// InsurancePersonName الخاص بـ ReturnBillMaster
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the ReturnBillMaster
    /// InsuranceCardNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the ReturnBillMaster
    /// InsuranceCardNumberFamily الخاص بـ ReturnBillMaster
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the ReturnBillMaster
    /// InsuranceRelationType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the ReturnBillMaster
    /// InsuranceClassNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the ReturnBillMaster
    /// InsuranceCashAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the ReturnBillMaster
    /// CommissionAmountDetail الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// CustomerGCC of the ReturnBillMaster
    /// CustomerGCC الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// ExportFlag of the ReturnBillMaster
    /// ExportFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// VatAmountOther of the ReturnBillMaster
    /// VatAmountOther الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the ReturnBillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the ReturnBillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the ReturnBillMaster
    /// OtherAmountDiscount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// WithoutVatFlag of the ReturnBillMaster
    /// WithoutVatFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? WithoutVatFlag { get; private set; }

    /// <summary>
    /// ReturnVatPeriodType of the ReturnBillMaster
    /// ReturnVatPeriodType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnVatPeriodType { get; private set; }

    /// <summary>
    /// CTel of the ReturnBillMaster
    /// CTel الخاص بـ ReturnBillMaster
    /// </summary>
    public string CTel { get; private set; }

    /// <summary>
    /// CCodeCsh of the ReturnBillMaster
    /// CCodeCsh الخاص بـ ReturnBillMaster
    /// </summary>
    public string CCodeCsh { get; private set; }

    /// <summary>
    /// PointReplaceAmount of the ReturnBillMaster
    /// PointReplaceAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PointReplaceAmount { get; private set; }

    /// <summary>
    /// PointTypeNumber of the ReturnBillMaster
    /// PointTypeNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointCount of the ReturnBillMaster
    /// PointCount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointReplaceCount of the ReturnBillMaster
    /// PointReplaceCount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PointReplaceCount { get; private set; }

    /// <summary>
    /// CreditCard of the ReturnBillMaster
    /// CreditCard الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCard { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the ReturnBillMaster
    /// CreditCardNumberFull الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// CreditCardAmount of the ReturnBillMaster
    /// CreditCardAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmount { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercent of the ReturnBillMaster
    /// CreditCardCommissionPercent الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercent { get; private set; }

    /// <summary>
    /// CreditCardNumberSecond of the ReturnBillMaster
    /// CreditCardNumberSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardAmountSecond of the ReturnBillMaster
    /// CreditCardAmountSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentSecond of the ReturnBillMaster
    /// CreditCardCommissionPercentSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentSecond { get; private set; }

    /// <summary>
    /// CreditCardNumberThird of the ReturnBillMaster
    /// CreditCardNumberThird الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberThird { get; private set; }

    /// <summary>
    /// CreditCardAmountThird of the ReturnBillMaster
    /// CreditCardAmountThird الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmountThird { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentThird of the ReturnBillMaster
    /// CreditCardCommissionPercentThird الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentThird { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the ReturnBillMaster
    /// CalcTypeNumberTax الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// AccountAmount of the ReturnBillMaster
    /// AccountAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// Field1 of the ReturnBillMaster
    /// Field1 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the ReturnBillMaster
    /// Field2 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the ReturnBillMaster
    /// Field3 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the ReturnBillMaster
    /// Field4 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the ReturnBillMaster
    /// Field5 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the ReturnBillMaster
    /// Field6 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the ReturnBillMaster
    /// Field7 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the ReturnBillMaster
    /// Field8 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the ReturnBillMaster
    /// Field9 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the ReturnBillMaster
    /// Field10 الخاص بـ ReturnBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// PostUserId of the ReturnBillMaster
    /// PostUserId الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the ReturnBillMaster
    /// PostDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the ReturnBillMaster
    /// UnpostUserId الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the ReturnBillMaster
    /// UnpostDate الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReturnBillMaster
    /// CompanyNumberShort الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReturnBillMaster
    /// BranchNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReturnBillMaster
    /// BranchYear الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReturnBillMaster
    /// BranchUser الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PatientNumber of the ReturnBillMaster
    /// PatientNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// DctrNo of the ReturnBillMaster
    /// DctrNo الخاص بـ ReturnBillMaster
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// PatientType of the ReturnBillMaster
    /// PatientType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PatientType { get; private set; }

    /// <summary>
    /// DocNoAdmson of the ReturnBillMaster
    /// DocNoAdmson الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DocNoAdmson { get; private set; }

    /// <summary>
    /// DocSrlAdmson of the ReturnBillMaster
    /// DocSrlAdmson الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DocSrlAdmson { get; private set; }

    /// <summary>
    /// AccountCode of the ReturnBillMaster
    /// AccountCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ReturnBillMaster
    /// AccountDetailCode الخاص بـ ReturnBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the ReturnBillMaster
    /// AccountDetailType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// PaymentAccount of the ReturnBillMaster
    /// PaymentAccount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the ReturnBillMaster
    /// InsuranceLoadPercent الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the ReturnBillMaster
    /// DocSerExtrnl الخاص بـ ReturnBillMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CancelFlag of the ReturnBillMaster
    /// CancelFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CancelFlag { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the ReturnBillMaster
    /// CalcVatPriceType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the ReturnBillMaster
    /// ColumnNumberShort الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// RmsReturnBillDocumentType of the ReturnBillMaster
    /// RmsReturnBillDocumentType الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? RmsReturnBillDocumentType { get; private set; }

    /// <summary>
    /// RmsFreeFlag of the ReturnBillMaster
    /// RmsFreeFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? RmsFreeFlag { get; private set; }

    /// <summary>
    /// HoursDocumentNumberReference of the ReturnBillMaster
    /// HoursDocumentNumberReference الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// HoursDocumentTypeReference of the ReturnBillMaster
    /// HoursDocumentTypeReference الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentTypeReference { get; private set; }

    /// <summary>
    /// HoursDocumentSerialReference of the ReturnBillMaster
    /// HoursDocumentSerialReference الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentSerialReference { get; private set; }

    /// <summary>
    /// ReturnBillTypeAlt of the ReturnBillMaster
    /// ReturnBillTypeAlt الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? ReturnBillTypeAlt { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the ReturnBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the ReturnBillMaster
    /// InsuranceAdditionalLimitMaster الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// CreatedDateClock of the ReturnBillMaster
    /// CreatedDateClock الخاص بـ ReturnBillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDocument of the ReturnBillMaster
    /// InsuranceAdditionalLimitDocument الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDocument { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDetail of the ReturnBillMaster
    /// InsuranceAdditionalLimitDetail الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDetail { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the ReturnBillMaster
    /// InsuranceLimitAmountLocalDocument الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    /// <summary>
    /// CreditCardDescription of the ReturnBillMaster
    /// CreditCardDescription الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardDescription { get; private set; }

    /// <summary>
    /// CreditCardDescriptionSecond of the ReturnBillMaster
    /// CreditCardDescriptionSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardDescriptionSecond { get; private set; }

    /// <summary>
    /// CreditCardDescriptionThird of the ReturnBillMaster
    /// CreditCardDescriptionThird الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardDescriptionThird { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberThird of the ReturnBillMaster
    /// CreditCardCustomerNumberThird الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumberThird { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberSecond of the ReturnBillMaster
    /// CreditCardCustomerNumberSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumber of the ReturnBillMaster
    /// CreditCardCustomerNumber الخاص بـ ReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumber { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceSecond of the ReturnBillMaster
    /// CreditCardDocumentNumberReferenceSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReference of the ReturnBillMaster
    /// CreditCardDocumentNumberReference الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReference { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceThird of the ReturnBillMaster
    /// CreditCardDocumentNumberReferenceThird الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmount of the ReturnBillMaster
    /// CreditCardMaxCommissionAmount الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmount { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountSecond of the ReturnBillMaster
    /// CreditCardMaxCommissionAmountSecond الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountThird of the ReturnBillMaster
    /// CreditCardMaxCommissionAmountThird الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountThird { get; private set; }

    /// <summary>
    /// DocMSq of the ReturnBillMaster
    /// DocMSq الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the ReturnBillMaster
    /// WebServiceTransferDataFlag الخاص بـ ReturnBillMaster
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceUuid of the ReturnBillMaster
    /// WebServiceUuid الخاص بـ ReturnBillMaster
    /// </summary>
    public string WebServiceUuid { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ReturnBillMaster to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ReturnSalesType
    /// </summary>
    public ReturnSalesType ReturnSalesType { get; private set; }
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
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
