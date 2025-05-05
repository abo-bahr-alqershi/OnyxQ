using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerMoveBudgetMaster Entity
/// </summary>
public class GeneralLedgerMoveBudgetMaster : AggregateRoot<GeneralLedgerMoveBudgetMasterId>
{

    private GeneralLedgerMoveBudgetMaster() { }

    public GeneralLedgerMoveBudgetMaster(GeneralLedgerMoveBudgetMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerMoveBudgetMaster
    /// المعرف الفريد لـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public GeneralLedgerMoveBudgetMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerMoveBudgetMaster
    /// DocNo الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerMoveBudgetMaster
    /// DocSer الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerMoveBudgetMaster
    /// DocDate الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerMoveBudgetMaster
    /// DocDesc الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNote of the GeneralLedgerMoveBudgetMaster
    /// DocNote الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string DocNote { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerMoveBudgetMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the GeneralLedgerMoveBudgetMaster
    /// BudgetPeriodType الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the GeneralLedgerMoveBudgetMaster
    /// PeriodNumberShort الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerMoveBudgetMaster
    /// AccountCode الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerMoveBudgetMaster
    /// CostCenterCode الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerMoveBudgetMaster
    /// ProjectNumber الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerMoveBudgetMaster
    /// ActivityNumber الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the GeneralLedgerMoveBudgetMaster
    /// AccountCurrency الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the GeneralLedgerMoveBudgetMaster
    /// AccountRate الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// BudgetMovementType of the GeneralLedgerMoveBudgetMaster
    /// BudgetMovementType الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? BudgetMovementType { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerMoveBudgetMaster
    /// AmountLocal الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerMoveBudgetMaster
    /// AmountForeign الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerMoveBudgetMaster
    /// DocNoRef الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the GeneralLedgerMoveBudgetMaster
    /// DocSerRef الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GeneralLedgerMoveBudgetMaster
    /// ApprovedFlag الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GeneralLedgerMoveBudgetMaster
    /// ApprovalUserId الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GeneralLedgerMoveBudgetMaster
    /// ApprovalDate الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GeneralLedgerMoveBudgetMaster
    /// ApprovalDescription الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerMoveBudgetMaster
    /// DocBrnNo الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerMoveBudgetMaster
    /// CompanyNumberShort الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerMoveBudgetMaster
    /// BranchNumber الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerMoveBudgetMaster
    /// BranchYear الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerMoveBudgetMaster
    /// BranchUser الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerMoveBudgetMaster
    /// AccountDetailCode الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerMoveBudgetMaster
    /// AccountDetailType الخاص بـ GeneralLedgerMoveBudgetMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

