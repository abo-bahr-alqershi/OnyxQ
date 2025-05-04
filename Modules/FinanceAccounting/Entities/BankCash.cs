using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BankCash Entity
/// </summary>
public class BankCash : Entity<BankCashId>
{
    private BankCash() { }

    /// <summary>
    /// The unique identifier for the BankCash
    /// المعرف الفريد لـ BankCash
    /// </summary>
    public BankCashId Id { get; private set; }

    /// <summary>
    /// BankNumber of the BankCash
    /// BankNumber الخاص بـ BankCash
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BankCash
    /// AccountCode الخاص بـ BankCash
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// BankName of the BankCash
    /// BankName الخاص بـ BankCash
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// BankNameEnglish of the BankCash
    /// BankNameEnglish الخاص بـ BankCash
    /// </summary>
    public string BankNameEnglish { get; private set; }

    /// <summary>
    /// BankSerial of the BankCash
    /// BankSerial الخاص بـ BankCash
    /// </summary>
    public decimal? BankSerial { get; private set; }

    /// <summary>
    /// GroupNumber of the BankCash
    /// GroupNumber الخاص بـ BankCash
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// BankAccountShort of the BankCash
    /// BankAccountShort الخاص بـ BankCash
    /// </summary>
    public string BankAccountShort { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the BankCash
    /// ConnectionBranchNumber الخاص بـ BankCash
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// BankTelephone of the BankCash
    /// BankTelephone الخاص بـ BankCash
    /// </summary>
    public string BankTelephone { get; private set; }

    /// <summary>
    /// BankFax of the BankCash
    /// BankFax الخاص بـ BankCash
    /// </summary>
    public string BankFax { get; private set; }

    /// <summary>
    /// BankBox of the BankCash
    /// BankBox الخاص بـ BankCash
    /// </summary>
    public string BankBox { get; private set; }

    /// <summary>
    /// BankAddress of the BankCash
    /// BankAddress الخاص بـ BankCash
    /// </summary>
    public string BankAddress { get; private set; }

    /// <summary>
    /// BankEmail of the BankCash
    /// BankEmail الخاص بـ BankCash
    /// </summary>
    public string BankEmail { get; private set; }

    /// <summary>
    /// BankWebsite of the BankCash
    /// BankWebsite الخاص بـ BankCash
    /// </summary>
    public string BankWebsite { get; private set; }

    /// <summary>
    /// CountryNumber of the BankCash
    /// CountryNumber الخاص بـ BankCash
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the BankCash
    /// CityNumber الخاص بـ BankCash
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// MediatorFlag of the BankCash
    /// MediatorFlag الخاص بـ BankCash
    /// </summary>
    public decimal? MediatorFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the BankCash
    /// InactiveFlag الخاص بـ BankCash
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the BankCash
    /// InactiveDate الخاص بـ BankCash
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the BankCash
    /// InactiveReason الخاص بـ BankCash
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// BankImage of the BankCash
    /// BankImage الخاص بـ BankCash
    /// </summary>
    public string BankImage { get; private set; }

    /// <summary>
    /// ReceiveLetter of the BankCash
    /// ReceiveLetter الخاص بـ BankCash
    /// </summary>
    public string ReceiveLetter { get; private set; }

    /// <summary>
    /// PaymentLetter of the BankCash
    /// PaymentLetter الخاص بـ BankCash
    /// </summary>
    public string PaymentLetter { get; private set; }

    /// <summary>
    /// ChequePayInterimAccount of the BankCash
    /// ChequePayInterimAccount الخاص بـ BankCash
    /// </summary>
    public string ChequePayInterimAccount { get; private set; }

    /// <summary>
    /// RepSample of the BankCash
    /// RepSample الخاص بـ BankCash
    /// </summary>
    public decimal? RepSample { get; private set; }

    /// <summary>
    /// ConfigLastDate of the BankCash
    /// ConfigLastDate الخاص بـ BankCash
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// OchkAutoSerial of the BankCash
    /// OchkAutoSerial الخاص بـ BankCash
    /// </summary>
    public decimal? OchkAutoSerial { get; private set; }

    /// <summary>
    /// BankCode of the BankCash
    /// BankCode الخاص بـ BankCash
    /// </summary>
    public decimal? BankCode { get; private set; }

    /// <summary>
    /// ReceiptSerialType of the BankCash
    /// ReceiptSerialType الخاص بـ BankCash
    /// </summary>
    public decimal? ReceiptSerialType { get; private set; }

    /// <summary>
    /// PaymentTypeNumberDefault of the BankCash
    /// PaymentTypeNumberDefault الخاص بـ BankCash
    /// </summary>
    public decimal? PaymentTypeNumberDefault { get; private set; }

    /// <summary>
    /// ReceivedTypeNumberDefault of the BankCash
    /// ReceivedTypeNumberDefault الخاص بـ BankCash
    /// </summary>
    public decimal? ReceivedTypeNumberDefault { get; private set; }

    /// <summary>
    /// BankNetworkCode of the BankCash
    /// BankNetworkCode الخاص بـ BankCash
    /// </summary>
    public string BankNetworkCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BankGroup
    /// </summary>
    public BankGroup BankGroup { get; private set; }
    /// <summary>
    /// One-to-many relationship: BankCash to CashAtBankBranch
    /// </summary>
    public IReadOnlyCollection<CashAtBankBranch> CashAtBankBranches { get; private set; }
    /// <summary>
    /// One-to-many relationship: BankCash to CashAtBankDetail
    /// </summary>
    public IReadOnlyCollection<CashAtBankDetail> CashAtBankDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: BankCash to LetterOfCreditMaster
    /// </summary>
    public IReadOnlyCollection<LetterOfCreditMaster> LetterOfCreditMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: BankCash to AccountCurrency
    /// </summary>
    public IReadOnlyCollection<AccountCurrency> AccountCurrencies { get; private set; }
    #endregion
}
}
