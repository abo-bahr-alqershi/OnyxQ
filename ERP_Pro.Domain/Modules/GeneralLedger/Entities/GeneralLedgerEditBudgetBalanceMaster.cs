using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerEditBudgetBalanceMaster Entity
/// </summary>
public class GeneralLedgerEditBudgetBalanceMaster : AggregateRoot<GeneralLedgerEditBudgetBalanceMasterId>
{

    private GeneralLedgerEditBudgetBalanceMaster() { }

    public GeneralLedgerEditBudgetBalanceMaster(GeneralLedgerEditBudgetBalanceMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerEditBudgetBalanceMaster
    /// المعرف الفريد لـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public GeneralLedgerEditBudgetBalanceMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerEditBudgetBalanceMaster
    /// DocNo الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerEditBudgetBalanceMaster
    /// DocSer الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerEditBudgetBalanceMaster
    /// DocDate الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerEditBudgetBalanceMaster
    /// DocDesc الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNote of the GeneralLedgerEditBudgetBalanceMaster
    /// DocNote الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public string DocNote { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerEditBudgetBalanceMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the GeneralLedgerEditBudgetBalanceMaster
    /// BudgetPeriodType الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerEditBudgetBalanceMaster
    /// DocNoRef الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GeneralLedgerEditBudgetBalanceMaster
    /// ApprovedFlag الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GeneralLedgerEditBudgetBalanceMaster
    /// ApprovalUserId الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GeneralLedgerEditBudgetBalanceMaster
    /// ApprovalDate الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GeneralLedgerEditBudgetBalanceMaster
    /// ApprovalDescription الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerEditBudgetBalanceMaster
    /// CompanyNumberShort الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerEditBudgetBalanceMaster
    /// BranchNumber الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerEditBudgetBalanceMaster
    /// BranchYear الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerEditBudgetBalanceMaster
    /// BranchUser الخاص بـ GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BudgetBalanceMaster BudgetBalanceMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

