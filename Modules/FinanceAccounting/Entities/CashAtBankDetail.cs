using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashAtBankDetail Entity
/// </summary>
public class CashAtBankDetail : Entity<CashAtBankDetailId>
{
    private CashAtBankDetail() { }

    /// <summary>
    /// The unique identifier for the CashAtBankDetail
    /// المعرف الفريد لـ CashAtBankDetail
    /// </summary>
    public CashAtBankDetailId Id { get; private set; }

    /// <summary>
    /// BankNumber of the CashAtBankDetail
    /// BankNumber الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// AccountCode of the CashAtBankDetail
    /// AccountCode الخاص بـ CashAtBankDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CashAtBankDetail
    /// AccountCurrency الخاص بـ CashAtBankDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// OpenBalanceLocal of the CashAtBankDetail
    /// OpenBalanceLocal الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? OpenBalanceLocal { get; private set; }

    /// <summary>
    /// OpenBalanceForeign of the CashAtBankDetail
    /// OpenBalanceForeign الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? OpenBalanceForeign { get; private set; }

    /// <summary>
    /// CurrBalL of the CashAtBankDetail
    /// CurrBalL الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? CurrBalL { get; private set; }

    /// <summary>
    /// CurrBalF of the CashAtBankDetail
    /// CurrBalF الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? CurrBalF { get; private set; }

    /// <summary>
    /// InactiveFlag of the CashAtBankDetail
    /// InactiveFlag الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CashAtBankDetail
    /// InactiveDate الخاص بـ CashAtBankDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// MinLimitAmount of the CashAtBankDetail
    /// MinLimitAmount الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? MinLimitAmount { get; private set; }

    /// <summary>
    /// MaxLimitAmount of the CashAtBankDetail
    /// MaxLimitAmount الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? MaxLimitAmount { get; private set; }

    /// <summary>
    /// MaxLimitTransactionAmount of the CashAtBankDetail
    /// MaxLimitTransactionAmount الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? MaxLimitTransactionAmount { get; private set; }

    /// <summary>
    /// MinLimitTransactionAmount of the CashAtBankDetail
    /// MinLimitTransactionAmount الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? MinLimitTransactionAmount { get; private set; }

    /// <summary>
    /// PassportLimit of the CashAtBankDetail
    /// PassportLimit الخاص بـ CashAtBankDetail
    /// </summary>
    public decimal? PassportLimit { get; private set; }

    /// <summary>
    /// BankAccount of the CashAtBankDetail
    /// BankAccount الخاص بـ CashAtBankDetail
    /// </summary>
    public string BankAccount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CashAtBankDetail to GeneralLedgerBankChequeDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerBankChequeDetail> GeneralLedgerBankChequeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CashAtBankDetail to BankAdjustmentDetail
    /// </summary>
    public IReadOnlyCollection<BankAdjustmentDetail> BankAdjustmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CashAtBankDetail to BankAdjustmentMaster
    /// </summary>
    public IReadOnlyCollection<BankAdjustmentMaster> BankAdjustmentMasters { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BankCash
    /// </summary>
    public BankCash BankCash { get; private set; }
    #endregion
}
}
