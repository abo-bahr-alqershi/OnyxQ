using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchReturnBillMasterRequest Entity
/// </summary>
public class BranchReturnBillMasterRequest : Entity<BranchReturnBillMasterRequestId>
{
    private BranchReturnBillMasterRequest() { }

    /// <summary>
    /// The unique identifier for the BranchReturnBillMasterRequest
    /// المعرف الفريد لـ BranchReturnBillMasterRequest
    /// </summary>
    public BranchReturnBillMasterRequestId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the BranchReturnBillMasterRequest
    /// ReturnBillDocumentType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the BranchReturnBillMasterRequest
    /// ReturnBillNumberAlt الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the BranchReturnBillMasterRequest
    /// ReturnBillSerial الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// PYear of the BranchReturnBillMasterRequest
    /// PYear الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnBillDate of the BranchReturnBillMasterRequest
    /// ReturnBillDate الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public DateTime? ReturnBillDate { get; private set; }

    /// <summary>
    /// ReturnBillCurrency of the BranchReturnBillMasterRequest
    /// ReturnBillCurrency الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ReturnBillCurrency { get; private set; }

    /// <summary>
    /// ReturnBillRate of the BranchReturnBillMasterRequest
    /// ReturnBillRate الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BranchReturnBillMasterRequest
    /// StockRateShort الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the BranchReturnBillMasterRequest
    /// CCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the BranchReturnBillMasterRequest
    /// CName الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountCode of the BranchReturnBillMasterRequest
    /// AccountCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the BranchReturnBillMasterRequest
    /// ChequeNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the BranchReturnBillMasterRequest
    /// ChequeAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the BranchReturnBillMasterRequest
    /// ChequeDueDate الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the BranchReturnBillMasterRequest
    /// ReturnBillDueDate الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// DiscAmt of the BranchReturnBillMasterRequest
    /// DiscAmt الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the BranchReturnBillMasterRequest
    /// DiscAmtMst الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the BranchReturnBillMasterRequest
    /// DiscAmtDtl الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// BillAmount of the BranchReturnBillMasterRequest
    /// BillAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// VatAmount of the BranchReturnBillMasterRequest
    /// VatAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the BranchReturnBillMasterRequest
    /// OtherAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchReturnBillMasterRequest
    /// WarehouseCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RegionCode of the BranchReturnBillMasterRequest
    /// RegionCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CashNumber of the BranchReturnBillMasterRequest
    /// CashNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchReturnBillMasterRequest
    /// CostCenterCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchReturnBillMasterRequest
    /// ProjectNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchReturnBillMasterRequest
    /// ActivityNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the BranchReturnBillMasterRequest
    /// CashAccountForeignCurrencyCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the BranchReturnBillMasterRequest
    /// CashNumberForeignCurrencyCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// RepCode of the BranchReturnBillMasterRequest
    /// RepCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// EmpNo of the BranchReturnBillMasterRequest
    /// EmpNo الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SalesReturnType of the BranchReturnBillMasterRequest
    /// SalesReturnType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchReturnBillMasterRequest
    /// CommissionPercent الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchReturnBillMasterRequest
    /// ReferenceNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchReturnBillMasterRequest
    /// AccountDescription الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchReturnBillMasterRequest
    /// AttachmentCount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ReturnReason of the BranchReturnBillMasterRequest
    /// ReturnReason الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the BranchReturnBillMasterRequest
    /// ProcessedFlagFull الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// PreviousYear of the BranchReturnBillMasterRequest
    /// PreviousYear الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// ClassifyNumber of the BranchReturnBillMasterRequest
    /// ClassifyNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ClassifyNumber { get; private set; }

    /// <summary>
    /// ClassifySerial of the BranchReturnBillMasterRequest
    /// ClassifySerial الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ClassifySerial { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the BranchReturnBillMasterRequest
    /// ReturnBillPaymentYear الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchReturnBillMasterRequest
    /// ExternalPostFlag الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the BranchReturnBillMasterRequest
    /// DiscAmtAftrVat الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// WarehouseCodeBill of the BranchReturnBillMasterRequest
    /// WarehouseCodeBill الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? WarehouseCodeBill { get; private set; }

    /// <summary>
    /// CostCenterCodeBill of the BranchReturnBillMasterRequest
    /// CostCenterCodeBill الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string CostCenterCodeBill { get; private set; }

    /// <summary>
    /// RepCodeBill of the BranchReturnBillMasterRequest
    /// RepCodeBill الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string RepCodeBill { get; private set; }

    /// <summary>
    /// ReturnType of the BranchReturnBillMasterRequest
    /// ReturnType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnType { get; private set; }

    /// <summary>
    /// AccountAmount of the BranchReturnBillMasterRequest
    /// AccountAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// PaymentAccount of the BranchReturnBillMasterRequest
    /// PaymentAccount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchReturnBillMasterRequest
    /// AccountDetailType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchReturnBillMasterRequest
    /// AccountDetailCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountCode of the BranchReturnBillMasterRequest
    /// AccountCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the BranchReturnBillMasterRequest
    /// InsuranceLoadPercent الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the BranchReturnBillMasterRequest
    /// InsuranceMedicalNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchReturnBillMasterRequest
    /// StandByFlag الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// NoteNumber of the BranchReturnBillMasterRequest
    /// NoteNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DriverNo of the BranchReturnBillMasterRequest
    /// DriverNo الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchReturnBillMasterRequest
    /// DocBrnNo الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ReservationType of the BranchReturnBillMasterRequest
    /// ReservationType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ReservationType { get; private set; }

    /// <summary>
    /// Field1 of the BranchReturnBillMasterRequest
    /// Field1 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchReturnBillMasterRequest
    /// Field2 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchReturnBillMasterRequest
    /// Field3 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchReturnBillMasterRequest
    /// Field4 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchReturnBillMasterRequest
    /// Field5 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchReturnBillMasterRequest
    /// Field6 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchReturnBillMasterRequest
    /// Field7 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchReturnBillMasterRequest
    /// Field8 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchReturnBillMasterRequest
    /// Field9 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchReturnBillMasterRequest
    /// Field10 الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// PromoterCode of the BranchReturnBillMasterRequest
    /// PromoterCode الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchReturnBillMasterRequest
    /// CompanyNumberShort الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchReturnBillMasterRequest
    /// BranchNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchReturnBillMasterRequest
    /// BranchYear الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchReturnBillMasterRequest
    /// BranchUser الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocNoPda of the BranchReturnBillMasterRequest
    /// DocNoPda الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// PdaName of the BranchReturnBillMasterRequest
    /// PdaName الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the BranchReturnBillMasterRequest
    /// InsuranceCompanyNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the BranchReturnBillMasterRequest
    /// InsuranceBenefitNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the BranchReturnBillMasterRequest
    /// InsurancePersonName الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the BranchReturnBillMasterRequest
    /// InsuranceCardNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the BranchReturnBillMasterRequest
    /// InsuranceCardNumberFamily الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the BranchReturnBillMasterRequest
    /// InsuranceRelationType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the BranchReturnBillMasterRequest
    /// InsuranceClassNumber الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the BranchReturnBillMasterRequest
    /// InsuranceCashAmount الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the BranchReturnBillMasterRequest
    /// InsuranceAdditionalLimitMaster الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// ApprovedFlag of the BranchReturnBillMasterRequest
    /// ApprovedFlag الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the BranchReturnBillMasterRequest
    /// ApprovalDate الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the BranchReturnBillMasterRequest
    /// ApprovalDescription الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalUserId of the BranchReturnBillMasterRequest
    /// ApprovalUserId الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BranchReturnBillMasterRequest
    /// CalcTypeNumberTax الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the BranchReturnBillMasterRequest
    /// CalcVatPriceType الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the BranchReturnBillMasterRequest
    /// DiscAmtMstVat الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the BranchReturnBillMasterRequest
    /// DocSerExtrnl الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// ExportFlag of the BranchReturnBillMasterRequest
    /// ExportFlag الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the BranchReturnBillMasterRequest
    /// VatAmountDiscountMaster الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// CreatedDateClock of the BranchReturnBillMasterRequest
    /// CreatedDateClock الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the BranchReturnBillMasterRequest
    /// InsuranceLimitAmountLocalDocument الخاص بـ BranchReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: BranchReturnBillMasterRequest to BranchReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetailRequest> BranchReturnBillDetailRequests { get; private set; }
    #endregion
}
}
