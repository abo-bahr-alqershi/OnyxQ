using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetBalanceMaster Entity
/// </summary>
public class BudgetBalanceMaster : Entity<BudgetBalanceMasterId>
{
    private BudgetBalanceMaster() { }

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
    /// AccountCurrency of the BudgetBalanceMaster
    /// AccountCurrency الخاص بـ BudgetBalanceMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

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
    /// One-to-many relationship: BudgetBalanceMaster to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: BudgetBalanceMaster to GeneralLedgerEditBudgetBalanceMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceMaster> GeneralLedgerEditBudgetBalanceMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: BudgetBalanceMaster to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: BudgetBalanceMaster to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion
}
}
