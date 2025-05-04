using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetBalanceColumnDetail Entity
/// </summary>
public class BudgetBalanceColumnDetail : Entity<BudgetBalanceColumnDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
    private readonly List<BudgetBalanceMaster> _budgetBalanceMaster = new List<BudgetBalanceMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private BudgetBalanceColumnDetail() { }

    public BudgetBalanceColumnDetail(BudgetBalanceColumnDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BudgetBalanceColumnDetail
    /// المعرف الفريد لـ BudgetBalanceColumnDetail
    /// </summary>
    public BudgetBalanceColumnDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the BudgetBalanceColumnDetail
    /// DocNo الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AmountLocal1 of the BudgetBalanceColumnDetail
    /// AmountLocal1 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal1 { get; private set; }

    /// <summary>
    /// AmountLocal2 of the BudgetBalanceColumnDetail
    /// AmountLocal2 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal2 { get; private set; }

    /// <summary>
    /// AmountLocal3 of the BudgetBalanceColumnDetail
    /// AmountLocal3 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal3 { get; private set; }

    /// <summary>
    /// AmountLocal4 of the BudgetBalanceColumnDetail
    /// AmountLocal4 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal4 { get; private set; }

    /// <summary>
    /// AmountLocal5 of the BudgetBalanceColumnDetail
    /// AmountLocal5 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal5 { get; private set; }

    /// <summary>
    /// AmountLocal6 of the BudgetBalanceColumnDetail
    /// AmountLocal6 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal6 { get; private set; }

    /// <summary>
    /// AmountLocal7 of the BudgetBalanceColumnDetail
    /// AmountLocal7 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal7 { get; private set; }

    /// <summary>
    /// AmountLocal8 of the BudgetBalanceColumnDetail
    /// AmountLocal8 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal8 { get; private set; }

    /// <summary>
    /// AmountLocal9 of the BudgetBalanceColumnDetail
    /// AmountLocal9 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal9 { get; private set; }

    /// <summary>
    /// AmountLocal10 of the BudgetBalanceColumnDetail
    /// AmountLocal10 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal10 { get; private set; }

    /// <summary>
    /// AmountLocal11 of the BudgetBalanceColumnDetail
    /// AmountLocal11 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal11 { get; private set; }

    /// <summary>
    /// AmountLocal12 of the BudgetBalanceColumnDetail
    /// AmountLocal12 الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AmountLocal12 { get; private set; }

    /// <summary>
    /// DocDesc of the BudgetBalanceColumnDetail
    /// DocDesc الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNoRef of the BudgetBalanceColumnDetail
    /// DocNoRef الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BudgetBalanceColumnDetail
    /// DocSerRef الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BudgetBalanceColumnDetail
    /// CompanyNumberShort الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BudgetBalanceColumnDetail
    /// BranchNumber الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BudgetBalanceColumnDetail
    /// BranchYear الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BudgetBalanceColumnDetail
    /// BranchUser الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RecordNumber of the BudgetBalanceColumnDetail
    /// RecordNumber الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BudgetType of the BudgetBalanceColumnDetail
    /// BudgetType الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the BudgetBalanceColumnDetail
    /// BudgetPeriodType الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BudgetBalanceColumnDetail
    /// AccountDetailCode الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BudgetBalanceColumnDetail
    /// AccountDetailType الخاص بـ BudgetBalanceColumnDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ExchangeRate> ExchangeRate => _exchangeRate;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<BudgetBalanceMaster> BudgetBalanceMaster => _budgetBalanceMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
