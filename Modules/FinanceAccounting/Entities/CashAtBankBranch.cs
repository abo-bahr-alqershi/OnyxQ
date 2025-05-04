using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashAtBankBranch Entity
/// </summary>
public class CashAtBankBranch : Entity<CashAtBankBranchId>
{
    private CashAtBankBranch() { }

    /// <summary>
    /// The unique identifier for the CashAtBankBranch
    /// المعرف الفريد لـ CashAtBankBranch
    /// </summary>
    public CashAtBankBranchId Id { get; private set; }

    /// <summary>
    /// BranchBankNumber of the CashAtBankBranch
    /// BranchBankNumber الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// BankNumber of the CashAtBankBranch
    /// BankNumber الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// AccountCode of the CashAtBankBranch
    /// AccountCode الخاص بـ CashAtBankBranch
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// OpenBalanceLocal of the CashAtBankBranch
    /// OpenBalanceLocal الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? OpenBalanceLocal { get; private set; }

    /// <summary>
    /// OpenBalanceForeign of the CashAtBankBranch
    /// OpenBalanceForeign الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? OpenBalanceForeign { get; private set; }

    /// <summary>
    /// CurrBalL of the CashAtBankBranch
    /// CurrBalL الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? CurrBalL { get; private set; }

    /// <summary>
    /// CurrBalF of the CashAtBankBranch
    /// CurrBalF الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? CurrBalF { get; private set; }

    /// <summary>
    /// InactiveFlag of the CashAtBankBranch
    /// InactiveFlag الخاص بـ CashAtBankBranch
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CashAtBankBranch
    /// InactiveDate الخاص بـ CashAtBankBranch
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to BankCash
    /// </summary>
    public BankCash BankCash { get; private set; }
    #endregion
}
}
