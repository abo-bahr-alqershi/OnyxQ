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
    private BudgetBalanceDetail() { }

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
    /// DocSer of the BudgetBalanceDetail
    /// DocSer الخاص بـ BudgetBalanceDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

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
    /// AccountCode of the BudgetBalanceDetail
    /// AccountCode الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BudgetBalanceDetail
    /// AccountCurrency الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the BudgetBalanceDetail
    /// CostCenterCode الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BudgetBalanceDetail
    /// ProjectNumber الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BudgetBalanceDetail
    /// ActivityNumber الخاص بـ BudgetBalanceDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    #endregion
}
}
