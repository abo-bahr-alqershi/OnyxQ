using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;
namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterGeneralLedger Entity
/// </summary>
public class ParameterGeneralLedger : Entity<ParameterGeneralLedgerId>
{

    private ParameterGeneralLedger() { }

    public ParameterGeneralLedger(ParameterGeneralLedgerId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParameterGeneralLedger
    /// المعرف الفريد لـ ParameterGeneralLedger
    /// </summary>
    public ParameterGeneralLedgerId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterGeneralLedger
    /// ParameterNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// DocGenGl of the ParameterGeneralLedger
    /// DocGenGl الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DocGenGl { get; private set; }

    /// <summary>
    /// AllowDocumentDeleteNumber of the ParameterGeneralLedger
    /// AllowDocumentDeleteNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AllowDocumentDeleteNumber { get; private set; }

    /// <summary>
    /// DateGenGl of the ParameterGeneralLedger
    /// DateGenGl الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DateGenGl { get; private set; }

    /// <summary>
    /// DateSettingGl of the ParameterGeneralLedger
    /// DateSettingGl الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DateSettingGl { get; private set; }

    /// <summary>
    /// AccountCodeLength of the ParameterGeneralLedger
    /// AccountCodeLength الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AccountCodeLength { get; private set; }

    /// <summary>
    /// AccountCodeDiscountType of the ParameterGeneralLedger
    /// AccountCodeDiscountType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AccountCodeDiscountType { get; private set; }

    /// <summary>
    /// CostCenterLength of the ParameterGeneralLedger
    /// CostCenterLength الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CostCenterLength { get; private set; }

    /// <summary>
    /// CostCenterDiscountType of the ParameterGeneralLedger
    /// CostCenterDiscountType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CostCenterDiscountType { get; private set; }

    /// <summary>
    /// AccountSub of the ParameterGeneralLedger
    /// AccountSub الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AccountSub { get; private set; }

    /// <summary>
    /// JournalStandByFlag of the ParameterGeneralLedger
    /// JournalStandByFlag الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? JournalStandByFlag { get; private set; }

    /// <summary>
    /// ForeignCurrency of the ParameterGeneralLedger
    /// ForeignCurrency الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ForeignCurrency { get; private set; }

    /// <summary>
    /// NumberOfDecimal of the ParameterGeneralLedger
    /// NumberOfDecimal الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? NumberOfDecimal { get; private set; }

    /// <summary>
    /// RequestReferenceNumberGeneralLedger of the ParameterGeneralLedger
    /// RequestReferenceNumberGeneralLedger الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? RequestReferenceNumberGeneralLedger { get; private set; }

    /// <summary>
    /// RequestDescriptionGeneralLedger of the ParameterGeneralLedger
    /// RequestDescriptionGeneralLedger الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? RequestDescriptionGeneralLedger { get; private set; }

    /// <summary>
    /// CashReserve of the ParameterGeneralLedger
    /// CashReserve الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CashReserve { get; private set; }

    /// <summary>
    /// HandledLocalAmount of the ParameterGeneralLedger
    /// HandledLocalAmount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? HandledLocalAmount { get; private set; }

    /// <summary>
    /// CurrType of the ParameterGeneralLedger
    /// CurrType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CurrType { get; private set; }

    /// <summary>
    /// UseCashIncome of the ParameterGeneralLedger
    /// UseCashIncome الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseCashIncome { get; private set; }

    /// <summary>
    /// PostChequeType of the ParameterGeneralLedger
    /// PostChequeType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PostChequeType { get; private set; }

    /// <summary>
    /// PostChequeTypeVendor of the ParameterGeneralLedger
    /// PostChequeTypeVendor الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PostChequeTypeVendor { get; private set; }

    /// <summary>
    /// UseDeleteGeneralLedger of the ParameterGeneralLedger
    /// UseDeleteGeneralLedger الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseDeleteGeneralLedger { get; private set; }

    /// <summary>
    /// UseModifyGeneralLedger of the ParameterGeneralLedger
    /// UseModifyGeneralLedger الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseModifyGeneralLedger { get; private set; }

    /// <summary>
    /// UseGuarantor of the ParameterGeneralLedger
    /// UseGuarantor الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseGuarantor { get; private set; }

    /// <summary>
    /// ConnectionAccountCostCenter of the ParameterGeneralLedger
    /// ConnectionAccountCostCenter الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionAccountCostCenter { get; private set; }

    /// <summary>
    /// ConnectionAccountProject of the ParameterGeneralLedger
    /// ConnectionAccountProject الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionAccountProject { get; private set; }

    /// <summary>
    /// PostChequeTypeReceive of the ParameterGeneralLedger
    /// PostChequeTypeReceive الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PostChequeTypeReceive { get; private set; }

    /// <summary>
    /// PostChequeTypePay of the ParameterGeneralLedger
    /// PostChequeTypePay الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PostChequeTypePay { get; private set; }

    /// <summary>
    /// UseKimb of the ParameterGeneralLedger
    /// UseKimb الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseKimb { get; private set; }

    /// <summary>
    /// UseCashInJournalVoucher of the ParameterGeneralLedger
    /// UseCashInJournalVoucher الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseCashInJournalVoucher { get; private set; }

    /// <summary>
    /// UseBankMediatorInJournalVoucher of the ParameterGeneralLedger
    /// UseBankMediatorInJournalVoucher الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseBankMediatorInJournalVoucher { get; private set; }

    /// <summary>
    /// UseInvoiceAccountInJournalVoucher of the ParameterGeneralLedger
    /// UseInvoiceAccountInJournalVoucher الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseInvoiceAccountInJournalVoucher { get; private set; }

    /// <summary>
    /// MultiFillJournalVoucherNote of the ParameterGeneralLedger
    /// MultiFillJournalVoucherNote الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? MultiFillJournalVoucherNote { get; private set; }

    /// <summary>
    /// ParentAccountNotIncludeCode of the ParameterGeneralLedger
    /// ParentAccountNotIncludeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ParentAccountNotIncludeCode { get; private set; }

    /// <summary>
    /// CParentNotIncludeCc of the ParameterGeneralLedger
    /// CParentNotIncludeCc الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CParentNotIncludeCc { get; private set; }

    /// <summary>
    /// NoteSerialNumber of the ParameterGeneralLedger
    /// NoteSerialNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? NoteSerialNumber { get; private set; }

    /// <summary>
    /// GeneralLedgerLimitType of the ParameterGeneralLedger
    /// GeneralLedgerLimitType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? GeneralLedgerLimitType { get; private set; }

    /// <summary>
    /// DescIncludeCcName of the ParameterGeneralLedger
    /// DescIncludeCcName الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DescIncludeCcName { get; private set; }

    /// <summary>
    /// UseChequeJournalVoucher of the ParameterGeneralLedger
    /// UseChequeJournalVoucher الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseChequeJournalVoucher { get; private set; }

    /// <summary>
    /// PlaceClassType of the ParameterGeneralLedger
    /// PlaceClassType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PlaceClassType { get; private set; }

    /// <summary>
    /// DiffCurClsType of the ParameterGeneralLedger
    /// DiffCurClsType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DiffCurClsType { get; private set; }

    /// <summary>
    /// AllowDuplicateCashAccount of the ParameterGeneralLedger
    /// AllowDuplicateCashAccount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AllowDuplicateCashAccount { get; private set; }

    /// <summary>
    /// AllowDuplicateBankAccount of the ParameterGeneralLedger
    /// AllowDuplicateBankAccount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AllowDuplicateBankAccount { get; private set; }

    /// <summary>
    /// CashBankConnectedBranch of the ParameterGeneralLedger
    /// CashBankConnectedBranch الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CashBankConnectedBranch { get; private set; }

    /// <summary>
    /// UsePayVoucherMasterAccountPrevious of the ParameterGeneralLedger
    /// UsePayVoucherMasterAccountPrevious الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UsePayVoucherMasterAccountPrevious { get; private set; }

    /// <summary>
    /// UseReceiveVoucherMasterAccountPrevious of the ParameterGeneralLedger
    /// UseReceiveVoucherMasterAccountPrevious الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseReceiveVoucherMasterAccountPrevious { get; private set; }

    /// <summary>
    /// RequestCollectorNumberRecord of the ParameterGeneralLedger
    /// RequestCollectorNumberRecord الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? RequestCollectorNumberRecord { get; private set; }

    /// <summary>
    /// RequestVoucherTypeNumber of the ParameterGeneralLedger
    /// RequestVoucherTypeNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? RequestVoucherTypeNumber { get; private set; }

    /// <summary>
    /// ConnectionPaymentRequest of the ParameterGeneralLedger
    /// ConnectionPaymentRequest الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionPaymentRequest { get; private set; }

    /// <summary>
    /// ConnectionReceiptRequest of the ParameterGeneralLedger
    /// ConnectionReceiptRequest الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionReceiptRequest { get; private set; }

    /// <summary>
    /// PRateType of the ParameterGeneralLedger
    /// PRateType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PRateType { get; private set; }

    /// <summary>
    /// ReceiptSerialType of the ParameterGeneralLedger
    /// ReceiptSerialType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ReceiptSerialType { get; private set; }

    /// <summary>
    /// ConnectionCostCenterProject of the ParameterGeneralLedger
    /// ConnectionCostCenterProject الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionCostCenterProject { get; private set; }

    /// <summary>
    /// ConnectionProjectActivity of the ParameterGeneralLedger
    /// ConnectionProjectActivity الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionProjectActivity { get; private set; }

    /// <summary>
    /// AllowVoucherZero of the ParameterGeneralLedger
    /// AllowVoucherZero الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AllowVoucherZero { get; private set; }

    /// <summary>
    /// SubAccountLevel of the ParameterGeneralLedger
    /// SubAccountLevel الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? SubAccountLevel { get; private set; }

    /// <summary>
    /// FillHoursPayFormMethod of the ParameterGeneralLedger
    /// FillHoursPayFormMethod الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? FillHoursPayFormMethod { get; private set; }

    /// <summary>
    /// FillHoursReceiptFormMethod of the ParameterGeneralLedger
    /// FillHoursReceiptFormMethod الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? FillHoursReceiptFormMethod { get; private set; }

    /// <summary>
    /// JournalRequestSequence of the ParameterGeneralLedger
    /// JournalRequestSequence الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? JournalRequestSequence { get; private set; }

    /// <summary>
    /// PaymentRequestSequence of the ParameterGeneralLedger
    /// PaymentRequestSequence الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PaymentRequestSequence { get; private set; }

    /// <summary>
    /// ReceiveRequestSequence of the ParameterGeneralLedger
    /// ReceiveRequestSequence الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ReceiveRequestSequence { get; private set; }

    /// <summary>
    /// UseMultiCurrencyBudget of the ParameterGeneralLedger
    /// UseMultiCurrencyBudget الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseMultiCurrencyBudget { get; private set; }

    /// <summary>
    /// UseMultiCurrencyLimit of the ParameterGeneralLedger
    /// UseMultiCurrencyLimit الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseMultiCurrencyLimit { get; private set; }

    /// <summary>
    /// FillHoursJournalFormMethod of the ParameterGeneralLedger
    /// FillHoursJournalFormMethod الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? FillHoursJournalFormMethod { get; private set; }

    /// <summary>
    /// DupChqNoPaymnt of the ParameterGeneralLedger
    /// DupChqNoPaymnt الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DupChqNoPaymnt { get; private set; }

    /// <summary>
    /// DfltPostDsplyInAstmt of the ParameterGeneralLedger
    /// DfltPostDsplyInAstmt الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DfltPostDsplyInAstmt { get; private set; }

    /// <summary>
    /// NotCloseDifferenceCurrentPlAccount of the ParameterGeneralLedger
    /// NotCloseDifferenceCurrentPlAccount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? NotCloseDifferenceCurrentPlAccount { get; private set; }

    /// <summary>
    /// DescIncludePjName of the ParameterGeneralLedger
    /// DescIncludePjName الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? DescIncludePjName { get; private set; }

    /// <summary>
    /// ShowColumnNumber of the ParameterGeneralLedger
    /// ShowColumnNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ShowColumnNumber { get; private set; }

    /// <summary>
    /// ShowRepresentativeCode of the ParameterGeneralLedger
    /// ShowRepresentativeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ShowRepresentativeCode { get; private set; }

    /// <summary>
    /// ConnectionCashNumberRepresentativeCode of the ParameterGeneralLedger
    /// ConnectionCashNumberRepresentativeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionCashNumberRepresentativeCode { get; private set; }

    /// <summary>
    /// ConnectionCostCenterCodeRepresentativeCode of the ParameterGeneralLedger
    /// ConnectionCostCenterCodeRepresentativeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionCostCenterCodeRepresentativeCode { get; private set; }

    /// <summary>
    /// AllowDifferentRateMasterDetail of the ParameterGeneralLedger
    /// AllowDifferentRateMasterDetail الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AllowDifferentRateMasterDetail { get; private set; }

    /// <summary>
    /// PostAccountDiscountInPayCheque of the ParameterGeneralLedger
    /// PostAccountDiscountInPayCheque الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? PostAccountDiscountInPayCheque { get; private set; }

    /// <summary>
    /// UseMultiRequestInJournalVoucher of the ParameterGeneralLedger
    /// UseMultiRequestInJournalVoucher الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseMultiRequestInJournalVoucher { get; private set; }

    /// <summary>
    /// CheckBudgetAmount of the ParameterGeneralLedger
    /// CheckBudgetAmount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CheckBudgetAmount { get; private set; }

    /// <summary>
    /// CreateNoteMoveBudgetBranch of the ParameterGeneralLedger
    /// CreateNoteMoveBudgetBranch الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CreateNoteMoveBudgetBranch { get; private set; }

    /// <summary>
    /// ShowDocumentBranchNumber of the ParameterGeneralLedger
    /// ShowDocumentBranchNumber الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ShowDocumentBranchNumber { get; private set; }

    /// <summary>
    /// UseAllAccountBudget of the ParameterGeneralLedger
    /// UseAllAccountBudget الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseAllAccountBudget { get; private set; }

    /// <summary>
    /// CallCustomerRepresentativeCode of the ParameterGeneralLedger
    /// CallCustomerRepresentativeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? CallCustomerRepresentativeCode { get; private set; }

    /// <summary>
    /// UseBudgetApproval of the ParameterGeneralLedger
    /// UseBudgetApproval الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseBudgetApproval { get; private set; }

    /// <summary>
    /// UseBranchLimit of the ParameterGeneralLedger
    /// UseBranchLimit الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseBranchLimit { get; private set; }

    /// <summary>
    /// JournalSequenceType of the ParameterGeneralLedger
    /// JournalSequenceType الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? JournalSequenceType { get; private set; }

    /// <summary>
    /// MandatoryReceiptRepresentativeCode of the ParameterGeneralLedger
    /// MandatoryReceiptRepresentativeCode الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? MandatoryReceiptRepresentativeCode { get; private set; }

    /// <summary>
    /// AdditionalFieldDetailCount of the ParameterGeneralLedger
    /// AdditionalFieldDetailCount الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? AdditionalFieldDetailCount { get; private set; }

    /// <summary>
    /// ConnectionAccountActivity of the ParameterGeneralLedger
    /// ConnectionAccountActivity الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ConnectionAccountActivity { get; private set; }

    /// <summary>
    /// ExchangeCurrencySequence of the ParameterGeneralLedger
    /// ExchangeCurrencySequence الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? ExchangeCurrencySequence { get; private set; }

    /// <summary>
    /// UseExpenseTax of the ParameterGeneralLedger
    /// UseExpenseTax الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseExpenseTax { get; private set; }

    /// <summary>
    /// UseMultiRequestInPayment of the ParameterGeneralLedger
    /// UseMultiRequestInPayment الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseMultiRequestInPayment { get; private set; }

    /// <summary>
    /// UseMultiRequestInReceipt of the ParameterGeneralLedger
    /// UseMultiRequestInReceipt الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseMultiRequestInReceipt { get; private set; }

    /// <summary>
    /// UseBankDepositAccountIntermediate of the ParameterGeneralLedger
    /// UseBankDepositAccountIntermediate الخاص بـ ParameterGeneralLedger
    /// </summary>
    public decimal? UseBankDepositAccountIntermediate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

