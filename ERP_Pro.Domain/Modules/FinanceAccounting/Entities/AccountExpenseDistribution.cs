using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountExpenseDistribution Entity
/// </summary>
public class AccountExpenseDistribution : Entity<AccountExpenseDistributionId>
{

    private AccountExpenseDistribution() { }

    public AccountExpenseDistribution(AccountExpenseDistributionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountExpenseDistribution
    /// المعرف الفريد لـ AccountExpenseDistribution
    /// </summary>
    public AccountExpenseDistributionId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountExpenseDistribution
    /// RecordNumber الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// AccountCode of the AccountExpenseDistribution
    /// AccountCode الخاص بـ AccountExpenseDistribution
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountExpenseDistribution
    /// CostCenterCode الخاص بـ AccountExpenseDistribution
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountExpenseDistribution
    /// ProjectNumber الخاص بـ AccountExpenseDistribution
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountExpenseDistribution
    /// ActivityNumber الخاص بـ AccountExpenseDistribution
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ExpensePercent of the AccountExpenseDistribution
    /// ExpensePercent الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? ExpensePercent { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountExpenseDistribution
    /// CompanyNumberShort الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountExpenseDistribution
    /// BranchNumber الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountExpenseDistribution
    /// BranchYear الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountExpenseDistribution
    /// BranchUser الخاص بـ AccountExpenseDistribution
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
