using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerMoveBudgetDetail Entity
/// </summary>
public class GeneralLedgerMoveBudgetDetail : Entity<GeneralLedgerMoveBudgetDetailId>
{
    private GeneralLedgerMoveBudgetDetail() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerMoveBudgetDetail
    /// المعرف الفريد لـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public GeneralLedgerMoveBudgetDetailId Id { get; private set; }

    /// <summary>
    /// BudgetType of the GeneralLedgerMoveBudgetDetail
    /// BudgetType الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the GeneralLedgerMoveBudgetDetail
    /// BudgetPeriodType الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerMoveBudgetDetail
    /// RecordNumber الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerMoveBudgetDetail
    /// DocNo الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerMoveBudgetDetail
    /// DocSer الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// FDate of the GeneralLedgerMoveBudgetDetail
    /// FDate الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the GeneralLedgerMoveBudgetDetail
    /// TDate الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the GeneralLedgerMoveBudgetDetail
    /// PeriodNumberShort الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerMoveBudgetDetail
    /// AccountCode الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the GeneralLedgerMoveBudgetDetail
    /// AccountCurrency الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerMoveBudgetDetail
    /// CostCenterCode الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerMoveBudgetDetail
    /// ProjectNumber الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerMoveBudgetDetail
    /// ActivityNumber الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerMoveBudgetDetail
    /// AmountLocal الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerMoveBudgetDetail
    /// AmountForeign الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// AccountRate of the GeneralLedgerMoveBudgetDetail
    /// AccountRate الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerMoveBudgetDetail
    /// DocDesc الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerMoveBudgetDetail
    /// DocNoRef الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the GeneralLedgerMoveBudgetDetail
    /// DocSerRef الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerMoveBudgetDetail
    /// DocBrnNo الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerMoveBudgetDetail
    /// CompanyNumberShort الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerMoveBudgetDetail
    /// BranchNumber الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerMoveBudgetDetail
    /// BranchYear الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerMoveBudgetDetail
    /// BranchUser الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerMoveBudgetDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerMoveBudgetDetail
    /// AccountDetailType الخاص بـ GeneralLedgerMoveBudgetDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerMoveBudgetMaster
    /// </summary>
    public GeneralLedgerMoveBudgetMaster GeneralLedgerMoveBudgetMaster { get; private set; }
    #endregion
}
}
