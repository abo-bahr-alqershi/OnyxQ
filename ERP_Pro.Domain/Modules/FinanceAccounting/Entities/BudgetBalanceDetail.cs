using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetBalanceDetail Entity
/// </summary>
public class BudgetBalanceDetail : Entity<BudgetBalanceDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Account> _account = new List<Account>();
    private readonly List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
    private readonly List<BudgetBalanceMaster> _budgetBalanceMaster = new List<BudgetBalanceMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private BudgetBalanceDetail() { }

    public BudgetBalanceDetail(BudgetBalanceDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BudgetBalanceDetail
    /// المعرف الفريد لـ BudgetBalanceDetail
    /// </summary>
    public BudgetBalanceDetailId Id { get; private set; }

    /// <summary>
    /// BudgetType of the BudgetBalanceDetail
    /// BudgetType الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the BudgetBalanceDetail
    /// BudgetPeriodType الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// RecordNumber of the BudgetBalanceDetail
    /// RecordNumber الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocNo of the BudgetBalanceDetail
    /// DocNo الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the BudgetBalanceDetail
    /// PeriodNumberShort الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// FDate of the BudgetBalanceDetail
    /// FDate الخاص بـ BudgetBalanceDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the BudgetBalanceDetail
    /// TDate الخاص بـ BudgetBalanceDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// AmountLocal of the BudgetBalanceDetail
    /// AmountLocal الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the BudgetBalanceDetail
    /// AmountForeign الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// AmountLocalAdditionalMovement of the BudgetBalanceDetail
    /// AmountLocalAdditionalMovement الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalAdditionalMovement { get; private set; }

    /// <summary>
    /// AmountForeignAdditionalMovement of the BudgetBalanceDetail
    /// AmountForeignAdditionalMovement الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignAdditionalMovement { get; private set; }

    /// <summary>
    /// AmountLocalDiscountMovement of the BudgetBalanceDetail
    /// AmountLocalDiscountMovement الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalDiscountMovement { get; private set; }

    /// <summary>
    /// AmountForeignDiscountMovement of the BudgetBalanceDetail
    /// AmountForeignDiscountMovement الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignDiscountMovement { get; private set; }

    /// <summary>
    /// AccountRate of the BudgetBalanceDetail
    /// AccountRate الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// DocDesc of the BudgetBalanceDetail
    /// DocDesc الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNoRef of the BudgetBalanceDetail
    /// DocNoRef الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BudgetBalanceDetail
    /// DocSerRef الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BudgetBalanceDetail
    /// CompanyNumberShort الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BudgetBalanceDetail
    /// BranchNumber الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BudgetBalanceDetail
    /// BranchYear الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BudgetBalanceDetail
    /// BranchUser الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BudgetBalanceDetail
    /// AccountDetailCode الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BudgetBalanceDetail
    /// AccountDetailType الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AmountLocalAdditional of the BudgetBalanceDetail
    /// AmountLocalAdditional الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalAdditional { get; private set; }

    /// <summary>
    /// AmountForeignAdditional of the BudgetBalanceDetail
    /// AmountForeignAdditional الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignAdditional { get; private set; }

    /// <summary>
    /// AmountLocalDiscount of the BudgetBalanceDetail
    /// AmountLocalDiscount الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalDiscount { get; private set; }

    /// <summary>
    /// AmountForeignDiscount of the BudgetBalanceDetail
    /// AmountForeignDiscount الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignDiscount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
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
