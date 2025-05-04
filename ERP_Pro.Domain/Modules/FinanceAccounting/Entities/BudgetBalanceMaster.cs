using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetBalanceMaster Entity
/// </summary>
public class BudgetBalanceMaster : Entity<BudgetBalanceMasterId>
{

    private BudgetBalanceMaster() { }

    public BudgetBalanceMaster(BudgetBalanceMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the BudgetBalanceMaster
    /// المعرف الفريد لـ BudgetBalanceMaster
    /// </summary>
    public BudgetBalanceMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the BudgetBalanceMaster
    /// DocNo الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BudgetBalanceMaster
    /// DocSer الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BudgetBalanceMaster
    /// DocDate الخاص بـ BudgetBalanceMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the BudgetBalanceMaster
    /// DocDesc الخاص بـ BudgetBalanceMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DocNote of the BudgetBalanceMaster
    /// DocNote الخاص بـ BudgetBalanceMaster
    /// </summary>
    public string DocNote { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BudgetBalanceMaster
    /// ReferenceNumber الخاص بـ BudgetBalanceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BudgetPeriodType of the BudgetBalanceMaster
    /// BudgetPeriodType الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// BudgetType of the BudgetBalanceMaster
    /// BudgetType الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// ApprovedFlag of the BudgetBalanceMaster
    /// ApprovedFlag الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the BudgetBalanceMaster
    /// ApprovalUserId الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the BudgetBalanceMaster
    /// ApprovalDate الخاص بـ BudgetBalanceMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the BudgetBalanceMaster
    /// ApprovalDescription الخاص بـ BudgetBalanceMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// DocNoRef of the BudgetBalanceMaster
    /// DocNoRef الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the BudgetBalanceMaster
    /// DocSerRef الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// Dflt of the BudgetBalanceMaster
    /// Dflt الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? Dflt { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BudgetBalanceMaster
    /// CompanyNumberShort الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BudgetBalanceMaster
    /// BranchNumber الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BudgetBalanceMaster
    /// BranchYear الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BudgetBalanceMaster
    /// BranchUser الخاص بـ BudgetBalanceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
