using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// ReturnBillMasterRequest Entity
/// </summary>
public class ReturnBillMasterRequest : Entity<ReturnBillMasterRequestId>
{
    private ReturnBillMasterRequest() { }

    /// <summary>
    /// The unique identifier for the ReturnBillMasterRequest
    /// المعرف الفريد لـ ReturnBillMasterRequest
    /// </summary>
    public ReturnBillMasterRequestId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the ReturnBillMasterRequest
    /// ReturnBillDocumentType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the ReturnBillMasterRequest
    /// ReturnBillNumberAlt الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the ReturnBillMasterRequest
    /// ReturnBillSerial الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// PYear of the ReturnBillMasterRequest
    /// PYear الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnBillDate of the ReturnBillMasterRequest
    /// ReturnBillDate الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public DateTime? ReturnBillDate { get; private set; }

    /// <summary>
    /// ReturnBillCurrency of the ReturnBillMasterRequest
    /// ReturnBillCurrency الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ReturnBillCurrency { get; private set; }

    /// <summary>
    /// ReturnBillRate of the ReturnBillMasterRequest
    /// ReturnBillRate الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the ReturnBillMasterRequest
    /// StockRateShort الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the ReturnBillMasterRequest
    /// CCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the ReturnBillMasterRequest
    /// CName الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountCode of the ReturnBillMasterRequest
    /// AccountCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the ReturnBillMasterRequest
    /// ChequeNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the ReturnBillMasterRequest
    /// ChequeAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the ReturnBillMasterRequest
    /// ChequeDueDate الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the ReturnBillMasterRequest
    /// ReturnBillDueDate الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// DiscAmt of the ReturnBillMasterRequest
    /// DiscAmt الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the ReturnBillMasterRequest
    /// DiscAmtMst الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the ReturnBillMasterRequest
    /// DiscAmtDtl الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// BillAmount of the ReturnBillMasterRequest
    /// BillAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// VatAmount of the ReturnBillMasterRequest
    /// VatAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the ReturnBillMasterRequest
    /// OtherAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the ReturnBillMasterRequest
    /// WarehouseCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RegionCode of the ReturnBillMasterRequest
    /// RegionCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CashNumber of the ReturnBillMasterRequest
    /// CashNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the ReturnBillMasterRequest
    /// CostCenterCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ReturnBillMasterRequest
    /// ProjectNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ReturnBillMasterRequest
    /// ActivityNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the ReturnBillMasterRequest
    /// CashAccountForeignCurrencyCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the ReturnBillMasterRequest
    /// CashNumberForeignCurrencyCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// RepCode of the ReturnBillMasterRequest
    /// RepCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// EmpNo of the ReturnBillMasterRequest
    /// EmpNo الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SalesReturnType of the ReturnBillMasterRequest
    /// SalesReturnType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// CommissionPercent of the ReturnBillMasterRequest
    /// CommissionPercent الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ReturnBillMasterRequest
    /// ReferenceNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the ReturnBillMasterRequest
    /// AccountDescription الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the ReturnBillMasterRequest
    /// AttachmentCount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// ReturnReason of the ReturnBillMasterRequest
    /// ReturnReason الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the ReturnBillMasterRequest
    /// ProcessedFlagFull الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// PreviousYear of the ReturnBillMasterRequest
    /// PreviousYear الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// ClassifyNumber of the ReturnBillMasterRequest
    /// ClassifyNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ClassifyNumber { get; private set; }

    /// <summary>
    /// ClassifySerial of the ReturnBillMasterRequest
    /// ClassifySerial الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ClassifySerial { get; private set; }

    /// <summary>
    /// ReturnBillPaymentYear of the ReturnBillMasterRequest
    /// ReturnBillPaymentYear الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnBillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReturnBillMasterRequest
    /// ExternalPostFlag الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the ReturnBillMasterRequest
    /// DiscAmtAftrVat الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// WarehouseCodeBill of the ReturnBillMasterRequest
    /// WarehouseCodeBill الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? WarehouseCodeBill { get; private set; }

    /// <summary>
    /// CostCenterCodeBill of the ReturnBillMasterRequest
    /// CostCenterCodeBill الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string CostCenterCodeBill { get; private set; }

    /// <summary>
    /// RepCodeBill of the ReturnBillMasterRequest
    /// RepCodeBill الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string RepCodeBill { get; private set; }

    /// <summary>
    /// ReturnType of the ReturnBillMasterRequest
    /// ReturnType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReturnType { get; private set; }

    /// <summary>
    /// StandByFlag of the ReturnBillMasterRequest
    /// StandByFlag الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// NoteNumber of the ReturnBillMasterRequest
    /// NoteNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// DriverNo of the ReturnBillMasterRequest
    /// DriverNo الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DocBrnNo of the ReturnBillMasterRequest
    /// DocBrnNo الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ReservationType of the ReturnBillMasterRequest
    /// ReservationType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ReservationType { get; private set; }

    /// <summary>
    /// PromoterCode of the ReturnBillMasterRequest
    /// PromoterCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// DocNoPda of the ReturnBillMasterRequest
    /// DocNoPda الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DocNoPda { get; private set; }

    /// <summary>
    /// PdaName of the ReturnBillMasterRequest
    /// PdaName الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// ExportFlag of the ReturnBillMasterRequest
    /// ExportFlag الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the ReturnBillMasterRequest
    /// InsuranceCompanyNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the ReturnBillMasterRequest
    /// InsuranceBenefitNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the ReturnBillMasterRequest
    /// InsurancePersonName الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the ReturnBillMasterRequest
    /// InsuranceCardNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the ReturnBillMasterRequest
    /// InsuranceCardNumberFamily الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the ReturnBillMasterRequest
    /// InsuranceRelationType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the ReturnBillMasterRequest
    /// InsuranceClassNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the ReturnBillMasterRequest
    /// InsuranceCashAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// ApprovedFlag of the ReturnBillMasterRequest
    /// ApprovedFlag الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the ReturnBillMasterRequest
    /// ApprovalDate الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the ReturnBillMasterRequest
    /// ApprovalDescription الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalUserId of the ReturnBillMasterRequest
    /// ApprovalUserId الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the ReturnBillMasterRequest
    /// CalcTypeNumberTax الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// Field1 of the ReturnBillMasterRequest
    /// Field1 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the ReturnBillMasterRequest
    /// Field2 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the ReturnBillMasterRequest
    /// Field3 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the ReturnBillMasterRequest
    /// Field4 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the ReturnBillMasterRequest
    /// Field5 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the ReturnBillMasterRequest
    /// Field6 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the ReturnBillMasterRequest
    /// Field7 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the ReturnBillMasterRequest
    /// Field8 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the ReturnBillMasterRequest
    /// Field9 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the ReturnBillMasterRequest
    /// Field10 الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReturnBillMasterRequest
    /// CompanyNumberShort الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReturnBillMasterRequest
    /// BranchNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReturnBillMasterRequest
    /// BranchYear الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReturnBillMasterRequest
    /// BranchUser الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the ReturnBillMasterRequest
    /// DocSerExtrnl الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the ReturnBillMasterRequest
    /// DiscAmtMstVat الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the ReturnBillMasterRequest
    /// VatAmountDiscountMaster الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the ReturnBillMasterRequest
    /// CalcVatPriceType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// AccountAmount of the ReturnBillMasterRequest
    /// AccountAmount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// PaymentAccount of the ReturnBillMasterRequest
    /// PaymentAccount الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// AccountDetailType of the ReturnBillMasterRequest
    /// AccountDetailType الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ReturnBillMasterRequest
    /// AccountDetailCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountCode of the ReturnBillMasterRequest
    /// AccountCode الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the ReturnBillMasterRequest
    /// InsuranceLoadPercent الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the ReturnBillMasterRequest
    /// InsuranceMedicalNumber الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the ReturnBillMasterRequest
    /// CalcTaxFreeQuantityFlag الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the ReturnBillMasterRequest
    /// InsuranceAdditionalLimitMaster الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// CreatedDateClock of the ReturnBillMasterRequest
    /// CreatedDateClock الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the ReturnBillMasterRequest
    /// InsuranceLimitAmountLocalDocument الخاص بـ ReturnBillMasterRequest
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ReturnBillMasterRequest to ReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetailRequest> ReturnBillDetailRequests { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
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
