using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerEditBudgetBalanceDetail Entity
/// </summary>
public class GeneralLedgerEditBudgetBalanceDetail : Entity<GeneralLedgerEditBudgetBalanceDetailId>
{
    private GeneralLedgerEditBudgetBalanceDetail() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerEditBudgetBalanceDetail
    /// المعرف الفريد لـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public GeneralLedgerEditBudgetBalanceDetailId Id { get; private set; }

    /// <summary>
    /// BudgetType of the GeneralLedgerEditBudgetBalanceDetail
    /// BudgetType الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the GeneralLedgerEditBudgetBalanceDetail
    /// BudgetPeriodType الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerEditBudgetBalanceDetail
    /// RecordNumber الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerEditBudgetBalanceDetail
    /// DocNo الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerEditBudgetBalanceDetail
    /// DocSer الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the GeneralLedgerEditBudgetBalanceDetail
    /// PeriodNumberShort الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// FDate of the GeneralLedgerEditBudgetBalanceDetail
    /// FDate الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the GeneralLedgerEditBudgetBalanceDetail
    /// TDate الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerEditBudgetBalanceDetail
    /// AccountCode الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the GeneralLedgerEditBudgetBalanceDetail
    /// AccountCurrency الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerEditBudgetBalanceDetail
    /// CostCenterCode الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerEditBudgetBalanceDetail
    /// ProjectNumber الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerEditBudgetBalanceDetail
    /// ActivityNumber الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AmountLocalAdditional of the GeneralLedgerEditBudgetBalanceDetail
    /// AmountLocalAdditional الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalAdditional { get; private set; }

    /// <summary>
    /// AmountForeignAdditional of the GeneralLedgerEditBudgetBalanceDetail
    /// AmountForeignAdditional الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignAdditional { get; private set; }

    /// <summary>
    /// AmountLocalDiscount of the GeneralLedgerEditBudgetBalanceDetail
    /// AmountLocalDiscount الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AmountLocalDiscount { get; private set; }

    /// <summary>
    /// AmountForeignDiscount of the GeneralLedgerEditBudgetBalanceDetail
    /// AmountForeignDiscount الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AmountForeignDiscount { get; private set; }

    /// <summary>
    /// AccountRate of the GeneralLedgerEditBudgetBalanceDetail
    /// AccountRate الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerEditBudgetBalanceDetail
    /// DocDesc الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerEditBudgetBalanceDetail
    /// DocNoRef الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the GeneralLedgerEditBudgetBalanceDetail
    /// DocSerRef الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerEditBudgetBalanceDetail
    /// CompanyNumberShort الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerEditBudgetBalanceDetail
    /// BranchNumber الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerEditBudgetBalanceDetail
    /// BranchYear الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerEditBudgetBalanceDetail
    /// BranchUser الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerEditBudgetBalanceDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerEditBudgetBalanceDetail
    /// AccountDetailType الخاص بـ GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BudgetBalanceMaster
    /// </summary>
    public BudgetBalanceMaster BudgetBalanceMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public GeneralLedgerEditBudgetBalanceMaster GeneralLedgerEditBudgetBalanceMaster { get; private set; }
    #endregion
}
}
