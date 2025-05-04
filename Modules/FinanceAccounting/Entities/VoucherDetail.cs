using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VoucherDetail Entity
/// </summary>
public class VoucherDetail : Entity<VoucherDetailId>
{
    private VoucherDetail() { }

    /// <summary>
    /// The unique identifier for the VoucherDetail
    /// المعرف الفريد لـ VoucherDetail
    /// </summary>
    public VoucherDetailId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the VoucherDetail
    /// VoucherTypeFull الخاص بـ VoucherDetail
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the VoucherDetail
    /// VoucherPayTypeShort الخاص بـ VoucherDetail
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the VoucherDetail
    /// VoucherNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the VoucherDetail
    /// CashNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// VendorSerialShort of the VoucherDetail
    /// VendorSerialShort الخاص بـ VoucherDetail
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// AccountCode of the VoucherDetail
    /// AccountCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the VoucherDetail
    /// AccountDetailCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the VoucherDetail
    /// AccountDetailSubCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailSubEndCode of the VoucherDetail
    /// AccountDetailSubEndCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailSubEndCode { get; private set; }

    /// <summary>
    /// AccountDetailSubDrCommissionCode of the VoucherDetail
    /// AccountDetailSubDrCommissionCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailSubDrCommissionCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the VoucherDetail
    /// AccountDetailType الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the VoucherDetail
    /// AccountCurrency الخاص بـ VoucherDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountDescription of the VoucherDetail
    /// AccountDescription الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AccountAmount of the VoucherDetail
    /// AccountAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountAmountForeign of the VoucherDetail
    /// AccountAmountForeign الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the VoucherDetail
    /// ExchangeRate الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the VoucherDetail
    /// CostCenterCode الخاص بـ VoucherDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the VoucherDetail
    /// ProjectNumber الخاص بـ VoucherDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the VoucherDetail
    /// ActivityNumber الخاص بـ VoucherDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CCode of the VoucherDetail
    /// CCode الخاص بـ VoucherDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the VoucherDetail
    /// VendorCode الخاص بـ VoucherDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// RepCode of the VoucherDetail
    /// RepCode الخاص بـ VoucherDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the VoucherDetail
    /// CashBankNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the VoucherDetail
    /// ChequeNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ValueDate of the VoucherDetail
    /// ValueDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ChequePostFlag of the VoucherDetail
    /// ChequePostFlag الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ChequePostFlag { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the VoucherDetail
    /// ChequeValuedFlag الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// Endrsmnt of the VoucherDetail
    /// Endrsmnt الخاص بـ VoucherDetail
    /// </summary>
    public decimal? Endrsmnt { get; private set; }

    /// <summary>
    /// NoteNumber of the VoucherDetail
    /// NoteNumber الخاص بـ VoucherDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// BankNumber of the VoucherDetail
    /// BankNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BankNameShort of the VoucherDetail
    /// BankNameShort الخاص بـ VoucherDetail
    /// </summary>
    public string BankNameShort { get; private set; }

    /// <summary>
    /// BankBranchNumber of the VoucherDetail
    /// BankBranchNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BankBranchNumber { get; private set; }

    /// <summary>
    /// AccountCodeEnd of the VoucherDetail
    /// AccountCodeEnd الخاص بـ VoucherDetail
    /// </summary>
    public string AccountCodeEnd { get; private set; }

    /// <summary>
    /// CCodeEnd of the VoucherDetail
    /// CCodeEnd الخاص بـ VoucherDetail
    /// </summary>
    public string CCodeEnd { get; private set; }

    /// <summary>
    /// VendorCodeEnd of the VoucherDetail
    /// VendorCodeEnd الخاص بـ VoucherDetail
    /// </summary>
    public string VendorCodeEnd { get; private set; }

    /// <summary>
    /// ReturnReason of the VoucherDetail
    /// ReturnReason الخاص بـ VoucherDetail
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the VoucherDetail
    /// LetterCreditNumber الخاص بـ VoucherDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// CiNumber of the VoucherDetail
    /// CiNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CiNumber { get; private set; }

    /// <summary>
    /// CiSerial of the VoucherDetail
    /// CiSerial الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CiSerial { get; private set; }

    /// <summary>
    /// HoursPayNumber of the VoucherDetail
    /// HoursPayNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? HoursPayNumber { get; private set; }

    /// <summary>
    /// KNumber of the VoucherDetail
    /// KNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// KSerial of the VoucherDetail
    /// KSerial الخاص بـ VoucherDetail
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// BillNumber of the VoucherDetail
    /// BillNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the VoucherDetail
    /// BillSerial الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the VoucherDetail
    /// ItemNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the VoucherDetail
    /// WorkOrderNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the VoucherDetail
    /// WorkOrderSerial الخاص بـ VoucherDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ContractNumber of the VoucherDetail
    /// ContractNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerialShort of the VoucherDetail
    /// ContractSerialShort الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ContractSerialShort { get; private set; }

    /// <summary>
    /// ContractBatch of the VoucherDetail
    /// ContractBatch الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ContractBatch { get; private set; }

    /// <summary>
    /// RepCommissionAmount of the VoucherDetail
    /// RepCommissionAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? RepCommissionAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the VoucherDetail
    /// ReferenceNumber الخاص بـ VoucherDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the VoucherDetail
    /// RecordNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ConnectionVNumber of the VoucherDetail
    /// ConnectionVNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ConnectionVNumber { get; private set; }

    /// <summary>
    /// ConnectionVSerial of the VoucherDetail
    /// ConnectionVSerial الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ConnectionVSerial { get; private set; }

    /// <summary>
    /// ConnectionVAmount of the VoucherDetail
    /// ConnectionVAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ConnectionVAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the VoucherDetail
    /// ExternalPostFlag الخاص بـ VoucherDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillmentDate of the VoucherDetail
    /// BillmentDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? BillmentDate { get; private set; }

    /// <summary>
    /// DocSequenceRef of the VoucherDetail
    /// DocSequenceRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// DocSequence of the VoucherDetail
    /// DocSequence الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CashierNumber of the VoucherDetail
    /// CashierNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// Note of the VoucherDetail
    /// Note الخاص بـ VoucherDetail
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// AccountDrCommissionCode of the VoucherDetail
    /// AccountDrCommissionCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDrCommissionCode { get; private set; }

    /// <summary>
    /// AccountDetailDrCommissionCode of the VoucherDetail
    /// AccountDetailDrCommissionCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailDrCommissionCode { get; private set; }

    /// <summary>
    /// AccountDetailTypeDrCommission of the VoucherDetail
    /// AccountDetailTypeDrCommission الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AccountDetailTypeDrCommission { get; private set; }

    /// <summary>
    /// OtherAmountLocal of the VoucherDetail
    /// OtherAmountLocal الخاص بـ VoucherDetail
    /// </summary>
    public decimal? OtherAmountLocal { get; private set; }

    /// <summary>
    /// OtherAmountForeign of the VoucherDetail
    /// OtherAmountForeign الخاص بـ VoucherDetail
    /// </summary>
    public decimal? OtherAmountForeign { get; private set; }

    /// <summary>
    /// AuditReference of the VoucherDetail
    /// AuditReference الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the VoucherDetail
    /// AuditReferenceDescription الخاص بـ VoucherDetail
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the VoucherDetail
    /// AuditReferenceUserId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the VoucherDetail
    /// AuditReferenceDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// AccountDetailTypeEnd of the VoucherDetail
    /// AccountDetailTypeEnd الخاص بـ VoucherDetail
    /// </summary>
    public decimal? AccountDetailTypeEnd { get; private set; }

    /// <summary>
    /// AccountDetailEndCode of the VoucherDetail
    /// AccountDetailEndCode الخاص بـ VoucherDetail
    /// </summary>
    public string AccountDetailEndCode { get; private set; }

    /// <summary>
    /// DocTypeRef of the VoucherDetail
    /// DocTypeRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the VoucherDetail
    /// DocJvTypeRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the VoucherDetail
    /// DocNoRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the VoucherDetail
    /// DocSerRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocBrnNo of the VoucherDetail
    /// DocBrnNo الخاص بـ VoucherDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PostUserId of the VoucherDetail
    /// PostUserId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the VoucherDetail
    /// PostDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the VoucherDetail
    /// UnpostUserId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the VoucherDetail
    /// UnpostDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// FContractDate of the VoucherDetail
    /// FContractDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? FContractDate { get; private set; }

    /// <summary>
    /// TContractDate of the VoucherDetail
    /// TContractDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? TContractDate { get; private set; }

    /// <summary>
    /// FContractDateHijri of the VoucherDetail
    /// FContractDateHijri الخاص بـ VoucherDetail
    /// </summary>
    public string FContractDateHijri { get; private set; }

    /// <summary>
    /// TContractDateHijri of the VoucherDetail
    /// TContractDateHijri الخاص بـ VoucherDetail
    /// </summary>
    public string TContractDateHijri { get; private set; }

    /// <summary>
    /// CreditCardNumber of the VoucherDetail
    /// CreditCardNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCardNumber { get; private set; }

    /// <summary>
    /// CreditAccountReceiptLetter of the VoucherDetail
    /// CreditAccountReceiptLetter الخاص بـ VoucherDetail
    /// </summary>
    public string CreditAccountReceiptLetter { get; private set; }

    /// <summary>
    /// CreditCommissionAccount of the VoucherDetail
    /// CreditCommissionAccount الخاص بـ VoucherDetail
    /// </summary>
    public string CreditCommissionAccount { get; private set; }

    /// <summary>
    /// CreditCommissionCalculationType of the VoucherDetail
    /// CreditCommissionCalculationType الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCommissionCalculationType { get; private set; }

    /// <summary>
    /// CreditCommissionPercent of the VoucherDetail
    /// CreditCommissionPercent الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCommissionPercent { get; private set; }

    /// <summary>
    /// CreditVatCommissionPercent of the VoucherDetail
    /// CreditVatCommissionPercent الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionPercent { get; private set; }

    /// <summary>
    /// CreditDuePeriod of the VoucherDetail
    /// CreditDuePeriod الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditDuePeriod { get; private set; }

    /// <summary>
    /// CreditProcessesNumber of the VoucherDetail
    /// CreditProcessesNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditProcessesNumber { get; private set; }

    /// <summary>
    /// Field1Alt of the VoucherDetail
    /// Field1Alt الخاص بـ VoucherDetail
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// Field2Alt of the VoucherDetail
    /// Field2Alt الخاص بـ VoucherDetail
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// Field3Alt of the VoucherDetail
    /// Field3Alt الخاص بـ VoucherDetail
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// Field4Alt of the VoucherDetail
    /// Field4Alt الخاص بـ VoucherDetail
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// Field5Alt of the VoucherDetail
    /// Field5Alt الخاص بـ VoucherDetail
    /// </summary>
    public string Field5Alt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VoucherDetail
    /// CompanyNumberShort الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the VoucherDetail
    /// BranchNumber الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the VoucherDetail
    /// BranchYear الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VoucherDetail
    /// BranchUser الخاص بـ VoucherDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CreditCommissionAmountLocal of the VoucherDetail
    /// CreditCommissionAmountLocal الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCommissionAmountLocal { get; private set; }

    /// <summary>
    /// CreditVatCommissionAmountLocal of the VoucherDetail
    /// CreditVatCommissionAmountLocal الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionAmountLocal { get; private set; }

    /// <summary>
    /// CreditWithdrawAmountLocal of the VoucherDetail
    /// CreditWithdrawAmountLocal الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditWithdrawAmountLocal { get; private set; }

    /// <summary>
    /// CreditCardType of the VoucherDetail
    /// CreditCardType الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCardType { get; private set; }

    /// <summary>
    /// EndrsmntDate of the VoucherDetail
    /// EndrsmntDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? EndrsmntDate { get; private set; }

    /// <summary>
    /// EndrsmntPost of the VoucherDetail
    /// EndrsmntPost الخاص بـ VoucherDetail
    /// </summary>
    public decimal? EndrsmntPost { get; private set; }

    /// <summary>
    /// EndrsmntPostUId of the VoucherDetail
    /// EndrsmntPostUId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? EndrsmntPostUId { get; private set; }

    /// <summary>
    /// EndrsmntUnpostUId of the VoucherDetail
    /// EndrsmntUnpostUId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? EndrsmntUnpostUId { get; private set; }

    /// <summary>
    /// EndrsmntPostDate of the VoucherDetail
    /// EndrsmntPostDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? EndrsmntPostDate { get; private set; }

    /// <summary>
    /// EndrsmntUnpostDate of the VoucherDetail
    /// EndrsmntUnpostDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? EndrsmntUnpostDate { get; private set; }

    /// <summary>
    /// EndrsmntAuditRefUId of the VoucherDetail
    /// EndrsmntAuditRefUId الخاص بـ VoucherDetail
    /// </summary>
    public decimal? EndrsmntAuditRefUId { get; private set; }

    /// <summary>
    /// EndrsmntAuditRef of the VoucherDetail
    /// EndrsmntAuditRef الخاص بـ VoucherDetail
    /// </summary>
    public decimal? EndrsmntAuditRef { get; private set; }

    /// <summary>
    /// EndrsmntAuditRefDesc of the VoucherDetail
    /// EndrsmntAuditRefDesc الخاص بـ VoucherDetail
    /// </summary>
    public string EndrsmntAuditRefDesc { get; private set; }

    /// <summary>
    /// EndrsmntUauditRefDate of the VoucherDetail
    /// EndrsmntUauditRefDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? EndrsmntUauditRefDate { get; private set; }

    /// <summary>
    /// EndrsmntAuditRefDate of the VoucherDetail
    /// EndrsmntAuditRefDate الخاص بـ VoucherDetail
    /// </summary>
    public DateTime? EndrsmntAuditRefDate { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the VoucherDetail
    /// CalcTypeNumberTax الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// TaxPercent of the VoucherDetail
    /// TaxPercent الخاص بـ VoucherDetail
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the VoucherDetail
    /// TaxAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// CreditCommissionAmount of the VoucherDetail
    /// CreditCommissionAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditCommissionAmount { get; private set; }

    /// <summary>
    /// CreditVatCommissionAmount of the VoucherDetail
    /// CreditVatCommissionAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionAmount { get; private set; }

    /// <summary>
    /// CreditAccountCurrencyMaxCommission of the VoucherDetail
    /// CreditAccountCurrencyMaxCommission الخاص بـ VoucherDetail
    /// </summary>
    public string CreditAccountCurrencyMaxCommission { get; private set; }

    /// <summary>
    /// CreditWithdrawAmount of the VoucherDetail
    /// CreditWithdrawAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditWithdrawAmount { get; private set; }

    /// <summary>
    /// CreditProcessMaxCommissionAmount of the VoucherDetail
    /// CreditProcessMaxCommissionAmount الخاص بـ VoucherDetail
    /// </summary>
    public decimal? CreditProcessMaxCommissionAmount { get; private set; }

    #region Navigation Properties
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
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Voucher
    /// </summary>
    public Voucher Voucher { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetail to VoucherChequeDetail
    /// </summary>
    public IReadOnlyCollection<VoucherChequeDetail> VoucherChequeDetails { get; private set; }
    #endregion
}
}
