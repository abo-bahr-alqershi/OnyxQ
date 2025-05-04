using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountCostCenterLimit Entity
/// </summary>
public class AccountCostCenterLimit : Entity<AccountCostCenterLimitId>
{
    private AccountCostCenterLimit() { }

    /// <summary>
    /// The unique identifier for the AccountCostCenterLimit
    /// المعرف الفريد لـ AccountCostCenterLimit
    /// </summary>
    public AccountCostCenterLimitId Id { get; private set; }

    /// <summary>
    /// AccountCode of the AccountCostCenterLimit
    /// AccountCode الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountCostCenterLimit
    /// AccountCurrency الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountCostCenterLimit
    /// CostCenterCode الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountCostCenterLimit
    /// ProjectNumber الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountCostCenterLimit
    /// ActivityNumber الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// MinAmount of the AccountCostCenterLimit
    /// MinAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MinAmount { get; private set; }

    /// <summary>
    /// MaxAmount of the AccountCostCenterLimit
    /// MaxAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxAmount { get; private set; }

    /// <summary>
    /// MinTransactionAmount of the AccountCostCenterLimit
    /// MinTransactionAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MinTransactionAmount { get; private set; }

    /// <summary>
    /// MaxTransactionAmount of the AccountCostCenterLimit
    /// MaxTransactionAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxTransactionAmount { get; private set; }

    /// <summary>
    /// MaxLimitPercent of the AccountCostCenterLimit
    /// MaxLimitPercent الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxLimitPercent { get; private set; }

    /// <summary>
    /// MaxLimitPossible of the AccountCostCenterLimit
    /// MaxLimitPossible الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxLimitPossible { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountCostCenterLimit
    /// BranchNumber الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ExceedLimit of the AccountCostCenterLimit
    /// ExceedLimit الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? ExceedLimit { get; private set; }

    /// <summary>
    /// DrCr of the AccountCostCenterLimit
    /// DrCr الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? DrCr { get; private set; }

    /// <summary>
    /// LimitDescription of the AccountCostCenterLimit
    /// LimitDescription الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string LimitDescription { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AccountCostCenterLimit
    /// AccountDetailCode الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountCostCenterLimit
    /// AccountDetailType الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// FacilityAmount of the AccountCostCenterLimit
    /// FacilityAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? FacilityAmount { get; private set; }

    /// <summary>
    /// FacilityStatus of the AccountCostCenterLimit
    /// FacilityStatus الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? FacilityStatus { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountCostCenterLimit
    /// InactiveFlag الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// DalyAmt of the AccountCostCenterLimit
    /// DalyAmt الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? DalyAmt { get; private set; }

    /// <summary>
    /// MonthlyAmount of the AccountCostCenterLimit
    /// MonthlyAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MonthlyAmount { get; private set; }

    /// <summary>
    /// AnnualAmount of the AccountCostCenterLimit
    /// AnnualAmount الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? AnnualAmount { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the AccountCostCenterLimit
    /// AccountDetailSubCode الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AccountCostCenterLimit
    /// ExternalPostFlag الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
