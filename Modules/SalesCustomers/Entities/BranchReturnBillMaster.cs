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
/// BranchReturnBillMaster Entity
/// </summary>
public class BranchReturnBillMaster : Entity<BranchReturnBillMasterId>
{
    private BranchReturnBillMaster() { }

    /// <summary>
    /// The unique identifier for the BranchReturnBillMaster
    /// المعرف الفريد لـ BranchReturnBillMaster
    /// </summary>
    public BranchReturnBillMasterId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the BranchReturnBillMaster
    /// ReturnBillDocumentType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the BranchReturnBillMaster
    /// ReturnBillNumberAlt الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the BranchReturnBillMaster
    /// ReturnBillSerial الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// PYear of the BranchReturnBillMaster
    /// PYear الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnBillDate of the BranchReturnBillMaster
    /// ReturnBillDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? ReturnBillDate { get; private set; }

    /// <summary>
    /// ReturnBillCurrency of the BranchReturnBillMaster
    /// ReturnBillCurrency الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string ReturnBillCurrency { get; private set; }

    /// <summary>
    /// ReturnBillRate of the BranchReturnBillMaster
    /// ReturnBillRate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BranchReturnBillMaster
    /// StockRateShort الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the BranchReturnBillMaster
    /// CCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the BranchReturnBillMaster
    /// CName الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountCode of the BranchReturnBillMaster
    /// AccountCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the BranchReturnBillMaster
    /// ChequeNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the BranchReturnBillMaster
    /// ChequeAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the BranchReturnBillMaster
    /// ChequeDueDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the BranchReturnBillMaster
    /// ReturnBillDueDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// ReturnBillPostFlag of the BranchReturnBillMaster
    /// ReturnBillPostFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillPostFlag { get; private set; }

    /// <summary>
    /// DiscAmt of the BranchReturnBillMaster
    /// DiscAmt الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the BranchReturnBillMaster
    /// DiscAmtMst الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the BranchReturnBillMaster
    /// DiscAmtDtl الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the BranchReturnBillMaster
    /// DiscAmtMstVat الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the BranchReturnBillMaster
    /// VatAmountDiscountMaster الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// BillAmount of the BranchReturnBillMaster
    /// BillAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// VatAmount of the BranchReturnBillMaster
    /// VatAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchReturnBillMaster
    /// OtherAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchReturnBillMaster
    /// WarehouseCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RegionCode of the BranchReturnBillMaster
    /// RegionCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CashNumber of the BranchReturnBillMaster
    /// CashNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchReturnBillMaster
    /// CostCenterCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchReturnBillMaster
    /// ProjectNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchReturnBillMaster
    /// ActivityNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the BranchReturnBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the BranchReturnBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// RepCode of the BranchReturnBillMaster
    /// RepCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// EmpNo of the BranchReturnBillMaster
    /// EmpNo الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SalesReturnType of the BranchReturnBillMaster
    /// SalesReturnType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchReturnBillMaster
    /// CommissionPercent الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchReturnBillMaster
    /// ReferenceNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchReturnBillMaster
    /// AccountDescription الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchReturnBillMaster
    /// AttachmentCount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ReturnReason of the BranchReturnBillMaster
    /// ReturnReason الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BranchReturnBillMaster
    /// ProcessedFlagFull الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// PreviousYear of the BranchReturnBillMaster
    /// PreviousYear الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// ClassifyNumber of the BranchReturnBillMaster
    /// ClassifyNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ClassifyNumber { get; private set; }

    /// <summary>
    /// ClassifySerial of the BranchReturnBillMaster
    /// ClassifySerial الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ClassifySerial { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the BranchReturnBillMaster
    /// ReturnBillPaymentYear الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchReturnBillMaster
    /// ExternalPostFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the BranchReturnBillMaster
    /// DocSerExtrnl الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// AuditReference of the BranchReturnBillMaster
    /// AuditReference الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// CancelFlag of the BranchReturnBillMaster
    /// CancelFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CancelFlag { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the BranchReturnBillMaster
    /// DiscAmtAftrVat الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchReturnBillMaster
    /// AuditReferenceDescription الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchReturnBillMaster
    /// AuditReferenceUserId الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchReturnBillMaster
    /// AuditReferenceDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// WarehouseCodeBill of the BranchReturnBillMaster
    /// WarehouseCodeBill الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? WarehouseCodeBill { get; private set; }

    /// <summary>
    /// CostCenterCodeBill of the BranchReturnBillMaster
    /// CostCenterCodeBill الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CostCenterCodeBill { get; private set; }

    /// <summary>
    /// RepCodeBill of the BranchReturnBillMaster
    /// RepCodeBill الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string RepCodeBill { get; private set; }

    /// <summary>
    /// ReturnType of the BranchReturnBillMaster
    /// ReturnType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnType { get; private set; }

    /// <summary>
    /// ReturnBillTypeAlt of the BranchReturnBillMaster
    /// ReturnBillTypeAlt الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReturnBillTypeAlt { get; private set; }

    /// <summary>
    /// PaidReturnBillFlag of the BranchReturnBillMaster
    /// PaidReturnBillFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PaidReturnBillFlag { get; private set; }

    /// <summary>
    /// PaidUserId of the BranchReturnBillMaster
    /// PaidUserId الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PaidUserId { get; private set; }

    /// <summary>
    /// PaidDate of the BranchReturnBillMaster
    /// PaidDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// ReceiveInvoiceReturnBill of the BranchReturnBillMaster
    /// ReceiveInvoiceReturnBill الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceReturnBill { get; private set; }

    /// <summary>
    /// ReceiveInvoiceUserId of the BranchReturnBillMaster
    /// ReceiveInvoiceUserId الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReceiveInvoiceUserId { get; private set; }

    /// <summary>
    /// ReceiveInvoiceDate of the BranchReturnBillMaster
    /// ReceiveInvoiceDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }

    /// <summary>
    /// NoteNumber of the BranchReturnBillMaster
    /// NoteNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchReturnBillMaster
    /// StandByFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// DriverNo of the BranchReturnBillMaster
    /// DriverNo الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchReturnBillMaster
    /// DocBrnNo الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PdaName of the BranchReturnBillMaster
    /// PdaName الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// PointReplaceAmount of the BranchReturnBillMaster
    /// PointReplaceAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PointReplaceAmount { get; private set; }

    /// <summary>
    /// PointTypeNumber of the BranchReturnBillMaster
    /// PointTypeNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointCount of the BranchReturnBillMaster
    /// PointCount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointReplaceCount of the BranchReturnBillMaster
    /// PointReplaceCount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PointReplaceCount { get; private set; }

    /// <summary>
    /// ReservationType of the BranchReturnBillMaster
    /// ReservationType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ReservationType { get; private set; }

    /// <summary>
    /// Field1 of the BranchReturnBillMaster
    /// Field1 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchReturnBillMaster
    /// Field2 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchReturnBillMaster
    /// Field3 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchReturnBillMaster
    /// Field4 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchReturnBillMaster
    /// Field5 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchReturnBillMaster
    /// Field6 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchReturnBillMaster
    /// Field7 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchReturnBillMaster
    /// Field8 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchReturnBillMaster
    /// Field9 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchReturnBillMaster
    /// Field10 الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// HoursDocumentNumberReference of the BranchReturnBillMaster
    /// HoursDocumentNumberReference الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// HoursDocumentTypeReference of the BranchReturnBillMaster
    /// HoursDocumentTypeReference الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentTypeReference { get; private set; }

    /// <summary>
    /// HoursDocumentSerialReference of the BranchReturnBillMaster
    /// HoursDocumentSerialReference الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? HoursDocumentSerialReference { get; private set; }

    /// <summary>
    /// PatientNumber of the BranchReturnBillMaster
    /// PatientNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// DctrNo of the BranchReturnBillMaster
    /// DctrNo الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// PatientType of the BranchReturnBillMaster
    /// PatientType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PatientType { get; private set; }

    /// <summary>
    /// ProcedureType of the BranchReturnBillMaster
    /// ProcedureType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ProcedureType { get; private set; }

    /// <summary>
    /// PercentAmount of the BranchReturnBillMaster
    /// PercentAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PercentAmount { get; private set; }

    /// <summary>
    /// DocNoAdmson of the BranchReturnBillMaster
    /// DocNoAdmson الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DocNoAdmson { get; private set; }

    /// <summary>
    /// DocSrlAdmson of the BranchReturnBillMaster
    /// DocSrlAdmson الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DocSrlAdmson { get; private set; }

    /// <summary>
    /// AccountCode of the BranchReturnBillMaster
    /// AccountCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchReturnBillMaster
    /// AccountDetailCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchReturnBillMaster
    /// AccountDetailType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// PaymentAccount of the BranchReturnBillMaster
    /// PaymentAccount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// PromoterCode of the BranchReturnBillMaster
    /// PromoterCode الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// DocNoPda of the BranchReturnBillMaster
    /// DocNoPda الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the BranchReturnBillMaster
    /// InsuranceCompanyNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the BranchReturnBillMaster
    /// InsuranceBenefitNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the BranchReturnBillMaster
    /// InsurancePersonName الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the BranchReturnBillMaster
    /// InsuranceCardNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the BranchReturnBillMaster
    /// InsuranceCardNumberFamily الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the BranchReturnBillMaster
    /// InsuranceRelationType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the BranchReturnBillMaster
    /// InsuranceClassNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the BranchReturnBillMaster
    /// InsuranceCashAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BranchReturnBillMaster
    /// InsuranceAdditionalLimitMaster الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDocument of the BranchReturnBillMaster
    /// InsuranceAdditionalLimitDocument الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDocument { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchReturnBillMaster
    /// InsuranceLoadPercent الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the BranchReturnBillMaster
    /// InsuranceLimitAmountLocalDocument الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    /// <summary>
    /// CommissionAmountDetail of the BranchReturnBillMaster
    /// CommissionAmountDetail الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CommissionAmountDetail { get; private set; }

    /// <summary>
    /// CustomerGCC of the BranchReturnBillMaster
    /// CustomerGCC الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CustomerGCC { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchReturnBillMaster
    /// VatAmountOther الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the BranchReturnBillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the BranchReturnBillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the BranchReturnBillMaster
    /// OtherAmountDiscount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// WithoutVatFlag of the BranchReturnBillMaster
    /// WithoutVatFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? WithoutVatFlag { get; private set; }

    /// <summary>
    /// ExportFlag of the BranchReturnBillMaster
    /// ExportFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// AccountAmount of the BranchReturnBillMaster
    /// AccountAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BranchReturnBillMaster
    /// CalcTypeNumberTax الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CreditCard of the BranchReturnBillMaster
    /// CreditCard الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCard { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the BranchReturnBillMaster
    /// CreditCardNumberFull الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// CreditCardAmount of the BranchReturnBillMaster
    /// CreditCardAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmount { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercent of the BranchReturnBillMaster
    /// CreditCardCommissionPercent الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercent { get; private set; }

    /// <summary>
    /// CreditCardNumberSecond of the BranchReturnBillMaster
    /// CreditCardNumberSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardAmountSecond of the BranchReturnBillMaster
    /// CreditCardAmountSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentSecond of the BranchReturnBillMaster
    /// CreditCardCommissionPercentSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentSecond { get; private set; }

    /// <summary>
    /// CreditCardNumberThird of the BranchReturnBillMaster
    /// CreditCardNumberThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardNumberThird { get; private set; }

    /// <summary>
    /// CreditCardAmountThird of the BranchReturnBillMaster
    /// CreditCardAmountThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardAmountThird { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercentThird of the BranchReturnBillMaster
    /// CreditCardCommissionPercentThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardCommissionPercentThird { get; private set; }

    /// <summary>
    /// CreditCardDescription of the BranchReturnBillMaster
    /// CreditCardDescription الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardDescription { get; private set; }

    /// <summary>
    /// CreditCardDescriptionSecond of the BranchReturnBillMaster
    /// CreditCardDescriptionSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardDescriptionSecond { get; private set; }

    /// <summary>
    /// CreditCardDescriptionThird of the BranchReturnBillMaster
    /// CreditCardDescriptionThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardDescriptionThird { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberThird of the BranchReturnBillMaster
    /// CreditCardCustomerNumberThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumberThird { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumberSecond of the BranchReturnBillMaster
    /// CreditCardCustomerNumberSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumberSecond { get; private set; }

    /// <summary>
    /// CreditCardCustomerNumber of the BranchReturnBillMaster
    /// CreditCardCustomerNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string CreditCardCustomerNumber { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceSecond of the BranchReturnBillMaster
    /// CreditCardDocumentNumberReferenceSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceSecond { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReference of the BranchReturnBillMaster
    /// CreditCardDocumentNumberReference الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReference { get; private set; }

    /// <summary>
    /// CreditCardDocumentNumberReferenceThird of the BranchReturnBillMaster
    /// CreditCardDocumentNumberReferenceThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardDocumentNumberReferenceThird { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmount of the BranchReturnBillMaster
    /// CreditCardMaxCommissionAmount الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmount { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountSecond of the BranchReturnBillMaster
    /// CreditCardMaxCommissionAmountSecond الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountSecond { get; private set; }

    /// <summary>
    /// CreditCardMaxCommissionAmountThird of the BranchReturnBillMaster
    /// CreditCardMaxCommissionAmountThird الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CreditCardMaxCommissionAmountThird { get; private set; }

    /// <summary>
    /// DocMSq of the BranchReturnBillMaster
    /// DocMSq الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// RmsReturnBillDocumentType of the BranchReturnBillMaster
    /// RmsReturnBillDocumentType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? RmsReturnBillDocumentType { get; private set; }

    /// <summary>
    /// RmsFreeFlag of the BranchReturnBillMaster
    /// RmsFreeFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? RmsFreeFlag { get; private set; }

    /// <summary>
    /// WebServiceTransferDataFlag of the BranchReturnBillMaster
    /// WebServiceTransferDataFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? WebServiceTransferDataFlag { get; private set; }

    /// <summary>
    /// WebServiceUuid of the BranchReturnBillMaster
    /// WebServiceUuid الخاص بـ BranchReturnBillMaster
    /// </summary>
    public string WebServiceUuid { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BranchReturnBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BranchReturnBillMaster
    /// CalcVatPriceType الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BranchReturnBillMaster
    /// ColumnNumberShort الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BranchReturnBillMaster
    /// CreatedDateClock الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// PostUserId of the BranchReturnBillMaster
    /// PostUserId الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchReturnBillMaster
    /// PostDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchReturnBillMaster
    /// UnpostUserId الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchReturnBillMaster
    /// UnpostDate الخاص بـ BranchReturnBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchReturnBillMaster
    /// CompanyNumberShort الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchReturnBillMaster
    /// BranchNumber الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchReturnBillMaster
    /// BranchYear الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchReturnBillMaster
    /// BranchUser الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDetail of the BranchReturnBillMaster
    /// InsuranceAdditionalLimitDetail الخاص بـ BranchReturnBillMaster
    /// </summary>
    public decimal? InsuranceAdditionalLimitDetail { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: BranchReturnBillMaster to BranchReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetail> BranchReturnBillDetails { get; private set; }
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
