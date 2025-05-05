using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;

using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;
namespace ERP_Pro.Domain.ERP.JudicialLegal.Entities
{
/// <summary>
/// LetterOfCreditMaster Entity
/// </summary>
public class LetterOfCreditMaster : AggregateRoot<LetterOfCreditMasterId>
{

    private LetterOfCreditMaster() { }

    public LetterOfCreditMaster(LetterOfCreditMasterId id, string letterCreditNumber)
    {
        Id = id;
        LetterCreditNumber = letterCreditNumber;
    }

    /// <summary>
    /// The unique identifier for the LetterOfCreditMaster
    /// المعرف الفريد لـ LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMasterId Id { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the LetterOfCreditMaster
    /// LetterCreditNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// LetterCreditSerial of the LetterOfCreditMaster
    /// LetterCreditSerial الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditSerial { get; private set; }

    /// <summary>
    /// BankName of the LetterOfCreditMaster
    /// BankName الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// LetterCreditCostTypeNumber of the LetterOfCreditMaster
    /// LetterCreditCostTypeNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditCostTypeNumber { get; private set; }

    /// <summary>
    /// LetterCreditAmount of the LetterOfCreditMaster
    /// LetterCreditAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditAmount { get; private set; }

    /// <summary>
    /// LetterCreditRate of the LetterOfCreditMaster
    /// LetterCreditRate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditRate { get; private set; }

    /// <summary>
    /// LetterCreditOpenDate of the LetterOfCreditMaster
    /// LetterCreditOpenDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? LetterCreditOpenDate { get; private set; }

    /// <summary>
    /// LetterCreditExpenseDate of the LetterOfCreditMaster
    /// LetterCreditExpenseDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? LetterCreditExpenseDate { get; private set; }

    /// <summary>
    /// LetterCreditType of the LetterOfCreditMaster
    /// LetterCreditType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditType { get; private set; }

    /// <summary>
    /// LetterCreditDescription of the LetterOfCreditMaster
    /// LetterCreditDescription الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditDescription { get; private set; }

    /// <summary>
    /// LetterCreditOpenType of the LetterOfCreditMaster
    /// LetterCreditOpenType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditOpenType { get; private set; }

    /// <summary>
    /// LetterCreditOpenAmount of the LetterOfCreditMaster
    /// LetterCreditOpenAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditOpenAmount { get; private set; }

    /// <summary>
    /// PurchaseAmount of the LetterOfCreditMaster
    /// PurchaseAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PurchaseAmount { get; private set; }

    /// <summary>
    /// PurchaseNumber of the LetterOfCreditMaster
    /// PurchaseNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string PurchaseNumber { get; private set; }

    /// <summary>
    /// BillNumber of the LetterOfCreditMaster
    /// BillNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the LetterOfCreditMaster
    /// BillSerial الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the LetterOfCreditMaster
    /// ReferenceNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CountryOrigin of the LetterOfCreditMaster
    /// CountryOrigin الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CountryOrigin { get; private set; }

    /// <summary>
    /// CountryExport of the LetterOfCreditMaster
    /// CountryExport الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CountryExport { get; private set; }

    /// <summary>
    /// PortOfArrival of the LetterOfCreditMaster
    /// PortOfArrival الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string PortOfArrival { get; private set; }

    /// <summary>
    /// TypeOfCargo of the LetterOfCreditMaster
    /// TypeOfCargo الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? TypeOfCargo { get; private set; }

    /// <summary>
    /// GoodsType of the LetterOfCreditMaster
    /// GoodsType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? GoodsType { get; private set; }

    /// <summary>
    /// InsuranceCompany of the LetterOfCreditMaster
    /// InsuranceCompany الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceCompany { get; private set; }

    /// <summary>
    /// InsuranceNumberFull of the LetterOfCreditMaster
    /// InsuranceNumberFull الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceNumberFull { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the LetterOfCreditMaster
    /// ProcessedFlagFull الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// JournalVoucherProcessedFlag of the LetterOfCreditMaster
    /// JournalVoucherProcessedFlag الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? JournalVoucherProcessedFlag { get; private set; }

    /// <summary>
    /// LetterCreditClosedFlag of the LetterOfCreditMaster
    /// LetterCreditClosedFlag الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditClosedFlag { get; private set; }

    /// <summary>
    /// LetterCreditStatus of the LetterOfCreditMaster
    /// LetterCreditStatus الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditStatus { get; private set; }

    /// <summary>
    /// LetterCreditDueDate of the LetterOfCreditMaster
    /// LetterCreditDueDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? LetterCreditDueDate { get; private set; }

    /// <summary>
    /// CargoDate of the LetterOfCreditMaster
    /// CargoDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? CargoDate { get; private set; }

    /// <summary>
    /// CargoUnit of the LetterOfCreditMaster
    /// CargoUnit الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CargoUnit { get; private set; }

    /// <summary>
    /// CargoPrice of the LetterOfCreditMaster
    /// CargoPrice الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CargoPrice { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the LetterOfCreditMaster
    /// PurchaseOrderType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the LetterOfCreditMaster
    /// PurchaseOrderNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the LetterOfCreditMaster
    /// PurchaseOrderSerial الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// ExportCompany of the LetterOfCreditMaster
    /// ExportCompany الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string ExportCompany { get; private set; }

    /// <summary>
    /// MarineLine of the LetterOfCreditMaster
    /// MarineLine الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string MarineLine { get; private set; }

    /// <summary>
    /// LetterCreditRotate of the LetterOfCreditMaster
    /// LetterCreditRotate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditRotate { get; private set; }

    /// <summary>
    /// LetterCreditRotateNumber of the LetterOfCreditMaster
    /// LetterCreditRotateNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditRotateNumber { get; private set; }

    /// <summary>
    /// LetterCreditRotateAmount of the LetterOfCreditMaster
    /// LetterCreditRotateAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditRotateAmount { get; private set; }

    /// <summary>
    /// LetterCreditClosedDate of the LetterOfCreditMaster
    /// LetterCreditClosedDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? LetterCreditClosedDate { get; private set; }

    /// <summary>
    /// DeliveryCondType of the LetterOfCreditMaster
    /// DeliveryCondType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? DeliveryCondType { get; private set; }

    /// <summary>
    /// FacilityType of the LetterOfCreditMaster
    /// FacilityType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? FacilityType { get; private set; }

    /// <summary>
    /// CancelableFlag of the LetterOfCreditMaster
    /// CancelableFlag الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CancelableFlag { get; private set; }

    /// <summary>
    /// PromotionType of the LetterOfCreditMaster
    /// PromotionType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PromotionType { get; private set; }

    /// <summary>
    /// TenderNumber of the LetterOfCreditMaster
    /// TenderNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string TenderNumber { get; private set; }

    /// <summary>
    /// TenderDate of the LetterOfCreditMaster
    /// TenderDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? TenderDate { get; private set; }

    /// <summary>
    /// ImporterName of the LetterOfCreditMaster
    /// ImporterName الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string ImporterName { get; private set; }

    /// <summary>
    /// CustomStatementNo of the LetterOfCreditMaster
    /// CustomStatementNo الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CustomStatementNo { get; private set; }

    /// <summary>
    /// FlyingNumber of the LetterOfCreditMaster
    /// FlyingNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string FlyingNumber { get; private set; }

    /// <summary>
    /// BillLadingNumber of the LetterOfCreditMaster
    /// BillLadingNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string BillLadingNumber { get; private set; }

    /// <summary>
    /// CommitmentEndDate of the LetterOfCreditMaster
    /// CommitmentEndDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? CommitmentEndDate { get; private set; }

    /// <summary>
    /// CommitmentNumber of the LetterOfCreditMaster
    /// CommitmentNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CommitmentNumber { get; private set; }

    /// <summary>
    /// CommitmentDate of the LetterOfCreditMaster
    /// CommitmentDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? CommitmentDate { get; private set; }

    /// <summary>
    /// LetterCreditPaymentYear of the LetterOfCreditMaster
    /// LetterCreditPaymentYear الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditPaymentYear { get; private set; }

    /// <summary>
    /// DocType of the LetterOfCreditMaster
    /// DocType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// CollectNumber of the LetterOfCreditMaster
    /// CollectNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CollectNumber { get; private set; }

    /// <summary>
    /// CollectAmount of the LetterOfCreditMaster
    /// CollectAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CollectAmount { get; private set; }

    /// <summary>
    /// CollectAccountCurrency of the LetterOfCreditMaster
    /// CollectAccountCurrency الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CollectAccountCurrency { get; private set; }

    /// <summary>
    /// TransferAmount of the LetterOfCreditMaster
    /// TransferAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? TransferAmount { get; private set; }

    /// <summary>
    /// TransferAccountCurrency of the LetterOfCreditMaster
    /// TransferAccountCurrency الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string TransferAccountCurrency { get; private set; }

    /// <summary>
    /// TransferCommissionAmount of the LetterOfCreditMaster
    /// TransferCommissionAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? TransferCommissionAmount { get; private set; }

    /// <summary>
    /// TransferCommissionAccountCurrency of the LetterOfCreditMaster
    /// TransferCommissionAccountCurrency الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string TransferCommissionAccountCurrency { get; private set; }

    /// <summary>
    /// TransferDate of the LetterOfCreditMaster
    /// TransferDate الخاص بـ LetterOfCreditMaster
    /// </summary>
    public DateTime? TransferDate { get; private set; }

    /// <summary>
    /// InsuranceType of the LetterOfCreditMaster
    /// InsuranceType الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceType { get; private set; }

    /// <summary>
    /// InsuranceCompanyAccountCode of the LetterOfCreditMaster
    /// InsuranceCompanyAccountCode الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceCompanyAccountCode { get; private set; }

    /// <summary>
    /// InsuranceCondition of the LetterOfCreditMaster
    /// InsuranceCondition الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceCondition { get; private set; }

    /// <summary>
    /// InsuranceAmount of the LetterOfCreditMaster
    /// InsuranceAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? InsuranceAmount { get; private set; }

    /// <summary>
    /// InsuranceAccountCurrency of the LetterOfCreditMaster
    /// InsuranceAccountCurrency الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsuranceAccountCurrency { get; private set; }

    /// <summary>
    /// InsurancePremium of the LetterOfCreditMaster
    /// InsurancePremium الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? InsurancePremium { get; private set; }

    /// <summary>
    /// InsurancePolicy of the LetterOfCreditMaster
    /// InsurancePolicy الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string InsurancePolicy { get; private set; }

    /// <summary>
    /// LetterCreditCreditAmount of the LetterOfCreditMaster
    /// LetterCreditCreditAmount الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? LetterCreditCreditAmount { get; private set; }

    /// <summary>
    /// CreditAccountCurrency of the LetterOfCreditMaster
    /// CreditAccountCurrency الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string CreditAccountCurrency { get; private set; }

    /// <summary>
    /// LetterCreditAccountCredit of the LetterOfCreditMaster
    /// LetterCreditAccountCredit الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditAccountCredit { get; private set; }

    /// <summary>
    /// LetterCreditAccountCreditDetail of the LetterOfCreditMaster
    /// LetterCreditAccountCreditDetail الخاص بـ LetterOfCreditMaster
    /// </summary>
    public string LetterCreditAccountCreditDetail { get; private set; }

    /// <summary>
    /// PostToVendorCode of the LetterOfCreditMaster
    /// PostToVendorCode الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? PostToVendorCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the LetterOfCreditMaster
    /// CompanyNumberShort الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the LetterOfCreditMaster
    /// BranchNumber الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the LetterOfCreditMaster
    /// BranchYear الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the LetterOfCreditMaster
    /// BranchUser الخاص بـ LetterOfCreditMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BankCash BankCash { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

