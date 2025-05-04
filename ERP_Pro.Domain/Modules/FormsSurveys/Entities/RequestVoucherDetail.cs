using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestVoucherDetail Entity
/// </summary>
public class RequestVoucherDetail : Entity<RequestVoucherDetailId>
{

    private RequestVoucherDetail() { }

    public RequestVoucherDetail(RequestVoucherDetailId id, decimal? docSequence)
    {
        Id = id;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the RequestVoucherDetail
    /// المعرف الفريد لـ RequestVoucherDetail
    /// </summary>
    public RequestVoucherDetailId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the RequestVoucherDetail
    /// VoucherTypeFull الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the RequestVoucherDetail
    /// VoucherPayTypeShort الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the RequestVoucherDetail
    /// VoucherNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the RequestVoucherDetail
    /// CashNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the RequestVoucherDetail
    /// AccountDetailCode الخاص بـ RequestVoucherDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the RequestVoucherDetail
    /// AccountDetailType الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountDescription of the RequestVoucherDetail
    /// AccountDescription الخاص بـ RequestVoucherDetail
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AccountAmount of the RequestVoucherDetail
    /// AccountAmount الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountAmountForeign of the RequestVoucherDetail
    /// AccountAmountForeign الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the RequestVoucherDetail
    /// ExchangeRate الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// ProjectNumber of the RequestVoucherDetail
    /// ProjectNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// RepCode of the RequestVoucherDetail
    /// RepCode الخاص بـ RequestVoucherDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the RequestVoucherDetail
    /// CashBankNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the RequestVoucherDetail
    /// ChequeNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ValueDate of the RequestVoucherDetail
    /// ValueDate الخاص بـ RequestVoucherDetail
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the RequestVoucherDetail
    /// ChequeValuedFlag الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// NoteNumber of the RequestVoucherDetail
    /// NoteNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// BankNumber of the RequestVoucherDetail
    /// BankNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// CiNumber of the RequestVoucherDetail
    /// CiNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CiNumber { get; private set; }

    /// <summary>
    /// CiSerial of the RequestVoucherDetail
    /// CiSerial الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CiSerial { get; private set; }

    /// <summary>
    /// HoursPayNumber of the RequestVoucherDetail
    /// HoursPayNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? HoursPayNumber { get; private set; }

    /// <summary>
    /// KNumber of the RequestVoucherDetail
    /// KNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// KSerial of the RequestVoucherDetail
    /// KSerial الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// BillNumber of the RequestVoucherDetail
    /// BillNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the RequestVoucherDetail
    /// BillSerial الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the RequestVoucherDetail
    /// ItemNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the RequestVoucherDetail
    /// WorkOrderNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the RequestVoucherDetail
    /// WorkOrderSerial الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestVoucherDetail
    /// ReferenceNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// OtherAmountLocal of the RequestVoucherDetail
    /// OtherAmountLocal الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? OtherAmountLocal { get; private set; }

    /// <summary>
    /// OtherAmountForeign of the RequestVoucherDetail
    /// OtherAmountForeign الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? OtherAmountForeign { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestVoucherDetail
    /// RecordNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillmentDate of the RequestVoucherDetail
    /// BillmentDate الخاص بـ RequestVoucherDetail
    /// </summary>
    public DateTime? BillmentDate { get; private set; }

    /// <summary>
    /// Note of the RequestVoucherDetail
    /// Note الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// DocSequence of the RequestVoucherDetail
    /// DocSequence الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocTypeRef of the RequestVoucherDetail
    /// DocTypeRef الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the RequestVoucherDetail
    /// DocJvTypeRef الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the RequestVoucherDetail
    /// DocNoRef الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the RequestVoucherDetail
    /// DocSerRef الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ConnectionVNumber of the RequestVoucherDetail
    /// ConnectionVNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ConnectionVNumber { get; private set; }

    /// <summary>
    /// ConnectionVSerial of the RequestVoucherDetail
    /// ConnectionVSerial الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ConnectionVSerial { get; private set; }

    /// <summary>
    /// ConnectionVAmount of the RequestVoucherDetail
    /// ConnectionVAmount الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ConnectionVAmount { get; private set; }

    /// <summary>
    /// DocBrnNo of the RequestVoucherDetail
    /// DocBrnNo الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the RequestVoucherDetail
    /// AccountDetailSubCode الخاص بـ RequestVoucherDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// Field1Alt of the RequestVoucherDetail
    /// Field1Alt الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// Field2Alt of the RequestVoucherDetail
    /// Field2Alt الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// Field3Alt of the RequestVoucherDetail
    /// Field3Alt الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// Field4Alt of the RequestVoucherDetail
    /// Field4Alt الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// Field5Alt of the RequestVoucherDetail
    /// Field5Alt الخاص بـ RequestVoucherDetail
    /// </summary>
    public string Field5Alt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestVoucherDetail
    /// CompanyNumberShort الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestVoucherDetail
    /// BranchNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestVoucherDetail
    /// BranchYear الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestVoucherDetail
    /// BranchUser الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the RequestVoucherDetail
    /// CalcTypeNumberTax الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// BankAccountCode of the RequestVoucherDetail
    /// BankAccountCode الخاص بـ RequestVoucherDetail
    /// </summary>
    public string BankAccountCode { get; private set; }

    /// <summary>
    /// CreditCardType of the RequestVoucherDetail
    /// CreditCardType الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCardType { get; private set; }

    /// <summary>
    /// CreditCardNumber of the RequestVoucherDetail
    /// CreditCardNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCardNumber { get; private set; }

    /// <summary>
    /// CreditAccountReceiptLetter of the RequestVoucherDetail
    /// CreditAccountReceiptLetter الخاص بـ RequestVoucherDetail
    /// </summary>
    public string CreditAccountReceiptLetter { get; private set; }

    /// <summary>
    /// CreditCommissionAccount of the RequestVoucherDetail
    /// CreditCommissionAccount الخاص بـ RequestVoucherDetail
    /// </summary>
    public string CreditCommissionAccount { get; private set; }

    /// <summary>
    /// CreditCommissionCalculationType of the RequestVoucherDetail
    /// CreditCommissionCalculationType الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCommissionCalculationType { get; private set; }

    /// <summary>
    /// CreditCommissionPercent of the RequestVoucherDetail
    /// CreditCommissionPercent الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCommissionPercent { get; private set; }

    /// <summary>
    /// CreditVatCommissionPercent of the RequestVoucherDetail
    /// CreditVatCommissionPercent الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionPercent { get; private set; }

    /// <summary>
    /// CreditDuePeriod of the RequestVoucherDetail
    /// CreditDuePeriod الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditDuePeriod { get; private set; }

    /// <summary>
    /// CreditProcessesNumber of the RequestVoucherDetail
    /// CreditProcessesNumber الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditProcessesNumber { get; private set; }

    /// <summary>
    /// CreditCommissionAmountLocal of the RequestVoucherDetail
    /// CreditCommissionAmountLocal الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCommissionAmountLocal { get; private set; }

    /// <summary>
    /// CreditVatCommissionAmountLocal of the RequestVoucherDetail
    /// CreditVatCommissionAmountLocal الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionAmountLocal { get; private set; }

    /// <summary>
    /// CreditWithdrawAmountLocal of the RequestVoucherDetail
    /// CreditWithdrawAmountLocal الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditWithdrawAmountLocal { get; private set; }

    /// <summary>
    /// CreditCommissionAmount of the RequestVoucherDetail
    /// CreditCommissionAmount الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditCommissionAmount { get; private set; }

    /// <summary>
    /// CreditAccountCurrencyMaxCommission of the RequestVoucherDetail
    /// CreditAccountCurrencyMaxCommission الخاص بـ RequestVoucherDetail
    /// </summary>
    public string CreditAccountCurrencyMaxCommission { get; private set; }

    /// <summary>
    /// CreditVatCommissionAmount of the RequestVoucherDetail
    /// CreditVatCommissionAmount الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? CreditVatCommissionAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the RequestVoucherDetail
    /// ExternalPostFlag الخاص بـ RequestVoucherDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    public RequestVoucherMaster RequestVoucherMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
